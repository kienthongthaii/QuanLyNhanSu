using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER_MANAGERMENT.Components
{
    public partial class MyTreeViewCombo : Component
    {
        public MyTreeViewCombo()
        {
            InitializeComponent();
        }

        public MyTreeViewCombo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
