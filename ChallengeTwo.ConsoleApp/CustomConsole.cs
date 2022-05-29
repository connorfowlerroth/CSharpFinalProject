using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeTwo.Repository;

namespace ChallengeTwo.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("Choose a menu item:\n\n" +
                            "1. See all claims\n\n" +
                            "2. Take care of next claim\n\n" +
                            "3. Enter a new claim\n\n");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public decimal GetUserInputDecimal()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }
        public bool GetUserInputBool()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }

        public void EnterClaimID()
        {
            Console.Clear();
            Console.Write("Enter ClaimID: \n");
        }
        public void EnterClaimType()
        {
            Console.Clear();
            Console.Write("Enter Claim Type: \n\n" +
                        "Car, Home, Theft \n\n");
        }
        public void EnterDescription()
        {
            Console.Clear();
            Console.WriteLine("Enter Description of Claim: \n\n");
        }
        public void EnterClaimAmount()
        {
            Console.Clear();
            Console.WriteLine("Enter Claim Amount: \n\n");
        }
        public void EnterDateOfIncident()
        {
            Console.Clear();
            Console.WriteLine("Enter Date of Incident: \n\n" +
                                    "MM/DD/YYYY\n\n");
        }
        public void EnterDateOfClaim()
        {
            Console.Clear();
            Console.WriteLine("Enter Date of Claim: \n\n" +
                                    "MM/DD/YYYY\n\n");
        }
        public void EnterIsValid()
        {
            Console.Clear();
            Console.WriteLine("Was The Incident reported within 30 days?\n\n" +
                                        "true/false\n\n");
        }

        public void PrintClaims(Claims claimList)
        {
            Console.WriteLine("ClaimId       Type               Description               Amount       DateOfIncident          DateOfClaim          IsValid \n\n" +
                            $"   {claimList.ClaimID}          "+$"{claimList.ClaimType}          "    +    $"{claimList.Description}        "    +    $"{claimList.ClaimAmount}         "    +    $"{claimList.DateOfIncident}               "    +    $"{claimList.DateOfClaim}             "    +    $"{claimList.IsValid}\n\n");

        }
        public void PrintClaimsByID(Claims claimIDList)
        {
            Console.WriteLine(
            $"ClaimID: {claimIDList.ClaimID}\n\n" + $"Type: {claimIDList.ClaimType}\n\n" + $"Description: {claimIDList.Description}\n\n" + $"Amount: {claimIDList.ClaimAmount}\n\n" + $"DateOfAccident: {claimIDList.DateOfIncident}\n\n" + $"DateOfClaim: {claimIDList.DateOfClaim}\n\n" + $"IsValid: {claimIDList.IsValid}\n\n");

        }
        public void PrintAllClaims(List<Claims> claimList)
        {
            foreach(Claims x in claimList)
            {
                PrintClaims(x);
            }
        }
        public void PrintClaimsByID(List<Claims> claimIDList)
        {
            foreach(Claims x in claimIDList)
            {
                PrintClaimsByID(x);
            }
        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Press any key to EXIT....");
            Console.ReadKey();
        }
        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue....\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}