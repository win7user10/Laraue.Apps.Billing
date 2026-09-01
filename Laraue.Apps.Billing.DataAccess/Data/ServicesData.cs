namespace Laraue.Apps.Billing.DataAccess.Data;

public static class ServicesData
{
    public static Service Boards = new()
    {
        Id = new Guid("536654A6-533C-43FB-8F3B-FFDE8AC38F7E"),
        Name = "Laraue Boards",
        Code = "laraue_boards",
    };
    
    public static Service MarkdownTranslator = new()
    {
        Id = new Guid("DB9CB0AB-3939-44DD-960E-2808629B5193"),
        Name = "Markdown Translator",
        Code = "markdown_translator",
    };
}