class Comment{

    protected string _name;
    protected string _comment;

    // public Comment(string name, string comment){
    //     this.name = name;
    //     this.comment = comment;
    // }


    List<string> names= new List<string>{
        "Xueli",
        "Jade",
        "Laurn",
        "Will"
    };

    List<string> comments = new List<string>{
        "You are looking good!!!",
        "Good jobs!!!",
        "This video looks great!",
        "This video is amazing!"
    };

    public Comment(){
        
        Random random = new Random();
        int randomIndex = random.Next(names.Count);
        _name = names[randomIndex];
        _comment= comments[random.Next(comments.Count)];


    }
 
    public void display(){
        Console.WriteLine($"{_name}\n \"{_comment}\" \n \n");
    }

}

