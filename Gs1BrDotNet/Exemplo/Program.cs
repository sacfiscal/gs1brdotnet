using Gs1Br;

public class Program
{
    public static void Main(string[] args)
    {
        Gs1brConfig config = new Gs1brConfig("2da3d381-43ae-4e0a-8cc4-8d583f7732ec", "23e15806-bb04-4c0c-97e8-f8beb885cd6a", "teste@teste.com", "senha");

        AutenticacaoGs1Br auth = new AutenticacaoGs1Br(config);
        RetornoLogin retorno = auth.Autenticar();

        ConsultaGtin consulta = new ConsultaGtin();
        RetornoConsultaGtinGs1Br retornoGtin = consulta.ConsultarGtin("07896412802546", retorno);

        Product produto = retornoGtin.product;
        if (produto == null)
        {
            Console.WriteLine($@"{retornoGtin.status} - {retornoGtin.message}!");
        } else
        {
            Console.WriteLine($@"Produto: {produto.LerDescricao()}
{produto.LerUrlFoto()}
{produto.LerMarca()}
{produto.LerClassificacaoGPC()}
{produto.LerNCM()}
{produto.LerCEST()}
{produto.LerEmbalagem()}");
        }
        
        Console.ReadKey();
    }
}
