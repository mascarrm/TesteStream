using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteStream
{
    /// <summary>
    /// Representa uma sequência de caracteres que implementa a interface IStream.
    /// </summary>
    public class Stream : IStream
    {
        private char[] _stream;
        private int _pos = -1;

        /// <summary>
        /// Inicia uma nova instancia de uma stream informando uma sequencia de caracteres como string.
        /// </summary>
        /// <param name="valor">O valor em string que será inicializado na stream.</param>
        public Stream(string valor)
        {
            _stream = valor.ToCharArray();
        }

        /// <summary>
        /// Retorna o valor do próximo elemento da stream.
        /// </summary>
        /// <returns>O valor do próximo elemento da stream.</returns>
        /// <exception cref="System.IndexOutOfRangeException">A stream não possui mais elementos.</exception>
        public char getNext()
        {
            _pos += 1;
            return _stream[_pos];
        }

        /// <summary>
        /// Determina de a stream possui mais elementos.
        /// </summary>
        /// <returns>true se a stream possuir mais elementos; senão retorna false.</returns>
        public bool hasNext()
        {
            return _stream.Length > _pos +1;
        }
    }
}
