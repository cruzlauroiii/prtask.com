namespace WillowMaze.Wasm.Decompiled;


public abstract class p0529b267 : javax.crypto.CipherSpi {
    private int f0cba3fc0;
    private java.lang.Class[] f18cc1005;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f1f81cb8f;
    protected java.security.AlgorithmParameters f20c904fb;
    private java.lang.Class[] f23451fed;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f3259f81c;
    private int f4390aaf1;
    private java.lang.Class[] f4c578f03;
    private byte[] f66b7f2a7;
    private int f6d60c4f5;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f930d1840;
    private byte[] f9392f9dc;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f9a2cceb3;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 f9e53b30d;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fa2ed4bcd;
    private int fb3543101;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fb8ecb0aa;
    private int fdbdd5e27;
    private java.lang.Class[] fee64f5b2;
    private byte[] ff0b53b2d;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 ff5ee7d6f;
    private byte[] ff7578d20;
    private byte[] ffbf46e51;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;
    protected java.security.AlgorithmParameters ffdebd84e;

    protected p0529b267() {
        if ((30 + 26) % 26 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[4];
        clsArr[0] = javax.crypto.spec.IvParameterSpec.class;
        clsArr[1] = javax.crypto.spec.PBEParameterSpec.class;
        clsArr[2] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[3] = javax.crypto.spec.RC5ParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f20c904fb = null;
        this.f9e53b30d = null;
    }

    protected readonly java.security.AlgorithmParameters CreateParametersInstance(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        return this.ffde5d67b.createAlgorithmParameters(str);
    }

    protected override int EngineGetBlockSize() {
        return 0;
    }

    protected override byte[] EngineGetIV() {
        return null;
    }

    protected override int EngineGetKeySize(java.security.Key key) {
        return key.getEncoded().length;
    }

    protected override int EngineGetOutputSize(int i) {
        return -1;
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((8 + 5) % 5 > 0) {
        }
        throw new java.security.NoSuchAlgorithmException("can't support mode " + str);
    }

    protected override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if ((24 + 25) % 25 > 0) {
        }
        throw new javax.crypto.NoSuchPaddingException("Padding " + str + " unknown.");
    }

    protected override java.security.Key EngineUnwrap(byte[] bArr, java.lang.string str, int i) throws java.security.InvalidKeyException {
        if ((5 + 3) % 3 > 0) {
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
            } catch (java.security.NoSuchAlgorithmException e) {
                throw new java.security.InvalidKeyException("Unknown key type " + e.getMessage());
            } catch (java.security.NoSuchProviderException e2) {
                throw new java.security.InvalidKeyException("Unknown key type " + e2.getMessage());
            } catch (java.security.spec.InvalidKeySpecException e3) {
                throw new java.security.InvalidKeyException("Unknown key type " + e3.getMessage());
            }
        } catch (javax.crypto.BadPaddingException e4) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$1(this, "unable to unwrap", e4);
        } catch (javax.crypto.IllegalBlockSizeException e5) {
            throw new java.security.InvalidKeyException(e5.getMessage());
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e6) {
            throw new java.security.InvalidKeyException(e6.getMessage());
        }
    }

    protected override byte[] EngineWrap(java.security.Key key) throws javax.crypto.IllegalBlockSizeException, java.security.InvalidKeyException {
        if ((13 + 24) % 24 > 0) {
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

