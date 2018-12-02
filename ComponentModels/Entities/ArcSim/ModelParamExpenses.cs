namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ModelParamExpenses : ModelParam
    {
        public string ExpenseType {get; set;}
        public int Currency {get;set;}
        public double InflationRate {get; set;}
        public int InflationFrequency {get; set;}
        public double Initial {get; set;}
        public int InitialFrequency {get;set;}
        public double Renewal { get; set; }
        public int RenewalFrequency { get; set;}
    }
}