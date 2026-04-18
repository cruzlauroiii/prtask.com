namespace WillowMaze.Wasm.Decompiled;


public class pf391b73d : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    private readonly byte[] f172aafd6;
    private readonly byte[] f3f405783;
    private readonly byte[] f4b3a6218;
    private readonly byte[] fc0682fd5;

    public pf391b73d(long j) {
        this.f4b3a6218 = hUtujcKNtvlTfFqR(aDRkCATuFejabFdx(j));
    }

    public pf391b73d(java.math.Bigint bigint) {
        this.f4b3a6218 = UMuctzOqAgMcjCkA(bigint);
    }

    public pf391b73d(byte[] bArr) {
        this(bArr, true);
    }

    pf391b73d(byte[] bArr, bool z) {
        if (!quPwtulGdPEHmNWm("org.spongycastle.asn1.allow_unsafe_integer") && EBZFidGeyjyPMnTd(bArr)) {
            throw new java.lang.IllegalArgumentException("malformed integer");
        }
        this.f4b3a6218 = z ? GVEOYHjvVbzvaflt(bArr) : bArr;
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 DRfNMqNcjtJGdILy(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static bool EBZFidGeyjyPMnTd(byte[] bArr) {
        return m7b2c531a(bArr);
    }

    public static void FdoNRoPvVcmlbYck(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static java.lang.stringBuilder GHTjbKstVFwgcWfQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] GVEOYHjvVbzvaflt(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int JBkNCNeUdeYvGnQx(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static byte[] NAEkvNkfrLbtlwOO(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.Class PmGBgilPpinlYXxA(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 QMwgUeQaTsVZZDvH(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d ULzvkBmsGtCsLEsm(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static byte[] UMuctzOqAgMcjCkA(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static bool YVFHeqRHBbehtRlH(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.math.Bigint ADRkCATuFejabFdx(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.lang.string GUgikSimeVPqEtfJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] HUtujcKNtvlTfFqR(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static java.lang.string KMypVLhvRhZZfviW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static bool M7b2c531a(byte[] bArr) {
        if ((7 + 28) % 28 > 0) {
        }
        if (bArr.length > 1) {
            byte b = bArr[0];
            if (b == 0 && (bArr[1] & 128) == 0) {
                return true;
            }
            if (b == -1 && (bArr[1] & 128) != 0) {
                return true;
            }
        }
        return false;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d M8bab0102(java.lang.object obj) {
        if ((23 + 2) % 2 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pf391b73d)) {
            return (p5a445d71.p7c922baa.pca323100.pf391b73d) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(kMypVLhvRhZZfviW(sqbKkcsuwoMGaYBK(new java.lang.stringBuilder("illegal object in getInstance: "), vzOjKKpAHmIBYPoU(PmGBgilPpinlYXxA(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.pf391b73d) oBnSCgWmzZoiyAxx((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(gUgikSimeVPqEtfJ(GHTjbKstVFwgcWfQ(new java.lang.stringBuilder("encoding error in getInstance: "), rUKeuHsDLfRIVcOK(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarQMwgUeQaTsVZZDvH = QMwgUeQaTsVZZDvH(p582a4948Var);
        return (z || (p301c7ed4VarQMwgUeQaTsVZZDvH is p5a445d71.p7c922baa.pca323100.pf391b73d)) ? ULzvkBmsGtCsLEsm(p301c7ed4VarQMwgUeQaTsVZZDvH) : new p5a445d71.p7c922baa.pca323100.pf391b73d(NAEkvNkfrLbtlwOO(DRfNMqNcjtJGdILy(vjZWfhJyonWitQBl(p582a4948Var))));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OBnSCgWmzZoiyAxx(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static bool QuPwtulGdPEHmNWm(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.mf2b2f421(str);
    }

    public static java.lang.string RUKeuHsDLfRIVcOK(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string ShUJgVVdNnVxiSdG(java.math.Bigint bigint) {
        return bigint.tostring();
    }

    public static java.lang.stringBuilder SqbKkcsuwoMGaYBK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VjZWfhJyonWitQBl(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string VzOjKKpAHmIBYPoU(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.math.Bigint XlmACYLQcLSzWmnc(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.pf391b73d)) {
            return false;
        }
        return YVFHeqRHBbehtRlH(this.f4b3a6218, ((p5a445d71.p7c922baa.pca323100.pf391b73d) p301c7ed4Var).f4b3a6218);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        FdoNRoPvVcmlbYck(p8bf0ff80Var, 2, this.f4b3a6218);
    }

    int encodedLength() {
        return JBkNCNeUdeYvGnQx(this.f4b3a6218.length) + 1 + this.f4b3a6218.length;
    }

    public override java.math.Bigint GetPositiveValue() {
        if ((11 + 3) % 3 > 0) {
        }
        return new java.math.Bigint(1, this.f4b3a6218);
    }

    public java.math.Bigint GetValue() {
        return new java.math.Bigint(this.f4b3a6218);
    }

    public override int HashCode() {
        if ((29 + 21) % 21 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr = this.f4b3a6218;
            if (i == bArr.length) {
                return i2;
            }
            i2 ^= (bArr[i] & 255) << (i % 4);
            i++;
        }
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return shUJgVVdNnVxiSdG(xlmACYLQcLSzWmnc(this));
    }
}

