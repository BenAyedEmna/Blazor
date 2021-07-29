using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwitchColors
{
    public class Grid
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public List<List<Cellule>> grid { get; set; }
        public Grid(int nbreColumn, int nbreRow)
        {
            this.Column = nbreColumn;
            this.Row = nbreRow; 
        }
        public void CreateGrid()
        {
            this.grid = new List<List<Cellule>>(); 
            for(var i=0;i<this.Column;i++)
            {
                List<Cellule> ListCell = new List<Cellule>();
                Cellule cell; 
                for(var j=0;j<(this.Row)/2;j++)
                {
                    if (i%2==0)
                    {
                        cell = new Cellule(colors.black);
                        ListCell.Add(cell);
                        cell = new Cellule(colors.white);
                        ListCell.Add(cell);
                    }
                    else
                    {
                        cell = new Cellule(colors.white);
                        ListCell.Add(cell);
                        cell = new Cellule(colors.black);
                        ListCell.Add(cell);
                    }            
                }
                grid.Add(ListCell);
            }
        }

        public void ChangingColors()
        {
            foreach (var CellList in this.grid)
            {
                foreach (var cell in CellList)
                {
                    cell.ChangeTheColor();
                }
            }
        }
    }
    
}
