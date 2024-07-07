using System;
using System.Drawing;

public class PyramidDrawer
{
    private int baseLength;
    private int height;

    public PyramidDrawer(double volume)
    {
        // Calculate the base length and height from the volume
        // Volume of a pyramid: V = (1/3) * baseArea * height
        // For simplicity, assume height = baseLength (square base)
        // Volume = (1/3) * baseLength^2 * height = (1/3) * baseLength^3
        // baseLength = (3 * volume)^(1/3)
        this.baseLength = (int)Math.Pow(3 * volume, 1.0 / 3.0);
        this.height = this.baseLength; // Assuming height = baseLength for simplicity
    }

    public void DrawPyramid(Graphics g, PointF origin)
    {
        if (g == null)
        {
            throw new ArgumentNullException(nameof(g));
        }

        // Calculate the points of the pyramid
        PointF[] basePoints = new PointF[]
        {
            new PointF(origin.X - baseLength / 2, origin.Y + baseLength / 2),
            new PointF(origin.X + baseLength / 2, origin.Y + baseLength / 2),
            new PointF(origin.X + baseLength / 2, origin.Y - baseLength / 2),
            new PointF(origin.X - baseLength / 2, origin.Y - baseLength / 2)
        };

        PointF apex = new PointF(origin.X, origin.Y - height);

        // Draw the base
        g.DrawPolygon(Pens.Black, basePoints);

        // Draw the triangular faces with shading
        for (int i = 0; i < 4; i++)
        {
            PointF[] facePoints = new PointF[]
            {
                basePoints[i],
                basePoints[(i + 1) % 4],
                apex
            };

            int alpha = 128 + (i * 32); // Vary the transparency for shading effect
            using (Brush brush = new SolidBrush(Color.FromArgb(alpha, Color.Gray)))
            {
                g.FillPolygon(brush, facePoints);
            }

            g.DrawPolygon(Pens.Black, facePoints);
        }
    }
}
