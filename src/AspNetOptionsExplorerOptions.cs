﻿namespace AspNetOptionsExplorer
{
    public class AspNetOptionsExplorerOptions
    {
        public string PathMatch { get; set; } = "/options";
        public bool LocalHostOnly { get; set; } = true;
        public bool TryRedactConnectionStrings { get; set; } = true;

    }
}
