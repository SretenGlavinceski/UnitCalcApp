using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class CylinderDrawer
{
    private int radius;
    private int height;

    public CylinderDrawer(double volume)
    {
        // Calculate the radius and height from the volume
        // Volume of a cylinder: V = π r^2 h
        // For simplicity, assume h = 2r (height = diameter)
        // Volume = π r^2 * 2r = 2π r^3
        // r = (V / (2π))^(1/3)
        this.radius = (int)Math.Pow(volume / (2 * Math.PI), 1.0 / 3.0);
        this.height = 2 * this.radius; // Assuming height = 2 * radius
    }

    public void DrawCylinder(Graphics g, PointF origin)
    {
        if (g == null)
        {
            throw new ArgumentNullException(nameof(g));
        }

        // Draw the top ellipse
        RectangleF topEllipse = new RectangleF(
            origin.X - radius,
            origin.Y - height / 2,
            2 * radius,
            radius
        );

        using (Brush brush = new LinearGradientBrush(topEllipse, Color.LightGray, Color.Gray, LinearGradientMode.Vertical))
        {
            g.FillEllipse(brush, topEllipse);
        }
        g.DrawEllipse(Pens.Black, topEllipse);

        // Draw the bottom ellipse
        RectangleF bottomEllipse = new RectangleF(
            origin.X - radius,
            origin.Y + height / 2 - radius,
            2 * radius,
            radius
        );

        using (Brush brush = new LinearGradientBrush(bottomEllipse, Color.Gray, Color.DarkGray, LinearGradientMode.Vertical))
        {
            g.FillEllipse(brush, bottomEllipse);
        }
        g.DrawEllipse(Pens.Black, bottomEllipse);

        // Draw the side rectangles with gradient shading
        RectangleF leftSide = new RectangleF(
            origin.X - radius,
            origin.Y - height / 2 + radius / 2,
            radius,
            height - radius
        );

        RectangleF rightSide = new RectangleF(
            origin.X,
            origin.Y - height / 2 + radius / 2,
            radius,
            height - radius
        );

        using (Brush brush = new LinearGradientBrush(leftSide, Color.LightGray, Color.Gray, LinearGradientMode.Horizontal))
        {
            g.FillRectangle(brush, leftSide);
        }

        using (Brush brush = new LinearGradientBrush(rightSide, Color.Gray, Color.DarkGray, LinearGradientMode.Horizontal))
        {
            g.FillRectangle(brush, rightSide);
        }

        g.DrawRectangle(Pens.Black, Rectangle.Round(leftSide));
        g.DrawRectangle(Pens.Black, Rectangle.Round(rightSide));
    }
}
