using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
    public class ClaimsRepository
    {
        // empty con
         public ClaimsRepository() { }

        //  fake db 
        List<Claims> _claimsDB = new List<Claims>();

        // create
        public void AddClaimToDatabase (Claims claims)
        {
            _claimsDB.Add(claims);
        }

        // read
        public List<Claims> GetAllClaims()
        {
            return _claimsDB;
        }

        // update


        // delete
        

        // seed data 
        public void SeedClaimsData()
        {
            Claims Claim1 = new Claims(1, ClaimType.Car, "Car accident on 465.", 400.00m, "04/25/18", "04/27/18", true);
            Claims Claim2 = new Claims(1, ClaimType.Home, "House fire in kitchen.", 4000.00m, "04/11/18", "04/12/18", true);
            Claims Claim3 = new Claims(3, ClaimType.Theft, "Stolen pancakes.", 4.00m, "04/27/2018", "06/01/18", false);

            Claims[] claimsArr = { Claim1, Claim2, Claim3 };

            foreach (Claims claims in claimsArr)
            {
                AddClaimToDatabase(claims);
            }
        }

    }
}