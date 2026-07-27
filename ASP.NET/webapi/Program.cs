using Repository;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddScoped<StudentRepository>();
var app=builder.Build();
//StudentRepository repo=new StudentRepository();

app.MapGet("api/students",(StudentRepository repo)=> {return repo.GetStudents();});

app.Run();