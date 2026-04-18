namespace WillowMaze.Wasm.Decompiled;


public class p86e5591f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private int f058586c5;
    private byte[] f2aaf97ef;
    private int f2bf69314;
    private int f5c0f7bb2;
    private byte[] f6f0e7e13;
    private int f81a388c8;
    private byte[] f9d5cc3ea;
    private byte[] fb97d5966;
    private byte[] fcb584e44;
    private int ff5d56b05;

    private p86e5591f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((4 + 10) % 10 > 0) {
        }
        this.fcb584e44 = dtPWggUzLSyVehCG(dKJhpGePdZgnKDwD(EunbqQbtBtOolSRj(p80f8c729Var, 0)));
        if (WqrYULPlmwzzkEHC(p80f8c729Var) != 2) {
            this.f058586c5 = 12;
        } else {
            this.f058586c5 = nxKWezhKjOrpmxeH(ivvjqvXocOVrULJU(qbteTuHysiJnDDXe(IxvsBqOLEaaLtMir(p80f8c729Var, 1))));
        }
    }

    public p86e5591f(byte[] bArr, int i) {
        this.fcb584e44 = YaKmSYDexjjKbfMp(bArr);
        this.f058586c5 = i;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 EunbqQbtBtOolSRj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void IcrWDAkPBUJpfcIK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void IqzVTGvxPlRUcoyY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IxvsBqOLEaaLtMir(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int WqrYULPlmwzzkEHC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static byte[] YaKmSYDexjjKbfMp(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 DKJhpGePdZgnKDwD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static byte[] DtPWggUzLSyVehCG(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] GOIloNrpZeVZcSAM(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.math.Bigint IvvjqvXocOVrULJU(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p86e5591f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p86e5591f) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p86e5591f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p86e5591f(uhqjACfjRowsqzzs(obj));
    }

    public static int NxKWezhKjOrpmxeH(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d QbteTuHysiJnDDXe(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 UhqjACfjRowsqzzs(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public int GetIcvLen() {
        return this.f058586c5;
    }

    public byte[] GetNonce() {
        return gOIloNrpZeVZcSAM(this.fcb584e44);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 2) % 2 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        IcrWDAkPBUJpfcIK(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p6f0e511c(this.fcb584e44));
        if (this.f058586c5 != 12) {
            IqzVTGvxPlRUcoyY(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pf391b73d(this.f058586c5));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

