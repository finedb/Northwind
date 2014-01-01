using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;
// ポイント プロパティウィンドウでDataGridViewをバインディングしてはいけない
namespace Northwind {
  public partial class OrdersForm_DIY : Form {
    public OrdersForm_DIY() {
      InitializeComponent();
    }


    private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
      EndEditsOnBindingSources();

      // DataSet.Copyを使用してセーブポイントを作成する。

      // 変更を反映しようとして失敗したら、

      //   トランザクションをロールバックし、ユーザーに
      //   変更を反映する前の状態に変更を戻したいかどう

      //   かを尋ねる。


      DataSet dataSetSavePoint = this.northwindDataSet.Copy();
      try {
        int numberOfChangesSubmitted = 0;
        using (TransactionScope txn = new TransactionScope()) {
          // 明示的に接続を開く。

          // そうしないと、TableAdapter.Updateの呼出しが暗示的に
          //   接続を開いたり閉じたりし、その結果SQL Serverトラン
          //   ザクションがローカルトランザクションから分散トラン
          //   ザクションになってしまう。

          try {
            this.connection.Open();
          } catch (Exception openFailedException) {
            MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return;
          }

          // 挿入と更新の反映はトップダウン、削除はボトムアップで行う。

          // 関係するテーブルはOrdersおよびOrder Detailsだけ。


          DataRow[] rowsToSubmit;
          // 新規注文および注文変更を反映する。

          rowsToSubmit = this.northwindDataSet.Orders.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
          if (rowsToSubmit.Length != 0)
            numberOfChangesSubmitted += this.ordersTableAdapter.Update(rowsToSubmit);

          // 新規注文詳細および注文詳細変更を反映する。

          rowsToSubmit = this.northwindDataSet.Order_Details.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
          if (rowsToSubmit.Length != 0)
            numberOfChangesSubmitted += this.order_DetailsTableAdapter.Update(rowsToSubmit);

          // 注文詳細の削除を反映する。

          rowsToSubmit = this.northwindDataSet.Order_Details.Select("", "", DataViewRowState.Deleted);
          if (rowsToSubmit.Length != 0)
            numberOfChangesSubmitted += this.order_DetailsTableAdapter.Update(rowsToSubmit);

          // 注文の削除を反映する。

          rowsToSubmit = this.northwindDataSet.Orders.Select("", "", DataViewRowState.Deleted);
          if (rowsToSubmit.Length != 0)
            numberOfChangesSubmitted += this.ordersTableAdapter.Update(rowsToSubmit);

          if (numberOfChangesSubmitted == 0) {
            MessageBox.Show("反映する変更がありません。", "処理なし");
            return;
          }

          if (MessageBox.Show("ニセ例外を発生させて、データベースの変更をロールバックしますか？", "変更の反映に成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
            throw new Exception("ニセ例外発生");
          }

          txn.Complete();
        }
        MessageBox.Show(string.Format("{0} 個の変更を正常に反映しました。", numberOfChangesSubmitted), "保存に成功");
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "更新に失敗しました。", MessageBoxButtons.OK, MessageBoxIcon.Error);
        if (MessageBox.Show("保留状態の変更を復元しますか？", "更新失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
          this.northwindDataSet.Clear();
          this.northwindDataSet.Merge(dataSetSavePoint);
        }
      } finally {
        connection.Close();
      }

      this.ShowCurrentOrder();
    }

    public static Color READ_ONLY_COLOR = Color.Gray;
    public static Color READ_WRITE_COLOR = Color.Black;
    public static string NULL_VALUE = "<Null>";

    SqlConnection connection = null;
    DataView ordersView = null;
    DataView detailsView = null;
    int currentOrderPosition = 0;
    BindingSource employeesBindingSource = null;
    BindingSource detailsBindingSource = null;
    private void OrdersForm_DIY_Load_1(object sender, EventArgs e) {
      this.orderIDTextBox.ForeColor = READ_ONLY_COLOR;
      this.orderTotalTextBox.ForeColor = READ_ONLY_COLOR;

      // すべてのTableAdapterが同一の接続を使用するようにする。

      this.connection = this.productsTableAdapter.Connection;
      this.employeesTableAdapter.Connection = this.connection;
      this.productsTableAdapter.Connection = this.connection;
      this.ordersTableAdapter.Connection = this.connection;
      this.order_DetailsTableAdapter.Connection = this.connection;

      // 接続を開く。

      // そうしないと、TableAdapterはFillを呼び出すたびに暗示的に
      //   接続を開いたり閉じたりしてしまう。

      try {
        this.connection.Open();
      } catch (Exception openFailedException) {
        MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return;
      }

      // すべての商品情報と従業員情報を取得する。

      this.productsTableAdapter.Fill(this.northwindDataSet.Products);
      this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

      // 特定の顧客だけの注文情報を取得する。

      string customerID = "ALFKI";
      this.ordersTableAdapter.FillByCustomerID(this.northwindDataSet.Orders, customerID);
      this.order_DetailsTableAdapter.FillByCustomerID(this.northwindDataSet.Order_Details, customerID);

      // 接続を閉じる。

      this.connection.Close();


      this.MinimumSize = this.Size;




      this.detailsBindingSource = new BindingSource();
      order_DetailsDetaGridView.DataMember = "";
      this.order_DetailsDetaGridView.DataSource = this.detailsBindingSource;
      this.employeesBindingSource = new BindingSource(this.northwindDataSet.Employees, "");
      this.employeeIDComboBox.DataSource = this.employeesBindingSource;
      this.employeeIDComboBox.DisplayMember = "EmployeeName";
      this.employeeIDComboBox.ValueMember = "EmployeeID";

      this.ordersView = new DataView(this.northwindDataSet.Orders);
      this.currentOrderPosition = 0;
      //this.currentOrder = (NorthwindDataSet.OrdersRow) this.ordersView[this.currentOrderPosition].Row;
      ShowCurrentOrder();

      //this.order_DetailsDetaGridView.Columns["OrderID"].Visible = false;
      //this.order_DetailsDetaGridView.Columns["ProductID"].Visible = false;

      this.SetOrderEditMode(false);
    }

    NorthwindDataSet.OrdersRow currentOrder;
    private void ShowCurrentOrder() {
      this.currentOrder = (NorthwindDataSet.OrdersRow)this.ordersView[this.currentOrderPosition].Row;

      this.orderIDTextBox.Text = currentOrder.OrderID.ToString();

      if (this.currentOrder.IsCustomerIDNull())
        this.customerIDTextBox.Text = NULL_VALUE;
      else
        this.customerIDTextBox.Text = this.currentOrder.CustomerID;

      if (currentOrder.IsEmployeeIDNull())
        this.employeeIDComboBox.SelectedIndex = -1;
      else
        this.employeeIDComboBox.SelectedValue = currentOrder.EmployeeID;

      if (currentOrder.IsOrderDateNull())
        this.orderDateTextBox.Text = NULL_VALUE;
      else
        this.orderDateTextBox.Text = currentOrder.OrderDate.ToShortDateString();

      if (currentOrder.IsOrderTotalNull())
        this.orderTotalTextBox.Text = NULL_VALUE;
      else
        this.orderTotalTextBox.Text = currentOrder.OrderTotal.ToString("c");

      this.bindingNavigatorCountItem.Text = string.Format(" of {0}", this.ordersView.Count);
      this.bindingNavigatorPositionItem.Text = (this.currentOrderPosition + 1).ToString();

      this.detailsView = ordersView[this.currentOrderPosition].CreateChildView("FK_Order_Details_Orders");
      this.detailsBindingSource.DataSource = this.detailsView;

      bool isOrderAvailable = this.ordersView.Count != 0; // true; //= this.ordersBindingSource.Count != 0;
      this.bindingNavigatorDeleteItem.Enabled = isOrderAvailable;
      this.ordersBindingNavigatorEditItem.Enabled = isOrderAvailable;

      bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
      this.orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
      this.orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
    }

    private void UpdateCurrentOrder() {
      NorthwindDataSet.OrdersRow currentOrder;
      currentOrder = (NorthwindDataSet.OrdersRow)this.ordersView[this.currentOrderPosition].Row;

      if (this.customerIDTextBox.Text == NULL_VALUE) {
        if (!currentOrder.IsCustomerIDNull())
          currentOrder.SetCustomerIDNull();
      } else {
        string customerID = this.customerIDTextBox.Text;
        if (currentOrder.IsCustomerIDNull() ||
            customerID != currentOrder.CustomerID)
          currentOrder.CustomerID = customerID;
      }

      if (this.employeeIDComboBox.SelectedIndex == -1) {
        if (!currentOrder.IsEmployeeIDNull())
          currentOrder.SetEmployeeIDNull();
      } else {
        int employeeID = (int)this.employeeIDComboBox.SelectedValue;
        if (currentOrder.IsEmployeeIDNull() ||
            employeeID != currentOrder.EmployeeID)
          currentOrder.EmployeeID = employeeID;
      }

      if (this.orderDateTextBox.Text == NULL_VALUE) {
        if (!currentOrder.IsOrderDateNull())
          currentOrder.SetOrderDateNull();
      } else {
        DateTime orderDate = DateTime.Today;
        if (DateTime.TryParse(this.orderDateTextBox.Text, out orderDate)
            && (currentOrder.IsOrderDateNull() || orderDate != currentOrder.OrderDate))
          currentOrder.OrderDate = orderDate;
      }
    }

    bool isEditingOrder = false;
    private void SetOrderEditMode(Boolean IsEditing) {
      this.isEditingOrder = IsEditing;
      Color fontColor;
      if (IsEditing)
        fontColor = READ_WRITE_COLOR;
      else
        fontColor = READ_ONLY_COLOR;

      this.bindingNavigatorMoveFirstItem.Enabled = !IsEditing;
      this.bindingNavigatorMovePreviousItem.Enabled = !IsEditing;
      this.bindingNavigatorMoveNextItem.Enabled = !IsEditing;
      this.bindingNavigatorMoveLastItem.Enabled = !IsEditing;
      this.bindingNavigatorPositionItem.Enabled = !IsEditing;

      this.bindingNavigatorAddNewItem.Enabled = !IsEditing;
      this.bindingNavigatorDeleteItem.Enabled = !IsEditing;

      this.ordersBindingNavigatorEditItem.Enabled = !IsEditing;
      this.ordersBindingNavigatorAcceptItem.Enabled = IsEditing;
      this.ordersBindingNavigatorRejectItem.Enabled = IsEditing;

      this.ordersBindingNavigatorSaveItem.Enabled = !IsEditing;

      this.customerIDTextBox.ReadOnly = !IsEditing;
      this.customerIDTextBox.ForeColor = fontColor;
      this.orderDateTextBox.ReadOnly = !IsEditing;
      this.orderDateTextBox.ForeColor = fontColor;
      this.employeeIDComboBox.Enabled = IsEditing;

      this.orderDetailsAddButton.Enabled = !IsEditing;
      this.orderDetailsEditButton.Enabled = !IsEditing && CanEnableOrderDetailsEditAndDelete();
      this.orderDetailsDeleteButton.Enabled = !IsEditing && CanEnableOrderDetailsEditAndDelete();
    }

    private void ordersBindingNavigatorEditItem_Click(object sender, EventArgs e) {
      this.SetOrderEditMode(true);
      this.customerIDTextBox.Focus();
    }

    private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
      //currentOrder = ((NorthwindDataSet.OrdersDataTable) this.ordersView.Table).NewOrdersRow();

      currentOrder = (NorthwindDataSet.OrdersRow)this.ordersView.AddNew().Row;
      currentOrder.OrderDate = DateTime.Today;

      this.currentOrderPosition = this.ordersView.Count - 1;
      this.ShowCurrentOrder();
      this.SetOrderEditMode(true);

      this.customerIDTextBox.Focus();
      order_DetailsDetaGridView.Refresh();
    }

    private void ordersBindingNavigatorAcceptItem_Click(object sender, EventArgs e) {
      UpdateCurrentOrder();

      if (this.currentOrder.RowState == DataRowState.Detached)
        this.ordersView[this.ordersView.Count - 1].EndEdit();

      ShowCurrentOrder();
      this.SetOrderEditMode(false);
    }

    private void ordersBindingNavigatorRejectItem_Click(object sender, EventArgs e) {
      if (this.currentOrder.RowState == DataRowState.Detached) {
        this.ordersView[this.ordersView.Count - 1].CancelEdit();
        this.currentOrderPosition = this.ordersView.Count - 1;
      }

      ShowCurrentOrder();
      this.SetOrderEditMode(false);

      bool isOrderAvailable = this.ordersView.Count != 0;
      this.bindingNavigatorDeleteItem.Enabled = isOrderAvailable;
      this.ordersBindingNavigatorEditItem.Enabled = isOrderAvailable;
    }

    private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
      DialogResult result;
      result = MessageBox.Show("本当にこの注文を削除しますか？",
                          "確認ダイアログ", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes) {
        this.ordersView.Delete(this.currentOrderPosition);
        if (this.currentOrderPosition == this.ordersView.Count)
          this.currentOrderPosition = this.ordersView.Count - 1;
        ShowCurrentOrder();
      }
    }

    private bool ConfirmDeletion(string ItemType) {
      return (MessageBox.Show(string.Format("本当にこの{0}を削除しますか？", ItemType), "削除確認", MessageBoxButtons.YesNo) == DialogResult.Yes);
    }

    private void orderDetailsEditButton_Click(object sender, EventArgs e) {
      using (DetailForm_DIY detailForm = new DetailForm_DIY()) {
        DataRowView currentDetailRowView = (DataRowView)this.detailsBindingSource.Current;
        NorthwindDataSet.Order_DetailsRow currentDetailRow = (NorthwindDataSet.Order_DetailsRow)currentDetailRowView.Row;
        detailForm.EditDetail(currentDetailRow);
      }
    }

    private void orderDetailsAddButton_Click(object sender, EventArgs e) {
      DataRowView currentDetailRowView = (DataRowView)this.detailsBindingSource.AddNew();
      NorthwindDataSet.Order_DetailsRow currentDetailRow = (NorthwindDataSet.Order_DetailsRow)currentDetailRowView.Row;
      currentDetailRow.Quantity = 1;
      NorthwindDataSet.ProductsRow productRow = this.northwindDataSet.Products[0];
      currentDetailRow.ProductID = productRow.ProductID;
      currentDetailRow.UnitPrice = productRow.UnitPrice;
      currentDetailRow.ItemTotal = productRow.UnitPrice;

      using (DetailForm_DIY detailForm = new DetailForm_DIY()) {
        if (detailForm.EditDetail(currentDetailRow))
          this.detailsBindingSource.EndEdit();
        else
          this.detailsBindingSource.CancelEdit();
      }
    }

    private void orderDetailsDeleteButton_Click(object sender, EventArgs e) {
      if (ConfirmDeletion("注文詳細"))
        this.detailsBindingSource.RemoveCurrent();
    }

    private bool CanEnableOrderDetailsEditAndDelete() {
      if (detailsBindingSource == null)
      return  true;
      else
      return !isEditingOrder && !(this.detailsBindingSource.Count == 0);
    }

    private void order_DetailsBindingSource_PositionChanged(object sender, EventArgs e) {
      bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
      this.orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
      this.orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
    }

    private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e) {
      EndEditsOnBindingSources();

      if (this.northwindDataSet.HasChanges())
        if (MessageBox.Show("このフォームには保留状態の変更があります。" +
          "フォームを閉じると保留状態の変更は破棄されます。\n\r" +
          "本当にフォームを閉じますか？", "確認ダイアログ",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          e.Cancel = true;
    }

    private void EndEditsOnBindingSources() {
      this.Validate();
    }

    #region ナビゲーション
    private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e) {
      this.currentOrderPosition = 0;
      this.ShowCurrentOrder();
    }

    private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e) {
      if (this.currentOrderPosition > 0)
        this.currentOrderPosition--;
      this.ShowCurrentOrder();
    }

    private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {
      if (this.currentOrderPosition < (this.ordersView.Count - 1))
        this.currentOrderPosition++;
      this.ShowCurrentOrder();
    }

    private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e) {
      if (this.currentOrderPosition < (this.ordersView.Count - 1))
        this.currentOrderPosition = this.ordersView.Count - 1;
      this.ShowCurrentOrder();
    }

    private void bindingNavigatorPositionItem_Leave(object sender, EventArgs e) {
      int newPosition;
      if (int.TryParse(this.bindingNavigatorPositionItem.Text, out newPosition)) {
        if (newPosition > 0 && newPosition <= this.ordersView.Count) {
          this.currentOrderPosition = newPosition - 1;
          this.ShowCurrentOrder();
          return;
        }
      }
    #endregion

      this.bindingNavigatorPositionItem.Text = (this.currentOrderPosition + 1).ToString();
      MessageBox.Show(string.Format("1～{0}の値を入力してください。", this.ordersView.Count), "無効な位置", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
