namespace Northwind {
  partial class DetailForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.unitPriceTextBox = new System.Windows.Forms.TextBox();
      this.b_OK = new System.Windows.Forms.Button();
      this.quantityTextBox = new System.Windows.Forms.TextBox();
      this.itemTotalTextBox = new System.Windows.Forms.TextBox();
      this.b_Cancel = new System.Windows.Forms.Button();
      this.productIDComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // unitPriceTextBox
      // 
      this.unitPriceTextBox.Location = new System.Drawing.Point(86, 38);
      this.unitPriceTextBox.Name = "unitPriceTextBox";
      this.unitPriceTextBox.Size = new System.Drawing.Size(144, 19);
      this.unitPriceTextBox.TabIndex = 0;
      // 
      // b_OK
      // 
      this.b_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.b_OK.Location = new System.Drawing.Point(57, 113);
      this.b_OK.Name = "b_OK";
      this.b_OK.Size = new System.Drawing.Size(75, 23);
      this.b_OK.TabIndex = 1;
      this.b_OK.Text = "OK";
      this.b_OK.UseVisualStyleBackColor = true;
      // 
      // quantityTextBox
      // 
      this.quantityTextBox.Location = new System.Drawing.Point(86, 63);
      this.quantityTextBox.Name = "quantityTextBox";
      this.quantityTextBox.Size = new System.Drawing.Size(144, 19);
      this.quantityTextBox.TabIndex = 2;
      this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
      // 
      // itemTotalTextBox
      // 
      this.itemTotalTextBox.Location = new System.Drawing.Point(86, 88);
      this.itemTotalTextBox.Name = "itemTotalTextBox";
      this.itemTotalTextBox.Size = new System.Drawing.Size(144, 19);
      this.itemTotalTextBox.TabIndex = 3;
      // 
      // b_Cancel
      // 
      this.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.b_Cancel.Location = new System.Drawing.Point(155, 113);
      this.b_Cancel.Name = "b_Cancel";
      this.b_Cancel.Size = new System.Drawing.Size(75, 23);
      this.b_Cancel.TabIndex = 4;
      this.b_Cancel.Text = "キャンセル";
      this.b_Cancel.UseVisualStyleBackColor = true;
      // 
      // productIDComboBox
      // 
      this.productIDComboBox.FormattingEnabled = true;
      this.productIDComboBox.Location = new System.Drawing.Point(86, 12);
      this.productIDComboBox.Name = "productIDComboBox";
      this.productIDComboBox.Size = new System.Drawing.Size(144, 20);
      this.productIDComboBox.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 12);
      this.label1.TabIndex = 6;
      this.label1.Text = "unitPrice";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 66);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 12);
      this.label2.TabIndex = 7;
      this.label2.Text = "quantity";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 8;
      this.label3.Text = "itemTotal";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 15);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 12);
      this.label4.TabIndex = 9;
      this.label4.Text = "Product";
      // 
      // DetailForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(248, 159);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.productIDComboBox);
      this.Controls.Add(this.b_Cancel);
      this.Controls.Add(this.itemTotalTextBox);
      this.Controls.Add(this.quantityTextBox);
      this.Controls.Add(this.b_OK);
      this.Controls.Add(this.unitPriceTextBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "DetailForm";
      this.Text = "DetailForm";
      this.Load += new System.EventHandler(this.DetailForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox unitPriceTextBox;
    private System.Windows.Forms.Button b_OK;
    private System.Windows.Forms.TextBox quantityTextBox;
    private System.Windows.Forms.TextBox itemTotalTextBox;
    private System.Windows.Forms.Button b_Cancel;
    private System.Windows.Forms.ComboBox productIDComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}