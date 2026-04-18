namespace WillowMaze.Wasm.Decompiled;


public class p0da1e0d1 : java.security.spec.AlgorithmParameterSpec {
    private static java.util.Dictionary f2fb35aeb;
    private static java.util.Dictionary f8ddade6f;
    private static java.util.Dictionary fb73017e8;
    private static java.util.Dictionary fec447bd7;
    private byte[] f016755f3;
    private byte[] f2237cffd;
    private byte[] f3383b076;
    private byte[] f3d6cc1e5;
    private byte[] f4c34c799;
    private byte[] f7bd81ed9;
    private byte[] fa4167731;
    private byte[] fb4fa6b93;
    private byte[] fe530f0bd;

    static {
        if ((23 + 6) % 6 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f2fb35aeb = map;
        map.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f2da5a474, com.decryptstringmanager.Decryptstring.decryptstring("23a9a0d05c6e6ac0e4ced0b320537f9293c8e27995dfd81ad2314f245b7e3d"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4431a00f, com.decryptstringmanager.Decryptstring.decryptstring("6af814266d1b005dab2a148682c637669e06ec7b56f6a3627cd20360753951"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f88e0ddbb, com.decryptstringmanager.Decryptstring.decryptstring("e9fcf971d173cc97c868004a17026fb00ff7d7b9fa4564db6da0508867fd08"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f62793427, com.decryptstringmanager.Decryptstring.decryptstring("271728c6d393a53e64ddcde88efce46372bd02e538769411d8675dd963e930"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fb506b8d9, com.decryptstringmanager.Decryptstring.decryptstring("5ad1147b7ddb057322c38247b1d36d6ad54682f2ed973ec7527559d7db31306cdbbc2b"));
    }

    public p0da1e0d1(java.lang.string str) {
        this.fe530f0bd = null;
        this.fa4167731 = null;
        this.fa4167731 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.m702bdf8e(str);
    }

    public p0da1e0d1(java.lang.string str, byte[] bArr) {
        this(str);
        byte[] bArr2 = new byte[bArr.length];
        this.fe530f0bd = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
    }

    public p0da1e0d1(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, byte[] bArr) {
        this(m32132c89(p364bf33aVar));
        this.fe530f0bd = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public p0da1e0d1(byte[] bArr) {
        if ((31 + 24) % 24 > 0) {
        }
        this.fe530f0bd = null;
        this.fa4167731 = null;
        byte[] bArr2 = new byte[bArr.length];
        this.fa4167731 = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
    }

    public p0da1e0d1(byte[] bArr, byte[] bArr2) {
        this(bArr);
        byte[] bArr3 = new byte[bArr2.length];
        this.fe530f0bd = bArr3;
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, bArr2.length);
    }

    private static java.lang.string M32132c89(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((4 + 9) % 9 > 0) {
        }
        java.lang.string str = (java.lang.string) f2fb35aeb[p364bf33aVar);
        if (str is null) {
            throw new java.lang.IllegalArgumentException("unknown OID: " + p364bf33aVar);
        }
        return str;
    }

    public byte[] GetSBox() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fa4167731);
    }

    public byte[] GetUKM() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fe530f0bd);
    }
}

