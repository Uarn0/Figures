using Figures;

public class Square : Figure
{
    public int SideLength { get; set; }

    public Square(int centerX, int centerY, int sideLength) : base(centerX, centerY)
    {
        SideLength = sideLength;
    }

    public override void DrawBlack(Graphics g)
    {
        int half = SideLength / 2;
        g.DrawRectangle(Pens.Black, CenterX - half, CenterY - half, SideLength, SideLength);
    }

    public override void HideDrawingBackGround(Graphics g, Color backColor)
    {
        float factor = 1.1f;
        int half = (int)(SideLength * factor / 2);

        g.FillRectangle(new SolidBrush(backColor),
                        CenterX - half,
                        CenterY - half,
                        (int)(SideLength * factor),
                        (int)(SideLength * factor));
    }

}
