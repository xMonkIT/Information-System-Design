//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab8.Models
{
    using System.Collections.Generic;

    public partial class Post
    {
        public Post()
        {
            this.Comment = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int IdBlog { get; set; }
    
        public virtual Blog Blog { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
