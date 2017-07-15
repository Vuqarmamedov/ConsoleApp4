using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Home :ISize,IgetInfo
    {
        public int [] eniUzunu { get; set; }
        public int rooms { get; set; }
        public Window []  pencere { get; set; }
        public Door [] qapi { get; set; }

        public bool enterOrNoEnter()
        {
            for (int i = 0; i < qapi.Length; i++)
            {
                if (qapi[i].openClose)
                {

                    return true;
                    
                }
            }
            return false;
        }
    }


    public class Door :ISize,IgetInfo
    {
       public int [] eniUzunu { get; set; }
       public bool iron { get; set; }
        public bool openClose { get; set; }
    }

    public class Window :ISize,IgetInfo
    {
       public int [] eniUzunu { get; set; }
       public bool plastik { get; set; }
       public int lays { get; set; }
       public string glassType { get; set; }

        public Glass shushe { get; set; }
        
    }
    public class Glass 
    {
        public int qalinliqi { get; set; }
        public string marka { get; set; }
        public string reng { get; set; }

    }

      public interface ISize
    {
        int[] eniUzunu { get; set; }
    }

    interface IgetInfo
    {
        
    }
}
