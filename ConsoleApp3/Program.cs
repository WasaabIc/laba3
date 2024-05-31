using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Сад сад = new Сад { Садовник = "Иван" };
            Яблоня яблоня = new Яблоня { Сорт = "Антоновка" };
            Смородина смородина = new Смородина { Сорт = "Черная" };

            сад.Посадить(яблоня);
            сад.Посадить(смородина);
        }
    }
}
