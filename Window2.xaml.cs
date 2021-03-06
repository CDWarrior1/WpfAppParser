using System.Collections.Generic;
using System.Windows;

namespace WpfAppParser
{
    public partial class Window2 : Window
    {
        public Window2(List<List<Report>> reports)
        {
            InitializeComponent();
            foreach (List<Report> item in reports)
            {
                foreach (Report rep in item)
                {
                    listOfChanges.Items.Add(rep);
                }
            }
        }
    }
}