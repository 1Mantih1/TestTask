namespace TestTask.Forms
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.RadioButton rbEmploy;
        private System.Windows.Forms.RadioButton rbUneploy;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.rbEmploy = new System.Windows.Forms.RadioButton();
            this.rbUneploy = new System.Windows.Forms.RadioButton();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Location = new System.Drawing.Point(120, 20);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 21);
            this.cbStatus.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(120, 60);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(260, 60);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // rbEmploy
            // 
            this.rbEmploy.Location = new System.Drawing.Point(120, 100);
            this.rbEmploy.Name = "rbEmploy";
            this.rbEmploy.Size = new System.Drawing.Size(100, 20);
            this.rbEmploy.TabIndex = 3;
            this.rbEmploy.Text = "Принятые";
            // 
            // rbUneploy
            // 
            this.rbUneploy.Location = new System.Drawing.Point(230, 100);
            this.rbUneploy.Name = "rbUneploy";
            this.rbUneploy.Size = new System.Drawing.Size(100, 20);
            this.rbUneploy.TabIndex = 4;
            this.rbUneploy.Text = "Уволенные";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Count});
            this.dgvStatistics.Location = new System.Drawing.Point(20, 140);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.Size = new System.Drawing.Size(420, 200);
            this.dgvStatistics.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(347, 99);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(93, 23);
            this.btnShowStatistics.TabIndex = 6;
            this.btnShowStatistics.Text = "Показать";
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 21);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Статус:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(20, 60);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(100, 21);
            this.lblPeriod.TabIndex = 9;
            this.lblPeriod.Text = "Период:";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(20, 100);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 21);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Тип события:";
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // StatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(514, 380);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.rbEmploy);
            this.Controls.Add(this.rbUneploy);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblType);
            this.Name = "StatisticsForm";
            this.Text = "Статистика сотрудников";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}
