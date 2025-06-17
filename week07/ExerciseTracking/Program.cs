using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager manager = new ActivityManager();

        manager.AddActivity(new RunningActivity("02 Apr 2003", 25, 5.0)); // Date, minutes, distance (km)
        manager.AddActivity(new CyclingActivity("03 Jan 2008", 17, 15.0));
        manager.AddActivity(new SwimmingActivity("19 May 2010", 15, 20));

        manager.DisplaySummaries();
    }
}