﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {/* Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:

            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms. */

            Console.WriteLine("Hello World!");

			List<int> list = new List<int>()
			{
			1, 2, 3
			};

			for (var i = 0; i < 29; i++)
			{
				int z = list[^1] + list[^2];
				list.Add(z);
			}

			List<int> evenList = new List<int>();

			foreach (var item in list)
			{
				if (item % 2 == 0)

					evenList.Add(item);

			}

				int finalSum = evenList.Sum();

                Console.WriteLine(finalSum);

            
		}
    }
}
