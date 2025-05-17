class Program
{
    static void Main()
    {
        var service = new ProdutoService();

        service.CriarMouse();
        service.CriarTeclado();
        service.CriarFone();

        service.ListarProdutos(); 
}

}
