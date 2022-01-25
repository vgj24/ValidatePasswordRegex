// See https://aka.ms/new-console-template for more information
using RegexAssgn;
Console.WriteLine("Regex Password assignment");
RegexPasswordPgm rg=new RegexPasswordPgm();
#region validatefirstname
if (rg.ValidateFirstname("Neha")) 
{
    Console.WriteLine("  :Valid"); 
}
else {
    Console.WriteLine("  :invalid"); 
}
#endregion
#region validate Lastname
if (rg.ValidateLastname("Joshi"))
{
    Console.WriteLine("  :valid");
}
else
{
    Console.WriteLine("  :invalid");
}
#endregion
#region validate email
if (rg.ValidateEmail("abc@1.com"))
{
    Console.WriteLine("  :valid");
}
else
{
    Console.WriteLine("  :invalid");
}
#endregion
#region to pass all givenmails
/*to validdate all emailid
 * abc@yahoo.com
 * abc-100@yahoo.com
 * abc.100@yahoo.com
 * abc11@yahoo.com
 * abc_100@abc.net
 * abc.100@abc.com.au
 * abc@1.com
 * abc@gmail.com.com
 * abc+100@gmail.com
*/
#endregion
#region validae mobilenumbr
if (rg.ValidateMobileNumber("91 7022334411"))
{
    Console.WriteLine("   :valid");
}
else
{
    Console.WriteLine("  :inavalid");
}
#endregion
#region validate Pwd
if (rg.ValidatePassword("a3@Ndshj"))
{
    Console.WriteLine("  :valid");
}
else
{
    Console.WriteLine("  :invalid");
}
#endregion
Console.ReadKey();