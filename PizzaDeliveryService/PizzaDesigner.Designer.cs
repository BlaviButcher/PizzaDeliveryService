namespace PizzaDeliveryService
{
    partial class PizzaDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._ingredientsGrid = new System.Windows.Forms.DataGridView();
            this._addIngredientButton = new System.Windows.Forms.Button();
            this._removePizzaButton = new System.Windows.Forms.Button();
            this._removeIngredientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._removePizzaIngredientbutton = new System.Windows.Forms.Button();
            this._pizzaGrid = new System.Windows.Forms.DataGridView();
            this.IngredientsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addedIngredientsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeterianDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pizzaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardServingSizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeterianDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardServingSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegeterianDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pizzaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._addedIngredientsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _ingredientsGrid
            // 
            this._ingredientsGrid.AutoGenerateColumns = false;
            this._ingredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ingredientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.standardServingSizeDataGridViewTextBoxColumn,
            this.energyValueDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.vegeterianDataGridViewCheckBoxColumn});
            this._ingredientsGrid.DataSource = this.ingredientBindingSource;
            this._ingredientsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingredientsGrid.Location = new System.Drawing.Point(594, 29);
            this._ingredientsGrid.Margin = new System.Windows.Forms.Padding(2);
            this._ingredientsGrid.Name = "_ingredientsGrid";
            this._ingredientsGrid.RowHeadersWidth = 51;
            this._ingredientsGrid.RowTemplate.Height = 24;
            this._ingredientsGrid.Size = new System.Drawing.Size(589, 247);
            this._ingredientsGrid.TabIndex = 0;
            this._ingredientsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._ingredientsGrid_CellFormatting);
            this._ingredientsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._ingredientsGrid_CellValueChanged);
            // 
            // _addIngredientButton
            // 
            this._addIngredientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._addIngredientButton.Location = new System.Drawing.Point(36, 17);
            this._addIngredientButton.Margin = new System.Windows.Forms.Padding(2);
            this._addIngredientButton.Name = "_addIngredientButton";
            this._addIngredientButton.Size = new System.Drawing.Size(547, 44);
            this._addIngredientButton.TabIndex = 3;
            this._addIngredientButton.Text = "Add Ingredient";
            this._addIngredientButton.UseVisualStyleBackColor = true;
            this._addIngredientButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // _removePizzaButton
            // 
            this._removePizzaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._removePizzaButton.Location = new System.Drawing.Point(36, 161);
            this._removePizzaButton.Margin = new System.Windows.Forms.Padding(2);
            this._removePizzaButton.Name = "_removePizzaButton";
            this._removePizzaButton.Size = new System.Drawing.Size(547, 44);
            this._removePizzaButton.TabIndex = 4;
            this._removePizzaButton.Text = "Remove Pizza";
            this._removePizzaButton.UseVisualStyleBackColor = true;
            this._removePizzaButton.Click += new System.EventHandler(this.removePizzaButton_Click);
            // 
            // _removeIngredientButton
            // 
            this._removeIngredientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._removeIngredientButton.Location = new System.Drawing.Point(36, 113);
            this._removeIngredientButton.Margin = new System.Windows.Forms.Padding(2);
            this._removeIngredientButton.Name = "_removeIngredientButton";
            this._removeIngredientButton.Size = new System.Drawing.Size(547, 44);
            this._removeIngredientButton.TabIndex = 5;
            this._removeIngredientButton.Text = "Remove Ingredient";
            this._removeIngredientButton.UseVisualStyleBackColor = true;
            this._removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pizzas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Ingredients";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pizza Toppings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _removePizzaIngredientbutton
            // 
            this._removePizzaIngredientbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._removePizzaIngredientbutton.Location = new System.Drawing.Point(36, 66);
            this._removePizzaIngredientbutton.Margin = new System.Windows.Forms.Padding(2);
            this._removePizzaIngredientbutton.Name = "_removePizzaIngredientbutton";
            this._removePizzaIngredientbutton.Size = new System.Drawing.Size(547, 44);
            this._removePizzaIngredientbutton.TabIndex = 9;
            this._removePizzaIngredientbutton.Text = "Remove Pizza Topping";
            this._removePizzaIngredientbutton.UseVisualStyleBackColor = true;
            this._removePizzaIngredientbutton.Click += new System.EventHandler(this._removePizzaIngredientbutton_Click);
            // 
            // _pizzaGrid
            // 
            this._pizzaGrid.AllowUserToDeleteRows = false;
            this._pizzaGrid.AutoGenerateColumns = false;
            this._pizzaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._pizzaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.IngredientsCount,
            this.Energy,
            this.vegeterianDataGridViewCheckBoxColumn2,
            this.PurchasePrice,
            this.dataGridViewTextBoxColumn1});
            this._pizzaGrid.DataSource = this.pizzaBindingSource1;
            this._pizzaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pizzaGrid.Location = new System.Drawing.Point(2, 29);
            this._pizzaGrid.Margin = new System.Windows.Forms.Padding(2);
            this._pizzaGrid.Name = "_pizzaGrid";
            this._pizzaGrid.RowHeadersWidth = 51;
            this._pizzaGrid.RowTemplate.Height = 24;
            this._pizzaGrid.Size = new System.Drawing.Size(588, 247);
            this._pizzaGrid.TabIndex = 10;
            this._pizzaGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._pizzaGrid_CellFormatting);
            this._pizzaGrid.SelectionChanged += new System.EventHandler(this._pizzaGrid_SelectionChanged_1);
            // 
            // IngredientsCount
            // 
            this.IngredientsCount.DataPropertyName = "IngredientsCount";
            this.IngredientsCount.HeaderText = "Ingredients Added";
            this.IngredientsCount.MinimumWidth = 6;
            this.IngredientsCount.Name = "IngredientsCount";
            this.IngredientsCount.ReadOnly = true;
            this.IngredientsCount.Width = 125;
            // 
            // Energy
            // 
            this.Energy.DataPropertyName = "Energy";
            this.Energy.HeaderText = "Energy";
            this.Energy.MinimumWidth = 6;
            this.Energy.Name = "Energy";
            this.Energy.ReadOnly = true;
            this.Energy.Width = 125;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.MinimumWidth = 6;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RetailPrice";
            dataGridViewCellStyle3.Format = "C2";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "RetailPrice";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // _addedIngredientsGrid
            // 
            this._addedIngredientsGrid.AutoGenerateColumns = false;
            this._addedIngredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._addedIngredientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.standardServingSizeDataGridViewTextBoxColumn1,
            this.energyValueDataGridViewTextBoxColumn1,
            this.purchasePriceDataGridViewTextBoxColumn1,
            this.vegeterianDataGridViewCheckBoxColumn1});
            this._addedIngredientsGrid.DataSource = this.ingredientBindingSource;
            this._addedIngredientsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addedIngredientsGrid.Location = new System.Drawing.Point(2, 307);
            this._addedIngredientsGrid.Margin = new System.Windows.Forms.Padding(2);
            this._addedIngredientsGrid.Name = "_addedIngredientsGrid";
            this._addedIngredientsGrid.ReadOnly = true;
            this._addedIngredientsGrid.RowHeadersWidth = 51;
            this._addedIngredientsGrid.RowTemplate.Height = 24;
            this._addedIngredientsGrid.Size = new System.Drawing.Size(588, 249);
            this._addedIngredientsGrid.TabIndex = 11;
            this._addedIngredientsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._addedIngredientsGrid_CellFormatting);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._pizzaGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._addedIngredientsGrid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._ingredientsGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 558);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._addIngredientButton);
            this.panel1.Controls.Add(this._removeIngredientButton);
            this.panel1.Controls.Add(this._removePizzaIngredientbutton);
            this.panel1.Controls.Add(this._removePizzaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(594, 307);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 249);
            this.panel1.TabIndex = 13;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vegeterianDataGridViewCheckBoxColumn2
            // 
            this.vegeterianDataGridViewCheckBoxColumn2.DataPropertyName = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn2.HeaderText = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.vegeterianDataGridViewCheckBoxColumn2.Name = "vegeterianDataGridViewCheckBoxColumn2";
            this.vegeterianDataGridViewCheckBoxColumn2.ReadOnly = true;
            this.vegeterianDataGridViewCheckBoxColumn2.Width = 125;
            // 
            // pizzaBindingSource1
            // 
            this.pizzaBindingSource1.DataSource = typeof(PizzaDeliveryService.Pizza);
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // standardServingSizeDataGridViewTextBoxColumn1
            // 
            this.standardServingSizeDataGridViewTextBoxColumn1.DataPropertyName = "StandardServingSize";
            this.standardServingSizeDataGridViewTextBoxColumn1.HeaderText = "Serving Size";
            this.standardServingSizeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.standardServingSizeDataGridViewTextBoxColumn1.Name = "standardServingSizeDataGridViewTextBoxColumn1";
            this.standardServingSizeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.standardServingSizeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // energyValueDataGridViewTextBoxColumn1
            // 
            this.energyValueDataGridViewTextBoxColumn1.DataPropertyName = "EnergyValue";
            this.energyValueDataGridViewTextBoxColumn1.HeaderText = "Energy";
            this.energyValueDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.energyValueDataGridViewTextBoxColumn1.Name = "energyValueDataGridViewTextBoxColumn1";
            this.energyValueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.energyValueDataGridViewTextBoxColumn1.Width = 125;
            // 
            // purchasePriceDataGridViewTextBoxColumn1
            // 
            this.purchasePriceDataGridViewTextBoxColumn1.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle4.Format = "C2";
            this.purchasePriceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.purchasePriceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.purchasePriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.purchasePriceDataGridViewTextBoxColumn1.Name = "purchasePriceDataGridViewTextBoxColumn1";
            this.purchasePriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.purchasePriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vegeterianDataGridViewCheckBoxColumn1
            // 
            this.vegeterianDataGridViewCheckBoxColumn1.DataPropertyName = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn1.HeaderText = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.vegeterianDataGridViewCheckBoxColumn1.Name = "vegeterianDataGridViewCheckBoxColumn1";
            this.vegeterianDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.vegeterianDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataSource = typeof(PizzaDeliveryService.Ingredient);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // standardServingSizeDataGridViewTextBoxColumn
            // 
            this.standardServingSizeDataGridViewTextBoxColumn.DataPropertyName = "StandardServingSize";
            this.standardServingSizeDataGridViewTextBoxColumn.HeaderText = "Standard Serving";
            this.standardServingSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.standardServingSizeDataGridViewTextBoxColumn.Name = "standardServingSizeDataGridViewTextBoxColumn";
            this.standardServingSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // energyValueDataGridViewTextBoxColumn
            // 
            this.energyValueDataGridViewTextBoxColumn.DataPropertyName = "EnergyValue";
            this.energyValueDataGridViewTextBoxColumn.HeaderText = "Energy";
            this.energyValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.energyValueDataGridViewTextBoxColumn.Name = "energyValueDataGridViewTextBoxColumn";
            this.energyValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.purchasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // vegeterianDataGridViewCheckBoxColumn
            // 
            this.vegeterianDataGridViewCheckBoxColumn.DataPropertyName = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn.HeaderText = "Vegeterian";
            this.vegeterianDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.vegeterianDataGridViewCheckBoxColumn.Name = "vegeterianDataGridViewCheckBoxColumn";
            this.vegeterianDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pizzaBindingSource
            // 
            this.pizzaBindingSource.DataSource = typeof(PizzaDeliveryService.Pizza);
            // 
            // PizzaDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "PizzaDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PizzaDesigner";
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pizzaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._addedIngredientsGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _ingredientsGrid;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private System.Windows.Forms.BindingSource pizzaBindingSource;
        private System.Windows.Forms.Button _addIngredientButton;
        private System.Windows.Forms.Button _removePizzaButton;
        private System.Windows.Forms.Button _removeIngredientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _removePizzaIngredientbutton;
        private System.Windows.Forms.DataGridView _pizzaGrid;
        private System.Windows.Forms.DataGridView _addedIngredientsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardServingSizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vegeterianDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardServingSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vegeterianDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource pizzaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vegeterianDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

