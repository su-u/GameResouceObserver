﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameResouceObserver
{
    class Writter
    {
        static public void Write(String filename, String text)
        {
            try
            {
                // appendをtrueにすると，既存のファイルに追記
                // falseにすると，ファイルを新規作成する
                var append = true;
                var utf8_encoding = new System.Text.UTF8Encoding(false);
                using (var sw = new System.IO.StreamWriter(filename, append, System.Text.Encoding.UTF8))
                {
                    sw.Write($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff")},{text}");
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
