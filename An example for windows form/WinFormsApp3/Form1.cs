//---------------------- Student Name:Yiğit Sancar
//---------------------- Student No:B221202025


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Polygon polygon; // Declare a variable to store the polygon

        public Form1()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Define a Point2D class to represent 2D points
        public class Point2D
        {
            public double X { get; set; } // X coordinate
            public double Y { get; set; } // Y coordinate

            // Default constructor with no parameters
            public Point2D() : this(0, 0) { }

            // Constructor with X and Y coordinates as parameters
            public Point2D(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        // Define a Polygon class to represent a polygon
        public class Polygon
        {
            private Point2D center; // Center point of the polygon
            private double length; // Length of each edge
            private int numberOfEdges; // Number of edges in the polygon
            private List<Point2D> edgeCoordinates; // List to store edge coordinates

            // Constructor to initialize the polygon with center, length, and number of edges
            public Polygon(Point2D center, double length, int numberOfEdges)
            {
                this.center = center;
                this.length = length;
                this.numberOfEdges = numberOfEdges;
                CalculateEdgeCoordinates(); // Calculate edge coordinates
            }

            // Method to calculate edge coordinates of the polygon
            public List<Point2D> CalculateEdgeCoordinates()
            {
                edgeCoordinates = new List<Point2D>(); // Initialize edge coordinates list
                double angleIncrement = 360.0 / numberOfEdges; // Calculate angle increment

                double currentAngle = 0;
                for (int i = 0; i < numberOfEdges; i++)
                {
                    double radians = currentAngle * (Math.PI / 180); // Convert angle to radians
                    double x = center.X + (length * Math.Cos(radians)); // Calculate X coordinate
                    double y = center.Y + (length * Math.Sin(radians)); // Calculate Y coordinate
                    edgeCoordinates.Add(new Point2D(x, y)); // Add the point to edge coordinates list
                    currentAngle += angleIncrement; // Increment the angle
                }

                return edgeCoordinates; // Return the edge coordinates list
            }

            // Method to rotate the polygon by a given rotation angle
            public void RotatePolygon(double rotationAngle)
            {
                if (edgeCoordinates != null)
                {
                    double radians = -rotationAngle * (Math.PI / 180); // Convert rotation angle to radians (negative for clockwise rotation)

                    for (int i = 0; i < edgeCoordinates.Count; i++)
                    {
                        // Translate point to origin relative to the center
                        double translatedX = edgeCoordinates[i].X - center.X;
                        double translatedY = edgeCoordinates[i].Y - center.Y;

                        // Apply rotation
                        double rotatedX = translatedX * Math.Cos(radians) - translatedY * Math.Sin(radians);
                        double rotatedY = translatedX * Math.Sin(radians) + translatedY * Math.Cos(radians);

                        // Translate back to the original center
                        edgeCoordinates[i] = new Point2D(center.X + rotatedX, center.Y + rotatedY);
                    }
                }
            }

            // Method to get the edge coordinates of the polygon
            public List<Point2D> GetEdgeCoordinates()
            {
                return edgeCoordinates; // Return the edge coordinates list
            }
        }

        // Event handler for the Randomize button click
        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // Create a new random object
            textBoxCenterX.Text = random.Next(0, 4).ToString(); // Generate random X coordinate for center
            textBoxCenterY.Text = random.Next(0, 4).ToString(); // Generate random Y coordinate for center
            textBoxLength.Text = random.Next(3, 10).ToString(); // Generate random length
            textBoxNumberOfEdges.Text = random.Next(3, 11).ToString(); // Generate random number of edges
            textBoxRotationAngle.Text = random.Next(0, 360).ToString(); // Generate random rotation angle
        }

        // Event handler for the Draw button click
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from TextBoxes
                double centerX = double.Parse(textBoxCenterX.Text);
                double centerY = double.Parse(textBoxCenterY.Text);
                double length = double.Parse(textBoxLength.Text);
                int numberOfEdges = int.Parse(textBoxNumberOfEdges.Text);

                // Create the polygon and calculate edge coordinates
                Point2D center = new Point2D(centerX, centerY);
                polygon = new Polygon(center, length, numberOfEdges);

                // Clear and populate the ListBox with edge coordinates
                listBoxEdgeCoordinates.Items.Clear();
                List<Point2D> edgeCoordinates = polygon.CalculateEdgeCoordinates();
                foreach (Point2D point in edgeCoordinates)
                {
                    listBoxEdgeCoordinates.Items.Add($"({point.X}, {point.Y})");
                }

                // Draw the polygon on the PictureBox
                DrawPolygonOnPictureBox();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numerical values."); // Show error message for invalid input
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        // Method to draw the polygon on the PictureBox
        private void DrawPolygonOnPictureBox()
        {
            if (polygon != null)
            {
                Graphics graphics = pictureBox.CreateGraphics(); // Create graphics object for the PictureBox
                graphics.Clear(Color.White); // Clear the PictureBox

                List<Point2D> edgeCoordinates = polygon.GetEdgeCoordinates(); // Get edge coordinates of the polygon
                Point[] points = new Point[edgeCoordinates.Count]; // Create an array to store points for drawing

                // Center the polygon in the PictureBox. I want in in the middle so:
                double centerX = (pictureBox.Width / 2) ;
                double centerY = (pictureBox.Height / 2);

                for (int i = 0; i < edgeCoordinates.Count; i++)
                {
                    double originalX = edgeCoordinates[i].X;
                    double originalY = edgeCoordinates[i].Y;
                    // Scale and translate the coordinates 
                    double scaledX = centerX + double.Parse(textBoxCenterX.Text) + (originalX - polygon.GetEdgeCoordinates()[0].X) * 10;
                    double scaledY = centerY - double.Parse(textBoxCenterY.Text) - (originalY - polygon.GetEdgeCoordinates()[0].Y) * 10;
                    points[i] = new Point((int)scaledX, (int)scaledY); // Store the scaled point
                }
                graphics.DrawPolygon(Pens.Black, points); // Draw the polygon using the scaled points
            }
        }

       
        // Event handler for the Rotate button click
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (polygon != null)
            {
                try
                {
                    int rotationAngle = int.Parse(textBoxRotationAngle.Text); // Get rotation angle from TextBox
                    polygon.RotatePolygon(rotationAngle); // Rotate the polygon

                    // Update edge coordinates and redraw the polygon
                    listBoxEdgeCoordinates.Items.Clear(); // Clear the ListBox
                    List<Point2D> edgeCoordinates = polygon.GetEdgeCoordinates(); // Get updated edge coordinates
                    foreach (Point2D point in edgeCoordinates)
                    {
                        listBoxEdgeCoordinates.Items.Add($"({point.X}, {point.Y})"); // Populate the ListBox
                    }

                    DrawPolygonOnPictureBox(); // Redraw the polygon on the PictureBox
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid rotation angle. Please enter a valid number."); // Show error message for invalid input
                }
            }
        }

        // Event handler for the Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize TextBoxes with default values
            textBoxCenterX.Text = "0";
            textBoxCenterY.Text = "0";
            textBoxLength.Text = "4";
            textBoxNumberOfEdges.Text = "5";
            textBoxRotationAngle.Text = "30";
        }
    }
}