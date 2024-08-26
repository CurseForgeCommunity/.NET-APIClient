using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class ModLinks
    {
        [JsonPropertyName("websiteUrl")]
        public string WebsiteUrl {  get; set;}
        [JsonPropertyName("wikiUrl")]
        public string WikiUrl {  get; set;}
        [JsonPropertyName("issuesUrl")]
        public string IssuesUrl {  get; set;}
        [JsonPropertyName("sourceUrl")]
        public string SourceUrl {  get; set;}
    }
}
