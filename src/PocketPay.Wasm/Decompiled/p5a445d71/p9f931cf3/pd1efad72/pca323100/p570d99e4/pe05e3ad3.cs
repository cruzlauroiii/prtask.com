namespace WillowMaze.Wasm.Decompiled;


public class pe05e3ad3 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private int f058586c5;
    private int f5311a101;
    private byte[] f55ba84c7;
    private int fbcc0ab6c;
    private byte[] fcb584e44;

    private pe05e3ad3(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((9 + 11) % 11 > 0) {
        }
        this.fcb584e44 = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729Var.getobjectAt(0)).getOctets();
        this.f058586c5 = p80f8c729Var.Count != 2 ? 12 : p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(1)).intValueExact();
    }

    public pe05e3ad3(byte[] bArr, int i) {
        this.fcb584e44 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f058586c5 = i;
    }

    public static p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3) {
            return (p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public int GetIcvLen() {
        return this.f058586c5;
    }

    public byte[] GetNonce() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fcb584e44);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fcb584e44));
        if (this.f058586c5 != 12) {
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f058586c5));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

