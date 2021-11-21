using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitor
{
    public partial class ProcessMonitor : Form
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        public ProcessMonitor()
        {
            InitializeComponent();

            timer_update_process_monitor.Interval = GetPrivateProfileInt("SETTING", "timer_interval", 30000, ".\\setting.ini");
        }

        private void ProcessMonitor_Load(object sender, EventArgs e)
        {
            data_grid_view_process.ColumnCount = 3;
            data_grid_view_process.Columns[0].HeaderText = "ID";
            data_grid_view_process.Columns[1].HeaderText = "ProcessId";
            data_grid_view_process.Columns[2].HeaderText = "CommandLine";
        }

        private void button_update_process_monitor_Click(object sender, EventArgs e)
        {
            data_grid_view_process.ColumnCount = 3;
            data_grid_view_process.Columns[0].HeaderText = "ID";
            data_grid_view_process.Columns[1].HeaderText = "ProcessId";
            data_grid_view_process.Columns[2].HeaderText = "CommandLine";

            int capacitySize = 256;
            StringBuilder string_builder = new StringBuilder(capacitySize);
            GetPrivateProfileString("SETTING", "command_line_like", "", string_builder, Convert.ToUInt32(string_builder.Capacity), ".\\setting.ini");

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(string.Format("SELECT * FROM Win32_Process WHERE CommandLine like '%{0}%'", string_builder.ToString())))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                data_grid_view_process.RowCount = objects.Count;
                int row = 0;
                foreach (var obj in objects)
                {
                    try
                    {
                        data_grid_view_process.Rows[row].Cells[0].Value = row + 1;
                        data_grid_view_process.Rows[row].Cells[1].Value = obj["ProcessId"]?.ToString();
                        data_grid_view_process.Rows[row].Cells[2].Value = obj["CommandLine"]?.ToString();
                        row += 1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: {0}", ex.Message);
                    }
                }
                label_count.Text = string.Format("Count: {0}", row.ToString());
            }
        }

        private void timer_update_process_monitor_Tick(object sender, EventArgs e)
        {
            if (checkBox_auto_update.Checked)
            {
                button_clear_process_monitor_Click(sender, e);
                button_update_process_monitor_Click(sender, e);
            }
        }

        private void button_clear_process_monitor_Click(object sender, EventArgs e)
        {
            label_count.Text = string.Format("Count: ");
            data_grid_view_process.Rows.Clear();
        }
    }
}
