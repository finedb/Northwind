using System;
using System.Data;
using System.Windows.Forms;

namespace Northwind {
  public partial class DetailForm : Form {
    public DetailForm() {
      InitializeComponent();
    }

    private void DetailForm_Load(object sender, EventArgs e) {
      this.UpdateItemTotal();
    }

    BindingSource orderDetailsBindingSource, productsBindingSource;
    NorthwindDataSet.ProductsDataTable productsTable;
    DataRowView orderDetailDataRowView;

    public void EditDetail(BindingSource OrderDetailsBindingSource,
                           BindingSource ProductsBindingSource) {

      productsBindingSource = ProductsBindingSource;
      productsTable = (NorthwindDataSet.ProductsDataTable)((DataView)this.productsBindingSource.List).Table;
      orderDetailsBindingSource = OrderDetailsBindingSource;
      orderDetailDataRowView = (DataRowView)orderDetailsBindingSource.Current;

      if (orderDetailDataRowView.IsNew) {
        NorthwindDataSet.ProductsRow product = productsTable[0];
        orderDetailDataRowView["Quantity"] = 1;
        orderDetailDataRowView["ProductID"] = product.ProductID;
        orderDetailDataRowView["UnitPrice"] = product.UnitPrice;
      }

      this.productIDComboBox.DisplayMember = "ProductName";
      this.productIDComboBox.ValueMember = "ProductID";
      this.productIDComboBox.DataSource = this.productsBindingSource;
      this.productIDComboBox.DataBindings.Add("SelectedValue", this.orderDetailsBindingSource, "ProductID");
      productIDComboBox.SelectionChangeCommitted += productIDComboBox_SelectionChangeCommitted;
      unitPriceTextBox.DataBindings.Add("Text", orderDetailsBindingSource, "UnitPrice", true, DataSourceUpdateMode.OnValidation, "<Null>", "C2");
      quantityTextBox.DataBindings.Add("Text", this.orderDetailsBindingSource, "Quantity", true, DataSourceUpdateMode.OnValidation, "<Null>", "");
      itemTotalTextBox.DataBindings.Add("Text", this.orderDetailsBindingSource, "ItemTotal", true, DataSourceUpdateMode.OnValidation, "", "C2");


      if (this.orderDetailDataRowView.IsNew) {
        this.itemTotalTextBox.Text = this.unitPriceTextBox.Text;

      }


      if (ShowDialog() == DialogResult.OK)
        try {
          orderDetailsBindingSource.EndEdit();
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
          orderDetailsBindingSource.CancelEdit();
        }
      else
        orderDetailsBindingSource.CancelEdit();
    }

    private void quantityTextBox_TextChanged(object sender, EventArgs e) {
      this.UpdateItemTotal();
    }

    void UpdateItemTotal() {
      int quantity;
      decimal unitPrice;
      if (int.TryParse(quantityTextBox.Text, out quantity) && decimal.TryParse(unitPriceTextBox.Text, System.Globalization.NumberStyles.Currency, null, out unitPrice))
        itemTotalTextBox.Text = (unitPrice * quantity).ToString("C");
    }

    void productIDComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
      if (this.productIDComboBox.SelectedIndex != -1) {
        int productID = (int)this.productIDComboBox.SelectedValue;
        NorthwindDataSet.ProductsRow productRow = this.productsTable.FindByProductID(productID);
        this.unitPriceTextBox.Text = productRow.UnitPrice.ToString("C");

        this.UpdateItemTotal();
      }
    }
  }
}
