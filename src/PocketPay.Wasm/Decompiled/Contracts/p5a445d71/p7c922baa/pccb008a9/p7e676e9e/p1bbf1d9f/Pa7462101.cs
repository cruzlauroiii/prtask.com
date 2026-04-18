namespace WillowMaze.Wasm.Decompiled;

public interface Pa7462101
{
    pa7462101 Add(pa7462101 P0);
    void AddToThis(pa7462101 P0);
    object Clone();
    bool Equals(object P0);
    int HashCode();
    pa7462101 Invert();
    bool IsOne();
    bool IsZero();
    pa7462101 Multiply(pa7462101 P0);
    void MultiplyThisBy(pa7462101 P0);
    pa7462101 Subtract(pa7462101 P0);
    void SubtractFromThis(pa7462101 P0);
    byte[] ToByteArray();
    System.Numerics.BigInteger ToFlexiBigInt();
    string ToString();
    string ToString(int P0);
}
