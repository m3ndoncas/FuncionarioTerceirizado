using System;
using System.Collections.Generic;
using System.Text;

namespace FuncionarioTerceirizado.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + ( this.AdditionalCharge * 1.1);

        }
    }


}
