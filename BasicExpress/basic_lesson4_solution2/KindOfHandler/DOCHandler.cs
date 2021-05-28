using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson4_solution2.KindOfHandler
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Создан DOC");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменение DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение DOC");
        }
        public override void Show()
        {
            Console.WriteLine("\nDOC:");
            this.Open();
            this.Create();
            this.Chenge();
            this.Save();
        }
    }
}
