using GoodTeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodTeas.Services
{
    internal class DataGridViewService
    {
        public void AddTeaToDataGridView(Tea tea, DataGridView dataGridView)
        {
            // Add the tea to the DataGridView
            dataGridView.Rows.Add(tea.Name, tea.Type, tea.CaffeineContent, tea.SteepTime, tea.WaterTemperature, tea.Notes, tea.Rating);
        }
    }
}
