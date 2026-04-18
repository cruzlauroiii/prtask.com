namespace WillowMaze.Wasm.Decompiled;


public class pa1bc6907 : p5a445d71.p9f931cf3.pca323100.p11b04310 {
    private static readonly int f7e515155 = 1000;
    private static readonly int f82164aea = 1000;
    private static readonly int f84e42337 = 1000;
    private static readonly int ff724c197 = 1000;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310[] f500bd8b0;
    private readonly int f65f32385;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310[] f6a7f2458;
    private readonly int f7b6c8288;

    public pa1bc6907(byte[] bArr) {
        this(bArr, 1000);
    }

    public pa1bc6907(byte[] bArr, int i) {
        this(bArr, null, i);
    }

    private pa1bc6907(byte[] bArr, p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr, int i) {
        super(bArr);
        this.f6a7f2458 = p11b04310VarArr;
        this.f65f32385 = i;
    }

    public pa1bc6907(p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr) {
        this(p11b04310VarArr, 1000);
    }

    public pa1bc6907(p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr, int i) {
        this(PwHmpzFUHrSTioLI(p11b04310VarArr), p11b04310VarArr, i);
    }

    public static int BzRZGgbbxHmQlcpX(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var, bool z) {
        return p11b04310Var.encodedLength(z);
    }

    public static void MrvRlnBcWjapDjUx(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i) throws java.io.IOException {
        p8bf0ff80Var.writeIdentifier(z, i);
    }

    public static void NCQGtSdskEJtnLvJ(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static byte[] PwHmpzFUHrSTioLI(p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr) {
        return m5fcecd92(p11b04310VarArr);
    }

    public static int RrPlzdHXxvEuxlQf(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void TdwrSmntFilJrqNC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool YCxYDQMdnbfWJOwL(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return pa1bc6907Var.encodeConstructed();
    }

    public static void HChEmiqxSwKjOYuv(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static int HFTLdsuWIMEKsVID(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p6f0e511c.me64db885(z, i);
    }

    public static void HmNuptcOFuesfbku(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4[] p301c7ed4VarArr) throws java.io.IOException {
        p8bf0ff80Var.writePrimitives(p301c7ed4VarArr);
    }

    public static void IMhWdvaxMWpjctSr(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    static byte[] M5fcecd92(p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr) {
        if ((20 + 24) % 24 > 0) {
        }
        int length = p11b04310VarArr.length;
        if (length == 0) {
            return f24a67948;
        }
        if (length == 1) {
            return p11b04310VarArr[0].fb45cffe0;
        }
        int length2 = 0;
        for (p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var : p11b04310VarArr) {
            length2 += p11b04310Var.fb45cffe0.length;
        }
        byte[] bArr = new byte[length2];
        int length3 = 0;
        for (p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var2 : p11b04310VarArr) {
            byte[] bArr2 = p11b04310Var2.fb45cffe0;
            TdwrSmntFilJrqNC(bArr2, 0, bArr, length3, bArr2.length);
            length3 += bArr2.length;
        }
        return bArr;
    }

    static int Mf23e8626(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return pa1bc6907Var.f65f32385;
    }

    static p5a445d71.p9f931cf3.pca323100.p11b04310[] Mf8f67da7(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return pa1bc6907Var.f6a7f2458;
    }

    public static int QGUTyxGqXvPVqPjL(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p6f0e511c.me64db885(z, i);
    }

    public static bool QWbkUovRJmKijjkh(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return pa1bc6907Var.encodeConstructed();
    }

    public static void RGvUmtjjeyrmUopD(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static void YtOEiDalFbPvEIbu(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static int YxzFgtLwnsxscEuz(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p6f0e511c.me64db885(z, i);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        if ((19 + 7) % 7 > 0) {
        }
        if (!qWbkUovRJmKijjkh(this)) {
            NCQGtSdskEJtnLvJ(p8bf0ff80Var, z, this.fb45cffe0, 0, this.fb45cffe0.length);
            return;
        }
        MrvRlnBcWjapDjUx(p8bf0ff80Var, z, 36);
        ytOEiDalFbPvEIbu(p8bf0ff80Var, 128);
        p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr = this.f6a7f2458;
        if (p11b04310VarArr is null) {
            int i = 0;
            while (i < this.fb45cffe0.length) {
                int iRrPlzdHXxvEuxlQf = RrPlzdHXxvEuxlQf(this.fb45cffe0.length - i, this.f65f32385);
                rGvUmtjjeyrmUopD(p8bf0ff80Var, true, this.fb45cffe0, i, iRrPlzdHXxvEuxlQf);
                i += iRrPlzdHXxvEuxlQf;
            }
        } else {
            hmNuptcOFuesfbku(p8bf0ff80Var, p11b04310VarArr);
        }
        hChEmiqxSwKjOYuv(p8bf0ff80Var, 0);
        iMhWdvaxMWpjctSr(p8bf0ff80Var, 0);
    }

    bool encodeConstructed() {
        return this.f6a7f2458 is not null || this.fb45cffe0.length > this.f65f32385;
    }

    int encodedLength(bool z) throws java.io.IOException {
        if ((26 + 8) % 8 > 0) {
        }
        if (!YCxYDQMdnbfWJOwL(this)) {
            return yxzFgtLwnsxscEuz(z, this.fb45cffe0.length);
        }
        int iBzRZGgbbxHmQlcpX = !z ? 3 : 4;
        if (this.f6a7f2458 is null) {
            int length = this.fb45cffe0.length;
            int i = this.f65f32385;
            int i2 = length / i;
            int iHFTLdsuWIMEKsVID = iBzRZGgbbxHmQlcpX + (hFTLdsuWIMEKsVID(true, i) * i2);
            int length2 = this.fb45cffe0.length - (i2 * this.f65f32385);
            return length2 <= 0 ? iHFTLdsuWIMEKsVID : iHFTLdsuWIMEKsVID + qGUTyxGqXvPVqPjL(true, length2);
        }
        int i3 = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArr = this.f6a7f2458;
            if (i3 >= p11b04310VarArr.length) {
                return iBzRZGgbbxHmQlcpX;
            }
            iBzRZGgbbxHmQlcpX += BzRZGgbbxHmQlcpX(p11b04310VarArr[i3], true);
            i3++;
        }
    }

    public override java.util.Enumeration Getobjects() {
        return this.f6a7f2458 is not null ? new p5a445d71.p9f931cf3.pca323100.pa1bc6907$2(this) : new p5a445d71.p9f931cf3.pca323100.pa1bc6907$1(this);
    }
}

