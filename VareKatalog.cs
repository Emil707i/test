using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHuset.DataModels;

namespace LagkageHuset
{
    public class VareKatalog
    {
        public static List<Vare> HentVarer()
        {
            return new List<Vare>
            {
                new Vare
                {
                    Id = 1, 
                    Pris = 12, 
                    VareBeskrivelse = new VareBeskrivelse
                    {
                        Id = 1, 
                        Navn = "GROVHÅNDVÆRKER ALM."
                    }
                },
                new Vare
                {
                    Id = 2,
                    Pris = 15,
                    VareBeskrivelse = new VareBeskrivelse
                    {
                        Id = 2,
                        Navn = "SURDEJS BOLLE"
                    }
                },
                new Vare
                {
                    Id = 3,
                    Pris = 28,
                    VareBeskrivelse = new VareBeskrivelse
                    {
                        Id = 3,
                        Navn = "BAGEL"
                    }
                },
                new Vare
                {
                    Id = 4,
                    Pris = 14,
                    VareBeskrivelse = new VareBeskrivelse
                    {
                        Id = 4,
                        Navn = "GULEROD RUSTIK BOLLE"
                    }
                },
                new Vare
                {
                    Id = 5,
                    Pris = 16,
                    VareBeskrivelse = new VareBeskrivelse
                    {
                        Id = 5,
                        Navn = "BLØD FULDKORNSBOLLE"
                    }
                }
            };
        }
    }
}
