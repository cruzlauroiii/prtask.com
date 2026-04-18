namespace WillowMaze.Wasm.Decompiled;


public class pc7eced35 : javax.crypto.CipherSpi {
    private java.security.SecureRandom f03338fcb;
    private java.security.AlgorithmParameters f129a3abe;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f198ca2a6;
    private bool f1a980786;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f1c094ab4;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f30f21b61;
    private java.security.AlgorithmParameters f3584fcc6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f3c6e0b8a;
    private int f47e838e0;
    private int f55b42e9c;
    private java.security.AlgorithmParameters f58163324;
    private java.io.byteArrayStream f5ace44c2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8b9ea2ac f6977e73b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f753bb310;
    private bool f7a5f093a;
    private bool f7be14ee9;
    private java.security.SecureRandom f7ddf32e1;
    private java.io.byteArrayStream f7f2db423;
    private java.io.byteArrayStream f7facfe20;
    private int f8304832d;
    private java.io.byteArrayStream f8dac63ae;
    private bool f90c2a945;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f90d576eb;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f95a56826;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8b9ea2ac f9b5ff6e0;
    private int f9ed39e2e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8b9ea2ac fad1943a9;
    private int fc6199611;
    private java.security.AlgorithmParameters fc86dfd3b;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fcce6253e;
    private int fcd61488b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fd021a4b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fd821b60a;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fd8658d3d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fdfafde64;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fe07341c2;
    private int ffa47b2cf;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d ffb826d36;
    private bool ffd491d8b;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    public pc7eced35(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8b9ea2ac p8b9ea2acVar) {
        if ((7 + 7) % 7 > 0) {
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f9ed39e2e = -1;
        this.f7f2db423 = new java.io.byteArrayStream();
        this.f58163324 = null;
        this.f30f21b61 = null;
        this.f7be14ee9 = false;
        this.f753bb310 = null;
        this.fad1943a9 = p8b9ea2acVar;
        this.f47e838e0 = 0;
    }

    public pc7eced35(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8b9ea2ac p8b9ea2acVar, int i) {
        if ((32 + 29) % 29 > 0) {
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f9ed39e2e = -1;
        this.f7f2db423 = new java.io.byteArrayStream();
        this.f58163324 = null;
        this.f30f21b61 = null;
        this.f7be14ee9 = false;
        this.f753bb310 = null;
        this.fad1943a9 = p8b9ea2acVar;
        this.f47e838e0 = i;
    }

    public override int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        byte[] bArrEngineDoFinal = engineDoFinal(bArr, i, i2);
        java.lang.System.arraycopy(bArrEngineDoFinal, 0, bArr2, i3, bArrEngineDoFinal.length);
        return bArrEngineDoFinal.length;
    }

    public override byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        if ((21 + 28) % 28 > 0) {
        }
        if (i2 != 0) {
            this.f7f2db423.write(bArr, i, i2);
        }
        byte[] byteArray = this.f7f2db423.tobyteArray();
        this.f7f2db423.reset();
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pae87d463Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pae87d463(this.f30f21b61.getDerivationV(), this.f30f21b61.getEncodingV(), this.f30f21b61.getMacKeySize(), this.f30f21b61.getCipherKeySize());
        if (this.f30f21b61.getNonce() is not null) {
            pae87d463Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(pae87d463Var, this.f30f21b61.getNonce());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) this.f3c6e0b8a).getParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = this.f753bb310;
        if (pcfffbc4aVar is not null) {
            try {
                int i3 = this.f9ed39e2e;
                if (i3 == 1 || i3 == 3) {
                    this.fad1943a9.init(true, pcfffbc4aVar, this.f3c6e0b8a, pae87d463Var);
                } else {
                    this.fad1943a9.init(false, this.f3c6e0b8a, pcfffbc4aVar, pae87d463Var);
                }
                return this.fad1943a9.processBlock(byteArray, 0, byteArray.length);
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to process block", e);
            }
        }
        int i4 = this.f9ed39e2e;
        if (i4 == 1 || i4 == 3) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a p2c69f81aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
            p2c69f81aVar.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(parameters, this.f7ddf32e1));
            try {
                this.fad1943a9.init(this.f3c6e0b8a, pae87d463Var, new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p56a617c5(p2c69f81aVar, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35$1(this, this.f30f21b61.getPointCompression())));
                return this.fad1943a9.processBlock(byteArray, 0, byteArray.length);
            } catch (java.lang.Exception e2) {
                throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to process block", e2);
            }
        }
        if (i4 != 2 && i4 != 4) {
            throw new java.lang.IllegalStateException("cipher not initialised");
        }
        try {
            this.fad1943a9.init(this.f3c6e0b8a, pae87d463Var, new p5a445d71.p9f931cf3.p5ae9b7f2.p36d1de7e.p3451b390(parameters));
            return this.fad1943a9.processBlock(byteArray, 0, byteArray.length);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e3) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to process block", e3);
        }
    }

    public override int EngineGetBlockSize() {
        if (this.fad1943a9.getCipher() is null) {
            return 0;
        }
        return this.fad1943a9.getCipher().getBlockSize();
    }

    public override byte[] EngineGetIV() {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d pdd952c9dVar = this.f30f21b61;
        if (pdd952c9dVar is null) {
            return null;
        }
        return pdd952c9dVar.getNonce();
    }

    public override int EngineGetKeySize(java.security.Key key) {
        if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) {
            return ((p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) key).getParameters().getCurve().getFieldSize();
        }
        throw new java.lang.IllegalArgumentException("not an EC key");
    }

    public override int EngineGetOutputSize(int i) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 cipher;
        if ((3 + 24) % 24 > 0) {
        }
        if (this.f3c6e0b8a is null) {
            throw new java.lang.IllegalStateException("cipher not initialised");
        }
        int macSize = this.fad1943a9.getMac().getMacSize();
        int fieldSize = this.f753bb310 is not null ? 0 : ((((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) this.f3c6e0b8a).getParameters().getCurve().getFieldSize() + 7) / 8) * 2;
        int size = this.f7f2db423.Count + i;
        if (this.fad1943a9.getCipher() is not null) {
            int i2 = this.f9ed39e2e;
            if (i2 == 1 || i2 == 3) {
                cipher = this.fad1943a9.getCipher();
            } else {
                if (i2 != 2 && i2 != 4) {
                    throw new java.lang.IllegalStateException("cipher not initialised");
                }
                cipher = this.fad1943a9.getCipher();
                size = (size - macSize) - fieldSize;
            }
            size = cipher.getOutputSize(size);
        }
        int i3 = this.f9ed39e2e;
        if (i3 == 1 || i3 == 3) {
            return macSize + fieldSize + size;
        }
        if (i3 == 2 || i3 == 4) {
            return size;
        }
        throw new java.lang.IllegalStateException("cipher not initialised");
    }

    public override java.security.AlgorithmParameters EngineGetParameters() {
        if ((13 + 2) % 2 > 0) {
        }
        if (this.f58163324 is null && this.f30f21b61 is not null) {
            try {
                java.security.AlgorithmParameters algorithmParametersCreateAlgorithmParameters = this.ffde5d67b.createAlgorithmParameters("IES");
                this.f58163324 = algorithmParametersCreateAlgorithmParameters;
                algorithmParametersCreateAlgorithmParameters.init(this.f30f21b61);
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
            }
        }
        return this.f58163324;
    }

    public override void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        java.security.spec.AlgorithmParameterSpec parameterSpec;
        if (algorithmParameters is null) {
            parameterSpec = null;
        } else {
            try {
                parameterSpec = algorithmParameters.getParameterSpec(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d.class);
            } catch (java.lang.Exception e) {
                throw new java.security.InvalidAlgorithmParameterException("cannot recognise parameters: " + e.tostring());
            }
        }
        this.f58163324 = algorithmParameters;
        engineInit(i, key, parameterSpec, secureRandom);
    }

    public override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((4 + 15) % 15 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.lang.IllegalArgumentException("cannot handle supplied parameter spec: " + e.getMessage());
        }
    }

    public override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d pdd952c9dVarM5edb6578;
        java.security.PrivateKey privateKey;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360;
        if ((12 + 11) % 11 > 0) {
        }
        byte[] bArr = null;
        this.f753bb310 = null;
        if (algorithmParameterSpec is null) {
            int i2 = this.f47e838e0;
            if (i2 != 0 && i == 1) {
                bArr = new byte[i2];
                secureRandom.nextbytes(bArr);
            }
            pdd952c9dVarM5edb6578 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p67f289ed.m5edb6578(this.fad1943a9.getCipher(), bArr);
        } else {
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d)) {
                throw new java.security.InvalidAlgorithmParameterException("must be passed IES parameters");
            }
            pdd952c9dVarM5edb6578 = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d) algorithmParameterSpec;
        }
        this.f30f21b61 = pdd952c9dVarM5edb6578;
        byte[] nonce = this.f30f21b61.getNonce();
        int i3 = this.f47e838e0;
        if (i3 != 0 && (nonce is null || nonce.length != i3)) {
            throw new java.security.InvalidAlgorithmParameterException("NONCE in IES Parameters needs to be " + this.f47e838e0 + " bytes long");
        }
        if (i == 1 || i == 3) {
            if (key is java.security.PublicKey) {
                pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21((java.security.PublicKey) key);
            } else {
                if (!(key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f)) {
                    throw new java.security.InvalidKeyException("must be passed recipient's public EC key for encryption");
                }
                p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f pc1b7c67fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f) key;
                this.f3c6e0b8a = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(pc1b7c67fVar.getPublic());
                this.f753bb310 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(pc1b7c67fVar.getPrivate());
            }
            this.f7ddf32e1 = secureRandom;
            this.f9ed39e2e = i;
            this.f7f2db423.reset();
        }
        if (i != 2 && i != 4) {
            throw new java.security.InvalidKeyException("must be passed EC key");
        }
        if (key is java.security.PrivateKey) {
            privateKey = (java.security.PrivateKey) key;
        } else {
            if (!(key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f)) {
                throw new java.security.InvalidKeyException("must be passed recipient's private EC key for decryption");
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f pc1b7c67fVar2 = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc1b7c67f) key;
            this.f753bb310 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(pc1b7c67fVar2.getPublic());
            privateKey = pc1b7c67fVar2.getPrivate();
        }
        pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        this.f3c6e0b8a = pcfffbc4aVarM02ea6360;
        this.f7ddf32e1 = secureRandom;
        this.f9ed39e2e = i;
        this.f7f2db423.reset();
    }

    public override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        bool z;
        if ((22 + 18) % 18 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals(com.decryptstringmanager.Decryptstring.decryptstring("154652ccfb5fbff153f082c3cc5d3572c739915ecbe905559772e6f58cc8a93c"))) {
            z = false;
        } else {
            if (!strMb8a8247c.Equals("DHAES")) {
                throw new java.lang.IllegalArgumentException("can't support mode " + str);
            }
            z = true;
        }
        this.f7be14ee9 = z;
    }

    public override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (!strMb8a8247c.Equals("NOPADDING") && !strMb8a8247c.Equals("PKCS5PADDING") && !strMb8a8247c.Equals("PKCS7PADDING")) {
            throw new javax.crypto.NoSuchPaddingException("padding not available with IESCipher");
        }
    }

    public override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        this.f7f2db423.write(bArr, i, i2);
        return 0;
    }

    public override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        this.f7f2db423.write(bArr, i, i2);
        return null;
    }
}

