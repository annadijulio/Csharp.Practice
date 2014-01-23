using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Jayway.Csharp.Practice.Extensions;

namespace Jayway.Csharp.Practice
{
    public class Lab
    {

        public class Orange : IFruit
        {
            private readonly ICanEat _eater;

            public Orange(ICanEat eater)
            {
                _eater = eater;
            }

            public void Eat()
            {
                _eater.Eat();
            }
        }

        public interface IFruit
        {
            void Eat();
        }

        public abstract class Fruit
        {
            public abstract void Eat();
        }


        public void Collections()
        {
            var list = new List<int> {1, 2, 3} as IEnumerable<int>;


            // C# 2.0 Way
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //Same thing, different syntax, C# 3.5:
            list.ForEach(x=>Console.WriteLine(x));
            list.ForEach(Console.WriteLine);

            var overTwo = list.Any(x => x > 2);

            //var f = AddTwoFactory(Add);
            //f(2);
            //f(3);

            //var d = new Dispatcher();
            //d.Register<DoMagicCommand>(() => Console.WriteLine("Magic!"));
            //d.Handle(new DoMagicCommand());
        }

        public interface ICommand
        {
            int AggregateId { get; set; } 
        }

        private class DoMagicCommand : ICommand
        {
            public int AggregateId { get; set; }
        }

        public class Dispatcher
        {
            private readonly IDictionary<Type, Action> _routes = new Dictionary<Type, Action>(); 

            public void Register<T>(Action action)
            {
                _routes.Add(typeof(T), action);
            }

            public void Handle(ICommand command)
            {
                _routes[command.GetType()]();
            }
        }


        public Func<int, int> AddTwoFactory(Func<int,int,int> f)
        {

            Func<int, int> addToTwo = i => Add(2, i);
            return addToTwo;
        }

        public int Add(int i1, int i2)
        {
            return i1 + i2;
        }

    }

    public interface ICanEat
    {
        void Eat();
    }
}
