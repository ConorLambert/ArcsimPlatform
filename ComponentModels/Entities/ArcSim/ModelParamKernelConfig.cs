namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ModelParamKernelConfig : ModelParam
   {
        public int NumberOfProcessors { get; set; }
        public int PolicyBlockSize { get; set; }
        public string ParallelSettingsCalculationMethod { get; set; }
        public string RunInParallel { get; set; }
        public string ParallelProcessingType { get; set; }
        public int NumberOfSimulations { get; set; }
        public int ProjectionDurationInMonths { get; set; }
        public string EsgSource { get; set; }
        public string EsgDatabaseServer { get; set; }
        public string EsgXmlDirectory { get; set; }
        public int StochasticRateAdjustmentFactor { get; set; }
        public int BenefitClaimScalar { get; set; }
        public string ResultLevel { get; set; }
        public string ResultSubLevel { get; set; }
        public string ResultOutputTarget { get; set; }
        public string ResultLevelDetailedPolicyGroupingProperty { get; set; }
        public string ResultLevelDebugPolicyNumber { get; set; }
        public string ResultLevelDebugSimulationNumber { get; set; }
        public string ResultProjection { get; set; }
        public string ResultSummaryOutputVariables { get; set; }
        public string ResultDetailedOutputVariables { get; set; }
        public string ResultDebugOutputVariables { get; set; }
        public string RequiredPolicyDataVariables { get; set; }
        public string RequiredAssetDataVariables { get; set; }
    }
}