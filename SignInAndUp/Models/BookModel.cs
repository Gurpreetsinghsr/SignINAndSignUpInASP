using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignInAndUp.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string PizzaName { get; set; }
        
        public string Description { get; set; }

        public int PriceofLarge { get; set; }

        public int PriceofMedium { get; set; }

        public int PriceofRegular { get; set; }
    }
}
