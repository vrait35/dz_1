using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1.vvedenie_v_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task();
        }
        static private void Task()
        {
            Console.WriteLine("Отгадайте загадку, и напишите ответ");
            Console.WriteLine("Один глаз, один рог, но не носорог?");            
            string reply_shifr = "теавыдялгыв алгу аз-зи аворок";            
            string reply=function_reverce_str(reply_shifr);
            //Console.WriteLine("otvet:"+reply+")");
            string reply_user=null;
            while (reply_user!=reply || reply_user!=reply)
            {
                reply_user= Console.ReadLine();
                if(reply_user != reply)
                Console.WriteLine("Не правильно! ");
            }
            Console.WriteLine("Угадали!");
        }
        static public string function_reverce_str(string str)
        {
            char[] buff = str.ToCharArray();
            Array.Reverse(buff);
            return new string(buff);
        }
    }
}
