namespace WillowMaze.Wasm.Decompiled;


public class p4c73b922 : java.security.spec.KeySpec {
    private short[][] f07bada18;
    private short[][] f1fb418eb;
    private short[][] f2f02c6ca;
    private short[][] f3bada2a8;
    private short[] f41239e31;
    private int f4e1568f6;
    private int f82878935;
    private short[][] f852a90f3;
    private int f9557f4ed;
    private short[][] f99d6d0c1;
    private short[][] fabd8ef20;
    private short[][] fc0aafe38;
    private short[] fe17f756f;
    private short[] fe60c0817;

    public p4c73b922(int i, short[][] sArr, short[][] sArr2, short[] sArr3) {
        this.f9557f4ed = i;
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

    public int GetDocLength() {
        return this.f9557f4ed;
    }
}

