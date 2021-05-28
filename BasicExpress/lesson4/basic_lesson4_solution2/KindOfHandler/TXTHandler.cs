using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson4_solution2.KindOfHandler
{
    class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Создан TXT");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменение TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение TXT");
        }
        public override void Show()
        {
            Console.WriteLine("\nTXT:");
            this.Open();
            this.Create();
            this.Chenge();
            this.Save();
        }
    }
}
