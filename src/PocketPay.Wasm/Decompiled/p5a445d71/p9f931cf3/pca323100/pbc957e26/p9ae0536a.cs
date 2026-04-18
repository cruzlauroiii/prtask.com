namespace WillowMaze.Wasm.Decompiled;


public class p9ae0536a : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f27d810f9;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f8aa3a5b0;
    p5a445d71.p9f931cf3.pca323100.p11b04310 fdc2acd80;
    p5a445d71.p9f931cf3.pca323100.p11b04310 ff0b53b2d;

    private p9ae0536a(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((23 + 2) % 2 > 0) {
        }
        this.ff0b53b2d = poLxXckCYBhZLGaG(p80f8c729Var) != 1 ? null : (p5a445d71.p9f931cf3.pca323100.p11b04310) qwFsboUHvFCtIVuh(p80f8c729Var, 0);
    }

    public p9ae0536a(byte[] bArr) {
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }

    public static void MrFDulSzyabCMvcJ(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] UScXgyNRDDcNyOVC(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 XcKOwgKORDPKHdct(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static byte[] HUAzQTlQHcvtZcVa(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a) {
            return (p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a(XcKOwgKORDPKHdct(obj));
    }

    public static int PoLxXckCYBhZLGaG(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 QwFsboUHvFCtIVuh(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public byte[] GetIV() {
        p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var = this.ff0b53b2d;
        if (p11b04310Var is null) {
            return null;
        }
        return UScXgyNRDDcNyOVC(hUAzQTlQHcvtZcVa(p11b04310Var));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((16 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(1);
        p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var = this.ff0b53b2d;
        if (p11b04310Var is not null) {
            MrFDulSzyabCMvcJ(pd6ccb7fcVar, p11b04310Var);
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

