using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class doctor
    {
        public class Doctor
        {
            private string name;
            private bool available;

            public Doctor(string name)
            {
                this.name = name;
                this.available = true;
            }

            public string GetName()
            {
                return name;
            }

            public bool IsAvailable()
            {
                return available;
            }

            public void SetAvailable(bool status)
            {
                available = status;
            }
        }
    }
}
