﻿using OpenStack.NetCoreSwiftClient.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSwiftClient.Demo.AspNetCore.ViewModels
{
    public class TextModel: BaseFieldModel
    {
        public string Value { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } = "text";
        public string PlaceHolder { get; set; }
        public bool IncludeLabel { get; set; } = true; 
        public string Tip { get; set; }
        public string Pattern { get; set; }
        public bool AutoComplete { get; set; } = true;
        public static TextModel FromNameLabel(string name, string label, string value=null, string tip=null)
        {
            var tm= new TextModel()
            {
                Name = name,
                Label = label,
            };
            if (!value.IsNullOrEmpty()) tm.Value = value;
            if (!tip.IsNullOrEmpty()) tm.Tip = tip;
            return tm;
        }
    }
}
