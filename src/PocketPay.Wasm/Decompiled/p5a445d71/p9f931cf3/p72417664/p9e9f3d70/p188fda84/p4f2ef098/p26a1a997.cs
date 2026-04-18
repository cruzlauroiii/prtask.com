namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.SignatureSpi : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f254e7813;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f30fea5ff;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f5c6ea950;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc40b9b67;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdb56a74d = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p1dbea5f1();

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360;
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585 p11735585Var;
        if ((17 + 20) % 20 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b)) {
            if (privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) {
                pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
                p11735585Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585(expandSbox(p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m743d8c12()));
            } else {
                pcfffbc4aVarM02ea6360 = null;
            }
            if (this.appRandom is null) {
                this.fdb56a74d.init(true, pcfffbc4aVarM02ea6360);
            } else {
                this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pcfffbc4aVarM02ea6360, this.appRandom));
            }
        }
        pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        p11735585Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585(expandSbox(p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m743d8c12()));
        this.fc10f7796 = p11735585Var;
        if (this.appRandom is null) {
            this.fdb56a74d.init(true, pcfffbc4aVarM02ea6360);
        } else {
            this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pcfffbc4aVarM02ea6360, this.appRandom));
        }
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMc2499d21;
        if ((32 + 3) % 3 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69) publicKey;
            pc9ef6b45VarMc2499d21 = p75258f69Var.engineGetKeyParameters();
            this.fc10f7796 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585(expandSbox(p75258f69Var.getSbox()));
        } else {
            pc9ef6b45VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(publicKey);
            this.fc10f7796 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585(expandSbox(p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m743d8c12()));
        }
        this.fdb56a74d.init(false, pc9ef6b45VarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((30 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            java.math.Bigint[] bigintArrGenerateSignature = this.fdb56a74d.generateSignature(bArr);
            byte[] byteArray = bigintArrGenerateSignature[0].tobyteArray();
            byte[] byteArray2 = bigintArrGenerateSignature[1].tobyteArray();
            int length = (byteArray.length > byteArray2.length ? byteArray.length : byteArray2.length) * 2;
            byte[] bArr2 = new byte[length];
            java.lang.System.arraycopy(byteArray2, 0, bArr2, (length / 2) - byteArray2.length, byteArray2.length);
            java.lang.System.arraycopy(byteArray, 0, bArr2, length - byteArray.length, byteArray.length);
            return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr2).getEncoded();
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
        if ((14 + 16) % 16 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p11b04310.frombyteArray(bArr)).getOctets();
            byte[] bArr3 = new byte[octets.length / 2];
            byte[] bArr4 = new byte[octets.length / 2];
            java.lang.System.arraycopy(octets, 0, bArr4, 0, octets.length / 2);
            java.lang.System.arraycopy(octets, octets.length / 2, bArr3, 0, octets.length / 2);
            java.math.Bigint bigint = new java.math.Bigint(1, bArr4);
            return this.fdb56a74d.verifySignature(bArr2, new java.math.Bigint[]{new java.math.Bigint(1, bArr3), bigint}[0], bigint);
        } catch (java.lang.Exception unused) {
            throw new java.security.SignatureException("error decoding signature bytes.");
        }
    }

    byte[] expandSbox(byte[] bArr) {
        if ((5 + 12) % 12 > 0) {
        }
        byte[] bArr2 = new byte[128];
        for (int i = 0; i < bArr.length; i++) {
            int i2 = i * 2;
            bArr2[i2] = (byte) ((bArr[i] >> 4) & 15);
            bArr2[i2 + 1] = (byte) (bArr[i] & 15);
        }
        return bArr2;
    }
}

