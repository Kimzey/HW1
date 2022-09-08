//1.2
public class change{
    public static string input_change (){
        Console.Write("input ValueTochange :");
        string value = Console.ReadLine();
        return value;
    }
    public static double check_Value(string value){
        if (double.TryParse(value,out double Value_change))
        {
            if (Value_change > 0){
            return Value_change;}
        }
        throw new Exception("Please input numeric/(>0)  ."); 
    }

    public static double[] change_Value(double Value_change){
        double[] money = {1000,500,100,50,20,10,5,2,1,0.50,0.25}; 
        double[] getmoney = {0,0,0,0,0,0,0,0,0,0,0};

        for (int i =0; i < money.Length; i++){
        getmoney[i] = Math.Floor(Value_change/money[i]);
        Value_change = Value_change%money[i];
        Console.WriteLine("{0} : {1}",money[i],(getmoney[i]));
        }
        return getmoney;
    }   
    public static void changeX(){
        string Value = input_change ();
        double Value_change = check_Value(Value);
        double[] final_change = change_Value(Value_change);

        //for chaek Value of Array final_change
        // for (int i = 0; i < 12 ;i++){
        // Console.WriteLine(final_change[i]);
        // }
    }
}