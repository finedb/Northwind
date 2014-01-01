using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Northwind {
  public class DbOrderDetails {
    public static int Execute(SqlConnection cn, DataRow[] dataRow) {
      string strSQLInsert = "INSERT INTO [Order Details]( OrderID, ProductID, UnitPrice, Quantity, Discount) VALUES";
      strSQLInsert += "(@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

      string strSQLUpdate = "UPDATE [Order Details] SET ProductID=@ProductID, UnitPrice=@UnitPrice, Quantity=@Quantity";
      strSQLUpdate+=" WHERE OrderID=@Original_OrderID AND ProductID=@Original_ProductID AND UnitPrice=@Original_UnitPrice AND Quantity=@Original_Quantity";

      string strSQLDelete = "DELETE FROM [Order Details]";
      strSQLDelete += " WHERE OrderID=@Original_OrderID AND ProductID=@Original_ProductID AND UnitPrice=@Original_UnitPrice AND Quantity=@Original_Quantity";
      int cnt = 0;
      using (SqlCommand cmd = new SqlCommand()) {
        try {
          cmd.Connection = cn;
          foreach (DataRow row in dataRow) {
            cmd.Parameters.Clear();
            switch (row.RowState) {
              case DataRowState.Added:
              // cmd.Parameters.Add("OrderID", SqlDbType.Int);
              cmd.Parameters.Add("OrderID", SqlDbType.Int);
              cmd.Parameters.Add("ProductID", SqlDbType.Int);
              cmd.Parameters.Add("UnitPrice", SqlDbType.Money);
              cmd.Parameters.Add("Quantity", SqlDbType.SmallInt);
              cmd.Parameters.Add("Discount", SqlDbType.Real);

              cmd.CommandText = strSQLInsert;

              //  cmd.Parameters["OrderID"].Value = row["OrderID", DataRowVersion.Current];
              cmd.Parameters["OrderID"].Value = row["OrderID", DataRowVersion.Current];
              cmd.Parameters["ProductID"].Value = row["ProductID", DataRowVersion.Current];
              cmd.Parameters["UnitPrice"].Value = row["UnitPrice", DataRowVersion.Current];
              cmd.Parameters["Quantity"].Value = row["Quantity", DataRowVersion.Current];
              cmd.Parameters["Discount"].Value = row["Discount", DataRowVersion.Current];

              cnt += cmd.ExecuteNonQuery();
              break;

              case DataRowState.Modified:
              cmd.Parameters.Add("OrderID", SqlDbType.Int);
              cmd.Parameters.Add("ProductID", SqlDbType.Int);
              cmd.Parameters.Add("UnitPrice", SqlDbType.Money);
              cmd.Parameters.Add("Quantity", SqlDbType.SmallInt);


              cmd.Parameters.Add("Original_OrderID", SqlDbType.Int);
              cmd.Parameters.Add("Original_ProductID", SqlDbType.Int);
              cmd.Parameters.Add("Original_UnitPrice", SqlDbType.Money);
              cmd.Parameters.Add("Original_Quantity", SqlDbType.SmallInt);

              cmd.CommandText = strSQLUpdate;

              cmd.Parameters["OrderID"].Value = row["OrderID", DataRowVersion.Current];
              cmd.Parameters["ProductID"].Value = row["ProductID", DataRowVersion.Current];
              cmd.Parameters["UnitPrice"].Value = row["UnitPrice", DataRowVersion.Current];
              cmd.Parameters["Quantity"].Value = row["Quantity", DataRowVersion.Current];

              cmd.Parameters["Original_OrderID"].Value = row["OrderID", DataRowVersion.Original];
              cmd.Parameters["Original_ProductID"].Value = row["ProductID", DataRowVersion.Original];
              cmd.Parameters["Original_UnitPrice"].Value = row["UnitPrice", DataRowVersion.Original];
              cmd.Parameters["Original_Quantity"].Value = row["Quantity", DataRowVersion.Original];
              try {
                int intRecordsAffected = cmd.ExecuteNonQuery();
                if (intRecordsAffected == 1) {
                  cnt += intRecordsAffected;
                   row.AcceptChanges();
                  // 変更中に別のユーザーがデータを変更してしまったら0になる。
                } else if (intRecordsAffected == 0) {
                  Console.WriteLine("[Order Details]失敗 - クエリは行を変更していません");
                } else {
                  Console.WriteLine("[Order Details]クエリは{0}行を変更してしまいました", intRecordsAffected);
                }
              } catch (Exception ex) {
                Console.WriteLine("[Order Details]クエリが失敗しました: {0}", ex.Message);
              }
              break;

              case DataRowState.Deleted:
              cmd.Parameters.Add("Original_OrderID", SqlDbType.Int);
              cmd.Parameters.Add("Original_ProductID", SqlDbType.Int);
              cmd.Parameters.Add("Original_UnitPrice", SqlDbType.Money);
              cmd.Parameters.Add("Original_Quantity", SqlDbType.SmallInt);

              cmd.CommandText = strSQLDelete;
              cmd.Parameters["Original_OrderID"].Value = row["OrderID", DataRowVersion.Original];
              cmd.Parameters["Original_ProductID"].Value = row["ProductID", DataRowVersion.Original];
              cmd.Parameters["Original_UnitPrice"].Value = row["UnitPrice", DataRowVersion.Original];
              cmd.Parameters["Original_Quantity"].Value = row["Quantity", DataRowVersion.Original];
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
