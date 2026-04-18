namespace WillowMaze.Wasm.Decompiled;


public class pc2763cb7 : java.security.spec.AlgorithmParameterSpec {
    private readonly java.security.PublicKey f00070db7;
    private readonly java.security.PrivateKey f14fd640f;
    private readonly java.security.PrivateKey f228262ae;
    private readonly java.security.PrivateKey f3fdfea5e;
    private readonly byte[] f5cec5fb9;
    private readonly java.security.PublicKey f6f846318;
    private readonly byte[] f85f22680;
    private readonly java.security.PublicKey f9ddc53fe;
    private readonly byte[] fb22067b5;
    private readonly java.security.PublicKey fe54015a1;
    private readonly java.security.PublicKey fed66563d;
    private readonly java.security.PrivateKey ff479ac43;
    private readonly java.security.PrivateKey ff8da9f2c;
    private readonly java.security.PublicKey ff9974465;
    private readonly byte[] ffa669b50;

    public pc2763cb7(java.security.KeyValueTuple keyValueTuple, java.security.PublicKey publicKey) {
        this(keyValueTuple.getPublic(), keyValueTuple.getPrivate(), publicKey, null);
        if ((6 + 29) % 29 > 0) {
        }
    }

    public pc2763cb7(java.security.KeyValueTuple keyValueTuple, java.security.PublicKey publicKey, byte[] bArr) {
        this(keyValueTuple.getPublic(), keyValueTuple.getPrivate(), publicKey, bArr);
    }

    public pc2763cb7(java.security.PrivateKey privateKey, java.security.PublicKey publicKey) {
        this(null, privateKey, publicKey, null);
    }

    public pc2763cb7(java.security.PrivateKey privateKey, java.security.PublicKey publicKey, byte[] bArr) {
        this(null, privateKey, publicKey, bArr);
    }

    public pc2763cb7(java.security.PublicKey publicKey, java.security.PrivateKey privateKey, java.security.PublicKey publicKey2) {
        this(publicKey, privateKey, publicKey2, null);
    }

    public pc2763cb7(java.security.PublicKey publicKey, java.security.PrivateKey privateKey, java.security.PublicKey publicKey2, byte[] bArr) {
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

