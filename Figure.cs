using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public abstract class Figure
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }

        protected Figure(int centerX, int centerY)
        {
            CenterX = centerX;
            CenterY = centerY;
        }

        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackGround(Graphics g, Color backColor);

        public void MoveRight(Graphics g, Color backColor, int distance, int step = 5, int interval = 20)
        {
            int targetX = CenterX + distance;
            System.Windows.Forms.Timer moveTimer = new System.Windows.Forms.Timer
            {
                Interval = interval
            };

            moveTimer.Tick += (sender, e) =>
            {
                HideDrawingBackGround(g, backColor);

                if (CenterX < targetX)
                {
                    CenterX += step;
                    if (CenterX > targetX)
                        CenterX = targetX;
                }
                else
                {
                    moveTimer.Stop();
                }

                DrawBlack(g);
            };

            moveTimer.Start();
        }
    }
}
