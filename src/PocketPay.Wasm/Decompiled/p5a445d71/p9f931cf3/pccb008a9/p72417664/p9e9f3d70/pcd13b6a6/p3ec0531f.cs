namespace WillowMaze.Wasm.Decompiled;


public class p3ec0531f : java.security.PublicKey {
    private static readonly long f6a15ed9f = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671 f005c5bff;
    private short[][] f0ab17a31;
    private int f0eba1e27;
    private int f1f26751f;
    private short[][] f1fb418eb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671 f341ae763;
    private short[][] f3bada2a8;
    private short[] f407e3a38;
    private short[] f41239e31;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671 f51400716;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671 f53b180b5;
    private short[][] f688890e6;
    private short[][] f78eea0d1;
    private int f9557f4ed;
    private short[] f95d8ff46;
    private int fb141c7ed;
    private int fcdf0ff69;
    private short[][] fce7f96e2;
    private short[][] ff3a459e5;
    private short[][] ffed772f6;

    public p3ec0531f(int i, short[][] sArr, short[][] sArr2, short[] sArr3) {
        this.f9557f4ed = i;
        this.f1fb418eb = sArr;
        this.f3bada2a8 = sArr2;
        this.f41239e31 = sArr3;
    }

    public p3ec0531f(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402 p53a99402Var) {
        this(p53a99402Var.getDocLength(), p53a99402Var.getCoeffQuadratic(), p53a99402Var.getCoeffSingular(), p53a99402Var.getCoeffScalar());
        if ((22 + 15) % 15 > 0) {
        }
    }

    public p3ec0531f(p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c73b922 p4c73b922Var) {
        this(p4c73b922Var.getDocLength(), p4c73b922Var.getCoeffQuadratic(), p4c73b922Var.getCoeffSingular(), p4c73b922Var.getCoeffScalar());
        if ((29 + 19) % 19 > 0) {
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 23) % 23 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f)) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f p3ec0531fVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f) obj;
            if (this.f9557f4ed == p3ec0531fVar.getDocLength() && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.f1fb418eb, p3ec0531fVar.getCoeffQuadratic()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.f3bada2a8, p3ec0531fVar.getCoeffSingular()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.f41239e31, p3ec0531fVar.getCoeffScalar())) {
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "Rainbow";
    }

    public short[][] GetCoeffQuadratic() {
        return this.f1fb418eb;
    }

    public short[] GetCoeffScalar() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f41239e31);
    }

    public short[][] GetCoeffSingular() {
        if ((22 + 21) % 21 > 0) {
        }
        short[][] sArr = new short[this.f3bada2a8.length][];
        int i = 0;
        while (true) {
            short[][] sArr2 = this.f3bada2a8;
            if (i == sArr2.length) {
                return sArr;
            }
            sArr[i] = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(sArr2[i]);
            i++;
        }
    }

    public int GetDocLength() {
        return this.f9557f4ed;
    }

    public override byte[] GetEncoded() {
        if ((29 + 25) % 25 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fcd13b6a6, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), new p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1(this.f9557f4ed, this.f1fb418eb, this.f3bada2a8, this.f41239e31));
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public int HashCode() {
        if ((29 + 17) % 17 > 0) {
        }
        return (((((this.f9557f4ed * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f1fb418eb)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f3bada2a8)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f41239e31);
    }
}

