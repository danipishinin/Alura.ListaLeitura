using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura.ListaLeitura.App
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            var paginaHTML = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(paginaHTML))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
