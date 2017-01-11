﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceleratorMagnets_InheritanceExample_
{
    public class Magnet
    {
        // base class constructor
        public Magnet(float B, Material material, int GLenght)
        {
            MagneticFieldStrenght = B;
            this.material = material;
            GeometricalLenght = GLenght;
        }

        // main fields
        protected float MagneticFieldStrenght;
        protected int GeometricalLenght;
        protected Material material;
        private float MagneticLenght { get { return GeometricalLenght * 0.9f; } }

        // method for printing core information about magnet
        public void GetInformation()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Magnetic lenght is equal to  {0}m", MagneticLenght);
            switch (material)
            {
                case Material.Electromagnets:
                    Console.WriteLine("Cooling system needed");
                    break;
                case Material.SCMagnets:
                    Console.WriteLine("Cooling and super cunducting systems needed");
                    break;
                case Material.Ferromagnets:
                    Console.WriteLine("No need of cooling system and no need of voltage");
                    break;
                default:
                    break;
            }
        }
    }
}
