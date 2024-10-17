using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardApplication.BAL
{
    public class Employee
    {
        private string _name;
        private int _salary;
        private float _netSalary, _bonus;

        public void SetName(string name)
        {
            _name = name;
        }

        public int Salary
        {

            set
            {
                _salary = value;
            }
            get
            {
                return _salary;
            }
        }

        public void CalculateBonus()
        {
            _bonus = 0;
            if (_salary >= 1000 && _salary < 5000)
            {
                _bonus = 200;
            }
            else if (_salary >= 5000 && _salary < 10000)
            {
                _bonus = _salary * 0.10f;
            }
            else if (_salary >= 10000 && _salary < 50000)
            {
                _bonus = _salary * 0.075f;
            }
            else if (_salary >= 50000 && _salary < 100000)
            {
                _bonus = _salary * 0.05f;
            }
            else if (_salary >= 100000)
            {
                _bonus = _salary * 0.025f;
            }

        }

        public void CalculateNetSalary()
        {
            _netSalary = _salary + _bonus;
        }

        public Tuple<string, int, float, float> GetData()
        {
            return new Tuple<string, int, float, float>(_name, _salary, _bonus, _netSalary);
        }

    }
}