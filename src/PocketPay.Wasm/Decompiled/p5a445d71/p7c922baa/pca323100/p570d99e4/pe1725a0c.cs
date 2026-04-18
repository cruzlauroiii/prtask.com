namespace WillowMaze.Wasm.Decompiled;


public class pe1725a0c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] f155e7815;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] f3a0ce9f4;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] fc187249d;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] fcdd9c0dc;

    public pe1725a0c(p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7 pcf66a5b7Var) {
        p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] pcf66a5b7VarArr = new p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[1];
        this.f3a0ce9f4 = pcf66a5b7VarArr;
        pcf66a5b7VarArr[0] = pcf66a5b7Var;
    }

    private pe1725a0c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((3 + 15) % 15 > 0) {
        }
        this.f3a0ce9f4 = new p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[sprmxHTBRkyxufMQ(p80f8c729Var)];
        java.util.Enumeration enumerationBlsSJPaiVtkbkVAs = blsSJPaiVtkbkVAs(p80f8c729Var);
        int i = 0;
        while (pNVzOTALtbKcchKt(enumerationBlsSJPaiVtkbkVAs)) {
            int i2 = i + 1;
            this.f3a0ce9f4[i] = eZTWYqKOxLdvqkqI(hrIoZvyPAaPHOyNV(enumerationBlsSJPaiVtkbkVAs));
            i = i2;
        }
    }

    public pe1725a0c(p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] pcf66a5b7VarArr) {
        this.f3a0ce9f4 = pcf66a5b7VarArr;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VrdviSOJFzQAALza(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static void ZFKmEgcpRxsiWfPs(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration BlsSJPaiVtkbkVAs(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7 EZTWYqKOxLdvqkqI(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7.m8bab0102(obj);
    }

    public static java.lang.object HrIoZvyPAaPHOyNV(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c IEwQIsciYDuaUeKO(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c(xiDfaPRpjXopeOkr(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pe1725a0c M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return iEwQIsciYDuaUeKO(VrdviSOJFzQAALza(p582a4948Var, z));
    }

    public static bool PNVzOTALtbKcchKt(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int SprmxHTBRkyxufMQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 XiDfaPRpjXopeOkr(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((32 + 29) % 29 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        int i = 0;
        while (true) {
            p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] pcf66a5b7VarArr = this.f3a0ce9f4;
            if (i == pcf66a5b7VarArr.length) {
                return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
            }
            ZFKmEgcpRxsiWfPs(pd6ccb7fcVar, pcf66a5b7VarArr[i]);
            i++;
        }
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7[] ToTimeStampAndCRLArray() {
        return this.f3a0ce9f4;
    }
}

