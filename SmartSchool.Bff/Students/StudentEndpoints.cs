using Microsoft.AspNetCore.Mvc;
using SmartSchool.Bff.ApiClients;

namespace SmartSchool.Bff.Students
{
    public static class StudentEndpoints
    {
        public static IEndpointRouteBuilder AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            var students = app.MapGroup("/students");
            students.MapPost("/", async ([FromBody]CreateStudent newStudent, [FromServices] IStudentsApiClients studentClient) =>
            await CreateStudent(studentClient,newStudent))
                .WithName("CreateStudent")
                .Produces(200,typeof(StudentBasicInfo));
            return app;
        }
        public static async Task<IResult> CreateStudent(IStudentsApiClients StudentsClient, CreateStudent newStudent)
        {
            var result = await StudentsClient.CreateStudent(newStudent);
            return TypedResults.Ok(result);
        }
    }
   
}
