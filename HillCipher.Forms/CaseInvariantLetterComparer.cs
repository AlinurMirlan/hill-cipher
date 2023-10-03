using System.Diagnostics.CodeAnalysis;

namespace HillCipher.Forms;

public class CaseInvariantLetterComparer : IEqualityComparer<char>
{
    public bool Equals(char x, char y) => char.ToLowerInvariant(x) == char.ToLowerInvariant(y);

    public int GetHashCode([DisallowNull] char obj) => char.ToLowerInvariant(obj).GetHashCode();
}
