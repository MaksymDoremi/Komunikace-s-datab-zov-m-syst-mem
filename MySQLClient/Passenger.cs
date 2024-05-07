using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLClient
{
    public class Passenger
    {
        protected string _name;
        public Passenger(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }

        public void StaticMethod()
        {
            this._name = "aaa";
        }
    }
}
