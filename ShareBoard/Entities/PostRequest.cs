using ShareBoard.Models;

namespace ShareBoard.Entities
{
    public class PostRequest
    {
        public string Content { get; set; }
        public PostItemType Type { get; set; }
    }
}