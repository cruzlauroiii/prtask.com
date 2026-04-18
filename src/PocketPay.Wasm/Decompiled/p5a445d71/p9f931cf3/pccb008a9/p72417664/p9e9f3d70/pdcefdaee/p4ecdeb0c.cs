namespace WillowMaze.Wasm.Decompiled;


public class p4ecdeb0c : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2ef824ce;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0 f34f272b4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f573882fa;
    private java.io.byteArrayStream f5ee6ce3c;
    private java.io.byteArrayStream f65bf9a9f;
    private java.io.byteArrayStream f956d5aee;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa9cd1e4b;
    private java.io.byteArrayStream fabe5633d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private java.io.byteArrayStream fcb7e52b2;

    public p4ecdeb0c() {
        this.fcb7e52b2 = new java.io.byteArrayStream();
        this.fcb7e52b2 = new java.io.byteArrayStream();
    }

    protected p4ecdeb0c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0 p0607d6b0Var) {
        this.fcb7e52b2 = new java.io.byteArrayStream();
        this.fc10f7796 = pe5cfc515Var;
        this.f08406a6e = p0607d6b0Var;
        this.fcb7e52b2 = new java.io.byteArrayStream();
    }

    private byte[] M4dca00da() {
        if ((15 + 19) % 19 > 0) {
        }
        this.fcb7e52b2.write(1);
        byte[] byteArray = this.fcb7e52b2.tobyteArray();
        this.fcb7e52b2.reset();
        return byteArray;
    }

    private byte[] M7d46bda9(byte[] bArr) throws javax.crypto.BadPaddingException {
        if ((8 + 4) % 4 > 0) {
        }
        int length = bArr.length - 1;
        while (length >= 0 && bArr[length] == 0) {
            length--;
        }
        if (bArr[length] != 1) {
            throw new javax.crypto.BadPaddingException("invalid ciphertext");
        }
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, length);
        return bArr2;
    }

    protected override int DecryptOutputSize(int i) {
        return 0;
    }

    public override byte[] DoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException {
        update(bArr, i, i2);
        if (this.f51235003 == 1) {
            return this.f08406a6e.messageEncrypt(m4dca00da());
        }
        if (this.f51235003 != 2) {
            throw new java.lang.IllegalStateException("unknown mode in doFinal");
        }
        try {
            byte[] byteArray = this.fcb7e52b2.tobyteArray();
            this.fcb7e52b2.reset();
            return m7d46bda9(this.f08406a6e.messageDecrypt(byteArray));
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new javax.crypto.BadPaddingException(e.getMessage());
        }
    }

    protected override int EncryptOutputSize(int i) {
        return 0;
    }

    public override int GetKeySize(java.security.Key key) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21;
        if (key is java.security.PublicKey) {
            pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.mc2499d21((java.security.PublicKey) key);
        } else {
            if (!(key is java.security.PrivateKey)) {
                throw new java.security.InvalidKeyException();
            }
            pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.m02ea6360((java.security.PrivateKey) key);
        }
        return this.f08406a6e.getKeySize((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04) pcfffbc4aVarMc2499d21);
    }

    public override java.lang.string GetName() {
        return "McElieceKobaraImaiCipher";
    }

    protected override void InitCipherDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.fcb7e52b2.reset();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.m02ea6360((java.security.PrivateKey) key);
        this.fc10f7796.reset();
        this.f08406a6e.init(false, pcfffbc4aVarM02ea6360);
    }

    protected override void InitCipherEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.fcb7e52b2.reset();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p0d1837a4.mc2499d21((java.security.PublicKey) key), secureRandom);
        this.fc10f7796.reset();
        this.f08406a6e.init(true, p4715f007Var);
    }

    public override byte[] Update(byte[] bArr, int i, int i2) {
        this.fcb7e52b2.write(bArr, i, i2);
        return new byte[0];
    }
}

