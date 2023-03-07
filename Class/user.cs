using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace PosSystem
{
    internal class user
    {
        private string userId;
        private string nic;
        private string firstName;
        private string lastName;
        private string fullName;
        private string address;
        private string contact;
        private string username;
        private string role;
        private string password;
        private string email;
        private string gender;
        private string status;
        

        public user() { }

        public user(string userId, string nic, string firstName, string lastName, string fullName, string address, string contact, string username, string role, string password, string status, string gender)
        {
            this.UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            this.nic = nic ?? throw new ArgumentNullException(nameof(nic));
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.fullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
            this.username = username ?? throw new ArgumentNullException(nameof(username));
            this.role = role ?? throw new ArgumentNullException(nameof(role));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            this.status = status ?? throw new ArgumentNullException(nameof(status));
            this.gender = gender ?? throw new ArgumentNullException(nameof(gender)); ;
        }

        public string UserId 
        {
            get
            {
                Regex check = new Regex(@"(^[0-9]{5}$)");
                check.IsMatch(userId);
                if (check.IsMatch(userId))
                {
                    return userId;
                }
                else
                {
                    return "0";
                }
            }
            set { userId = value; }
        } 
        public string Nic
        {
            get
            {
                Regex check = new Regex(@"^([0-9]{9}[x|X|v|V]|[0-9]{12})$");
                check.IsMatch(nic);
                if (check.IsMatch(nic))
                {
                    return nic;
                }
                else
                {
                    return "0";
                }

            }
            set { nic = value; }
        }
        public string FirstName
        {
            get 
            { 
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(firstName);
                if (check.IsMatch(firstName))
                {
                    return firstName;
                }
                else
                {
                    return "0";
                }
                 
            }
            set { firstName = value; }
        }
        public string LastName
        {
            get {
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(lastName);
                if (check.IsMatch(lastName))
                {
                    return lastName;
                }
                else
                {
                    return "0";
                }
            }
            set { lastName = value; }
        }
        public string FullName
        {
            get
            {
                Regex check = new Regex(@"^([a-zA-Z\s]+)$");
                check.IsMatch(fullName);
                if (check.IsMatch(fullName))
                {
                    return fullName;
                }
                else
                {
                    return "0";
                }
            }
            set { fullName = value; }
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
        public string Contact
        {
            get 
            {
                Regex check = new Regex(@"(^[0]{1}[0-9]{9}$)");
                check.IsMatch(contact);
                if (check.IsMatch(contact))
                {
                    return contact;
                }
                else
                {
                    return "0";
                }
            }
            set { contact = value; }
        }
        public string Username
        {
            get {
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(username);
                if (check.IsMatch(username))
                {
                    return username;
                }
                else
                {
                    return "0";
                }
            }
            set { username = value; }
        }
        public string Password
        {
            get 
            {
                Regex check = new Regex(@"^([a-zA-Z0-9]+)$");
                check.IsMatch(password);
                if (check.IsMatch(password))
                {
                    return password;
                }
                else
                {
                    return "0";
                }
            }
            set { password = value; }
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
        public string Role
        {
            get
            {
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(role);
                if (check.IsMatch(role))
                {
                    return role;
                }
                else
                {
                    return "0";
                }
            }
            set { role = value; }
        }
        public string Gender 
        {
            get
            {
                Regex check = new Regex(@"^([a-zA-Z]+)$");
                check.IsMatch(gender);
                if (check.IsMatch(gender))
                {
                    return gender;
                }
                else
                {
                    return "0";
                }
            }
            set { gender= value; }
        }
        public string Status
        {
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
