namespace factory
{
    public class HotelInfo
    {
        public string Town { get; set; }
        public string HotelName { get; set; }
        public override string ToString()
        {
            return string.Format("{0} in {1}", this.HotelName, this.Town);
        }
    }
}