 
## Requisitos
1. .Net 7 ou superior;
2. Angular CLI;
3. Visual Studio ou VS Code;

 ## Como executar  
 1. Clone o repositório. `gh repo clone ElisBAmorim/Calculation-Simulator`;
 3. Abra a Solução no Visual Studio: `.sln`;
 4. Restaure as Dependências
     * Projetos .NET, você pode restaurar as dependências usando o NuGet Package Manager.
     * Projeto Angular, navegue até a pasta `CalculationSimulatorWeb` e execute npm install.

 ## Executando
 - Configure o projeto para inicializar.
    1. Com o botão direito clique em cima do projeto `CalculationSimulatorAPI`;
    2. `set as Startup project`;    
    3. Pressione `F5`; 

 - Aplicativo Angular.
     1. Navegue até a pasta  `CalculationSimulatorWeb` e execute `ng serve`. Se o broser não inicializar pode acessar em `http://localhost:4200`;      

  ### Testes Unitarios
   Para executar os testes unitários, você pode usar o Test Runner do Visual Studio ou
   dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
