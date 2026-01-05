namespace POS
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbSupp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txSellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txDecs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStokView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillScreenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockValueReminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLowStockItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbItemCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btSummary = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btViewAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.cbSupp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txSellPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txDecs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txItemCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 562);
            this.panel1.TabIndex = 0;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Red;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Image = global::POS.Properties.Resources.cleaning1;
            this.btClear.Location = new System.Drawing.Point(161, 515);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(98, 40);
            this.btClear.TabIndex = 17;
            this.btClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = global::POS.Properties.Resources.add1;
            this.btAdd.Location = new System.Drawing.Point(19, 515);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(136, 40);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = " &Add Item";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbSupp
            // 
            this.cbSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupp.FormattingEnabled = true;
            this.cbSupp.Location = new System.Drawing.Point(19, 416);
            this.cbSupp.Name = "cbSupp";
            this.cbSupp.Size = new System.Drawing.Size(240, 28);
            this.cbSupp.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Supplier :";
            // 
            // txSellPrice
            // 
            this.txSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSellPrice.Location = new System.Drawing.Point(19, 354);
            this.txSellPrice.Name = "txSellPrice";
            this.txSellPrice.Size = new System.Drawing.Size(240, 27);
            this.txSellPrice.TabIndex = 11;
            this.txSellPrice.TextChanged += new System.EventHandler(this.txSellPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "MRP / Selling Price :";
            // 
            // txValue
            // 
            this.txValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValue.Location = new System.Drawing.Point(19, 292);
            this.txValue.Name = "txValue";
            this.txValue.ReadOnly = true;
            this.txValue.Size = new System.Drawing.Size(240, 27);
            this.txValue.TabIndex = 9;
            this.txValue.TextChanged += new System.EventHandler(this.txValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Purchase Value :";
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(19, 230);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(240, 27);
            this.txPrice.TabIndex = 7;
            this.txPrice.TextChanged += new System.EventHandler(this.txPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Purchasing Price :";
            // 
            // txQuantity
            // 
            this.txQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantity.Location = new System.Drawing.Point(19, 168);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(240, 27);
            this.txQuantity.TabIndex = 5;
            this.txQuantity.TextChanged += new System.EventHandler(this.txQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchasing Quantity :";
            // 
            // txDecs
            // 
            this.txDecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDecs.Location = new System.Drawing.Point(19, 106);
            this.txDecs.Name = "txDecs";
            this.txDecs.Size = new System.Drawing.Size(240, 27);
            this.txDecs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // txItemCode
            // 
            this.txItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txItemCode.Location = new System.Drawing.Point(19, 44);
            this.txItemCode.Name = "txItemCode";
            this.txItemCode.Size = new System.Drawing.Size(240, 27);
            this.txItemCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code :";
            // 
            // dgvStokView
            // 
            this.dgvStokView.AllowUserToAddRows = false;
            this.dgvStokView.AllowUserToDeleteRows = false;
            this.dgvStokView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStokView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStokView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStokView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStokView.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStokView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStokView.Location = new System.Drawing.Point(298, 12);
            this.dgvStokView.Name = "dgvStokView";
            this.dgvStokView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStokView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvStokView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStokView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokView.Size = new System.Drawing.Size(774, 435);
            this.dgvStokView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.fillScreenViewToolStripMenuItem,
            this.lowStockValueReminderToolStripMenuItem,
            this.viewLowStockItemsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // fillScreenViewToolStripMenuItem
            // 
            this.fillScreenViewToolStripMenuItem.Name = "fillScreenViewToolStripMenuItem";
            this.fillScreenViewToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.fillScreenViewToolStripMenuItem.Text = "Stock Full Screen View";
            this.fillScreenViewToolStripMenuItem.Click += new System.EventHandler(this.fillScreenViewToolStripMenuItem_Click);
            // 
            // lowStockValueReminderToolStripMenuItem
            // 
            this.lowStockValueReminderToolStripMenuItem.Name = "lowStockValueReminderToolStripMenuItem";
            this.lowStockValueReminderToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.lowStockValueReminderToolStripMenuItem.Text = "Low Stock Value Reminder";
            this.lowStockValueReminderToolStripMenuItem.Click += new System.EventHandler(this.lowStockValueReminderToolStripMenuItem_Click);
            // 
            // viewLowStockItemsToolStripMenuItem
            // 
            this.viewLowStockItemsToolStripMenuItem.Name = "viewLowStockItemsToolStripMenuItem";
            this.viewLowStockItemsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.viewLowStockItemsToolStripMenuItem.Text = "View Low Stock Items";
            this.viewLowStockItemsToolStripMenuItem.Click += new System.EventHandler(this.viewLowStockItemsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lbItemCount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(666, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 118);
            this.panel2.TabIndex = 5;
            // 
            // lbItemCount
            // 
            this.lbItemCount.AutoSize = true;
            this.lbItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemCount.Location = new System.Drawing.Point(12, 72);
            this.lbItemCount.Name = "lbItemCount";
            this.lbItemCount.Size = new System.Drawing.Size(26, 29);
            this.lbItemCount.TabIndex = 1;
            this.lbItemCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stock Item Count :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lbValue);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(872, 456);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 118);
            this.panel3.TabIndex = 6;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValue.Location = new System.Drawing.Point(12, 72);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(26, 29);
            this.lbValue.TabIndex = 1;
            this.lbValue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Stock Value :";
            // 
            // btSummary
            // 
            this.btSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSummary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSummary.ForeColor = System.Drawing.Color.White;
            this.btSummary.Image = global::POS.Properties.Resources.summary_check;
            this.btSummary.Location = new System.Drawing.Point(477, 482);
            this.btSummary.Name = "btSummary";
            this.btSummary.Size = new System.Drawing.Size(84, 92);
            this.btSummary.TabIndex = 4;
            this.btSummary.Text = "Purchasing Summary";
            this.btSummary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSummary.UseVisualStyleBackColor = false;
            this.btSummary.Click += new System.EventHandler(this.btSummary_Click);
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Image = global::POS.Properties.Resources.paper;
            this.btPrint.Location = new System.Drawing.Point(387, 482);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(84, 92);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "Print Stock Balance";
            this.btPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPrint.UseVisualStyleBackColor = false;
            // 
            // btViewAll
            // 
            this.btViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btViewAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewAll.ForeColor = System.Drawing.Color.White;
            this.btViewAll.Image = global::POS.Properties.Resources.accountability;
            this.btViewAll.Location = new System.Drawing.Point(297, 482);
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(84, 92);
            this.btViewAll.TabIndex = 2;
            this.btViewAll.Text = "View All Item";
            this.btViewAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btViewAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btViewAll.UseVisualStyleBackColor = false;
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 578);
            this.Controls.Add(this.btSummary);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btViewAll);
            this.Controls.Add(this.dgvStokView);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1100, 617);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDecs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dgvStokView;
        private System.Windows.Forms.Button btViewAll;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillScreenViewToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbItemCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btSummary;
        private System.Windows.Forms.ToolStripMenuItem lowStockValueReminderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLowStockItemsToolStripMenuItem;
    }
}