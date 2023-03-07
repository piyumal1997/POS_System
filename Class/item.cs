using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PosSystem
{
    internal class item
    {
        private string itemCode;
        private string itemBrand;
        private string itemCategory;
        private string itemDescription;
        private decimal itemCost;
        private decimal itemPrice;
        private decimal maxDiscount;
        private int quantity;
        private string itemSize;

        public item() { }

        public item(string itemCode, string itemBrand, string itemCategory, string itemSize, string itemDescription, decimal itemCost, decimal itemPrice, decimal maxDiscount, int quantity)
        {
            this.itemCode = itemCode ?? throw new ArgumentNullException(nameof(itemCode));
            this.itemBrand = itemBrand ?? throw new ArgumentNullException(nameof(itemBrand));
            this.itemCategory = itemCategory ?? throw new ArgumentNullException(nameof(itemCategory));
            this.itemSize = itemSize ?? throw new ArgumentNullException(nameof(itemSize));
            this.itemDescription = itemDescription;
            this.itemCost = itemCost;
            this.itemPrice = itemPrice;
            this.maxDiscount = maxDiscount;
            this.quantity = quantity;
        }

        public string ItemCode 
        { 
            get { return itemCode; } 
            set { itemCode = value; } 
        }

        public string ItemBrand 
        { 
            get { return itemBrand; } 
            set { itemBrand = value; } 
        }

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; }
        }

        public string ItemSize
        {
            get 
            {
                Regex check = new Regex(@"^(S|M|X{0,4}[L]|[0-9]{2})$");
                if (itemSize == "")
                {
                    return itemSize;
                }
                else
                {
                    if (check.IsMatch(itemSize))
                    {
                        return itemSize;
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
            set { itemSize = value; }
        }

        public string ItemDescription
        {
            get 
            {
                Regex check = new Regex(@"^([\w'"",-\\/.\s]+)$");
                check.IsMatch(itemDescription);

                if (itemDescription == "")
                {
                    return itemDescription;
                }
                else
                {
                    if (check.IsMatch(itemDescription))
                    {
                        return itemDescription;
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
            set { itemDescription = value; }
        }

        public decimal ItemCost
        {
            get 
            {
                Regex check = new Regex(@"^([0-9]+)$");
                string itemCostStr = itemCost.ToString();
                if (itemCostStr == "")
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(itemCostStr))
                    {
                        return itemCost;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            set { itemCost = value; }
        }

        public decimal ItemPrice
        {
            get 
            { 
                Regex check = new Regex(@"^([0-9]+)$");
                string itemPriceStr = itemPrice.ToString();
                if (itemPriceStr == "")
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(itemPriceStr))
                    {
                        return itemPrice;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            set { itemPrice = value; }
        }

        public decimal MaxDiscount
        {
            get 
            {
                Regex check = new Regex(@"^([0-9]+)$");
                string maxDiscountStr = itemPrice.ToString();
                if (maxDiscountStr == "" || itemPrice < 100)
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(maxDiscountStr))
                    {
                        return maxDiscount;
                    }
                    else
                    {
                        return 0;
                    }
                }
                 
            }
            set { maxDiscount = value; }
        }

        public int Quantity
        {
            get
            {
                Regex check = new Regex(@"^([0-9]+)$");
                check.IsMatch(quantity.ToString());
                if (quantity.ToString() == "" || quantity <= 0)
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(quantity.ToString()))
                    {
                        return quantity;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            set { quantity = value; }
        }
    }
}
