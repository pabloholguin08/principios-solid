using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");

/*
using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper<Student> studentExport = new();
studentExport.ExportToCSV(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");
*/