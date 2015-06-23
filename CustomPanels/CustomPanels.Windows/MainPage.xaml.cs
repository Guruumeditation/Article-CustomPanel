
using System.Collections.Generic;
using System.Linq;

namespace CustomPanels
{
    public sealed partial class MainPage 
    {
        public List<string> Items { get; set; }

        public List<IGrouping<string,string>> GroupedItems { get; set; }

        public MainPage()
        {
            InitializeComponent();

            var strings = new List<string>
                    {
                        "Hello",
                        "Hello world",
                        "Hello world Hello world",
                        "Hello world Hello world Hello world",
                        "Hello world Hello world Hello world \nHello world",
                        "Hello world Hello world Hello world \nHello world Hello world",
                        "Hello world Hello world Hello world \nHello world Hello world \nHello world",
                    };

            for (var i = 0; i < 3; i++)
            {
                strings.AddRange(strings);
            }

            Items = strings.ToList();

            GroupedItems = Items.GroupBy(d => "Group 1").Union(Items.GroupBy(d => "Group 2")).ToList();

            DataContext = this;


        }
    }
}
