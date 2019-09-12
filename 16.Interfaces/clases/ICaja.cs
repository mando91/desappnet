namespace Interfaces.clases
{
    public interface ICaja
    {
        bool IsOpen {get; set;}
        string Color { get; set; }
        string ShowContent{get; set;}
        void Open();
        void Close();
    } 
}