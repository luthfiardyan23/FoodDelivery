using System;
using System.Collections.Generic;

namespace FoodService.Models
{
    public partial class Profile
    {
        public int Id { get; set; }
        public int UseId { get; set; }
        public string Name { get; set; } = null!;
        public string Addres { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual User Use { get; set; } = null!;
    }
}
