using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
     class CommissionEmployee
    {
        private readonly string _firstName;

        private readonly string _lastName;
        private readonly string _socialSecurityNumber;
        private double grossSales;
        private double commissionRate;

        
    
        public CommissionEmployee( string Firstname, string LastName, string SocialSecurityNumber, double GrossSales, double CommissionRate)
        {
          if(grossSales < 0.0)
            {
                throw new ArgumentException("Gross sale must be >= 0");
            }
            if (commissionRate<0.0|| commissionRate>0.1)
            {
                throw new ArgumentException(" Commissionrate must be > 0.0  and 1.0 ");
            }
            this._firstName = Firstname;
            this._lastName = LastName;
            this._socialSecurityNumber = SocialSecurityNumber;
            this.grossSales = GrossSales;
            this.commissionRate = CommissionRate;
        }
        public string getfirstName { get { return _firstName; } }
        public string getlastName { get { return _lastName;} }
        public string getSocietyNumber { get { return _socialSecurityNumber; } }
            public double getGrosssales { get { return grossSales; }  private set 
            { 
            if (grossSales < 0.0)
                {
                    throw new ArgumentException("Gross sale must be >= 0");
                }
            grossSales = value;
            }
        }
        public void setGrossSales(double grossSales)
        {
            if (grossSales < 0.0)
            {
                throw new ArgumentException("Gross sales must be >= 0.0");
            }
            this.grossSales = grossSales;
        }
        public void setCommissionRate(double commissionRate)
        {
            if (commissionRate <= 0.0 || commissionRate >= 1.0)
            {
                throw new ArgumentException(
                "Commission rate must be > 0.0 and < 1.0");
            }
            this.commissionRate = commissionRate;
        }
        public double getComissionRate { get { return commissionRate; } 
        }
        public virtual double  earning() { return this.commissionRate * grossSales; }



        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:F2}\n{7}: {8:F2}",
                "commission employee", getfirstName, getlastName,
                "social security number", getSocietyNumber,
                "gross sales", getGrosssales,
                "commission rate", getComissionRate);
        }




    }

}




    

