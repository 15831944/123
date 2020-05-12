using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        List<Polygon3d> polygons = new List<Polygon3d>();
        List<int> punkty = new List<int>();
        List<Lines> lines = new List<Lines>();
        List<Polygon3d> vertex3d = new List<Polygon3d>();
        List<Polygon3d> spline = new List<Polygon3d>();
        List<Polygon3d> att = new List<Polygon3d>();
        List<Text> mmtext = new List<Text>();
        List<Polygon2d> hatchList = new List<Polygon2d>();
        List<Polygon2d> poly2 = new List<Polygon2d>();
        List<Points> pkt = new List<Points>();
        List<Points> rayy = new List<Points>();
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

            for (int i = 0; i < pkt.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    pkt[i].X1 += minX;
                    pkt[i].Y1 += minY;
                    FindMax(Convert.ToInt32(pkt[i].X1), Convert.ToInt32(pkt[i].Y1));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    pkt[i].X1 += minX;
                    FindMax(Convert.ToInt32(pkt[i].X1));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                     pkt[i].Y1 += minY;
                    FindMaxy(Convert.ToInt32(pkt[i].Y1));
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
            for (int i = 0; i < ellipse.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    ellipse[i].x += minX;
                    ellipse[i].y += minY;
                    FindMax(Convert.ToInt32(ellipse[i].x), Convert.ToInt32(ellipse[i].y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    ellipse[i].x += minX;
                    FindMax(Convert.ToInt32(ellipse[i].x));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    ellipse[i].y += minY;
                    FindMaxy(Convert.ToInt32(ellipse[i].y));
                }
            }
            for (int i = 0; i < texts.Count; i++)
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
            for (int i = 0; i < vertex3d.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    vertex3d[i].X += minX;
                    vertex3d[i].Y += minY;
                    FindMax(Convert.ToInt32(vertex3d[i].X), Convert.ToInt32(vertex3d[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    vertex3d[i].X += minX;
                    FindMax(Convert.ToInt32(vertex3d[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    vertex3d[i].Y += minY;
                    FindMaxy(Convert.ToInt32(vertex3d[i].Y));
                }


            }

            for (int i = 0; i < lines.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    lines[i].X += minX;
                    lines[i].Y += minY;
                    FindMax(Convert.ToInt32(lines[i].X), Convert.ToInt32(lines[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    lines[i].X += minX;
                    FindMax(Convert.ToInt32(lines[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    lines[i].Y += minY;
                    FindMaxy(Convert.ToInt32(lines[i].Y));
                }


            }

            for (int i = 0; i < rayy.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    rayy[i].X1 += minX;
                    rayy[i].Y1 += minY;
                    FindMax(Convert.ToInt32(rayy[i].X1), Convert.ToInt32(rayy[i].Y1));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    rayy[i].X1 += minX;
                    FindMax(Convert.ToInt32(rayy[i].X1));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    rayy[i].Y1 += minY;
                    FindMaxy(Convert.ToInt32(rayy[i].Y1));
                }


            }

            for (int i = 0; i < spline.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    spline[i].X += minX;
                    spline[i].Y += minY;
                    FindMax(Convert.ToInt32(spline[i].X), Convert.ToInt32(spline[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    spline[i].X += minX;
                    FindMax(Convert.ToInt32(spline[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    spline[i].Y += minY;
                    FindMaxy(Convert.ToInt32(spline[i].Y));
                }


            }

            for (int i = 0; i < att.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    att[i].X += minX;
                    att[i].Y += minY;
                    FindMax(Convert.ToInt32(att[i].X), Convert.ToInt32(att[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    att[i].X += minX;
                    FindMax(Convert.ToInt32(att[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    att[i].Y += minY;
                    FindMaxy(Convert.ToInt32(att[i].Y));
                }


            }

            for (int i = 0; i < mmtext.Count; i++)
            {
                if (MinPointX < 0 && MinPointY < 0)
                {
                    mmtext[i].X += minX;
                    mmtext[i].Y += minY;
                    FindMax(Convert.ToInt32(mmtext[i].X), Convert.ToInt32(mmtext[i].Y));

                }
                else if (MinPointX < 0 && MinPointY > 0)
                {
                    mmtext[i].X += minX;
                    FindMax(Convert.ToInt32(mmtext[i].X));
                }
                else if (MinPointX > 0 && MinPointY < 0)
                {
                    mmtext[i].Y += minY;
                    FindMaxy(Convert.ToInt32(mmtext[i].Y));
                }


            }

        }

        public void LoadFile()
        {
            Dwg_Data dwg_Data = new Dwg_Data();
            Dwg_Object_Ref dwg = new Dwg_Object_Ref();

            string path = "l0949.dwg";
            //string path = "example_2010.dwg";


            LibreDWG.dwg_read_file(path, dwg_Data);

            //LibreDWG.dwg_getall_POLYLINE_2D(dwg_Data);




            SWIGTYPE_p_int error = null;
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
                        texts.Add(new Text(dwg_Entity_TEXT.text_value, (float)dwg_Entity_TEXT.insertion_pt.x, (float)dwg_Entity_TEXT.insertion_pt.y, (float)dwg_Entity_TEXT.height));
                        FindMin(Convert.ToInt32(dwg_Entity_TEXT.insertion_pt.x), Convert.ToInt32(dwg_Entity_TEXT.insertion_pt.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_SPLINE:
                        Console.WriteLine("Text");
                        Dwg_Entity_SPLINE dwg_Entity_SPLINE = x.tio.entity.tio.SPLINE;

                       
                        if(dwg_Entity_SPLINE.fit_pts !=null){
                var ptx = dwg_Entity_SPLINE.fit_pts.x;
                var pty = dwg_Entity_SPLINE.fit_pts.y;

                spline.Add(new Polygon3d((float)ptx, (float)pty));
             }
                      
                    

                        break;
                    case Dwg_Object_Type.DWG_TYPE_POINT:
                        Console.WriteLine("Text");
                        Dwg_Entity_POINT point = x.tio.entity.tio.POINT;
                        pkt.Add(new Points(point.x, point.y));
                        FindMin((int)point.x,(int)point.y);
                        

                        break;


                    case Dwg_Object_Type.DWG_TYPE_MTEXT:
                        Dwg_Entity_MTEXT mtext = x.tio.entity.tio.MTEXT;
                        mmtext.Add(new Text(mtext.text, (float)mtext.insertion_pt.x, (float)mtext.insertion_pt.y,(float) mtext.text_height));
                        FindMin(Convert.ToInt32(mtext.insertion_pt.x), Convert.ToInt32(mtext.insertion_pt.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_MLINE:
                        Dwg_Entity_MLINE mline = x.tio.entity.tio.MLINE;
                         for(int k = 0; k < mline.num_lines; k++)
                        {
                            var xyza = mline.base_point;
                        }
                  
                   
                        break;
                    case Dwg_Object_Type.DWG_TYPE_XLINE:
                        Dwg_Entity_RAY xline = x.tio.entity.tio.XLINE;
                        rayy.Add(new Points(xline.point.x, xline.point.y));
                        break;
                 
                     
                    case Dwg_Object_Type.DWG_TYPE_HATCH:
                        Dwg_Entity_HATCH hatch = x.tio.entity.tio.HATCH;
                        hatchList.Add(new Polygon2d((float)hatch.extrusion.x, (float)hatch.extrusion.y));
                        //mmtext.Add(new Text(mtext.text, (float)mtext.extrusion.x, (float)mtext.extrusion.y));
                        //FindMin(Convert.ToInt32(mtext.extrusion.x), Convert.ToInt32(mtext.extrusion.y));
                        break;
                    //case Dwg_Object_Type.DWG_TYPE_VERTEX_2D:
                    //    Console.WriteLine("Polyline 2D");
                    //    Dwg_Entity_VERTEX_2D pol2d = x.tio.entity.tio.VERTEX_2D;
                    //    polygon.Add(new Polygon2d((float)pol2d.point.x,(float)pol2d.point.y));
                    //    FindMin(Convert.ToInt32(pol2d.point.x), Convert.ToInt32(pol2d.point.y));
                    //    break;
                    case Dwg_Object_Type.DWG_TYPE_LWPOLYLINE:
                        Console.WriteLine("LWPOLYLINE");
                        Dwg_Entity_LWPOLYLINE pol3d = x.tio.entity.tio.LWPOLYLINE;
                        lines.Add(new Lines((float)pol3d.points.x, (float)pol3d.extrusion.y));
                        FindMin(Convert.ToInt32(pol3d.points.x), Convert.ToInt32(pol3d.points.y));
                        break;
                    //case Dwg_Object_Type.DWG_TYPE_ATTRIB:
                    //    Console.WriteLine("LWPOLYLINE");
                    //    Dwg_Entity_ATTRIB attrib = x.tio.entity.tio.ATTRIB;
                    //    att.Add(new Polygon3d((float)attrib.insertion_pt.x, (float)attrib.insertion_pt.y));
                    //    FindMin(Convert.ToInt32(attrib.insertion_pt.x), Convert.ToInt32(attrib.insertion_pt.y));
                    //    break;
                    //case Dwg_Object_Type.DWG_TYPE_VERTEX_3D:
                    //    Console.WriteLine("Polyline 3D");
                    //    Dwg_Entity_LWPOLYLINE vert3 = x.tio.entity.tio.LWPOLYLINE;
                    //    vertex3d.Add(new Polygon3d((float)vert3.points.x, (float)vert3.points.y));
                    //    FindMin(Convert.ToInt32(vert3.points.x), Convert.ToInt32(vert3.points.y));
                    //    break;

                    case Dwg_Object_Type.DWG_TYPE_ARC:
                        Dwg_Entity_ARC arc = x.tio.entity.tio.ARC;
                        arcs.Add(new Arc((float)arc.center.x, (float)arc.center.y, (float)arc.radius, (float)(Math.Round(arc.start_angle, 2)), (float)(Math.Round(arc.end_angle, 2))));

                        FindMin(Convert.ToInt32(arc.center.x), Convert.ToInt32(arc.center.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CAMERA:
                        //Dwg_Entity_CAMERA camera
                        //    = x.tio.entity.tio.CAMERA;
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CIRCLE:
                        Dwg_Entity_CIRCLE dwg_Entity_CIRCLE = x.tio.entity.tio.CIRCLE;
      

                        circles.Add(new CirclePoints((float)dwg_Entity_CIRCLE.center.x, (float)dwg_Entity_CIRCLE.center.y, (float)dwg_Entity_CIRCLE.radius));
                        FindMin(Convert.ToInt32(dwg_Entity_CIRCLE.center.x), Convert.ToInt32(dwg_Entity_CIRCLE.center.y));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_ELLIPSE:
                        Dwg_Entity_ELLIPSE el = x.tio.entity.tio.ELLIPSE;
                          
                        ellipse.Add(new Ellipse((float) el.sm_axis.x, (float)el.sm_axis.y, (float)(Math.Round(el.axis_ratio))));
                        var asda = el.center.x;
                            var sdffd = el.center.y;
                        FindMin(Convert.ToInt32( el.center.x),Convert.ToInt32( el.sm_axis.y));
                      
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
                 
                    default:
                        break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadFile();

            UpdateResults();
            double wpx = 1.00;
            double wpy = 1.00;


            var Height = MaxPointX;
            var Width = MaxPointY;
            if (MaxPointX > 10000 && MaxPointY > 10000)
            {

                Height = 10000;
                Width = 10000;
                wpx = Math.Round((10000.00 / MaxPointX), 2);
                wpy = Math.Round((10000.00 / MaxPointY), 2);
                if (wpx == 0)
                {
                    wpx = 0.01;
                }
                if (wpy == 0)
                {
                    wpy = 0.01;
                }
            }
            System.Drawing.Bitmap image = new Bitmap(Height,Width);



            Graphics graph = Graphics.FromImage(image);

            graph.Clear(System.Drawing.Color.Azure);

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);


            System.Drawing.Point[] pktPkt = new System.Drawing.Point[pkt.Count()];
            for (int i = 0; i < pkt.Count; i++) {
                //pktPkt[i].X =Convert.ToInt32( pkt[i].X1 * wpx);
                //pktPkt[i].Y = Convert.ToInt32(pkt[i].Y1 * wpy);
                graph.DrawEllipse(pen, (float) pkt[i].X1, (float)pkt[i].Y1, 5, 5);
            }

            //System.Drawing.Point[] rayPoints = new System.Drawing.Point[rayy.Count];
            //for (int i = 0; i < rayy.Count; i++)
            //{
            //    rayPoints[i].X = Convert.ToInt32(rayy[i].X1);
            //    rayPoints[i].Y = Convert.ToInt32(rayy[i].Y1);
            //}

            //graph.DrawPolygon(pen, rayPoints);
            for (int i = 0; i < Punkty.Count; i++)
            {


                graph.DrawLine(pen, Convert.ToInt32(Punkty[i].X1 * wpx), Convert.ToInt32(Punkty[i].Y1 * wpy), Convert.ToInt32(Punkty[i].X2 * wpx), Convert.ToInt32(Punkty[i].Y2 * wpy));


            }
            for (int i = 0; i < ellipse.Count; i++)
            {

                var width = 100 * ellipse[i].ratio;
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Convert.ToInt32(ellipse[i].x * wpx), Convert.ToInt32(ellipse[i].y * wpy), Convert.ToInt32(width), 100);

                graph.DrawEllipse(pen, rect);


            }
            for (int i = 0; i < circles.Count; i++)
            {
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Convert.ToInt32(circles[i].X * wpx), Convert.ToInt32(circles[i].Y * wpy), Convert.ToInt32(circles[i].Radius * wpx), Convert.ToInt32(circles[i].Radius * wpx));

                graph.DrawEllipse(pen,rect);


            }
            for (int i = 0; i < arcs.Count; i++)
            {
                int radius = 1;
                if(arcs[i].Z * wpx  < 1)
                {
                     radius = 1;
                }
                else
                {
                    radius =Convert.ToInt32( arcs[i].Z * wpx);
                }
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Convert.ToInt32(arcs[i].X * wpx), Convert.ToInt32(arcs[i].Y * wpy),radius,radius);
                graph.DrawArc(pen,rect, arcs[i].startAngle, arcs[i].endAngle);
            
            }
            for (int i = 0; i < texts.Count; i++)
            {
                var item = ((float)(texts[i].textHeight * wpx)) > 1 ? 1 : (float)(texts[i].textHeight * wpx);
                graph.DrawString(texts[i].text, new Font(new System.Drawing.FontFamily("Arial"),item),
                System.Drawing.Brushes.Blue, texts[i].X * (float)wpx, texts[i].Y * (float)wpy);
            }
            for (int i = 0; i < mmtext.Count; i++)
            {
                var item = ((float)(texts[i].textHeight * wpx)) > 1 ? 1 : (float)(texts[i].textHeight * wpx);
                graph.DrawString(mmtext[i].text, new Font(new System.Drawing.FontFamily("Arial"), item),
                System.Drawing.Brushes.Blue, mmtext[i].X * (float)wpx, mmtext[i].Y * (float)wpy);
            }


            System.Drawing.Point[] pointsPolygon = new System.Drawing.Point[polygon.Count];
            for (int i = 0; i < polygon.Count; i++)
            {
                pointsPolygon[i] = new System.Drawing.Point(Convert.ToInt32(polygon[i].X * wpx), Convert.ToInt32(polygon[i].Y * wpy));
                var ts = pointsPolygon[i].X;
                var db = pointsPolygon[i].Y;
            }


            System.Drawing.Point[] pktlines = new System.Drawing.Point[lines.Count()];
            for (int i = 0; i < lines.Count; i++)
            {
                pktlines[i] = new System.Drawing.Point(Convert.ToInt32(lines[i].X * wpx), Convert.ToInt32(lines[i].Y * wpy));
            }

            System.Drawing.Point[] pktvertex3d = new System.Drawing.Point[vertex3d.Count()];
            for (int i = 0; i < vertex3d.Count; i++)
            {
                pktvertex3d[i] = new System.Drawing.Point(Convert.ToInt32(vertex3d[i].X * wpx), Convert.ToInt32(vertex3d[i].Y * wpy));
            }

            System.Drawing.Point[] sppoints = new System.Drawing.Point[spline.Count()];
            for (int i = 0; i < spline.Count; i++)
            {
                var x = 1.00;
                var y = 1.00;
                if(spline[i].X * wpx  > 1)
                {
                    x = spline[i].X * wpx;
                }
                if(spline[i].Y *wpy > 1)
                {
                    y = spline[i].Y * wpy;
                }
                sppoints[i] = new System.Drawing.Point(Convert.ToInt32(x), Convert.ToInt32(y));
            }
            if (pktlines.Count() > 0)
                graph.DrawPolygon(pen, pktlines);

            if (pointsPolygon.Count() > 0)
                graph.DrawPolygon(pen, pointsPolygon);

            if (vertex3d.Count() > 0)
            {
                graph.DrawPolygon(pen, pktvertex3d);
            }
            if(sppoints.Count() > 0)
            {
                graph.DrawCurve(pen, sppoints);
                
            }
            System.Drawing.Point[] attpoints = new System.Drawing.Point[att.Count()];
            for (int i = 0; i < att.Count; i++)
            {
                var x = 1.00;
                var y = 1.00;
                if (att[i].X * wpx > 1)
                {
                    x = att[i].X * wpx;
                }
                if (att[i].Y * wpy > 1)
                {
                    y = att[i].Y * wpy;
                }
                attpoints[i] = new System.Drawing.Point(Convert.ToInt32(x), Convert.ToInt32(y));
            }
            //graph.DrawLines(pen, attpoints);

            image.Save("trala.jpeg", System.Drawing.Imaging.ImageFormat.Png);
            var ScreenCapture = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
            image.GetHbitmap(),
             IntPtr.Zero,
             System.Windows.Int32Rect.Empty,
            BitmapSizeOptions.FromWidthAndHeight(10000, 10000));
            abc.Source = ScreenCapture;
        }
    }
}