﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitInStock=5,ProductName="Kalem",UnitPrice=35 };

            //PascalCase   //camelCase
            //Case sensitive
            PrdocutManager prdocutManager = new PrdocutManager(); //sol taraf stack //sağ taraf heap
            prdocutManager.Add(product1);

           //int,doubel,bool.. değer tip
           //diziler,class,abstract class,interface.. referans tip
           //ref out 



        }
    }
}
