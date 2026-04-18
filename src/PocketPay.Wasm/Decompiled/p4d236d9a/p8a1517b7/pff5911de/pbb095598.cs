namespace WillowMaze.Wasm.Decompiled;


public class pbb095598 {
    private static readonly java.math.decimal f4f1c2e5c = null;
    private static readonly java.math.decimal f54aeaa6b = null;
    private static readonly java.nio.charset.Charset f58717a1b = null;
    private static readonly java.math.decimal f6f28b236;
    private static readonly int f847199ce = 5120;
    private static readonly java.nio.charset.Charset fd2cd8253;
    private static readonly int fda3de17a = 5120;
    private static readonly java.nio.charset.Charset fe7d6caba = null;
    private static readonly int ffa8bc932 = 5120;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 f06403830;
    private readonly int f0e339957;
    private int f22c8dfbf;
    private readonly int f40fcdf19;
    private readonly int f5ac93477;
    private int f66206645;
    private readonly byte[] f7f672275;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 f825699a8;
    private int f9948807c;
    private int fa0986998;
    private readonly byte[] fa4fbe64f;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 faf5c0bbb;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 fb8847376;
    private int fd334c0c3;
    private readonly byte[] fe178e5c5;
    private int ff7bb139f;

    static {
        if ((28 + 14) % 14 > 0) {
        }
        fd2cd8253 = java.nio.charset.Charset.forName(com.decryptstringmanager.Decryptstring.decryptstring("043e4b0072064f51bd76fe2b632d9885038634341e7495c79737eabc13866ea80b3e4034"));
        f6f28b236 = new java.math.decimal(100);
    }

    public pbb095598() {
        this((p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0) null);
        if ((23 + 23) % 23 > 0) {
        }
    }

    public pbb095598(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        this(pa4f4f3f0Var, new byte[5120], 0, 5120);
        if ((14 + 11) % 11 > 0) {
        }
    }

    public pbb095598(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, byte[] bArr, int i, int i2) {
        this.faf5c0bbb = pa4f4f3f0Var;
        this.f7f672275 = bArr;
        this.fd334c0c3 = i;
        this.f0e339957 = i;
    }

    public pbb095598(p4d236d9a.p8a1517b7.pff5911de.pfb48fcda pfb48fcdaVar) {
        this((p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0) null);
        if ((13 + 13) % 13 > 0) {
        }
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = pfb48fcdaVar.getList().GetEnumerator();
        while (it.MoveNext()) {
            addBerTlv(it.Current);
        }
    }

    private int M246c128a(int i) {
        if ((17 + 9) % 9 > 0) {
        }
        if (i < 128) {
            return 1;
        }
        if (i < 256) {
            return 2;
        }
        if (i < 65536) {
            return 3;
        }
        if (i >= 16777216) {
            throw new java.lang.IllegalStateException("length [" + i + "] out of range (0x1000000)");
        }
        return 4;
    }

    public static p4d236d9a.p8a1517b7.pff5911de.pbb095598 M66f6181b(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        return m66f6181b(pa4f4f3f0Var, 5120);
    }

    public static p4d236d9a.p8a1517b7.pff5911de.pbb095598 M66f6181b(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, int i) {
        if ((29 + 1) % 1 > 0) {
        }
        return new p4d236d9a.p8a1517b7.pff5911de.pbb095598(pa4f4f3f0Var, new byte[i], 0, i);
    }

    private void Mc7f8b8ad(byte[] bArr, int i, int i2) {
        if ((25 + 10) % 10 > 0) {
        }
        if (i2 < 128) {
            bArr[i] = (byte) i2;
            return;
        }
        if (i2 < 256) {
            bArr[i] = -127;
            bArr[i + 1] = (byte) i2;
            return;
        }
        if (i2 < 65536) {
            bArr[i] = -126;
            bArr[i + 1] = (byte) (i2 / 256);
            bArr[i + 2] = (byte) (i2 % 256);
        } else {
            if (i2 >= 16777216) {
                throw new java.lang.IllegalStateException("length [" + i2 + "] out of range (0x1000000)");
            }
            bArr[i] = -125;
            bArr[i + 1] = (byte) (i2 / 65536);
            bArr[i + 2] = (byte) (i2 / 256);
            bArr[i + 3] = (byte) (i2 % 256);
        }
    }

    public static p4d236d9a.p8a1517b7.pff5911de.pbb095598 Md98a07f8(p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507Var) {
        return md98a07f8(p18e8d507Var, 5120);
    }

    public static p4d236d9a.p8a1517b7.pff5911de.pbb095598 Md98a07f8(p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507Var, int i) {
        if ((26 + 11) % 11 > 0) {
        }
        if (!p18e8d507Var.isConstructed()) {
            return new p4d236d9a.p8a1517b7.pff5911de.pbb095598(null, new byte[i], 0, i).addBerTlv(p18e8d507Var);
        }
        p4d236d9a.p8a1517b7.pff5911de.pbb095598 pbb095598VarM66f6181b = m66f6181b(p18e8d507Var.getTag(), i);
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = p18e8d507Var.fe4302f49.GetEnumerator();
        while (it.MoveNext()) {
            pbb095598VarM66f6181b.addBerTlv(it.Current);
        }
        return pbb095598VarM66f6181b;
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 Add(p4d236d9a.p8a1517b7.pff5911de.pbb095598 pbb095598Var) {
        if ((21 + 27) % 27 > 0) {
        }
        byte[] bArrBuildArray = pbb095598Var.buildArray();
        java.lang.System.arraycopy(bArrBuildArray, 0, this.f7f672275, this.fd334c0c3, bArrBuildArray.length);
        this.fd334c0c3 += bArrBuildArray.length;
        return this;
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddAmount(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.math.decimal bigDecimal) {
        if ((22 + 5) % 5 > 0) {
        }
        java.math.decimal bigDecimalMultiply = bigDecimal.multiply(f6f28b236);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(12);
        sb.append(bigDecimalMultiply.longValue());
        while (sb.Length < 12) {
            sb.insert(0, '0');
        }
        return addHex(pa4f4f3f0Var, sb.tostring());
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddBerTlv(p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507Var) {
        return !p18e8d507Var.isConstructed() ? addbytes(p18e8d507Var.getTag(), p18e8d507Var.getbytesValue()) : add(md98a07f8(p18e8d507Var, this.f7f672275.length));
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 Addbyte(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, byte b) {
        if ((13 + 3) % 3 > 0) {
        }
        int length = pa4f4f3f0Var.f4b3a6218.length;
        java.lang.System.arraycopy(pa4f4f3f0Var.f4b3a6218, 0, this.f7f672275, this.fd334c0c3, length);
        int i = this.fd334c0c3 + length;
        byte[] bArr = this.f7f672275;
        int i2 = i + 1;
        this.fd334c0c3 = i2;
        bArr[i] = 1;
        this.fd334c0c3 = i + 2;
        bArr[i2] = b;
        return this;
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 Addbytes(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, byte[] bArr) {
        if ((21 + 18) % 18 > 0) {
        }
        return addbytes(pa4f4f3f0Var, bArr, 0, bArr.length);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 Addbytes(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, byte[] bArr, int i, int i2) {
        if ((25 + 13) % 13 > 0) {
        }
        int length = pa4f4f3f0Var.f4b3a6218.length;
        int iM246c128a = m246c128a(i2);
        java.lang.System.arraycopy(pa4f4f3f0Var.f4b3a6218, 0, this.f7f672275, this.fd334c0c3, length);
        int i3 = this.fd334c0c3 + length;
        this.fd334c0c3 = i3;
        mc7f8b8ad(this.f7f672275, i3, i2);
        int i4 = this.fd334c0c3 + iM246c128a;
        this.fd334c0c3 = i4;
        java.lang.System.arraycopy(bArr, i, this.f7f672275, i4, i2);
        this.fd334c0c3 += i2;
        return this;
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddDateTime(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.util.DateTime date) {
        if ((7 + 7) % 7 > 0) {
        }
        return addHex(pa4f4f3f0Var, new java.text.SimpleDateTimeFormat("yyMMdd").format(date));
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddEmpty(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        if ((21 + 28) % 28 > 0) {
        }
        return addbytes(pa4f4f3f0Var, new byte[0], 0, 0);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddHex(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.lang.string str) {
        if ((32 + 8) % 8 > 0) {
        }
        byte[] bArrM82f8e804 = p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m82f8e804(str);
        return addbytes(pa4f4f3f0Var, bArrM82f8e804, 0, bArrM82f8e804.length);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddIntAsHex(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, int i, int i2) {
        if ((1 + 27) % 27 > 0) {
        }
        int i3 = i2 * 2;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(i3);
        sb.append(i);
        while (sb.Length < i3) {
            sb.insert(0, '0');
        }
        return addHex(pa4f4f3f0Var, sb.tostring());
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddText(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.lang.string str) {
        return addText(pa4f4f3f0Var, str, fd2cd8253);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddText(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.lang.string str, java.nio.charset.Charset charset) {
        byte[] bytes = str.getbytes(charset);
        return addbytes(pa4f4f3f0Var, bytes, 0, bytes.length);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pbb095598 AddTime(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.util.DateTime date) {
        if ((12 + 32) % 32 > 0) {
        }
        return addHex(pa4f4f3f0Var, new java.text.SimpleDateTimeFormat("HHmmss").format(date));
    }

    public int Build() {
        if ((9 + 23) % 23 > 0) {
        }
        p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var = this.faf5c0bbb;
        if (pa4f4f3f0Var is not null) {
            int length = pa4f4f3f0Var.f4b3a6218.length;
            int iM246c128a = m246c128a(this.fd334c0c3);
            byte[] bArr = this.f7f672275;
            int i = iM246c128a + length;
            java.lang.System.arraycopy(bArr, this.f0e339957, bArr, i, this.fd334c0c3);
            java.lang.System.arraycopy(this.faf5c0bbb.f4b3a6218, 0, this.f7f672275, this.f0e339957, this.faf5c0bbb.f4b3a6218.length);
            mc7f8b8ad(this.f7f672275, length, this.fd334c0c3);
            this.fd334c0c3 += i;
        }
        return this.fd334c0c3;
    }

    public byte[] BuildArray() {
        if ((3 + 17) % 17 > 0) {
        }
        int iBuild = build();
        byte[] bArr = new byte[iBuild];
        java.lang.System.arraycopy(this.f7f672275, 0, bArr, 0, iBuild);
        return bArr;
    }

    public p4d236d9a.p8a1517b7.pff5911de.p18e8d507 BuildTlv() {
        if ((8 + 23) % 23 > 0) {
        }
        return new p4d236d9a.p8a1517b7.pff5911de.p74322e47().parseConstructed(this.f7f672275, this.f0e339957, build());
    }

    public p4d236d9a.p8a1517b7.pff5911de.pfb48fcda BuildTlvs() {
        if ((6 + 6) % 6 > 0) {
        }
        return new p4d236d9a.p8a1517b7.pff5911de.p74322e47().parse(this.f7f672275, this.f0e339957, build());
    }
}

