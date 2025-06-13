namespace SAD_UMKM_SOARE
{
    partial class MainMenu
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
            this.bt_logout = new System.Windows.Forms.Button();
            this.lb_sold = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.tbnama_1 = new System.Windows.Forms.TextBox();
            this.tbnama_2 = new System.Windows.Forms.TextBox();
            this.tbnama_3 = new System.Windows.Forms.TextBox();
            this.tbqty_3 = new System.Windows.Forms.TextBox();
            this.tbqty_2 = new System.Windows.Forms.TextBox();
            this.tbqty_1 = new System.Windows.Forms.TextBox();
            this.tb_new = new System.Windows.Forms.TextBox();
            this.lb_profit = new System.Windows.Forms.Label();
            this.tb_quotes = new System.Windows.Forms.TextBox();
            this.sidebar.SuspendLayout();
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
            this.sidebar.TabIndex = 0;
            // 
            // bt_transrecord
            // 
            this.bt_transrecord.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.transaction_record;
            this.bt_transrecord.FlatAppearance.BorderSize = 0;
            this.bt_transrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_transrecord.Location = new System.Drawing.Point(30, 870);
            this.bt_transrecord.Name = "bt_transrecord";
            this.bt_transrecord.Size = new System.Drawing.Size(301, 74);
            this.bt_transrecord.TabIndex = 8;
            this.bt_transrecord.UseVisualStyleBackColor = true;
            this.bt_transrecord.Click += new System.EventHandler(this.bt_transrecord_Click);
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
            this.bt_dashboard.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.dashboard_bold;
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Location = new System.Drawing.Point(30, 211);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(301, 74);
            this.bt_dashboard.TabIndex = 1;
            this.bt_dashboard.UseVisualStyleBackColor = true;
            // 
            // bt_logout
            // 
            this.bt_logout.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.bt_logout;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Location = new System.Drawing.Point(1182, 33);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(187, 61);
            this.bt_logout.TabIndex = 9;
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // lb_sold
            // 
            this.lb_sold.AutoSize = true;
            this.lb_sold.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_sold.Location = new System.Drawing.Point(837, 237);
            this.lb_sold.Name = "lb_sold";
            this.lb_sold.Size = new System.Drawing.Size(168, 47);
            this.lb_sold.TabIndex = 142;
            this.lb_sold.Text = "10000 pcs";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(915, 670);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(39, 39);
            this.lb_3.TabIndex = 145;
            this.lb_3.Text = "3.";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(915, 605);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(39, 39);
            this.lb_2.TabIndex = 144;
            this.lb_2.Text = "2.";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(915, 540);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(39, 39);
            this.lb_1.TabIndex = 143;
            this.lb_1.Text = "1.";
            // 
            // tbnama_1
            // 
            this.tbnama_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_1.Location = new System.Drawing.Point(980, 527);
            this.tbnama_1.Multiline = true;
            this.tbnama_1.Name = "tbnama_1";
            this.tbnama_1.Size = new System.Drawing.Size(220, 60);
            this.tbnama_1.TabIndex = 146;
            this.tbnama_1.Text = "Defect Polar Opposites Dark Grey Size 2";
            // 
            // tbnama_2
            // 
            this.tbnama_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_2.Location = new System.Drawing.Point(980, 593);
            this.tbnama_2.Multiline = true;
            this.tbnama_2.Name = "tbnama_2";
            this.tbnama_2.Size = new System.Drawing.Size(220, 60);
            this.tbnama_2.TabIndex = 147;
            this.tbnama_2.Text = "Defect Polar Opposites Dark Grey Size 2";
            // 
            // tbnama_3
            // 
            this.tbnama_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_3.Location = new System.Drawing.Point(980, 659);
            this.tbnama_3.Multiline = true;
            this.tbnama_3.Name = "tbnama_3";
            this.tbnama_3.Size = new System.Drawing.Size(220, 60);
            this.tbnama_3.TabIndex = 148;
            this.tbnama_3.Text = "Defect Polar Opposites Dark Grey Size 2";
            // 
            // tbqty_3
            // 
            this.tbqty_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_3.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_3.Location = new System.Drawing.Point(1240, 690);
            this.tbqty_3.MaxLength = 8;
            this.tbqty_3.Multiline = true;
            this.tbqty_3.Name = "tbqty_3";
            this.tbqty_3.Size = new System.Drawing.Size(110, 30);
            this.tbqty_3.TabIndex = 158;
            this.tbqty_3.Text = "1";
            this.tbqty_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbqty_2
            // 
            this.tbqty_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_2.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_2.Location = new System.Drawing.Point(1240, 615);
            this.tbqty_2.MaxLength = 8;
            this.tbqty_2.Multiline = true;
            this.tbqty_2.Name = "tbqty_2";
            this.tbqty_2.Size = new System.Drawing.Size(110, 30);
            this.tbqty_2.TabIndex = 157;
            this.tbqty_2.Text = "1";
            this.tbqty_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbqty_1
            // 
            this.tbqty_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_1.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_1.Location = new System.Drawing.Point(1240, 540);
            this.tbqty_1.MaxLength = 8;
            this.tbqty_1.Multiline = true;
            this.tbqty_1.Name = "tbqty_1";
            this.tbqty_1.Size = new System.Drawing.Size(110, 30);
            this.tbqty_1.TabIndex = 156;
            this.tbqty_1.Text = "1";
            this.tbqty_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_new
            // 
            this.tb_new.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_new.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_new.Location = new System.Drawing.Point(509, 237);
            this.tb_new.Multiline = true;
            this.tb_new.Name = "tb_new";
            this.tb_new.Size = new System.Drawing.Size(196, 60);
            this.tb_new.TabIndex = 159;
            this.tb_new.Text = "Defect Polar Opposites Dark Grey Size 2";
            // 
            // lb_profit
            // 
            this.lb_profit.AutoSize = true;
            this.lb_profit.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_profit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_profit.Location = new System.Drawing.Point(1190, 240);
            this.lb_profit.Name = "lb_profit";
            this.lb_profit.Size = new System.Drawing.Size(156, 39);
            this.lb_profit.TabIndex = 160;
            this.lb_profit.Text = "Rp100.000";
            // 
            // tb_quotes
            // 
            this.tb_quotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_quotes.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quotes.Location = new System.Drawing.Point(465, 825);
            this.tb_quotes.Multiline = true;
            this.tb_quotes.Name = "tb_quotes";
            this.tb_quotes.Size = new System.Drawing.Size(840, 86);
            this.tb_quotes.TabIndex = 161;
            this.tb_quotes.Text = "\'Success is not final; failure is not fatal: It is the courage to continue that c" +
    "ounts.\' - Winston S. Churchill";
            this.tb_quotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.menuu;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.tb_quotes);
            this.Controls.Add(this.lb_profit);
            this.Controls.Add(this.tb_new);
            this.Controls.Add(this.tbqty_3);
            this.Controls.Add(this.tbqty_2);
            this.Controls.Add(this.tbqty_1);
            this.Controls.Add(this.tbnama_3);
            this.Controls.Add(this.tbnama_2);
            this.Controls.Add(this.tbnama_1);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.lb_sold);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.sidebar);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.Button bt_purchase;
        private System.Windows.Forms.Button bt_sale;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_inventory;
        private System.Windows.Forms.Button bt_profitloss;
        private System.Windows.Forms.Button bt_performance;
        private System.Windows.Forms.Button bt_transrecord;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label lb_sold;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox tbnama_1;
        private System.Windows.Forms.TextBox tbnama_2;
        private System.Windows.Forms.TextBox tbnama_3;
        private System.Windows.Forms.TextBox tbqty_3;
        private System.Windows.Forms.TextBox tbqty_2;
        private System.Windows.Forms.TextBox tbqty_1;
        private System.Windows.Forms.TextBox tb_new;
        private System.Windows.Forms.Label lb_profit;
        private System.Windows.Forms.TextBox tb_quotes;
    }
}