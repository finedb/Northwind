namespace Northwind {
  partial class OrdersForm_DIY {
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label orderIDLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm_DIY));
      this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorAcceptItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorRejectItem = new System.Windows.Forms.ToolStripButton();
      this.northwindDataSet = new Northwind.NorthwindDataSet();
      this.orderTotalTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.productsTableAdapter = new Northwind.NorthwindDataSetTableAdapters.ProductsTableAdapter();
      this.employeesTableAdapter = new Northwind.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.ordersTableAdapter = new Northwind.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.order_DetailsTableAdapter = new Northwind.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
      this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.customerIDTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.orderDateTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.orderDetailsAddButton = new System.Windows.Forms.Button();
      this.orderDetailsEditButton = new System.Windows.Forms.Button();
      this.orderDetailsDeleteButton = new System.Windows.Forms.Button();
      this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tableAdapterManager = new Northwind.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.orderIDTextBox = new System.Windows.Forms.TextBox();
      this.order_DetailsDetaGridView = new System.Windows.Forms.DataGridView();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.order_DetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.itemTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      orderIDLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
      this.ordersBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDetaGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // orderIDLabel
      // 
      orderIDLabel.AutoSize = true;
      orderIDLabel.Location = new System.Drawing.Point(54, 85);
      orderIDLabel.Name = "orderIDLabel";
      orderIDLabel.Size = new System.Drawing.Size(50, 12);
      orderIDLabel.TabIndex = 15;
      orderIDLabel.Text = "Order ID:";
      // 
      // ordersBindingNavigator
      // 
      this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem,
            this.ordersBindingNavigatorEditItem,
            this.ordersBindingNavigatorAcceptItem,
            this.ordersBindingNavigatorRejectItem});
      this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.ordersBindingNavigator.Name = "ordersBindingNavigator";
      this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.ordersBindingNavigator.Size = new System.Drawing.Size(698, 25);
      this.ordersBindingNavigator.TabIndex = 0;
      this.ordersBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "新規追加";
      this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
      this.bindingNavigatorCountItem.Text = "/ {0}";
      this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "削除";
      this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
      this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
      this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "位置";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 19);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
      this.bindingNavigatorPositionItem.Leave += new System.EventHandler(this.bindingNavigatorPositionItem_Leave);
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "次に移動";
      this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "最後に移動";
      this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // ordersBindingNavigatorSaveItem
      // 
      this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
      this.ordersBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
      this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(33, 22);
      this.ordersBindingNavigatorSaveItem.Text = "保存";
      this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
      // 
      // ordersBindingNavigatorEditItem
      // 
      this.ordersBindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.ordersBindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorEditItem.Image")));
      this.ordersBindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ordersBindingNavigatorEditItem.Name = "ordersBindingNavigatorEditItem";
      this.ordersBindingNavigatorEditItem.Size = new System.Drawing.Size(33, 22);
      this.ordersBindingNavigatorEditItem.Text = "編集";
      this.ordersBindingNavigatorEditItem.Click += new System.EventHandler(this.ordersBindingNavigatorEditItem_Click);
      // 
      // ordersBindingNavigatorAcceptItem
      // 
      this.ordersBindingNavigatorAcceptItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.ordersBindingNavigatorAcceptItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorAcceptItem.Image")));
      this.ordersBindingNavigatorAcceptItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ordersBindingNavigatorAcceptItem.Name = "ordersBindingNavigatorAcceptItem";
      this.ordersBindingNavigatorAcceptItem.Size = new System.Drawing.Size(33, 22);
      this.ordersBindingNavigatorAcceptItem.Text = "確定";
      this.ordersBindingNavigatorAcceptItem.Click += new System.EventHandler(this.ordersBindingNavigatorAcceptItem_Click);
      // 
      // ordersBindingNavigatorRejectItem
      // 
      this.ordersBindingNavigatorRejectItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.ordersBindingNavigatorRejectItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorRejectItem.Image")));
      this.ordersBindingNavigatorRejectItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ordersBindingNavigatorRejectItem.Name = "ordersBindingNavigatorRejectItem";
      this.ordersBindingNavigatorRejectItem.Size = new System.Drawing.Size(50, 22);
      this.ordersBindingNavigatorRejectItem.Text = "取り消し";
      this.ordersBindingNavigatorRejectItem.Click += new System.EventHandler(this.ordersBindingNavigatorRejectItem_Click);
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // orderTotalTextBox
      // 
      this.orderTotalTextBox.Enabled = false;
      this.orderTotalTextBox.Location = new System.Drawing.Point(110, 183);
      this.orderTotalTextBox.Name = "orderTotalTextBox";
      this.orderTotalTextBox.Size = new System.Drawing.Size(100, 19);
      this.orderTotalTextBox.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(47, 186);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "orderTotal";
      // 
      // productsTableAdapter
      // 
      this.productsTableAdapter.ClearBeforeFill = true;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // order_DetailsTableAdapter
      // 
      this.order_DetailsTableAdapter.ClearBeforeFill = true;
      // 
      // employeeIDComboBox
      // 
      this.employeeIDComboBox.FormattingEnabled = true;
      this.employeeIDComboBox.Location = new System.Drawing.Point(110, 132);
      this.employeeIDComboBox.Name = "employeeIDComboBox";
      this.employeeIDComboBox.Size = new System.Drawing.Size(100, 20);
      this.employeeIDComboBox.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(40, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 12);
      this.label3.TabIndex = 7;
      this.label3.Text = "employeeID";
      // 
      // customerIDTextBox
      // 
      this.customerIDTextBox.Location = new System.Drawing.Point(110, 107);
      this.customerIDTextBox.Name = "customerIDTextBox";
      this.customerIDTextBox.Size = new System.Drawing.Size(100, 19);
      this.customerIDTextBox.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(40, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 12);
      this.label4.TabIndex = 9;
      this.label4.Text = "customerID";
      // 
      // orderDateTextBox
      // 
      this.orderDateTextBox.Location = new System.Drawing.Point(110, 158);
      this.orderDateTextBox.Name = "orderDateTextBox";
      this.orderDateTextBox.Size = new System.Drawing.Size(100, 19);
      this.orderDateTextBox.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(49, 161);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 12);
      this.label5.TabIndex = 11;
      this.label5.Text = "orderDate";
      // 
      // orderDetailsAddButton
      // 
      this.orderDetailsAddButton.Location = new System.Drawing.Point(256, 258);
      this.orderDetailsAddButton.Name = "orderDetailsAddButton";
      this.orderDetailsAddButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsAddButton.TabIndex = 12;
      this.orderDetailsAddButton.Text = "追加";
      this.orderDetailsAddButton.UseVisualStyleBackColor = true;
      this.orderDetailsAddButton.Click += new System.EventHandler(this.orderDetailsAddButton_Click);
      // 
      // orderDetailsEditButton
      // 
      this.orderDetailsEditButton.Location = new System.Drawing.Point(337, 258);
      this.orderDetailsEditButton.Name = "orderDetailsEditButton";
      this.orderDetailsEditButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsEditButton.TabIndex = 12;
      this.orderDetailsEditButton.Text = "編集";
      this.orderDetailsEditButton.UseVisualStyleBackColor = true;
      this.orderDetailsEditButton.Click += new System.EventHandler(this.orderDetailsEditButton_Click);
      // 
      // orderDetailsDeleteButton
      // 
      this.orderDetailsDeleteButton.Location = new System.Drawing.Point(418, 258);
      this.orderDetailsDeleteButton.Name = "orderDetailsDeleteButton";
      this.orderDetailsDeleteButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsDeleteButton.TabIndex = 12;
      this.orderDetailsDeleteButton.Text = "削除";
      this.orderDetailsDeleteButton.UseVisualStyleBackColor = true;
      this.orderDetailsDeleteButton.Click += new System.EventHandler(this.orderDetailsDeleteButton_Click);
      // 
      // order_DetailsBindingSource
      // 
      this.order_DetailsBindingSource.DataMember = "Order Details";
      this.order_DetailsBindingSource.DataSource = this.northwindDataSet;
      this.order_DetailsBindingSource.PositionChanged += new System.EventHandler(this.order_DetailsBindingSource_PositionChanged);
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
      this.tableAdapterManager.Order_DetailsTableAdapter = this.order_DetailsTableAdapter;
      this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
      this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
      this.tableAdapterManager.UpdateOrder = Northwind.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // orderIDTextBox
      // 
      this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailsBindingSource, "OrderID", true));
      this.orderIDTextBox.Location = new System.Drawing.Point(110, 82);
      this.orderIDTextBox.Name = "orderIDTextBox";
      this.orderIDTextBox.Size = new System.Drawing.Size(100, 19);
      this.orderIDTextBox.TabIndex = 16;
      // 
      // order_DetailsDetaGridView
      // 
      this.order_DetailsDetaGridView.AllowUserToAddRows = false;
      this.order_DetailsDetaGridView.AllowUserToDeleteRows = false;
      this.order_DetailsDetaGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.order_DetailsDetaGridView.AutoGenerateColumns = false;
      this.order_DetailsDetaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.order_DetailsDetaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.itemTotalDataGridViewTextBoxColumn});
      this.order_DetailsDetaGridView.DataSource = this.order_DetailsBindingSource;
      this.order_DetailsDetaGridView.Location = new System.Drawing.Point(228, 42);
      this.order_DetailsDetaGridView.Name = "order_DetailsDetaGridView";
      this.order_DetailsDetaGridView.ReadOnly = true;
      this.order_DetailsDetaGridView.RowTemplate.Height = 21;
      this.order_DetailsDetaGridView.Size = new System.Drawing.Size(458, 198);
      this.order_DetailsDetaGridView.TabIndex = 5;
      // 
      // ordersBindingSource
      // 
      this.ordersBindingSource.DataMember = "Orders";
      this.ordersBindingSource.DataSource = this.northwindDataSet;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(110, 42);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(67, 19);
      this.textBox1.TabIndex = 17;
      this.textBox1.Text = "ALFKI";
      // 
      // order_DetailsBindingSource1
      // 
      this.order_DetailsBindingSource1.DataMember = "FK_Order_Details_Orders";
      this.order_DetailsBindingSource1.DataSource = this.ordersBindingSource;
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
      this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
      this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // productIDDataGridViewTextBoxColumn
      // 
      this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
      this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
      this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
      this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // unitPriceDataGridViewTextBoxColumn
      // 
      this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
      this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
      this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
      this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // itemTotalDataGridViewTextBoxColumn
      // 
      this.itemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal";
      this.itemTotalDataGridViewTextBoxColumn.HeaderText = "ItemTotal";
      this.itemTotalDataGridViewTextBoxColumn.Name = "itemTotalDataGridViewTextBoxColumn";
      this.itemTotalDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // OrdersForm_DIY
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(698, 301);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(orderIDLabel);
      this.Controls.Add(this.orderIDTextBox);
      this.Controls.Add(this.orderDetailsDeleteButton);
      this.Controls.Add(this.orderDetailsEditButton);
      this.Controls.Add(this.orderDetailsAddButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.orderDateTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.customerIDTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.employeeIDComboBox);
      this.Controls.Add(this.order_DetailsDetaGridView);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.orderTotalTextBox);
      this.Controls.Add(this.ordersBindingNavigator);
      this.Name = "OrdersForm_DIY";
      this.Text = "OrdersForm_DIY";
      this.Load += new System.EventHandler(this.OrdersForm_DIY_Load_1);
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
      this.ordersBindingNavigator.ResumeLayout(false);
      this.ordersBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDetaGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.TextBox orderTotalTextBox;
    private System.Windows.Forms.Label label2;
    private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    private System.Windows.Forms.ComboBox employeeIDComboBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox customerIDTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox orderDateTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorEditItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorAcceptItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorRejectItem;
    private System.Windows.Forms.Button orderDetailsAddButton;
    private System.Windows.Forms.Button orderDetailsEditButton;
    private System.Windows.Forms.Button orderDetailsDeleteButton;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.TextBox orderIDTextBox;
    private System.Windows.Forms.DataGridView order_DetailsDetaGridView;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource1;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemTotalDataGridViewTextBoxColumn;
  }
}