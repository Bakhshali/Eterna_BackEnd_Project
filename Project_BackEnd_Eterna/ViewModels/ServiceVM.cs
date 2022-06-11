using Project_BackEnd_Eterna.Models;
using System.Collections.Generic;

namespace Project_BackEnd_Eterna.ViewModels
{
    public class ServiceVM
    {
        public List<Cart> Carts { get; set; }

        public Statistics Statistics { get; set; }
    }
}
