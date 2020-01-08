using System;
namespace MyBill.Entity
{
    public class BaseSearch
    {
        public BaseSearch()
        {
            this.Page = 1;
            this.Size = 10;
            this.Text = string.Empty;
        }
        public int Page { get; set; }
        public int Size { get; set; }
        public string Text { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }
    }
}
