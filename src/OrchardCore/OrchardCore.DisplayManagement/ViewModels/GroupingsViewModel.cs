using System.Collections.Generic;
using System.Linq;
using OrchardCore.DisplayManagement.Shapes;

namespace OrchardCore.DisplayManagement.ViewModels
{
    public class GroupViewModel : Shape
    {
        public string Identifier { get; set; }
    }
    public class GroupingsViewModel : GroupViewModel
    {
        public List<IGrouping<string, IShape>> Groupings { get; set; }
    }

    public class GroupingViewModel : GroupViewModel
    {
        public IGrouping<string, IShape> Grouping { get; set; }
    }   
}