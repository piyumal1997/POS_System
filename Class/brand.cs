using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PosSystem
{
    internal class brand
    {
        public string brandId;
        public string brandName;

        public brand()
        {
        }

        public brand(string brandId, string brandName)
        {
            this.brandId = brandId ?? throw new ArgumentNullException(nameof(brandId));
            this.brandName = brandName ?? throw new ArgumentNullException(nameof(brandName));
        }

        public string BrandId { 
            get { return brandId; } 
            set { brandId = value; } 
        }

        public string BrandName { 
            get 
            {
                Regex check = new Regex(@"^[a-zA-Z0-9\s-/'/,/][^|=]*$");
                check.IsMatch(brandName);
                if (check.IsMatch(brandName))
                {
                    return brandName;
                }
                else
                {
                    return "0";
                }
            } 
            set { brandName = value; } 
        }
    }
}
