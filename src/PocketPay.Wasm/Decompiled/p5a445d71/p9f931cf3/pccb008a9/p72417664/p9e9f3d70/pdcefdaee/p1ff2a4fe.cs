namespace WillowMaze.Wasm.Decompiled;


public class p1ff2a4fe : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d f08406a6e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d fc76ac48d;

    public p1ff2a4fe(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d pe8d57d0dVar) {
        this.f08406a6e = pe8d57d0dVar;
    }

    public override int GetKeySize(java.security.Key key) throws java.security.InvalidKeyException {
        return this.f08406a6e.getKeySize((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231) (!(key is java.security.PublicKey) ? p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pcfd4c6f3.m02ea6360((java.security.PrivateKey) key) : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pcfd4c6f3.mc2499d21((java.security.PublicKey) key)));
    }

    public override java.lang.string GetName() {
        return "McEliecePKCS";
    }

    protected override void InitCipherDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.f08406a6e.init(false, p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pcfd4c6f3.m02ea6360((java.security.PrivateKey) key));
        this.fa172f9ee = this.f08406a6e.fa172f9ee;
        this.f25f9919b = this.f08406a6e.f25f9919b;
    }

    protected override void InitCipherEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.f08406a6e.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pcfd4c6f3.mc2499d21((java.security.PublicKey) key), secureRandom));
        this.fa172f9ee = this.f08406a6e.fa172f9ee;
        this.f25f9919b = this.f08406a6e.f25f9919b;
    }

    protected override byte[] MessageDecrypt(byte[] bArr) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        try {
            return this.f08406a6e.messageDecrypt(bArr);
        } catch (java.lang.Exception e) {
            throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
        }
    }

    protected override byte[] MessageEncrypt(byte[] bArr) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        try {
            return this.f08406a6e.messageEncrypt(bArr);
        } catch (java.lang.Exception e) {
            throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
        }
    }
}

