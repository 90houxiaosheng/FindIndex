using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmc
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 10, 22, 38, 51 };
            //int[] arr2 = new int[6];
            //Console.WriteLine("请输入要插入bai的数字");
            //int i = int.Parse(Console.ReadLine());
            //int pos = 0;
            //for (int j = arr.Length - 1; j >= 0; j--)//查找插入位置du
            //{
            //    if (i > arr[j])
            //    {
            //        pos = j + 1; break;
            //    }
            //}
            //arr2[pos] = i;
            //for (int j = 0; j < pos; j++) arr2[j] = arr[j];//或Array.Copy(arr, 0, arr2, 0, pos);
            //for (int j = pos; j < arr.Length; j++) arr2[j + 1] = arr[j];//或Array.Copy(arr, pos, arr2, pos+1, arr.Length-pos);
            //Console.WriteLine(string.Join(",", arr2));
            //Console.ReadKey();
            List<int> list = new List<int> { 1, 10, 22, 38, 51 };
            Console.WriteLine("请输入要插入的数字");
            int i = int.Parse(Console.ReadLine());
            int pos = list.FindIndex(x => x >= i);
            if (pos == -1) pos = list.Count;
            list.Insert(pos, i);
            Console.WriteLine(string.Join(",", list));
            Console.ReadKey();
        }

    }
}
