﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace batNotes.Models
{
    public class FetchOptions
    {
        public string SortExpression { get; set; }

        public SortDirection SortDirection { get; set; }
    }
}