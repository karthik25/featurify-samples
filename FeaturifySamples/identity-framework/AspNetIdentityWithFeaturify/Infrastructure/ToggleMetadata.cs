using Featurify.Contracts;

namespace AspNetIdentityWithFeaturify.Infrastructure
{
    public class ToggleMetadata : IToggleMetadata
    {
        public string Name { get; set; }
        public bool Value { get; set; }
        public string UserId { get; set; }
    }
}
