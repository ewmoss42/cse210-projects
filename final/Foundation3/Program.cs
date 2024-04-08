using System;

class Program
{
    static void Main(string[] args)
    {
       
        LectureEvent LE = new LectureEvent("Lecture", "Pyton Basics", "Introduction to Python programming", "4th of April", "7pm", "Blackfoot South Stake Center Building","William Thompson", "200");
        Console.WriteLine(LE.GetStandard());
        Console.WriteLine(LE.GetFullLecture());
        Console.WriteLine(LE.GetShort());
        ReceptionEvent RE = new ReceptionEvent("Reception", "Samuel and Jennifer's Wedding", "A small reception to celebrate our wedding", "March 14th", "6pm", "204 Johnson rd, Blackfoot ID 83221", "ubenhaded@gmail.com");
        Console.WriteLine(RE.GetStandard());
        Console.WriteLine(RE.GetFullReception());
        Console.WriteLine(RE.GetShort());
        OutdoorEvent OE = new OutdoorEvent("Outdoor", "Young Mens Campout", "Enjoy Camping in the park with food and games", "Saturday the 1st", "9am", "Blackfoot South Stake Building", "Cloudy");
        Console.WriteLine(OE.GetStandard());
        Console.WriteLine(OE.GetFullOutdoor());
        Console.WriteLine(OE.GetShort());
        

    }
}