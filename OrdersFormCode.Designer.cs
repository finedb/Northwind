namespace Northwind {
  partial class OrdersFormCode {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersFormCode));
      this.orderIDTextBox = new System.Windows.Forms.TextBox();
      this.customerIDTextBox = new System.Windows.Forms.TextBox();
      this.orderDateTextBox = new System.Windows.Forms.TextBox();
      this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.sample = new System.Windows.Forms.TextBox();
      this.orderTotalTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.orderDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
      this.orderDetailsAddButton = new System.Windows.Forms.Button();
      this.orderDetailsEditButton = new System.Windows.Forms.Button();
      this.orderDetailsDeleteButton = new System.Windows.Forms.Button();
      this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
      this.northwindDataSetCode = new Northwind.NorthwindDataSetCode();
      this.DataTablebutton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).BeginInit();
      this.orderDetailsBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
      this.orderBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCode)).BeginInit();
      this.SuspendLayout();
      // 
      // orderIDTextBox
      // 
      this.orderIDTextBox.Location = new System.Drawing.Point(81, 95);
      this.orderIDTextBox.Name = "orderIDTextBox";
      this.orderIDTextBox.ReadOnly = true;
      this.orderIDTextBox.Size = new System.Drawing.Size(122, 19);
      this.orderIDTextBox.TabIndex = 0;
      // 
      // customerIDTextBox
      // 
      this.customerIDTextBox.Location = new System.Drawing.Point(81, 120);
      this.customerIDTextBox.Name = "customerIDTextBox";
      this.customerIDTextBox.Size = new System.Drawing.Size(122, 19);
      this.customerIDTextBox.TabIndex = 0;
      // 
      // orderDateTextBox
      // 
      this.orderDateTextBox.Location = new System.Drawing.Point(81, 171);
      this.orderDateTextBox.Name = "orderDateTextBox";
      this.orderDateTextBox.Size = new System.Drawing.Size(122, 19);
      this.orderDateTextBox.TabIndex = 0;
      // 
      // employeeIDComboBox
      // 
      this.employeeIDComboBox.FormattingEnabled = true;
      this.employeeIDComboBox.Location = new System.Drawing.Point(81, 145);
      this.employeeIDComboBox.Name = "employeeIDComboBox";
      this.employeeIDComboBox.Size = new System.Drawing.Size(122, 20);
      this.employeeIDComboBox.TabIndex = 1;
      this.employeeIDComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeIDComboBox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "Order ID";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 123);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "Customer ID";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 148);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "Employee ID";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 174);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 12);
      this.label4.TabIndex = 2;
      this.label4.Text = "Order Date";
      // 
      // sample
      // 
      this.sample.Location = new System.Drawing.Point(81, 55);
      this.sample.Name = "sample";
      this.sample.ReadOnly = true;
      this.sample.Size = new System.Drawing.Size(66, 19);
      this.sample.TabIndex = 3;
      this.sample.Text = "ALFKI";
      // 
      // orderTotalTextBox
      // 
      this.orderTotalTextBox.Location = new System.Drawing.Point(81, 218);
      this.orderTotalTextBox.Name = "orderTotalTextBox";
      this.orderTotalTextBox.ReadOnly = true;
      this.orderTotalTextBox.Size = new System.Drawing.Size(122, 19);
      this.orderTotalTextBox.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 221);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 12);
      this.label5.TabIndex = 5;
      this.label5.Text = "Order Total";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.orderDetailsBindingNavigator);
      this.groupBox1.Controls.Add(this.orderDetailsDataGridView);
      this.groupBox1.Location = new System.Drawing.Point(209, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(482, 205);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "注文詳細";
      // 
      // orderDetailsBindingNavigator
      // 
      this.orderDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
      this.orderDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
      this.orderDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.orderDetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
      this.orderDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
      this.orderDetailsBindingNavigator.Location = new System.Drawing.Point(6, 177);
      this.orderDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.orderDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.orderDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.orderDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.orderDetailsBindingNavigator.Name = "orderDetailsBindingNavigator";
      this.orderDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
      this.orderDetailsBindingNavigator.Size = new System.Drawing.Size(245, 25);
      this.orderDetailsBindingNavigator.TabIndex = 1;
      this.orderDetailsBindingNavigator.Text = "bindingNavigator2";
      // 
      // bindingNavigatorAddNewItem1
      // 
      this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
      this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
      this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem1.Text = "新規追加";
      // 
      // bindingNavigatorCountItem1
      // 
      this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
      this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(27, 22);
      this.bindingNavigatorCountItem1.Text = "/ {0}";
      this.bindingNavigatorCountItem1.ToolTipText = "項目の総数";
      // 
      // bindingNavigatorDeleteItem1
      // 
      this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
      this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
      this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem1.Text = "削除";
      // 
      // bindingNavigatorMoveFirstItem1
      // 
      this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
      this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
      this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem1.Text = "最初に移動";
      // 
      // bindingNavigatorMovePreviousItem1
      // 
      this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
      this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
      this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem1.Text = "前に戻る";
      // 
      // bindingNavigatorSeparator3
      // 
      this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
      this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem1
      // 
      this.bindingNavigatorPositionItem1.AccessibleName = "位置";
      this.bindingNavigatorPositionItem1.AutoSize = false;
      this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
      this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 19);
      this.bindingNavigatorPositionItem1.Text = "0";
      this.bindingNavigatorPositionItem1.ToolTipText = "現在の場所";
      // 
      // bindingNavigatorSeparator4
      // 
      this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
      this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem1
      // 
      this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
      this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
      this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem1.Text = "次に移動";
      // 
      // bindingNavigatorMoveLastItem1
      // 
      this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
      this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
      this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem1.Text = "最後に移動";
      // 
      // bindingNavigatorSeparator5
      // 
      this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
      this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // orderDetailsDataGridView
      // 
      this.orderDetailsDataGridView.AllowUserToAddRows = false;
      this.orderDetailsDataGridView.AllowUserToDeleteRows = false;
      this.orderDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.orderDetailsDataGridView.Location = new System.Drawing.Point(6, 18);
      this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
      this.orderDetailsDataGridView.ReadOnly = true;
      this.orderDetailsDataGridView.RowTemplate.Height = 21;
      this.orderDetailsDataGridView.Size = new System.Drawing.Size(470, 156);
      this.orderDetailsDataGridView.TabIndex = 0;
      // 
      // orderDetailsAddButton
      // 
      this.orderDetailsAddButton.Location = new System.Drawing.Point(266, 239);
      this.orderDetailsAddButton.Name = "orderDetailsAddButton";
      this.orderDetailsAddButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsAddButton.TabIndex = 7;
      this.orderDetailsAddButton.Text = "追加";
      this.orderDetailsAddButton.UseVisualStyleBackColor = true;
      this.orderDetailsAddButton.Click += new System.EventHandler(this.orderDetailsAddButton_Click);
      // 
      // orderDetailsEditButton
      // 
      this.orderDetailsEditButton.Location = new System.Drawing.Point(364, 239);
      this.orderDetailsEditButton.Name = "orderDetailsEditButton";
      this.orderDetailsEditButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsEditButton.TabIndex = 7;
      this.orderDetailsEditButton.Text = "編集";
      this.orderDetailsEditButton.UseVisualStyleBackColor = true;
      this.orderDetailsEditButton.Click += new System.EventHandler(this.orderDetailsEditButton_Click);
      // 
      // orderDetailsDeleteButton
      // 
      this.orderDetailsDeleteButton.Location = new System.Drawing.Point(465, 239);
      this.orderDetailsDeleteButton.Name = "orderDetailsDeleteButton";
      this.orderDetailsDeleteButton.Size = new System.Drawing.Size(75, 23);
      this.orderDetailsDeleteButton.TabIndex = 7;
      this.orderDetailsDeleteButton.Text = "削除";
      this.orderDetailsDeleteButton.UseVisualStyleBackColor = true;
      this.orderDetailsDeleteButton.Click += new System.EventHandler(this.orderDetailsDeleteButton_Click);
      // 
      // orderBindingNavigator
      // 
      this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.orderBindingNavigator.DeleteItem = null;
      this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
      this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.orderBindingNavigator.Name = "orderBindingNavigator";
      this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.orderBindingNavigator.Size = new System.Drawing.Size(702, 25);
      this.orderBindingNavigator.TabIndex = 8;
      this.orderBindingNavigator.Text = "bindingNavigator1";
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
      this.ordersBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
      this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
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
      this.ordersBindingNavigatorRejectItem.Size = new System.Drawing.Size(33, 22);
      this.ordersBindingNavigatorRejectItem.Text = "取消";
      this.ordersBindingNavigatorRejectItem.Click += new System.EventHandler(this.ordersBindingNavigatorRejectItem_Click);
      // 
      // northwindDataSetCode
      // 
      this.northwindDataSetCode.DataSetName = "NorthwindDataSetCode";
      this.northwindDataSetCode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // DataTablebutton
      // 
      this.DataTablebutton.Location = new System.Drawing.Point(29, 256);
      this.DataTablebutton.Name = "DataTablebutton";
      this.DataTablebutton.Size = new System.Drawing.Size(75, 23);
      this.DataTablebutton.TabIndex = 9;
      this.DataTablebutton.Text = "DataTable";
      this.DataTablebutton.UseVisualStyleBackColor = true;
      this.DataTablebutton.Click += new System.EventHandler(this.DataTablebutton_Click);
      // 
      // OrdersFormCode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(702, 278);
      this.Controls.Add(this.DataTablebutton);
      this.Controls.Add(this.orderBindingNavigator);
      this.Controls.Add(this.orderDetailsDeleteButton);
      this.Controls.Add(this.orderDetailsEditButton);
      this.Controls.Add(this.orderDetailsAddButton);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.orderTotalTextBox);
      this.Controls.Add(this.sample);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.employeeIDComboBox);
      this.Controls.Add(this.orderDateTextBox);
      this.Controls.Add(this.customerIDTextBox);
      this.Controls.Add(this.orderIDTextBox);
      this.Name = "OrdersFormCode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "注文の編集";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersFormCode_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).EndInit();
      this.orderDetailsBindingNavigator.ResumeLayout(false);
      this.orderDetailsBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
      this.orderBindingNavigator.ResumeLayout(false);
      this.orderBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCode)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox orderIDTextBox;
    private System.Windows.Forms.TextBox customerIDTextBox;
    private System.Windows.Forms.TextBox orderDateTextBox;
    private System.Windows.Forms.ComboBox employeeIDComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox sample;
    private System.Windows.Forms.TextBox orderTotalTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView orderDetailsDataGridView;
    private System.Windows.Forms.Button orderDetailsAddButton;
    private System.Windows.Forms.Button orderDetailsEditButton;
    private System.Windows.Forms.Button orderDetailsDeleteButton;
    private System.Windows.Forms.BindingNavigator orderDetailsBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    private System.Windows.Forms.BindingNavigator orderBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorEditItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorAcceptItem;
    private System.Windows.Forms.ToolStripButton ordersBindingNavigatorRejectItem;
    private NorthwindDataSetCode northwindDataSetCode;
    private System.Windows.Forms.Button DataTablebutton;
  }
}