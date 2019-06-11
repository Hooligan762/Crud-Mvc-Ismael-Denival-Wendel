# **PROJETO: CRUD-MVC com API**
    Equipe: Denival, Ismael e Wendell.
    Linguagem utilizada: C#
    Framework utilizado: ASP.NET
    IDE utilizada: Microsoft Visual Studio - Método de desenvolvimento colaborativo em tempo real(Live Share).
    Postman: navegador para os desenvolvedores


## DESENVOVIMENTO CRUD em MVC
* **Criamos um class _"Pessoa.cs"_ dentro da pasta _"Models"_ e em seguida.**
    * **Criamos atributos com: nome, sexo, endereço, telefone e e-mail. O _[Key]_ foi Criado para que a bibliotaca _"Entity"_ importada entenda que o Id é uma chave primaria.**

    ```
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
    ```
* **Criamos outra class com o nome _"contexto.cs"_ dentro da pasta "Models".**
    * **Criação da class do banco _"DbContext"_ que irá herdar da classe _"contexto"_.**
    * **Em seguida criamos um "DbSet" e um Arry com a class < pessoa > com os atributos get e set.**
    ```
      public class Contexto: DbContext
     {
       public DbSet<Pessoa> Pessoas { get; set; }
     }
    ```
* **Na pasta "Controllers" criamos um controlador Scaffold Web Api2 que é framework gerador de códigos que irá criar o crud.**
    * **Dentro do controlador foi craido Get, Post, Edit e Del.**
* **Dentro da pasta "Shared" abrimos o arquivo "layout.html" e o editamos criando um link para apresentar na pagina inicial do site.**

```
<li>@Html.ActionLink("Cadastro", "Index", "Pessoas")</li>

 ```
_**Agora vamos amostrar como o crud Fico**!_

## Index
![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_5.png)


## Create
![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_6.png)


## Registro

![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_7.png)

## Editar

![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_8.png)

## Deletar 
![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_9.png)

## Deletado

![Crud](https://d2m498l008ebpa.cloudfront.net/2016/10/img_10.png)


# Web Api Restfull  

* **Criamos uma Class _"Usuario.cs"_ dentro da pasta "Models" e em seguida.**
    * **Criamos atributos com: nome, sexo, endereço, telefone e e-mail.**

    ´´´
     public class Usuario
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string telefone{ get; set; }
        public string email { get; set; }

        public Usuario(string nome, string sexo, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }
    ´´´
* **Na pasta "Controllers" criamos um controlador com o nome "UsuariosControllers.cs" onde irá fazer as operações de Busca, Inserção, Edição e Deletação. [HttpGet],[httpPost],[HttpPut],[HttpDelete].**
    * **ApiConntroller ela está herdando da Class UsuarioController, a ApiController  é uma class padrão da APi , onde tem as propiedades e metodos já estão ontidas nela.**

```
public class UsuariosController : ApiController
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        public List<Usuario> Pegar()
        {
            return usuarios; 
        }

        [HttpPost]
        public void enviar(string nome, string sexo, string endereco, string telefone, string email)
        {
            if (!string.IsNullOrEmpty(nome))
                usuarios.Add(new Usuario(nome, sexo, endereco, telefone, email));
        }
        
        public void Delete(string nome)
        {
            usuarios.RemoveAt(usuarios.IndexOf(usuarios.First(x => x.nome.Equals(nome))));
        }
    }
}


```
_**Depois de ter feito o Controller, precisamos testar. para isso precisamos de uma Ferramenta chama da Postman.**_

## Postam

* **Abra seu Google Chorme** _https://chrome.google.com/webstore/search/postman_

![Postman](https://developercielo.github.io/images/documentos-adicionais/tutorial-postman/p1.png)

* **Depois de ter Instalado a Ferramenta iremos testar.**

_**1. Copie o Link irá ser informado na pagina, quando você iniciou o projeto e Cole o link no Postman.**_


_**2. Abrindo o Postman e insirido o Link, http://localhost2631/api/Usuario. o /Usuario é o nosso Controller que criamos com o nome Usuario._** 

![Postman](https://debugsolutions.files.wordpress.com/2017/01/p2.png?w=999&h=833)

_**3.Agora na Opção [GET] Cliamos em [Send] como fazer a chamada [Get] que já identificamos nosso controller. em seguida ele irá no UsuarioController e chamar o método [httpGet].**_

![Postman](https://developercielo.github.io/images/documentos-adicionais/tutorial-postman/p1.png)

_**4. Na Opção [POST] vamos passar alguns parametros que será adicionado e retornar os valores insiridos.**_

![Postman](https://s3.amazonaws.com/postman-static-getpostman-com/postman-docs/requestBuilderUrlEncoded.png)


_**5. Na Opção [DEL] irá escolher um dos paramentros insiridos e Clicar em Send para deletar o paramento.**_




