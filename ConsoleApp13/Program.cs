using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя тип документа
            Console.WriteLine("Введите тип документа (xml, txt, doc):");
            string documentType = Console.ReadLine().ToLower();

            AbstractHandler handler = null;

            // Определяем обработчик в зависимости от типа документа
            switch (documentType)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Неверный тип документа. Используется обработчик TXT по умолчанию.");
                    handler = new TXTHandler();
                    break;
            }

            // Выполняем действия с документом
            handler.Open();
            handler.Create();
            handler.Chenge();
            handler.Save();

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
