namespace WillowMaze.Wasm.Decompiled;


public interface pfb2a2a44 {
    p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b createSigner(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar);

    p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b createSigner(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar);

    p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b createVerifyer(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar);

    p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b createVerifyer(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar);

    byte[] generateRawSignature(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f;

    byte[] generateRawSignature(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f;

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var);

    bool isValidPublicKey(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar);

    bool verifyRawSignature(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, byte[] bArr, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr2) throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f;

    bool verifyRawSignature(byte[] bArr, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr2) throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f;
}

