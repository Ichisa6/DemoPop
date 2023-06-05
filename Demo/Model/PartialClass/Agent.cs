using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public partial class Agent
    {
        public string FullName
        {
            get 
            {
                return $"{AgentType.Title} | {Title}";
            }
        }

        public string AgentDiscount
        {
            get
            {
                var productSale = App.DB.ProductSale.Where(x => x.AgentID == ID).ToList();
                decimal discountBuffer = 0;
                foreach (var item in productSale)
                {
                    discountBuffer += App.DB.Product.FirstOrDefault(x => x.ID == item.ProductID).MinCostForAgent * item.ProductCount;
                }

                if (discountBuffer >= 0 && discountBuffer <= 10000)
                {

                }

                return $"{discountBuffer}";
            }
        }
    }
}
