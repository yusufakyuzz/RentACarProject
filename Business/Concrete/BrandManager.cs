using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public void Add(Brand brand)
        {
            Console.WriteLine("Marka eklendi");
        }
    }
}
