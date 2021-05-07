﻿using FactoryMethod.Factories;
using FactoryMethod.Factories.TargetShooting;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //Transport transport = null; 

            //if(args.Length > 0 && args[0] == "--uber")
            //{
            //    transport = new CarTransport();

            //}else if (args.Length > 0 && args[0] == "--log")
            //{
            //    transport = new MotorcycleTransport();
            //}
            //else if (args.Length > 0 && args[0] == "--eats")
            //{
            //    transport = new BicycleTransport();
            //}
            //else
            //{
            //    Console.WriteLine("Selecione o tipo de serviço.");
            //}

            //if (transport != null)
            //{
            //    transport.StartTransport();
            //}

            TargetShooting targetShooting = null;

            if (args.Length > 0 && args[0] == "--pistol")
            {
                targetShooting = new PistolTargetShooting();

            }
            else if (args.Length > 0 && args[0] == "--machinegun")
            {
                targetShooting = new MachineGunTargetShooting();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço.");
            }

            if (targetShooting != null)
            {
                targetShooting.StartTargetShooting();
            }


            Console.ReadLine();
        }
    }
}
