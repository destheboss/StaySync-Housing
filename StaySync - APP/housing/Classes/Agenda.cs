using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    public class Agenda
    {
        public int ID { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Description { get; set; }
        public string DescriptionList { get; set; }

        public Agenda(int id, int day, int month, int year, string start, string end, string title, string desc)
        {
            this.ID = id;
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Start = start;
            this.End = end;
            this.Title = title;
            this.Desc = desc;
            this.DescriptionList = $"▶ {desc} ◀ \nDate: {day}/{month}/{year} \nStart: {start} ⦿ End: {end}";
            this.Description = $"{day}-{month}-{year} ■ {title}";
        }

        public string GetAgendaInfo()
        {
            return $"{ID}  ╠ {Description}";
        }
    }
}