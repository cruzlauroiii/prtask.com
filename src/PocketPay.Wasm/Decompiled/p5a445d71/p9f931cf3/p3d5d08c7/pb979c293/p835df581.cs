namespace WillowMaze.Wasm.Decompiled;


public class p835df581 : java.security.spec.AlgorithmParameterSpec {
    private byte[] f09c5555d;
    private java.math.Bigint f2510c390;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4a4bd5ea;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4efa264f;
    private byte[] f69775873;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f7071f3d3;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f7487ae4f;
    private java.math.Bigint f7b8b965a;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f7e1e8e64;
    private byte[] f80712260;
    private java.math.Bigint f9a912775;
    private java.math.Bigint fbed682e3;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fdfcf28d0;
    private java.math.Bigint fe7f5b8e5;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa ff12b82f1;
    private byte[] ffe4c0f30;

    public p835df581(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        this.f4efa264f = pa827ecfaVar;
        this.fdfcf28d0 = p53a5793fVar.normalize();
        this.f7b8b965a = bigint;
        this.f2510c390 = java.math.Bigint.valueOf(1L);
        this.ffe4c0f30 = null;
    }

    public p835df581(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.f4efa264f = pa827ecfaVar;
        this.fdfcf28d0 = p53a5793fVar.normalize();
        this.f7b8b965a = bigint;
        this.f2510c390 = bigint2;
        this.ffe4c0f30 = null;
    }

    public p835df581(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        this.f4efa264f = pa827ecfaVar;
        this.fdfcf28d0 = p53a5793fVar.normalize();
        this.f7b8b965a = bigint;
        this.f2510c390 = bigint2;
        this.ffe4c0f30 = bArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((27 + 13) % 13 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581)) {
            return false;
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj;
        return getCurve().Equals(p835df581Var.getCurve()) && getG().Equals(p835df581Var.getG());
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa GetCurve() {
        return this.f4efa264f;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetG() {
        return this.fdfcf28d0;
    }

    public java.math.Bigint GetH() {
        return this.f2510c390;
    }

    public java.math.Bigint GetN() {
        return this.f7b8b965a;
    }

    public byte[] GetSeed() {
        return this.ffe4c0f30;
    }

    public int HashCode() {
        return getG().GetHashCode() ^ getCurve().GetHashCode();
    }
}

