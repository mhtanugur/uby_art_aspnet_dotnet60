﻿using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Site
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Keywords { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string? Logo { get; set; }

    public string? Logo2 { get; set; }

    public string? Favicon { get; set; }

    public int Page { get; set; }
}
