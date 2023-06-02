using DoAn_LapTrinhWeb.Model;
using DoAn_LapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_LapTrinhWeb.ViewModel
{
    public class CheckoutViewModel
    {
        public List<CheckoutViewModel> CartProducts { get; set; }
        public List<int> CartProductIDs { get; set; }

    }
    public class ViewModel

    {
        public double MinimumPrice { get; set; }
        public double MaximumPrice { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Product> Products { get; set; }

    }
}