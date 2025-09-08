using System;
using System.Collections.Generic;

namespace BankAPI_IIS.Models;

public partial class Content
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? Category { get; set; }

    public string? Summary { get; set; }

    public bool IsPublished { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? PublishedDate { get; set; }

    public string? Author { get; set; }
}
