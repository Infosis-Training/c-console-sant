using System;
class Properties
{
    string _Name;

    //Full Property
    public string Name{
        get{
            return _Name;
        }
        set{
            if(value.Length >= 2){
                _Name = value;
            }
        }
    }

    //Auto implemented Property
    public double Average{get; set;}
}