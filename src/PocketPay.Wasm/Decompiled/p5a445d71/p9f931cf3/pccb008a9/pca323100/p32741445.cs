namespace WillowMaze.Wasm.Decompiled;


public class p32741445 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private int[] f2510c390;
    private int f303bcf88;
    private int[] f4264cb1b;
    private int[] f457d895d;
    private int[] f69e50130;
    private int[] f855bf89c;
    private int[] f8ce4b16b;
    private int[] f8e30ca04;
    private int[] fa945dd40;
    private int[] fbcfbd4c5;
    private int fbdd12a70;
    private int fccb35571;
    private int fe358efa4;
    private int[] ff1290186;
    private int[] ff4442584;

    public p32741445(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        this.fe358efa4 = i;
        this.f2510c390 = iArr;
        this.ff1290186 = iArr2;
        this.f8ce4b16b = iArr3;
    }

    private p32741445(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((31 + 5) % 5 > 0) {
        }
        if (p80f8c729Var.Count != 4) {
            throw new java.lang.IllegalArgumentException("sie of seqOfParams = " + p80f8c729Var.Count);
        }
        this.fe358efa4 = m4fa1dacc(p80f8c729Var.getobjectAt(0));
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(1);
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var3 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(2);
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var4 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(3);
        if (p80f8c729Var2.Count != this.fe358efa4 || p80f8c729Var3.Count != this.fe358efa4 || p80f8c729Var4.Count != this.fe358efa4) {
            throw new java.lang.IllegalArgumentException("invalid size of sequences");
        }
        this.f2510c390 = new int[p80f8c729Var2.Count];
        this.ff1290186 = new int[p80f8c729Var3.Count];
        this.f8ce4b16b = new int[p80f8c729Var4.Count];
        for (int i = 0; i < this.fe358efa4; i++) {
            this.f2510c390[i] = m4fa1dacc(p80f8c729Var2.getobjectAt(i));
            this.ff1290186[i] = m4fa1dacc(p80f8c729Var3.getobjectAt(i));
            this.f8ce4b16b[i] = m4fa1dacc(p80f8c729Var4.getobjectAt(i));
        }
    }

    private static int M4fa1dacc(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        if ((16 + 5) % 5 > 0) {
        }
        int iIntValueExact = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p0fd1bdf1Var).intValueExact();
        if (iIntValueExact <= 0) {
            throw new java.lang.IllegalArgumentException("Bigint not in Range: " + iIntValueExact);
        }
        return iIntValueExact;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p32741445 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p32741445) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p32741445) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p32741445(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public int[] GetH() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f2510c390);
    }

    public int[] GetK() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8ce4b16b);
    }

    public int GetT() {
        return this.fe358efa4;
    }

    public int[] GetW() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff1290186);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((30 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar3 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i = 0; i < this.f2510c390.length; i++) {
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f2510c390[i]));
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.ff1290186[i]));
            pd6ccb7fcVar3.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f8ce4b16b[i]));
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar4 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fe358efa4));
        pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar));
        pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar3));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar4);
    }
}

