using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки.
             * Например, в строке ([]{})[] скобки расставлены корректно,а в строке ([]] — нет. Указание: задача решается однократным проходом по символам
             * заданной строки слева направо; для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка
             * в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.
             * */
            Console.WriteLine("Введите строку, содержащую скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.");
            string str = Convert.ToString(Console.ReadLine());

            if (Check(str))
            {
                Console.WriteLine("Cкобки расставлены корректно.");
            }
            else
            {
                Console.WriteLine("Cкобки расставлены НЕ корректно.");
            }
           
            Console.ReadKey();
        }

        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                {'(',')'},
                {'[',']'},
                {'{','}'}
            };


            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    stack.Push(dic[c]);
                }
                else if (dic.ContainsValue(c))
                {

                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }

                }
            }
            if (stack.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
