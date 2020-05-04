using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using zabawa;

namespace _123
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


     
    

    public static int MaxPointX = 1;
        public static int MaxPointY = 1;
        public static int MinPointX = 1000000;
        public static int MinPointY = 1000000;

        List<Points> Punkty = new List<Points>();
        List<CirclePoints> circles = new List<CirclePoints>();
        List<Arc> arcs = new List<Arc>();
        List<Ellipse> ellipse = new List<Ellipse>();
        List<Text> texts = new List<Text>();
        List<Polygon2d> polygon = new List<Polygon2d>();

        public void FindMin(int x, int y)
        {
            if (MinPointX > x)
            {
                MinPointX = x;
            }
            if (MinPointY > y)
            {
                MinPointY = y;
            }
        }
        public void FindMax(int x, int y)
        {
            if (MaxPointX < x)
            {
                MaxPointX = x;
            }
            if (MaxPointY < y)
            {
                MaxPointY = y;
            }
        }
        public void FindMax(int x)
        {
            if (MaxPointX < x)
            {
                MaxPointX = x;
            }
        }
        public void FindMaxy(int y)
        {
            if (MaxPointY < y)
            {
                MaxPointY = y;
            }
        }

        public void UpdateResults()
        {

            var minX = MinPointX * -1;
            var minY = MinPointY * -1;
            for (int i = 0; i < Punkty.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    Punkty[i].X1 += minX;
                    Punkty[i].X2 += minX;
                    Punkty[i].Y1 += minY;
                    Punkty[i].Y2 += minY;

                    FindMax(Convert.ToInt32(Punkty[i].X1), Convert.ToInt32(Punkty[i].Y1));
                    FindMax(Convert.ToInt32(Punkty[i].X2), Convert.ToInt32(Punkty[i].Y2));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    Punkty[i].X1 += minX;
                    Punkty[i].X2 += minX;
                    FindMax(Convert.ToInt32(Punkty[i].X1));
                    FindMax(Convert.ToInt32(Punkty[i].X2));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    Punkty[i].Y1 += minY;
                    Punkty[i].Y2 += minY;
                    FindMaxy(Convert.ToInt32(Punkty[i].Y1));
                    FindMaxy(Convert.ToInt32(Punkty[i].Y2));
                }
            }
            for (int i = 0; i < circles.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    circles[i].X += minX;
                    circles[i].Y += minY;
                    FindMax(Convert.ToInt32(circles[i].X), Convert.ToInt32(circles[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    circles[i].X += minX;
                    FindMax(Convert.ToInt32(circles[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    circles[i].Y += minY;
                    FindMaxy(Convert.ToInt32(circles[i].Y));
                }
            }
            for (int i = 0; i < arcs.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    arcs[i].X += minX;
                    arcs[i].Y += minY;
                    FindMax(Convert.ToInt32(arcs[i].X), Convert.ToInt32(arcs[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    arcs[i].X += minX;
                    FindMax(Convert.ToInt32(arcs[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    arcs[i].Y += minY;
                    FindMaxy(Convert.ToInt32(arcs[i].Y));
                }
            }
            for(int i = 0; i < texts.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    texts[i].X += minX;
                    texts[i].Y += minY;
                    FindMax(Convert.ToInt32(texts[i].X), Convert.ToInt32(texts[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    texts[i].X += minX;
                    FindMax(Convert.ToInt32(texts[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    texts[i].Y += minY;
                    FindMaxy(Convert.ToInt32(texts[i].Y));
                }
            }

            for (int i = 0; i < polygon.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    polygon[i].X += minX;
                    polygon[i].Y += minY;
                    FindMax(Convert.ToInt32(polygon[i].X), Convert.ToInt32(polygon[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    polygon[i].X += minX;
                    FindMax(Convert.ToInt32(polygon[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    polygon[i].Y += minY;
                    FindMaxy(Convert.ToInt32(polygon[i].Y));
                }
            }


        }

        public void LoadFile()
        {
            Dwg_Data dwg_Data = new Dwg_Data();
            string path = "l0949.dwg";
            //string path = "example_2010.dwg";
            LibreDWG.dwg_read_file(path, dwg_Data);

            //LibreDWG.dwg_getall_POLYLINE_2D(dwg_Data);
         
       
            for (uint i = 0; i < dwg_Data.num_objects; i++)
            {
                var x = LibreDWG.dwg_get_object(dwg_Data, i);
                switch ((Dwg_Object_Type)Enum.ToObject(typeof(Dwg_Object_Type), x.type))
                {
                    case Dwg_Object_Type.DWG_TYPE_UNUSED:
                        break;
                    case Dwg_Object_Type.DWG_TYPE_TEXT:
                        Console.WriteLine("Text");
                        Dwg_Entity_TEXT dwg_Entity_TEXT = x.tio.entity.tio.TEXT;
                        Console.WriteLine(dwg_Entity_TEXT.text_value, dwg_Entity_TEXT.insertion_pt.x, dwg_Entity_TEXT.insertion_pt.y);
                        FindMin(Convert.ToInt32(dwg_Entity_TEXT.insertion_pt.x), Convert.ToInt32(dwg_Entity_TEXT.insertion_pt.y));
                        break;

                    case Dwg_Object_Type.DWG_TYPE_POLYLINE_2D:
                        Console.WriteLine("Polyline 2D");
                        Dwg_Entity_POLYLINE_2D pol2d = x.tio.entity.tio.POLYLINE_2D;
                        polygon.Add(new Polygon2d((float)pol2d.extrusion.x,(float) pol2d.extrusion.y));
                        FindMin(Convert.ToInt32(pol2d.extrusion.x), Convert.ToInt32(pol2d.extrusion.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_POLYLINE_3D:
                        Console.WriteLine("Polyline 3D");
                        Dwg_Entity_POLYLINE_3D dwg_Entity_POLYLINE_3D = x.tio.entity.tio.POLYLINE_3D;
                        break;
                    //case Dwg_Object_Type.DWG_TYPE_LAYER:
                    //    Console.WriteLine("Polyline 3D");
                    //    var layer = x.tio.entity.layer;
                    //    break;
                    case Dwg_Object_Type.DWG_TYPE_ARC:
                        Dwg_Entity_ARC arc = x.tio.entity.tio.ARC;
                        var xa = arc.end_angle;
                        var z = arc.start_angle;
                        var w = arc.thickness;
                        var l = arc.extrusion;
                        arcs.Add(new Arc((float)arc.center.x, (float)arc.center.y, (float)arc.radius, (float)arc.start_angle, (float)arc.end_angle));
                        FindMin(Convert.ToInt32(arc.center.x), Convert.ToInt32(arc.center.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CAMERA:
                        //Dwg_Entity_CAMERA camera
                        //    = x.tio.entity.tio.CAMERA;
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CIRCLE:
                        Dwg_Entity_CIRCLE dwg_Entity_CIRCLE = x.tio.entity.tio.CIRCLE;
                        var Zx = Math.Round(dwg_Entity_CIRCLE.center.x, 2);
                        var Zy = Math.Round(dwg_Entity_CIRCLE.center.y, 2);
                        var Zradius = Math.Round(dwg_Entity_CIRCLE.center.y, 2);

                        circles.Add(new CirclePoints((float)dwg_Entity_CIRCLE.center.x, (float)dwg_Entity_CIRCLE.center.y, (float)dwg_Entity_CIRCLE.radius));
                        FindMin(Convert.ToInt32(dwg_Entity_CIRCLE.center.x), Convert.ToInt32(dwg_Entity_CIRCLE.center.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_ELLIPSE:
                        Dwg_Entity_ELLIPSE el = x.tio.entity.tio.ELLIPSE;
                     
                        ellipse.Add(new Ellipse((float) el.center.x, (float)el.center.y, (float)el.end_angle, (float)el.start_angle));
                        FindMin(Convert.ToInt32( el.center.x),Convert.ToInt32( el.center.y)); 
                     
                        break;
                    case Dwg_Object_Type.DWG_TYPE_LINE:
                        Console.WriteLine("Line");
                        Dwg_Entity_LINE dwg_Entity_LINE = x.tio.entity.tio.LINE;



                        var Px1 = Math.Round(dwg_Entity_LINE.start.x, 2);
                        var Py1 = Math.Round(dwg_Entity_LINE.start.y, 2);
                        var Px2 = Math.Round(dwg_Entity_LINE.end.x, 2);
                        var Py2 = Math.Round(dwg_Entity_LINE.end.y, 2);
                        Punkty.Add(new Points(Px1, Py1, Px2, Py2));
                        FindMin(Convert.ToInt32(Px1), Convert.ToInt32(Py1));
                        FindMax(Convert.ToInt32(Px2), Convert.ToInt32(Py2));

                        break;
                    case Dwg_Object_Type.DWG_TYPE_HELIX:
                        Console.WriteLine("Line");
                        break;
                    default:
                        break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadFile();

            UpdateResults();
            double wpx = 1;
            double wpy = 1;
            
            

            if (MaxPointX > 10000 && MaxPointY > 10000)
            {


                wpx = Math.Round((10000.00 / MaxPointX), 2);
                wpy = Math.Round((10000.00 / MaxPointY), 2);
            }
            System.Drawing.Bitmap image = new Bitmap(10000, 10000);



            Graphics graph = Graphics.FromImage(image);

            graph.Clear(System.Drawing.Color.Azure);

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);



            for (int i = 0; i < Punkty.Count; i++)
            {


                graph.DrawLine(pen, Convert.ToInt32(Punkty[i].X1 * wpx), Convert.ToInt32(Punkty[i].Y1 * wpy), Convert.ToInt32(Punkty[i].X2 * wpx), Convert.ToInt32(Punkty[i].Y2 * wpy));

                //graph.DrawLine(pen, Convert.ToInt32(Punkty[i].X1), Convert.ToInt32(Punkty[i].Y1), Convert.ToInt32(Punkty[i].X2), Convert.ToInt32(Punkty[i].Y2));
            }
            
            for (int i = 0; i < arcs.Count; i++)
            {
                graph.DrawArc(pen, arcs[i].X * (float)wpx, arcs[i].Y * (float)wpy, arcs[i].Z + arcs[i].Z, +arcs[i].X + arcs[i].X, arcs[i].startAngle, arcs[i].endAngle);
            }
            for (int i = 0; i < texts.Count; i++)
            {
                
                graph.DrawString(texts[i].text, new Font(new System.Drawing.FontFamily("Arial"), 10),
                System.Drawing.Brushes.Blue, texts[i].X * (float)wpx,texts[i].Y * (float)wpy);
            }

            System.Drawing.Point[] pointsPolygon = new System.Drawing.Point[polygon.Count];
           for (int i = 0; i < polygon.Count; i++)
            {
                pointsPolygon[i] = new System.Drawing.Point(Convert.ToInt32(polygon[i].X * wpx), Convert.ToInt32(polygon[i].Y * wpy));
                
            }

            if (pointsPolygon.Count() > 0)
                graph.DrawPolygon(pen, pointsPolygon);

            image.Save("3.jpeg", System.Drawing.Imaging.ImageFormat.Png);
            var ScreenCapture = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
            image.GetHbitmap(),
             IntPtr.Zero,
             System.Windows.Int32Rect.Empty,
            BitmapSizeOptions.FromWidthAndHeight(10000, 10000));
            abc.Source = ScreenCapture;
        }
    }
}