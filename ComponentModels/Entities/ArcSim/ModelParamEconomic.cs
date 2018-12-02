namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ModelParamEconomic : ModelParam
    {
        public float IfrsCreditSpread {get; set;}
        public int EsgInternalRngFixedSeedEnabled {get; set;}
        public float EsgInternalRngFixedSeed {get; set;}
        public float EsgInternalVolatility {get; set;}
        public float SoniaRate {get; set;}
    }
}