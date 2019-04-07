using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象适配器
{
    /// <summary>
    /// 入口
    /// </summary>
    class Portal
    {
        private readonly string _msg;

        public Portal(string msg)
        {
            _msg = msg;
        }

        public void Input()
        {
            Console.WriteLine(_msg + " --> 18v");
        }
    }
    class Adapter : Export
    {
        private readonly Portal _portal;

        public Adapter(string msg)
        {
            _portal = new Portal(msg);
        }

        public override void Output()
        {
            _portal.Input();
        }
    }
    /// <summary>
    /// 出口
    /// </summary>
    abstract class Export
    {
        public abstract void Output();
    }
    class Client
    {
        static void Main(string[] args)
        {
            
        }
    }
}
