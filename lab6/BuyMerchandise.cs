//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab6
{

    public partial class BuyMerchandise
    {
        public int Идентификатор { get; set; }
        public short Count { get; set; }
        public int Merchandise_Идентификатор { get; set; }
        public int Buy_Идентификатор { get; set; }
    
        public virtual Buy Buy { get; set; }
        public virtual Merchandise Merchandise { get; set; }
    }
}