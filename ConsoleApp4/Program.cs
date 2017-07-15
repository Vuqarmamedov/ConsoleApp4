using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Home Ev = new Home();
            Ev.eniUzunu = new int[2] { 3600, 2500 };
            Ev.rooms =  4;
            
            
            Ev.pencere = new Window[3] {
                new Window
                {
                    eniUzunu = new int [2] {120,220},
                    lays = 25,
                    plastik = true,
                    glassType = "temperli",
                    shushe=new Glass
                    {
                        qalinliqi= 30,
                        marka = "bomba marka",
                        reng = "ag"
                    }
                },
                new Window
                {
                    eniUzunu =new int [2] {130,240},
                    lays=10,
                    plastik = true,
                    glassType = "temperli",
                },
                new Window
                {
                    eniUzunu =new int [2] {130,240},
                    lays=10,
                    plastik = false,
                    glassType = "temperli",
                }
            };

            Ev.qapi = new Door[2] {
                new Door
                {
                    eniUzunu =new int [2] {1200,2200},
                    iron = false,
                    openClose = false
                    
                },
                new Door
                {
                    eniUzunu =new int [2] {1300,2400},
                    iron = true,
                    openClose= false
                }
            };
            Console.WriteLine("netice" + Ev.enterOrNoEnter());

        }
    }
}
