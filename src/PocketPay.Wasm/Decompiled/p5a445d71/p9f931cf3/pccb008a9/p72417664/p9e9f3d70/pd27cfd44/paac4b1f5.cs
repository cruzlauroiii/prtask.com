namespace WillowMaze.Wasm.Decompiled;


public class paac4b1f5 : java.security.Signature {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 f02a4dca0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 f0445ad1d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d f060310c7;
    private java.security.SecureRandom f0c115c19;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f30fddcc1;
    private java.security.SecureRandom f310b1d2d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 f31d09ac8;
    private java.security.SecureRandom f3395581c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 f5f958d1a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d f67676ef5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 f6a78f174;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pd9f65fa7 f9d6990db;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pd9f65fa7 fb12071a1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d fbe142347;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fce6d9e05;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d fdb56a74d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d fe55ad586;

    protected paac4b1f5(java.lang.string str) {
        super(str);
    }

    protected paac4b1f5(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        super(str);
        this.fc10f7796 = pe5cfc515Var;
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Mb423450a() throws java.security.SignatureException {
        if ((12 + 20) % 20 > 0) {
        }
        try {
            return this.f31d09ac8.generateLMSobject();
        } catch (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c e) {
            throw new java.security.SignatureException(e.getMessage(), e);
        }
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((30 + 3) % 3 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3)) {
            throw new java.security.InvalidKeyException("unknown private key passed to LMS");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3 p64e649e3Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p64e649e3) ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3) privateKey).getKeyParams();
        this.f31d09ac8 = p64e649e3Var;
        if (p64e649e3Var.getUsagesRemaining() == 0) {
            throw new java.security.InvalidKeyException("private key exhausted");
        }
        this.fc10f7796 = null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4)) {
            throw new java.security.InvalidKeyException("unknown public key passed to XMSS");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7 p42086fe7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7();
        this.fc10f7796 = p42086fe7Var;
        p42086fe7Var.reset();
        this.f9d6990db = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pd9f65fa7) ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4) publicKey).getKeyParams();
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((30 + 24) % 24 > 0) {
        }
        if (this.fc10f7796 is null) {
            this.fc10f7796 = mb423450a();
        }
        try {
            byte[] bArrGenerateSignature = this.f31d09ac8.generateSignature((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530) this.fc10f7796);
            this.fc10f7796 = null;
            return bArrGenerateSignature;
        } catch (java.lang.Exception e) {
            if (e is java.lang.IllegalStateException) {
                throw new java.security.SignatureException(e.getMessage(), e);
            }
            throw new java.security.SignatureException(e.tostring(), e);
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        if (this.fc10f7796 is null) {
            this.fc10f7796 = mb423450a();
        }
        this.fc10f7796.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        if (this.fc10f7796 is null) {
            this.fc10f7796 = mb423450a();
        }
        this.fc10f7796.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        if ((29 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530VarGenerateLMSobject = this.f9d6990db.generateLMSobject(bArr);
        byte[] bArrMeca8e3f6 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p69279707.meca8e3f6(this.fc10f7796);
        pf502f530VarGenerateLMSobject.update(bArrMeca8e3f6, 0, bArrMeca8e3f6.length);
        return this.f9d6990db.verify(pf502f530VarGenerateLMSobject);
    }
}

