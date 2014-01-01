namespace Northwind {
  partial class OrdersForm {
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
      System.Windows.Forms.Label customerIDLabel;
      System.Windows.Forms.Label orderDateLabel;
      System.Windows.Forms.Label employeeIDLabel;
      System.Windows.Forms.Label orderTotalLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
      this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new Northwind.NorthwindDataSet();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorAcceptItem = new System.Windows.Forms.ToolStripButton();
      this.ordersBindingNavigatorRejectItem = new System.Windows.Forms.ToolStripButton();
      this.orderIDTextBox = new System.Windows.Forms.TextBox();
      this.customerIDTextBox = new System.Windows.Forms.TextBox();
      this.orderDateTextBox = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.order_DetailsDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.orderDetailsEditButton = new System.Windows.Forms.Button();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ordersTableAdapter = new Northwind.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.tableAdapterManager = new Northwind.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.order_DetailsTableAdapter = new Northwind.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
      this.productsTableAdapter = new Northwind.NorthwindDataSetTableAdapters.ProductsTableAdapter();
      this.employeesTableAdapter = new Northwind.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.orderTotalTextBox = new System.Windows.Forms.TextBox();
      this.orderDetailsDeleteButton = new System.Windows.Forms.Button();
      this.orderDetailsAddButton = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      orderIDLabel = new System.Windows.Forms.Label();
      customerIDLabel = new System.Windows.Forms.Label();
      orderDateLabel = new System.Windows.Forms.Label();
      employeeIDLabel = new System.Windows.Forms.Label();
      orderTotalLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
      this.ordersBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // orderIDLabel
      // 
      orderIDLabel.AutoSize = true;
      orderIDLabel.Location = new System.Drawing.Point(50, 103);
      orderIDLabel.Name = "orderIDLabel";
      orderIDLabel.Size = new System.Drawing.Size(50, 12);
      orderIDLabel.TabIndex = 1;
      orderIDLabel.Text = "Order ID:";
      // 
      // customerIDLabel
      // 
      customerIDLabel.AutoSize = true;
      customerIDLabel.Location = new System.Drawing.Point(29, 128);
      customerIDLabel.Name = "customerIDLabel";
      customerIDLabel.Size = new System.Drawing.Size(71, 12);
      customerIDLabel.TabIndex = 3;
      customerIDLabel.Text = "Customer ID:";
      // 
      // orderDateLabel
      // 
      orderDateLabel.AutoSize = true;
      orderDateLabel.Location = new System.Drawing.Point(37, 178);
      orderDateLabel.Name = "orderDateLabel";
      orderDateLabel.Size = new System.Drawing.Size(63, 12);
      orderDateLabel.TabIndex = 11;
      orderDateLabel.Text = "Order Date:";
      // 
      // employeeIDLabel
      // 
      employeeIDLabel.AutoSize = true;
      employeeIDLabel.Location = new System.Drawing.Point(29, 153);
      employeeIDLabel.Name = "employeeIDLabel";
      employeeIDLabel.Size = new System.Drawing.Size(71, 12);
      employeeIDLabel.TabIndex = 5;
      employeeIDLabel.Text = "Employee ID:";
      // 
      // orderTotalLabel
      // 
      orderTotalLabel.AutoSize = true;
      orderTotalLabel.Location = new System.Drawing.Point(35, 219);
      orderTotalLabel.Name = "orderTotalLabel";
      orderTotalLabel.Size = new System.Drawing.Size(65, 12);
      orderTotalLabel.TabIndex = 16;
      orderTotalLabel.Text = "Order Total:";
      // 
      // ordersBindingNavigator
      // 
      this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
      this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.ordersBindingNavigator.DeleteItem = null;
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
      this.ordersBindingNavigator.Size = new System.Drawing.Size(773, 25);
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
      // ordersBindingSource
      // 
      this.ordersBindingSource.DataMember = "Orders";
      this.ordersBindingSource.DataSource = this.northwindDataSet;
      this.ordersBindingSource.PositionChanged += new System.EventHandler(this.ordersBindingSource_PositionChanged);
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
      this.bindingNavigatorCountItem.Text = "/ {0}";
      this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
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
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "最後に移動";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // ordersBindingNavigatorSaveItem
      // 
      this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
      this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
      this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.ordersBindingNavigatorSaveItem.Text = "データの保存";
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
      // orderIDTextBox
      // 
      this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
      this.orderIDTextBox.Enabled = false;
      this.orderIDTextBox.Location = new System.Drawing.Point(106, 100);
      this.orderIDTextBox.Name = "orderIDTextBox";
      this.orderIDTextBox.Size = new System.Drawing.Size(116, 19);
      this.orderIDTextBox.TabIndex = 2;
      // 
      // customerIDTextBox
      // 
      this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
      this.customerIDTextBox.Location = new System.Drawing.Point(106, 125);
      this.customerIDTextBox.Name = "customerIDTextBox";
      this.customerIDTextBox.Size = new System.Drawing.Size(116, 19);
      this.customerIDTextBox.TabIndex = 4;
      // 
      // orderDateTextBox
      // 
      this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderDate", true));
      this.orderDateTextBox.Location = new System.Drawing.Point(106, 175);
      this.orderDateTextBox.Name = "orderDateTextBox";
      this.orderDateTextBox.Size = new System.Drawing.Size(116, 19);
      this.orderDateTextBox.TabIndex = 12;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.order_DetailsDataGridView);
      this.groupBox1.Location = new System.Drawing.Point(238, 37);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(535, 285);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "注文詳細";
      // 
      // order_DetailsDataGridView
      // 
      this.order_DetailsDataGridView.AllowUserToAddRows = false;
      this.order_DetailsDataGridView.AllowUserToDeleteRows = false;
      this.order_DetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.order_DetailsDataGridView.AutoGenerateColumns = false;
      this.order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.order_DetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.order_DetailsDataGridView.DataSource = this.order_DetailsBindingSource;
      this.order_DetailsDataGridView.Location = new System.Drawing.Point(6, 18);
      this.order_DetailsDataGridView.Name = "order_DetailsDataGridView";
      this.order_DetailsDataGridView.ReadOnly = true;
      this.order_DetailsDataGridView.RowTemplate.Height = 21;
      this.order_DetailsDataGridView.Size = new System.Drawing.Size(517, 261);
      this.order_DetailsDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
      this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
      this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
      this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
      this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemTotal";
      this.dataGridViewTextBoxColumn5.HeaderText = "ItemTotal";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // order_DetailsBindingSource
      // 
      this.order_DetailsBindingSource.DataMember = "FK_Order_Details_Orders";
      this.order_DetailsBindingSource.DataSource = this.ordersBindingSource;
      this.order_DetailsBindingSource.PositionChanged += new System.EventHandler(this.order_DetailsBindingSource_PositionChanged);
      // 
      // orderDetailsEditButton
      // 
      this.orderDetailsEditButton.Location = new System.Drawing.Point(423, 328);
      this.orderDetailsEditButton.Name = "orderDetailsEditButton";
      this.orderDetailsEditButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsEditButton.TabIndex = 14;
      this.orderDetailsEditButton.Text = "編集";
      this.orderDetailsEditButton.UseVisualStyleBackColor = true;
      this.orderDetailsEditButton.Click += new System.EventHandler(this.orderDetailsEditButton_Click);
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataMember = "Products";
      this.productsBindingSource.DataSource = this.northwindDataSet;
      // 
      // employeeIDComboBox
      // 
      this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "EmployeeID", true));
      this.employeeIDComboBox.DataSource = this.employeesBindingSource;
      this.employeeIDComboBox.DisplayMember = "EmployName";
      this.employeeIDComboBox.FormattingEnabled = true;
      this.employeeIDComboBox.Location = new System.Drawing.Point(106, 150);
      this.employeeIDComboBox.Name = "employeeIDComboBox";
      this.employeeIDComboBox.Size = new System.Drawing.Size(116, 20);
      this.employeeIDComboBox.TabIndex = 16;
      this.employeeIDComboBox.ValueMember = "EmployeeID";
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.northwindDataSet;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = this.order_DetailsTableAdapter;
      this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = Northwind.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // order_DetailsTableAdapter
      // 
      this.order_DetailsTableAdapter.ClearBeforeFill = true;
      // 
      // productsTableAdapter
      // 
      this.productsTableAdapter.ClearBeforeFill = true;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // orderTotalTextBox
      // 
      this.orderTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
      this.orderTotalTextBox.Location = new System.Drawing.Point(106, 216);
      this.orderTotalTextBox.Name = "orderTotalTextBox";
      this.orderTotalTextBox.ReadOnly = true;
      this.orderTotalTextBox.Size = new System.Drawing.Size(116, 19);
      this.orderTotalTextBox.TabIndex = 17;
      // 
      // orderDetailsDeleteButton
      // 
      this.orderDetailsDeleteButton.Location = new System.Drawing.Point(526, 328);
      this.orderDetailsDeleteButton.Name = "orderDetailsDeleteButton";
      this.orderDetailsDeleteButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsDeleteButton.TabIndex = 18;
      this.orderDetailsDeleteButton.Text = "削除";
      this.orderDetailsDeleteButton.UseVisualStyleBackColor = true;
      this.orderDetailsDeleteButton.Click += new System.EventHandler(this.orderDetailsDeleteButton_Click);
      // 
      // orderDetailsAddBUtton
      // 
      this.orderDetailsAddButton.Location = new System.Drawing.Point(264, 328);
      this.orderDetailsAddButton.Name = "orderDetailsAddBUtton";
      this.orderDetailsAddButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsAddButton.TabIndex = 19;
      this.orderDetailsAddButton.Text = "追加";
      this.orderDetailsAddButton.UseVisualStyleBackColor = true;
      this.orderDetailsAddButton.Click += new System.EventHandler(this.orderDetailsAddButton_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(106, 75);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(66, 19);
      this.textBox1.TabIndex = 20;
      this.textBox1.Text = "ALFKI";
      // 
      // OrdersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(773, 363);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.orderDetailsAddButton);
      this.Controls.Add(this.orderDetailsDeleteButton);
      this.Controls.Add(orderTotalLabel);
      this.Controls.Add(this.orderTotalTextBox);
      this.Controls.Add(this.employeeIDComboBox);
      this.Controls.Add(this.orderDetailsEditButton);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(orderDateLabel);
      this.Controls.Add(this.orderDateTextBox);
      this.Controls.Add(employeeIDLabel);
      this.Controls.Add(customerIDLabel);
      this.Controls.Add(this.customerIDTextBox);
      this.Controls.Add(orderIDLabel);
      this.Controls.Add(this.orderIDTextBox);
      this.Controls.Add(this.ordersBindingNavigator);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "OrdersForm";
      this.Text = "注文の編集";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
      this.Load += new System.EventHandler(this.OrderForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
      this.ordersBindingNavigator.ResumeLayout(false);
      this.ordersBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
    private System.Windows.Forms.TextBox orderIDTextBox;
    private System.Windows.Forms.TextBox customerIDTextBox;
    private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorEditItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorAcceptItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorRejectItem;
    private System.Windows.Forms.TextBox orderDateTextBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource;
    private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    private System.Windows.Forms.Button orderDetailsEditButton;
    private System.Windows.Forms.BindingSource productsBindingSource;
    private System.Windows.Forms.ComboBox employeeIDComboBox;
    private System.Windows.Forms.BindingSource employeesBindingSource;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private System.Windows.Forms.TextBox orderTotalTextBox;
    private System.Windows.Forms.Button orderDetailsDeleteButton;
    private System.Windows.Forms.Button orderDetailsAddButton;
    private System.Windows.Forms.DataGridView order_DetailsDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.TextBox textBox1;
  }
}