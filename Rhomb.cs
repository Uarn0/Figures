using Figures;

public class Rhomb : Figure
{
    public int HorDiagLen { get; set; }
    public int VertDiagLen { get; set; }

    public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen) : base(centerX, centerY)
    {
        HorDiagLen = horDiagLen;
        VertDiagLen = vertDiagLen;
    }

    public override void DrawBlack(Graphics g)
    {
        Point[] points =
        {
            new Point(CenterX, CenterY - VertDiagLen / 2),
            new Point(CenterX + HorDiagLen / 2, CenterY),
            new Point(CenterX, CenterY + VertDiagLen / 2),
            new Point(CenterX - HorDiagLen / 2, CenterY)
        };
        g.DrawPolygon(Pens.Black, points);
    }

    public override void HideDrawingBackGround(Graphics g, Color backColor)
    {
        float factor = 1.1f;
        int increasedHorDiag = (int)(HorDiagLen * factor);
        int increasedVertDiag = (int)(VertDiagLen * factor);

        Point[] points =
        {
        new Point(CenterX, CenterY - increasedVertDiag / 2),
        new Point(CenterX + increasedHorDiag / 2, CenterY),
        new Point(CenterX, CenterY + increasedVertDiag / 2),
        new Point(CenterX - increasedHorDiag / 2, CenterY)
    };

        g.FillPolygon(new SolidBrush(backColor), points);
    }

}
