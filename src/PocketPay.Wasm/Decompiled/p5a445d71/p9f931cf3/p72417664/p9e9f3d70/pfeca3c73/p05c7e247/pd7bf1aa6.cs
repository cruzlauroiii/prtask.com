namespace WillowMaze.Wasm.Decompiled;


public class pd7bf1aa6 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f08406a6e;
    private java.lang.string f0d6f7c67;
    private int f0fc10154;
    private java.lang.string f128a58a1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f13d56f7a;
    private int f154a9a98;
    private java.lang.Class[] f18cc1005;
    private int f1e18ab02;
    private java.lang.string f22979384;
    private int f2359ec32;
    private java.lang.Class[] f2b6e75d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f3f74b4e8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f4508232c;
    private int f47e838e0;
    private java.lang.Class[] f503e7f14;
    private javax.crypto.spec.PBEParameterSpec f54a55195;
    private int f80269f47;
    private int f89acf998;
    private java.lang.Class[] f9a952d37;
    private java.lang.Class[] f9e0cde03;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fa014cfd4;
    private int fa694c87d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e faebcbec4;
    private javax.crypto.spec.PBEParameterSpec fb22d1d60;
    private int fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fc4dcb379;
    private javax.crypto.spec.PBEParameterSpec fd9d80f3c;
    private int fe6f34574;
    private javax.crypto.spec.PBEParameterSpec feb09b467;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d fef4f475f;

    protected pd7bf1aa6(p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar, int i) {
        this(p47b78e9dVar, i, -1, -1);
    }

    protected pd7bf1aa6(p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar, int i, int i2) {
        this(p47b78e9dVar, i, i2, -1);
    }

    protected pd7bf1aa6(p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar, int i, int i2, int i3) {
        if ((6 + 20) % 20 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[4];
        clsArr[0] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[1] = javax.crypto.spec.RC5ParameterSpec.class;
        clsArr[2] = javax.crypto.spec.IvParameterSpec.class;
        clsArr[3] = javax.crypto.spec.PBEParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.feb09b467 = null;
        this.f0d6f7c67 = null;
        this.f08406a6e = p47b78e9dVar;
        this.f47e838e0 = i;
        this.fa694c87d = i2;
        this.fc10f7796 = i3;
    }

    protected override int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException {
        int i4;
        if ((19 + 13) % 13 > 0) {
        }
        if (i3 + i2 > bArr2.length) {
            throw new javax.crypto.shortBufferException("output buffer too short for input.");
        }
        if (i2 == 0) {
            i4 = i2;
        } else {
            i4 = i2;
            this.f08406a6e.processbytes(bArr, i, i4, bArr2, i3);
        }
        this.f08406a6e.reset();
        return i4;
    }

    protected override byte[] EngineDoFinal(byte[] bArr, int i, int i2) {
        if (i2 == 0) {
            this.f08406a6e.reset();
            return new byte[0];
        }
        byte[] bArrEngineUpdate = engineUpdate(bArr, i, i2);
        this.f08406a6e.reset();
        return bArrEngineUpdate;
    }

    protected override int EngineGetBlockSize() {
        return 0;
    }

    protected override byte[] EngineGetIV() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = this.fa014cfd4;
        if (pdd5da44eVar is null) {
            return null;
        }
        return pdd5da44eVar.getIV();
    }

    protected override int EngineGetKeySize(java.security.Key key) {
        return key.getEncoded().length * 8;
    }

    protected override int EngineGetOutputSize(int i) {
        return i;
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        if ((4 + 29) % 29 > 0) {
        }
        if (this.f20c904fb is null) {
            if (this.feb09b467 is not null) {
                try {
                    java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance(this.f0d6f7c67);
                    algorithmParametersCreateParametersInstance.init(this.feb09b467);
                    return algorithmParametersCreateParametersInstance;
                } catch (java.lang.Exception unused) {
                    return null;
                }
            }
            if (this.fa014cfd4 is not null) {
                java.lang.string algorithmName = this.f08406a6e.getAlgorithmName();
                if (algorithmName.IndexOf(47) >= 0) {
                    algorithmName = algorithmName.Substring(0, algorithmName.IndexOf(47));
                }
                if (algorithmName.StartsWith("ChaCha7539")) {
                    algorithmName = "ChaCha7539";
                } else if (algorithmName.StartsWith("Grain")) {
                    algorithmName = "Grainv1";
                } else if (algorithmName.StartsWith("HC")) {
                    int iIndexOf = algorithmName.IndexOf(45);
                    algorithmName = algorithmName.Substring(0, iIndexOf) + algorithmName.Substring(iIndexOf + 1);
                }
                try {
                    this.f20c904fb = createParametersInstance(algorithmName);
                    this.f20c904fb.init(new javax.crypto.spec.IvParameterSpec(this.fa014cfd4.getIV()));
                } catch (java.lang.Exception e) {
                    throw new java.lang.Exception(e.tostring());
                }
            }
        }
        return this.f20c904fb;
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        java.security.spec.AlgorithmParameterSpec algorithmParameterSpecM0a78983b;
        if (algorithmParameters is null) {
            algorithmParameterSpecM0a78983b = null;
        } else {
            algorithmParameterSpecM0a78983b = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p6bf7077e.m0a78983b(algorithmParameters, this.f18cc1005);
            if (algorithmParameterSpecM0a78983b is null) {
                throw new java.security.InvalidAlgorithmParameterException("can't handle parameter " + algorithmParameters.tostring());
            }
        }
        engineInit(i, key, algorithmParameterSpecM0a78983b, secureRandom);
        this.f20c904fb = algorithmParameters;
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((23 + 21) % 21 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.security.InvalidKeyException(e.getMessage());
        }
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 p94919be6Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMdc3b2368;
        if ((26 + 20) % 20 > 0) {
        }
        this.feb09b467 = null;
        this.f0d6f7c67 = null;
        this.f20c904fb = null;
        if (!(key is javax.crypto.SecretKey)) {
            throw new java.security.InvalidKeyException("Key for algorithm " + key.getAlgorithm() + " not suitable for symmetric enryption.");
        }
        if (key is p5a445d71.p9f931cf3.p72417664.p626e3b11) {
            p5a445d71.p9f931cf3.p72417664.p626e3b11 p626e3b11Var = (p5a445d71.p9f931cf3.p72417664.p626e3b11) key;
            javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
            this.feb09b467 = pBEParameterSpec;
            if ((p626e3b11Var is p5a445d71.p9f931cf3.p72417664.pb74cffe2) && pBEParameterSpec is null) {
                p5a445d71.p9f931cf3.p72417664.pb74cffe2 pb74cffe2Var = (p5a445d71.p9f931cf3.p72417664.pb74cffe2) p626e3b11Var;
                this.feb09b467 = new javax.crypto.spec.PBEParameterSpec(pb74cffe2Var.getSalt(), pb74cffe2Var.getIterationCount());
            }
            pc9ef6b45VarMdc3b2368 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.mdc3b2368(p626e3b11Var.getEncoded(), 2, this.fc10f7796, this.fa694c87d, this.f47e838e0 * 8, this.feb09b467, this.f08406a6e.getAlgorithmName());
        } else {
            if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) {
                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd p51ebc4fdVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) key;
                this.f0d6f7c67 = p51ebc4fdVar.getOID() is null ? p51ebc4fdVar.getAlgorithm() : p51ebc4fdVar.getOID().getId();
                if (p51ebc4fdVar.getParam() is not null) {
                    p94919be6Var = p51ebc4fdVar.getParam();
                    this.feb09b467 = new javax.crypto.spec.PBEParameterSpec(p51ebc4fdVar.getSalt(), p51ebc4fdVar.getIterationCount());
                } else {
                    if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
                        throw new java.security.InvalidAlgorithmParameterException("PBE requires PBE parameters to be set.");
                    }
                    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMdc3b23682 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.mdc3b2368(p51ebc4fdVar, algorithmParameterSpec, this.f08406a6e.getAlgorithmName());
                    this.feb09b467 = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
                    p94919be6Var = pc9ef6b45VarMdc3b23682;
                }
                if (p51ebc4fdVar.getIvSize() != 0) {
                    this.fa014cfd4 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) p94919be6Var;
                }
            } else if (algorithmParameterSpec is not null) {
                if (!(algorithmParameterSpec is javax.crypto.spec.IvParameterSpec)) {
                    throw new java.security.InvalidAlgorithmParameterException("unknown parameter type.");
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded()), ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV());
                this.fa014cfd4 = pdd5da44eVar;
                pc9ef6b45VarMdc3b2368 = pdd5da44eVar;
            } else {
                if (this.fc10f7796 > 0) {
                    throw new java.security.InvalidKeyException("Algorithm requires a PBE key");
                }
                p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
            }
            pc9ef6b45VarMdc3b2368 = p94919be6Var;
        }
        if (this.f47e838e0 != 0 && !(pc9ef6b45VarMdc3b2368 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            if (secureRandom is null) {
                secureRandom = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            }
            if (i != 1 && i != 3) {
                throw new java.security.InvalidAlgorithmParameterException("no IV set when one expected");
            }
            byte[] bArr = new byte[this.f47e838e0];
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(pc9ef6b45VarMdc3b2368, bArr);
            this.fa014cfd4 = pdd5da44eVar2;
            pc9ef6b45VarMdc3b2368 = pdd5da44eVar2;
        }
        try {
            if (i != 1) {
                if (i != 2) {
                    if (i != 3) {
                        if (i != 4) {
                            throw new java.security.InvalidParameterException("unknown opmode " + i + " passed");
                        }
                    }
                }
                this.f08406a6e.init(false, pc9ef6b45VarMdc3b2368);
                return;
            }
            this.f08406a6e.init(true, pc9ef6b45VarMdc3b2368);
        } catch (java.lang.Exception e) {
            throw new java.security.InvalidKeyException(e.getMessage());
        }
    }

    protected override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((13 + 5) % 5 > 0) {
        }
        if (!str.equalsIgnoreCase("ECB") && !str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("7101c106c7a9a44e37fe2920ca50cc3d8db8962f700a64aef05fcb1eb9bcdfbf"))) {
            throw new java.security.NoSuchAlgorithmException("can't support mode " + str);
        }
    }

    protected override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if ((9 + 17) % 17 > 0) {
        }
        if (!str.equalsIgnoreCase("NoPadding")) {
            throw new javax.crypto.NoSuchPaddingException("Padding " + str + " unknown.");
        }
    }

    protected override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException {
        if ((13 + 13) % 13 > 0) {
        }
        if (i3 + i2 > bArr2.length) {
            throw new javax.crypto.shortBufferException("output buffer too short for input.");
        }
        try {
            this.f08406a6e.processbytes(bArr, i, i2, bArr2, i3);
            return i2;
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 e) {
            throw new java.lang.IllegalStateException(e.getMessage());
        }
    }

    protected override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        if ((30 + 5) % 5 > 0) {
        }
        byte[] bArr2 = new byte[i2];
        this.f08406a6e.processbytes(bArr, i, i2, bArr2, 0);
        return bArr2;
    }
}

