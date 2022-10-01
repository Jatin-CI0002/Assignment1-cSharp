using System;
using System.Xml.Schema;

namespace Assignments
{
    public class Centrifuge
    {
        private static List<int> FindPrimeFactors(int n)
        {
            List<int> primeFactors = new List<int>();

            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            // Print all prime numbers
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    primeFactors.Add(i);
            }

            return primeFactors;
        }
        public static bool BalanceTheConfiguration(int total, int filled)
        {
            bool isSum = (isSumOfFactors(total, filled));
            return (total > 1 && (total == filled || isSum));
        }

        private static bool isSumOfFactors(int total, int filled) {
            List<int> primeFactors = FindPrimeFactors(total);

            int sum = 0;
            foreach (int factor in primeFactors)
            {
                sum += factor;
                if (sum == filled || sum == total - filled)
                    return true;
                else
                    continue;
            }
            return false;
        }
    }
    }

