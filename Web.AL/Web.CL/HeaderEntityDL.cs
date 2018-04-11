namespace Web.DL
{
    public class HeaderEntityDL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public LinkDL Link1 { get; set; }
        public LinkDL Link2 { get; set; }
    }
    public class LinkDL
    {
        public string LinkText { get; set; }
        public string LinkAddress { get; set; }
    }
}
