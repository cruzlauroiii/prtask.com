namespace WillowMaze.Wasm.Decompiled;

public interface Pfb2a2a44
{
    pd1977c1b CreateSigner(pcfffbc4a P0);
    pd1977c1b CreateSigner(p345a98df P0, pcfffbc4a P1);
    pd1977c1b CreateVerifyer(pcfffbc4a P0);
    pd1977c1b CreateVerifyer(p345a98df P0, pcfffbc4a P1);
    byte[] GenerateRawSignature(pcfffbc4a P0, byte[] P1);
    byte[] GenerateRawSignature(p345a98df P0, pcfffbc4a P1, byte[] P2);
    void Init(pf1660074 P0);
    bool IsValidPublicKey(pcfffbc4a P0);
    bool VerifyRawSignature(p345a98df P0, byte[] P1, pcfffbc4a P2, byte[] P3);
    bool VerifyRawSignature(byte[] P0, pcfffbc4a P1, byte[] P2);
}
