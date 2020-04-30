using System;
using System.Collections.Generic;
using System.Globalization;
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

        public LineGeometry DrawLine(double X1, double Y1, double X2, double Y2)
        {
            LineGeometry myLineGeometry = new LineGeometry();
            myLineGeometry.StartPoint = new Point(X1, Y1);
            myLineGeometry.EndPoint = new Point(X2, Y2);



            return myLineGeometry;
        }

        public EllipseGeometry DrawCircle(double X, double Y, double Radius)
        {
            EllipseGeometry ellipse = new EllipseGeometry();
            ellipse.Center = new Point(X, Y);
            ellipse.RadiusX = Radius;
            ellipse.RadiusY = Radius;



            return ellipse;
        }
        public Geometry DrawText(double X, double Y, string text)
        {
            FormattedText texts = new FormattedText(text,
             CultureInfo.CurrentCulture,
             FlowDirection.LeftToRight,
             new Typeface("Tahoma"),
             160,
             Brushes.Black);
            Geometry geometry = texts.BuildGeometry(new Point(X, Y));
            return geometry;
        }



   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dwg_Data dwg_Data = new Dwg_Data();
            //string path = "l0949.dwg";
            string path = "example_2010.dwg";
            LibreDWG.dwg_read_file(path, dwg_Data);


            List<Points> Punkty = new List<Points>();
            List<CirclePoints> circles = new List<CirclePoints>();

            var minPoint = 10000.00;

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
                        //GeometryDrawing geometry = new GeometryDrawing();
                        geo.Children.Add(DrawText(dwg_Entity_TEXT.insertion_pt.x, dwg_Entity_TEXT.insertion_pt.y, dwg_Entity_TEXT.text_value));
                        break;

                    case Dwg_Object_Type.DWG_TYPE_POLYLINE_2D:
                        Console.WriteLine("Polyline 2D");
                        Dwg_Entity_POLYLINE_2D dwg_Entity_POLYLINE_2D = x.tio.entity.tio.POLYLINE_2D;
                        Console.WriteLine(dwg_Entity_POLYLINE_2D.num_owned + "," + dwg_Entity_POLYLINE_2D.start_width + "," + dwg_Entity_POLYLINE_2D.end_width + "," + dwg_Entity_POLYLINE_2D.vertex + "," + dwg_Entity_POLYLINE_2D.first_vertex);
                        break;
                    case Dwg_Object_Type.DWG_TYPE_POLYLINE_3D:
                        Console.WriteLine("Polyline 3D");
                        Dwg_Entity_POLYLINE_3D dwg_Entity_POLYLINE_3D = x.tio.entity.tio.POLYLINE_3D;
                        Console.WriteLine(dwg_Entity_POLYLINE_3D.vertex + "," + dwg_Entity_POLYLINE_3D.curve_type + "," + dwg_Entity_POLYLINE_3D.vertex + "," + dwg_Entity_POLYLINE_3D.last_vertex + "," + dwg_Entity_POLYLINE_3D.num_owned + ",");
                        break;
                    case Dwg_Object_Type.DWG_TYPE_ARC:
                        Dwg_Entity_ARC arc = x.tio.entity.tio.ARC;
                        Console.WriteLine(arc.center.x + "," + arc.center.y + "," + arc.center.z + "," + arc.radius + "," + arc.center);
                        circles.Add(new CirclePoints(arc.center.x, arc.center.y, arc.radius));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CAMERA:
                        Dwg_Entity_CAMERA camera
                            = x.tio.entity.tio.CAMERA;
                        Console.WriteLine(camera.view + "," + camera.parent);
                        break;
                    case Dwg_Object_Type.DWG_TYPE_CIRCLE:
                        Console.WriteLine("Circle");
                        Dwg_Entity_CIRCLE dwg_Entity_CIRCLE = x.tio.entity.tio.CIRCLE;
                        Console.WriteLine($"Center point: ({dwg_Entity_CIRCLE.center.x}, {dwg_Entity_CIRCLE.center.y}, {dwg_Entity_CIRCLE.center.z}) Radius: {dwg_Entity_CIRCLE.radius}");
                        var Zx = Math.Round(dwg_Entity_CIRCLE.center.x, 2);
                        var Zy = Math.Round(dwg_Entity_CIRCLE.center.y, 2);
                        var Zradius = Math.Round(dwg_Entity_CIRCLE.center.y, 2);
                        circles.Add(new CirclePoints(Zx, Zy, Zradius));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_ELLIPSE:
                        Console.WriteLine("Circle");
                        Dwg_Entity_ELLIPSE dwg_Entity_Ellipse = x.tio.entity.tio.ELLIPSE;
                        Console.WriteLine($"Center point: ({dwg_Entity_Ellipse.center.x}, {dwg_Entity_Ellipse.center.y}, {dwg_Entity_Ellipse.center.z}");
                        circles.Add(new CirclePoints(dwg_Entity_Ellipse.center.x, dwg_Entity_Ellipse.center.y, 10));
                        break;
                    case Dwg_Object_Type.DWG_TYPE_LINE:
                        Console.WriteLine("Line");
                        Dwg_Entity_LINE dwg_Entity_LINE = x.tio.entity.tio.LINE;

                        if (minPoint > dwg_Entity_LINE.start.x)
                        {
                            minPoint = dwg_Entity_LINE.start.x;
                        }
                        else if (minPoint > dwg_Entity_LINE.start.y)
                        {
                            minPoint = dwg_Entity_LINE.start.y;
                        }
                        else if (minPoint > dwg_Entity_LINE.end.x)
                        {
                            minPoint = dwg_Entity_LINE.end.x;
                        }
                        else if (minPoint > dwg_Entity_LINE.end.y)
                        {
                            minPoint = dwg_Entity_LINE.end.y;
                        }
                        var Px1 = Math.Round(dwg_Entity_LINE.start.x, 2);
                        var Py1 = Math.Round(dwg_Entity_LINE.start.y, 2);
                        var Px2 = Math.Round(dwg_Entity_LINE.end.x, 2);
                        var Py2 = Math.Round(dwg_Entity_LINE.end.y, 2);
                        Punkty.Add(new Points(Px1, Py1, Px2, Py2));


                        break;
                    case Dwg_Object_Type.DWG_TYPE_HELIX:
                        Console.WriteLine("Line");
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < Punkty.Count; i++)
            {

                geo.Children.Add(DrawLine((Punkty[i].X1), (Punkty[i].Y1), (Punkty[i].X2), (Punkty[i].Y2)));

            }
           
      
            for (int i = 0; i < circles.Count; i++)
            {
                geo.Children.Add(DrawCircle(circles[i].X , circles[i].Y , circles[i].Radius));
            }
        }
    }
}