using System;

namespace SD725
{
    class MainApp

    {
        static void Main()
        {
            // An array of creators

            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created '{0}' of Type {1}",product.productName,  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }

    abstract class Product
    {
        public string productName;
        public string Description;
    }


    class ClothingProduct : Product
    {
        public string Size;

        public ClothingProduct(string inProductName)
        {
            productName = inProductName;
        }
    }


    class FoodProduct : Product
    {
        public DateTime expirationDate;

        public FoodProduct(string inProductName)
        {
            productName = inProductName;
        }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ClothingProduct("Breezy Summer Shirt");
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new FoodProduct("Crate of Bananas");
        }
    }
}