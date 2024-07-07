using System;
using System.Drawing;

public class CubeDrawer
{
    private int side;

    public CubeDrawer(double volume)
    {
        // Calculate the side length from the volume
        this.side = (int)Math.Pow(volume, 1.0 / 3.0);
    }

    public void DrawCube(Graphics g, PointF origin)
    {
        if (g == null)
        {
            throw new ArgumentNullException(nameof(g));
        }

        // Define the points of the cube
        PointF[] frontFace =
        {
            new PointF(origin.X, origin.Y),
            new PointF(origin.X + side, origin.Y),
            new PointF(origin.X + side, origin.Y + side),
            new PointF(origin.X, origin.Y + side)
        };

        PointF[] backFace =
        {
            new PointF(origin.X + side / 2, origin.Y - side / 2),
            new PointF(origin.X + side + side / 2, origin.Y - side / 2),
            new PointF(origin.X + side + side / 2, origin.Y + side - side / 2),
            new PointF(origin.X + side / 2, origin.Y + side - side / 2)
        };

        // Draw the front face
        g.DrawPolygon(Pens.Black, frontFace);
        // Draw the back face
        g.DrawPolygon(Pens.Black, backFace);

        // Draw the connecting lines
        for (int i = 0; i < 4; i++)
        {
            g.DrawLine(Pens.Black, frontFace[i], backFace[i]);
        }
    }
}
