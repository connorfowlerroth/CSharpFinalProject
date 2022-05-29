using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
    public class Claims
    {
            public int ClaimID { get; set; }

            public ClaimType? ClaimType { get; set; }

            public string Description { get; set; }

            public decimal ClaimAmount { get; set; }

            public string DateOfIncident { get; set; }

            public string DateOfClaim { get; set; }

            public bool IsValid { get; set; }

            public Claims(int claimID, ClaimType? claimType, string description, decimal claimAmount, string dateOfIncident, string dateOfClaim, bool isValid)
            {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
        // empty con
        public Claims() { }
    }
    // enums 
    public enum ClaimType { Car, Home, Theft }
}