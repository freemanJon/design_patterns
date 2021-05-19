# Design patterns
 Repositorio criado para armazenar meus conhecimentos de padrao de projeto
 
 # Strategy
 
<p>Padrao utilizado quando temos diferentes estrategias para realizar alguma acao, por exemplo, temos que calcular imposto sobre algum orcamento, temos diferentes estrategias para calcular imposto como ISS, ICMS, entre outros. Caso voce nao pense em como o seu projeto pode crescer, pode acabar criando uma classe que tem um metodo calculaImposto e que possui diversos ifs, dando para sua classe diversas funcoes e tornando o codigo muito maior, tambem um novo desenvolvedor teria que saber que quando acrescentasse um novo imposto, teria que adicionar um novo if no metodo.</p> 
<p>Utilizando o padrao strategy torna-se possivel o crescimento do projeto sem nenhum problema, como fazer isso? Sabemos que ISS, ICMS, sao tipos de imposto, o padrao consiste em ter uma interface para abstrair os dados, agora voce tem uma interface com o metodo calcula e classes para cada tipo de imposto, entao teremos por exemplo a classe ISS implementando a interface Imposto.</p> 
<img src="images/1.png"/>
<img src="images/2.png"/>
<p>Agora o metodo CalculaImposto nao precisa ter diversos if, ele apenas precisa receber como parametro um imposto, assinatura ficaria CalculaImposto(Imposto), a partir dai ele pode calcular x impostos que existirem sem ter que aumentar a complexidade do codigo da regra de negocio, pois cada tipo de imposto ira implementar a funcao calcula da sua maneira.</p>
<img src="images/3.png"/>
<img src="images/4.png"/>

 
 
