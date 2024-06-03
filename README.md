  # Simulador de Cálculo Financeiro - Desafio
  O desafio consiste em desenvolver uma interface web e uma API. 
  A interface web permite a entrada de valores, como o montante a ser aplicado e o número de meses. A API recebe esses valores, realiza o cálculo necessário e, em seguida, os valores de resultado são exibidos na tela.

 ## CalculationSimulatorAPI
  - Acesso ao Swagger: `https://localhost:8080/swagger/index.html`
  - Endpoint: `/v1/calculate/cdb`
  - Método: POST
  - Content-Type: `application/json`
  - Body:
     - Valor a ser aplicado:`applicationValue`;
     - Número de meses: `numberOfMonths`;
  - Response:
     - Valor Bruto: `grossValue`;
     - Valor Líquido: `netValue`;
  
## CalculationSimulatorWeb
   - Acesse a página em `http://localhost:4200`;
   - Insira o valor a ser aplicado e o número de meses;
   - Clique no botão `Simular` para obter o resultado;

     ![image](https://github.com/ElisBAmorim/Calculation-Simulator/assets/98433316/277bcc00-eca5-4916-8fda-976ccc152c9b)

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
     
      ![image](https://github.com/ElisBAmorim/Calculation-Simulator/assets/98433316/7871796e-7ed1-436b-8c0e-14f53776af31)

   3. Pressione `F5`;

 - Aplicativo Angular.
     1. Navegue até a pasta  `CalculationSimulatorWeb` e execute `ng serve`.

         ![image](https://github.com/ElisBAmorim/Calculation-Simulator/assets/98433316/d98ede30-10a4-49c4-ad1d-faea60e43fe8)



  ### Testes Unitarios
   Para executar os testes unitários, você pode usar o Test Runner do Visual Studio.
