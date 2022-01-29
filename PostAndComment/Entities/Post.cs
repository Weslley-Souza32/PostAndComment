using System.Text;

namespace PostAndComment.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //usando o StringBuilder para formatar a nossa saida.
        public override string ToString()
        {
            StringBuilder @string = new StringBuilder();
            @string.AppendLine(Title);
            @string.Append(Likes);
            @string.Append(" Likes - ");
            @string.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            @string.AppendLine(Content);
            @string.AppendLine("Comments:");

            //Peccorendo nossa lista de comentarios e adcionando em nosso StringBuilder
            foreach(Comment item in Comments)
            {
                @string.AppendLine(item.Text);
            }
            return @string.ToString();
        }
    }
}
