# Customer Contact Management - Pratical Test
	Candidato: Aldonei de Avila Souza (aldoneiavila@gmail.com)

# Dados Técnicos
	Linguagem: C#
	Ferramenta de desenvolvimento: Microsoft Visual Studio Professional 2013
	Arquitetura: ASP.NET MVC 5
	Framework: .NET Framework 4.5
	Front-end Framework: Bootstrap
	Entity Framework
	Sql Server - MDF (Master Data File)

# Realização de Testes
	Testes realizados no Google Chrome

# Instalação
	1. Faça download do arquivo zip: Stefanini-master.zip.
	2. Descompacte o arquivo .zip. (I M P O R T A N T E) - Por favor observe esta construção do diretório onde está a 		base de dados. Caso queira trocar o local, favor trocar dentro da HomeController.cs (private IEnumerable<Client>		ResultFromClient(ClientFilter filter))  
	3. DataSource=(LocalDB)\v11.0;AttachDbFilename='C:\Cursos\Testes\MVCWebApp\App_Data\Database.mdf'
	4. Abre este o arquivo MVCWebApp.sln (solução) no Microsoft Visual Studio Professional 2013 ou Visual Studio 2013 		Community Edition.
	5. Execute-o com o comando Run. (http://localhost:55832/Account/Login) 

# Telas do sistema
	Basicamente existem 4 telas: As mais importantes são a de login (User Identification) e a listagem dos clientes 		(Customer List). Também tem-se	uma Solution Explanation que informa o que deve ser feito, e uma última para enxer 	linguiça que não serve para nada, a tela de Contact.   
	
	LOGIN
	1. Formulário de Login para identificar usuários do sistema com Usuário e Senha (Login.cshtml). 
	2. ID - Usuário - Senha (MD5) - Apenas uma ilustração. Os usuário cadastrados estão logo abaixo.
	3. 682ca6cd-6502-4ae3-bf45-5153beb9c0a0	Admin 0ae67d1-e32b-4275-9cc9-7236771daeec
	3. a21a1944-a66b-46b7-a4e7-d8c98946752f	Aldonei	2c472d74-eb77-45ca-859b-eddf090f22d2
	4. ac75b716-b992-47a0-979c-abb70f471b08	Seller2	d313d06c-a43f-4ef6-9f4f-d12259df0709
	5. e784a30d-e33e-42e4-9387-cc92c2ca7e95	Seller1	c55e5fbb-e0ba-4a87-b100-30ee91d4cad6
	
	User Name: Admin
	Password: admin123

	User Name: Seller1
	Password: seller1
	
	User Name: Seller2
	Password: seller2
	
	CUSTOMER LIST
	A Customer List não tem nada de especial. Basicamente informar os dados e pesquisar. Somente chamar a atenção
	para os campos Last Purchase. O JQuery estava de mal comigo e sem paciência e sem muito tempo para dar atenção
	para a rebeldia dele. Este dois campos ficaram livres. Logo a data deve ser informada corretamente (dd/MM/YYYY). Por
	exemplo 12/01/1990 until 26/09/2015. Caso não seja, não vai listar nada, pois quando dar o POST da consulta será
	validado esta data. 
	a) Pode-se deixar tudo em branco. 
	b) Colocar somente a data incial. O sistema assumirá a data corrente do uso do sistema como data final.
	c) Se colocar somente data final o sistema assumirá 01/01/1901 como data inicial.
	d) Se a entrada das datas a final for menor que a inicial. Não traz nada, pois não é um período válido. 
	
# Observações finais
	1. Procurei seguir as orientação do documento enviado. Apenas na tela de Login eu troquei o e-mail pelo User Name. 		Achei mais apropriado e de qualquer forma não atrapalhava na execução do sistema.
	2. Obtive algumas informações do site da Microsoft para obter alguma ajuda quando me apertei. 
	3. O Bootstrap é um pouco novo para mim, ainda estou aprendendo a usá-lo
	4. Tive problema com o JQuery, não descobri ainda o que foi.
	5. P R O B L E M A que consumiu algum tempo desnecessário foi que em algumas tabelas o GUID estava com letras 			maúsculas e outras minúsculas. Por exempo o GUID RegionId na tabela Client estava com o GUID minúsculo, no entanto 	na tabela Region este GUID estava maiúsculo, ou seja, comparava b100-30ee91d4cad6 com B100-30EE91D4CAD6 			(Region.Id.Equals(Client.Region.Id) = Restulado NULL.
	6. Havia combinado para entregar no Domingo à tarde às 15 horas e isto foi antecipado para Sábado à tarde às 15 		horas.
	7. Como o tempo foi reduzido, alguns procedimentos não ficaram como eu gostaria que ficasse. Isto eu comentei no
	código fonte.
