using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Northwind
{
    public partial class OrdersFormCode : Form
    {

        private SqlConnection _connection = null;
        private BindingSource _ordersBindingSouce;
        private BindingSource _orderDetailsBindingSource;
        private BindingSource _productsBindingSource;
        private DataSet _ds;
        private string _strConn = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True;";

        public OrdersFormCode()
        {
            InitializeComponent();

            string strSQLOrders = "SELECT OrderID, CustomerID, EmployeeID, OrderDate FROM Orders;";
            string strSQLOrderDetails = "SELECT OrderID, ProductID, UnitPrice, Quantity FROM [Order Details]";

            _ds = new DataSet();

            Tables tbl = new Tables();
            _ds = tbl.GetDataSet();
            DataTable ordersDataTable = _ds.Tables["Orders"];
            DataTable orderDetailsDataTable = _ds.Tables["Order Details"];

            DumpDataTable.Schema(_ds.Tables["Orders"]);
            //      return;
            NorthwindDataSetCode.EmployeesDataTable employeesDataTable;
            NorthwindDataSetCode.ProductsDataTable productsDataTable;

            using (SqlConnection cn = new SqlConnection(_strConn))
            {
                // 雇用
                NorthwindDataSetCodeTableAdapters.EmployeesTableAdapter employeesTableAdapter;
                employeesDataTable = new NorthwindDataSetCode.EmployeesDataTable();
                NorthwindDataSetCodeTableAdapters.ProductsTableAdapter productsTableAdapter;
                productsDataTable = new NorthwindDataSetCode.ProductsDataTable();

                // 接続を開く。そうしないと、TableAdapterはFillを呼び出すたびに暗示的に接続を開いたり閉じたりしてしまう。
                try
                {
                    _connection = cn;
                    employeesTableAdapter = new NorthwindDataSetCodeTableAdapters.EmployeesTableAdapter();
                    employeesTableAdapter.Connection = _connection;
                    productsTableAdapter = new NorthwindDataSetCodeTableAdapters.ProductsTableAdapter();
                    productsTableAdapter.Connection = _connection;
                    // 開く
                    cn.Open();
                }
                catch (Exception openFailedException)
                {
                    MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                // 従業員情報と商品情報を取得する。
                employeesTableAdapter.Fill(employeesDataTable);
                productsTableAdapter.Fill(productsDataTable);

                SqlDataAdapter daOrders = new SqlDataAdapter(strSQLOrders, cn);
                SqlDataAdapter daOrderDetails = new SqlDataAdapter(strSQLOrderDetails, cn);

                daOrders.MissingSchemaAction = MissingSchemaAction.Error;
                daOrderDetails.MissingSchemaAction = MissingSchemaAction.Error;
                daOrders.FillError += daOrders_FillError;
                daOrderDetails.FillError += daOrderDetails_FillError;
                daOrders.Fill(ordersDataTable);
                daOrderDetails.Fill(orderDetailsDataTable);
            }
            _ordersBindingSouce = new BindingSource(ordersDataTable, "");
            _ordersBindingSouce.PositionChanged += _ordersBindingSouce_PositionChanged;
            //orderDetailsDataGridView.DataMember = "";
            // orderBindingSouce.DataSource = orderBindingSouce;
            // ナビゲータ
            orderBindingNavigator.BindingSource = _ordersBindingSouce;
            // テキストボックス Order
            //_ordersBindingSouce.Filter = "CustomerID='VICTE'";
            orderIDTextBox.DataBindings.Add("Text", _ordersBindingSouce, "OrderID");
            customerIDTextBox.DataBindings.Add("Text", _ordersBindingSouce, "CustomerID");
            employeeIDComboBox.DataBindings.Add("SelectedValue", _ordersBindingSouce, "EmployeeID");
            orderDateTextBox.DataBindings.Add("Text", _ordersBindingSouce, "OrderDate", true, DataSourceUpdateMode.OnValidation, "yyyy/MM/dd");
            orderTotalTextBox.DataBindings.Add("Text", _ordersBindingSouce, "OrderTotal");


            // DataGridView 詳細 _ordersBindingSouceにする
            _orderDetailsBindingSource = new BindingSource(_ordersBindingSouce, "FK_Orders_OrderDetails");

            //_orderDetailsBindingSource = new BindingSource(_ordersBindingSouce, "FK_Orders_Details");
            _orderDetailsBindingSource.PositionChanged += _orderDetailsBindingSource_PositionChanged;
            orderDetailsDataGridView.DataSource = _orderDetailsBindingSource;
            orderDetailsBindingNavigator.BindingSource = _orderDetailsBindingSource;


            // 雇用ID
            BindingSource employeesBindingSource = new BindingSource(employeesDataTable, "");
            Console.Write(northwindDataSetCode.Employees.ToString());
            employeeIDComboBox.DataSource = employeesBindingSource;
            employeeIDComboBox.DisplayMember = "EmployeeName";
            employeeIDComboBox.ValueMember = "EmployeeID";

            // 商品
            _productsBindingSource = new BindingSource(productsDataTable, "");

            //foreach (DataRow parent in ds.Tables["Orders"].Rows) {
            //  Console.WriteLine(parent["OrderID"] + " : " + parent["CustomerID"]);
            //  // 関連したsubテーブルをループする
            //  foreach (DataRow child in parent.GetChildRows("FK_Orders_Details")) {
            //    Console.WriteLine("\t" + child["OrderID"] + "  \\" + child["ProductID"] + " 1ロット10台 \\" + child["UnitPrice"]);
            //  }
            //}
            _connection.Close();
            this.MinimumSize = this.Size;

            SetOrderEditMode(false);

            //DumpDataTable.Data(_ds.Tables["Orders"],5);
            //DumpDataTable.Data(_ds.Tables["Order Details"], 5);
        }

        void daOrderDetails_FillError(object sender, FillErrorEventArgs e)
        {
            MessageBox.Show(e.Errors.Message);
            e.Continue = true;
        }

        void daOrders_FillError(object sender, FillErrorEventArgs e)
        {
            MessageBox.Show(e.Errors.Message);
            e.Continue = true;
        }

        #region コントロールの有効無効の切替
        bool isEditingOrder = false;
        private void SetOrderEditMode(bool IsEditing)
        {
            isEditingOrder = IsEditing;
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
            //orderIDTextBox.ReadOnly = !IsEditing;// 常時読み取り専用
            customerIDTextBox.ReadOnly = !IsEditing;
            orderDateTextBox.ReadOnly = !IsEditing;
            employeeIDComboBox.Enabled = IsEditing;

            // 下の三つのボタン
            orderDetailsAddButton.Enabled = !IsEditing;
            orderDetailsEditButton.Enabled = !IsEditing;
            orderDetailsDeleteButton.Enabled = !IsEditing;
        }
        #endregion

        private void employeeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(employeeIDComboBox.SelectedValue);
        }

        private void orderDetailsAddButton_Click(object sender, EventArgs e)
        {
            DataRowView newOrderDetails = (DataRowView)_orderDetailsBindingSource.AddNew();

            using (DetailFormCode detailForm = new DetailFormCode())
            {
                detailForm.EditDetail(_orderDetailsBindingSource, _productsBindingSource);
            }
        }

        #region Orders ナビゲーター
        // 削除
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //DialogResult result;
            //result = MessageBox.Show("本当にこの注文を削除しますか?", "確認ダイアログ", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes) {
            //}
            if (_ordersBindingSouce.Count == 0)
                return;
            _ordersBindingSouce.RemoveCurrent();
        }


        // 保存
        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _EndEditsOnBindingSources();
            // DataSet.Copyを使用してセーブポイントを作成する。
            // 変更を反映しようとして失敗したら、トランザクションをロールバックし、ユーザーに変更を反映する前の状態に変更を戻したいかどうかを尋ねる。

            DataSet dataSetSavePoint = _ds.Copy();
            using (SqlConnection cn = new SqlConnection(_strConn))
            {
                try
                {
                    int numberOfChangeSubmitted = 0;
                    using (TransactionScope txn = new TransactionScope())
                    {
                        // 明示的に接続を開く
                        // そうしないと、TableAdapter.Updateの呼出しが暗示的に接続を開いたり閉じたりし、その結果SQL Serverトランザクションがローカルトランザクションから分散トランザクションになってしまう。
                        try
                        {
                            cn.Open();
                        }
                        catch (Exception openFailedException)
                        {
                            MessageBox.Show(openFailedException.Message, "接続してデータを取得できません。",
                              MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        // 挿入と更新の反映はトップダウン、削除はボトムアップで行う。
                        // 関係するテーブルはOrdersおよびOrder Detailsだけ。

                        DataRow[] rowsToSubmit;
                        // 新規注文および注文変更を反映する。
                        rowsToSubmit = _ds.Tables["Orders"].Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
                        if (rowsToSubmit.Length != 0)
                            numberOfChangeSubmitted += DbOrders.Execute(cn, rowsToSubmit);


                        // 新規注文明細および注文詳細変更を反映する
                        rowsToSubmit = _ds.Tables["Order Details"].Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
                        if (rowsToSubmit.Length != 0)
                            numberOfChangeSubmitted += DbOrderDetails.Execute(cn, rowsToSubmit);

                        // 注文詳細の削除を反映する
                        rowsToSubmit = _ds.Tables["Order Details"].Select("", "", DataViewRowState.Deleted);
                        if (rowsToSubmit.Length != 0)
                            numberOfChangeSubmitted += DbOrderDetails.Execute(cn, rowsToSubmit);

                        // 注文の削除を反映する
                        rowsToSubmit = _ds.Tables["Orders"].Select("", "", DataViewRowState.Deleted);
                        if (rowsToSubmit.Length != 0)
                            numberOfChangeSubmitted += DbOrders.Execute(cn, rowsToSubmit);

                        if (numberOfChangeSubmitted == 0)
                        {
                            MessageBox.Show("反映するデータはありません。", "処理なし");
                            return;
                        }
                        txn.Complete();
                    }
                    MessageBox.Show(string.Format("{0} 個の変更を正常に反映しました。", numberOfChangeSubmitted), "保存に成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新に失敗しました。", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (MessageBox.Show("保留状態の変更を復元しますか？", "更新失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        _ds.Clear();
                        _ds.Merge(dataSetSavePoint);
                    }
                }
                finally
                {
                    _connection.Close();
                }
            }
            //DumpDataTable.Schema(dataSetSavePoint.Tables["Orders"]);
            //DumpDataTable.Schema(dataSetSavePoint.Tables["Order Details"]);

        }

        // 編集
        private void ordersBindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            SetOrderEditMode(true);
            customerIDTextBox.Focus();
        }

        // 確定
        private void ordersBindingNavigatorAcceptItem_Click(object sender, EventArgs e)
        {
            _ordersBindingSouce.EndEdit();
            SetOrderEditMode(false);
        }

        // 戻す
        private void ordersBindingNavigatorRejectItem_Click(object sender, EventArgs e)
        {
            _ordersBindingSouce.CancelEdit();
            SetOrderEditMode(false);

            bool isOrderAvaiable = _ordersBindingSouce.Count != 0;
            bindingNavigatorDeleteItem.Enabled = isOrderAvaiable;
            ordersBindingNavigatorEditItem.Enabled = isOrderAvaiable;
        }

        // 追加
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = orderBindingNavigator.BindingSource;
            DataRowView currentRow = (DataRowView)_ordersBindingSouce.Current;
            // 今日の日付を既定値にする
            currentRow["OrderDate"] = DateTime.Today;
            _ordersBindingSouce.ResetCurrentItem();

            SetOrderEditMode(true);
            customerIDTextBox.Focus();
        }

        #endregion

        #region ボタンの有効無効の切替
        private bool CanEnableOrderDetailsEditAndDelete()
        {
            return !isEditingOrder && !(this._orderDetailsBindingSource.Count == 0);
        }

        void _ordersBindingSouce_PositionChanged(object sender, EventArgs e)
        {
            bool isOrderAvailable = _ordersBindingSouce.Count != 0;
            bindingNavigatorDeleteItem.Enabled = isOrderAvailable;
            ordersBindingNavigatorEditItem.Enabled = isOrderAvailable;

            bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
            orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
            orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
        }

        void _orderDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            bool canEnableOrderDetailsEditAndDelete = CanEnableOrderDetailsEditAndDelete();
            orderDetailsEditButton.Enabled = canEnableOrderDetailsEditAndDelete;
            orderDetailsDeleteButton.Enabled = canEnableOrderDetailsEditAndDelete;
        }
        #endregion

        // フォームを閉じるときの確認
        private void OrdersFormCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            _EndEditsOnBindingSources();

            //if (_ds.HasChanges()) {
            //  if (MessageBox.Show("このフォームには保留状態です。フォームを閉じると保留状態は破棄されます。\n\r" +
            //      "本当にフォームを閉じますか？", "確認ダイアログ",
            //      MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            //    e.Cancel = true;
            //}
        }

        private void _EndEditsOnBindingSources()
        {
            Validate();
            _ordersBindingSouce.EndEdit();
            _orderDetailsBindingSource.EndEdit();
        }

        private void DataTablebutton_Click(object sender, EventArgs e)
        {
            DumpDataTable.Schema(_ds.Tables["Orders"], DataViewRowState.Added);
            DumpDataTable.Schema(_ds.Tables["Order Details"], DataViewRowState.Added);
        }

        private bool _ConfirmDeletion(string ItemType)
        {
            return (MessageBox.Show(string.Format("本当にこの{0}を削除しますか?", ItemType), "削除確認", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        private void orderDetailsDeleteButton_Click(object sender, EventArgs e)
        {
            _orderDetailsBindingSource.RemoveCurrent();
        }

        private void orderDetailsEditButton_Click(object sender, EventArgs e)
        {
            using (DetailFormCode detailForm = new DetailFormCode())
            {
                detailForm.EditDetail(_orderDetailsBindingSource, _productsBindingSource);
            }
        }
    }
}
