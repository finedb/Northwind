namespace Northwind {
  partial class DetailFormCode {
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
      this.quantityTextBox = new System.Windows.Forms.TextBox();
      this.itemTotalTextBox = new System.Windows.Forms.TextBox();
      this.productIDComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // unitPriceTextBox
      // 
      this.unitPriceTextBox.Location = new System.Drawing.Point(97, 40);
      this.unitPriceTextBox.Name = "unitPriceTextBox";
      this.unitPriceTextBox.Size = new System.Drawing.Size(140, 19);
      this.unitPriceTextBox.TabIndex = 0;
      // 
      // quantityTextBox
      // 
      this.quantityTextBox.Location = new System.Drawing.Point(97, 65);
      this.quantityTextBox.Name = "quantityTextBox";
      this.quantityTextBox.Size = new System.Drawing.Size(140, 19);
      this.quantityTextBox.TabIndex = 0;
      this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
      // 
      // itemTotalTextBox
      // 
      this.itemTotalTextBox.Location = new System.Drawing.Point(97, 90);
      this.itemTotalTextBox.Name = "itemTotalTextBox";
      this.itemTotalTextBox.Size = new System.Drawing.Size(140, 19);
      this.itemTotalTextBox.TabIndex = 0;
      // 
      // productIDComboBox
      // 
      this.productIDComboBox.FormattingEnabled = true;
      this.productIDComboBox.Location = new System.Drawing.Point(97, 14);
      this.productIDComboBox.Name = "productIDComboBox";
      this.productIDComboBox.Size = new System.Drawing.Size(140, 20);
      this.productIDComboBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "productID";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(41, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "unitPrice";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(45, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "quantity";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(38, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 12);
      this.label4.TabIndex = 2;
      this.label4.Text = "itemTotal";
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(47, 115);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(162, 115);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "キャンセル";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // DetailFormCode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 152);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.productIDComboBox);
      this.Controls.Add(this.itemTotalTextBox);
      this.Controls.Add(this.quantityTextBox);
      this.Controls.Add(this.unitPriceTextBox);
      this.Name = "DetailFormCode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "DetailFormCode";
      this.Load += new System.EventHandler(this.DetailFormCode_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox unitPriceTextBox;
    private System.Windows.Forms.TextBox quantityTextBox;
    private System.Windows.Forms.TextBox itemTotalTextBox;
    private System.Windows.Forms.ComboBox productIDComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}