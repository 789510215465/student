using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            // 身高資料的陣列
            //String[] names = { "Type-001", "Type-002", "Type-003", "Type-004", "Type-005", "Type-006" };
            //int[] heights = { 160, 169, 174 ,178, 180, 182 };

            // 隨機產生序號
            // Random rand = new Random();        
            //int r = rand.Next( 0 , heights.Length );

            // 顯示
            // for (int i = 0; i < names.Length; i++)
            // {
            // Console.WriteLine( names[i] + " " + heights[i]); 
            //Console.WriteLine();
            // }
            // 停止螢幕

            // 放在矩陣內的資料
            string[] names = { "實驗品一 " };  // 名字 
            string[] zodiac = { "博愛座" };    // 星座
            int[] heights = { 174 };           // 身高
            string[] sns = { " A9487 " };      // 學號

            // 讓使用者輸入學號
            Console.Write("請輸入學號 : ");
            string sn = Console.ReadLine();    // 將輸入的東東丟進sn
            int herN = -1;                     // 宣告一個變數herN

            // 利用For迴圈找出該學號的資料
            for(int i = 0 ; i < heights.Length ; i++)
                {
                if(sn == sns[i])               // 如果sn裡的東東等同於學號矩陣(第?號)裡的西西
                {
                    herN = i;                  // (第?號)
                }
                }


            Console.WriteLine(" 學號 : " + names[herN]);
            Console.WriteLine(" 星座 : " + zodiac[herN]);
            Console.WriteLine(" 身高 : " + heights[herN]);
            Console.ReadKey();
        }
    }
}
