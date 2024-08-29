using System;

class ComputacaoForense
{
    static void Main(string[] args)
    {
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;

        string bordaSuperior = new string('=', 50);
        string bordaInferior = new string('=', 50);
        string titulo = "Menu Principal - Introdução a Computação Forense";
        string menuOpcoes = "\n1. Definição e Objetivos\n2. História e Evolução\n3. Áreas de Aplicação e Importância Legal\n4. Ética e Responsabilidade Profissional\n5. Curiosidades\n6. Sair";

        int espacoEsquerda = (50 - titulo.Length) / 2; // Calcula o espaço para centralizar o título
        string espaco = new string(' ', espacoEsquerda);

        Console.WriteLine(bordaSuperior);
        Console.WriteLine(espaco + titulo);
        Console.WriteLine(bordaInferior);
        Console.ResetColor();
        Console.WriteLine(menuOpcoes);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(bordaInferior);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Desenvolvido por Mateus S.");
        Console.WriteLine("GitHub: Matz-Turing");
        Console.ResetColor();

        Console.Write("\nEscolha uma opção: ");
        int escolha = ObterEscolhaUsuario();
        ProcessarEscolha(escolha);
    }

    static int ObterEscolhaUsuario()
    {
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 6)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida! Por favor, escolha um número entre 1 e 6.");
            Console.ResetColor();
            Console.Write("\nEscolha uma opção: ");
        }
        return escolha;
    }

    static void ProcessarEscolha(int escolha)
    {
        Console.Clear();
        switch (escolha)
        {
            case 1:
                ExibirDefinicaoObjetivos();
                break;
            case 2:
                ExibirHistoriaEvolucao();
                break;
            case 3:
                ExibirAreasImportancia();
                break;
            case 4:
                ExibirEticaResponsabilidade();
                break;
            case 5:
                ExibirCuriosidades();
                break;
            case 6:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nObrigado por usar o programa! Até logo!");
                Console.ResetColor();
                return;
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ResetColor();
        Console.ReadKey();
        MostrarMenu();
    }

    static void ExibirDefinicaoObjetivos()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Definição e Objetivos da Computação Forense ===\n");
        Console.ResetColor();
        Console.Write("A computação forense é uma disciplina que envolve a ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("coleta, análise");
        Console.ResetColor();
        Console.WriteLine(" e ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("preservação de evidências digitais");
        Console.ResetColor();
        Console.WriteLine(" em um ambiente legal.");
        Console.WriteLine("Seus principais objetivos incluem:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Identificação");
        Console.ResetColor();
        Console.WriteLine("   - Determinar se um crime foi cometido e identificar os responsáveis.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. Preservação");
        Console.ResetColor();
        Console.WriteLine("   - Garantir que as evidências digitais sejam preservadas de maneira segura e íntegra.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("3. Análise");
        Console.ResetColor();
        Console.WriteLine("   - Examinar os dados coletados para extrair informações relevantes e construir um caso.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("4. Apresentação");
        Console.ResetColor();
        Console.WriteLine("   - Fornecer um relatório claro e compreensível das descobertas para uso em processos legais.");
    }

    static void ExibirHistoriaEvolucao()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== História e Evolução da Computação Forense ===\n");
        Console.ResetColor();
        Console.Write("A história da computação forense remonta à ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("década de 1980");
        Console.ResetColor();
        Console.WriteLine(", quando os primeiros crimes digitais começaram a ser investigados.");
        Console.WriteLine("Aqui está uma visão geral da evolução da disciplina:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Anos 1980");
        Console.ResetColor();
        Console.WriteLine("   - Início das investigações digitais, principalmente focadas em fraudes bancárias.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. Anos 1990");
        Console.ResetColor();
        Console.WriteLine("   - Expansão das técnicas forenses com o aumento da criminalidade digital e surgimento da internet.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("3. Anos 2000");
        Console.ResetColor();
        Console.WriteLine("   - Consolidação da computação forense como uma disciplina formal, com padrões e certificações específicas.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("4. Anos 2010 e além");
        Console.ResetColor();
        Console.WriteLine("   - Avanços contínuos em ferramentas e técnicas para lidar com novas formas de crimes digitais.");
    }

    static void ExibirAreasImportancia()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Áreas de Aplicação e Importância Legal ===\n");
        Console.ResetColor();
        Console.Write("A computação forense é aplicada em diversas áreas, e sua ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("importância legal");
        Console.ResetColor();
        Console.WriteLine(" é imensa. Algumas dessas áreas incluem:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Criminalidade Cibernética");
        Console.ResetColor();
        Console.WriteLine("   - Investigação de crimes cometidos através de redes de computadores e internet.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. Litígios Corporativos");
        Console.ResetColor();
        Console.WriteLine("   - Análise de dados digitais em casos de disputas empresariais e propriedade intelectual.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("3. Segurança da Informação");
        Console.ResetColor();
        Console.WriteLine("   - Identificação e resposta a violações de segurança e incidentes de dados.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("4. Fraude e Corrupção");
        Console.ResetColor();
        Console.WriteLine("   - Investigação de esquemas de fraude, corrupção e crimes financeiros.");
    }

    static void ExibirEticaResponsabilidade()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Ética e Responsabilidade Profissional na Computação Forense ===\n");
        Console.ResetColor();
        Console.Write("Na computação forense, a ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ética");
        Console.ResetColor();
        Console.Write(" e a ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("responsabilidade profissional");
        Console.ResetColor();
        Console.WriteLine(" são fundamentais. As principais áreas incluem:\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Confidencialidade");
        Console.ResetColor();
        Console.WriteLine("   - Manter sigilo sobre as informações coletadas durante uma investigação.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. Integridade");
        Console.ResetColor();
        Console.WriteLine("   - Assegurar que os dados não sejam alterados ou corrompidos durante o processo de coleta e análise.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("3. Imparcialidade");
        Console.ResetColor();
        Console.WriteLine("   - Realizar análises de forma objetiva, sem viés ou influência externa.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("4. Competência");
        Console.ResetColor();
        Console.WriteLine("   - Possuir o conhecimento técnico adequado para realizar investigações de forma eficaz.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("5. Transparência");
        Console.ResetColor();
        Console.WriteLine("   - Documentar e relatar de forma clara todas as etapas da investigação.");
    }

    static void ExibirCuriosidades()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Curiosidades sobre a Introdução à Computação Forense ===\n");
        Console.ResetColor();
        Console.WriteLine("Aqui estão algumas curiosidades sobre a computação forense:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n1. O primeiro caso judicial envolvendo evidências digitais ocorreu nos anos 80.");
        Console.ResetColor();
        Console.WriteLine("   Foi um marco que mostrou a importância crescente dessa área.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. A computação forense não se limita a computadores.");
        Console.ResetColor();
        Console.WriteLine("   Ela abrange também smartphones, tablets, e qualquer dispositivo que armazene dados.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("3. As técnicas de computação forense são constantemente atualizadas.");
        Console.ResetColor();
        Console.WriteLine("   Isso ocorre para acompanhar as novas tecnologias e métodos de crimes digitais.");
    }
}
