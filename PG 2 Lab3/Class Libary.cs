using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace PG_2_Lab3
{
    public partial class Class_Libary : Component
    {
        public Class_Libary()
        {
            InitializeComponent();
        }

        public Class_Libary(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
