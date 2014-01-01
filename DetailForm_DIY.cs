using System;
using System.Windows.Forms;

namespace Northwind {
  public partial class DetailForm_DIY : Form {
    public DetailForm_DIY() {
      InitializeComponent();
    }

    NorthwindDataSet.ProductsDataTable productsTable = null;
    BindingSource productsBindingSource = null;
    public bool EditDetail(NorthwindDataSet.Order_DetailsRow orderDetailsRow) {
      this.productsTable = ((NorthwindDataSet)orderDetailsRow.Table.DataSet).Products;
      this.productsBindingSource = new BindingSource(this.productsTable, "");
      this.productIDComboBox.DisplayMember = "ProductName";
      this.productIDComboBox.ValueMember = "ProductID";
      this.productIDComboBox.DataSource = this.productsBindingSource;
      this.productIDComboBox.SelectedValue = orderDetailsRow.ProductID;
      this.productIDComboBox.SelectionChangeCommitted += new EventHandler(productIDComboBox_SelectionChangeCommitted);

      this.unitPriceTextBox.Text = orderDetailsRow.UnitPrice.ToString("C2");

      this.quantityTextBox.Text = orderDetailsRow.Quantity.ToString();
      this.quantityTextBox.TextChanged += new EventHandler(quantityTextBox_TextChanged);

      this.itemTotalTextBox.Text = orderDetailsRow.ItemTotal.ToString("C2");

      if (this.ShowDialog() == DialogResult.OK) {
        int productID = (int)this.productIDComboBox.SelectedValue;
        if (productID != orderDetailsRow.ProductID)
          orderDetailsRow.ProductID = productID;

        short quantity = 0;
        if (short.TryParse(this.quantityTextBox.Text, out quantity)
            && quantity != orderDetailsRow.Quantity)
          orderDetailsRow.Quantity = quantity;

        decimal unitPrice = 0;
        if (decimal.TryParse(this.unitPriceTextBox.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentUICulture.NumberFormat, out unitPrice)
            && unitPrice != orderDetailsRow.UnitPrice)
          orderDetailsRow.UnitPrice = unitPrice;

        return true;
      } else
        return false;
    }

    void quantityTextBox_TextChanged(object sender, EventArgs e) {
      this.UpdateItemTotal();
    }

    void UpdateItemTotal() {
      int quantity;
      decimal unitPrice;
      if (int.TryParse(this.quantityTextBox.Text, out quantity))
        if (decimal.TryParse(this.unitPriceTextBox.Text, System.Globalization.NumberStyles.Currency, null, out unitPrice))
          this.itemTotalTextBox.Text = (unitPrice * quantity).ToString("C");
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