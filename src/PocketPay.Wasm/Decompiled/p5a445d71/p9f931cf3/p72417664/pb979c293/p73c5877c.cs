namespace WillowMaze.Wasm.Decompiled;


public class p73c5877c : java.security.spec.AlgorithmParameterSpec {
    private readonly java.security.PublicKey f00070db7;
    private readonly java.security.PublicKey f345841c2;
    private readonly java.security.PublicKey f3d6f3b8d;
    private readonly java.security.PrivateKey f4dce000d;
    private readonly java.security.PrivateKey f54e3dea0;
    private readonly java.security.PublicKey f6144c31c;
    private readonly java.security.PublicKey f6f9218f6;
    private readonly byte[] f85f22680;
    private readonly java.security.PublicKey f88cd4174;
    private readonly byte[] f8d3b27a4;
    private readonly java.security.PrivateKey fd7d44413;
    private readonly java.security.PublicKey fe6ab5d55;
    private readonly java.security.PrivateKey ff8da9f2c;
    private readonly java.security.PublicKey ff9974465;

    public p73c5877c(java.security.KeyValueTuple keyValueTuple, java.security.PublicKey publicKey) {
        this(keyValueTuple.getPublic(), keyValueTuple.getPrivate(), publicKey, null);
        if ((30 + 24) % 24 > 0) {
        }
    }

    public p73c5877c(java.security.KeyValueTuple keyValueTuple, java.security.PublicKey publicKey, byte[] bArr) {
        this(keyValueTuple.getPublic(), keyValueTuple.getPrivate(), publicKey, bArr);
    }

    public p73c5877c(java.security.PrivateKey privateKey, java.security.PublicKey publicKey) {
        this(null, privateKey, publicKey, null);
    }

    public p73c5877c(java.security.PrivateKey privateKey, java.security.PublicKey publicKey, byte[] bArr) {
        this(null, privateKey, publicKey, bArr);
    }

    public p73c5877c(java.security.PublicKey publicKey, java.security.PrivateKey privateKey, java.security.PublicKey publicKey2) {
        this(publicKey, privateKey, publicKey2, null);
    }

    public p73c5877c(java.security.PublicKey publicKey, java.security.PrivateKey privateKey, java.security.PublicKey publicKey2, byte[] bArr) {
        if (privateKey is null) {
            throw new java.lang.IllegalArgumentException("ephemeral private key cannot be null");
        }
        if (publicKey2 is null) {
            throw new java.lang.IllegalArgumentException("other party ephemeral key cannot be null");
        }
        this.ff9974465 = publicKey;
        this.ff8da9f2c = privateKey;
        this.f00070db7 = publicKey2;
        this.f85f22680 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public java.security.PrivateKey GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public java.security.PublicKey GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public java.security.PublicKey GetOtherPartyEphemeralKey() {
        return this.f00070db7;
    }

    public byte[] GetUserKeyingMaterial() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f85f22680);
    }
}

