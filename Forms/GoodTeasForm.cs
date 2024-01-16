using GoodTeas.Models;
using GoodTeas.Services;

namespace GoodTeas
{
    public partial class goodTeasForm : Form
    {
        TeaService teaService;

        public goodTeasForm()
        {
            InitializeComponent();
            //
            // Initialize the services
            //
            teaService = new TeaService();
            //
            // Load in the Tea XML data 
            //
            // Initialize the XMLDocumentService
            XMLDocumentService xmlDocService = new XMLDocumentService();
            // Read in the data
            List<Tea> teas = xmlDocService.ReadInData();
            // Fill in the Tea DataGridView
            teaService.AddTeasToDataGridView(teas, teasDataGridView);
        }

        private void addTeaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding Tea is not supported right now");
        }
    }
}