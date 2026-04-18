namespace WillowMaze.Wasm.Decompiled;


public class pbebe86f8 : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 f03b6fea1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0a677fb5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0a8507ef;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 f2769766e;
    private java.io.byteArrayStream f370beb7f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 f438f2a2b;
    private java.io.byteArrayStream f73a12053;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7b1e59cc;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 f854ad9c8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private java.io.byteArrayStream fcb7e52b2 = new java.io.byteArrayStream();
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd049e655;

    protected pbebe86f8(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p23b814a1 p23b814a1Var) {
        this.fc10f7796 = pe5cfc515Var;
        this.f08406a6e = p23b814a1Var;
    }

    protected override int DecryptOutputSize(int i) {
        return 0;
    }

    public override byte[] DoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException {
        update(bArr, i, i2);
        byte[] byteArray = this.fcb7e52b2.tobyteArray();
        this.fcb7e52b2.reset();
        if (this.f51235003 == 1) {
            return this.f08406a6e.messageEncrypt(byteArray);
        }
        if (this.f51235003 != 2) {
            throw new java.lang.IllegalStateException("unknown mode in doFinal");
        }
        try {
            return this.f08406a6e.messageDecrypt(byteArray);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new javax.crypto.BadPaddingException(e.getMessage());
        }
    }

    protected override int EncryptOutputSize(int i) {
        return 0;
    }

    public override int GetKeySize(java.security.Key key) throws java.security.InvalidKeyException {
        return this.f08406a6e.getKeySize((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04) (!(key is java.security.PublicKey) ? p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.m02ea6360((java.security.PrivateKey) key) : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.mc2499d21((java.security.PublicKey) key)));
    }

    public override java.lang.string GetName() {
        return "McElieceFujisakiCipher";
    }

    protected override void InitCipherDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.m02ea6360((java.security.PrivateKey) key);
        this.fc10f7796.reset();
        this.f08406a6e.init(false, pcfffbc4aVarM02ea6360);
    }

    protected override void InitCipherEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.mc2499d21((java.security.PublicKey) key), secureRandom);
        this.fc10f7796.reset();
        this.f08406a6e.init(true, p4715f007Var);
    }

    public override byte[] Update(byte[] bArr, int i, int i2) {
        this.fcb7e52b2.write(bArr, i, i2);
        return new byte[0];
    }
}

