using System;
using System.Collections.Generic;

namespace DBTask.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Genre { get; set; }

    public long? PublishedYear { get; set; }
}
