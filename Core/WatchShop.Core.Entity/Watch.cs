using System;
using System.Collections.Generic;
using System.Text;

namespace WatchShop.Core.Entity
{
    public class Watch
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }
    }
}
