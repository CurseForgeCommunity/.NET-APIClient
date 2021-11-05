using System;

namespace CurseForge.APIClient.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public DateTimeOffset DateModified { get; set; }
        public bool? IsClass { get; set; }
        public int? ClassId { get; set; }
        public int? ParentCategoryId { get; set; }
    }
}
