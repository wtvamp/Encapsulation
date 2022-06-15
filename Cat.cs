class Cat {
    public bool hasFur;
    public bool hasWhiskers;
    private string color;
    private string typeOfMeow;
    private String[] notAcceptableTypeOfMeows = {"fuck", "shit", "yo mama", "damn", "bullshit"};
    private String[] acceptableColors = {"blue", "green", "pink", "blue-green"};

    public Cat(bool hasFur,
               bool hasWhiskers,
               string color, 
               string typeOfMeow)
    {
        this.hasFur = hasFur;
        this.hasWhiskers = hasWhiskers;
        this.Color = color;
        this.typeOfMeow = typeOfMeow;
    }

    public string Color
    {
        get => color; set
        {
            if (acceptableColors.Contains(value)) {
                color = value;
            }
            else {
                
                color = "rainbow";
            }
        }
    }

    public string TypeOfMeow
    {
        get => typeOfMeow; set
        {
            typeOfMeow = value;
            foreach(String itemInBlackList in notAcceptableTypeOfMeows) {
                if (value.Contains(itemInBlackList)) {
                    typeOfMeow = "You kiss your mother with that mouth??";
                }
            }
        }
    }

    public String Meow(string typeOfMeow) {
        this.TypeOfMeow = typeOfMeow;
        if (hasWhiskers == true) {
            return "The cat says " + this.TypeOfMeow + ".";
        }
        else {
            return "I don't think this is a cat...";
        }
    }
}