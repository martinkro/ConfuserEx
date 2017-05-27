using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObfuscarTestLib;

namespace ObfuscarTestExe
{
    class Program
    {
        public static readonly string version = "1.0.2";
        static void Main(string[] args)
        {
            ShowVersion();
            TestSkeletonAnimation();
        }

        static void ShowVersion()
        {
            Console.WriteLine("Obfuscar Test Version:{0}", version);
        }

        static void TestSkeletonAnimation()
        {
            SkeletonAnimation sa = new SkeletonAnimation();
            sa.LateUpdate();
            Console.WriteLine("ToString:{0}", sa.ToString());
        }
    }
}
