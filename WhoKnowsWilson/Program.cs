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
            Console.WriteLine("����� ���������� � ����: \"��� ����� �������?\"");
            Console.WriteLine("������� ����:");
            Console.WriteLine("������ ������������ �������� �� ������, ������ ���� �� ������� ������������ ���������� ������.");
            Console.WriteLine("�� ����� ����������� ������ ������ ����������� 1000$, � �� ������������ -1000$");
            Console.WriteLine("� ���� 6 ��������. ������ ���� ������� ����� ����������. ����� ������� � 0$");
            Console.WriteLine("����� �� ����� ������� ����� ������ ����");
            Console.ReadKey();
            try
            {
                return ReadAllLines("bank.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("����������� ������, ���� �� ����� ���� ����������. ���������: " + ex);
                throw;
            }
        }
        static void Main(string[] args)
        {
            var ques = Init();
        }
    }
}