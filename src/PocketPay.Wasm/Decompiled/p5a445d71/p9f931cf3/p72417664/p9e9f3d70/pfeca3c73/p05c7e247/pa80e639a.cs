namespace WillowMaze.Wasm.Decompiled;


public abstract class pa80e639a : javax.crypto.CipherSpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557 {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f05a8a75c;
    protected int f07cde2df;
    private int f0c50f206;
    private java.lang.Class[] f18cc1005;
    protected int f18df3a92;
    protected java.security.AlgorithmParameters f20c904fb;
    protected int f24ee23bc;
    protected int f2ac9847e;
    protected java.security.AlgorithmParameters f346bc62b;
    private int f3487391b;
    protected int f3710d6a6;
    protected java.security.AlgorithmParameters f478adf2d;
    protected int f54704ac5;
    protected java.security.AlgorithmParameters f5b41ecb2;
    protected int f642ca925;
    protected int f6b31ac1d;
    private java.lang.Class[] f6ccf5dac;
    private int f6d60c4f5;
    protected int f871ff1c7;
    private bool f8b62e134;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f8ec17a91;
    protected int f8f448747;
    protected int f90727152;
    protected int f9822683d;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f9e53b30d;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 fa55baf29;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 fa672717d;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 fae8179f7;
    protected int fb3aeb44b;
    private java.lang.Class[] fbb39ffe9;
    protected int fc30b553f;
    protected int fc6af5bba;
    protected int fc8008b22;
    private byte[] fcb6c45c9;
    private int fd1a1ec24;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 fd336c3e5;
    private java.lang.Class[] fe3804e56;
    private bool fe468b4bf;
    protected int feb2d6d9f;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 feb590371;
    private byte[] ff0b53b2d;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    protected pa80e639a() {
        if ((26 + 3) % 3 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[5];
        clsArr[0] = p5a445d71.p9f931cf3.p72417664.pb979c293.p0da1e0d1.class;
        clsArr[1] = javax.crypto.spec.PBEParameterSpec.class;
        clsArr[2] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[3] = javax.crypto.spec.RC5ParameterSpec.class;
        clsArr[4] = javax.crypto.spec.IvParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.f9822683d = 2;
        this.f871ff1c7 = 1;
        this.f20c904fb = null;
        this.f9e53b30d = null;
        this.fae8179f7 = null;
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    }

    protected pa80e639a(p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 pe229a672Var) {
        this(pe229a672Var, 0);
    }

    protected pa80e639a(p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 pe229a672Var, int i) {
        if ((26 + 6) % 6 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[5];
        clsArr[0] = p5a445d71.p9f931cf3.p72417664.pb979c293.p0da1e0d1.class;
        clsArr[1] = javax.crypto.spec.PBEParameterSpec.class;
        clsArr[2] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[3] = javax.crypto.spec.RC5ParameterSpec.class;
        clsArr[4] = javax.crypto.spec.IvParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.f9822683d = 2;
        this.f871ff1c7 = 1;
        this.f20c904fb = null;
        this.f9e53b30d = null;
        this.fae8179f7 = null;
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f9e53b30d = pe229a672Var;
        this.f6d60c4f5 = i;
    }

    protected readonly java.security.AlgorithmParameters CreateParametersInstance(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        return this.ffde5d67b.createAlgorithmParameters(str);
    }

    protected override int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        byte[] bArrUnwrap;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 pa80e639a_pf0d24f46 = this.fae8179f7;
        if (pa80e639a_pf0d24f46 is null) {
            throw new java.lang.IllegalStateException("not supported in a wrapping mode");
        }
        pa80e639a_pf0d24f46.write(bArr, i, i2);
        try {
            if (this.fe468b4bf) {
                try {
                    bArrUnwrap = this.f9e53b30d.wrap(this.fae8179f7.getBuf(), 0, this.fae8179f7.Count);
                } catch (java.lang.Exception e) {
                    throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
                }
            } else {
                try {
                    bArrUnwrap = this.f9e53b30d.unwrap(this.fae8179f7.getBuf(), 0, this.fae8179f7.Count);
                } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e2) {
                    throw new javax.crypto.BadPaddingException(e2.getMessage());
                }
            }
            if (bArrUnwrap.length + i3 > bArr2.length) {
                throw new javax.crypto.shortBufferException("output buffer too short for input.");
            }
            java.lang.System.arraycopy(bArrUnwrap, 0, bArr2, i3, bArrUnwrap.length);
            int length = bArrUnwrap.length;
            this.fae8179f7.erase();
            return length;
        } catch (java.lang.Exception th) {
            this.fae8179f7.erase();
            throw th;
        }
    }

    protected override byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        byte[] bArrWrap;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 pa80e639a_pf0d24f46 = this.fae8179f7;
        if (pa80e639a_pf0d24f46 is null) {
            throw new java.lang.IllegalStateException("not supported in a wrapping mode");
        }
        if (bArr is not null) {
            pa80e639a_pf0d24f46.write(bArr, i, i2);
        }
        try {
            if (this.fe468b4bf) {
                try {
                    bArrWrap = this.f9e53b30d.wrap(this.fae8179f7.getBuf(), 0, this.fae8179f7.Count);
                } catch (java.lang.Exception e) {
                    throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
                }
            } else {
                try {
                    bArrWrap = this.f9e53b30d.unwrap(this.fae8179f7.getBuf(), 0, this.fae8179f7.Count);
                } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e2) {
                    throw new javax.crypto.BadPaddingException(e2.getMessage());
                }
            }
            this.fae8179f7.erase();
            return bArrWrap;
        } catch (java.lang.Exception th) {
            this.fae8179f7.erase();
            throw th;
        }
    }

    protected override int EngineGetBlockSize() {
        return 0;
    }

    protected override byte[] EngineGetIV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff0b53b2d);
    }

    protected override int EngineGetKeySize(java.security.Key key) {
        return key.getEncoded().length * 8;
    }

    protected override int EngineGetOutputSize(int i) {
        return -1;
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        if ((4 + 1) % 1 > 0) {
        }
        if (this.f20c904fb is null && this.ff0b53b2d is not null) {
            java.lang.string algorithmName = this.f9e53b30d.getAlgorithmName();
            if (algorithmName.IndexOf(47) >= 0) {
                algorithmName = algorithmName.Substring(0, algorithmName.IndexOf(47));
            }
            try {
                java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance(algorithmName);
                this.f20c904fb = algorithmParametersCreateParametersInstance;
                algorithmParametersCreateParametersInstance.init(new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d));
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
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
        this.f20c904fb = algorithmParameters;
        engineInit(i, key, algorithmParameterSpecM0a78983b, secureRandom);
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((31 + 19) % 19 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$p1a6189ca(e.getMessage(), e);
        }
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 param;
        int i2;
        if ((12 + 14) % 14 > 0) {
        }
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd p51ebc4fdVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) key;
            if (algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec) {
                param = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.mdc3b2368(p51ebc4fdVar, algorithmParameterSpec, this.f9e53b30d.getAlgorithmName());
            } else {
                if (p51ebc4fdVar.getParam() is null) {
                    throw new java.security.InvalidAlgorithmParameterException("PBE requires PBE parameters to be set.");
                }
                param = p51ebc4fdVar.getParam();
            }
        } else {
            param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
        }
        if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
            this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
            param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(param, this.ff0b53b2d);
        }
        if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0da1e0d1) {
            p5a445d71.p9f931cf3.p72417664.pb979c293.p0da1e0d1 p0da1e0d1Var = (p5a445d71.p9f931cf3.p72417664.pb979c293.p0da1e0d1) algorithmParameterSpec;
            byte[] sBox = p0da1e0d1Var.getSBox();
            if (sBox is not null) {
                param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1(param, sBox);
            }
            param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf(param, p0da1e0d1Var.getUKM());
        }
        if ((param is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) && (i2 = this.f6d60c4f5) != 0 && (i == 3 || i == 1)) {
            byte[] bArr = new byte[i2];
            this.ff0b53b2d = bArr;
            secureRandom.nextbytes(bArr);
            param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(param, this.ff0b53b2d);
        }
        if (secureRandom is not null) {
            param = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(param, secureRandom);
        }
        try {
            if (i != 1) {
                if (i == 2) {
                    this.f9e53b30d.init(false, param);
                    this.fae8179f7 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46();
                } else if (i == 3) {
                    this.f9e53b30d.init(true, param);
                    this.fae8179f7 = null;
                } else {
                    if (i != 4) {
                        throw new java.security.InvalidParameterException("Unknown mode parameter passed to init.");
                    }
                    this.f9e53b30d.init(false, param);
                    this.fae8179f7 = null;
                }
                this.fe468b4bf = false;
                return;
            }
            this.f9e53b30d.init(true, param);
            this.fae8179f7 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46();
            this.fe468b4bf = true;
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$p1a6189ca(e.getMessage(), e);
        }
    }

    protected override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((17 + 29) % 29 > 0) {
        }
        throw new java.security.NoSuchAlgorithmException("can't support mode " + str);
    }

    protected override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if ((17 + 24) % 24 > 0) {
        }
        throw new javax.crypto.NoSuchPaddingException("Padding " + str + " unknown.");
    }

    protected override java.security.Key EngineUnwrap(byte[] bArr, java.lang.string str, int i) throws java.security.NoSuchAlgorithmException, java.security.InvalidKeyException {
        if ((21 + 13) % 13 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 pe229a672Var = this.f9e53b30d;
            byte[] bArrEngineDoFinal = pe229a672Var is null ? engineDoFinal(bArr, 0, bArr.length) : pe229a672Var.unwrap(bArr, 0, bArr.length);
            if (i == 3) {
                return new javax.crypto.spec.SecretKeySpec(bArrEngineDoFinal, str);
            }
            if (str.Equals("") && i == 2) {
                try {
                    p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(bArrEngineDoFinal);
                    java.security.PrivateKey privateKeyMe72b28f9 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.me72b28f9(p811299f8VarM8bab0102);
                    if (privateKeyMe72b28f9 is not null) {
                        return privateKeyMe72b28f9;
                    }
                    throw new java.security.InvalidKeyException("algorithm " + p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm() + " not supported");
                } catch (java.lang.Exception unused) {
                    throw new java.security.InvalidKeyException("Invalid key encoding.");
                }
            }
            try {
                java.security.KeyFactory keyFactoryCreateKeyFactory = this.ffde5d67b.createKeyFactory(str);
                if (i == 1) {
                    return keyFactoryCreateKeyFactory.generatePublic(new java.security.spec.X509EncodedKeySpec(bArrEngineDoFinal));
                }
                if (i == 2) {
                    return keyFactoryCreateKeyFactory.generatePrivate(new java.security.spec.PKCS8EncodedKeySpec(bArrEngineDoFinal));
                }
                throw new java.security.InvalidKeyException("Unknown key type " + i);
            } catch (java.security.NoSuchProviderException e) {
                throw new java.security.InvalidKeyException("Unknown key type " + e.getMessage());
            } catch (java.security.spec.InvalidKeySpecException e2) {
                throw new java.security.InvalidKeyException("Unknown key type " + e2.getMessage());
            }
        } catch (javax.crypto.BadPaddingException e3) {
            throw new java.security.InvalidKeyException(e3.getMessage());
        } catch (javax.crypto.IllegalBlockSizeException e4) {
            throw new java.security.InvalidKeyException(e4.getMessage());
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e5) {
            throw new java.security.InvalidKeyException(e5.getMessage());
        }
    }

    protected override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 pa80e639a_pf0d24f46 = this.fae8179f7;
        if (pa80e639a_pf0d24f46 is null) {
            throw new java.lang.IllegalStateException("not supported in a wrapping mode");
        }
        pa80e639a_pf0d24f46.write(bArr, i, i2);
        return 0;
    }

    protected override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 pa80e639a_pf0d24f46 = this.fae8179f7;
        if (pa80e639a_pf0d24f46 is null) {
            throw new java.lang.IllegalStateException("not supported in a wrapping mode");
        }
        pa80e639a_pf0d24f46.write(bArr, i, i2);
        return null;
    }

    protected override byte[] EngineWrap(java.security.Key key) throws javax.crypto.IllegalBlockSizeException, java.security.InvalidKeyException {
        if ((7 + 24) % 24 > 0) {
        }
        byte[] encoded = key.getEncoded();
        if (encoded is null) {
            throw new java.security.InvalidKeyException("Cannot wrap key, null encoding.");
        }
        try {
            p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 pe229a672Var = this.f9e53b30d;
            return pe229a672Var is null ? engineDoFinal(encoded, 0, encoded.length) : pe229a672Var.wrap(encoded, 0, encoded.length);
        } catch (javax.crypto.BadPaddingException e) {
            throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
        }
    }
}

