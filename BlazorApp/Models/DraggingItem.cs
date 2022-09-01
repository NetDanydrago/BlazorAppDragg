namespace BlazorApp.Models
{
    public class DraggingItem
    {

        public int Order { get; set; }
        public string Value { get; set; }
        public bool IsDragOver { get; set; }
        public bool IsMove { get; set; }
    }
}
