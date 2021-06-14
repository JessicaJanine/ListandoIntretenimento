using System;

namespace ListandoIntretenimento
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio frepositorio = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoinicial = ObterMenuDesejado();
            while (opcaoinicial.ToUpper() != "X")
            {
                switch (opcaoinicial)
                {
                    case "1":
                        string menuUsuario = ObterOpcaoUsuario();
                        while (menuUsuario.ToUpper() != "X")
                        {
                            switch (menuUsuario)
                            {
                                case "1":
                                    ListarSeries();
                                    break;

                                case "2":
                                    InserirSerie();
                                    break;

                                case "3":
                                    AtualizarSerie();
                                    break;

                                case "4":
                                    ExcluirSerie();
                                    break;

                                case "5":
                                    VisualizarSerie();
                                    break;

                                case "C":
                                    Console.Clear();
                                    break;

                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            menuUsuario = ObterOpcaoUsuario();

                        }
                        Console.WriteLine("Obrigada por acessar o ListandoIntretenimento!");
                        Console.ReadLine();
                        break;

                    case "2":
                        string opcaoFilme = MenuFilmes();
                        while (opcaoFilme.ToUpper() != "X")
                        {
                            switch(opcaoFilme)
                            {
                                case "1":
                                    ListarFilmes();
                                    break;

                                case "2":
                                    InserirFilme();
                                    break;

                                case "3":
                                    AtualizarFilme();
                                    break;

                                case "4":
                                    ExcluirFilme();
                                    break;

                                case "5":
                                    VisualizarFilme();
                                    break;

                                case "C":
                                    Console.Clear();
                                    break;

                                default:
                                    throw new ArgumentOutOfRangeException();
                            }

                            opcaoFilme = MenuFilmes();
                        }
                        Console.WriteLine("Obrigada por acessar o ListandoIntretenimento!");
                        Console.ReadLine();
                        break;

                }


            }
        }
        
                
            
    
        private static string ObterMenuDesejado()
        {
            Console.WriteLine();
            Console.WriteLine("Listando o Intretenimento está aqui para você!");

            Console.WriteLine("Escolha uma opção: ");

            Console.WriteLine("1 - Menu de Séries");
            Console.WriteLine("2 - Menu de Filmes");
            Console.WriteLine("X - Sair");

            string opcaoinicial = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoinicial;
        }

        private static string MenuFilmes()
        {
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Filmes");
            Console.WriteLine("2 - Inserir Novo Filme");
            Console.WriteLine("3 - Atualizar Cadastro de um Filme");
            Console.WriteLine("4 - Excluir Filme");
            Console.WriteLine("5 - Visualizar Filme");
            Console.WriteLine("CLS - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoFilme = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoFilme;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Cadastro de uma Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("CLS - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string menuUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return menuUsuario;

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }

        private static void ExcluirFilme()
        {
            Console.WriteLine("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            frepositorio.Exclui(indiceFilme);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void VisualizarFilme()
        {
            Console.WriteLine("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = frepositorio.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }
        private static void AtualizarSerie()
        {
            Console.Write("Digite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(EnumGeneros)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(EnumGeneros), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de Lançamento da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series atualizaSerie = new Series(id: indiceSerie, 
                genero: (EnumGeneros)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
           }

        private static void AtualizarFilme()
        {
            Console.WriteLine("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(EnumGeneros)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(EnumGeneros), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de Lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes atualizaFilmes = new Filmes(fid: indiceFilme,
                fgenero: (EnumGeneros)entradaGenero,
                ftitulo: entradaTitulo,
                fano: entradaAno,
                fdescricao: entradaDescricao);
            frepositorio.Atualiza(indiceFilme, atualizaFilmes);

        }
        private static void ListarSeries()
        {
            Console.WriteLine("Lista de Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada em nosso catálogo");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Lista de Filmes");

            var lista = frepositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado em nosso catálogo");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaFexcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaFtitulo(), (excluido ? "*Excluído*" : ""));
            }

        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir uma série: ");

            foreach (int i in Enum.GetValues(typeof(EnumGeneros)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(EnumGeneros), i));
            }
            Console.Write("Escolha um gênero entre os listados acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitutlo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                genero: (EnumGeneros)entradaGenero,
                titulo: entradaTitutlo,
                ano: entradaAno, 
                descricao: entradaDescricao);


            repositorio.Insere(novaSerie);
        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme: ");

            foreach (int i in Enum.GetValues(typeof(EnumGeneros)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(EnumGeneros), i));
            }

            Console.Write("Escolha um gênero entre os listados acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitutlo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes(fid: frepositorio.ProximoId(),
                fgenero: (EnumGeneros)entradaGenero,
                ftitulo: entradaTitutlo, fano: entradaAno, fdescricao: entradaDescricao);

            frepositorio.Insere(novoFilme);
        }
}
}



