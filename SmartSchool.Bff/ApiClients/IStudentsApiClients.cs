using Refit;

namespace SmartSchool.Bff.ApiClients
{
    public interface IStudentsApiClients
    {
        [Post("/students")]
        Task<StudentBasicInfo> CreateStudent([Body]CreateStudent newStudent);
    }
    public record CreateStudent(string RollNumber,string FirstName, string LastName,DateTime DateOfBirth);
    public record StudentBasicInfo(int StudentId,string RollNumber, string FirstName,string LastName,string Email, DateTime DateOfBirth ,int Age);
}
