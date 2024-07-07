using System;
using System.Drawing;

public class SphereDrawer
{
    private int radius;

    public SphereDrawer(double volume)
    {
        // Calculate the radius from the volume
        this.radius = (int)Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
    }

    public void DrawSphere(Graphics g, PointF origin)
    {
        if (g == null)
        {
            throw new ArgumentNullException(nameof(g));
        }

        // Draw shaded concentric circles
        for (int i = radius; i > 0; i--)
        {
            int alpha = (int)(255 * (1 - (float)i / radius)); // Calculate alpha for transparency
            using (Brush brush = new SolidBrush(Color.FromArgb(alpha, Color.Gray)))
            {
                g.FillEllipse(brush, origin.X - i, origin.Y - i, 2 * i, 2 * i);
            }
        }

        // Draw the outline of the sphere
        g.DrawEllipse(Pens.Black, origin.X - radius, origin.Y - radius, 2 * radius, 2 * radius);
    }
}
