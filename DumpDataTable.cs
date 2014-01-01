using System;
using System.Data;

namespace Northwind {
  public class DumpDataTable {

    static DataTable _dataTable;
    static int _maxCount;
    public static void Schema(DataTable dataTable,DataViewRowState dvrs = DataViewRowState.Unchanged, int maxCount = 0) {
       _dataTable = dataTable;
       _maxCount = maxCount;
     if (_dataTable == null) return;
      Console.WriteLine("-".PadLeft(100, '-'));
      _LabelName();
      _ColumnInfo();

      Console.WriteLine("【削除を含む件数】" + _dataTable.Rows.Count + " 【削除を除く件数】" + _DeleteCount().ToString());

      _DataIfo(dvrs);
    }

    private static void _LabelName() {
      Console.WriteLine("|{0,-7}|{1,-15}|{2,-10}|{3,-6}|{4,-8}|{5,-9}|{6,-13}|{7,-12}|{8,-11}|{9,-3}|{10}"
      , "Ordinal", "Name", "Type", "Unique", "ReadOnly", "AutoIncre", "Caption", "DesignMode", "AllowDBNull", "Max", "Default");
    }

    private static void _ColumnInfo() {
      string def = string.Empty;

      foreach (DataColumn dataColumn in _dataTable.Columns) {
        if (dataColumn == null) {
          def = "DBNull";
        } else {
          def = dataColumn.ToString();
        }
        Console.WriteLine("|{0,-7}|{1,-15}|{2,-10}|{3,-6}|{4,-8}|{5,-9}|{6,-13}|{7,-12}|{8,-11}|{9,-3}|{10}"
          , dataColumn.Ordinal, dataColumn.ColumnName, dataColumn.DataType.Name, dataColumn.Unique, dataColumn.ReadOnly, dataColumn.AutoIncrement, dataColumn.Caption, dataColumn.DesignMode, dataColumn.AllowDBNull, dataColumn.MaxLength, def);
      }
    }

    private static void _DataIfo(DataViewRowState dvrs) {
      DataRow[] dataRow;
      dataRow = _dataTable.Select("", "", dvrs);

      // データの出力
      int cnt = 0;
      foreach (DataRow row in dataRow) {
        Console.Write("◆{0}:{1}", cnt, row.RowState);
        for (int col = 0; col < _dataTable.Columns.Count; col++) {
          if (row.RowState != DataRowState.Deleted) {
            //Console.Write("[Crr] NULL !\t");
          } else
            Console.Write("[Ori]{0}", row[col, DataRowVersion.Original]);

          if (row.RowState != DataRowState.Added) {
            if (row[col, DataRowVersion.Original] == null)
              Console.Write("[Ori] NULL !\t");
            else
              Console.Write("[Ori]{0}\t", row[col, DataRowVersion.Original]);
          }
          if (row.RowState == DataRowState.Added | row.RowState == DataRowState.Modified)
            Console.Write("[Curr]{0}\t", row[col, DataRowVersion.Current]);
        }
        Console.WriteLine();
        cnt++;
        if (cnt != 0)
          if (cnt == _maxCount) break;
      }
    }

    private static int _DeleteCount() {
      int n = 0;
      foreach (DataRow dataRow in _dataTable.Rows)
        if (dataRow.RowState != DataRowState.Deleted)
          n++;
      return n;
    }
  }
}
