using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
    public class Provider
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public string ConfPwd { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public IList<Product> products { get; set; }


        private string pass;
        private string confPass;
        public string Password { 
            get { return pass; }
            set { if (value.Length < 5 || value.Length > 20)
                    Console.WriteLine("///////ERROR///////");
                else
                    pass = value;
                Console.WriteLine("///////SUCCES///////");
            } }
        public string ConfPass{ get { return confPass; }
            set { if (pass.Equals(value))
                {
                    confPass = value;
                    Console.WriteLine("pass==confPass");
                }
              else
                    Console.WriteLine("/////ERROR////////");
                        } 
        }


        public Provider()
        {
            this.products = new List<Product>();
        }

        public Provider(int id,string userName,string email,string pwd,string confPwd,DateTime dateCreated,bool isApproved)
        {
            this.Id = id;
            this.UserName = userName;
            this.Email = email;
            this.Pwd = pwd;
            this.ConfPwd = confPwd;
            this.DateCreated = dateCreated;
            this.IsApproved = isApproved;
            this.products = new List<Product>();
        }

        public void getDetails()
        {
            Console.WriteLine($"{Id} {UserName} {Email}");

            foreach(Product p in products)
            {
                p.getDetails();
            }
        }

        public static void SetIsApproved(Provider p)
        {
            if (p.Pwd == p.ConfPwd)
                p.IsApproved = true;
            else
                p.IsApproved = false;
        }

        public static void SetIsApproved(string password, string confirmPassword,ref bool IsApproved) {

            if (password == confirmPassword)
                IsApproved = true;
            else
                IsApproved = false;
        }
        /*
        public bool Login(string username,string pwd)
        {
            return (username.Equals(UserName) && pwd.Equals(Pwd));
        }

        public bool Login(string username, string pwd,string email)
        {
            return (username.Equals(UserName) && pwd.Equals(Pwd) && email.Equals(Email));
        }
        */
        public bool Login(string username, string pwd, string email=null)
        {     if(email !=null)
            return (username.Equals(UserName) && pwd.Equals(Pwd) && email.Equals(Email));
              else
                return (username.Equals(UserName) && pwd.Equals(Pwd) && email.Equals(Email));
        }

        public void GetProducts(string filterType, string filterValue)
        {
            IList<Product> products = new List<Product>();
            foreach (var product in products)
            {
               
                switch (filterType.ToUpper())
                {
                    case "DESCRIPTION":
                        if (filterValue == product.Description) products.Add(product);
                        break;
                    case "DATEPROD":
                        DateTime.TryParse(filterValue, out var dateTime);
                        if (dateTime == product.DateProd) products.Add(product);
                        break;
                    case "PRICE":
                        Double.TryParse(filterValue, out var price);
                        if (price == product.Price) products.Add(product);
                        break;
                    default:
                        Console.WriteLine("Value not found!");
                        break;

                }
            }

            Console.WriteLine(products);
        }
    }
} 
