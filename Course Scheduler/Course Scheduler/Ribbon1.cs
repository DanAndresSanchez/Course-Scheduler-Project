﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Course_Sceduler;
using Microsoft.Office.Tools.Ribbon;

namespace Course_Scheduler
{
    public partial class Ribbon1
    {
        Reports r = new Reports();
        UpdateRoomOccupancy u = new UpdateRoomOccupancy();
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void center_align_button_Click(object sender, RibbonControlEventArgs e)
        {
            r.centerAlign();
        }

        private void final_report_button_Click(object sender, RibbonControlEventArgs e)
        {
            r.generateReport();
        }

        private void border_button_Click(object sender, RibbonControlEventArgs e)
        {
            r.createBorder();
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            r.addLeadingZero();
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            u.WriteToDatabase();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
