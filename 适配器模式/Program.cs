using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类适配器
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

        /// <summary>
        /// 输入（电流）
        /// </summary>
        public void Input()
        {
            Console.WriteLine(_msg + " --> 18v。");
        }
    }
    interface IOutput
    {
        /// <summary>
        /// 输出（电流）
        /// </summary>
        void Output();
    }
    /// <summary>
    /// 适配器
    /// </summary>
    class Adapter : Portal, IOutput
    {
        public Adapter(string msg) : base(msg)
        {
        }

        public void Output()
        {
            Input();
        }
    }
    class Client
    {
        static void Main(string[] args)
        {
            IOutput adapter = new Adapter("220v");
            adapter.Output();
            Console.Read();
        }
    }
}
