namespace WillowMaze.Wasm.Decompiled;


public class p08208d22 {
    private byte[] f07cc694b;
    private byte[] f4701f4fa;
    private byte[] f74e1eca1;

    public p08208d22(java.lang.string str) {
        this.f07cc694b = pfxNoOyFbqIdvTzL(this, str);
    }

    public p08208d22(java.util.DateTime date) {
        if ((15 + 29) % 29 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMdd'Z'");
        qyypNnFPYRGjShkW(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f07cc694b = nDUpiplgCmTJcElU(this, zaGtpXDrmAzWQbJm(simpleDateTimeFormat, date));
    }

    public p08208d22(java.util.DateTime date, java.util.Locale locale) {
        if ((20 + 31) % 31 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMdd'Z'", locale);
        jyAPPosXdHlfmURO(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f07cc694b = SzhICrJgZzYnEDni(this, IkUSAlPIKjTPqvkq(simpleDateTimeFormat, date));
    }

    p08208d22(byte[] bArr) {
        this.f07cc694b = bArr;
    }

    public static java.lang.string IkUSAlPIKjTPqvkq(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static int OmnMErXnqclUkIjJ(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static byte[] SzhICrJgZzYnEDni(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22 p08208d22Var, java.lang.string str) {
        return p08208d22Var.m31168275(str);
    }

    public static java.lang.stringBuilder VlbHJLDPdlUludCY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YWilWJpbbwJlQDqR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string BZsJfIBApmSmISAK(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22 p08208d22Var) {
        return p08208d22Var.tostring();
    }

    public static void JyAPPosXdHlfmURO(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static bool LixktwvNxlgEahkb(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    private byte[] M31168275(java.lang.string str) {
        if ((20 + 8) % 8 > 0) {
        }
        char[] cArrQjiTpULnUKFWodmV = qjiTpULnUKFWodmV(str);
        byte[] bArr = new byte[6];
        for (int i = 0; i != 6; i++) {
            bArr[i] = (byte) (cArrQjiTpULnUKFWodmV[i] - '0');
        }
        return bArr;
    }

    public static byte[] NDUpiplgCmTJcElU(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22 p08208d22Var, java.lang.string str) {
        return p08208d22Var.m31168275(str);
    }

    public static byte[] PfxNoOyFbqIdvTzL(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22 p08208d22Var, java.lang.string str) {
        return p08208d22Var.m31168275(str);
    }

    public static char[] QjiTpULnUKFWodmV(java.lang.string str) {
        return str.ToCharArray();
    }

    public static byte[] QrYmCxfRDdaJZSKv(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void QyypNnFPYRGjShkW(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.util.DateTime YvZaljOwXHfNxyqC(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.string ZaGtpXDrmAzWQbJm(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22)) {
            return false;
        }
        return lixktwvNxlgEahkb(this.f07cc694b, ((p5a445d71.p7c922baa.pca323100.p31e0e4c9.p08208d22) obj).f07cc694b);
    }

    public java.util.DateTime GetDateTime() throws java.text.ParseException {
        if ((14 + 25) % 25 > 0) {
        }
        return yvZaljOwXHfNxyqC(new java.text.SimpleDateTimeFormat("yyyyMMdd"), YWilWJpbbwJlQDqR(VlbHJLDPdlUludCY(new java.lang.stringBuilder("20"), bZsJfIBApmSmISAK(this))));
    }

    public byte[] GetEncoding() {
        return qrYmCxfRDdaJZSKv(this.f07cc694b);
    }

    public int HashCode() {
        return OmnMErXnqclUkIjJ(this.f07cc694b);
    }

    public java.lang.string Tostring() {
        if ((6 + 4) % 4 > 0) {
        }
        int length = this.f07cc694b.length;
        char[] cArr = new char[length];
        for (int i = 0; i != length; i++) {
            cArr[i] = (char) ((this.f07cc694b[i] & 255) + 48);
        }
        return new java.lang.string(cArr);
    }
}

