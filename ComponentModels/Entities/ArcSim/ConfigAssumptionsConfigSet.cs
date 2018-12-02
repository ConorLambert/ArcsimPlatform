using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ConfigAssumptionsConfigSet
    {
        public int AssumptionsConfigSetId {get;set;}
        public int BaseAssumptionConfigSetId {get;set;}
        public int ActionTypeId {get;set;}
        public string Name {get;set;}
        public int KernelConfigConfigSetId {get; set;}
        public int CalculationExecutionConfigSetId {get; set;}
        public int RunDefinitionConfigSetId {get; set;}
        public int ExpensesConfigSetId {get; set;}
        public int DemographicConfigSetId {get; set;}
        public int EconomicConfigSetId {get; set;}
        public int ModelConfigSetId {get; set;}
        public int ModelPointConfigSetId {get; set;}
        public int ManagementConfigSe{get; set;}
        public int KFactorConfigSetId {get;set;}
        public string Description {get;set;}
        public int AddedBy {get;set;}
        public DateTime DateAdded {get;set;}
        public string DateCompleted {get;set;}
        public string IsComplete {get;set;}

        public ConfigEconomic ConfigKernelConfig { get; set; }
        public ConfigCalculationExecution ConfigCalculationExecution { get; set; }
        public ConfigRunDefinition ConfigRunDefinition { get; set; }
        public ConfigEconomic ConfigEconomic { get; set; }
        public ConfigExpenses ConfigExpenses { get; set; }
        public ConfigDemographicSettings ConfigDemographicSettings { get; set; }
        //public List<ConfigSet> ConfigSets { get; set; }
    }
}