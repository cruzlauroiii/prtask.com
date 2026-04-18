namespace WillowMaze.Wasm.Decompiled;


public class p53a99402 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d {
    private short[][] f0494f80c;
    private short[][] f0c682cf9;
    private short[][] f13d66b41;
    private short[][] f1fb418eb;
    private short[][] f2c21c92a;
    private short[][] f3bada2a8;
    private short[] f41239e31;
    private short[][] f79737ae2;
    private short[][] f7b562c5c;
    private short[] f7ff593a8;
    private short[][] f9128b43b;
    private short[] f99a3ab9f;

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

