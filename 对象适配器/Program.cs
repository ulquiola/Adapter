using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象适配器
{
    /// <summary>
    /// 客户希望的类
    /// 输出电压
    /// 5V
    /// </summary>
    class Target
    {
        public virtual void Output()
        {
            Console.WriteLine("输出电压-----5V");
        }
    }
    /// <summary>
    /// 已经拥有的类
    /// 需要适配的类
    /// </summary>
    class Adaptee
    {
        public void Input()
        {
            Console.WriteLine("输入电压-----220V");
        }

    }
    /// <summary>
    /// 适配器
    /// 将电压220V转化为5V
    /// </summary>
    class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();//建立私有Adaptee对象
        /// <summary>
        /// 覆写方法
        /// 将220V输入转化为5V输出
        /// 适配器提供5V的输出，但本质还是调用220V的输入方法
        /// </summary>
        public override void Output()
        {
            adaptee.Input();
        }
    }
    /// <summary>
    /// 客户端
    /// 客户期待---手机通过充电头充电
    /// 期待结果----输出电压为5V
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.Output();
            Console.Read();
        }
    }
}
