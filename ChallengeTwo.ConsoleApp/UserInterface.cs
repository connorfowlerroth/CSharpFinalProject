using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeTwo.Repository;

namespace ChallengeTwo.ConsoleApp
{
    public class UserInterface
    {
        ClaimsRepository _repo = new ClaimsRepository();
        CustomConsole _console = new CustomConsole();
        bool isRunning = true;

        public void Run()
        {
            _repo.SeedClaimsData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                UserInputPortal(userInput);
            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    SeeAllClaims();
                    break;
                case "2":
                    // TakeCareOfNextClaim();
                    break;
                case "3":
                    CreateNewClaim();
                    break;
                case "4":
                    // ExitApp();
                    break;
                default:
                    //InvalidInputReturnToMainMenu();
                    break;
            }
        }

        private void CreateNewClaim()
        {
            Console.Clear();
            _console.EnterClaimID();
            int newClaimID = _console.GetUserInputInt();

             _console.EnterClaimType();
            string claimTypeSelection = _console.GetUserInput();

            ClaimType? newClaimType = ClaimTypeSelection(claimTypeSelection);

            _console.EnterDescription();
            string newClaimDescription = _console.GetUserInput();

            _console.EnterClaimAmount();
            decimal newClaimAmount = _console.GetUserInputDecimal();

            _console.EnterDateOfIncident();
            string newDateOfIncident = _console.GetUserInput();

            _console.EnterDateOfClaim();
            String newDateOfClaim = _console.GetUserInput();

            _console.EnterIsValid();
            bool newIsValid = _console.GetUserInputBool();

            // Constructor
            Claims newClaims = new Claims(newClaimID, newClaimType, newClaimDescription, newClaimAmount, newDateOfIncident, newDateOfClaim,newIsValid);

            _repo.AddClaimToDatabase(newClaims);

            _console.PressAnyKeyToContinue();
        }

        public void TakeCareOfNextClaim()
        {

        }
        public void SeeAllClaims()
        {
            List<Claims> allClaims = _repo.GetAllClaims();

            Console.Clear();
            _console.PrintAllClaims(allClaims);
            _console.PressAnyKeyToContinue();
        }
        public void ExitApp()
        {
            Console.Clear();
            _console.Exit();
            _console.PressAnyKeyToContinue();
        }


        private ClaimType? ClaimTypeSelection(string userClaimTypeInput)
        {
            switch(userClaimTypeInput)
            {
                case "1":
                    return ClaimType.Car;
                case "2":
                    return ClaimType.Home;
                case "3":
                    return ClaimType.Theft;
                default:
                    return null;
            }
        }
    }
}