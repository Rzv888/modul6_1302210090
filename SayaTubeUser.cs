using System;

namespace modul6_1302210090
{
    internal class SayaTubeUser{
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String Username;

        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            Random rn = new Random();
            this.id = rn.Next(1000, 9999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount(){
            int total = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                total = uploadedVideos[i].getplayCount();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                 uploadedVideos[i].PrintVideoDetails();
            }
        }
    }
}
