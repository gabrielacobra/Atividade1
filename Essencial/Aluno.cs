using System;
using System.IO;
using System.Text;

namespace Atividade1.Essencial
{
    public class Aluno { //Não é para chamar a classe Endereço aqui? //PS: Cadê o meu Program?
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public Endereco End { get; set; }
    }

    public Aluno() 
    {
        
    }

    public Aluno(int id, string nome, string email, int idade, Endereco endereco)
    {
        this.Id=id;
        this.Nome=nome;
        this.Email=email;
        this.Idade=idade;
        this.End=endereco;        
    }

    public Salvar()
    {
        string msg="";
        StreamWriter arquivo =null;
        try{
            arquivo = new StreamWriter("alunos.csv",true);
            arquivo.WriteLine(Id+";"+Nome+";"+Email+";"+Idade+";");        

            msg="Dados salvos com sucesso!";
        }
        catch(Exception ex){
            msg = "Erro ao salvar dados!"+ex.Message; //Pq aqui não usamos o throw new Exception?
        }
        finally{
            arquivo.Close();
        }
        return msg;
    }

    public Aluno Pesquisar (int id) //Pq usamos a classe aluno nesse método?
    {
        
    }
}