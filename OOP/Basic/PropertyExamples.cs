using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic
{
    public class PropertyExamples
    {
        private int width; 
        internal int _Width
        {
            get
            {
                return this.width;

            }
            set
            {
                this.width = value; 
            }
        }

        private int height;

        internal int Height { get; set;  }
        //internal int _Height { 
        //    get { return height; } 
        //    set { height = value; } 
        //}
        //internal int _Height { get { return this.height; } set { this.height = value; } }

    }
}
