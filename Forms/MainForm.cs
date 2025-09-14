using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestTask.Classes;
using TestTask.Models;

namespace TestTask.Forms
{
    public partial class MainForm : Form
    {
        public List<Employee> employees = new List<Employee>();
        EmployeeFromDb employeeFromDb = new EmployeeFromDb();


        public MainForm()
        {
            InitializeComponent();

            Dg_LoadEmployee.Columns[0].DataPropertyName = "Fio";
            Dg_LoadEmployee.Columns[1].DataPropertyName = "Status";
            Dg_LoadEmployee.Columns[2].DataPropertyName = "Department";
            Dg_LoadEmployee.Columns[3].DataPropertyName = "Post";
            Dg_LoadEmployee.Columns[4].DataPropertyName = "DateOfAdm";
            Dg_LoadEmployee.Columns[5].DataPropertyName = "DateOfDis";
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            var statForm = new StatisticsForm();
            statForm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            employees = employeeFromDb.LoadEmployees();
            Dg_LoadEmployee.DataSource = employees;

            List<string> statuses = new List<string>();
            statuses.Add("Все статусы");
            foreach (Employee emp in employees)
            {
                if (emp.Status != null && !statuses.Contains(emp.Status))
                    statuses.Add(emp.Status);
            }
            cb_status.DataSource = statuses;

            List<string> departments = new List<string>();
            departments.Add("Все отделы");
            foreach (Employee emp in employees)
            {
                if (emp.Department != null && !departments.Contains(emp.Department))
                    departments.Add(emp.Department);
            }
            cb_department.DataSource = departments;

            List<string> posts = new List<string>();
            posts.Add("Все должности");
            foreach (Employee emp in employees)
            {
                if (emp.Post != null && !posts.Contains(emp.Post))
                    posts.Add(emp.Post);
            }
            cb_post.DataSource = posts;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Employee> filtered = new List<Employee>();
                string search = tb_search.Text.Trim().ToLower();

                foreach (Employee emp in employees)
                {
                    bool match = true;

                    if (!string.IsNullOrEmpty(search))
                    {
                        if (emp.Fio != null && emp.Fio.Contains(" "))
                        {
                            string lastName = emp.Fio.Split(' ')[0].ToLower();
                            if (lastName.IndexOf(search) < 0)
                                match = false;
                        }
                        else
                        {
                            match = false;
                        }
                    }

                    if (cb_status.SelectedIndex > 0 && emp.Status != cb_status.SelectedItem.ToString())
                        match = false;

                    if (cb_department.SelectedIndex > 0 && emp.Department != cb_department.SelectedItem.ToString())
                        match = false;

                    if (cb_post.SelectedIndex > 0 && emp.Post != cb_post.SelectedItem.ToString())
                        match = false;

                    if (match)
                        filtered.Add(emp);
                }

                Dg_LoadEmployee.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при фильтрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search_TextChanged(sender, e);
        }

        private void comboBox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search_TextChanged(sender, e);
        }

        private void comboBox_post_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search_TextChanged(sender, e);
        }

        private void Dg_LoadEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dg_LoadEmployee.Columns[e.ColumnIndex].DataPropertyName == "Fio")
            {
                var emp = Dg_LoadEmployee.Rows[e.RowIndex].DataBoundItem as Employee;
                if (emp != null && emp.Status == "Уволен")
                {
                    e.CellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }
}
