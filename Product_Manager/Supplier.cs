using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    internal class Supplier
    {
        private int SupplierId { get; set; }
        private string CompanyName { get; set; }

        public Supplier(int supplierId, string companyName)
        {
            SupplierId = supplierId;
            CompanyName = companyName;
        }

        public int GetSupplierId()
        {
            return SupplierId;
        }

        public string GetCompanyName()
        {
            return CompanyName;
        }
    }

}

