using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    internal class order
    {
        string orderid;
        decimal totalprice;
        int quantity;
        string description;
        string supplierid;

        public order()
        {
        }

        public order(string orderid, decimal totalprice, int quantity, string description, string supplierid)
        {
            this.orderid = orderid ?? throw new ArgumentNullException(nameof(orderid));
            this.totalprice = totalprice;
            this.quantity = quantity;
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.supplierid = supplierid ?? throw new ArgumentNullException(nameof(supplierid));
        }

        public string OrderID
        {
            get { return orderid; }
            set { orderid = value; }
        }

        public decimal TotalPrice
        {
            get 
            {
                Regex check = new Regex(@"^([0-9]+)$");
                string totalPrice = totalprice.ToString();
                if (totalPrice == "")
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(totalPrice))
                    {
                        return totalprice;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            set { totalprice = value; }
        }

        public int Quantity
        {
            get 
            {
                Regex check = new Regex(@"^([0-9]+)$");
                string NoUnits = quantity.ToString();
                if (NoUnits == "")
                {
                    return 0;
                }
                else
                {
                    if (check.IsMatch(NoUnits))
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

        public string Description
        {
            get 
            {
                Regex check = new Regex(@"^([\w'"",-\\/.\s]+)$");
                check.IsMatch(description);
                if (check.IsMatch(description))
                {
                    return description;
                }
                else
                {
                    return "0";
                }
            }
            set { description = value; }
        }

        public string SupplierId
        {
            get 
            {
                Regex check = new Regex(@"^([0-9]+)$");
                if (check.IsMatch(supplierid))
                {
                    return supplierid;
                }
                else
                {
                    return "0";
                }
            }
            set { supplierid = value; }
        }
    }
}
