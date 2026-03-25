namespace StreetFoodReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submit Working 😋");
        }
    }
}
