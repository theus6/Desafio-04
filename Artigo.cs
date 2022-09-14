public class Artigo : Autor
{
    public string Titulo {get;set;}
    public string Palavraschave {get;set;}
    public string Instituicao {get;set;} 
    Autor Autor = new Autor();

    public List<Autor> Autores{get;set;} = new List<Autor>();

    public void Registro(Autor autor, string titulo, string instituicao, string palavraschave)
    {
        Autores.Add(Autor);
        this.Titulo = titulo;
        this.Instituicao = instituicao;
        this.Palavraschave = palavraschave;
    }
}