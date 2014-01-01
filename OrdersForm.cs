//#define WHERE
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;

namespace Northwind {
  public partial class OrdersForm : Form {

    public OrdersForm() {
      InitializeComponent();
    }


    #region 保存ボタン
    private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e) {

      EndEditsOnBindingSources();
      // DataSet.Copyを使用してセーブポイントを作成する。
      // 変更を反映しようとして失敗したら、トランザクションをロールバックし、ユーザーに変更を反映する前の状態に変更を戻したいかどうかを尋ねる。

      DataSet dataSetSavePoint = northwindDataSet.Copy();

      try {
        int numberOfChangeSubmitted = 0;
        using (TransactionScope txn = new TransactionScope()) {
          // 明示的に接続を開く。

          // そうしないと、TableAdapter.Updateの呼出しが暗示的に接続を開いたり閉じたりし、その結果SQL Serverトランザクションがローカルトランザクションから分散トランザクションになってしまう。

          try {
            connection.Open();
          } catch (Exception openFailedException) {
            MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return;
          }
          // 挿入と更新の反映はトップダウン、削除はボトムアップで行う。
          // 関係するテーブルはOrdersおよびOrder Detailsだけ。

          DataRow[] rowsToSumit;
          // 新規注文および注文変更を反映する。
          rowsToSumit = northwindDataSet.Orders.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
          if (rowsToSumit.Length != 0)
            numberOfChangeSubmitted += ordersTableAdapter.Update(rowsToSumit);

          // 新規注文詳細および注文詳細変更を反映する。
          rowsToSumit = northwindDataSet.Order_Details.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
          if (rowsToSumit.Length != 0)
            numberOfChangeSubmitted += this.order_DetailsTableAdapter.Update(rowsToSumit);

          // 注文詳細の削除を反映する。
          rowsToSumit = northwindDataSet.Order_Details.Select("", "", DataViewRowState.Deleted);
          if (rowsToSumit.Length != 0)
            numberOfChangeSubmitted += order_DetailsTableAdapter.Update(rowsToSumit);

          // 注文の削除を反映する。
          rowsToSumit = northwindDataSet.Orders.Select("", "", DataViewRowState.Deleted);
          if (rowsToSumit.Length != 0)
            numberOfChangeSubmitted += ordersTableAdapter.Update(rowsToSumit);

          if (numberOfChangeSubmitted == 0) {
            MessageBox.Show("反映する変更がありません。", "処理なし");
            return;
          }

          txn.Complete();
        }
        MessageBox.Show(string.Format("{0} 個の変更を正常に反映しました。", numberOfChangeSubmitted), "保存に成功");

      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "更新に失敗しました。", MessageBoxButtons.OK, MessageBoxIcon.Error);

        if (MessageBox.Show("保留状態の変更を復元しますか？", "更新失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
          northwindDataSet.Clear();
          northwindDataSet.Merge(dataSetSavePoint);
        }
      } finally {
        connection.Close();
      }
      DumpDataTable.Schema(dataSetSavePoint.Tables["Orders"]);
      DumpDataTable.Schema(dataSetSavePoint.Tables["Order Details"]);
    }
    #endregion

    public static Color READ_ONLY_COLOR = Color.Gray;
    public static Color READ_WRITE_COLOR = Color.Black;


    SqlConnection connection = null;
    private void OrderForm_Load(object sender, EventArgs e) {
      this.orderIDTextBox.ForeColor = READ_ONLY_COLOR;
      this.orderTotalTextBox.ForeColor = READ_ONLY_COLOR;

      connection = ordersTableAdapter.Connection;
      employeesTableAdapter.Connection = connection;
      ordersTableAdapter.Connection = connection;
      order_DetailsTableAdapter.Connection = connection;
      productsTableAdapter.Connection = connection;

      // 接続を開く。

      // そうしないと、TableAdapterはFillを呼び出すたびに暗示的に接続を開いたり閉じたりしてしまう。
      try {
        this.connection.Open();
      } catch (Exception openFailedException) {
        MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return;
      }

      // すべての商品情報と従業員情報を取得する。
      productsTableAdapter.Fill(northwindDataSet.Products);
      employeesTableAdapter.Fill(northwindDataSet.Employees);

      // TODO: このコード行はデータを 'northwindDataSet.Order_Details' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
      // TODO: このコード行はデータを 'northwindDataSet.Orders' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
      //this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
#if WHERE
      this.ordersTableAdapter.Fill(northwindDataSet.Orders);
      this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
#else
      // 特定の顧客だけの注文情報を取得する。
      string customerID = "ALFKI";
      this.ordersTableAdapter.FillByCustomerID(northwindDataSet.Orders, customerID);
      this.order_DetailsTableAdapter.FillByCustomerID(northwindDataSet.Order_Details, customerID);
#endif
      //dataGridView1.DataSource = order_DetailsBindingSource;

      //string strConn = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True;";
      //string strSQL = "SELECT OrderID FROM Orders;";

      //SqlConnection cn = new SqlConnection(strConn);
      //DataSet ds = new DataSet();
      //SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
      //ds.Tables.Add("Orders");
      //da.Fill(ds, "Orders");


      //BindingSource bindingSource;

      //bindingSource = new BindingSource(ds, "Orders");

      // 接続を閉じる。
      connection.Close();
      this.MinimumSize = this.Size;

      SetOrderEditMode(false);
    }

    bool isEditingOrder = false;
    private void SetOrderEditMode(bool IsEditing) {
      isEditingOrder = IsEditing;
      Color fontColor;
      if (IsEditing)
        fontColor = READ_WRITE_COLOR;
      else
        fontColor = READ_ONLY_COLOR;
      // 編集モードでなければ、ナビゲーション、追加、削除、保存を有効にする
      bindingNavigatorMoveFirstItem.Enabled = !IsEditing;
      bindingNavigatorMovePreviousItem.Enabled = !IsEditing;
      bindingNavigatorMoveNextItem.Enabled = !IsEditing;
      bindingNavigatorMoveLastItem.Enabled = !IsEditing;
      bindingNavigatorPositionItem.Enabled = !IsEditing;
      bindingNavigatorAddNewItem.Enabled = !IsEditing;
      bindingNavigatorDeleteItem.Enabled = !IsEditing;

      // 編集モードでなければ「編集」を有効にする
      ordersBindingNavigatorEditItem.Enabled = !IsEditing;
      ordersBindingNavigatorAcceptItem.Enabled = IsEditing;
      ordersBindingNavigatorRejectItem.Enabled = IsEditing;

      ordersBindingNavigatorSaveItem.Enabled = !IsEditing;

      // 編集モードでなければ、読み取り専用にする
      customerIDTextBox.ReadOnly = !IsEditing;
      customerIDTextBox.ForeColor = fontColor;
      orderDateTextBox.ReadOnly = !IsEditing;
      orderDateTextBox.ForeColor = fontColor;
      employeeIDComboBox.Enabled = IsEditing;

      //orderIDTextBox.ReadOnly = !IsEditing;

      // 下の三つのボタン
      orderDetailsAddButton.Enabled = !IsEditing;
      orderDetailsEditButton.Enabled = !IsEditing && CanEnableOrderDetailsEditAndDelete();
      orderDetailsDeleteButton.Enabled = !IsEditing && CanEnableOrderDetailsEditAndDelete();
    }

    private void ordersBindingNavigatorEditItem_Click(object sender, EventArgs e) {
      SetOrderEditMode(true);
      customerIDTextBox.Focus();
    }

    private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
      BindingSource bindingSource = ordersBindingNavigator.BindingSource;
      DataRowView currentRow = (DataRowView)this.ordersBindingSource.Current;
      currentRow["OrderDate"] = DateTime.Today;
      this.ordersBindingSource.ResetCurrentItem();

      SetOrderEditMode(true);
      customerIDTextBox.Focus();
    }

    private void ordersBindingNavigatorAcceptItem_Click(object sender, EventArgs e) {
      ordersBindingSource.EndEdit();
      SetOrderEditMode(false);
    }

    private void ordersBindingNavigatorRejectItem_Click(object sender, EventArgs e) {
      ordersBindingSource.CancelEdit();
      SetOrderEditMode(false);

      bool isOrderAvaiable = ordersBindingSource.Count != 0;
      bindingNavigatorDeleteItem.Enabled = isOrderAvaiable;
      ordersBindingNavigatorEditItem.Enabled = isOrderAvaiable;
    }


    private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
      //DialogResult result;
      //result = MessageBox.Show("本当にこの注文を削除しますか?", "確認ダイアログ", MessageBoxButtons.YesNo);

      //if (result == DialogResult.Yes) {
      //}
      this.ordersBindingSource.RemoveCurrent();
    }

    private bool ConfirmDeletion(string ItemType) {
      return (MessageBox.Show(string.Format("本当にこの{0}を削除しますか？", ItemType), "削除確認", MessageBoxButtons.YesNo) == DialogResult.Yes);

    }

    private void orderDetailsEditButton_Click(object sender, EventArgs e) {
      using (DetailForm detailForm = new DetailForm()) {
        detailForm.EditDetail(order_DetailsBindingSource, productsBindingSource);
      }
    }

    private void orderDetailsAddButton_Click(object sender, EventArgs e) {
      DataRowView newOrderDetail = (DataRowView)order_DetailsBindingSource.AddNew();

      using (DetailForm detailForm = new DetailForm()) {
        detailForm.EditDetail(order_DetailsBindingSource, productsBindingSource);
      }
    }

    private void orderDetailsDeleteButton_Click(object sender, EventArgs e) {
      if (ConfirmDeletion("注文詳細"))
        order_DetailsBindingSource.RemoveCurrent();
    }

    private bool CanEnableOrderDetailsEditAndDelete() {
      return !isEditingOrder && !(this.order_DetailsBindingSource.Count == 0);
    }

    private void ordersBindingSource_PositionChanged(object sender, EventArgs e) {
      bool isOrderAvailable = ordersBindingSource.Count != 0;
      bindingNavigatorDeleteItem.Enabled = isOrderAvailable;
      ordersBindingNavigatorEditItem.Enabled = isOrderAvailable;

      bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
      orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
      orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
    }

    private void order_DetailsBindingSource_PositionChanged(object sender, EventArgs e) {
      bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
      orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
      orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
    }

    private void OrderForm_FormClosing(object sender, FormClosingEventArgs e) {
      EndEditsOnBindingSources();

      if (northwindDataSet.HasChanges()) {
        if (MessageBox.Show("このフォームには保留状態の変更があります。" +
            "フォームを閉じると保留状態の変更は破棄されます。\n\r" +
            "本当にフォームを閉じますか？", "確認ダイアログ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          e.Cancel = true;
      }
    }

    private void EndEditsOnBindingSources() {
      this.Validate();
      this.ordersBindingSource.EndEdit();
      this.order_DetailsBindingSource.EndEdit();
    }
  }
}
