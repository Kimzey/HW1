namespace Testpro;

public class UnitTest1
{
    //1.1
    [Fact]
    public void Testcheck_NameAndOwnerName(){
        string Text = store.check_NameAndOwnerName("Kim");
        Assert.IsType<string>(Text);
    }
    [Fact]
    public void Testcheck_NumberAndValue(){
        double Number = store.check_NumberAndValue("64120501003");
        Assert.IsType<double>(Number);
    }
    //1.2
    [Fact]
    public void Testcheck_Value(){
        double Number = change.check_Value("5120.25");
        Assert.IsType<double>(Number);
    }
    [Fact]
    public void TestchangeValue(){
        double [] awsChange = change.change_Value(5120.25);
        double [] CheakChange = {5,0,1,0,1,0,0,0,0,0,1};
        Assert.Equal(awsChange,CheakChange);
    }
}
