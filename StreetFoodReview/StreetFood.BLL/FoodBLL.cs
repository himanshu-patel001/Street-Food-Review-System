using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using StreetFood.DAL;

namespace StreetFood.BLL
{
    public class FoodBLL
    {
        FoodDAL dal = new FoodDAL();

        // Save data (Insert)
        public void SaveReview(FoodReview f)
        {
            // Validation
            if (string.IsNullOrEmpty(f.Name))
                throw new Exception("Name is required");

            if (string.IsNullOrEmpty(f.FoodItem))
                throw new Exception("Food Item is required");

            if (string.IsNullOrEmpty(f.Location))
                throw new Exception("Location is required");

            if (f.Rating < 1 || f.Rating > 5)
                throw new Exception("Rating must be between 1 and 5");

            // Call DAL
            dal.InsertReview(f);
        }

        // Get data (Grid)
        public DataTable GetReviews()
        {
            return dal.GetAllReviews();
        }
    }
}
