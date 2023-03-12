using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementDay35
{
    public class ProductReviewManagement
    {
        public static void RetriveTo3ReviewBasedOnTheHighestRating(List<ProductReview> list)
        {
            Console.WriteLine("\nSorted Order");

            List<ProductReview> sortedList = (from product in list orderby product.Rating descending select product).ToList();
            program.IterateOverProductReview(sortedList);

            Console.WriteLine("\nRetriveint To 3Review Based On The Highest Rating");
            List<ProductReview> top3res = sortedList.Take(3).ToList();
            program.IterateOverProductReview(top3res);


        }
       