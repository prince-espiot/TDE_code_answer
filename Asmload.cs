using System;
using System.Reflection;

public class Asmload0
{
    public static void Main()
    {	
		//Dynamically load assembly from file 
		//dynamically load assembly from the file c:\Test1.dll 
		Assembly myassembly = Assembly.LoadFile(@”c:\Test1.dll”);
		
		//To get the type of class SmartCalcu 
		Type SmartCalcType = myassembly.GetType(“Test1.SmartCalc”); 
		
		//Create an instance of class SmartCalc 
		Object SmartCalcInstance = Activator.CreateInstance(SmartCalcType); 
		
		//To get the public property info and value 
		PropertyInfo PropertyInfoNumber = SmartCalcType.GetProperty(“NewNumber”); 
		Double PropertyValue = (double) PropertyInfoNumber.GetValue(SmartCalcInstance); 
		
		
		//To set the property value to 9.0 
		PropertyInfoNumber.SetValue(SmartCalcInstance, 9.0);


    }
}