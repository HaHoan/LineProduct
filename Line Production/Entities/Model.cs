namespace Line_Production.Entities
{
    public partial class Model
    {
        public string ModelID { get; set; }
        public double Cycle { get; set; }
        public bool BarcodeEnable { get; set; }
        public int Arlarm { get; set; }
        public int ArlarmHeight { get; set; }
        public int? Length { get; set; }
        public string Regex { get; set; }
        public int People { get; set; }
        public int PcbBox { get; set; }
        public string CustomerID { get; set; }
    }
}
