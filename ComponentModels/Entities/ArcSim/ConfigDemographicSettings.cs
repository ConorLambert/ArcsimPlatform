namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ConfigDemographicSettings : ConfigSet 
    {
        public int LapseRatesId { get; set; }
        public int DemographicSettingsId { get; set; }
        public int WithdrawalRatesId { get; set; }
        public int MortalityRatesMaleId { get; set; }
        public int MortalityRatesFemaleId { get; set; }
        public int MortalityAdjustmentFactorsMaleId { get; set; }
        public int MortalityAdjustmentFactorsFemaleId { get; set; }
        public int MortalitySelectFactorsMaleId { get; set; }
        public int MortalitySelectFactorsFemaleId { get; set; }
        public int WithdrawalTransitionalProbabilitiesTrueToFalse { get; set; }
        public int WithdrawalTransitionalProbabilitiesFalseToTrue { get; set; }
    }
}