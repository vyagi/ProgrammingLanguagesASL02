using System;
using System.Threading;
using System.Threading.Tasks;

namespace MoreAdvancedFeatures
{
    public class Shape
    {
    }

    public interface IWindowControl
    {
        void Draw();
        void Move();
        void Click();

        int Width { get; }
        int Age { set; }
    }

    public interface IMovable
    {
        void Move(int x, int y);

    }

    public class Triangle : Shape, IWindowControl, IMovable
    {
        public void Draw()
        {
        }

        public void Move()
        {
        }

        public void Click()
        {
        }

        public int Width { get; }
        public int Age { get; set; }

        public void Move(int x, int y)
        {
        }
    }





    public class Lift
    {
        public int CurrentFloor { get; private set; }

        public delegate void FloorReachedDelegate();

        public event FloorReachedDelegate FloorReached;

        public void Move(int targetFloor)
        {
            Thread.Sleep(1000 * Math.Abs(CurrentFloor - targetFloor));
            
            FloorReached?.Invoke();
            
            CurrentFloor = targetFloor;
        }
    }
    
    public class FunctionChartDrawer
    {
        private readonly FunctionDelegate _function;

        public delegate float FunctionDelegate(float arg);
        public FunctionChartDrawer(FunctionDelegate function)
        {
            _function = function;
        }
        public void Draw()
        {
            Console.WriteLine("Use your imagination to see the actual chart");
            Console.WriteLine("But I am able to get values");
            Console.WriteLine($"For x = -2, value is {_function(-2)}");
            Console.WriteLine($"For x = 0, value is {_function(0)}");
            Console.WriteLine($"For x = 1, value is {_function(1)}");
        }
    }

    public class BetterFunctionChartDrawer
    {
        private readonly Func<float, float> _function;

        public BetterFunctionChartDrawer(Func<float, float> function)
        {
            _function = function;
        }
        public void Draw()
        {
            Console.WriteLine("I am better : Use your imagination to see the actual chart");
            Console.WriteLine("But I am able to get values");
            Console.WriteLine($"For x = -2, value is {_function(-2)}");
            Console.WriteLine($"For x = 0, value is {_function(0)}");
            Console.WriteLine($"For x = 1, value is {_function(1)}");
        }
    }

    class Program
    {
        static float LinearExample(float x) => 2 * x - 1;
        static float CubicExample(float x) => x * x * x + 1;

        static void LiftCameHandler()
        {
            Console.WriteLine("Hooray");
        }

        static void Main(string[] args)
        {
            


            // var l1 = new Lift();
            // l1.FloorReached += LiftCameHandler;
            // l1.FloorReached += () => Console.WriteLine("Lambda hooray");
            //
            // Console.WriteLine(l1.CurrentFloor);
            // l1.Move(2);
            //
            // l1.FloorReached -= LiftCameHandler;
            // l1.Move(4);

            //**************************************************************************

            // var fcd = new FunctionChartDrawer(LinearExample);
            // fcd.Draw();
            //
            // fcd = new FunctionChartDrawer(CubicExample);
            // fcd.Draw();
            //
            // fcd = new FunctionChartDrawer(x=>x*x);
            // fcd.Draw();
            //
            // var fcd1 = new BetterFunctionChartDrawer(LinearExample);
            // fcd1.Draw();
            //
            // fcd1 = new BetterFunctionChartDrawer(CubicExample);
            // fcd1.Draw();
            //
            // fcd1 = new BetterFunctionChartDrawer(x => x * x);
            // fcd1.Draw();

            //**************************************************************************

            // Console.WriteLine("1. Now I will execute long running method");
            // LongRunningMethod();
            // Console.WriteLine("4. Now I can end");
            // Console.ReadKey();
        }

        public static async Task LongRunningMethod()
        {
            Console.WriteLine("2. Starting long running task");
            await Task.Run(() => Task.Delay(3000));
            Console.WriteLine("3. Finished !!!");
        }
    }
}
