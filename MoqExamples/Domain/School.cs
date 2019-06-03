namespace MoqExamples.Domain
{
    public class School
    {
        private ISchoolConfig _schoolConfig;

        public School(ISchoolConfig schoolConfig)
        {
            _schoolConfig = schoolConfig;
        }

        public string GetConfigValue(string configKey)
        {
            var configValue = _schoolConfig.GetValue(configKey);
            return configValue;
        }
    }
}
