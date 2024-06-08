using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Растение
    {
        public string Сорт { get; set; }
    }

    public class Яблоня : Растение
    {
    }

    public class Смородина : Растение
    {
    }

    public class Сад
    {
        public string Садовник { get; set; }
        public List<Растение> Растения { get; set; }

        public Сад()
        {
            Растения = new List<Растение>();
        }

        public void Посадить(Растение растение)
        {
            if  (растение==null)
            {
                throw new ArgumentNullException("ошибка");
                
            }
            Растения.Add(растение);
            Console.WriteLine($"Садовник {Садовник} посадил дерево {растение.Сорт}");
        }
    }
}
