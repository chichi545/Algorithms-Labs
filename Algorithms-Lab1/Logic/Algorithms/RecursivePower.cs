﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Algorithms
{
    public class RecursivePower : IPowerRaiser
    {
        public void RaiseToPower(int[] array, int power)
        {
            if (power < 0) throw new ArgumentException("Степень должна быть неотрицательным числом");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Power(array[i], power, out _);
            }
        }

        public static int Power(int baseValue, int power, out int steps)
        {
            steps = 0;
            int result = 1;

            while (power > 0)
            {
                steps++;

                if (power % 2 == 1)
                {
                    result *= baseValue;
                }

                baseValue *= baseValue;
                power /= 2;
            }

            return result;
        }

    }
}
