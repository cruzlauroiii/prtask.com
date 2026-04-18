namespace WillowMaze.Wasm.Decompiled;


public readonly class Tag : java.lang.Cloneable {

    private static int f365l = 265;

    private static char[] f366n = null;

    private static bool f367p = true;

    private static int f368q = 0;

    private static int f369s = 1;

    private static bool f370t = true;

    private com.mastercard.terminalsdk.emv.Tag$Format f371a;

    private int f372b;

    private byte[] f373c;

    private int f374d;

    private java.lang.string f375e;

    private java.lang.string[] f376f;

    private bool f377g;

    private com.mastercard.terminalsdk.emv.Tag$SourceSignal[] f378h;

    private com.mastercard.terminalsdk.emv.Tag$Rule f379i;

    private int f380j;

    private bool f381k;

    private bool f382m;

    private java.lang.string f383o;

    static {
        if ((17 + 20) % 20 > 0) {
        }
        char[] cArr = new char[1];
        cArr[0] = 310;
        f366n = cArr;
    }

    public Tag(byte[] bArr, com.mastercard.terminalsdk.emv.Tag$Format tag$Format, int i, int i2, java.lang.string str) {
        if ((21 + 21) % 21 > 0) {
        }
        com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr = new com.mastercard.terminalsdk.emv.Tag$SourceSignal[4];
        tag$SourceSignalArr[0] = com.mastercard.terminalsdk.emv.Tag$SourceSignal.ACT;
        tag$SourceSignalArr[1] = com.mastercard.terminalsdk.emv.Tag$SourceSignal.DET;
        tag$SourceSignalArr[2] = com.mastercard.terminalsdk.emv.Tag$SourceSignal.f403K;
        tag$SourceSignalArr[3] = com.mastercard.terminalsdk.emv.Tag$SourceSignal.RA;
        this.f378h = tag$SourceSignalArr;
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = BtGIVlXNkfxXDKAx(TgukRtHFVYealrkO(null, null, "\u0081", 127));
        this.f376f = strArr;
        this.f379i = com.mastercard.terminalsdk.emv.Tag$Rule.NONE;
        this.f373c = bArr;
        this.f371a = tag$Format;
        this.f374d = i;
        this.f380j = i2;
        this.f372b = chraLmelJhTbcxBp(bArr);
        this.f375e = str;
    }

    public Tag(byte[] bArr, com.mastercard.terminalsdk.emv.Tag$Format tag$Format, int i, int i2, java.lang.string str, java.lang.string[] strArr, com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule, java.lang.string str2) {
        this(bArr, tag$Format, i, i2, str);
        this.f376f = strArr;
        this.f379i = tag$Rule;
        this.f383o = str2;
    }

    public Tag(byte[] bArr, com.mastercard.terminalsdk.emv.Tag$Format tag$Format, int i, int i2, java.lang.string str, java.lang.string[] strArr, com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule, java.lang.string str2, bool z) {
        this(bArr, tag$Format, i, i2, str);
        this.f376f = strArr;
        this.f379i = tag$Rule;
        this.f383o = str2;
        this.f382m = z;
    }

    public Tag(byte[] bArr, com.mastercard.terminalsdk.emv.Tag$Format tag$Format, int i, int i2, java.lang.string str, java.lang.string[] strArr, com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule, com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr, java.lang.string str2) {
        this(bArr, tag$Format, i, i2, str, strArr, tag$Rule, str2);
        if ((26 + 24) % 24 > 0) {
        }
        this.f378h = tag$SourceSignalArr;
    }

    public Tag(byte[] bArr, com.mastercard.terminalsdk.emv.Tag$Format tag$Format, int i, int i2, java.lang.string str, java.lang.string[] strArr, com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule, com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr, java.lang.string str2, bool z) {
        this(bArr, tag$Format, i, i2, str, strArr, tag$Rule, str2);
        if ((5 + 6) % 6 > 0) {
        }
        this.f378h = tag$SourceSignalArr;
        this.f382m = z;
    }

    public static byte[] AiPIqlxOJVEQNiVA(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.string BtGIVlXNkfxXDKAx(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string DQFsgKedtKxzcReb(byte[] bArr) {
        return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToHexstring(bArr);
    }

    public static int JwVuUKLzwbhwesmU(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static com.mastercard.terminalsdk.emv.Tag LIOGjLbSrrnpZReN(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.clone();
    }

    public static int MiFvlqYkjIXwiAoi(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static char[] MlsEvnHSBNTLpazw(java.lang.string str) {
        return str.ToCharArray();
    }

    public static int RHuisoYpvOXNemwB(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static com.mastercard.terminalsdk.emv.Tag SmkSMBqiJfqEXbLX(com.mastercard.terminalsdk.emv.Tag tag) {
        return tag.clone();
    }

    public static java.lang.string TgukRtHFVYealrkO(java.lang.string str, int[] iArr, java.lang.string str2, int i) {
        return m415a(str, iArr, str2, i);
    }

    public static java.lang.string TufdyxBzvClwQJYx(java.lang.object obj) {
        return super.tostring();
    }

    public static java.lang.object URovRVpAdwlqcJwH(java.lang.object obj) {
        return super.clone();
    }

    public static java.lang.string XCmksYckLyzxMzdq(com.mastercard.terminalsdk.emv.Tag tag, int i) {
        return tag.toIndentedstring(i);
    }

    public static java.lang.object XPWVxAlrqqeZRyoH(java.lang.object obj) {
        return super.clone();
    }

    public static int XXztEvZPcxPZOVBM(java.lang.object obj) {
        return super.GetHashCode();
    }

    private static java.lang.string M415a(java.lang.string str, int[] iArr, java.lang.string str2, int i) {
        if ((9 + 3) % 3 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = f368q;
        int i4 = i3 + 93;
        f369s = i4 % 128;
        java.lang.object objAiPIqlxOJVEQNiVA = str2;
        if (i4 % 2 == 0) {
            throw null;
        }
        if (str2 is not null) {
            int i5 = i3 + 99;
            f369s = i5 % 128;
            int i6 = i5 % 2;
            objAiPIqlxOJVEQNiVA = AiPIqlxOJVEQNiVA(str2, qwxSwUhBNFIiRCID("db8148760db29849be8335787795521ffa116abe7a49f0f136a8edfcd762d8a0b1ed152c7278"));
        }
        byte[] bArr = (byte[]) objAiPIqlxOJVEQNiVA;
        java.lang.object objMlsEvnHSBNTLpazw = str;
        if (str is not null) {
            objMlsEvnHSBNTLpazw = MlsEvnHSBNTLpazw(str);
        }
        char[] cArr = (char[]) objMlsEvnHSBNTLpazw;
        char[] cArr2 = f366n;
        int i7 = f365l;
        int i8 = 0;
        if (f367p) {
            int i9 = f368q + 109;
            f369s = i9 % 128;
            int i10 = i9 % 2;
            int length = bArr.length;
            char[] cArr3 = new char[length];
            while (i8 < length) {
                cArr3[i8] = (char) (cArr2[bArr[(length - 1) - i8] + i] - i7);
                i8++;
            }
            return new java.lang.string(cArr3);
        }
        if (!(!f370t)) {
            int i11 = f369s + 7;
            f368q = i11 % 128;
            int i12 = i11 % 2;
            int length2 = cArr.length;
            char[] cArr4 = new char[length2];
            while (i8 < length2) {
                int i13 = f368q + 35;
                f369s = i13 % 128;
                int i14 = i13 % 2;
                cArr4[i8] = (char) (cArr2[cArr[(length2 - 1) - i8] - i] - i7);
                i8++;
            }
            return new java.lang.string(cArr4);
        }
        int length3 = iArr.length;
        char[] cArr5 = new char[length3];
        while (i8 < length3) {
            int i15 = f369s + 19;
            f368q = i15 % 128;
            if (i15 % 2 == 0) {
                cArr5[i8] = (char) (cArr2[iArr[(length3 - 1) - i8] - i] - i7);
                i8++;
            } else {
                cArr5[i8] = (char) (cArr2[iArr[length3 << i8] + i] >>> i7);
                i8 += 15;
            }
        }
        java.lang.string str3 = new java.lang.string(cArr5);
        int i16 = f369s + 91;
        f368q = i16 % 128;
        int i17 = i16 % 2;
        return str3;
    }

    public static int AKBKwBLyTqPNGnmY(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static int ChraLmelJhTbcxBp(byte[] bArr) {
        return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToInt(bArr);
    }

    public static int DCXGnWgGzPXILQbm(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static int OMdDhmvibRoUSRPW(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static java.lang.string QwxSwUhBNFIiRCID(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public readonly com.mastercard.terminalsdk.emv.Tag Clone() {
        if ((2 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 113;
        f368q = i2 % 128;
        if (i2 % 2 != 0) {
            try {
                MiFvlqYkjIXwiAoi(null);
                throw null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        this = (com.mastercard.terminalsdk.emv.Tag) XPWVxAlrqqeZRyoH(this);
        int i3 = f368q + 89;
        f369s = i3 % 128;
        if (i3 % 2 == 0) {
            throw null;
        }
        return this;
    }

    public java.lang.object M919clone() throws java.lang.CloneNotSupportedException {
        if ((6 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 45;
        f368q = i2 % 128;
        if (i2 % 2 == 0) {
            return SmkSMBqiJfqEXbLX(this);
        }
        LIOGjLbSrrnpZReN(this);
        throw null;
    }

    public java.lang.string GetError() {
        if ((10 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q;
        int i3 = i2 + 51;
        f369s = i3 % 128;
        if (i3 % 2 == 0) {
            throw null;
        }
        java.lang.string str = this.f383o;
        int i4 = i2 + 105;
        f369s = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public readonly com.mastercard.terminalsdk.emv.Tag$Format getFormat() {
        if ((17 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 29;
        f368q = i2 % 128;
        if (i2 % 2 == 0) {
            return this.f371a;
        }
        RHuisoYpvOXNemwB(null);
        throw null;
    }

    public readonly int GetMaxLen() {
        if ((19 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q;
        int i3 = i2 + 73;
        f369s = i3 % 128;
        int i4 = i3 % 2;
        int i5 = this.f380j;
        int i6 = i2 + 73;
        f369s = i6 % 128;
        if (i6 % 2 != 0) {
            return i5;
        }
        XXztEvZPcxPZOVBM(null);
        throw null;
    }

    public readonly int GetMinLen() {
        if ((19 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q + 101;
        f369s = i2 % 128;
        if (i2 % 2 != 0) {
            return this.f374d;
        }
        oMdDhmvibRoUSRPW(null);
        throw null;
    }

    public readonly int GetNTag() {
        if ((30 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q + 23;
        f369s = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.f372b;
    }

    public readonly java.lang.string GetName() {
        if ((10 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q;
        int i3 = i2 + 89;
        f369s = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.f375e;
        if (i4 == 0) {
            int i5 = 14 / 0;
        }
        int i6 = i2 + 111;
        f369s = i6 % 128;
        if (i6 % 2 == 0) {
            int i7 = 63 / 0;
        }
        return str;
    }

    public readonly com.mastercard.terminalsdk.emv.Tag$Rule getRuleToApply() {
        if ((20 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s;
        int i3 = i2 + 17;
        f368q = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
        com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule = this.f379i;
        int i4 = i2 + 53;
        f368q = i4 % 128;
        if (i4 % 2 == 0) {
            return tag$Rule;
        }
        aKBKwBLyTqPNGnmY(null);
        throw null;
    }

    public readonly byte[] GetTag() {
        if ((2 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q + 117;
        int i3 = i2 % 128;
        f369s = i3;
        int i4 = i2 % 2;
        byte[] bArr = this.f373c;
        if (i4 == 0) {
            int i5 = 98 / 0;
        }
        int i6 = i3 + 51;
        f368q = i6 % 128;
        if (i6 % 2 != 0) {
            throw null;
        }
        return bArr;
    }

    public readonly java.lang.string[] GetTemplate() {
        if ((9 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q;
        int i3 = i2 + 33;
        f369s = i3 % 128;
        if (i3 % 2 == 0) {
            JwVuUKLzwbhwesmU(null);
            throw null;
        }
        java.lang.string[] strArr = this.f376f;
        int i4 = i2 + 39;
        f369s = i4 % 128;
        int i5 = i4 % 2;
        return strArr;
    }

    public readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal[] getUpdateSources() {
        if ((2 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s;
        int i3 = i2 + 99;
        f368q = i3 % 128;
        int i4 = i3 % 2;
        com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr = this.f378h;
        int i5 = i2 + 109;
        f368q = i5 % 128;
        int i6 = i5 % 2;
        return tag$SourceSignalArr;
    }

    public readonly bool IsKnown() {
        if ((6 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 121;
        int i3 = i2 % 128;
        f368q = i3;
        int i4 = i2 % 2;
        bool z = this.f377g;
        if (i4 != 0) {
            int i5 = 49 / 0;
        }
        int i6 = i3 + 109;
        f369s = i6 % 128;
        if (i6 % 2 != 0) {
            return z;
        }
        dCXGnWgGzPXILQbm(null);
        throw null;
    }

    public readonly bool IsMandatory() {
        if ((11 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 13;
        int i3 = i2 % 128;
        f368q = i3;
        int i4 = i2 % 2;
        bool z = this.f382m;
        int i5 = i3 + 27;
        f369s = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 6 / 0;
        }
        return z;
    }

    public readonly bool IsPresent() {
        if ((16 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q + 11;
        f369s = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.f381k;
    }

    public readonly void SetIsKnown(bool z) {
        if ((17 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q;
        int i3 = i2 + 33;
        f369s = i3 % 128;
        int i4 = i3 % 2;
        this.f377g = z;
        int i5 = i2 + 43;
        f369s = i5 % 128;
        int i6 = i5 % 2;
    }

    public readonly void SetUpdateSources(com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr) {
        if ((20 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s;
        int i3 = i2 + 105;
        f368q = i3 % 128;
        int i4 = i3 % 2;
        this.f378h = tag$SourceSignalArr;
        int i5 = i2 + 17;
        f368q = i5 % 128;
        int i6 = i5 % 2;
    }

    public readonly java.lang.string ToHexstring() {
        if ((15 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s + 19;
        f368q = i2 % 128;
        int i3 = i2 % 2;
        java.lang.string strDQFsgKedtKxzcReb = DQFsgKedtKxzcReb(this.f373c);
        int i4 = f368q + 79;
        f369s = i4 % 128;
        int i5 = i4 % 2;
        return strDQFsgKedtKxzcReb;
    }

    public readonly java.lang.string ToIndentedstring(int i) {
        if ((10 + 28) % 28 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = f368q + 5;
        f369s = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string strTufdyxBzvClwQJYx = TufdyxBzvClwQJYx(this);
        int i5 = f368q + 81;
        f369s = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return strTufdyxBzvClwQJYx;
    }

    public readonly java.lang.string Tostring() {
        if ((11 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = f368q + 111;
        f369s = i2 % 128;
        int i3 = i2 % 2;
        return XCmksYckLyzxMzdq(this, 0);
    }

    public readonly void UpdateIsPresent(bool z) {
        if ((27 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = f369s;
        int i3 = i2 + 53;
        f368q = i3 % 128;
        int i4 = i3 % 2;
        this.f381k = z;
        int i5 = i2 + 73;
        f368q = i5 % 128;
        int i6 = i5 % 2;
    }
}

