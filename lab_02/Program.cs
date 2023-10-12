using System;
using System.Linq;


namespace lab_02
{
    internal class Program
    {
        class Phone
        {
            private static int objectCount = 0;
            private readonly int ID;
            private const decimal localCallRate = 0.1m;
            private const decimal longDistanceCallRate = 0.5m;

            public string Surname { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string CreditCardNumber { get; set; }
            public decimal Debit { get; set; }
            public decimal Credit { get; set; }
            public int LocalCallMinutes { get; set; }
            public int LongDistanceCallMinutes { get; set; }

            public Phone(string surname, string firstName, string lastName, 
                string address, string creditCardNumber, decimal debit = 0, 
                decimal credit = 0, int localCallMinutes = 0 , int longDistanceCallMinutes = 0) 
            {
                Surname = surname;
                FirstName = firstName;
                LastName = lastName;
                Address = address;
                CreditCardNumber = creditCardNumber;
                Debit = debit;
                Credit = credit;
                LocalCallMinutes = localCallMinutes;
                LongDistanceCallMinutes = longDistanceCallMinutes;

                ID = GetHashCode();
                objectCount++;
            }

            static Phone()
            {
                objectCount = 0;
            }

            public decimal CalcBalance()
            {
                decimal totCost = (LocalCallMinutes * localCallRate) + (LongDistanceCallMinutes * longDistanceCallRate);
                return Debit - totCost;
            }

            public static void DisplayClassInfo()
            {
                Console.WriteLine("Информация :");
                Console.WriteLine($"Кол-во созданных объектов:{objectCount}");
            }

            public static bool operator ==(Phone phone1, Phone phone2)
            {
                if (ReferenceEquals(phone1, null) && ReferenceEquals(phone2, null))
                    return true;
                if (ReferenceEquals(phone1, null) || ReferenceEquals(phone2, null))
                    return false;
                return phone1.ID == phone2.ID;
            }

            public static bool operator != (Phone phone1, Phone phone2)
            {
                return !(phone1 == phone2);
            }

            public override bool Equals(object obj)
            {
                if (obj is Phone otherPhone)
                    return this.ID == otherPhone.ID;
                return false;
            }

            public override int GetHashCode()
            {
                return ID;
            }

            public override string ToString()
            {
                return $"{Surname} {FirstName} {LastName} (ID: {ID})";
            }
        }
        static void Main(string[] args)
        {
            Phone.DisplayClassInfo();

            Phone[] phones = new Phone[]
            {
            new Phone("Smith", "John", "Doe", "123 Main St", "1234-5678-9012-3456", 100, 50, 30, 20),
            new Phone("Johnson", "Alice", "Smith", "456 Elm St", "9876-5432-1234-5678", 200, 0, 40, 10),
            new Phone("Brown", "Robert", "Jones", "789 Oak St", "5678-1234-4321-8765", 50, 100, 10, 50)
            };

            // a) Сведения об абонентах, у которых время внутригородских разговоров превышает заданное;
            int maxLocalMinutes = 25;
            var abonentsWithExcessiveLocalCalls = phones.Where(p => p.LocalCallMinutes > maxLocalMinutes).ToArray();

            Console.WriteLine($"Abonents with excessive local call minutes (more than {maxLocalMinutes} minutes):");
            foreach (var abonent in abonentsWithExcessiveLocalCalls)
            {
                Console.WriteLine(abonent);
            }

            // b) Сведения об абонентах, которые пользовались междугородной связью;
            var abonentsWithLongDistanceCalls = phones.Where(p => p.LongDistanceCallMinutes > 0).ToArray();

            Console.WriteLine("\nAbonents who made long distance calls:");
            foreach (var abonent in abonentsWithLongDistanceCalls)
            {
                Console.WriteLine(abonent);
            }
        }
    }
}