namespace ArcsimPlatform.ComponentModels.Entities.ArcSim
{
    public class ConfigSet
    {
        public int ConfigSetId { get; set; }
        public int ProductId { get; set; }
        public int RunTypeId { get; set; }
        public int ModelParamId { get; set; }

        public override string ToString()
        {
            return "Id:" + this.ConfigSetId + ", ProductId:" + this.ProductId + ", RunTypeId:" + this.RunTypeId + ", ModelParamId:" + this.ModelParamId;
        }
    }
}