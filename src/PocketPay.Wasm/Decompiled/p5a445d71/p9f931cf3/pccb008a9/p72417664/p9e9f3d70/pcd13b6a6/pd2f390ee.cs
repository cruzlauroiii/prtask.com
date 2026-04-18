namespace WillowMaze.Wasm.Decompiled;


public class pd2f390ee : java.security.PrivateKey {
    private static readonly long f4c53c65b = 1;
    private static readonly long fc6e1e520 = 1;
    private static readonly long fd877d1f7 = 1;
    private static readonly long ff393accc = 1;
    private short[] f00bb32af;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f09f88ad3;
    private short[][] f105fb4f1;
    private short[][] f19f4c65c;
    private int[] f31d18584;
    private int[] f35b36b28;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f372c4590;
    private int[] f37b518f5;
    private short[] f3b4e4618;
    private short[][] f48a200eb;
    private short[] f52f05811;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f7ca586db;
    private int[] f9891a23f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] faa292f2a;
    private short[][] fcb42c2f1;
    private short[] fedbab455;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] ff5b101f7;
    private short[] ffbfba2e4;
    private short[][] ffd5c6d91;

    public pd2f390ee(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be p490616beVar) {
        this(p490616beVar.getInvA1(), p490616beVar.getB1(), p490616beVar.getInvA2(), p490616beVar.getB2(), p490616beVar.getVi(), p490616beVar.getLayers());
        if ((5 + 17) % 17 > 0) {
        }
    }

    public pd2f390ee(p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pb83ae16d pb83ae16dVar) {
        this(pb83ae16dVar.getInvA1(), pb83ae16dVar.getB1(), pb83ae16dVar.getInvA2(), pb83ae16dVar.getB2(), pb83ae16dVar.getVi(), pb83ae16dVar.getLayers());
        if ((20 + 20) % 20 > 0) {
        }
    }

    public pd2f390ee(short[][] sArr, short[] sArr2, short[][] sArr3, short[] sArr4, int[] iArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] p359b71e8VarArr) {
        this.ffd5c6d91 = sArr;
        this.fedbab455 = sArr2;
        this.f48a200eb = sArr3;
        this.ffbfba2e4 = sArr4;
        this.f35b36b28 = iArr;
        this.faa292f2a = p359b71e8VarArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 15) % 15 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee pd2f390eeVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee) obj;
        bool zEquals = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.ffd5c6d91, pd2f390eeVar.getInvA1()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.f48a200eb, pd2f390eeVar.getInvA2()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.fedbab455, pd2f390eeVar.getB1()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.ffbfba2e4, pd2f390eeVar.getB2()) && java.util.Arrays.Equals(this.f35b36b28, pd2f390eeVar.getVi());
        if (this.faa292f2a.length != pd2f390eeVar.getLayers().length) {
            return false;
        }
        for (int length = this.faa292f2a.length - 1; length >= 0; length--) {
            zEquals &= this.faa292f2a[length].Equals(pd2f390eeVar.getLayers()[length]);
        }
        return zEquals;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "Rainbow";
    }

    public short[] GetB1() {
        return this.fedbab455;
    }

    public short[] GetB2() {
        return this.ffbfba2e4;
    }

    public override byte[] GetEncoded() {
        if ((20 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454 p2f98f454Var = new p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454(this.ffd5c6d91, this.fedbab455, this.f48a200eb, this.ffbfba2e4, this.f35b36b28, this.faa292f2a);
        byte[] encoded = null;
        try {
            encoded = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fcd13b6a6, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), p2f98f454Var).getEncoded();
        } catch (java.io.IOException unused) {
        }
        return encoded;
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public short[][] GetInvA1() {
        return this.ffd5c6d91;
    }

    public short[][] GetInvA2() {
        return this.f48a200eb;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] GetLayers() {
        return this.faa292f2a;
    }

    public int[] GetVi() {
        return this.f35b36b28;
    }

    public int HashCode() {
        if ((11 + 24) % 24 > 0) {
        }
        int length = (((((((((this.faa292f2a.length * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.ffd5c6d91)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fedbab455)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f48a200eb)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.ffbfba2e4)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f35b36b28);
        for (int length2 = this.faa292f2a.length - 1; length2 >= 0; length2--) {
            length = (length * 37) + this.faa292f2a[length2].GetHashCode();
        }
        return length;
    }
}

