using System;
namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="arr">Numbers to sort.</param>
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            if(arr is null)
            {
                throw new ArgumentNullException("Argument should be not null");
            }
            else
            {

                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                        {
                            // swap temp and arr[i]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
            }
        }

        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/> 
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products is null || predicate is null)
            {
                throw new ArgumentNullException();
            }
            else
            {

                
                for (int i = 0; i < products.Length; i++)
                {
                    Product prod = Array.Find(products, predicate);
                    var product = products[i];
                    if (prod==product)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        /*private static bool Find(Product[] prod1, Product prod2)
        {
            for (int i = 0; i < prod1.Length; i++)
            {
                if(prod1[i].Name == prod2.Name && prod1[i].Price == prod2.Price)
                {
                    return true;
                }
            }
            return false;
        }*/
    }
}
