namespace WillowMaze.Wasm.Decompiled;


public class p9bd379ee : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b f130a70ab;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f1abe8d8b;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f28637873;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f35f3ea67;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f363b122c;
    private readonly p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b f38c0c2de;
    private readonly p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b f432386f5;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f4dc24124;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f5f83db07;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f73fcc1a7;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f7694f4a6;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f83878c91;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f8f238a59;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d fa6bb746d;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d fb2f5ff47;
    private readonly p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b fff40f1d1;

    public p9bd379ee(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b p1dd1689bVar) {
        if (bigint is null) {
            throw new java.lang.IllegalArgumentException("'p' cannot be null");
        }
        if (bigint2 is null) {
            throw new java.lang.IllegalArgumentException("'g' cannot be null");
        }
        if (bigint3 is null) {
            throw new java.lang.IllegalArgumentException("'q' cannot be null");
        }
        this.f83878c91 = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint);
        this.fb2f5ff47 = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint2);
        this.f7694f4a6 = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint3);
        if (bigint4 is null) {
            this.f363b122c = null;
        } else {
            this.f363b122c = new p5a445d71.p7c922baa.pca323100.pf391b73d(bigint4);
        }
        this.f432386f5 = p1dd1689bVar;
    }

    private p9bd379ee(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((10 + 28) % 28 > 0) {
        }
        if (kvMAOuwIhOjAPqrh(p80f8c729Var) < 3 || aoFvrYujJvQjSWCj(p80f8c729Var) > 5) {
            throw new java.lang.IllegalArgumentException(ymgmeJmtsOMtJPsM(nqbPThfdSJmjBTMu(new java.lang.stringBuilder("Bad sequence size: "), hsgiUYbUGIwTDXoi(p80f8c729Var))));
        }
        java.util.Enumeration enumerationVGyeuwkCBLiYmrLk = VGyeuwkCBLiYmrLk(p80f8c729Var);
        this.f83878c91 = AbWJPLHxhsxllKQJ(TVVuBkBMUrAIzMRZ(enumerationVGyeuwkCBLiYmrLk));
        this.fb2f5ff47 = IzyjJOsntGxLYSKo(gaHGttyHgVobzbFd(enumerationVGyeuwkCBLiYmrLk));
        this.f7694f4a6 = xDGpQIRUGcfUJFoA(kTBooUHDlTIxawMD(enumerationVGyeuwkCBLiYmrLk));
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1VarMwLSqDLHcGJbsdsO = mwLSqDLHcGJbsdsO(enumerationVGyeuwkCBLiYmrLk);
        if (p0fd1bdf1VarMwLSqDLHcGJbsdsO is not null && (p0fd1bdf1VarMwLSqDLHcGJbsdsO is p5a445d71.p7c922baa.pca323100.pf391b73d)) {
            this.f363b122c = ZITofeTTFeVSQAfl(p0fd1bdf1VarMwLSqDLHcGJbsdsO);
            p0fd1bdf1VarMwLSqDLHcGJbsdsO = tjJMXiKbYeSDdZNu(enumerationVGyeuwkCBLiYmrLk);
        } else {
            this.f363b122c = null;
        }
        if (p0fd1bdf1VarMwLSqDLHcGJbsdsO is null) {
            this.f432386f5 = null;
        } else {
            this.f432386f5 = GQAwrkGlDaRoccST(tYEebVzBMrYWJHmn(p0fd1bdf1VarMwLSqDLHcGJbsdsO));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d AbWJPLHxhsxllKQJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void AbWJPLHxhsxllKQJ(java.lang.object obj, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbWJPLHxhsxllKQJ(java.lang.object obj, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AbWJPLHxhsxllKQJ(java.lang.object obj, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint CZxsBFPSzkeGmwFt(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static void CZxsBFPSzkeGmwFt(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CZxsBFPSzkeGmwFt(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CZxsBFPSzkeGmwFt(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b GQAwrkGlDaRoccST(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b.m8bab0102(obj);
    }

    public static void GQAwrkGlDaRoccST(java.lang.object obj, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQAwrkGlDaRoccST(java.lang.object obj, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GQAwrkGlDaRoccST(java.lang.object obj, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint GcbCCpDhVQIBuoNK(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static void GcbCCpDhVQIBuoNK(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcbCCpDhVQIBuoNK(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcbCCpDhVQIBuoNK(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d IzyjJOsntGxLYSKo(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void IzyjJOsntGxLYSKo(java.lang.object obj, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzyjJOsntGxLYSKo(java.lang.object obj, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IzyjJOsntGxLYSKo(java.lang.object obj, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JpGCAxhYNozUXyGY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void JpGCAxhYNozUXyGY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JpGCAxhYNozUXyGY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JpGCAxhYNozUXyGY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 MNOMiTzwXdQZcbKJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static void MNOMiTzwXdQZcbKJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, byte b, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MNOMiTzwXdQZcbKJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MNOMiTzwXdQZcbKJ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 NKnzFltQkgUtRCSB(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void NKnzFltQkgUtRCSB(java.lang.object obj, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKnzFltQkgUtRCSB(java.lang.object obj, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NKnzFltQkgUtRCSB(java.lang.object obj, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TMiuGpeSsNMsUvQC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void TMiuGpeSsNMsUvQC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMiuGpeSsNMsUvQC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMiuGpeSsNMsUvQC(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TVVuBkBMUrAIzMRZ(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void TVVuBkBMUrAIzMRZ(java.util.Enumeration enumeration, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVVuBkBMUrAIzMRZ(java.util.Enumeration enumeration, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TVVuBkBMUrAIzMRZ(java.util.Enumeration enumeration, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEUJiceQJtVcdgqW(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void UEUJiceQJtVcdgqW(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEUJiceQJtVcdgqW(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UEUJiceQJtVcdgqW(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Enumeration VGyeuwkCBLiYmrLk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void VGyeuwkCBLiYmrLk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VGyeuwkCBLiYmrLk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGyeuwkCBLiYmrLk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WVwcCgOOGMFjxSKd(java.util.Enumeration enumeration, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVwcCgOOGMFjxSKd(java.util.Enumeration enumeration, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WVwcCgOOGMFjxSKd(java.util.Enumeration enumeration, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WVwcCgOOGMFjxSKd(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee WpvmQjGRthNOkmYH(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void WpvmQjGRthNOkmYH(java.lang.object obj, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WpvmQjGRthNOkmYH(java.lang.object obj, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpvmQjGRthNOkmYH(java.lang.object obj, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YmfTYEQPDnwUpGRy(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void YmfTYEQPDnwUpGRy(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmfTYEQPDnwUpGRy(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmfTYEQPDnwUpGRy(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d ZITofeTTFeVSQAfl(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void ZITofeTTFeVSQAfl(java.lang.object obj, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZITofeTTFeVSQAfl(java.lang.object obj, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZITofeTTFeVSQAfl(java.lang.object obj, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AYZmgBqbjXLXOkFB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void AYZmgBqbjXLXOkFB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYZmgBqbjXLXOkFB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYZmgBqbjXLXOkFB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AoFvrYujJvQjSWCj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void AoFvrYujJvQjSWCj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoFvrYujJvQjSWCj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AoFvrYujJvQjSWCj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GaHGttyHgVobzbFd(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void GaHGttyHgVobzbFd(java.util.Enumeration enumeration, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GaHGttyHgVobzbFd(java.util.Enumeration enumeration, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GaHGttyHgVobzbFd(java.util.Enumeration enumeration, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HsgiUYbUGIwTDXoi(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void HsgiUYbUGIwTDXoi(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HsgiUYbUGIwTDXoi(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HsgiUYbUGIwTDXoi(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KTBooUHDlTIxawMD(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void KTBooUHDlTIxawMD(java.util.Enumeration enumeration, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTBooUHDlTIxawMD(java.util.Enumeration enumeration, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KTBooUHDlTIxawMD(java.util.Enumeration enumeration, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KvMAOuwIhOjAPqrh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void KvMAOuwIhOjAPqrh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvMAOuwIhOjAPqrh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvMAOuwIhOjAPqrh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 M8aa07233(java.util.Enumeration enumeration) {
        if (WVwcCgOOGMFjxSKd(enumeration)) {
            return (p5a445d71.p7c922baa.pca323100.p0fd1bdf1) tGUJYEHGRPYMRvdr(enumeration);
        }
        return null;
    }

    private static void M8aa07233(java.util.Enumeration enumeration, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private static void M8aa07233(java.util.Enumeration enumeration, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void M8aa07233(java.util.Enumeration enumeration, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee) {
            return (p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee(NKnzFltQkgUtRCSB(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pd0c2225b.p9bd379ee M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return WpvmQjGRthNOkmYH(MNOMiTzwXdQZcbKJ(p582a4948Var, z));
    }

    public static void M8bab0102(java.lang.object obj, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(java.lang.object obj, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, float f, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, short s, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MwLSqDLHcGJbsdsO(java.util.Enumeration enumeration) {
        return m8aa07233(enumeration);
    }

    public static void MwLSqDLHcGJbsdsO(java.util.Enumeration enumeration, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MwLSqDLHcGJbsdsO(java.util.Enumeration enumeration, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MwLSqDLHcGJbsdsO(java.util.Enumeration enumeration, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NqbPThfdSJmjBTMu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NqbPThfdSJmjBTMu(java.lang.stringBuilder sb, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NqbPThfdSJmjBTMu(java.lang.stringBuilder sb, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NqbPThfdSJmjBTMu(java.lang.stringBuilder sb, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TGUJYEHGRPYMRvdr(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void TGUJYEHGRPYMRvdr(java.util.Enumeration enumeration, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TGUJYEHGRPYMRvdr(java.util.Enumeration enumeration, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TGUJYEHGRPYMRvdr(java.util.Enumeration enumeration, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TYEebVzBMrYWJHmn(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void TYEebVzBMrYWJHmn(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYEebVzBMrYWJHmn(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYEebVzBMrYWJHmn(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 TjJMXiKbYeSDdZNu(java.util.Enumeration enumeration) {
        return m8aa07233(enumeration);
    }

    public static void TjJMXiKbYeSDdZNu(java.util.Enumeration enumeration, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjJMXiKbYeSDdZNu(java.util.Enumeration enumeration, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TjJMXiKbYeSDdZNu(java.util.Enumeration enumeration, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint TsEwzrScmTFFczyv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static void TsEwzrScmTFFczyv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TsEwzrScmTFFczyv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TsEwzrScmTFFczyv(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d XDGpQIRUGcfUJFoA(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void XDGpQIRUGcfUJFoA(java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XDGpQIRUGcfUJFoA(java.lang.object obj, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XDGpQIRUGcfUJFoA(java.lang.object obj, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint YLXzJAVORADePJcG(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static void YLXzJAVORADePJcG(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YLXzJAVORADePJcG(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YLXzJAVORADePJcG(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YmgmeJmtsOMtJPsM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YmgmeJmtsOMtJPsM(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmgmeJmtsOMtJPsM(java.lang.stringBuilder sb, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YmgmeJmtsOMtJPsM(java.lang.stringBuilder sb, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public java.math.Bigint GetG() {
        return yLXzJAVORADePJcG(this.fb2f5ff47);
    }

    public java.math.Bigint GetJ() {
        p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar = this.f363b122c;
        if (pf391b73dVar is not null) {
            return tsEwzrScmTFFczyv(pf391b73dVar);
        }
        return null;
    }

    public java.math.Bigint GetP() {
        return GcbCCpDhVQIBuoNK(this.f83878c91);
    }

    public java.math.Bigint GetQ() {
        return CZxsBFPSzkeGmwFt(this.f7694f4a6);
    }

    public p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b GetValidationParams() {
        return this.f432386f5;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((28 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        TMiuGpeSsNMsUvQC(pd6ccb7fcVar, this.f83878c91);
        JpGCAxhYNozUXyGY(pd6ccb7fcVar, this.fb2f5ff47);
        UEUJiceQJtVcdgqW(pd6ccb7fcVar, this.f7694f4a6);
        p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar = this.f363b122c;
        if (pf391b73dVar is not null) {
            aYZmgBqbjXLXOkFB(pd6ccb7fcVar, pf391b73dVar);
        }
        p5a445d71.p7c922baa.pca323100.pd0c2225b.p1dd1689b p1dd1689bVar = this.f432386f5;
        if (p1dd1689bVar is not null) {
            YmfTYEQPDnwUpGRy(pd6ccb7fcVar, p1dd1689bVar);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

