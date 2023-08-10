using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimCard sim = new SimCard()
            {
                CarrierName = "Bakcell",
                Number = "+994555728100",
                Balance = 3.550m,
                Tariff = 5


            };
            sim.IncreaseBalance(0);
            Console.WriteLine(sim.Balance);

            //sim.Call();
            //Console.WriteLine(sim.Balance);


        }



    }
    public class SimCard
    {
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public int Tariff { get; set; }


        public void IncreaseBalance(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Medaxil elemek ucun mebleg 0 dan boyuk olmalidir");
            }
            else
            {
                Balance += amount;

            }



        }
        public void Call()
        {
            if (Balance < Tariff)
            {
                Console.WriteLine("Zeng ucun balansinizda kifayet qeder vesait yoxdur ");

            }
            else
            {
                Balance -= Tariff;

            }

        }




    }
}
