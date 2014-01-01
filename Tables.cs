using System;
using System.Data;
//55
namespace Northwind {
  public class Tables {

    private static DataSet _ds;

    public Tables() {
      _ds = new DataSet();
      DataTable tbl;
      DataColumn col;

      #region 注文詳細テーブル
      tbl = _ds.Tables.Add("Order Details");
      tbl.BeginInit();
      tbl.Columns.Add("OrderID", typeof(int));
      tbl.Columns.Add("ProductID", typeof(int));
      tbl.Columns.Add("UnitPrice", typeof(decimal));
      tbl.Columns.Add("Quantity", typeof(int));
      col = tbl.Columns.Add("Discount", typeof(double));
      col.DefaultValue = 0;
      col = new DataColumn("ItemTotal", typeof(decimal));
      col.Expression = "Quantity*UnitPrice";
      tbl.Columns.Add(col);
      tbl.PrimaryKey = new DataColumn[] { tbl.Columns["OrderID"], tbl.Columns["ProductID"] };
      tbl.EndInit();
      #endregion

      #region 注文テーブル
      tbl = _ds.Tables.Add("Orders");
      tbl.BeginInit();// 明示的に呼び出す
      col = tbl.Columns.Add("OrderID", typeof(int));
      col.AutoIncrement = true;
      col.AutoIncrementSeed = -1;
      col.AutoIncrementStep = -1;
      col.ReadOnly = true;
      tbl.Columns.Add("CustomerID", typeof(string)).MaxLength = 5;
      tbl.Columns.Add("EmployeeID", typeof(int));
      tbl.Columns.Add("OrderDate", typeof(DateTime));
      col = new DataColumn("OrderTotal", typeof(decimal));
      col.Expression = "Sum(Child(FK_Orders_OrderDetails).ItemTotal)";
      tbl.Columns.Add(col);

      tbl.PrimaryKey = new DataColumn[] { tbl.Columns["OrderID"] };
      #endregion

      #region 外部キー
      //ForeignKeyConstraint fk;
      //fk = new ForeignKeyConstraint("FK_Orders_OrderDetails", _ds.Tables["Orders"].Columns["OrderID"], _ds.Tables["Order Details"].Columns["OrderID"]);
      //_ds.Tables["Order Details"].Constraints.Add(fk);

      DataRelation relation;
      relation = new DataRelation("FK_Orders_OrderDetails", _ds.Tables["Orders"].Columns["OrderID"],
        _ds.Tables["Order Details"].Columns["OrderID"], true);

      _ds.Relations.Add(relation);

      ForeignKeyConstraint foreignKey = relation.ChildKeyConstraint;
      foreignKey.DeleteRule = Rule.Cascade;
      foreignKey.UpdateRule = Rule.Cascade;
      foreignKey.AcceptRejectRule = AcceptRejectRule.Cascade;
      tbl.EndInit();
      #endregion
    }

    public DataTable this[string tableName] {
      get {
        return _ds.Tables[tableName];
      }
    }

    public DataSet GetDataSet() {
      return _ds;
    }
  }
}
