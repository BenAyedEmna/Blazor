using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwitchColors
{
    public class Cellule
    {
        public colors Color { get; set; }
        public Cellule(colors cellcolor)
        {
            this.Color = cellcolor; 
        }
        public void ChangeTheColor()
        {
            if(this.Color==colors.black)
            {
                this.Color = colors.white; 
            }
            else
            {
                this.Color = colors.black; 
            }
        }
    }
    public enum colors
    {
        black,
        white
    }
}

