using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwitchColors
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ChangeColor { get; set; }
        public Person(string first,string last)
        {
            this.FirstName = first;
            this.LastName = last;
            this.ChangeColor = false;
        }
        public bool ChangeTheColor()
        {
            return (this.ChangeColor=true); 
        }
        public void Initial()
        {
            this.ChangeColor = false; 
        }
    }
      
}
