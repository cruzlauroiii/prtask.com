namespace WillowMaze.Wasm.Decompiled;


public class pdf525d32 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d f427d6faf;
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d f68ee5a8c;
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be fde8c9e67;
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d fe00db03a;
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d fe5736fbb;
    private readonly p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be fe6212cca;

    private pdf525d32(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((30 + 20) % 20 > 0) {
        }
        this.f68ee5a8c = xkLfisPzoducmzHd(JDQiSIPrkpEyvgXh(p80f8c729Var, 0));
        this.fde8c9e67 = bytDOzxQvAyNNvoZ(CHzAwkWcJSMPIVoU(QWhUTcinbMeEHNVO(p80f8c729Var, 1)), false);
    }

    public pdf525d32(p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d p2f4eb55dVar, p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be p4a5545beVar) {
        this.f68ee5a8c = p2f4eb55dVar;
        this.fde8c9e67 = p4a5545beVar;
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 CHzAwkWcJSMPIVoU(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 JDQiSIPrkpEyvgXh(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 QWhUTcinbMeEHNVO(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void UelShVNjGFZsQzuB(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void ZLscWkXqKRzOxTNo(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ZORzLfvreUHRbDKm(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be BytDOzxQvAyNNvoZ(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.pdf525d32 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pff670599.pdf525d32) {
            return (p5a445d71.p9f931cf3.pca323100.pff670599.pdf525d32) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pff670599.pdf525d32(ZORzLfvreUHRbDKm(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d XkLfisPzoducmzHd(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.pff670599.p2f4eb55d GetSessionEncryptedKey() {
        return this.f68ee5a8c;
    }

    public p5a445d71.p9f931cf3.pca323100.pff670599.p4a5545be GetTransportParameters() {
        return this.fde8c9e67;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        ZLscWkXqKRzOxTNo(pd6ccb7fcVar, this.f68ee5a8c);
        if (this.fde8c9e67 is not null) {
            UelShVNjGFZsQzuB(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fde8c9e67));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

