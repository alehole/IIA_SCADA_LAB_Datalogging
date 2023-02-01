
namespace Datalogging
{
    partial class Form1
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.TxtBx_Status = new System.Windows.Forms.TextBox();
            this.dgv_u = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_T_Sp = new System.Windows.Forms.DataGridView();
            this.Row0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Graph_Temperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.Graph_Temp = new NationalInstruments.UI.WaveformPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Graph_u = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.graph_tsp = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Temp = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_T_Sp)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_u)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_tsp)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(19, 64);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // TxtBx_Status
            // 
            this.TxtBx_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Status.Location = new System.Drawing.Point(10, 26);
            this.TxtBx_Status.Name = "TxtBx_Status";
            this.TxtBx_Status.ReadOnly = true;
            this.TxtBx_Status.Size = new System.Drawing.Size(92, 22);
            this.TxtBx_Status.TabIndex = 29;
            // 
            // dgv_u
            // 
            this.dgv_u.AllowUserToAddRows = false;
            this.dgv_u.AllowUserToDeleteRows = false;
            this.dgv_u.AllowUserToOrderColumns = true;
            this.dgv_u.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_u.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_u.Location = new System.Drawing.Point(6, 6);
            this.dgv_u.Name = "dgv_u";
            this.dgv_u.ReadOnly = true;
            this.dgv_u.Size = new System.Drawing.Size(404, 394);
            this.dgv_u.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgv_T_Sp
            // 
            this.dgv_T_Sp.AllowUserToAddRows = false;
            this.dgv_T_Sp.AllowUserToDeleteRows = false;
            this.dgv_T_Sp.AllowUserToOrderColumns = true;
            this.dgv_T_Sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_T_Sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row0,
            this.Row1,
            this.Row2});
            this.dgv_T_Sp.Location = new System.Drawing.Point(3, 3);
            this.dgv_T_Sp.Name = "dgv_T_Sp";
            this.dgv_T_Sp.ReadOnly = true;
            this.dgv_T_Sp.Size = new System.Drawing.Size(410, 397);
            this.dgv_T_Sp.TabIndex = 31;
            // 
            // Row0
            // 
            this.Row0.HeaderText = "#";
            this.Row0.Name = "Row0";
            this.Row0.ReadOnly = true;
            // 
            // Row1
            // 
            this.Row1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Row1.HeaderText = "Value";
            this.Row1.Name = "Row1";
            this.Row1.ReadOnly = true;
            // 
            // Row2
            // 
            this.Row2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Row2.HeaderText = "DateTime";
            this.Row2.Name = "Row2";
            this.Row2.ReadOnly = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1033, 451);
            this.tabControl2.TabIndex = 33;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Graph_Temperature);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1025, 422);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Temperature [°C]";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Graph_Temperature
            // 
            this.Graph_Temperature.Location = new System.Drawing.Point(5, 6);
            this.Graph_Temperature.Name = "Graph_Temperature";
            this.Graph_Temperature.PlotAreaColor = System.Drawing.SystemColors.ControlLightLight;
            this.Graph_Temperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.Graph_Temp});
            this.Graph_Temperature.Size = new System.Drawing.Size(1014, 410);
            this.Graph_Temperature.TabIndex = 36;
            this.Graph_Temperature.UseColorGenerator = true;
            this.Graph_Temperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.Graph_Temperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis4});
            // 
            // Graph_Temp
            // 
            this.Graph_Temp.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.Graph_Temp.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.Graph_Temp.LineColor = System.Drawing.SystemColors.Highlight;
            this.Graph_Temp.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.Graph_Temp.LineWidth = 2F;
            this.Graph_Temp.PointColor = System.Drawing.SystemColors.WindowText;
            this.Graph_Temp.XAxis = this.xAxis4;
            this.Graph_Temp.YAxis = this.yAxis4;
            this.Graph_Temp.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis4
            // 
            this.xAxis4.BaseLineVisible = true;
            this.xAxis4.Caption = "Sample n";
            this.xAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxis4.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis4.Range = new NationalInstruments.UI.Range(0D, 500D);
            // 
            // yAxis4
            // 
            this.yAxis4.BaseLineWidth = 2;
            this.yAxis4.Caption = "Measured Temperature [°C]";
            this.yAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis4.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.yAxis4.Range = new NationalInstruments.UI.Range(25D, 35D);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Graph_u);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1025, 422);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Control Voltage u[V]";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Graph_u
            // 
            this.Graph_u.Location = new System.Drawing.Point(3, 6);
            this.Graph_u.Name = "Graph_u";
            this.Graph_u.PlotAreaColor = System.Drawing.SystemColors.ControlLightLight;
            this.Graph_u.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.Graph_u.Size = new System.Drawing.Size(1016, 410);
            this.Graph_u.TabIndex = 37;
            this.Graph_u.UseColorGenerator = true;
            this.Graph_u.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.Graph_u.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.waveformPlot1.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.waveformPlot1.LineColor = System.Drawing.SystemColors.Highlight;
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.LineWidth = 2F;
            this.waveformPlot1.PointColor = System.Drawing.SystemColors.WindowText;
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            this.waveformPlot1.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis1
            // 
            this.xAxis1.BaseLineVisible = true;
            this.xAxis1.Caption = "Sample n";
            this.xAxis1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxis1.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis1.Range = new NationalInstruments.UI.Range(0D, 500D);
            // 
            // yAxis1
            // 
            this.yAxis1.BaseLineWidth = 2;
            this.yAxis1.Caption = "Control signal u[V]";
            this.yAxis1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis1.Range = new NationalInstruments.UI.Range(0D, 5D);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.graph_tsp);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1025, 422);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Temperature setpoint[°C]";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // graph_tsp
            // 
            this.graph_tsp.Location = new System.Drawing.Point(4, 6);
            this.graph_tsp.Name = "graph_tsp";
            this.graph_tsp.PlotAreaColor = System.Drawing.SystemColors.ControlLightLight;
            this.graph_tsp.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.graph_tsp.Size = new System.Drawing.Size(1016, 413);
            this.graph_tsp.TabIndex = 38;
            this.graph_tsp.UseColorGenerator = true;
            this.graph_tsp.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.graph_tsp.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.waveformPlot2.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.waveformPlot2.LineColor = System.Drawing.SystemColors.Highlight;
            this.waveformPlot2.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot2.LineWidth = 2F;
            this.waveformPlot2.PointColor = System.Drawing.SystemColors.WindowText;
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            this.waveformPlot2.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis2
            // 
            this.xAxis2.BaseLineVisible = true;
            this.xAxis2.Caption = "Sample n";
            this.xAxis2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxis2.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis2.Range = new NationalInstruments.UI.Range(0D, 500D);
            // 
            // yAxis2
            // 
            this.yAxis2.BaseLineWidth = 2;
            this.yAxis2.Caption = "Temperature setpoint [°C]";
            this.yAxis2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis2.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.yAxis2.Range = new NationalInstruments.UI.Range(25D, 35D);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1025, 422);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Temp);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 403);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Temperature [°C]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Temp
            // 
            this.dgv_Temp.AllowUserToAddRows = false;
            this.dgv_Temp.AllowUserToDeleteRows = false;
            this.dgv_Temp.AllowUserToOrderColumns = true;
            this.dgv_Temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Temp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_Temp.Location = new System.Drawing.Point(6, 3);
            this.dgv_Temp.Name = "dgv_Temp";
            this.dgv_Temp.ReadOnly = true;
            this.dgv_Temp.Size = new System.Drawing.Size(524, 394);
            this.dgv_Temp.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "#";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Value";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_u);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(414, 403);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Control Voltage u[V]";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgv_T_Sp);
            this.tabPage7.Location = new System.Drawing.Point(4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(414, 403);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Temperature setpoint [°C]";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Controls.Add(this.TxtBx_Status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1051, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Temperature logging system";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_T_Sp)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_u)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph_tsp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox TxtBx_Status;
        private System.Windows.Forms.DataGridView dgv_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgv_T_Sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private NationalInstruments.UI.WindowsForms.WaveformGraph Graph_Temperature;
        private NationalInstruments.UI.WaveformPlot Graph_Temp;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis4;
        private NationalInstruments.UI.WindowsForms.WaveformGraph Graph_u;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private NationalInstruments.UI.WindowsForms.WaveformGraph graph_tsp;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

