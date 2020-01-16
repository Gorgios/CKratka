using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.Helpers
{
    public class PersonalBestHelper :TagHelper
    {
        public float PersonalBest { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.TagMode = TagMode.StartTagAndEndTag;
            var personalBest = PersonalBest + " m";
            output.Content.SetContent(personalBest);
        }
    }
}
