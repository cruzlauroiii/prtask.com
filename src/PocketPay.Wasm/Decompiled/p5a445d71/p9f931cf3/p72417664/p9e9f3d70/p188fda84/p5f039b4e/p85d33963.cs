namespace WillowMaze.Wasm.Decompiled;


public class p85d33963 : java.security.SignatureSpi : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f0d113c4a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f135bc2a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f2059e15f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f28fb9739;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f34b83328;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f583532c7;
    private java.security.SecureRandom f6fd7ff20;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f78ceb7d1;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f84bea1f0 = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082.f76425f17;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fba7d20d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 fce43b2ad;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdb56a74d;

    protected p85d33963(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d pae380b4dVar) {
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = pae380b4dVar;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineGetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((19 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.m02ea6360(privateKey);
        if (this.f7ddf32e1 is not null) {
            pc9ef6b45VarM02ea6360 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarM02ea6360, this.f7ddf32e1);
        }
        this.fc10f7796.reset();
        this.fdb56a74d.init(true, pc9ef6b45VarM02ea6360);
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.mc2499d21(publicKey);
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, pcfffbc4aVarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((22 + 5) % 5 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            java.math.Bigint[] bigintArrGenerateSignature = this.fdb56a74d.generateSignature(bArr);
            return this.f84bea1f0.encode(this.fdb56a74d.getOrder(), bigintArrGenerateSignature[0], bigintArrGenerateSignature[1]);
        } catch (java.lang.Exception e) {
            throw new java.security.SignatureException(e.tostring());
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.fc10f7796.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.fc10f7796.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        if ((15 + 1) % 1 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            java.math.Bigint[] bigintArrDecode = this.f84bea1f0.decode(this.fdb56a74d.getOrder(), bArr);
            return this.fdb56a74d.verifySignature(bArr2, bigintArrDecode[0], bigintArrDecode[1]);
        } catch (java.lang.Exception unused) {
            throw new java.security.SignatureException("error decoding signature bytes.");
        }
    }
}

