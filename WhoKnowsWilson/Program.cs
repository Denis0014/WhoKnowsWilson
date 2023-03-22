using System;
using System.IO;
using System.Text;
using static System.IO.File;

namespace Game
{
    internal class Program
    {
        static string[] Init()
        {
            Console.WriteLine("Добро пожаловать в игру: \"Кто знает Вилсона?\"");
            Console.WriteLine("Правила игры:");
            Console.WriteLine("Игроку предлагается ответить на вопрос, выбрав один из четерых предложенных вырианотов ответа.");
            Console.WriteLine("За выбор правильного ответа играку начислиться 1000$, а за неправильный -1000$");
            Console.WriteLine("В игре 6 вопросов. Только один вариант ответ правильный. Игрок начиает с 0$");
            Console.WriteLine("Нажми на любую клавиху чтобы начать игру");
            Console.ReadKey();
            try
            {
                return ReadAllLines("bank.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Критическая ошибка, игра не может быть продолжена. Сообщение: " + ex);
                throw;
            }
        }
        static void Main(string[] args)
        {
            var ques = Init();
        }
    }
}