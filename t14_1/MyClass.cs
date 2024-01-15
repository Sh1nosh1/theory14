using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t14_1
{
    /// <summary>
    /// Класс
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Открвтое поле
        /// </summary>
        public static int number;
        /// <summary>
        /// price
        /// </summary>
        public static int price;
        /// <summary>
        /// a
        /// </summary>
        public const int a = 125;
        /// <summary>
        /// 1. Стат. конструкт. выполн только 1 раз,вне зависимости от созданных объектов.
        /// 2. Стат. констр. не имеет модификаторов доступа.
        /// 3. СК никогда не имеет параметров.
        /// 4. СК нельзя вызвать вручную, он вызывается автоматически при создании 1-го объекта.
        /// 5. В СК, как и в стат. методе, нельзя использовать this для ссылки на текущ. объект, и можно обращаться только к статич. членам класса.
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("Стат. конструктор");
            int number = 1;
        }
        /// <summary>
        /// Не статич.
        /// </summary>
        public MyClass()
        {
            Console.WriteLine("НЕстат. конструктор");
            int number = 2;
        }
        /// <summary>
        /// Вывод поля number and price
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{number}\n{price}\n");
        }
        
    }
}
