namespace WillowMaze.Wasm.Decompiled;


public class p9ae0536a : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f1fe20011;
    p5a445d71.p7c922baa.pca323100.p11b04310 fe1710f3a;
    p5a445d71.p7c922baa.pca323100.p11b04310 ff0b53b2d;

    public p9ae0536a(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((5 + 28) % 28 > 0) {
        }
        if (QcUbXZZoldEGDokc(p80f8c729Var) != 1) {
            this.ff0b53b2d = null;
        } else {
            this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) ZHIVKBlXnFCyJNGM(p80f8c729Var, 0);
        }
    }

    public p9ae0536a(byte[] bArr) {
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    public static byte[] LuxaTrlbUmilBLqL(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int QcUbXZZoldEGDokc(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 UmFGxZOEwevzQwSP(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ZHIVKBlXnFCyJNGM(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] EbRgnADfDxsBAvfR(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void HigBJgJgXvZQjekC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pbc957e26.p9ae0536a M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pbc957e26.p9ae0536a) {
            return (p5a445d71.p7c922baa.pca323100.pbc957e26.p9ae0536a) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pbc957e26.p9ae0536a(UmFGxZOEwevzQwSP(obj));
    }

    public byte[] GetIV() {
        p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var = this.ff0b53b2d;
        if (p11b04310Var is null) {
            return null;
        }
        return LuxaTrlbUmilBLqL(ebRgnADfDxsBAvfR(p11b04310Var));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var = this.ff0b53b2d;
        if (p11b04310Var is not null) {
            higBJgJgXvZQjekC(pd6ccb7fcVar, p11b04310Var);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

