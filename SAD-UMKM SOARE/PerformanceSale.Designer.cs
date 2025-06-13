namespace SAD_UMKM_SOARE
{
    partial class PerformanceSale
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebar = new System.Windows.Forms.Panel();
            this.bt_transrecord = new System.Windows.Forms.Button();
            this.bt_performance = new System.Windows.Forms.Button();
            this.bt_profitloss = new System.Windows.Forms.Button();
            this.bt_inventory = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_sale = new System.Windows.Forms.Button();
            this.bt_purchase = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.tb_most = new System.Windows.Forms.TextBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.dateakhir = new System.Windows.Forms.DateTimePicker();
            this.dateawal = new System.Windows.Forms.DateTimePicker();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbqty_3 = new System.Windows.Forms.TextBox();
            this.tbqty_2 = new System.Windows.Forms.TextBox();
            this.tbqty_1 = new System.Windows.Forms.TextBox();
            this.tbnama_3 = new System.Windows.Forms.TextBox();
            this.tbnama_2 = new System.Windows.Forms.TextBox();
            this.tbnama_1 = new System.Windows.Forms.TextBox();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
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
            this.sidebar.TabIndex = 6;
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
            this.bt_performance.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.performance_sale_bold;
            this.bt_performance.FlatAppearance.BorderSize = 0;
            this.bt_performance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_performance.Location = new System.Drawing.Point(30, 780);
            this.bt_performance.Name = "bt_performance";
            this.bt_performance.Size = new System.Drawing.Size(301, 74);
            this.bt_performance.TabIndex = 7;
            this.bt_performance.UseVisualStyleBackColor = true;
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
            // tb_most
            // 
            this.tb_most.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_most.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_most.Location = new System.Drawing.Point(1015, 127);
            this.tb_most.Multiline = true;
            this.tb_most.Name = "tb_most";
            this.tb_most.Size = new System.Drawing.Size(225, 70);
            this.tb_most.TabIndex = 160;
            this.tb_most.Text = "Polar Opposites Dark Grey Size 2";
            this.tb_most.Visible = false;
            // 
            // bt_generate
            // 
            this.bt_generate.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.gen;
            this.bt_generate.FlatAppearance.BorderSize = 0;
            this.bt_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_generate.Location = new System.Drawing.Point(689, 518);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(152, 56);
            this.bt_generate.TabIndex = 169;
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // dateakhir
            // 
            this.dateakhir.Location = new System.Drawing.Point(622, 435);
            this.dateakhir.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateakhir.Name = "dateakhir";
            this.dateakhir.Size = new System.Drawing.Size(200, 20);
            this.dateakhir.TabIndex = 168;
            this.dateakhir.ValueChanged += new System.EventHandler(this.dateakhir_ValueChanged);
            // 
            // dateawal
            // 
            this.dateawal.Location = new System.Drawing.Point(622, 355);
            this.dateawal.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateawal.Name = "dateawal";
            this.dateawal.Size = new System.Drawing.Size(200, 20);
            this.dateawal.TabIndex = 167;
            this.dateawal.ValueChanged += new System.EventHandler(this.dateawal_ValueChanged);
            // 
            // piechart
            // 
            chartArea2.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.piechart.Legends.Add(legend2);
            this.piechart.Location = new System.Drawing.Point(962, 399);
            this.piechart.Name = "piechart";
            this.piechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "seriespie";
            this.piechart.Series.Add(series2);
            this.piechart.Size = new System.Drawing.Size(416, 364);
            this.piechart.TabIndex = 171;
            this.piechart.Visible = false;
            // 
            // tbqty_3
            // 
            this.tbqty_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_3.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_3.Location = new System.Drawing.Point(785, 915);
            this.tbqty_3.MaxLength = 8;
            this.tbqty_3.Multiline = true;
            this.tbqty_3.Name = "tbqty_3";
            this.tbqty_3.Size = new System.Drawing.Size(110, 30);
            this.tbqty_3.TabIndex = 180;
            this.tbqty_3.Text = "1";
            this.tbqty_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbqty_3.Visible = false;
            // 
            // tbqty_2
            // 
            this.tbqty_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_2.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_2.Location = new System.Drawing.Point(785, 850);
            this.tbqty_2.MaxLength = 8;
            this.tbqty_2.Multiline = true;
            this.tbqty_2.Name = "tbqty_2";
            this.tbqty_2.Size = new System.Drawing.Size(110, 30);
            this.tbqty_2.TabIndex = 179;
            this.tbqty_2.Text = "1";
            this.tbqty_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbqty_2.Visible = false;
            // 
            // tbqty_1
            // 
            this.tbqty_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbqty_1.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty_1.Location = new System.Drawing.Point(785, 785);
            this.tbqty_1.MaxLength = 8;
            this.tbqty_1.Multiline = true;
            this.tbqty_1.Name = "tbqty_1";
            this.tbqty_1.Size = new System.Drawing.Size(110, 30);
            this.tbqty_1.TabIndex = 178;
            this.tbqty_1.Text = "1";
            this.tbqty_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbqty_1.Visible = false;
            // 
            // tbnama_3
            // 
            this.tbnama_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_3.Location = new System.Drawing.Point(525, 900);
            this.tbnama_3.Multiline = true;
            this.tbnama_3.Name = "tbnama_3";
            this.tbnama_3.Size = new System.Drawing.Size(220, 60);
            this.tbnama_3.TabIndex = 177;
            this.tbnama_3.Text = "Defect Polar Opposites Dark Grey Size 2";
            this.tbnama_3.Visible = false;
            // 
            // tbnama_2
            // 
            this.tbnama_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_2.Location = new System.Drawing.Point(525, 835);
            this.tbnama_2.Multiline = true;
            this.tbnama_2.Name = "tbnama_2";
            this.tbnama_2.Size = new System.Drawing.Size(220, 60);
            this.tbnama_2.TabIndex = 176;
            this.tbnama_2.Text = "Defect Polar Opposites Dark Grey Size 2";
            this.tbnama_2.Visible = false;
            // 
            // tbnama_1
            // 
            this.tbnama_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnama_1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama_1.Location = new System.Drawing.Point(525, 770);
            this.tbnama_1.Multiline = true;
            this.tbnama_1.Name = "tbnama_1";
            this.tbnama_1.Size = new System.Drawing.Size(220, 60);
            this.tbnama_1.TabIndex = 175;
            this.tbnama_1.Text = "Defect Polar Opposites Dark Grey Size 2";
            this.tbnama_1.Visible = false;
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(460, 910);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(39, 39);
            this.lb_3.TabIndex = 174;
            this.lb_3.Text = "3.";
            this.lb_3.Visible = false;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(460, 845);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(39, 39);
            this.lb_2.TabIndex = 173;
            this.lb_2.Text = "2.";
            this.lb_2.Visible = false;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(460, 780);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(39, 39);
            this.lb_1.TabIndex = 172;
            this.lb_1.Text = "1.";
            this.lb_1.Visible = false;
            // 
            // PerformanceSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAD_UMKM_SOARE.Properties.Resources.performance_sale_fix;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.tbqty_3);
            this.Controls.Add(this.tbqty_2);
            this.Controls.Add(this.tbqty_1);
            this.Controls.Add(this.tbnama_3);
            this.Controls.Add(this.tbnama_2);
            this.Controls.Add(this.tbnama_1);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.piechart);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.dateakhir);
            this.Controls.Add(this.dateawal);
            this.Controls.Add(this.tb_most);
            this.Controls.Add(this.sidebar);
            this.Name = "PerformanceSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerformanceSale";
            this.Load += new System.EventHandler(this.PerformanceSale_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tb_most;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.DateTimePicker dateakhir;
        private System.Windows.Forms.DateTimePicker dateawal;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.TextBox tbqty_3;
        private System.Windows.Forms.TextBox tbqty_2;
        private System.Windows.Forms.TextBox tbqty_1;
        private System.Windows.Forms.TextBox tbnama_3;
        private System.Windows.Forms.TextBox tbnama_2;
        private System.Windows.Forms.TextBox tbnama_1;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
    }
}