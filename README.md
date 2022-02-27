# --- CREATE ---
# Create Solution and projects
  mkdir <folder>
  mkdir <code>
  mkdir <test>

# Create Projects on each new folder
  dotnet new webapi -n <projectName>  
  dotnet new xunit -n <projectName.Test>

# Create solution
  dotnet new sln --n <SolutionName>

# Add Projects to solution
  dotnet sln <solutioName> add <projectName>

# Add reference for Project to Test Project
  dotnet add <projectName.test> reference <projectName>

# ---BUILD & RUN---
  # Go to solution path <E:\Repos\AzureSln>
  dotnet build
  
  # Go to project path <E:\Repos\AzureSln\code\SimpleAPI\ or test>
  dotnet run
  (project in https://localhost:7253/api/clima)

  Swagger: https://localhost:7253/swagger/index.html

# DevOps Azure: https://dev.azure.com/mpolox/
# update



# Tutorial from: https://www.youtube.com/watch?v=SOtC1VLZKm4&list=WL&index=9&ab_channel=LesJackson