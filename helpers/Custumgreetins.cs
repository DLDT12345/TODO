using System ;

namespace projeto_blazor.Client.helpers

{
    public class Custumgreetins
    {
        
        public static string customGree(string value){
            return value.ToUpper() + "hoje é " + DateTime.Today;
        }
    }
}