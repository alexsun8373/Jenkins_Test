using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMath;
using System.Text;
using System.IO;

namespace BasicMathsApp
{
    class Program
    {
        BasicMaths BM;
        static void Main(string[] args)
        {
            BasicMaths bm = new BasicMaths();
            string strWriteFilePath = @"WriteLog.txt";
            

            for (int i = 0; i < 10; i++) {
                StreamWriter swWriteFile = new StreamWriter(strWriteFilePath, true);
                //StreamWriter swWriteFile = File.CreateText(strWriteFilePath);
                double res1 = bm.Add(i, 1);
                double res2 = bm.Substract(i, 1);
                double res3 = bm.divide(i, 2);
                double res4 = bm.Multiply(i, 2);
                Console.WriteLine(res1.ToString() + ' ' + res2.ToString() + ' ' + res3.ToString() + ' ' + res4.ToString() + ' ');
                swWriteFile.WriteLine(res1.ToString() + ' ' + res2.ToString() + ' ' + res3.ToString() + ' ' + res4.ToString() + ' '); //写入读取的每行数据
                //Console.WriteLine(res2.ToString() + ' ');
                //Console.WriteLine(res3.ToString() + ' ');
                //Console.WriteLine(res4.ToString() + ' ' + '\n');
                System.Threading.Thread.Sleep(2000);

                swWriteFile.Close();
            }
           
        }
    }
}
//SVN Trigger