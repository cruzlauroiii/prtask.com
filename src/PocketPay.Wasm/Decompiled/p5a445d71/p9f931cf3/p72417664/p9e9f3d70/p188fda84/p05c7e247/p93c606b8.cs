namespace WillowMaze.Wasm.Decompiled;


public abstract class p93c606b8 : java.security.SignatureSpi : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f0d357d31;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f15360c6e;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f400bd658;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f44d0d17a;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f4bca121a;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f584e656a;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f61bebf21;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f84bea1f0;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f886c9c50;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 fa4a82a74;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdb56a74d;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdf2c34cb;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe2911a31;

    protected p93c606b8(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d pae380b4dVar, p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 pa8ad1191Var) {
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = pae380b4dVar;
        this.f84bea1f0 = pa8ad1191Var;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((4 + 8) % 8 > 0) {
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
        if ((13 + 22) % 22 > 0) {
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

