
namespace Interfaces.clases
{
    public class Box : ICaja, IDimension
    {
        public bool IsOpen {get; set;}
        public string Color { get; set; }
        public string ShowContent {get; set;}
        public double Long {get; set;}
        public double Width {get; set;}
        public Box()
        {
        }

        public Box(bool isOpen, string color, string showContent, double lon, double width)
        {
            IsOpen = isOpen;
            Color = color;
            ShowContent = showContent;
            Long = lon;
            Width =width;
        }
        public void Open()
        {
            if (!IsOpen)
            {
                IsOpen = true;
            }
        }
        public void Close()
        {
            if (IsOpen)
            {
                IsOpen = false;
            }
        }

        public string Measure()
        {
            return $"| {Long} x {Width} |";
        }
    }
}