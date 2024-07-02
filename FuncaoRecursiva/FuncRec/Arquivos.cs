using FuncaoRecursiva.FuncRec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoRecursiva.FuncRec
{
    internal class Arquivos
    {
        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoCaminho = @"C:\\Arquivos\\Arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoCaminho))
            {
                Console.WriteLine($"\nTexto do Arquivo {numeroArquivo}:\n");
                using (StreamReader arquivo = File.OpenText(arquivoCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }

                }
            }
            string arquivoCaminho2 = @"C:\\Arquivos\\Arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
    }
}

