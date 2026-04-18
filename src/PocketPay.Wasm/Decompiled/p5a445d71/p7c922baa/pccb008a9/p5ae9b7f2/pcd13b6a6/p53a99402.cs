namespace WillowMaze.Wasm.Decompiled;


public class p53a99402 : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d {
    private short[][] f03a790be;
    private short[][] f043ee88c;
    private short[] f0ba4fbaf;
    private short[] f13ffefa4;
    private short[][] f1fb418eb;
    private short[][] f3bada2a8;
    private short[] f41239e31;
    private short[][] f42a122be;
    private short[][] f56f4bc57;
    private short[][] f5a5ed178;
    private short[][] f7a65b28f;
    private short[][] f80a3ac63;
    private short[][] f9b16e18b;
    private short[] fc0a42ea5;
    private short[] fc8acd697;

    public p53a99402(int i, short[][] sArr, short[][] sArr2, short[] sArr3) {
        super(false, i);
        this.f1fb418eb = sArr;
        this.f3bada2a8 = sArr2;
        this.f41239e31 = sArr3;
    }

    public short[][] GetCoeffQuadratic() {
        return this.f1fb418eb;
    }

    public short[] GetCoeffScalar() {
        return this.f41239e31;
    }

    public short[][] GetCoeffSingular() {
        return this.f3bada2a8;
    }
}

