namespace SAD_UMKM_SOARE
{
    partial class TransactionRecord
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.bt_transrecord = new System.Windows.Forms.Button();
            this.bt_performance = new System.Windows.Forms.Button();
            this.bt_profitloss = new System.Windows.Forms.Button();
            this.bt_inventory = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_sale = new System.Windows.Forms.Button();
            this.bt_purchase = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.dgvbaju = new System.Windows.Forms.DataGridView();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.pb_header = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.Side_Bar_Component;
            this.sidebar.Controls.Add(this.bt_transrecord);
            this.sidebar.Controls.Add(this.bt_performance);
            this.sidebar.Controls.Add(this.bt_profitloss);
            this.sidebar.Controls.Add(this.bt_inventory);
            this.sidebar.Controls.Add(this.bt_return);
            this.sidebar.Controls.Add(this.bt_sale);
            this.sidebar.Controls.Add(this.bt_purchase);
            this.sidebar.Controls.Add(this.bt_dashboard);
            this.sidebar.Location = new System.Drawing.Point(-4, -1);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(357, 988);
            this.sidebar.TabIndex = 7;
            // 
            // bt_transrecord
            // 
            this.bt_transrecord.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.transaction_record_bold;
            this.bt_transrecord.FlatAppearance.BorderSize = 0;
            this.bt_transrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_transrecord.Location = new System.Drawing.Point(30, 870);
            this.bt_transrecord.Name = "bt_transrecord";
            this.bt_transrecord.Size = new System.Drawing.Size(301, 74);
            this.bt_transrecord.TabIndex = 8;
            this.bt_transrecord.UseVisualStyleBackColor = true;
            // 
            // bt_performance
            // 
            this.bt_performance.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.performance_sale;
            this.bt_performance.FlatAppearance.BorderSize = 0;
            this.bt_performance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_performance.Location = new System.Drawing.Point(30, 780);
            this.bt_performance.Name = "bt_performance";
            this.bt_performance.Size = new System.Drawing.Size(301, 74);
            this.bt_performance.TabIndex = 7;
            this.bt_performance.UseVisualStyleBackColor = true;
            this.bt_performance.Click += new System.EventHandler(this.bt_performance_Click);
            // 
            // bt_profitloss
            // 
            this.bt_profitloss.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.profit_n_loss;
            this.bt_profitloss.FlatAppearance.BorderSize = 0;
            this.bt_profitloss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_profitloss.Location = new System.Drawing.Point(30, 690);
            this.bt_profitloss.Name = "bt_profitloss";
            this.bt_profitloss.Size = new System.Drawing.Size(301, 74);
            this.bt_profitloss.TabIndex = 6;
            this.bt_profitloss.UseVisualStyleBackColor = true;
            this.bt_profitloss.Click += new System.EventHandler(this.bt_profitloss_Click);
            // 
            // bt_inventory
            // 
            this.bt_inventory.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.inventory;
            this.bt_inventory.FlatAppearance.BorderSize = 0;
            this.bt_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inventory.Location = new System.Drawing.Point(30, 600);
            this.bt_inventory.Name = "bt_inventory";
            this.bt_inventory.Size = new System.Drawing.Size(301, 74);
            this.bt_inventory.TabIndex = 5;
            this.bt_inventory.UseVisualStyleBackColor = true;
            this.bt_inventory.Click += new System.EventHandler(this.bt_inventory_Click);
            // 
            // bt_return
            // 
            this.bt_return.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources._return;
            this.bt_return.FlatAppearance.BorderSize = 0;
            this.bt_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_return.Location = new System.Drawing.Point(30, 490);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(301, 74);
            this.bt_return.TabIndex = 4;
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_sale
            // 
            this.bt_sale.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.sale;
            this.bt_sale.FlatAppearance.BorderSize = 0;
            this.bt_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sale.Location = new System.Drawing.Point(30, 400);
            this.bt_sale.Name = "bt_sale";
            this.bt_sale.Size = new System.Drawing.Size(301, 74);
            this.bt_sale.TabIndex = 3;
            this.bt_sale.UseVisualStyleBackColor = true;
            this.bt_sale.Click += new System.EventHandler(this.bt_sale_Click);
            // 
            // bt_purchase
            // 
            this.bt_purchase.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.purchase;
            this.bt_purchase.FlatAppearance.BorderSize = 0;
            this.bt_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_purchase.Location = new System.Drawing.Point(30, 310);
            this.bt_purchase.Name = "bt_purchase";
            this.bt_purchase.Size = new System.Drawing.Size(301, 74);
            this.bt_purchase.TabIndex = 2;
            this.bt_purchase.UseVisualStyleBackColor = true;
            this.bt_purchase.Click += new System.EventHandler(this.bt_purchase_Click);
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.dashboard;
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Location = new System.Drawing.Point(30, 211);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(301, 74);
            this.bt_dashboard.TabIndex = 1;
            this.bt_dashboard.UseVisualStyleBackColor = true;
            this.bt_dashboard.Click += new System.EventHandler(this.bt_dashboard_Click);
            // 
            // dgvbaju
            // 
            this.dgvbaju.AllowUserToAddRows = false;
            this.dgvbaju.AllowUserToDeleteRows = false;
            this.dgvbaju.AllowUserToOrderColumns = true;
            this.dgvbaju.AllowUserToResizeColumns = false;
            this.dgvbaju.AllowUserToResizeRows = false;
            this.dgvbaju.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbaju.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaju.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvbaju.Location = new System.Drawing.Point(400, 131);
            this.dgvbaju.MultiSelect = false;
            this.dgvbaju.Name = "dgvbaju";
            this.dgvbaju.RowHeadersVisible = false;
            this.dgvbaju.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbaju.Size = new System.Drawing.Size(1000, 723);
            this.dgvbaju.TabIndex = 122;
            this.dgvbaju.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaju_CellClick);
            // 
            // cb_filter
            // 
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Purchase",
            "Sales",
            "Return"});
            this.cb_filter.Location = new System.Drawing.Point(1145, 80);
            this.cb_filter.MaxLength = 37;
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(114, 21);
            this.cb_filter.TabIndex = 124;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "General",
            "Detail"});
            this.cb_type.Location = new System.Drawing.Point(1272, 80);
            this.cb_type.MaxLength = 37;
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(114, 21);
            this.cb_type.TabIndex = 125;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // bt_delete
            // 
            this.bt_delete.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.del_fix;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Location = new System.Drawing.Point(1037, 69);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(90, 40);
            this.bt_delete.TabIndex = 126;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // pb_header
            // 
            this.pb_header.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.header1;
            this.pb_header.Location = new System.Drawing.Point(400, 46);
            this.pb_header.Name = "pb_header";
            this.pb_header.Size = new System.Drawing.Size(1000, 85);
            this.pb_header.TabIndex = 127;
            this.pb_header.TabStop = false;
            // 
            // TransactionRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.transrecord;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.dgvbaju);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pb_header);
            this.Name = "TransactionRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionRecord";
            this.Load += new System.EventHandler(this.TransactionRecord_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button bt_transrecord;
        private System.Windows.Forms.Button bt_performance;
        private System.Windows.Forms.Button bt_profitloss;
        private System.Windows.Forms.Button bt_inventory;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_sale;
        private System.Windows.Forms.Button bt_purchase;
        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.DataGridView dgvbaju;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.PictureBox pb_header;
    }
}