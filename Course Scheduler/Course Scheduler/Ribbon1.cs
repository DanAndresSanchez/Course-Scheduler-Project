﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Course_Scheduler
{
    public partial class Ribbon1
    {
        Reports r = new Reports();
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void center_align_button_Click(object sender, RibbonControlEventArgs e)
        {
            r.centerAlign();
        }

        private void final_report_button_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
