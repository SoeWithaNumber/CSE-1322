using System;
class BlueRayDisk{
    string title, director;
    int yearOfRelease;
    double cost;
    public BlueRayDisk(string title, string director, int yearOfRelease, double cost){
        this.title = title;
        this.director = director;
        this.yearOfRelease = yearOfRelease;
        this.cost = cost;
    }
    public override string ToString()
    {
        return String.Format("${0} {1} {2}, {3}", cost, yearOfRelease, title, director);
    }
}