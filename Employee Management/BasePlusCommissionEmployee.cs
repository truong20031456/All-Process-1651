using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
     class BasePlusCommissionEmployee : CommissionEmployee
    {
        private Double _baseSalary;

        public BasePlusCommissionEmployee(string firstName,string lastName,string socialSecurityNumber,double grossSales, double commissionRate, double baseSalary ) : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            
            if (baseSalary <0.0) {
                throw new ArgumentException("Base salary must be > 0.0");
            }
            this._baseSalary = baseSalary;
        }
        public void setBaseSalary(double baseSalary)
        {
            if(baseSalary <0.0)
            {
                throw new ArgumentException("Base salary must be >= 0.0")
            ;
            }
            this._baseSalary = baseSalary;
        }
        public double getBaseSalary() { return this._baseSalary; }
        public override double earning()
        {
            return getBaseSalary() + base.earning();
        }

        public override string ToString()
        {
            return string.Format("base-salaried {0}\n{1}: {2:F2}", base.ToString(), "base salary", getBaseSalary());
        }







    }
}
