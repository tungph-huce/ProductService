using System;
using System.Collections.Generic;
using UserService.Models;
using ProductService.Models;  // Đảm bảo thêm namespace này nếu cần

namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }  // Sử dụng List<Product> thay vì List<int>
        public DateTime OrderDate { get; set; }

        // Navigation property
        public virtual User User { get; set; }
    }
}
