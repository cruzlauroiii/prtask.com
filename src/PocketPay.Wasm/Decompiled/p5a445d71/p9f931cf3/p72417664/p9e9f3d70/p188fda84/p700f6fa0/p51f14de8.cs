namespace WillowMaze.Wasm.Decompiled;


public class p51f14de8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f {
    private static readonly java.math.Bigint f0c3405f1 = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f1fab1c66 = null;
    private static readonly java.math.Bigint f9d4e2ebc = null;
    private static readonly java.math.Bigint fa7ef153b = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fcf92fc60 = null;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c f06bb221f;
    private java.math.Bigint f07e05100;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b f10465d73;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 f2bc72b0b;
    private java.math.Bigint f2d6b9982;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b f39218891;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 f3ae6fba0;
    private byte[] f5dc264ba;
    private java.math.Bigint f72814489;
    private java.math.Bigint f83878c91;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 f8c6223b0;
    private java.math.Bigint f93e27ff6;
    private byte[] f9d48ddfc;
    private java.math.Bigint f9dd4e461;
    private java.math.Bigint fa055903f;
    private java.math.Bigint fb2f5ff47;
    private byte[] fb4a88417;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c fb728c914;
    private byte[] fbc42457f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 fbdabf83a;
    private java.math.Bigint fca5fe8d5;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b fd0b1f5e9;
    private java.math.Bigint fd1623c44;
    private java.math.Bigint fd31bc1cf;
    private java.math.Bigint fda72aa6f;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c fde7894ab;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b feafcc14a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b feb1b8f5e;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 ff6679e3a;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c ffda14aec;

    static {
        if ((31 + 26) % 26 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public p51f14de8() {
        this("Diffie-Hellman", null);
        if ((11 + 8) % 8 > 0) {
        }
    }

    public p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.fd0b1f5e9 = null;
        this.fbdabf83a = null;
    }

    public p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.fd0b1f5e9 = null;
        this.fbdabf83a = p38d4f313Var;
    }

    public p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b pe2d8c23bVar, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.fd0b1f5e9 = pe2d8c23bVar;
        this.fbdabf83a = null;
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((8 + 18) % 18 > 0) {
        }
        if (!(privateKey is javax.crypto.interfaces.DHPrivateKey)) {
            throw new java.security.InvalidKeyException("private key not a DHPrivateKey");
        }
        if (privateKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e) privateKey).engineGetKeyParameters();
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) privateKey;
        javax.crypto.spec.DHParameterSpec params = dHPrivateKey.getParams();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(dHPrivateKey.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(params.getP(), params.getG(), null, params.getL()));
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((21 + 29) % 29 > 0) {
        }
        if (!(publicKey is javax.crypto.interfaces.DHPublicKey)) {
            throw new java.security.InvalidKeyException("public key not a DHPublicKey");
        }
        if (publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34) publicKey).engineGetKeyParameters();
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) publicKey;
        javax.crypto.spec.DHParameterSpec params = dHPublicKey.getParams();
        return !(params is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(dHPublicKey.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(params.getP(), params.getG(), null, params.getL())) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(dHPublicKey.getY(), ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) params).getDomainParameters());
    }

    protected byte[] BigIntTobytes(java.math.Bigint bigint) {
        if ((10 + 24) % 24 > 0) {
        }
        int iBitLength = (this.f83878c91.bitLength() + 7) / 8;
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length == iBitLength) {
            return byteArray;
        }
        if (byteArray[0] != 0 || byteArray.length != iBitLength + 1) {
            byte[] bArr = new byte[iBitLength];
            java.lang.System.arraycopy(byteArray, 0, bArr, iBitLength - byteArray.length, byteArray.length);
            return bArr;
        }
        int length = byteArray.length - 1;
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(byteArray, 1, bArr2, 0, length);
        return bArr2;
    }

    protected override byte[] CalcSecret() {
        return this.fb4a88417;
    }

    protected override java.security.Key EngineDoPhase(java.security.Key key, bool z) throws java.lang.IllegalStateException, java.security.InvalidKeyException {
        if ((23 + 8) % 8 > 0) {
        }
        if (this.f9dd4e461 is null) {
            throw new java.lang.IllegalStateException("Diffie-Hellman not initialised.");
        }
        if (!(key is javax.crypto.interfaces.DHPublicKey)) {
            throw new java.security.InvalidKeyException("DHKeyAgreement doPhase requires DHPublicKey");
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) key;
        if (!dHPublicKey.getParams().getG().Equals(this.fb2f5ff47) || !dHPublicKey.getParams().getP().Equals(this.f83878c91)) {
            throw new java.security.InvalidKeyException("DHPublicKey not for this KeyAgreement!");
        }
        java.math.Bigint y = dHPublicKey.getY();
        if (y is not null && y.compareTo(f0f82d86a) >= 0) {
            java.math.Bigint bigint = this.f83878c91;
            java.math.Bigint bigint2 = fbc21e648;
            if (y.compareTo(bigint.subtract(bigint2)) < 0) {
                if (this.fd0b1f5e9 is not null) {
                    if (!z) {
                        throw new java.lang.IllegalStateException("unified Diffie-Hellman can use only two key pairs");
                    }
                    this.fb4a88417 = this.fd0b1f5e9.calculateAgreement(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1c11fbf7(mc2499d21((java.security.PublicKey) key), mc2499d21(this.f06bb221f.getOtherPartyEphemeralKey())));
                    return null;
                }
                if (this.fbdabf83a is not null) {
                    if (!z) {
                        throw new java.lang.IllegalStateException("MQV Diffie-Hellman can use only two key pairs");
                    }
                    this.fb4a88417 = bigIntTobytes(this.fbdabf83a.calculateAgreement(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa666112c(mc2499d21((java.security.PublicKey) key), mc2499d21(this.ff6679e3a.getOtherPartyEphemeralKey()))));
                    return null;
                }
                java.math.Bigint bigintModPow = y.modPow(this.f9dd4e461, this.f83878c91);
                if (bigintModPow.compareTo(bigint2) == 0) {
                    throw new java.security.InvalidKeyException("Shared key can't be 1");
                }
                this.fb4a88417 = bigIntTobytes(bigintModPow);
                if (z) {
                    return null;
                }
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34(bigintModPow, dHPublicKey.getParams());
            }
        }
        throw new java.security.InvalidKeyException("Invalid DH PublicKey");
    }

    protected override int EngineGenerateSecret(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.shortBufferException {
        if (this.f9dd4e461 is null) {
            throw new java.lang.IllegalStateException("Diffie-Hellman not initialised.");
        }
        return super.engineGenerateSecret(bArr, i);
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if (this.f9dd4e461 is null) {
            throw new java.lang.IllegalStateException("Diffie-Hellman not initialised.");
        }
        return !str.Equals("TlsPremasterSecret") ? super.engineGenerateSecret(str) : new javax.crypto.spec.SecretKeySpec(trimZeroes(this.fb4a88417), str);
    }

    protected override byte[] EngineGenerateSecret() throws java.lang.IllegalStateException {
        if (this.f9dd4e461 is null) {
            throw new java.lang.IllegalStateException("Diffie-Hellman not initialised.");
        }
        return super.engineGenerateSecret();
    }

    protected override void EngineInit(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if (!(key is javax.crypto.interfaces.DHPrivateKey)) {
            throw new java.security.InvalidKeyException("DHKeyAgreement requires DHPrivateKey");
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) key;
        this.f83878c91 = dHPrivateKey.getParams().getP();
        this.fb2f5ff47 = dHPrivateKey.getParams().getG();
        java.math.Bigint x = dHPrivateKey.getX();
        this.f9dd4e461 = x;
        this.fb4a88417 = bigIntTobytes(x);
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe2d8c23b pe2d8c23bVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca pfbd59bcaVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 p38d4f313Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4 p251537e4Var;
        if ((16 + 9) % 9 > 0) {
        }
        if (!(key is javax.crypto.interfaces.DHPrivateKey)) {
            throw new java.security.InvalidKeyException("DHKeyAgreement requires DHPrivateKey for initialisation");
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) key;
        if (algorithmParameterSpec is null) {
            this.f83878c91 = dHPrivateKey.getParams().getP();
            this.fb2f5ff47 = dHPrivateKey.getParams().getG();
        } else if (algorithmParameterSpec is javax.crypto.spec.DHParameterSpec) {
            javax.crypto.spec.DHParameterSpec dHParameterSpec = (javax.crypto.spec.DHParameterSpec) algorithmParameterSpec;
            this.f83878c91 = dHParameterSpec.getP();
            this.fb2f5ff47 = dHParameterSpec.getG();
            this.f06bb221f = null;
            this.f53f67e05 = null;
        } else if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c) {
            if (this.fd0b1f5e9 is null) {
                throw new java.security.InvalidAlgorithmParameterException("agreement algorithm not DHU based");
            }
            this.f83878c91 = dHPrivateKey.getParams().getP();
            this.fb2f5ff47 = dHPrivateKey.getParams().getG();
            p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c p73c5877cVar = (p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c) algorithmParameterSpec;
            this.f06bb221f = p73c5877cVar;
            this.f53f67e05 = p73c5877cVar.getUserKeyingMaterial();
            if (this.f06bb221f.getEphemeralPublicKey() is null) {
                pe2d8c23bVar = this.fd0b1f5e9;
                pfbd59bcaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca(m02ea6360(dHPrivateKey), m02ea6360(this.f06bb221f.getEphemeralPrivateKey()));
            } else {
                pe2d8c23bVar = this.fd0b1f5e9;
                pfbd59bcaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pfbd59bca(m02ea6360(dHPrivateKey), m02ea6360(this.f06bb221f.getEphemeralPrivateKey()), mc2499d21(this.f06bb221f.getEphemeralPublicKey()));
            }
            pe2d8c23bVar.init(pfbd59bcaVar);
        } else if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7) {
            if (this.fbdabf83a is null) {
                throw new java.security.InvalidAlgorithmParameterException("agreement algorithm not MQV based");
            }
            this.f83878c91 = dHPrivateKey.getParams().getP();
            this.fb2f5ff47 = dHPrivateKey.getParams().getG();
            p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 pc2763cb7Var = (p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7) algorithmParameterSpec;
            this.ff6679e3a = pc2763cb7Var;
            this.f53f67e05 = pc2763cb7Var.getUserKeyingMaterial();
            if (this.ff6679e3a.getEphemeralPublicKey() is null) {
                p38d4f313Var = this.fbdabf83a;
                p251537e4Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4(m02ea6360(dHPrivateKey), m02ea6360(this.ff6679e3a.getEphemeralPrivateKey()));
            } else {
                p38d4f313Var = this.fbdabf83a;
                p251537e4Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4(m02ea6360(dHPrivateKey), m02ea6360(this.ff6679e3a.getEphemeralPrivateKey()), mc2499d21(this.ff6679e3a.getEphemeralPublicKey()));
            }
            p38d4f313Var.init(p251537e4Var);
        } else {
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653)) {
                throw new java.security.InvalidAlgorithmParameterException("DHKeyAgreement only accepts DHParameterSpec");
            }
            if (this.f168e7cba is null) {
                throw new java.security.InvalidAlgorithmParameterException("no KDF specified for UserKeyingMaterialSpec");
            }
            this.f83878c91 = dHPrivateKey.getParams().getP();
            this.fb2f5ff47 = dHPrivateKey.getParams().getG();
            this.f06bb221f = null;
            this.f53f67e05 = ((p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) algorithmParameterSpec).getUserKeyingMaterial();
        }
        java.math.Bigint x = dHPrivateKey.getX();
        this.f9dd4e461 = x;
        this.fb4a88417 = bigIntTobytes(x);
    }
}

