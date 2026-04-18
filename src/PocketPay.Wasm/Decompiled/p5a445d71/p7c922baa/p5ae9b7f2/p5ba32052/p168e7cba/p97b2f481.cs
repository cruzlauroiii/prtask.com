namespace WillowMaze.Wasm.Decompiled;


public class p97b2f481 : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    private p5a445d71.p7c922baa.pca323100.p364bf33a f0a67795d;
    private int f0ef8d4a7;
    private int f2496da2f;
    private byte[] f29ba96a7;
    private byte[] f4d135ebe;
    private byte[] f589e9c5f;
    private byte[] f6e099507;
    private byte[] f868224d4;
    private byte[] f95f40ff2;
    private byte[] fa5f323b0;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fafe06d47;
    private byte[] fd4282bf0;
    private int feac217c5;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fed469618;
    private byte[] ffbade9e3;

    public p97b2f481(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, int i, byte[] bArr) {
        this(p364bf33aVar, i, bArr, null);
    }

    public p97b2f481(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, int i, byte[] bArr, byte[] bArr2) {
        this.fed469618 = p364bf33aVar;
        this.f2496da2f = i;
        this.ffbade9e3 = bArr;
        this.f589e9c5f = bArr2;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAlgorithm() {
        return this.fed469618;
    }

    public byte[] GetExtraInfo() {
        return this.f589e9c5f;
    }

    public int GetKeySize() {
        return this.f2496da2f;
    }

    public byte[] GetZ() {
        return this.ffbade9e3;
    }
}

