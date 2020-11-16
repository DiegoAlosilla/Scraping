using System;

namespace ScrapingAhCuanto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Metodos _metodos = new Metodos();
            //_metodos.getData("https://www.westernunionperu.pe/cambiodemoneda?utm_source=ced", "//*[@id='btnCompra']", "//*[@id='btnVenta']", "Western Union");
            _metodos.getData("https://app.dollarhouse.pe/calculadora", "//*[@id='buy-exchange-rate']", "//*[@id='sell-exchange-rate']", "Dollar House");
            _metodos.getData("https://cambioseguro.com", "//*[@id='__layout']/div/div[2]/header/div/div[2]/div[1]/div/div/div/div[1]/ul/li[1]/span", "//*[@id='__layout']/div/div[2]/header/div/div[2]/div[1]/div/div/div/div[1]/ul/li[3]/span", "Cambio Seguro");
            
            Console.ReadLine();

        }
    }
}
