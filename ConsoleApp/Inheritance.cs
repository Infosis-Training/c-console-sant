namespace Oop;


//Single
//Multilevel
//Multiple

class Inheritance
{

    class African : Person
    {

    }

    class Asian : Person
    {

    }

    class Nepalese : Asian, ICulture    //multiple Interface is allowed to call
    {
        public void SpeakLang(){

        }
    }

    //Interface
    //It doesnt have logic, only blank method is defined
    interface ICulture{
        public void SpeakLang();
    }

}
