using static System.Console; 

Artigo a1 = new Artigo();
Artigo a2 = new Artigo();

Autor at1 = new Autor();
Autor at2 = new Autor();
Autor at3 = new Autor();

at1.Nome = "Matheus Silva";
at1.Email = "matheus123@gmail.com";

at2.Nome = "J R R Tolkien";
at2.Email = "tolkienbr1@gmail.com";

at3.Nome = "Sarah J Maas";
at3.Email = "sarahj2010@gmail.com";

Write(" \n# # # Sistema de Registros de Artigos # # #\n ");

Write("\nQual é o titulo do artigo?\n");
string titulo = ReadLine();

Write("\nQuais são as palavras chaves?\n");
string palavraschave = ReadLine();

Write("\nQual é a instituição?\n");
string instituicao = ReadLine();

Write("\nQual é o nome do autor?\n");
string nomea = ReadLine();

a1.Registro(at1, titulo, instituicao, palavraschave);

if (at1.Nome == nomea)
{
    WriteLine("\nAutor encontrado no sistema!\n");
    Write("Registro realizado com sucesso!\n");
    Write($"Titulo:{titulo}\n");
    Write($"Autor:{nomea}\n");
    Write($"Instituição:{instituicao}\n");
    Write($"Palavras-Chave:{palavraschave}\n");

}
else if (at2.Nome == nomea)
{
    Write("\nAutor encontrado no sistema!\n");
    Write("Registro realizado com sucesso!\n");
    Write($"Titulo:{titulo}\n");
    Write($"Autor:{nomea}\n");
    Write($"Instituição:{instituicao}\n");
    Write($"Palavras-Chave:{palavraschave}\n");

}
else if (at3.Nome == nomea)
{
    Write("\nAutor encontrado no sistema!\n");
    Write("Registro realizado com sucesso!\n");
    Write($"Titulo:{titulo}\n");
    Write($"Autor:{nomea}\n");
    Write($"Instituição:{instituicao}\n");
    Write($"Palavras-Chave:{palavraschave}\n");

}
else
{
    Write("\nError!! Autor não encotrado!!!\n");
}

Write("\nDeseja registrar mais algum artigo?\n");
Write("1 = sim || 0 = não");
int op = int.Parse(ReadLine());

if (op == 1)
{
    Write(" \n# # # Sistema de Registros de Artigos # # #\n ");

    Write("\nQual é o titulo do artigo?\n");
    string titulo2 = ReadLine();

    Write("\nQuais são as palavras chaves?\n");
    string palavraschave2 = ReadLine();

    Write("\nQual é a instituição?\n");
    string instituicao2 = ReadLine();

    Write("\nQual é o nome do autor?\n");
    string nomea2 = ReadLine();

    a2.Registro(at2, titulo2, instituicao2, palavraschave2);

    if (at1.Nome == nomea2)
    {
        WriteLine("\nAutor encontrado no sistema!\n");
        Write("Registro realizado com sucesso!\n");
        Write($"Titulo:{titulo2}\n");
        Write($"Autor:{nomea2}\n");
        Write($"Instituição:{instituicao2}\n");
        Write($"Palavras-Chave:{palavraschave2}\n");

    }
    else if (at2.Nome == nomea2)
    {
        Write("\nAutor encontrado no sistema!\n");
        Write("Registro realizado com sucesso!\n");
        Write($"Titulo:{titulo2}\n");
        Write($"Autor:{nomea2}\n");
        Write($"Instituição:{instituicao2}\n");
        Write($"Palavras-Chave:{palavraschave2}\n");

    }
    else if (at3.Nome == nomea2)
    {
        Write("\nAutor encontrado no sistema!\n");
        Write("Registro realizado com sucesso!\n");
        Write($"Titulo:{titulo2}\n");
        Write($"Autor:{nomea2}\n");
        Write($"Instituição:{instituicao2}\n");
        Write($"Palavras-Chave:{palavraschave2}\n");

    }
    else
    {
        Write("\nError!! Autor não encotrado!!!\n");
    }
}
else
{
    Write("Até a próxima ! ! !");
}