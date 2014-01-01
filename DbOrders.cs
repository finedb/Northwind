using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Northwind {
  public class DbOrders {
    public static int Execute(SqlConnection cn, DataRow[] dataRow) {
      string strSQLInsert = "INSERT INTO Orders( CustomerID, EmployeeID, OrderDate) VALUES";
      strSQLInsert += "(@CustomerID, @EmployeeID, @OrderDate)";
      string strSQLUpdate = "UPDATE Orders SET CustomerID=@CustomerID, EmployeeID=@EmployeeID, OrderDate=@OrderDate";
      strSQLUpdate += " WHERE OrderID=@Original_OrderID";
      strSQLUpdate += " AND ((CustomerID IS NULL AND @Original_CustomerID IS NULL) OR CustomerID=@Original_CustomerID)";
      strSQLUpdate += " AND ((EmployeeID IS NULL AND @Original_EmployeeID IS NULL) OR EmployeeID=@Original_EmployeeID)";
      strSQLUpdate += " AND ((OrderDate  IS NULL AND @Original_OrderDate  IS NULL) OR OrderDate =@Original_OrderDate);";
      string strSQLDelete = "DELETE FROM Orders WHERE OrderID=@Original_OrderID";
      strSQLDelete += " AND ((CustomerID IS NULL AND @Original_CustomerID IS NULL) OR CustomerID=@Original_CustomerID)";
      strSQLDelete += " AND ((EmployeeID IS NULL AND @Original_EmployeeID IS NULL) OR EmployeeID=@Original_EmployeeID)";
      strSQLDelete += " AND ((OrderDate  IS NULL AND @Original_OrderDate  IS NULL) OR OrderDate =@Original_OrderDate);";

      int cnt = 0;
      using (SqlCommand cmd = new SqlCommand()) {
        try {
          cmd.Connection = cn;
          foreach (DataRow row in dataRow) {
            cmd.Parameters.Clear();
            switch (row.RowState) {
              case DataRowState.Added:
              // cmd.Parameters.Add("OrderID", SqlDbType.Int);
              cmd.Parameters.Add("CustomerID", SqlDbType.NVarChar);
              cmd.Parameters.Add("EmployeeID", SqlDbType.Int);
              cmd.Parameters.Add("OrderDate", SqlDbType.DateTime);

              cmd.CommandText = strSQLInsert;

              //  cmd.Parameters["OrderID"].Value = row["OrderID", DataRowVersion.Current];
              cmd.Parameters["CustomerID"].Value = row["CustomerID", DataRowVersion.Current];
              cmd.Parameters["EmployeeID"].Value = row["EmployeeID", DataRowVersion.Current];
              cmd.Parameters["OrderDate"].Value = row["OrderDate", DataRowVersion.Current];
              cnt += cmd.ExecuteNonQuery();
              break;

              case DataRowState.Modified:
              cmd.Parameters.Add("CustomerID", SqlDbType.NVarChar, 5);
              cmd.Parameters.Add("EmployeeID", SqlDbType.Int);
              cmd.Parameters.Add("OrderDate", SqlDbType.DateTime);

              cmd.Parameters.Add("Original_OrderID", SqlDbType.Int);
              cmd.Parameters.Add("Original_CustomerID", SqlDbType.NVarChar, 5);
              cmd.Parameters.Add("Original_EmployeeID", SqlDbType.Int);
              cmd.Parameters.Add("Original_OrderDate", SqlDbType.DateTime);

              cmd.CommandText = strSQLUpdate;

              cmd.Parameters["CustomerID"].Value = row["CustomerID", DataRowVersion.Current];
              cmd.Parameters["EmployeeID"].Value = row["EmployeeID", DataRowVersion.Current];
              cmd.Parameters["OrderDate"].Value = row["OrderDate", DataRowVersion.Current];

              cmd.Parameters["Original_OrderID"].Value = row["OrderID", DataRowVersion.Original];
              cmd.Parameters["Original_CustomerID"].Value = row["CustomerID", DataRowVersion.Original];
              cmd.Parameters["Original_EmployeeID"].Value = row["EmployeeID", DataRowVersion.Original];
              cmd.Parameters["Original_OrderDate"].Value = row["OrderDate", DataRowVersion.Original];
              try {
                int intRecordsAffected = cmd.ExecuteNonQuery();
                if (intRecordsAffected == 1) {
                  cnt += intRecordsAffected;
                    row.AcceptChanges();
                  // 変更中に別のユーザーがデータを変更してしまったら0になる。
                } else if (intRecordsAffected == 0) {
                  Console.WriteLine("失敗 - クエリは行を変更していません");
                } else {
                  Console.WriteLine("クエリは{0}行を変更してしまいました", intRecordsAffected);
                }
              } catch (Exception ex) {
                Console.WriteLine("クエリが失敗しました: {0}", ex.Message);
              }
              break;

              case DataRowState.Deleted:
              cmd.Parameters.Add("Original_OrderID", SqlDbType.Int);
              cmd.Parameters.Add("Original_CustomerID", SqlDbType.NVarChar, 5);
              cmd.Parameters.Add("Original_EmployeeID", SqlDbType.Int);
              cmd.Parameters.Add("Original_OrderDate", SqlDbType.DateTime);

              cmd.CommandText = strSQLDelete;

              cmd.Parameters["Original_OrderID"].Value = row["OrderID", DataRowVersion.Original];
              cmd.Parameters["Original_CustomerID"].Value = row["CustomerID", DataRowVersion.Original];
              cmd.Parameters["Original_EmployeeID"].Value = row["EmployeeID", DataRowVersion.Original];
              cmd.Parameters["Original_OrderDate"].Value = row["OrderDate", DataRowVersion.Original];
              try {
                int intRecordsAffected = cmd.ExecuteNonQuery();
                if (intRecordsAffected == 1) {
                  cnt += intRecordsAffected;
                    row.AcceptChanges();
                  // 変更中に別のユーザーがデータを変更してしまったら0になる。
                } else if (intRecordsAffected == 0) {
                  Console.WriteLine("[Orders]失敗 - クエリは行を変更していません");
                } else {
                  Console.WriteLine("[Orders]クエリは{0}行を変更してしまいました", intRecordsAffected);
                }
              } catch (Exception ex) {
                Console.WriteLine("[Orders]クエリが失敗しました: {0}", ex.Message);
              }
              break;
            }
          }
        } catch (Exception ex) {
          throw new Exception(ex.Message);
        }
      }
      return cnt;
    }
  }
}
