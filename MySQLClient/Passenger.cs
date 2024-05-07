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
        protected string _surname;
        public Passenger(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }

        public string Surname
        {
            get => this._surname;
            set => this._surname = value;
        }

        public void StaticMethod()
        {
            this._name = "aaa";
        }
    }
}
