using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PosSystem
{
    internal class category
    {
        public string categoryId;
        public string categoryName;

        public category()
        {
        }

        public category(string categoryId, string categoryName)
        {
            this.categoryId = categoryId ?? throw new ArgumentNullException(nameof(categoryId));
            this.categoryName = categoryName ?? throw new ArgumentNullException(nameof(categoryName));
        }

        public string CategoryId { 
            get { return categoryId; } 
            set { categoryId = value; } 
        }
        public string CategoryName { 
            get 
            {
                Regex check = new Regex(@"^[a-zA-Z0-9\s-/'/,/][^|=]*$");
                check.IsMatch(categoryName);
                if (check.IsMatch(categoryName))
                {
                    return categoryName;
                }
                else
                {
                    return "0";
                } 
            } 
            set { categoryId = value; } 
        }
    }
}
