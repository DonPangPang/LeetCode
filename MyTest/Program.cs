using System;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(5));
        }

        public static string CountAndSay(int n)
        {
            string result = "";
            string temp = "";

            for(int i = 1; i <= n; i++){
                if(i == 1){
                    temp = "1";
                }
                result = temp;
                temp = "";
                int flag = 0;
                int cursor = 0;
                while(cursor <= result.Length){
                    if(cursor == result.Length || result[cursor] != result[flag]){
                        temp += (cursor-flag).ToString()+result[flag];
                        flag = cursor;
                    }
                    cursor++;
                }
            }

            return result;
        }
    }
}
