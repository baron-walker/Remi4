using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remi4.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowlers> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamCategory { get; set; }
    }
}
