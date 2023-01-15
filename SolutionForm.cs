using GeoCoordinatePortable;
using CoordinateSharp;

namespace MortarCalc
{
    public partial class SolutionForm : Form
    {
        static Cartridge m720 = new Cartridge("M720", 60, new int[] { 65, 126, 170, 208, 241 }/*, new Dictionary<int, int>()*/);
        //m720.ranges.Add(70, 400);
        //m720.ranges.Add(200, 1300);
        //m720.ranges.Add(350, 2100);
        //m720.ranges.Add(500, 2800);
        //m720.ranges.Add(650, 3500);
        static Cartridge m821 = new Cartridge("M821", 81, new int[] { 66, 149, 208, 259, 305 }/*, new Dictionary<int, int>()*/);
        //m821.ranges.Add(70, 425);
        //m821.ranges.Add(300, 1900);
        //m821.ranges.Add(550, 3300);
        //m821.ranges.Add(750, 4600);
        //m821.ranges.Add(950, 5900);
        static Cartridge m933 = new Cartridge("M933", 120, new int[] { 101, 165, 220, 270, 318 }/*, new Dictionary<int, int>()*/);
        //m933.ranges.Add(200, 1000);
        //m933.ranges.Add(500, 2500);
        //m933.ranges.Add(850, 4100);
        //m933.ranges.Add(1200, 5800);
        //m933.ranges.Add(1600, 7200);
        List<Cartridge> cartridges = new List<Cartridge>() { m720, m821, m933 };
        public SolutionForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΑΚΟΝΤΙΟ v0.1: Βαλλιστικός υπολογιστής για στόχευση όλμων του ΕΣ. Το πρόγραμμα παρέχει λειτουργία καταγραφής αποθεμάτων πυρομαχικών και ασφαλούς μεταφοράς δεδομένων στόχευσης από ΜΕΑ και προς λοιπά στοιχεία όλμων μέσω ασυρμάτου. Επιμέλεια @ddkatsios", "About");
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Cartridge cartridge;
            string Solution;
            double GunLat = Convert.ToDouble(gunLat.Text);
            double GunLon = Convert.ToDouble(gunLon.Text);
            double GunAlt = Convert.ToDouble(gunAlt.Text);
            double TargetLat = Convert.ToDouble(targetLat.Text);
            double TargetLon = Convert.ToDouble(targetLon.Text);
            double TargetAlt = Convert.ToDouble(targetAlt.Text);
            GeoCoordinate GunPos = new(GunLat, GunLon, GunAlt);
            GeoCoordinate TargetPos = new(TargetLat, TargetLon, TargetAlt);
            int AltDiff = (int)Math.Round(GunAlt - TargetAlt);
            int Range = (int)GunPos.GetDistanceTo(TargetPos);
            if (adjCheckBox.Checked)
            {
                if (adjAddButton.Checked)
                {
                    Range += Convert.ToInt32(adjTextBox.Text);
                }
                else if (adjDropButton.Checked)
                {
                    Range -= Convert.ToInt32(adjTextBox.Text);
                }
            }
            double Bearing = GetBearing(GunPos, TargetPos);
            
            if (Button60mm.Checked)
            {
                cartridge = cartridges[0];
            }
            else if (Button81mm.Checked)
            {
                cartridge = cartridges[1];
            }
            else if (Button120mm.Checked)
            {
                cartridge = cartridges[2];
            }
            else
            {
                cartridge = cartridges[0];
            }

            Solution = $"Range: {Range}      Bearing: {ToMils(Bearing)}\n";

            for (short i = 0; i < cartridge.Charge.Length; i++)
            {
                double elev = Math.Round(Elevation(Range, cartridge.Charge[i], AltDiff), 2);
                if (double.IsNaN(elev))
                {
                    Solution += $"Charge: {i}      Elev: -      TOF: -\n";
                }
                else
                {
                    Solution += $"Charge: {i}      Elev: {ToMils(elev)}      TOF: {TOF(elev, cartridge.Charge[i], Range)}\n";
                }
            }

            solutionBox.Text = Solution;
        }

        public static double GetBearing(GeoCoordinate gun, GeoCoordinate target)
        {
            double lat1 = gun.Latitude;
            double lon1 = gun.Longitude;
            double lat2 = target.Latitude;
            double lon2 = target.Longitude;

            var dLon = ToRad(lon2 - lon1);
            var dPhi = Math.Log(Math.Tan(ToRad(lat2) / 2 + Math.PI / 4) / Math.Tan(ToRad(lat1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
            {
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);
            }
            return ToBearing(Math.Atan2(dLon, dPhi));
        }

        public static double Elevation(double range, int velocity, double elevationDiff)
        {
            double g = 9.81;
            //in rad
            double elevation = Math.Atan((Math.Pow(velocity, 2) + Math.Sqrt(Math.Pow(velocity, 4) - g * (g * Math.Pow(range, 2) + 2 * elevationDiff * Math.Pow(velocity, 2)))) / (g * range));
            return ToDegrees(elevation);
        }

        public static int TOF(double elevation, int velocity, double range)
        {
            double g = 9.81;
            double time = (2 * velocity * Math.Sin(elevation)) / g;
            double time2 = Math.Sqrt((range * g) + ((velocity * velocity) * (Math.Sin(elevation) * Math.Sin(elevation))));
            time = (time + time2) / 2;
            return (int)Math.Round(time);
        }

        public static double ToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        public static double ToMils(double degrees)
        {
            return Math.Round(degrees * 17.777777777778);
        }

        public static double ToBearing(double rad)
        {
            return (ToDegrees(rad) + 360) % 360;
        }

        public static string LatLongToMGRS(GeoCoordinate coordinates)
        {
            Coordinate coordinate = new Coordinate(coordinates.Latitude, coordinates.Longitude);
            return coordinate.MGRS.ToString();
        }

        private void adjCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            adjBox.Enabled = adjCheckBox.Checked;
        }

        TextBox activeTextBox;
        private void textBox1_Enter(object sender, EventArgs e)
        {
            activeTextBox = (TextBox)sender;
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox activeTextBox = (TextBox)this.ActiveControl;
                if (activeTextBox.SelectionLength > 0)
                {
                    Clipboard.SetText(activeTextBox.SelectedText);
                }
                else
                {
                    Clipboard.SetText(activeTextBox.Text);
                }
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox activeTextBox = (TextBox)this.ActiveControl;
                if (Clipboard.ContainsText())
                {
                    activeTextBox.Text = Clipboard.GetText();
                }
            }
        }
    }
}