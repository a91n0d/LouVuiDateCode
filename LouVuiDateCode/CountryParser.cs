using System;

namespace LouVuiDateCode
{
    public static class CountryParser
    {
        private static readonly string[] France = new[]
            {
                "A0", "A1", "A2", "AA", "AH", "AN", "AR", "AS", "BA", "BJ", "BU", "DR", "DU", "DR", "DT", "CO", "CT", "CX",
                "ET", "MB", "MI", "NO", "RA", "RI", "SF", "SL", "SN", "SP", "SR", "TJ", "TH", "TR", "TS", "VI", "VX",
            };

        private static readonly string[] FranseUsa = new[] { "FL", "SD" };
        private static readonly string[] FranceSpain = new[] { "LW" };
        private static readonly string[] Germany = new[] { "LP", "OL" };
        private static readonly string[] Italy = new[] { "BC", "BO", "CE", "FO", "MA", "OB", "RC", "RE", "SA", "TD", };
        private static readonly string[] Spain = new[] { "CA", "LO", "LB", "LM", "GI" };
        private static readonly string[] Switzerland = new[] { "DI", "FA" };
        private static readonly string[] Usa = new[] { "FC", "FH", "LA", "OS" };

        /// <summary>
        /// Gets a an array of <see cref="Country"/> enumeration values for a specified factory location code. One location code can belong to many countries.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <returns>An array of <see cref="Country"/> enumeration values.</returns>
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode), "string is null or empty ");
            }

            if (Array.IndexOf(France, factoryLocationCode) > -1)
            {
                return new Country[] { Country.France };
            }
            else if (Array.IndexOf(Italy, factoryLocationCode) > -1)
            {
                return new Country[] { Country.Italy };
            }
            else if (Array.IndexOf(Spain, factoryLocationCode) > -1)
            {
                return new Country[] { Country.Spain };
            }
            else if (Array.IndexOf(Usa, factoryLocationCode) > -1)
            {
                return new Country[] { Country.USA };
            }
            else if (Array.IndexOf(FranseUsa, factoryLocationCode) > -1)
            {
                return new Country[] { Country.France, Country.USA };
            }
            else if (Array.IndexOf(Germany, factoryLocationCode) > -1)
            {
                return new Country[] { Country.Germany };
            }
            else if (Array.IndexOf(Switzerland, factoryLocationCode) > -1)
            {
                return new Country[] { Country.Switzerland };
            }
            else if (Array.IndexOf(FranceSpain, factoryLocationCode) > -1)
            {
                return new Country[] { Country.France, Country.Spain };
            }
            else
            {
                throw new ArgumentException("factory location code is invalid ", nameof(factoryLocationCode));
            }
        }
    }
}
