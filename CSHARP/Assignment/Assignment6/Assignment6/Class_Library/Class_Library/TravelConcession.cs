using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
        public class TravelConcession
        {
            
            private const decimal TotalFare = 500;
            public static string CalculateConcession(int age)
            {
                if (age <= 5)
                {
                    return "Little Champs - Free Ticket";
                }
                else if (age > 60)
                {
                    decimal concessionAmount = TotalFare * 0.3m;
                    decimal discountedFare = TotalFare - concessionAmount;
                    return $"Senior Citizen - Discounted Fare: {discountedFare:C}";
                }
                else
                {
                    return $"Ticket Booked - Fare: {TotalFare:C}";
                }
            }
        }
    }
