/* BLOCO FINALLY - E um bloco que contem codigo a ser executado independentemente de ter ocorrido ou nao uma excecao 
    - Muito utilizado para fechar arquivos ou conexoes de dados. 
*/
using System;
using System.IO;

namespace Aula142_BlocoFinally
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\Projetos\Aula142_BlocoFinally\test.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
