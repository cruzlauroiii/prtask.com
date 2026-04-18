namespace WillowMaze.Wasm.Decompiled;


public class p18a65ced : java.security.SignatureSpi : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f0cf1049d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f59ef9f6a;
    private int f5cb8e83e;
    private int f61545e5c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fae30d7f0;
    private int ff7bd60b7 = 128;
    private int ffa63da8e = 64;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p4a34217f();
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdb56a74d = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p8ca44722();

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        return !(publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed) ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(publicKey) : ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed) publicKey).engineGetKeyParameters();
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((7 + 13) % 13 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e)) {
            throw new java.security.InvalidKeyException("cannot recognise key type in ECGOST-2012-512 signer");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        if (p1235ff36Var.getParameters().getN().bitLength() < 505) {
            throw new java.security.InvalidKeyException("key too weak for ECGOST-2012-512");
        }
        this.fc10f7796.reset();
        if (this.appRandom is null) {
            this.fdb56a74d.init(true, p1235ff36Var);
        } else {
            this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(p1235ff36Var, this.appRandom));
        }
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var;
        if ((22 + 29) % 29 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b) {
            p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) mc2499d21(publicKey);
        } else {
            try {
                p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(publicKey.getEncoded())));
            } catch (java.lang.Exception unused) {
                throw new java.security.InvalidKeyException("cannot recognise key type in ECGOST-2012-512 signer");
            }
        }
        if (p1235ff36Var.getParameters().getN().bitLength() < 505) {
            throw new java.security.InvalidKeyException("key too weak for ECGOST-2012-512");
        }
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, p1235ff36Var);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((16 + 3) % 3 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            byte[] bArr2 = new byte[this.ff7bd60b7];
            java.math.Bigint[] bigintArrGenerateSignature = this.fdb56a74d.generateSignature(bArr);
            byte[] byteArray = bigintArrGenerateSignature[0].tobyteArray();
            byte[] byteArray2 = bigintArrGenerateSignature[1].tobyteArray();
            if (byteArray2[0] != 0) {
                java.lang.System.arraycopy(byteArray2, 0, bArr2, this.ffa63da8e - byteArray2.length, byteArray2.length);
            } else {
                java.lang.System.arraycopy(byteArray2, 1, bArr2, this.ffa63da8e - (byteArray2.length - 1), byteArray2.length - 1);
            }
            if (byteArray[0] != 0) {
                java.lang.System.arraycopy(byteArray, 0, bArr2, this.ff7bd60b7 - byteArray.length, byteArray.length);
                return bArr2;
            }
            java.lang.System.arraycopy(byteArray, 1, bArr2, this.ff7bd60b7 - (byteArray.length - 1), byteArray.length - 1);
            return bArr2;
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
        if ((1 + 29) % 29 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            int i = this.ffa63da8e;
            byte[] bArr3 = new byte[i];
            byte[] bArr4 = new byte[i];
            java.lang.System.arraycopy(bArr, 0, bArr4, 0, i);
            int i2 = this.ffa63da8e;
            java.lang.System.arraycopy(bArr, i2, bArr3, 0, i2);
            java.math.Bigint bigint = new java.math.Bigint(1, bArr4);
            return this.fdb56a74d.verifySignature(bArr2, new java.math.Bigint[]{new java.math.Bigint(1, bArr3), bigint}[0], bigint);
        } catch (java.lang.Exception unused) {
            throw new java.security.SignatureException("error decoding signature bytes.");
        }
    }
}

