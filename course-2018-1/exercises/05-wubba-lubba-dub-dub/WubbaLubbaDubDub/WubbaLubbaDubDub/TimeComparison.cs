using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;

namespace WubbaLubbaDubDub
{
    public class TimeComparison
    {
        private static void Main()
        {
            const int n = (int)1e5;
            String stringJoin = "";
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < n; ++i)
                string.Join("a", stringJoin);

            TimeSpan ts1 = watch.Elapsed;
            double strJoinTime = ts1.TotalMilliseconds;

            StringBuilder stringBuilder = new StringBuilder("");
            watch.Restart();

            for (int i = 0; i < n; ++i)
                stringBuilder.Append("a");

            TimeSpan ts2 = watch.Elapsed;
            double strBuilderTime = ts2.TotalMilliseconds;

            String strConcat = "";
            watch.Restart();

            for (int i = 0; i < n; ++i)
                strConcat = strConcat + "a";
            
            TimeSpan ts3 = watch.Elapsed;
            double strConcatTime = ts3.TotalMilliseconds;

            Console.WriteLine("Time for string.Join: " + strJoinTime + "ms\n" + 
                              "Time for StringBuilder: " + strBuilderTime + "ms\n" + 
                              "Time for Concat: " + strConcatTime + "ms\n");

        }
    }
}