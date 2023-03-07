using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PosSystem
{
    internal class supplier
    {
        private string supplierId;
        private string supplierName;
        private string mobileCon;
        private string landlineCon;
        private string email;
        private string address;
        private string status;

        public supplier()
        {
        }

        public supplier(string supplierId, string supplierName, string mobileCon, string landlineCon, string email, string address, string status)
        {
            this.supplierId = supplierId ?? throw new ArgumentNullException(nameof(supplierId));
            this.supplierName = supplierName ?? throw new ArgumentNullException(nameof(supplierName));
            this.mobileCon = mobileCon ?? throw new ArgumentNullException(nameof(mobileCon));
            this.landlineCon = landlineCon ?? throw new ArgumentNullException(nameof(landlineCon));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.status = status ?? throw new ArgumentNullException(nameof(status));
        }

        public string SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public string SupplierName { 
            get 
            {
                Regex check = new Regex(@"^([a-zA-Z1-9\s]+)$");
                check.IsMatch(supplierName);
                if (check.IsMatch(supplierName))
                {
                    return supplierName;
                }
                else
                {
                    return "0";
                } 
            } 
            set { supplierName= value; } 
        }

        public string MobileCon
        {
            get 
            {
                Regex check = new Regex(@"(^[0]{1}[0-9]{9}$)");
                check.IsMatch(mobileCon);
                if (check.IsMatch(mobileCon))
                {
                    return mobileCon;
                }
                else
                {
                    return "0";
                } 
            }
            set { mobileCon = value; }
        }
        public string LandlineCon
        {
            get 
            {
                Regex check = new Regex(@"(^[0]{1}[0-9]{9}$)");
                check.IsMatch(landlineCon);
                if (check.IsMatch(landlineCon))
                {
                    return landlineCon;
                }
                else
                {
                    return "0";
                }
            }
            set { landlineCon = value; }
        }

        public string Email
        {
            get 
            {
                Regex check = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                check.IsMatch(email);
                if (check.IsMatch(email))
                {
                    return email;
                }
                else
                {
                    return "0";
                };
            }
            set { email = value; }
        }

        public string Address
        {
            get 
            {
                Regex check = new Regex(@"^([\w'"",-\\/.\s]+)$");
                check.IsMatch(address);
                if (check.IsMatch(address))
                {
                    return address;
                }
                else
                {
                    return "0";
                }
            }
            set { address = value; }
        }
        
        public string Status { 
            get 
            {
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(status);
                if (check.IsMatch(status))
                {
                    return status;
                }
                else
                {
                    return "0";
                }
            }
            set { status = value; }
        }
    }
}
