using static System.Console; 

Artigo a1 = new Artigo();
Artigo a2 = new Artigo();
Artigo a3 = new Artigo();
Artigo a4 = new Artigo();

Autor at1 = new Autor();
Autor at2 = new Autor();
Autor at3 = new Autor();

List<Autor> autores = new List<Autor>();

at1.Nome = "Matheus Silva";
at1.Email = "matheus123@gmail.com";

at2.Nome = "J R R Tolkien";
at2.Email = "tolkienbr1@gmail.com";

at3.Nome = "Sarah J Maas";
at3.Email = "sarahj2010@gmail.com";

autores.Add(at1);
autores.Add(at2);
autores.Add(at3);

Write(" # # # Sistema de Registros de Artigos # # #\n ");

Write("\nQual é o titulo do artigo?\n");
a1.Titulo = ReadLine();

Write("\nQuais são as palavras chaves?\n");
a1.Palavraschave = ReadLine();

Write("\nQual é a instituição?\n");
a1.Instituicao = ReadLine();

Write("\nQual é o nome do autor?\n");
string nomea= ReadLine();

if (at1.Nome == nomea)
{
    WriteLine("\nAutor encontrado no sistema!\n");
}
else if (at2.Nome == nomea)
{
    Write("\nAutor encontrado no sistema!\n");
}
else if (at3.Nome == nomea)
{
    Write("\nAutor encontrado no sistema!\n");
}
else
{
    Write("\nError!! Autor não encotrado!!!\n");
}

Write("\nRegistro realizado com sucesso!\n");
Write($"Titulo:{a1.Titulo}\n");
Write($"Autor:{nomea}\n");
Write($"Instituição:{a1.Instituicao}\n");
Write($"Palavras-Chave:{a1.Palavraschave}\n");

Write("Deseja registrar mais algum artigo?\n");
Write("1 = sim || 0 = não");
int op = int.Parse(ReadLine());

if (op == 1)
{
    Write("\nQual é o titulo do artigo?\n");
    a2.Titulo = ReadLine();

    Write("\nQuais são as palavras chaves?\n");
    a2.Palavraschave = ReadLine();

    Write("\nQual é a instituição?\n");
    a2.Instituicao = ReadLine();

    Write("\nQual é o nome do autor?\n");
    string nomea2= ReadLine();

    if (at1.Nome == nomea2)
    {
        WriteLine("\nAutor encontrado no sistema!\n");
    }
    else if (at2.Nome == nomea2)
    {
        Write("\nAutor encontrado no sistema!\n");
    }
    else if (at3.Nome == nomea2)
    {
        Write("\nAutor encontrado no sistema!\n");
    }
    else
    {
        Write("\nError!! Autor não encotrado!!!\n");
    }

    Write("\nRegistro realizado com sucesso!\n");
    Write($"Titulo:{a2.Titulo}\n");
    Write($"Autor:{nomea2}\n");
    Write($"Instituição:{a2.Instituicao}\n");
    Write($"Palavras-Chave:{a2.Palavraschave}\n");

    Write("Deseja registrar mais algum artigo?\n");
    Write("1 = sim || 0 = não");
    int op2 = int.Parse(ReadLine());

}

else
{
    Write("Até a próxima!");
}

/* Write("Deseja encotrar alguma artigo?");
Write("1 = sim || 0 = não");
int op = int.Parse(ReadLine());

if (op == 1)
{
    Write("Digite alguma palavra chave do artigo:");
    string nova = ReadLine();
    
        Write($"Titulo:{a1.Titulo}\n");
        Write($"Autor:{nomea}\n");
        Write($"Instituição:{a1.Instituicao}\n");
        Write($"Palavras-Chave:{a1.Palavraschave}\n");
}

else
{
    Write("Até a proxima!");
}
 */

