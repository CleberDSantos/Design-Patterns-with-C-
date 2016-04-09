using System;

namespace Proxy.Resolvido
{
    public interface ICar
    {
        void DriveCar();
    }


    /// <summary>
    /// Objeto real
    /// </summary>
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("carro foi conduzido!");
        }
    }

    /// <summary>
    /// Objeto Proxy
    /// </summary>
    public class ProxyCar : ICar
    {
        private const int MinAge = 18;
        private readonly ICar _realCar;
        private readonly Driver _driver;

        public ProxyCar(Driver driver)
        {
            this._driver = driver;
            _realCar = new Car();
        }

        public void DriveCar()
        {
            if (_driver.Age <= MinAge)
            {
                Console.WriteLine("Desculpe, o motorista é jovem demais para dirigir.");
            }
            else
            {
                _realCar.DriveCar();
            }
        }
    }

    public class Driver
    {
        public int Age { get; set; }

        public Driver(int age)
        {
            this.Age = age;
        }
    }
}
