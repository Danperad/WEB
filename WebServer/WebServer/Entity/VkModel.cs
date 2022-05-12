namespace WebServer.Entity;

public class VkModel
{
    public class Response
    {
        public class Friend
        {
            public class City
            {
                public int id { get; set; }
                public string title { get; set; }
            }
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string bdate { get; set; }
            public City city { get; set; }
        }
        public int count { get; set; }
        public Friend[] items { get; set; }
    }
    public Response response { get; set; }
}