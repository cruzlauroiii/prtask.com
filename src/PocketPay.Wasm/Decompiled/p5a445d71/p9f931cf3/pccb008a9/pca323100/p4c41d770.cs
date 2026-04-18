namespace WillowMaze.Wasm.Decompiled;


public class p4c41d770 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly byte[] f4461675a;
    private readonly byte[] f4decb11c;
    private readonly byte[] f529a2433;
    private readonly byte[] f63a9f0ea;
    private readonly byte[] ff9602895;

    private p4c41d770(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((21 + 14) % 14 > 0) {
        }
        if (!p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0)).hasValue(0)) {
            throw new java.lang.IllegalArgumentException("unknown version of sequence");
        }
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729Var.getobjectAt(1)).getOctets());
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729Var.getobjectAt(2)).getOctets());
    }

    public p4c41d770(byte[] bArr, byte[] bArr2) {
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p4c41d770 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p4c41d770) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p4c41d770) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p4c41d770(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public byte[] GetPublicSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f529a2433);
    }

    public byte[] GetRoot() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f63a9f0ea);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f529a2433));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f63a9f0ea));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

