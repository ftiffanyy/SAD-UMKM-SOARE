namespace SAD_UMKM_SOARE
{
    partial class ViewProduct
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
            this.bt_back = new System.Windows.Forms.Button();
            this.dgvbaju = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.pb_header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.back;
            this.bt_back.FlatAppearance.BorderSize = 0;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Location = new System.Drawing.Point(1080, 901);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(184, 50);
            this.bt_back.TabIndex = 120;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
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
            this.dgvbaju.Location = new System.Drawing.Point(125, 152);
            this.dgvbaju.MultiSelect = false;
            this.dgvbaju.Name = "dgvbaju";
            this.dgvbaju.RowHeadersVisible = false;
            this.dgvbaju.RowTemplate.Height = 40;
            this.dgvbaju.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbaju.Size = new System.Drawing.Size(1200, 682);
            this.dgvbaju.TabIndex = 121;
            this.dgvbaju.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaju_CellClick);
            // 
            // bt_delete
            // 
            this.bt_delete.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.del_fix;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Location = new System.Drawing.Point(1062, 90);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(90, 40);
            this.bt_delete.TabIndex = 122;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Defect"});
            this.cb_filter.Location = new System.Drawing.Point(1182, 102);
            this.cb_filter.MaxLength = 37;
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(114, 21);
            this.cb_filter.TabIndex = 123;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // pb_header
            // 
            this.pb_header.Image = global::SAD_UMKM_SOARE.Properties.Resources.header_vp;
            this.pb_header.Location = new System.Drawing.Point(125, 67);
            this.pb_header.Name = "pb_header";
            this.pb_header.Size = new System.Drawing.Size(1200, 85);
            this.pb_header.TabIndex = 124;
            this.pb_header.TabStop = false;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.view_product;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.dgvbaju);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.pb_header);
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.DataGridView dgvbaju;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.PictureBox pb_header;
    }
}