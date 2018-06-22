using Featurify.Contracts;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace AspNetIdentityWithFeaturify.Infrastructure
{
    public class UserBasedToggleMetadataFinder : IToggleMetadataFinder
    {
        public async Task<IToggleMetadata> FindToggleStatus(string featureName, string userId)
        {
            var required = toggleMetadatas.SingleOrDefault(t => t.Name == featureName && t.UserId == userId);
            await Task.CompletedTask;
            return required;
        }

        private static List<ToggleMetadata> toggleMetadatas = new List<ToggleMetadata>
        {
            new ToggleMetadata { Name = "Featurify.ImportFeature", Value = true, UserId = "john.doe@company.com" },
            new ToggleMetadata { Name = "Featurify.ExportFeature", Value = false, UserId = "john.doe@company.com" },
            new ToggleMetadata { Name = "Featurify.EmailFeature", Value = true, UserId = "john.doe@company.com" }
        };
    }
}
