using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind {
  public partial class DetailFormCode : Form {
    public DetailFormCode() {
      InitializeComponent();
    }

    private void DetailFormCode_Load(object sender, EventArgs e) {
      _UpdateItemTotal();
    }

    BindingSource _orderDetailsBindingSource,_productsBindingSource;
    DataTable _productsTable;
    DataRowView _orderDetailDataRowView;

    public void EditDetail(BindingSource orderDetailsBindingSource,
                           BindingSource productsBindingSource) {
      _productsBindingSource = productsBindingSource;
      _productsTable = ((DataView)productsBindingSource.List).Table;
      _orderDetailsBindingSource = orderDetailsBindingSource;
      _orderDetailDataRowView = (DataRowView)_orderDetailsBindingSource.Current;

      if (_orderDetailDataRowView.IsNew) {
        DataRow product = _productsTable.Rows[0];
        _orderDetailDataRowView["Quantity"] = 1;
        _orderDetailDataRowView["ProductID"] = product["ProductID"];
        _orderDetailDataRowView["UnitPrice"]=product["UnitPrice"];
      }

      productIDComboBox.DisplayMember = "ProductName";
      productIDComboBox.ValueMember = "ProductID";
      productIDComboBox.DataSource = _productsBindingSource;
      productIDComboBox.DataBindings.Add("SelectedValue", _orderDetailsBindingSource, "ProductID");
      productIDComboBox.SelectionChangeCommitted += productIDComboBox_SelectionChangeCommitted;

      unitPriceTextBox.DataBindings.Add("Text", _orderDetailsBindingSource, "UnitPrice", true, DataSourceUpdateMode.OnValidation, "<Null>", "C2");
      quantityTextBox.DataBindings.Add("Text", _orderDetailsBindingSource, "Quantity", true, DataSourceUpdateMode.OnValidation, "<Null>", "");
      itemTotalTextBox.DataBindings.Add("Text", _orderDetailsBindingSource, "ItemTotal", true, DataSourceUpdateMode.OnValidation, "", "C2");

      if (_orderDetailDataRowView.IsNew) {
       // itemTotalTextBox.Text = unitPriceTextBox.Text;
      }

      if (ShowDialog() == DialogResult.OK)
        try {
          orderDetailsBindingSource.EndEdit();
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
          orderDetailsBindingSource.CancelEdit();
        } else
        orderDetailsBindingSource.CancelEdit();
    

    }

    void productIDComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
      if (productIDComboBox.SelectedIndex != 1) {
        int productID = (int)productIDComboBox.SelectedValue;
        DataRow productRow = _productsTable.Rows.Find(productID);
        unitPriceTextBox.Text = productRow["UnitPrice"].ToString();

        _UpdateItemTotal();
      }
    }

    private void quantityTextBox_TextChanged(object sender, EventArgs e) {
      _UpdateItemTotal();
    }

    private void _UpdateItemTotal() {
      int quantity;
      decimal unitPrice;
      if(int.TryParse(quantityTextBox.Text, out quantity) && decimal.TryParse(unitPriceTextBox.Text,System.Globalization.NumberStyles.Currency,null,out unitPrice))
        itemTotalTextBox.Text = (unitPrice* quantity).ToString("C");
    }

  }
}
