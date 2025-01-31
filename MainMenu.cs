namespace turbo_dash
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            // Set up the DataGridView columns
            partsviewer.Columns.Add("PartName", "Part Name");
            partsviewer.Columns.Add("PartNumber", "Part Number");
            partsviewer.Columns.Add("PartCost", "Part Cost");
            partsviewer.Columns.Add("PartStatus", "Part Status");
        }

        private void addpart_Click(object sender, EventArgs e)
        {
            // Get the values from the text fields
            string partName = partnametext.Text;
            string partNumber = partnumbertext.Text;
            string partCost = partcosttext.Text;
            string partStatus = partstatusid.Text;

            // Add the values as a new row in the DataGridView
            partsviewer.Rows.Add(partName, partNumber, partCost, partStatus);

            // Optional: Clear the text fields after adding the row
            partnametext.Text = "";
            partnumbertext.Text = "";
            partcosttext.Text = "";
            partstatusid.Text = "";
        }
    }
}