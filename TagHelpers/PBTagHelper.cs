using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.TagHelpers
{
    [HtmlTargetElement("dd", Attributes = ValueAttribute)]
    public class PBTagHelper: TagHelper
    {
        private const string ValueAttribute = "pb-helper-value";
        [HtmlAttributeName(ValueAttribute)] public float Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {   string val = Value.ToString();
            output.TagName = "dd";
            output.Content.SetContent(val + " m");
        }
    }
}
