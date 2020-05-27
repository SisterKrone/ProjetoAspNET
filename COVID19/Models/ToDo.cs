using System.Collections.Generic;

namespace COVID19.Models {
    public class ToDo {

        public int ToDoId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string LinkImage { get; set; }
        public List<CommentsToDo> CommentsToDo { get; set; }

    }
}