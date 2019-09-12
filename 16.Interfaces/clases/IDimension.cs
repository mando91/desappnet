namespace Interfaces.clases
{
    interface IDimension
    {
        double Long {get; set;}
        double Width {get; set;}

        string Measure();
    }
}