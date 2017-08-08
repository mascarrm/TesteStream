using System;
using System.Collections.Generic;

namespace TesteStream
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new Stream("aAbBABacfee");
            try
            {
                Console.WriteLine("A primeira vogal única seguida de uma consoante é: " + firstChar(stream));
            }
            catch (FirstCharException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public static char firstChar(IStream input)
        {
            // Armazena a informação se o ultimo caracter lido foi uma consoante
            bool ultimaConsoante = false;

            // Armazena as vogais lidas para verificar duplicidade
            List<string> vogaisLidas = new List<string>();

            // Armazena vogais única para retornar o resultado
            List<string> vogaisUnicas = new List<string>();

            // O while varre a stream
            while (input.hasNext()) {
                // Armazena o valor do próximo elemento da stream
                char atual = input.getNext();

                // Verifica se o valor é uma vogal
                if (isVowal(atual))
                {
                    // Verifica se a vogal já foi lida, para ser removida da lista de vogais únicas
                    if (vogaisLidas.Contains(atual.ToString()))
                    {
                        vogaisUnicas.Remove(atual.ToString());
                    } 
                    else
                    {
                        // Caso ela não tenha sido lida, ela é adicionada na lista de vogais lidas para próximas consultas
                        vogaisLidas.Add(atual.ToString());

                        // Verifica se o ultimo caracter é uma consoante,
                        // para neste caso ele ser incluído na lista das vogais que atendem aos critérios de busca
                        if (ultimaConsoante)
                        {
                            vogaisUnicas.Add(atual.ToString());
                        }
                    }

                    // No caso de ser uma vogal,
                    // definir a variável de apoio para saber que o último caracter não foi uma consoante
                    ultimaConsoante = false;
                }
                // Verifica se o valor é uma consoante, para excluir números e caracteres especiais
                else if (isConsonant(atual))
                {
                    ultimaConsoante = true;
                }
                else
                {
                    ultimaConsoante = false;
                }
            }

            if (vogaisUnicas.Count > 0)
            {
                // No caso se haver vogais que atendam ao critério de busca,
                // retornar a primeira encontrada na lista
                return char.Parse(vogaisUnicas[0]);
            }

            throw new FirstCharException("Não foi possível encontrar nenhuma vogal única seguida de uma consoante.");
        }

        /// <summary>
        /// Determina se o valor informado é uma vogal
        /// </summary>
        /// <param name="c">Caracter que será testado como vogal</param>
        /// <returns>true se o valor informado em c for uma vogal; senão, retorna false.</returns>
        public static bool isVowal(char c)
        {
            char[] vowals = "AEIOUaeiou".ToCharArray();
            for (int i = 0; i < vowals.Length; i++)
            {
                if (vowals[i] == c)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determina se o valor informado é uma consoante
        /// </summary>
        /// <param name="c">Caracter que será testado como consoante</param>
        /// <returns>true se o valor informado em c for uma consoante; senão, retorna false.</returns>
        public static bool isConsonant(char c)
        {
            char[] vowals = "BCDFGHJKLMNPQRSTVXWYZbcdfghjklmnpqrstvxwyz".ToCharArray();
            for (int i = 0; i < vowals.Length; i++)
            {
                if (vowals[i] == c)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
