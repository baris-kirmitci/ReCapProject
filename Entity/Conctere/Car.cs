using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Conctere
{
    public class Car :IEntity
    {
        public int CarId { get; set; }
        public int CategoryId { get; set; } //Arabanın türü: spor,cip,sedan,hybrit
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public long ModelYear { get; set; }
        public string Description { get; set; }
        public double DailyPrice { get; set; }

    }
}
