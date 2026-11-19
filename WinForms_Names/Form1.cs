namespace WindowsFormsNames
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name.");
            }
        }
    }
}
