//1- By Convention [Default Behaviour]
internal class Employee
{

   
    {
        public int Id { get; set; }//public numeric Property Named As
                                   //"Id", "EmployeeId"=>Pk identity (1,1)
        public string? Name { get; set; }// nvarchar(max)
                                         //.net 5: Refernce Type: Allow Null [optional]
                                         //.net 6: Refernce Type: Not Allow Null [Required]
                                         //Nullable<string>
        public decimal Salary { get; set; } // decimal(18,2) 
        public int? Age { get; set; }  // Nullable <int>
    }














}
