using System.Collections.Generic;

namespace COVID19.Models {
    public class Tips {

        public int TipsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string LinkImage { get; set; }
        public List<Comment> Comments { get; set; }

    }
}