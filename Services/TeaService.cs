using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodTeas.Models;

namespace GoodTeas.Services
{
    /// <summary>
    /// Hanlde all Tea related needs for the GoodTeas project
    /// </summary>
    internal class TeaService
    {
        /// <summary>
        /// Add a List of Teas to a DataGridView
        /// </summary>
        /// <param name="teas">List of Tea to be added</param>
        /// <param name="dataGridView">DataGridView where Tea will be added</param>
        public void AddTeasToDataGridView(List<Tea> teas, DataGridView dataGridView)
        {
            // Initialize the DataGridViewService
            DataGridViewService dataGridViewService = new DataGridViewService();
            // Iterate through the teas and add them
            foreach (Tea tea in teas)
            {
                dataGridViewService.AddTeaToDataGridView(tea, dataGridView);
            }
        }
    }
}
