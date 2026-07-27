using Repository;

var builder=WebApplication.CreateBuilder(args);

builder.Services.AddScoped<StudentRepository>();
var app=builder.Build();

app.MapGet("api/students",(StudentRepository repo)=> {return repo.GetStudents();});
app.MapPut("api/students/id/{id}/name/{name}",(StudentRepository repo,int id,string name)=> {return repo.updateStudent(id,name);});
app.MapDelete("api/students",(StudentRepository repo)=>{return repo.deleteStudent(14);});
app.Run();