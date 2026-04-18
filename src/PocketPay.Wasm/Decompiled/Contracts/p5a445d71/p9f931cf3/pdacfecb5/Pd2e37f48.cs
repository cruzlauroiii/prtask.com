namespace WillowMaze.Wasm.Decompiled;

public interface Pd2e37f48
{
    void CheckValidity();
    void CheckValidity(DateTime P0);
    pe9e8674a[] GetAttributes();
    pe9e8674a[] GetAttributes(string P0);
    byte[] GetEncoded();
    p8ac6972f GetHolder();
    p73d7b518 GetIssuer();
    bool[] GetIssuerUniqueID();
    DateTime GetNotAfter();
    DateTime GetNotBefore();
    System.Numerics.BigInteger GetSerialNumber();
    byte[] GetSignature();
    int GetVersion();
    void Verify(PublicKey P0, string P1);
}
