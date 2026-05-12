using System.Collections.Generic;

namespace BlogEngineDataLayer.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
