using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.Classes;
using TestTask.Models;

namespace TestTask.Forms
{
    public partial class StatisticsForm : Form
    {
        public List<Statistics> statistics = new List<Statistics>();
        StatisticsFromDb statisticsFromDb = new StatisticsFromDb();
        List<string> statuses = new List<string>();

        public StatisticsForm()
        {
            InitializeComponent();

            dgvStatistics.Columns[0].DataPropertyName = "Date";
            dgvStatistics.Columns[1].DataPropertyName = "Count";
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            statuses = statisticsFromDb.LoadStatuses();
            statuses.Insert(0, "Все статусы");
            cbStatus.DataSource = statuses;

            rbEmploy.Checked = true;
            dtpStart.Value = DateTime.Today.AddMonths(-1);
            dtpEnd.Value = DateTime.Today;
        }

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты окончания!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStart.Value > DateTime.Today)
            {
                MessageBox.Show("Дата начала не может быть больше текущей даты!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int? statusId = null;
                if (cbStatus.SelectedIndex > 0)
                {
                    statusId = statisticsFromDb.GetStatusIdByName(cbStatus.SelectedItem.ToString());
                }
                DateTime start = dtpStart.Value.Date;
                DateTime end = dtpEnd.Value.Date;
                bool isEmploy = rbEmploy.Checked;

                statistics = statisticsFromDb.LoadStatistics(statusId, start, end, isEmploy);
                dgvStatistics.DataSource = statistics;

                if (statistics.Count == 0)
                {
                    MessageBox.Show("За выбранный период данных не найдено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке статистики: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
