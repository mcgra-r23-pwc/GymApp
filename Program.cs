using System;

namespace GymApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Login or register
            Console.WriteLine("Hi!\n");
            Console.WriteLine("\tExisting member?\tLogin (L)\n\n\tNew member?\t\tRegister (R)\n\n\t\t\t\tExit (X)\n");

            var loginRegister = char.ToUpper(Console.ReadKey().KeyChar);
            if (loginRegister == 'L')
            {
                // set up list of members
                var memberList = new List<Member>
                {
                    new Member()
                    {
                        FirstName = "Rory",
                        LastName = "McGrath",
                        MembershipNumber = 040118,
                        MemberType = "Personal Trainer",
                        RenewalDate = new DateTime(2023, 01, 17),
                        HouseNumber = "123",
                        StreetName = "This Place",
                        TownCity = "Carryduff",
                        County = "Down",
                        PostCode = "BT8 7RS"
                    },
                    new Member()
                    {
                        FirstName = "Arthur",
                        LastName = "Guinness",
                        MembershipNumber = 231109,
                        MemberType = "Gym User",
                        RenewalDate = new DateTime(2023, 03, 17),
                        HouseNumber = "456",
                        StreetName = "That Place",
                        TownCity = "Belfast",
                        County = "Antrim",
                        PostCode = "BT9 7HQ"
                    },
                    new Member()
                    {
                        FirstName = "David",
                        LastName = "Clifford",
                        MembershipNumber = 241222,
                        MemberType = "Gym User",
                        RenewalDate = new DateTime(2023, 09, 11),
                        HouseNumber = "789",
                        StreetName = "The Other Place",
                        TownCity = "Derrymacash",
                        County = "Armagh",
                        PostCode = "BT66 6LG"
                    }
                };

                // select a member
                bool membershipNumberValid = false;
                Member selectedMember = new Member();

                Console.WriteLine("\nWelcome! Please enter your Membership Number:");

                do
                {
                    int.TryParse(Console.ReadLine(), out var membershipNumber);

                    if (membershipNumber <= 0)
                    {
                        Console.WriteLine("\n\tMembership number must be in numeric format only.");
                    }

                    foreach (Member m in memberList)
                    {
                        if (membershipNumber == m.MembershipNumber)
                        {
                            selectedMember = m;
                            membershipNumberValid = true;
                        }
                    }

                    if (membershipNumberValid == false)
                    {
                        Console.WriteLine("\n\tPlease enter a valid Membership Number.");
                    }

                } while (membershipNumberValid == false);

                // Welcome Member
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine($"\n\tWelcome, {selectedMember.FirstName}!\n\tMember Type: {selectedMember.MemberType}");
                Console.WriteLine("\n------------------------------------------------------------");

                bool exited = false;

                // Calculate Days Remaining
                DateTime currentDate = DateTime.Today;
                DateTime memberRenewalDate = (selectedMember.RenewalDate);
                TimeSpan remainingDays = memberRenewalDate.Subtract(currentDate);

                // Short Renewal Date
                var shortRenewalDate = (selectedMember.RenewalDate).ToShortDateString();

                do
                {
                    Console.WriteLine("\n\tWhich service would you like?");
                    Console.WriteLine("\t\tView Member Information (I)\n\t\tDays Remaining Balance (D)\n\t\tExit (X)\n");

                    var service = char.ToUpper(Console.ReadKey().KeyChar);

                    switch (service)
                    {
                        // View Member Information
                        case 'I':
                            Console.WriteLine("\n------------------------------------------------------------");
                            Console.WriteLine($"\n\tName:\t\t{selectedMember.FullName()}");
                            Console.WriteLine($"\n\tMembership No.:\t{selectedMember.MembershipNumber}");
                            Console.WriteLine($"\n\tMember Type:\t{selectedMember.MemberType}");
                            Console.WriteLine($"\n\tRenewal Date:\t{shortRenewalDate}");
                            Console.WriteLine($"\n\tAddress:\t{selectedMember.FullAddress()}");
                            Console.WriteLine("\n------------------------------------------------------------");
                            break;
                        // View Days Remaining Balance
                        case 'D':
                            Console.WriteLine("\n------------------------------------------------------------");
                            Console.WriteLine($"\n\tYou have {remainingDays.TotalDays} days remaining until your next renewal.");
                            Console.WriteLine("\n------------------------------------------------------------");
                            break;
                        // Exit char
                        case 'X':
                            exited = true;
                            break;
                        default:
                            Console.WriteLine("\nPlease enter a valid character");
                            break;
                    }
                }
                while (exited == false);
            }

            else if (loginRegister == 'R')
            {
                Console.WriteLine("\nWelcome to Giomnáisiam Aodha Dhuibh!\nPlease fill out the following form...");
                Console.WriteLine("\tFirst Name?");
                Console.ReadLine();

            }

        }
    }
}