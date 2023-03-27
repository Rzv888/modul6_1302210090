using System;


namespace modul6_1302210090
{
    internal class SayaTubeVideo{
        private int id;
        private String Title;
        private int playCount;

        public SayaTubeVideo(String Title)
        {
            this.Title = Title;
            Random rn = new Random();
            this.id = rn.Next(1000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount){
            this.playCount += playCount;

        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Play count: " + this.playCount);
        }
        public int getplayCount()
        {
            return this.playCount;
        }
        public String getTitle()
        {
            return this.Title;
        }
    }
}
