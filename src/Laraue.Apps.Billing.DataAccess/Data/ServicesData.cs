using Laraue.Apps.Billing.DataAccess.Entities;

namespace Laraue.Apps.Billing.DataAccess.Data;

public static class ServicesData
{
    private static readonly Service Boards = new()
    {
        Id = ServiceId.LaraueBoards,
        Name = "Laraue Boards",
        Code = "laraue_boards",
    };

    private static readonly Service MarkdownTranslator = new()
    {
        Id = ServiceId.MarkdownTranslator,
        Name = "Markdown Translator",
        Code = "markdown_translator",
    };

    public static readonly Service[] Services =
    [
        Boards,
        MarkdownTranslator,
    ];
}