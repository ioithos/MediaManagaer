using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager
{
    class Reposition
    {
        public const double LABEL_LEFT = 0.1;
        public const double TEXT_LEFT = 0.3;
        public const double TEXT_RIGHT = 0.7;

        public static void setTitle(Label label)
        {
            setControl(label, .4, .7, 0, .1);
        }
        public static double setLabels(double top, params Label[] labels)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                setControl(labels[i], LABEL_LEFT, TEXT_LEFT, top, top + 0.1);
                top += 0.1;
            }

            return top;
        }

        public static double setTextBoxes(double top, params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                setControl(textBoxes[i], TEXT_LEFT, TEXT_RIGHT, top, top + 0.1);
                top += 0.1;
            }

            return top;
        }

        public static void setControl(Control control, double left, double right, double top, double bottom)
        {
            int formWidth = control.Parent.Width;
            int formHeight = control.Parent.Height;

            int xPos = Convert.ToInt32(formWidth * left);
            int yPos = Convert.ToInt32(formHeight * top);
            int width = Convert.ToInt32(formWidth * right) - xPos;
            int height = Convert.ToInt32(formHeight * bottom) - yPos;

            control.Location = new Point(xPos, yPos);
            control.Size = new Size(width, height);
        }

        public static void setNestedControlPosition(Control control, double left, double right, double top, double bottom)
        {
            int formWidth = control.Parent.Parent.Width;
            int formHeight = control.Parent.Parent.Height;

            int xPos = Convert.ToInt32(formWidth * left);
            int yPos = Convert.ToInt32(formHeight * top);
            int width = Convert.ToInt32(formWidth * right) - xPos;
            int height = Convert.ToInt32(formHeight * bottom) - yPos;

            control.Location = new Point(xPos, yPos);
            control.Size = new Size(width, height);
        }

        public static void setNestedControlLocation(Control control, double x, double y)
        {
            int formWidth = control.Parent.Parent.Width;
            int formHeight = control.Parent.Parent.Height;

            int xPos = Convert.ToInt32(formWidth * x);
            int yPos = Convert.ToInt32(formHeight * y);

            control.Location = new Point(xPos, yPos);
        }

        public static void setControlLocation(Control control, double x, double y)
        {
            int formWidth = control.Parent.Width;
            int formHeight = control.Parent.Height;

            int xPos = Convert.ToInt32(formWidth * x);
            int yPos = Convert.ToInt32(formHeight * y);

            control.Location = new Point(xPos, yPos);
        }

        public static void setControlSize(Control control, double widthPercent, double heightPercent)
        {
            int formWidth = control.Parent.Width;
            int formHeight = control.Parent.Height;

            int width = Convert.ToInt32(formWidth * widthPercent);
            int height = Convert.ToInt32(formHeight * heightPercent);

            control.Size = new Size(width, height);
        }

        public static void setVertically(Control[] controls, Panel panel)
        {
            int numberOfControls = controls.Length;

            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            for (int i = 0; i < controls.Length; i++)
            {
                Control control = controls[i];

                control.Location = new Point(0, i * panelHeight / numberOfControls);

                control.Width = panelWidth;
                control.Height = panelHeight / numberOfControls;
            }
        }

        public static void setHorizontally(Control[] controls, Panel panel)
        {
            int numberOfControls = controls.Length;
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            for (int i = 0; i < controls.Length; i++)
            {
                Control control = controls[i];

                control.Location = new Point(i * panelHeight / numberOfControls, 0);

                control.Width = panelWidth / numberOfControls;
                control.Height = panelHeight;
            }
        }
    }
}
