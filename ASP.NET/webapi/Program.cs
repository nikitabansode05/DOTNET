using Repository;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddScoped<StudentRepository>();
var app=builder.Build();

app.MapGet("api/students",(StudentRepository repo)=> {return repo.GetStudents();});
app.MapPut("api/students",(StudentRepository repo)=> {return repo.updateStudent();});
app.MapDelete("api/students",(StudentRepository repo)=>{return repo.deleteStudent(14);});
app.Run();