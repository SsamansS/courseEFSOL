using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson4_solution2.KindOfHandler
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML");
        }
        public override void Create()
        {
            Console.WriteLine("Создан XML");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменение XML");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение XML");
        }    
        public override void Show()
        {
            Console.WriteLine("\nXML:");
            this.Open();
            this.Create();
            this.Chenge();
            this.Save();
        }
    }
}
