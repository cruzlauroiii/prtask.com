namespace WillowMaze.Wasm.Decompiled;


public class p3fd371e5 : java.security.spec.KeySpec, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f {
    private java.security.PublicKey f07abba19;
    private java.security.PrivateKey f0d3e7e88;
    private java.security.PrivateKey f14071b89;
    private java.security.PublicKey f28c326cd;
    private java.security.PrivateKey f4aa2361b;
    private java.security.PrivateKey f5fdbf20b;
    private java.security.PublicKey fa25e34fa;
    private java.security.PublicKey fab912d73;
    private java.security.PublicKey feb0af9f8;
    private java.security.PrivateKey fedeeb5d8;

    public p3fd371e5(java.security.PrivateKey privateKey, java.security.PublicKey publicKey) {
        this.f4aa2361b = privateKey;
        this.f28c326cd = publicKey;
    }

    public override java.lang.string GetAlgorithm() {
        return "IES";
    }

    public override byte[] GetEncoded() {
        return null;
    }

    public override java.lang.string GetFormat() {
        return null;
    }

    public override java.security.PrivateKey GetPrivate() {
        return this.f4aa2361b;
    }

    public override java.security.PublicKey GetPublic() {
        return this.f28c326cd;
    }
}

