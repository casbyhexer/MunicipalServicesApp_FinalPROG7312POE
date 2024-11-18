using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure
{
    namespace MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure
    {
        public class GraphPanel : Panel
        {
            private Graph graph;

            public GraphPanel(Graph graph)
            {
                this.graph = graph;
                this.Paint += new PaintEventHandler(DrawGraph);
            }

            private void DrawGraph(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen edgePen = new Pen(Color.Black, 2);
                Brush nodeBrush = new SolidBrush(Color.Blue);
                Font font = new Font("Arial", 10);
                Font coordinateFont = new Font("Arial", 8);
                Pen axisPen = new Pen(Color.Gray, 1);

                // Scale factor for better distribution of nodes
                int scale = 50;

                // Draw Axes
                DrawAxes(g, axisPen);

                // Example: Draw nodes and edges
                foreach (var vertex in graph.GetAllVertices())  // Using GetAllVertices method
                {
                    // Calculate X and Y coordinates for the node
                    int x = vertex.RequestId * scale + 50;  // Scale the X position
                    int y = 100 + (vertex.RequestId * scale);  // Scale the Y position

                    // Draw node (request) as a circle (blue)
                    g.FillEllipse(nodeBrush, x, y, 30, 30);  // Position nodes using X and Y coordinates

                    // Draw edges (dependencies between requests)
                    foreach (var adjacent in graph.GetAdjacent(vertex.RequestId))
                    {
                        int adjX = adjacent * scale + 50;  // X coordinate of the adjacent node
                        int adjY = 100 + (adjacent * scale);  // Y coordinate of the adjacent node

                        // Draw line (edge) from vertex to adjacent node
                        g.DrawLine(edgePen, x + 15, y + 15, adjX + 15, adjY + 15); // Add +15 to center the circle
                    }

                    // Draw the label for the request ID
                    g.DrawString($"Request {vertex.RequestId}", font, Brushes.Black, x, y + 35);

                    // Label the coordinates next to the request point (the blue circle)
                    g.DrawString($"({x}, {y})", coordinateFont, Brushes.Black, x + 35, y + 10);  // Display (X, Y) coordinates next to the blue point
                }
            }

            // Method to draw X and Y Axes
            private void DrawAxes(Graphics g, Pen axisPen)
            {
                // Draw X axis (horizontal)
                g.DrawLine(axisPen, 50, 50, 50 + (graph.GetAllVertices().Count * 50), 50); // Starting at (50, 50)

                // Draw Y axis (vertical)
                g.DrawLine(axisPen, 50, 50, 50, 50 + (graph.GetAllVertices().Count * 50)); // Starting at (50, 50)

                // Optional: Draw grid lines (horizontal and vertical) for better clarity
                for (int i = 1; i <= graph.GetAllVertices().Count; i++)
                {
                    // Draw vertical grid lines (X)
                    g.DrawLine(axisPen, 50 + (i * 50), 50, 50 + (i * 50), 50 + (graph.GetAllVertices().Count * 50));

                    // Draw horizontal grid lines (Y)
                    g.DrawLine(axisPen, 50, 50 + (i * 50), 50 + (graph.GetAllVertices().Count * 50), 50 + (i * 50));
                }
            }
        }
    }
}
