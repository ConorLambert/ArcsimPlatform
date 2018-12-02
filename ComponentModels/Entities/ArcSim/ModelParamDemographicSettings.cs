namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ModelParamDemographicSettings : ModelParam
    {
        public int DynamicLapseIndicator { get; set; }
        public float LapseShockFactor { get; set; }
        public int MaxLapseRate { get; set; }
        public string LapseRates { get; set; }
        public float DeathBenefitCashInFactor { get; set; }
        public float ProportionOfTables { get; set; }
        public string MortalityTableType {get; set; }
        public int	MortalityTableMaleAgeOffset {get; set; }
        public int	MortalityTableFemaleAgeOffset {get; set; }
        public string StaticMortalityRatesMale {get; set; }
        public string StaticMortalityRatesFemale	 {get; set; }
        public string TimeDependantMortalityRatesMale {get; set; }
        public string TimeDependantMortalityRatesFemale {get; set; }
        public string MortalityRatesWithStaticAdjustmentsMale {get; set; }
        public string MortalityRatesWithStaticAdjustmentsFemale {get; set; }
        public string MortalityRatesWithTimeBasedAdjustmentsMale {get; set; }
        public string MortalityRatesWithTimeBasedAdjustmentsFemale {get; set; }
        public string MortalitySelectFactorsMale {get; set; }
        public string MortalitySelectFactorsFemale {get; set; }
        public int DynamicWithdrawalIndicator {get; set; }
        public int DynamicWithdrawalPseudoRandomNumbersIndicator {get; set; }
        public int DynamicWithdrawalRngFixedSeedEnabled {get; set; }
        public int DynamicWithdrawalRngFixedSeed {get; set; }
        public string DynamicWithdrawalProbabilityFalseToTrue {get; set; }
        public string DynamicWithdrawalProbabilityTrueToFalse {get; set; }
        public string DynamicWithdrawalPseudoRandomNumberSet {get; set; }
    }
}