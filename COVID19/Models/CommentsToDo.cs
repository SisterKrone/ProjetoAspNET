namespace COVID19.Models
{
    public class CommentsToDo
    {  
     
        public int CommentsToDoId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public int ToDoId { get; set; }
        public ToDo ToDo { get; set; }
    
    
    }
}