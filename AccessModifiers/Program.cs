using AccessModifiers.Models;
using System;
using System.Reflection;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            #region Public - class and all class members
            //Car car = new Car();
            //car.Brand = "Ford";
            //Console.WriteLine(car.Brand);
            //car.Run();
            #endregion
            #region Private - all class members

            #endregion
            #region Protected - all class members

            #endregion

            #region Property
            Car car = new Car();
            //car.SetSpeed(200);
            //Console.WriteLine(car.GetSpeed());
            //car.MaxSpeed = 200;
            //Console.WriteLine(car.MaxSpeed);
            //        var prop = car.GetType().GetField("_maxSpeed", System.Reflection.BindingFlags.NonPublic
            //|            System.Reflection.BindingFlags.Instance);
            //        prop.SetValue(car, -200);
            //        Console.WriteLine(car.MaxSpeed);
            #endregion

            #region Readonly
            Car car1 = new Car();
            Console.WriteLine(car1.Brand);
            #endregion
            #endregion

        }
    }
}
