using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using System.Windows.Forms;


namespace tezcalisma
{
    public partial class Form1 : Form
    {
        int saniye = 0; int bitBoyut;
        int byteBoyut;
        int baslikBoyut;
        List<string> gizlenecekYerler = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create instance of video reader
            VideoFileReader reader = new VideoFileReader();
            // open video file           
            reader.Open(dosyaAdi);
            // check some of its attributes
            listBox1.Items.Add("Genişlik:  " + reader.Width);
            listBox1.Items.Add("Yükseklik: " + reader.Height);
            listBox1.Items.Add("fps:    " + reader.FrameRate);
            listBox1.Items.Add("codec:  " + reader.CodecName);
            int sure = (int)(reader.FrameCount / reader.FrameRate);
            this.Text = (reader.FrameCount / reader.FrameRate).ToString();

            for (int i = 0; i < sure; i++)
            {
                gizlenecekYerler.Add(i + ";");
            }

            label1.Left = pictureBox1.Left;
            label2.Left = pictureBox1.Left;

            label1.Top = pictureBox1.Top;
            label2.Top = pictureBox1.Top;

            label1.Width = pictureBox1.Width;
            label2.Height = pictureBox1.Height;

            //label1.Width = reader.Width+50;
            //label2.Height = reader.Height+50;
            //ilk frame i aldık
            Bitmap videoFrame = reader.ReadVideoFrame();
            pictureBox1.Image = (Image)videoFrame.Clone();
            videoFrame.Dispose();


            reader.Close();
            // read 100 video frames out of it

        }
        Bitmap istenilenGoruntu;
        private void SaniyedekiGoruntuyuAc(int saniye)
        {
            VideoFileReader reader = new VideoFileReader();
            reader.Open(dosyaAdi);
            Bitmap bitmap;
            int istenilenFrame = reader.FrameRate * saniye;
            istenilenGoruntu = new Bitmap(100, 100);
            for (int i = 0; i < istenilenFrame; i++)
            {
                Bitmap videoFrame = reader.ReadVideoFrame();
                if (i == (istenilenFrame - 1))
                    istenilenGoruntu = (Bitmap)videoFrame.Clone();
                videoFrame.Dispose();
            }

            reader.Close();
            //bitmap = new Bitmap(istenilenGoruntu);


            pictureBox1.Image = (Image)istenilenGoruntu;
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            label2.Left += (int)numericUpDown1.Value;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            label2.Left -= (int)numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = checkBox2.Checked;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sira = Convert.ToInt32(lblSaniye.Text);

            string veri = "" + sira + ";" + (checkBox3.Checked == true ? "1" : "0") + //maskeleme
                          ";" + (checkBox1.Checked == true ? "1" : "0") + //yatay
                          ";" + (checkBox2.Checked == true ? "1" : "0") + //dikey
                          ";" + (label1.Top - pictureBox1.Top) + //yatay üst
                          ";" + (radioButton1.Checked == true ? "1" : "0") + //üst
                          ";" + (label2.Left - pictureBox1.Left) +
                          ";" + (radioButton3.Checked == true ? "1" : "0");//sol

            if(pictureBox1.Controls.Count>0)
            {
                veri += ";" + pictureBox1.Controls.Count;
                for (int i = 0; i < pictureBox1.Controls.Count; i++)
                {
                    veri +=";" + pictureBox1.Controls[i].Left+ ";" + pictureBox1.Controls[i].Top+ ";" + pictureBox1.Controls[i].Width+ ";" + pictureBox1.Controls[i].Height;
                }
            }


            gizlenecekYerler[sira] = veri;             
           

            StreamWriter yaz = new StreamWriter("C:\\test\\yerler.txt", false);
            
            for (int i = 0; i < gizlenecekYerler.Count; i++)
                yaz.WriteLine(gizlenecekYerler[i]);
            yaz.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //label1üsttaraf
            //label2soltaraf
            if (checkBox3.Checked == false)
            {
                label1.Visible = false;
                label2.Visible = false;                

                return;
            }

            if (checkBox4.Checked)
            {
                if (checkBox1.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        label2.Left = pictureBox1.Left;
                        label1.Top = pictureBox1.Top;
                        label1.Width = pictureBox1.Width;
                        label1.Height = (label1.Top - pictureBox1.Top);
                        label1.Visible = true;
                    }
                    else
                    {
                        label1.Left = pictureBox1.Left;
                        label1.Top = label1.Top;
                        label1.Width = pictureBox1.Width;
                        label1.Height = pictureBox1.Height - (label1.Top - pictureBox1.Top);

                        label1.Visible = true;
                    }
                }
                else
                    label1.Visible = false;

                if (pictureBox1.Controls.Count > 0)
                {
                    for (int i = 0; i < pictureBox1.Controls.Count; i++)
                        pictureBox1.Controls[i].BackColor = Color.LightBlue;
                }
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;

                if (pictureBox1.Controls.Count > 0)
                {
                    for (int i = 0; i < pictureBox1.Controls.Count; i++)
                        pictureBox1.Controls[i].BackColor = Color.Transparent;
                }
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //------------------  

        private Bitmap Blur(Bitmap image, Int32 blurSize)
        {

            ////else
            //    a = label1.Top + 2;
            //if (radioButton2.Checked)
            //    b = 0;
            //else
            //    b = label2.Left + 2;

            // return Blur(image, new Rectangle(x, y, z, t), blurSize);
            return null;

        }

        private unsafe static Bitmap Blur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width - 200, image.Height - 100);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width - 200, image.Height - 100),
                    new Rectangle(0, 0, image.Width - 200, image.Height - 100), GraphicsUnit.Pixel);

            // Lock the bitmap's bits
            BitmapData blurredData = blurred.LockBits(new Rectangle(0, 0, image.Width - 200, image.Height - 100), ImageLockMode.ReadWrite, blurred.PixelFormat);

            // Get bits per pixel for current PixelFormat
            int bitsPerPixel = Image.GetPixelFormatSize(blurred.PixelFormat);

            // Get pointer to first line
            byte* scan0 = (byte*)blurredData.Scan0.ToPointer();

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width - 200); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height - 100); y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;

                            avgB += data[0]; // Blue
                            avgG += data[1]; // Green
                            avgR += data[2]; // Red

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width - 200 && x < rectangle.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height - 100 && y < rectangle.Height; y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;
                            //if (icindemi)
                            //{
                            // Change values
                            data[0] = (byte)avgB;
                            data[1] = (byte)avgG;
                            data[2] = (byte)avgR;
                            //}
                        }
                    }
                }
            }

            // Unlock the bits
            blurred.UnlockBits(blurredData);

            return blurred;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                int a = 0, b = 0, c = 0, d = 0;
                int x = 0, y = 0, z = 0, t = 0;
                a = Math.Abs(pictureBox1.Top - label1.Top);//üst mesafenin alan değeri
                b = Math.Abs(pictureBox1.Left - label2.Left);//sağ mesafenin alan değeri
                c = pictureBox1.Height - Math.Abs(pictureBox1.Top - label1.Top);//alt mesafenin alan değeri
                d = pictureBox1.Width - Math.Abs(pictureBox1.Left - label2.Left);//sol mesafenin alan değeri

                if (radioButton1.Checked && radioButton3.Checked)
                {
                    x = 0;//dikdörtgen sol üst
                    y = 0;//dikdörtgen sol üst
                    z = b;//boyut
                    t = a;//boyut
                    kapat(x, y, z, t);
                }
                if (radioButton1.Checked && radioButton4.Checked)
                {
                    x = b;
                    y = 0;
                    z = d;
                    t = a;
                    kapat(x, y, z, t);
                }
                if (radioButton2.Checked && radioButton3.Checked)
                {
                    x = 0;
                    y = a;
                    z = b;
                    t = c;
                    kapat(x, y, z, t);
                }
                if (radioButton2.Checked && radioButton4.Checked)
                {
                    x = b;
                    y = a;
                    z = d;
                    t = c;
                    kapat(x, y, z, t);
                }
                //var l2H=label1.Height;
                //var l2W=label1.Width;
                //var l2L = label2.Left;
                //var l2R = label2.Right;
                //Bitmap bitmap = Blur(istenilenGoruntu, 10);
                //pictureBox1.Image = (Image)bitmap;

            }
        }       

        

       

        

        public void kapat(int x, int y, int z, int t)//seçilen alanları kapatan metot
        {
            Rectangle d = new Rectangle(x, y, z, t);
            Brush b = new SolidBrush(Color.FromArgb(230, 0, 0, 0));
            pictureBox1.CreateGraphics().FillRectangle(b, d);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            label1.Top -= (int)numericUpDown1.Value;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            label1.Top += (int)numericUpDown1.Value;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            label2.Left += (int)numericUpDown1.Value;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            label2.Left -= (int)numericUpDown1.Value;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            saniye--;//geriye doğru görüntü gider
            if (saniye < 0)
                saniye = 1;

            SaniyedekiGoruntuyuAc(saniye);
            lblSaniye.Text = saniye.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            saniye++;//ileriye doğru görüntü gider
            SaniyedekiGoruntuyuAc(saniye);
            lblSaniye.Text = saniye.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            const string basePath = @"C:\test\frames\frames\";
            reader.Open(dosyaAdi);
            var imageCount = reader.FrameCount;

            Bitmap r=reader.ReadVideoFrame();
            
            using( var videoWriter = new VideoFileWriter())
            {
                videoWriter.Open(basePath + "maskelenmisvideo.mp4", r.Width, r.Height, 30, VideoCodec.MPEG4, 10000);

           
                for (int imageFrame = 30; imageFrame < imageCount-1; imageFrame++)
                {
                    var imgPath = string.Format("{0}{1}.jpeg", basePath, imageFrame);
                    using (Bitmap image = Bitmap.FromFile(imgPath) as Bitmap)
                    {
                        videoWriter.WriteVideoFrame(image);
                    }
                }
                videoWriter.Close();
            }
            reader.Close();
           
        }
        string dosyaAdi;

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            
            DialogResult cevap=  file.ShowDialog();
            if (cevap == DialogResult.OK)
                dosyaAdi = file.FileName;

        }
        VideoFileReader reader = new VideoFileReader();
        private void simpleButton9_Click(object sender, EventArgs e)
        {
                     

            // open video file
            reader.Open(dosyaAdi);
            string dir = @"C:\test\frames\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //read 100 video frames out of it
            for (int i = 0; i < reader.FrameCount; i++)
            {
                Bitmap videoFrame = reader.ReadVideoFrame();

                videoFrame.Save(dir +i+ ".jpeg");
               
                // dispose the frame when it is no longer required
                videoFrame.Dispose();
            }

            reader.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //graphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));

            //Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
            //Graphics g = Graphics.FromImage(bmp);
            //g.FillRectangle(new SolidBrush(Color.Blue), 10, 10, 30, 50);
            //g.Flush();
            //bmp.Save("aa.jpg");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool maskelemeOncekiVarmi = false;
            string[] oncekiVeriler = new string[1];
            var satirlar = File.ReadAllLines("C:\\test\\yerler.txt");
            for (int i = 0; i < satirlar.Length; i++)
            {
                label1.Top = 0;
                label2.Left = 0;
                var bilgiler = satirlar[i].Split(';');
                if (bilgiler.Length < 3 && maskelemeOncekiVarmi == false)
                {
                    maskelemeOncekiVarmi = false;
                    continue;
                }

                if (bilgiler.Length > 3)
                    maskelemeOncekiVarmi = false;



                if (maskelemeOncekiVarmi)
                {
                    bilgiler = new string[oncekiVeriler.Length];
                    Array.Copy(oncekiVeriler, bilgiler, oncekiVeriler.Length);
                }

                var saniye = Convert.ToInt32(bilgiler[0]);
                var maskelemeVarmi = bilgiler[1] == "1" ? true : false;
                var yatayCizgiVarmi = bilgiler[2] == "1" ? true : false;
                var dikeyCizgiVarmi = bilgiler[3] == "1" ? true : false;
                var yatayCizgiYuksekligi = Convert.ToInt32(bilgiler[4]);
                var ustTarafmi = bilgiler[5] == "1" ? true : false;
                var dikeyCizgiGenislik = Convert.ToInt32(bilgiler[6]);
                var solTarafmi = bilgiler[7] == "1" ? true : false;

              
                
                List<Rectangle> alanlar = new List<Rectangle>();

                if(bilgiler.Length>8)
                {
                    int index = 9;
                    for (int j = 0; j < Convert.ToInt32(bilgiler[8]); j++)
                    {
                        Rectangle alan = new Rectangle(Convert.ToInt32(bilgiler[index++]),
                            Convert.ToInt32(bilgiler[index++ ]),
                            Convert.ToInt32(bilgiler[index++ ]),
                            Convert.ToInt32(bilgiler[index++ ]));
                        alanlar.Add(alan);
                    }
                }

                GoruntuMaskele(saniye, yatayCizgiVarmi, dikeyCizgiVarmi, yatayCizgiYuksekligi, ustTarafmi, dikeyCizgiGenislik, solTarafmi, alanlar);

                oncekiVeriler = new string[bilgiler.Length];
                Array.Copy(bilgiler, oncekiVeriler, bilgiler.Length);
                maskelemeOncekiVarmi = true;

                //saniyeyi arttır
                oncekiVeriler[0] = (Convert.ToInt32(bilgiler[0]) + 1).ToString();
            }

        }

        private void GoruntuMaskele(int saniye, bool yatayCizgiVarmi,bool dikeyCizgiVarmi, int yatayCizgiYuksekligi, bool ustTarafmi, int dikeyCizgiGenislik, bool solTarafmi,List<Rectangle> alanlar)
        {

            for (int i = (saniye*30); i < (saniye * 30+30); i++)
            {
                if (!File.Exists(@"C:\test\frames\" + i + ".jpeg"))
                    continue;

                using (Bitmap bmpTemp = new Bitmap(@"C:\test\frames\" + i + ".jpeg"))
                {

                    //Bitmap bmp = (Bitmap)bmpTemp.Clone();
                   

                    using (Graphics g = Graphics.FromImage(bmpTemp))
                    {                    


                        int a = 0, b = 0, c = 0, d = 0;
                        int x = 0, y = 0, z = 0, t = 0;
                        a = yatayCizgiYuksekligi;
                        b = dikeyCizgiGenislik;
                        
                        c = bmpTemp.Height - yatayCizgiYuksekligi;
                        d = bmpTemp.Width - dikeyCizgiGenislik;

                        if (ustTarafmi && solTarafmi)//üst sol ise kapat
                        {
                            x = 0;//dikdörtgen sol üst
                            y = 0;//dikdörtgen sol üst
                            z = b;//boyut
                            t = a;//boyut
                            
                            g.FillRectangle(new SolidBrush(Color.Blue), x, y, z, t);
                        }
                        if (ustTarafmi && solTarafmi==false)// üst sağ ise kapat
                        {
                            x = b;
                            y = 0;
                            z = d;
                            t = a;
                           
                            g.FillRectangle(new SolidBrush(Color.Blue), x, y, z, t);
                        }
                        if (ustTarafmi==false && solTarafmi)//alt sol kapat
                        {
                            x = 0;
                            y = a;
                            z = b;
                            t = c;
                            
                            g.FillRectangle(new SolidBrush(Color.Blue), x, y, z, t);
                        }
                        if (ustTarafmi==false && solTarafmi==false)//alt sağ kapat
                        {
                            x = b;
                            y = a;
                            z = d;
                            t = c;
                            
                            g.FillRectangle(new SolidBrush(Color.Blue), x, y, z, t);
                        }

                        //Bölgesel Alan Ekleme
                        if (alanlar.Count>0)
                            for (int j = 0; j < alanlar.Count; j++)
                            {
                                g.FillRectangle(new SolidBrush(Color.Blue), alanlar[j]);
                            }

                        g.Flush();
                        if (yatayCizgiVarmi || dikeyCizgiVarmi || alanlar.Count > 0)
                            bmpTemp.Save(@"C:\test\frames\frames\" + i + ".jpeg");

                        
                    }

                     
                }
            }           
            GC.Collect();//bellekten gereksiz nesneleri siler           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            UserControl_MaskedArea maskeliAlan = new UserControl_MaskedArea();
            pictureBox1.Controls.Add(maskeliAlan);
            if (checkBox4.Checked)
                maskeliAlan.BackColor = Color.LightBlue;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MaskeliAlanlariSil();

        }

        void MaskeliAlanlariSil()
        {
            pictureBox1.Controls.Clear();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
