using Staj.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj.Core.Dtos
{
    public class ProductFeatureDto
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductID { get; set; }
    }
}
