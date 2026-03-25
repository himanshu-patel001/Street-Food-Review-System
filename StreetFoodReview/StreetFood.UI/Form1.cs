using StreetFood.BLL;
using System.Xml.Linq;

namespace StreetFood.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");

            LoadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Object banana
                FoodReview f = new FoodReview();

                // Step 2: Form se data lena
                f.Name = txtName.Text;
                f.FoodItem = txtFood.Text;
                f.Location = txtLocation.Text;
                f.Rating = int.Parse(cmbRating.Text);
                f.Comment = txtComment.Text;

                // Step 3: BLL call karna
                FoodBLL bll = new FoodBLL();
                bll.SaveReview(f);

                // Step 4: Message show
                MessageBox.Show("Review Saved 😋");

                // Step 5: Grid refresh
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            FoodBLL bll = new FoodBLL();
            dataGridView1.DataSource = bll.GetReviews();
        }
    }
}
