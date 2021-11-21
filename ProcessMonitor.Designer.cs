
namespace ProcessMonitor
{
    partial class ProcessMonitor
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.data_grid_view_process = new System.Windows.Forms.DataGridView();
            this.button_update_process_monitor = new System.Windows.Forms.Button();
            this.timer_update_process_monitor = new System.Windows.Forms.Timer(this.components);
            this.button_clear_process_monitor = new System.Windows.Forms.Button();
            this.checkBox_auto_update = new System.Windows.Forms.CheckBox();
            this.label_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_process)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_view_process
            // 
            this.data_grid_view_process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_view_process.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_grid_view_process.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grid_view_process.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_grid_view_process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_process.Location = new System.Drawing.Point(12, 89);
            this.data_grid_view_process.Name = "data_grid_view_process";
            this.data_grid_view_process.ReadOnly = true;
            this.data_grid_view_process.RowTemplate.Height = 21;
            this.data_grid_view_process.Size = new System.Drawing.Size(776, 349);
            this.data_grid_view_process.TabIndex = 0;
            // 
            // button_update_process_monitor
            // 
            this.button_update_process_monitor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update_process_monitor.Location = new System.Drawing.Point(12, 12);
            this.button_update_process_monitor.Name = "button_update_process_monitor";
            this.button_update_process_monitor.Size = new System.Drawing.Size(75, 43);
            this.button_update_process_monitor.TabIndex = 1;
            this.button_update_process_monitor.Text = "UPDATE";
            this.button_update_process_monitor.UseVisualStyleBackColor = false;
            this.button_update_process_monitor.Click += new System.EventHandler(this.button_update_process_monitor_Click);
            // 
            // timer_update_process_monitor
            // 
            this.timer_update_process_monitor.Enabled = true;
            this.timer_update_process_monitor.Interval = 30000;
            this.timer_update_process_monitor.Tick += new System.EventHandler(this.timer_update_process_monitor_Tick);
            // 
            // button_clear_process_monitor
            // 
            this.button_clear_process_monitor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear_process_monitor.Location = new System.Drawing.Point(93, 12);
            this.button_clear_process_monitor.Name = "button_clear_process_monitor";
            this.button_clear_process_monitor.Size = new System.Drawing.Size(75, 43);
            this.button_clear_process_monitor.TabIndex = 2;
            this.button_clear_process_monitor.Text = "CLEAR";
            this.button_clear_process_monitor.UseVisualStyleBackColor = false;
            this.button_clear_process_monitor.Click += new System.EventHandler(this.button_clear_process_monitor_Click);
            // 
            // checkBox_auto_update
            // 
            this.checkBox_auto_update.AutoSize = true;
            this.checkBox_auto_update.Checked = true;
            this.checkBox_auto_update.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_auto_update.Location = new System.Drawing.Point(174, 39);
            this.checkBox_auto_update.Name = "checkBox_auto_update";
            this.checkBox_auto_update.Size = new System.Drawing.Size(104, 16);
            this.checkBox_auto_update.TabIndex = 3;
            this.checkBox_auto_update.Text = "AUTO UPDATE";
            this.checkBox_auto_update.UseVisualStyleBackColor = true;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(12, 74);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(50, 12);
            this.label_count.TabIndex = 4;
            this.label_count.Text = "COUNT: ";
            // 
            // ProcessMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.checkBox_auto_update);
            this.Controls.Add(this.button_clear_process_monitor);
            this.Controls.Add(this.button_update_process_monitor);
            this.Controls.Add(this.data_grid_view_process);
            this.Name = "ProcessMonitor";
            this.Text = "Process Monitor";
            this.Load += new System.EventHandler(this.ProcessMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_process)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_view_process;
        private System.Windows.Forms.Button button_update_process_monitor;
        private System.Windows.Forms.Timer timer_update_process_monitor;
        private System.Windows.Forms.Button button_clear_process_monitor;
        private System.Windows.Forms.CheckBox checkBox_auto_update;
        private System.Windows.Forms.Label label_count;
    }
}

