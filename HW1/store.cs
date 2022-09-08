//1.1
public class store {
    public static string input_Name(){
        Console.Write("Please input Name:'");
        string Name  = Console.ReadLine();
        return Name;
    }
    public static string input_Number(){
        Console.Write("Please input Number:'");
        string Number  = Console.ReadLine();
        return Number;
    }
    public static string input_Owner_Name(){
        Console.Write("Please input Owner_Name:'");
        string Owner_Name  = Console.ReadLine();
        return Owner_Name;
    }
    public static string input_Value(){
        Console.Write("Please input Value:'");
        string Value  = (Console.ReadLine());
        return Value;
    }
    public static string check_NameAndOwnerName (string inputX){
        if (int.TryParse(inputX,out int Value)){
            throw new Exception("Please input a-z or A-Z."); 
        }
        return inputX;
    }
    public static double check_NumberAndValue (string inputX){
        if (double.TryParse(inputX,out double Value)){
            return Value;
        }
        throw new Exception("Please input numeric."); 
    }
    public static void printstore(string Name,double Number,string Owner_Name,double Value){
        Console.WriteLine("-------------------------");
        Console.WriteLine("Name: {0}",Name);
        Console.WriteLine("Number: {0}",Number);
        Console.WriteLine("Owner_Name: {0}",Owner_Name);
        Console.WriteLine("Value: {0}",Value);
        Console.WriteLine("-------------------------");
        return;
    }


    public static void storeX(){      

        string SName = input_Name();
        string Name = check_NameAndOwnerName(SName);

        string SNumber = input_Number();
        double Number = check_NumberAndValue(SNumber);

        string SOwner_Name = input_Owner_Name();
        string Owner_Name = check_NameAndOwnerName(SOwner_Name);
        
        string SValue = input_Number();
        double Value = check_NumberAndValue(SValue);

        printstore( Name, Number, Owner_Name, Value);
    }
}
