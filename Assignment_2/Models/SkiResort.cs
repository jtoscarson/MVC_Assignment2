using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class SkiResort
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int TopElevation { get; set; }
        public int BaseElevation { get; set; }
        public int NumberOfLifts { get; set; }
        public List<SeasonPass> PassList;
    }
}