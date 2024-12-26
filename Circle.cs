using Figures;

public class Circle : Figure
{
    public int Radius { get; set; }

    public Circle(int centerX, int centerY, int radius) : base(centerX, centerY)
    {
        Radius = radius;
    }

    public override void DrawBlack(Graphics g)
    {
        g.DrawEllipse(Pens.Black, CenterX - Radius, CenterY - Radius, Radius * 2, Radius * 2);
    }

    public override void HideDrawingBackGround(Graphics g, Color backColor)
    {
        float factor = 1.1f;
        int increasedRadius = (int)(Radius * factor);

        g.FillEllipse(new SolidBrush(backColor),
                      CenterX - increasedRadius,
                      CenterY - increasedRadius,
                      increasedRadius * 2,
                      increasedRadius * 2);
    }

}
