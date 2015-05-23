using System;
using System.Windows.Forms;
using OpenCvSharp;
namespace 自作傷検出1
{
    public partial class 検査対象画像画面 : Form
    {
        IplImage 編集前;
        IplImage Canny実行後;
        public static IplImage 編集後;
        IplImage 表示中;
        private static 検査対象画像画面 _instance;

        public 検査対象画像画面()
        {
            
            InitializeComponent();
            if(編集前!=null)編集前.Dispose();
            編集前=メイン画面.検査対象画像.Clone();
            pictureBoxIpl1.Size = メイン画面.pictureBoxIplのサイズ調整(編集前);
            全て実行();
        }
        public static 検査対象画像画面 Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                    _instance = new 検査対象画像画面();
                return _instance;
            }
        }

        private void Canny実行()
        {


            IplImage sample = 編集前.Clone();

            Cv.Canny(sample, sample, trackBar_CannyTH1.Value, trackBar_CannyTH2.Value);
            Canny実行後 = sample.Clone();
            表示中 = sample.Clone();

            pictureBoxIpl1.ImageIpl = 表示中;

            sample.Dispose();


        }
        private void Close実行()
        {
            if (Canny実行後 != null)
            {
                IplConvKernel element = Cv.CreateStructuringElementEx(trackBar_CloseSize.Value, trackBar_CloseSize.Value, trackBar_CloseSize.Value / 2, trackBar_CloseSize.Value / 2, ElementShape.Rect);
                IplImage temp = Canny実行後.Clone();
                IplImage sample = Canny実行後.Clone();
                Cv.MorphologyEx(sample, sample, temp, element, MorphologyOperation.Close, trackBar_CloseNum.Value);
                編集後 = sample.Clone();
                表示中 = sample.Clone();
                pictureBoxIpl1.ImageIpl = 表示中;
                sample.Dispose();
                temp.Dispose();
                element.Dispose();
            }
        }
        private void 全て実行()
        {
            Canny実行();
            Close実行();
        }
        private void MouseMove_pictureBoxIpl1(object sender, MouseEventArgs e)
        {
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            System.Drawing.Point cp = this.PointToClient(sp);
            label_座標.Text = "(" + (cp.X - pictureBoxIpl1.Location.X) + "," + (cp.Y - pictureBoxIpl1.Location.Y) + ")";
        }

        private void OnClick_pictureBoxIpl1(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);
                CvColor c = pictureBoxIpl1.ImageIpl[cp.Y - pictureBoxIpl1.Location.Y, cp.X - pictureBoxIpl1.Location.X];
                色.Text = "" + c.B;
                textBox_x.Text = "" + (cp.X - pictureBoxIpl1.Location.X);
                textBox_y.Text = "" + (cp.Y - pictureBoxIpl1.Location.Y);
            }
        }

        private void TextChanged_x(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                double isnumber_x, isnumber_y;
                if (double.TryParse(textBox_x.Text, out isnumber_x) && double.TryParse(textBox_y.Text, out isnumber_y))
                    if ((isnumber_x >= 0 && isnumber_x <= pictureBoxIpl1.ImageIpl.Width) && (isnumber_y >= 0 && isnumber_y <= pictureBoxIpl1.ImageIpl.Height))
                    {
                        CvColor c = pictureBoxIpl1.ImageIpl[(int)isnumber_y, (int)isnumber_x];
                        色.Text = "" + c.B;
                        //クライアント座標を画面座標に変換する
                        System.Drawing.Point mp = this.PointToScreen(new System.Drawing.Point((int)isnumber_x + pictureBoxIpl1.Location.X, (int)isnumber_y + pictureBoxIpl1.Location.Y));
                        //マウスポインタの位置を設定する
                        System.Windows.Forms.Cursor.Position = mp;
                    }
            }
        }

        private void TextChanged_y(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                double isnumber_x, isnumber_y;
                if (double.TryParse(textBox_x.Text, out isnumber_x) && double.TryParse(textBox_y.Text, out isnumber_y))
                    if ((isnumber_x >= 0 && isnumber_x <= pictureBoxIpl1.ImageIpl.Width) && (isnumber_y >= 0 && isnumber_y <= pictureBoxIpl1.ImageIpl.Height))
                    {
                        CvColor c = pictureBoxIpl1.ImageIpl[(int)isnumber_y, (int)isnumber_x];
                        色.Text = "" + c.B;
                        //クライアント座標を画面座標に変換する
                        System.Drawing.Point mp = this.PointToScreen(new System.Drawing.Point((int)isnumber_x + pictureBoxIpl1.Location.X, (int)isnumber_y + pictureBoxIpl1.Location.Y));
                        //マウスポインタの位置を設定する
                        System.Windows.Forms.Cursor.Position = mp;
                    }
            }
        }


        private void OnClickCanny実行ボタン(object sender, EventArgs e)
        {
            Canny実行();
        }

        private void Scroll_CannyTH2(object sender, EventArgs e)
        {
            textBox_CannyTH2.Text = trackBar_CannyTH2.Value.ToString();
            Canny実行();
        }

        private void Scroll_CannyTH1(object sender, EventArgs e)
        {
            textBox_CannyTH1.Text = trackBar_CannyTH1.Value.ToString();
            Canny実行();
        }

        private void TextChanged_CannyTH1(object sender, EventArgs e)
        {
            double isnumber;
            if (double.TryParse(textBox_CannyTH1.Text, out isnumber))
            {
                if (isnumber >= trackBar_CannyTH1.Minimum && isnumber <= trackBar_CannyTH1.Maximum)
                {
                    trackBar_CannyTH1.Value = (int)isnumber;
                    Canny実行();
                }
            }
            
        }

        private void TextChanged_CannyTH2(object sender, EventArgs e)
        {
            double isnumber;
            if (double.TryParse(textBox_CannyTH2.Text, out isnumber))
            {
                if (isnumber >= trackBar_CannyTH2.Minimum && isnumber <= trackBar_CannyTH2.Maximum)
                {
                    trackBar_CannyTH2.Value = (int)isnumber;
                    Canny実行();
                }
            }

        }



        private void TextChanged_CloseSize(object sender, EventArgs e)
        {
            double isnumber;
            if (double.TryParse(textBox_CloseSize.Text, out isnumber))
            {
                if (isnumber >= trackBar_CloseSize.Minimum && isnumber <= trackBar_CloseSize.Maximum)
                {
                    trackBar_CloseSize.Value = (int)isnumber;
                    Close実行();
                }
            }
        }

        private void TextChanged_CloseNum(object sender, EventArgs e)
        {
            double isnumber;
            if (double.TryParse(textBox_CloseNum.Text, out isnumber))
            {
                if (isnumber >= trackBar_CloseNum.Minimum && isnumber <= trackBar_CloseNum.Maximum)
                {
                    trackBar_CloseNum.Value = (int)isnumber;
                    Close実行();
                }
            }
        }

        private void Scroll_CloseSize(object sender, EventArgs e)
        {
            textBox_CloseSize.Text = trackBar_CloseSize.Value.ToString();
            Close実行();
        }

        private void Scroll_CloseNum(object sender, EventArgs e)
        {
            textBox_CloseNum.Text = trackBar_CloseNum.Value.ToString();
            Close実行();
        }

        private void OnClick全て実行ボタン(object sender, EventArgs e)
        {
            全て実行();
        }


    }


}
