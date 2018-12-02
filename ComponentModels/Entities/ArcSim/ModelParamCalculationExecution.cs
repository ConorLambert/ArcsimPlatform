namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ModelParamCalculationExecution : ModelParam
    {
        public string CalculationStage {get; set;}
        public string StepType {get; set;}
        public string StepName {get; set;}
        public string StepAlgorithm {get; set;}
        public int OrderID {get; set;}
    }
}