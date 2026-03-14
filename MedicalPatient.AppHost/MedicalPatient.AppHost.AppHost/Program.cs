var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MedicalPatient_Generator>("medicalpatient-generator");

builder.Build().Run();
