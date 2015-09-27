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
	2. Descompacte o arquivo .zip. (I M P O R T A N T E) - Por favor observe esta construção do diretório onde está a base de dados. Caso queira trocar o local, favor trocar dentro da HomeController.cs (private IEnumerable<Client> ResultFromClient(ClientFilter filter))  
	3. DataSource=(LocalDB)\v11.0;AttachDbFilename='C:\Cursos\Testes\MVCWebApp\App_Data\Database.mdf'
	4. Abre este o arquivo MVCWebApp.sln (solução) no Microsoft Visual Studio Professional 2013 ou Visual Studio 2013 Community Edition.
	5. Execute-o com o comando Run. (http://localhost:55832/Account/Login) 

# Telas do sistema
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
