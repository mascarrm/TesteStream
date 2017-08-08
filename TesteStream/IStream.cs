namespace TesteStream
{
    public interface IStream
    {
        /// <summary>
        /// Retorna o valor do próximo elemento da stream.
        /// </summary>
        /// <returns>O valor do próximo elemento da stream.</returns>
        /// <exception cref="System.IndexOutOfRangeException">A stream não possui mais elementos.</exception>
        char getNext();

        /// <summary>
        /// Determina de a stream possui mais elementos.
        /// </summary>
        /// <returns>true se a stream possuir mais elementos; senão, retorna false.</returns>
        bool hasNext();

    }
}
