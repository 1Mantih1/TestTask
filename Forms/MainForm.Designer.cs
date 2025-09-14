namespace TestTask.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dg_LoadEmployee = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_post = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lblLegend = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_LoadEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_LoadEmployee
            // 
            this.Dg_LoadEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_LoadEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.Status,
            this.Department,
            this.Post,
            this.DateOfAdm,
            this.DateOfDis});
            this.Dg_LoadEmployee.Location = new System.Drawing.Point(20, 140);
            this.Dg_LoadEmployee.Name = "Dg_LoadEmployee";
            this.Dg_LoadEmployee.Size = new System.Drawing.Size(773, 300);
            this.Dg_LoadEmployee.TabIndex = 0;
            this.Dg_LoadEmployee.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dg_LoadEmployee_CellFormatting);
            // 
            // Fio
            // 
            this.Fio.HeaderText = "ФИО";
            this.Fio.Name = "Fio";
            this.Fio.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // Department
            // 
            this.Department.HeaderText = "Отдел";
            this.Department.Name = "Department";
            this.Department.Width = 120;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.Width = 120;
            // 
            // DateOfAdm
            // 
            this.DateOfAdm.HeaderText = "Дата приёма";
            this.DateOfAdm.Name = "DateOfAdm";
            this.DateOfAdm.Width = 120;
            // 
            // DateOfDis
            // 
            this.DateOfDis.HeaderText = "Дата увольнения";
            this.DateOfDis.Name = "DateOfDis";
            this.DateOfDis.Width = 120;
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(120, 20);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 1;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(120, 50);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(121, 21);
            this.cb_department.TabIndex = 2;
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.comboBox_department_SelectedIndexChanged);
            // 
            // cb_post
            // 
            this.cb_post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_post.FormattingEnabled = true;
            this.cb_post.Location = new System.Drawing.Point(120, 80);
            this.cb_post.Name = "cb_post";
            this.cb_post.Size = new System.Drawing.Size(121, 21);
            this.cb_post.TabIndex = 3;
            this.cb_post.SelectedIndexChanged += new System.EventHandler(this.comboBox_post_SelectedIndexChanged);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(120, 110);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(121, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(300, 20);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 30);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.Location = new System.Drawing.Point(20, 460);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(227, 13);
            this.lblLegend.TabIndex = 6;
            this.lblLegend.Text = "* Розовый фон - это уволенные сотрудники";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 53);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Отдел:";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(20, 83);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(68, 13);
            this.lblPost.TabIndex = 9;
            this.lblPost.Text = "Должность:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 113);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Поиск:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 490);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_post);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.Dg_LoadEmployee);
            this.Name = "MainForm";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_LoadEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_LoadEmployee;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.ComboBox cb_post;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDis;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblSearch;
    }
}

