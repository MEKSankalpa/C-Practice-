class User {

    public User(string university) {
        names = new List<string>();
        this.university = university;   
    }

    public void AddUser(string name)
    {

        names.Add(name);


    }

    private List<string> names;
    private string university;

}