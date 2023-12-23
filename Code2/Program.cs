// Theory answer : Class is blueprint of object. ;

var p1 = new Post();
p1.Title = "Tourism";
p1.Description = "I'm in London";
p1.LikeCount = 5;
p1.Like();
p1.Comment("Best city");
p1.Publish();
//-------------------------
var p2 = new Post();
p2.Title = "Work";
p2.Description = "I work in SoftClub";
p2.LikeCount = 3;
p2.Like();
p2.Comment("I want to work in Softclub");
p2.Publish();
//-------------------------
var p3 = new Post();
p3.Title = "Teaching";
p3.Description = "I'm teach c# ";
p3.LikeCount = 120;
p3.Like();
p3.Comment("I'm teach english");
p3.Publish();
//-------------------------
var p4 = new Post();
p4.Title = "Sport";
p4.Description = "I'm a football player";
p4.LikeCount = 102;
p4.Like();
p4.Comment("i'm a boxer");
p4.Publish();
//-------------------------
var p5= new Post();
p5.Title = "Tourism";
p5.Description = "I'm in London";
p5.LikeCount = 65;
p5.Like();
p5.Comment("Best city");
p5.Publish();

List<Post> alposts = new List<Post>();
alposts.Add(p1);
alposts.Add(p2);
alposts.Add(p3);
alposts.Add(p4);
alposts.Add(p5);
foreach (var item in alposts)
{
    System.Console.WriteLine($"{item.Title}-{item.Description} - number of Likes {item.LikeCount}");
    System.Console.WriteLine("----------------------------------------------------");
}



















class Post{
    public string Title { get; set; }
    public string Description { get; set; }
    public int  LikeCount { get; set; }
    public List<string> Comments = new List<string>();
    public bool IsPublished;


    public string Publish(){
     return "The post is published.";
     this.IsPublished = true;
    }

    public void Like(){
        LikeCount++;
    }
    public void Comment(string message){
        this.Comments.Add(message);
    }

} 