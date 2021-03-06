﻿namespace _10观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new Cat();

            var jerry = new Mouse("Jerry");
            var mickey = new Mouse("Mickey");
            var xg = new Human();

            tom.Attach(jerry);
            tom.Attach(mickey);
            tom.Attach(xg);

            tom.Miao();

            /*
             * 观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题
             * 对象。这个主题对象在线状态发生变化时，会通知所有观察者对象，使它们能够自
             * 动更新自己。
             * 
             * 观察者模式的动机是什么？
             *     将一个系统分割成一系列相互协作的类有一个很不好的副作用，那就是需要维
             *     护相关对象的一致性。我们不希望为了维持一致性而使各类紧密耦合，这样会
             *     给维护、扩展、重用带来很不便。
             *     
             *     当一个对象的改变需要同事改变其它对象，而且它不知道具体有多少对象有待
             *     改变时，应该考虑适用观察者模式。
             *     
             *     一个抽象模型有两个方面，其中一方面依赖于另一方面，这时用观察者模式可
             *     以将这两者防装在独立的对象中使它们各自独立地改变和复用。
             *     
             *     观察者模式所做的工作其实就是在接触耦合。让耦合地双方都依赖于抽象，而
             *     不是依赖于具体。从而使得个字变化都不会影响到另一边地变化。
             */
        }
    }
}
