using System;
using System.Windows.Forms;

namespace Datalogging
{
    public partial class Form1 : Form
    {
        readonly OPC_DA_Read _Temperature = new OPC_DA_Read();
        readonly OPC_DA_Read _Temperature_SP = new OPC_DA_Read();
        readonly OPC_DA_Read _Control_U = new OPC_DA_Read();
        readonly Write_DB _DB_write = new Write_DB();

        string quality_Temp;
        string quality_TempSP;
        string quality_U;

        bool online;
        int loggingIndex_temp;
        int loggingIndex_u;
        int loggingIndex_T_sp;

        public Form1()
        {
            InitializeComponent();
            Create_OPC_DA_Subscriptions();

            online = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Temperature.Disconnect();
            _Temperature_SP.Disconnect();
            _Control_U.Disconnect();
        }
        
        private void UpdateDataGrid_Temp(double Value, string TimeStamp)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_Temp);
            loggingIndex_temp++;
            row.Cells[0].Value = loggingIndex_temp;
            row.Cells[1].Value = Value.ToString();
            row.Cells[2].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            dgv_Temp.Rows.Add(row);
            dgv_Temp.Sort(dgv_Temp.Columns[0], System.ComponentModel.ListSortDirection.Descending);

            Graph_Temperature.PlotYAppend(Value);
        }
        private void UpdateDataGrid_U(double Value, string TimeStamp)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_u);
            loggingIndex_u++;
            row.Cells[0].Value = loggingIndex_u;
            row.Cells[1].Value = Value.ToString();
            row.Cells[2].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            dgv_u.Rows.Add(row);
            dgv_u.Sort(dgv_u.Columns[0], System.ComponentModel.ListSortDirection.Descending);

            Graph_u.PlotYAppend(Value);
        }
        private void UpdateDataGrid_T_Sp(double Value, string TimeStamp)
        {
            DataGridViewRow row = new DataGridViewRow();
            
            row.CreateCells(dgv_T_Sp);
            loggingIndex_T_sp++;
            row.Cells[0].Value = loggingIndex_T_sp;
            row.Cells[1].Value = Value.ToString();
            row.Cells[2].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            dgv_T_Sp.Rows.Add(row);
            dgv_T_Sp.Sort(dgv_T_Sp.Columns[0], System.ComponentModel.ListSortDirection.Descending);

            graph_tsp.PlotYAppend(Value);
        }
        private void OnConstatusChange(string status)
        {
            string constatus = status;
        }
        // Temperature
        private void OnValueChange_Temp(double Value)
        {
            _DB_write.Usp_SaveSensorData(Value, DateTime.Now, quality_Temp, "T_Measured");
            UpdateDataGrid_Temp(Value, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
        }
        private void OnQualityChange_Temp(string value)
        {
            quality_Temp = value;
        }
        private void OnTimeStampChange_Temp(string value)
        {
            string timestamp_Temp = value;
        }

        // Temperature SP
        private void OnValueChange_TempSP(double Value)
        {
            _DB_write.Usp_SaveSensorData(Value, DateTime.Now, quality_TempSP, "T_sp");
            UpdateDataGrid_T_Sp(Value, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
        }
        private void OnQualityChange_TempSP(string value)
        {
            quality_TempSP = value;
        }
        private void OnTimeStampChange_TempSP(string value)
        {
           string timestamp_TempSP = value;
        }

        // Control Variable U
        private void OnValueChange_U(double Value)
        {
            _DB_write.Usp_SaveSensorData(Value, DateTime.Now, quality_U ,"u");
            UpdateDataGrid_U(Value, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
        }
        private void OnQualityChange_U(string value)
        {
            quality_U = value;
        }
        private void OnTimeStampChange_U(string value)
        {
           string timestamp_U = value;
        }
        private void Create_OPC_DA_Subscriptions()
        {
            _Temperature.Value += new OPC_DA_Read.updateValue(OnValueChange_Temp);
            _Temperature.Quality += new OPC_DA_Read.updateQuality(OnQualityChange_Temp);
            _Temperature.Timestamp += new OPC_DA_Read.updateTimeStamp(OnTimeStampChange_Temp);
            _Temperature.Constatus += new OPC_DA_Read.updateConStatus(OnConstatusChange);

            _Temperature_SP.Value += new OPC_DA_Read.updateValue(OnValueChange_TempSP);
            _Temperature_SP.Quality += new OPC_DA_Read.updateQuality(OnQualityChange_TempSP);
            _Temperature_SP.Timestamp += new OPC_DA_Read.updateTimeStamp(OnTimeStampChange_TempSP);
            _Temperature_SP.Constatus += new OPC_DA_Read.updateConStatus(OnConstatusChange);

            _Control_U.Value += new OPC_DA_Read.updateValue(OnValueChange_U);
            _Control_U.Quality += new OPC_DA_Read.updateQuality(OnQualityChange_U);
            _Control_U.Timestamp += new OPC_DA_Read.updateTimeStamp(OnTimeStampChange_U);
            _Control_U.Constatus += new OPC_DA_Read.updateConStatus(OnConstatusChange);
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            online = (online == false) ? true : false;
            if (online)
            {
                TxtBx_Status.Text = "ONLINE";
                Btn_Start.Text = "Stop";
                _Temperature.Connect(@"\\MSI\OPCProcess\T_measured");
                _Temperature_SP.Connect(@"\\MSI\OPCProcess\T_sp");
                _Control_U.Connect(@"\\MSI\OPCProcess\u");
            }
            else
            {
                TxtBx_Status.Text = "OFFLINE";
                Btn_Start.Text = "Start";
                _Temperature.Disconnect();
                _Temperature_SP.Disconnect();
                _Control_U.Disconnect();
            }
        }
    }
}