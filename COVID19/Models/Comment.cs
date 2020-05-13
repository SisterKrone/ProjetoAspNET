namespace COVID19.Models
{
    public class Comment
    {  
     
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public int TipsId { get; set; }
        public Tips Tips { get; set; }
    
    
    }
}