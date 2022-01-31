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
        public List<Product> products { get; set; }

        public Provider()
        {
            this.products = new List<Product>();
        }
    }
}
