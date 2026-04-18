namespace WillowMaze.Wasm.Decompiled;


public class p97b2f481 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private byte[] f08d6542c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f0cba4829;
    private int f2496da2f;
    private byte[] f3dc501d5;
    private byte[] f46c8a16b;
    private int f4b815e60;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f55fe89ae;
    private byte[] f589e9c5f;
    private int f7f7abd77;
    private int f8cfa8706;
    private byte[] f9b06d0b9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fa7edb006;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fdb1f2346;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fed469618;
    private byte[] ff54ada7c;
    private byte[] ffbade9e3;
    private byte[] ffc4bb76d;

    public p97b2f481(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, int i, byte[] bArr) {
        this(p364bf33aVar, i, bArr, null);
    }

    public p97b2f481(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, int i, byte[] bArr, byte[] bArr2) {
        this.fed469618 = p364bf33aVar;
        this.f2496da2f = i;
        this.ffbade9e3 = bArr;
        this.f589e9c5f = bArr2;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetAlgorithm() {
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

