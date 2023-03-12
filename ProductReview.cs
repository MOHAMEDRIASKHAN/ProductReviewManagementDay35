using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementDay35
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
        public int Rating { get; set; }
        public override string ToString()
        {
            return $"ProductId:{ProductId} UserId: {UserId} Review: {Review} IsLike: {IsLike} Rating: {Rating}";
        }
  }
}
