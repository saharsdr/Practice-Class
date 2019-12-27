using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{

    public class classThem
    {
        //variable for form's object's colour
        public System.Drawing.Color sideMenuBack;
        public System.Drawing.Color mainText;
        public System.Drawing.Color unmainText;
        public System.Drawing.Color background;
        public System.Drawing.Color row;
        public System.Drawing.Color borderWarning;
        public System.Drawing.Color borderOccur;
        public System.Drawing.Color buttonIn;
        public System.Drawing.Color buttonOut;


        public classThem()
        {
            sideMenuBack = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            mainText = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(251)))));
            unmainText = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            background = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            row = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            borderWarning = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            borderOccur = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(216)))), ((int)(((byte)(80)))));
            buttonIn = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(235)))));
            buttonOut = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(251)))));
        }
        public void changeThemToLight()
        {
            sideMenuBack = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            mainText = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(251)))));
            unmainText = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            background = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            row = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            borderWarning = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(102)))), ((int)(((byte)(38)))));
            borderOccur = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(216)))), ((int)(((byte)(80)))));
        }

    }

}
