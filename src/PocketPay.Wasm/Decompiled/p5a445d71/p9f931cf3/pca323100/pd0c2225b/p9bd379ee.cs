namespace WillowMaze.Wasm.Decompiled;


public class p9bd379ee : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f00b4d81b;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f0e141da3;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f160cee34;
    private readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b f168ed410;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f363b122c;
    private readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b f432386f5;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f47e998f4;
    private readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b f5e8e202a;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f7694f4a6;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f807ca3dc;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f83878c91;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fb2f5ff47;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fb350b9ff;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fc54c5d4d;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fca269966;
    private readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b fd5492559;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fe76ce6c7;

    public p9bd379ee(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b p1dd1689bVar) {
        if (bigint is null) {
            throw new java.lang.IllegalArgumentException("'p' cannot be null");
        }
        if (bigint2 is null) {
            throw new java.lang.IllegalArgumentException("'g' cannot be null");
        }
        if (bigint3 is null) {
            throw new java.lang.IllegalArgumentException("'q' cannot be null");
        }
        this.f83878c91 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint);
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint2);
        this.f7694f4a6 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint3);
        this.f363b122c = bigint4 is null ? null : new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint4);
        this.f432386f5 = p1dd1689bVar;
    }

    private p9bd379ee(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((22 + 15) % 15 > 0) {
        }
        if (TGGMIrRrzPLcYLca(p80f8c729Var) < 3 || BcPTudUEDNRlDfKj(p80f8c729Var) > 5) {
            throw new java.lang.IllegalArgumentException(oFzygzCBTpkSkOwj(DDdovEVRhMoxeDfJ(new java.lang.stringBuilder("Bad sequence size: "), hJiUKXHhkoIeGFqF(p80f8c729Var))));
        }
        java.util.Enumeration enumerationPoFujNHFRWhVOedc = PoFujNHFRWhVOedc(p80f8c729Var);
        this.f83878c91 = qTbwzEHXvnOiCtGz(vHPoiLwkqrUDPfsJ(enumerationPoFujNHFRWhVOedc));
        this.fb2f5ff47 = IPDIqgATtTMIgzPC(DGgcZjGDDbZdeYlq(enumerationPoFujNHFRWhVOedc));
        this.f7694f4a6 = AHrDCwjGwuvoUGNI(xobdFmWadcLSmkge(enumerationPoFujNHFRWhVOedc));
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1VarMnVRTLyOnUSTFTZf = MnVRTLyOnUSTFTZf(enumerationPoFujNHFRWhVOedc);
        if (p0fd1bdf1VarMnVRTLyOnUSTFTZf is not null && (p0fd1bdf1VarMnVRTLyOnUSTFTZf is p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
            this.f363b122c = ISTxcDpXzIwDYZSE(p0fd1bdf1VarMnVRTLyOnUSTFTZf);
            p0fd1bdf1VarMnVRTLyOnUSTFTZf = bNhZiTNRfKRUftGi(enumerationPoFujNHFRWhVOedc);
        } else {
            this.f363b122c = null;
        }
        if (p0fd1bdf1VarMnVRTLyOnUSTFTZf is null) {
            this.f432386f5 = null;
        } else {
            this.f432386f5 = uHmMkzFZIxRxDPwm(kWIPlseYDHCpUCGH(p0fd1bdf1VarMnVRTLyOnUSTFTZf));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d AHrDCwjGwuvoUGNI(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static int BcPTudUEDNRlDfKj(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuilder DDdovEVRhMoxeDfJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object DGgcZjGDDbZdeYlq(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void DuxrVEGkRVRYUIdH(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 HbBYNMurSVLDlHjW(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d IPDIqgATtTMIgzPC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d ISTxcDpXzIwDYZSE(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 MnVRTLyOnUSTFTZf(java.util.Enumeration enumeration) {
        return m8aa07233(enumeration);
    }

    public static void OherzAIyyaAZRRnk(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration PoFujNHFRWhVOedc(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void QDXhwgXqLQPeiMUH(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee ROYMUytTfLVitwbz(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static int TGGMIrRrzPLcYLca(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.math.Bigint YYpuIBtAlphESvzr(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ZwIHjmyavnBsUXUe(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static void AdMelMnnPrferaOe(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 BNhZiTNRfKRUftGi(java.util.Enumeration enumeration) {
        return m8aa07233(enumeration);
    }

    public static void EUZMvDwupYlusIEF(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object GcBVtZIPsbhYyYuu(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int HJiUKXHhkoIeGFqF(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static bool JOrfHesKCexazozA(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.math.Bigint JTEPtrzNzSxSeiGt(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KWIPlseYDHCpUCGH(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    private static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 M8aa07233(java.util.Enumeration enumeration) {
        if (jOrfHesKCexazozA(enumeration)) {
            return (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) gcBVtZIPsbhYyYuu(enumeration);
        }
        return null;
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee(HbBYNMurSVLDlHjW(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return ROYMUytTfLVitwbz(ZwIHjmyavnBsUXUe(p582a4948Var, z));
    }

    public static java.math.Bigint NZJnSasEUaRSfupq(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static java.lang.string OFzygzCBTpkSkOwj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d QTbwzEHXvnOiCtGz(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static java.math.Bigint RjNufYqMKzWfLWvb(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b UHmMkzFZIxRxDPwm(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b.m8bab0102(obj);
    }

    public static java.lang.object VHPoiLwkqrUDPfsJ(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.object XobdFmWadcLSmkge(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public java.math.Bigint GetG() {
        return jTEPtrzNzSxSeiGt(this.fb2f5ff47);
    }

    public java.math.Bigint GetJ() {
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.f363b122c;
        if (pf391b73dVar is not null) {
            return YYpuIBtAlphESvzr(pf391b73dVar);
        }
        return null;
    }

    public java.math.Bigint GetP() {
        return rjNufYqMKzWfLWvb(this.f83878c91);
    }

    public java.math.Bigint GetQ() {
        return nZJnSasEUaRSfupq(this.f7694f4a6);
    }

    public p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b GetValidationParams() {
        return this.f432386f5;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((14 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(5);
        DuxrVEGkRVRYUIdH(pd6ccb7fcVar, this.f83878c91);
        OherzAIyyaAZRRnk(pd6ccb7fcVar, this.fb2f5ff47);
        QDXhwgXqLQPeiMUH(pd6ccb7fcVar, this.f7694f4a6);
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.f363b122c;
        if (pf391b73dVar is not null) {
            eUZMvDwupYlusIEF(pd6ccb7fcVar, pf391b73dVar);
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b p1dd1689bVar = this.f432386f5;
        if (p1dd1689bVar is not null) {
            adMelMnnPrferaOe(pd6ccb7fcVar, p1dd1689bVar);
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

