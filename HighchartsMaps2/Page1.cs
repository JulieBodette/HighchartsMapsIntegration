using System;
using System.Drawing;
using System.Dynamic;
using System.IO;
using Wisej.Web;
//using static System.Net.Mime.MediaTypeNames;


namespace HighchartsMaps2
{
    public partial class Page1 : Page
    {
        public int[][] continentCoordinatesArray = new int[7][];//has 4 elements, each of which is a single-dimensional array of integers:
       

public int index = 0;
        public Page1()
        {
            InitializeComponent();
            continentCoordinatesArray[0] = new int[] { -21, 0 }; //africa
            continentCoordinatesArray[1] = new int[] { 5, -43 };//europe
            continentCoordinatesArray[2] = new int[] { -94, -27 };//asia
            continentCoordinatesArray[3] = new int[] { -108, 21 }; //australia
            continentCoordinatesArray[4] = new int[] { 50, -96 }; //arctic
            continentCoordinatesArray[5] = new int[] { 110, -33 };//north america
            continentCoordinatesArray[6] = new int[] { 57, 2 }; //south america
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            //set the chart title
            this.widget1.Options.title = new
            {
                text = "Airport density per country",
                floating=true,
                align="left",
                style = new
                {
                    textOutline = "2px white"
                }
            };
            this.widget1.Options.subtitle = new
            {
                text = "Source: <a href=\"http://www.citypopulation.de/en/world/bymap/airports/\">citypopulation.de</a><br>" + "Click and drag to rotate globe<br>",
                floating = true,
                y=34,
                align="left"
            };
            this.widget1.Options.legend = new
            {
                enabled = false
            };
            this.widget1.Options.chart = new
            {
                map = getTopology()
            };

            this.widget1.Options.mapNavigation = new
            {
                enabled = true,
                enableDoubleClickZoomTo = true,
                buttonOptions = new
                {
                    verticalAlign= "bottom"
                }

            };
            this.widget1.Options.mapView = new
            {
                maxZoom = 30,
                projection = new
                {
                    name= "Orthographic",
                    rotation= new[] {60, -30}
            }
            };
            this.widget1.Options.colorAxis = new
            {
                tickPixelInterval = 100,
                minColor = "#BFCFAD",
                maxColor = "#31784B",
                max = 1000
            };
            this.widget1.Options.series = new dynamic[]
            {
                new
                {
                    name = "Graticule",
                    id = "graticule",
                    type = "mapline",
                    data = new dynamic[] { },
                    nullColor = "rgba(11,127,171,0.5",
                    accessibility = new
                    {
                        enabled = false
                    },
                    enableMouseTracking= false
                },
                new
                {
                    data = getData(),
                    joinBy="name",
                    name="Airports per million km^2",
                    states = new
                    {
                        hover = new
                        {
                            color ="#a4edba", //green
                            borderColor="#000000" //black
                        }
                    },
                    dataLabels = new
                    {
                        enabled = false,
                        format = "{point.name}"
                    }
                }

            };
        }

        private object getTopology()
        {
            var json = File.ReadAllText(Application.MapPath("world.topo.json"));
            return JSON.Parse(json);
        }

        private object getData()
        {
            var json = File.ReadAllText(Application.MapPath("airportdata.json"));
            return JSON.Parse(json).airportData; //gotta parse it into an object, then we can access airportData from it
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //australia
            int[] rotation = new[] { -108, 21 };
            this.widget1.Call("rotateMap", rotation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Arctic
            int[] rotation = new[] { 50, -96 };
            this.widget1.Call("rotateMap", rotation);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //south america
            int[] rotation = new[] { 57, 2 };
            this.widget1.Call("rotateMap", rotation); 

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.widget1.Options.title = new
            {
                text = textBox1.Text,
                floating = true,
                align = "left",
                style = new
                {
                    textOutline = "2px white"
                }
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Africa
            int[] rotation = new[] { -21, 0 };
            this.widget1.Call("rotateMap", rotation);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //make continents red
            this.widget1.Options.colorAxis = new
            {
                tickPixelInterval = 100,
                minColor = "#F88379",
                maxColor = "#C41E3A",
                max = 1000
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //make continents green
            this.widget1.Options.colorAxis = new
            {
                tickPixelInterval = 100,
                minColor = "#BFCFAD",
                maxColor = "#31784B",
                max = 1000
            };
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //auto switch continents
            AlertBox.Show("Beginning continent switching...");
            Timer timer = new Timer();
            timer.Interval = 1000; //1 second
            timer.Tick += SwitchContinent;
            timer.Start();


        }

        public void SwitchContinent(object sender, EventArgs e)
        {

            int[] coords = continentCoordinatesArray[index];//coordinates of the current continent to show
            index += 1;
            if(index > continentCoordinatesArray.Length -1)
            {
                index = 0;//reset the loop
            }

            //move the map to the coords of curent continent
            this.widget1.Call("rotateMap", coords);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //north america
            int[] rotation = new[] { 110, -33 };
            this.widget1.Call("rotateMap", rotation);
        }
    }
}
