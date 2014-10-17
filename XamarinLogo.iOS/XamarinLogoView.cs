using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;
using System.ComponentModel;

namespace XamarinLogo
{
    [Register("XamarinLogoView"), DesignTimeVisible(true)]
    public class XamarinLogoView : UIView
    {
        #region constructor
        public XamarinLogoView ()
        {
        }

        public XamarinLogoView (IntPtr handle) : base (handle)
        {
            Initialize ();
        }

        private void Initialize ()
        {
        }
        #endregion

        public override void Draw(RectangleF rect)
        {
            var xamarinBlue = UIColor.FromRGBA(0.071f, 0.463f, 0.725f, 1.000f);

            UIBezierPath xamarinLogoPath = new UIBezierPath();
            xamarinLogoPath.MoveTo(new PointF(230.49f, 92.68f));
            xamarinLogoPath.AddLineTo(new PointF(200.74f, 92.68f));
            xamarinLogoPath.AddLineTo(new PointF(159.7f, 167.71f));
            xamarinLogoPath.AddLineTo(new PointF(200.74f, 242.73f));
            xamarinLogoPath.AddLineTo(new PointF(230.49f, 242.73f));
            xamarinLogoPath.AddLineTo(new PointF(191.23f, 167.71f));
            xamarinLogoPath.AddLineTo(new PointF(230.49f, 92.68f));
            xamarinLogoPath.ClosePath();
            xamarinLogoPath.MoveTo(new PointF(118.66f, 92.68f));
            xamarinLogoPath.AddLineTo(new PointF(88.92f, 92.68f));
            xamarinLogoPath.AddLineTo(new PointF(128.18f, 167.71f));
            xamarinLogoPath.AddLineTo(new PointF(88.92f, 242.73f));
            xamarinLogoPath.AddLineTo(new PointF(118.66f, 242.73f));
            xamarinLogoPath.AddLineTo(new PointF(159.7f, 167.71f));
            xamarinLogoPath.AddLineTo(new PointF(118.66f, 92.68f));
            xamarinLogoPath.ClosePath();
            xamarinLogoPath.MoveTo(new PointF(220.7f, 37.0f));
            xamarinLogoPath.AddCurveToPoint(new PointF(232.55f, 41.1f), new PointF(220.7f, 37.0f), new PointF(227.07f, 38.03f));
            xamarinLogoPath.AddCurveToPoint(new PointF(242.62f, 49.31f), new PointF(238.03f, 44.18f), new PointF(242.62f, 49.31f));
            xamarinLogoPath.AddLineTo(new PointF(304.22f, 152.47f));
            xamarinLogoPath.AddCurveToPoint(new PointF(308.95f, 170.05f), new PointF(304.22f, 152.47f), new PointF(309.55f, 163.02f));
            xamarinLogoPath.AddCurveToPoint(new PointF(304.22f, 183.53f), new PointF(308.36f, 177.09f), new PointF(304.22f, 183.53f));
            xamarinLogoPath.AddLineTo(new PointF(243.57f, 286.11f));
            xamarinLogoPath.AddCurveToPoint(new PointF(234.05f, 294.31f), new PointF(243.57f, 286.11f), new PointF(239.7f, 291.09f));
            xamarinLogoPath.AddCurveToPoint(new PointF(220.97f, 299.0f), new PointF(228.4f, 297.53f), new PointF(220.97f, 299.0f));
            xamarinLogoPath.AddLineTo(new PointF(97.25f, 299.0f));
            xamarinLogoPath.AddCurveToPoint(new PointF(84.16f, 294.31f), new PointF(97.25f, 299.0f), new PointF(89.51f, 297.53f));
            xamarinLogoPath.AddCurveToPoint(new PointF(75.83f, 286.11f), new PointF(78.81f, 291.09f), new PointF(75.83f, 286.11f));
            xamarinLogoPath.AddLineTo(new PointF(13.99f, 181.77f));
            xamarinLogoPath.AddCurveToPoint(new PointF(11.03f, 170.05f), new PointF(13.99f, 181.77f), new PointF(11.33f, 176.21f));
            xamarinLogoPath.AddCurveToPoint(new PointF(12.81f, 157.16f), new PointF(10.73f, 163.9f), new PointF(12.81f, 157.16f));
            xamarinLogoPath.AddLineTo(new PointF(75.59f, 49.31f));
            xamarinLogoPath.AddCurveToPoint(new PointF(85.07f, 41.1f), new PointF(75.59f, 49.31f), new PointF(79.59f, 44.18f));
            xamarinLogoPath.AddCurveToPoint(new PointF(97.5f, 37.0f), new PointF(90.54f, 38.03f), new PointF(97.5f, 37.0f));
            xamarinLogoPath.AddLineTo(new PointF(220.7f, 37.0f));
            xamarinLogoPath.AddLineTo(new PointF(220.7f, 37.0f));
            xamarinLogoPath.ClosePath();
            xamarinBlue.SetFill();
            xamarinLogoPath.Fill();

        }
    }
}

