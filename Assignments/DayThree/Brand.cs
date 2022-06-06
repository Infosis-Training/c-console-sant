//Derived class on 2 should implement this interface
public class Brand:Laptop, IDetails
{
    //Add one readonly property in it
    public string Vendor{get; private set;}

    //one static method
    public void VendorEmail(){
        //
    }

    //Implementaion of Interface is mandatory
    public void CpuType()
    {
        
    }

    public void DisplaySize()
    {
        
    }
}
