using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph = System.Windows.Forms.DataVisualization.Charting;

namespace TestFormApplication
{
    public partial class Form1 : Form
    {
        public const int MaxX = 20;

        public Form1()
        {
            InitializeComponent();
            chart.Series.Add("MyFunc");
            // Set the type to line      
            chart.Series["MyFunc"].ChartType = Graph.SeriesChartType.Line;
            // Color the line of the graph light green and give it a thickness of 3
            chart.Series["MyFunc"].Color = Color.Black;
            chart.Series["MyFunc"].BorderWidth = 2;

            chart.Series["MyFunc"].LegendText = "sin(x) / x";
            // Create a new legend called "MyLegend".
            chart.Legends.Add("MyLegend");
            chart.Legends["MyLegend"].BorderColor = Color.Tomato; // I like tomato juice!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString());

            // Add a chartarea called "draw", add axes to it and color the area black
            //chart.ChartAreas.Add("draw");
            //chart.ChartAreas["draw"].AxisX.Minimum = 0;
            //chart.ChartAreas["draw"].AxisX.Maximum = MaxX;
            //chart.ChartAreas["draw"].AxisX.Interval = 1;
            //chart.ChartAreas["draw"].AxisX.MajorGrid.LineColor = Color.White;
            //chart.ChartAreas["draw"].AxisX.MajorGrid.LineDashStyle = Graph.ChartDashStyle.Dash;
            //chart.ChartAreas["draw"].AxisY.Minimum = -0.4;
            //chart.ChartAreas["draw"].AxisY.Maximum = 1;
            //chart.ChartAreas["draw"].AxisY.Interval = 0.2;
            //chart.ChartAreas["draw"].AxisY.MajorGrid.LineColor = Color.White;
            //chart.ChartAreas["draw"].AxisY.MajorGrid.LineDashStyle = Graph.ChartDashStyle.Dash;

            //chart.ChartAreas["draw"].BackColor = Color.Azure;

            // Create a new function series


            chart.Series["MyFunc"].Points.Clear();
            Random rnd = new Random();

            //This function cannot include zero, and we walk through it in steps of 0.1 to add coordinates to our series
            for (double x = 0.1; x < MaxX; x += 0.1)
            {
                //chart.Series["MyFunc"].Points.AddXY(x, Math.Sin(x) / x);
                
                int val = rnd.Next(0, 10);
                //chart.Series["MyFunc"].Points.AddXY(x, val);
                chart.Series["MyFunc"].Points.AddXY(x, 1/x);
                Console.WriteLine(val);
            }


        }
    }
}
