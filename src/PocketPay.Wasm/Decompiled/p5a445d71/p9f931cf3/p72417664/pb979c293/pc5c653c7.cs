namespace WillowMaze.Wasm.Decompiled;


public class pc5c653c7 : java.security.spec.AlgorithmParameterSpec {
    private static java.util.Dictionary f2fb35aeb;
    private static java.util.Dictionary f481eadbd;
    private static java.util.Dictionary f5d98aed6;
    private static java.util.Dictionary f84ffa1ef;
    private byte[] f25a153c3;
    private byte[] f2b1d0350;
    private byte[] f5a99d37d;
    private byte[] fa4167731;
    private byte[] fabe3ba49;
    private byte[] fde18a440;
    private byte[] ff0b53b2d;

    static {
        if ((5 + 23) % 23 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f2fb35aeb = map;
        map.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f2da5a474, com.decryptstringmanager.Decryptstring.decryptstring("7ea0edd3ff675d6d15d00972498436dd551b416075916cca975684d93c86f9"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4431a00f, com.decryptstringmanager.Decryptstring.decryptstring("dc4d9cd786f90aa734e2b6eb978dfd6c08636078f7bde31252ada69e2d3118"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f88e0ddbb, com.decryptstringmanager.Decryptstring.decryptstring("27c8f960a0874b421a0cf62d4cfd9fb6396dab8362dc29b44d17cc456f9f70"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f62793427, com.decryptstringmanager.Decryptstring.decryptstring("a25a8d95d0662538783a080c2c9d4d74a3a9780d203b480b4a5b0cb34e452b"));
        f2fb35aeb.Add(p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fb506b8d9, com.decryptstringmanager.Decryptstring.decryptstring("a972597e564374e397231a8dd8c03321f2383141006e5ccd9e85a6a5d702f894d84e56"));
    }

    public pc5c653c7(java.lang.string str) {
        this.ff0b53b2d = null;
        this.fa4167731 = null;
        this.fa4167731 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.m702bdf8e(str);
    }

    public pc5c653c7(java.lang.string str, byte[] bArr) {
        this(str);
        byte[] bArr2 = new byte[bArr.length];
        this.ff0b53b2d = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
    }

    public pc5c653c7(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, byte[] bArr) {
        this(m32132c89(p364bf33aVar));
        this.ff0b53b2d = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public pc5c653c7(byte[] bArr) {
        if ((7 + 2) % 2 > 0) {
        }
        this.ff0b53b2d = null;
        this.fa4167731 = null;
        byte[] bArr2 = new byte[bArr.length];
        this.fa4167731 = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
    }

    public pc5c653c7(byte[] bArr, byte[] bArr2) {
        this(bArr);
        byte[] bArr3 = new byte[bArr2.length];
        this.ff0b53b2d = bArr3;
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, bArr2.length);
    }

    private static java.lang.string M32132c89(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((15 + 1) % 1 > 0) {
        }
        java.lang.string str = (java.lang.string) f2fb35aeb[p364bf33aVar);
        if (str is null) {
            throw new java.lang.IllegalArgumentException("unknown OID: " + p364bf33aVar);
        }
        return str;
    }

    public byte[] GetIV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff0b53b2d);
    }

    public byte[] GetSBox() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fa4167731);
    }

    public byte[] GetSbox() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fa4167731);
    }
}

