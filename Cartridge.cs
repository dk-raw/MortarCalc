namespace MortarCalc
{
    public class Cartridge
    {
        public string Id { get; set; }
        public int Cal { get; set; }
        public int[] Charge { get; set; }
        //public Dictionary<int, int> ranges { get; set; }

        public Cartridge(string id, int cal, int[] charge/*, Dictionary<int, int> ranges*/)
        {
            this.Id = id;
            this.Cal = cal;
            this.Charge = charge;
            //this.ranges = ranges;
        }
    }
}