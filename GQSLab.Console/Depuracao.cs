#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using GQSLab.Model;

namespace GQSLab.Console
{
    public static class Depuracao
    {
        #region Opções de Debug

        public static void ExecutaExemploDebug()
        {
            // Informações de Produto
            var p = new Produto
                        {
                            Id = 117,
                            Descricao = "Widget",
                            Qtde = 19,
                            Preco = (decimal) 17.6,
                            DataVencimento = new DateTime(2015, 05, 11)
                        };

            // Especifica a mensagem a ser produzida
            Debug.WriteLine("Debug: Iniciando informações de Produto");

            // Para facilitar a leitura - Uso do método Indent p/ alinhar o recuo
            Debug.Indent();

            // Exibe conteúdo das variáveis
            Debug.WriteLine("A descrição do produto é: " + p.Descricao);
            Debug.WriteLine("A quantidade do produtos é: " + p.Qtde.ToString());
            Debug.WriteLine("O preço do Produto é: " + p.Preco.ToString());
            Debug.WriteLine("A Data de Vencimento do Produto é: " + p.DataVencimento.ToShortDateString());

            // Exibe mensagem se condição for verdadeira
            Debug.WriteLineIf(p.Qtde < 15, "Qtde é menor que 15");

            // Método Assert - Exibe a mensagem somente se uma condição especificada for avaliada como falsa
            Debug.Assert(p.Preco > 20, "Mensagem só vai aparecer se condição for falsa!");
        }

        public static void ExecutaExemploPreProcessamento()
        {
            // Exemplo de Diretivas de pré-processamento em C#

            #if DEBUG
            
            System.Console.WriteLine("Este código somente é permitido para DEBUG ");
            
            #endif
        }

        #endregion

        #region Exemplos de Exceções

        private static void TestThrow()
        {
            System.ApplicationException exc = new System.ApplicationException("Demonstração de Exception do método TestThrow()");

            throw exc;
        }


        static void TestCatch()
        {
            try
            {
                TestThrow();
            }
            catch (System.ApplicationException exc)
            {
                System.Console.WriteLine("ApplicationException do método TestCatch1: \n" + exc.ToString());
            }
        }

        static void TestCatch2()
        {
            try
            {
                TestThrow();
            }
            catch (System.ApplicationException exc)
            {
                System.Console.WriteLine("ApplicationException do método TestCatch2: \n" + exc.ToString());  // this block will be executed
            }
            catch (System.Exception exc)
            {
                System.Console.WriteLine("Exception do método TestCatch2: \n" + exc.ToString());  // this block will NOT be executed
            }

            //System.Console.WriteLine("\n Fim do método TestCatch2");  // this statement is executed after the catch block
        }

        static void TestFinally()
        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\file.txt");

            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
                if (file != null)
                {
                    file.Close();
                }
            }

            try
            {
                file = fileInfo.OpenWrite();
                System.Console.WriteLine("OpenWrite() succeeded");
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("OpenWrite() failed");
            }
        }

        static void TestFinally2()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                System.Console.WriteLine("Dentro do finally");
            }

            System.Console.WriteLine("Fora do finally ");
        }


        public static int DivideNumeros(int a, int b)
        {
            try
            {
                return a / b;


            }
            catch (DivideByZeroException exc)
            {
                throw new Exception("Divisão por zero detectada! Desc.: " + exc.Message);
            }
            catch (Exception exc)
            {
                throw new Exception("Exceção detectada! Desc.: " + exc.Message);
            }
        }

        public static void ConverteNumero()
        {
            try
            {
                string teste = "teste";

                int numero = Convert.ToInt32(teste);

                if (!Int32.TryParse("0", out numero))
                    throw new FormatException();

            }
            catch (FormatException exc)
            {
                throw new Exception("Formato inválido! Desc.: " + exc.Message);
            }
            catch (Exception exc)
            {
                throw new Exception("Exceção detectada! Desc.: " + exc.Message);
            }
        }

        public static void LeArquivo()
        {
            FileStream fs = null;

            try
            {
                // Abre o arquivo texto
                fs = new FileStream(@"C:\teste\dados.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                // Um valor é lido do arquivo e exibido no console
                string line = sr.ReadLine();

                System.Console.WriteLine("Conteúdo do arquivo: " + line);
            }
            catch (FileNotFoundException exc)
            {
                throw new FileNotFoundException(@"[Arquivo dados.txt não existe na pasta c:\teste]", exc);
            }
            catch (Exception exc)
            {
                throw new Exception("Exceção detectada! Desc.: " + exc.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }


        public static void ExecutaExemploExcecoes()
        {
            try
            {
                //DivideNumeros(10, 0);
                //LeArquivo();
                ConverteNumero();
            }
            catch (FileNotFoundException exc)
            {
                System.Console.WriteLine("asdfadfasdfs" + exc.Message);
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("A exceção gerada é: " + exc.Message);
            }
        }

        #endregion
    }
}