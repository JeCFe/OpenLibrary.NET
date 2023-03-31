﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.NET
{
    public record OLRequest
    {
        public OLRequestAPI? API { get; init; }
        public string? ID { get; init; }
        public string? Path { get; init; }
        public ReadOnlyDictionary<string, string> Params { get; init; }
            = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());

        public string ToURL() => OpenLibraryUtility.BuildURL(this);
    }
}