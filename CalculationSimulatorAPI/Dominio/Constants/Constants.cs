namespace CalculationSimulatorAPI.Dominio.Constantes
{
    public static class Constants
    {
        public static class Taxs
        {
            /// <summary>
            /// Taxas CDI e TB
            /// </summary>
            public static readonly decimal CDI = 0.9M / 100;
            public static readonly decimal TB = 108M / 100;
        }

        /// <summary>
        /// Taxas de IR conforme a quantidade de meses
        /// </summary>
        public static class TaxIncome
        {
            public static readonly decimal TaxRateUp6 = 22.5M / 100;
            public static readonly decimal TaxRateUp12 = 20M / 100;
            public static readonly decimal TaxRateUp24 = 17.5M / 100;
            public static readonly decimal TaxRateThan24 = 15M / 100;
        } 
    }
}
