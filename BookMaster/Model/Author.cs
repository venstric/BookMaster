//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMaster.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        public Author()
        {
            this.BookAuthor = new HashSet<BookAuthor>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> DeathDate { get; set; }
        public string Wikipedia { get; set; }
    
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
