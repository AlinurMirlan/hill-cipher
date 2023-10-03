namespace HillCipher.Library;

public interface ICipher<T>
{
    public T? Key { get; set; }
    public char[] Alphabet { get; set; }
    public abstract string Encrypt(string message);
    public abstract string Decrypt(string message);
}
