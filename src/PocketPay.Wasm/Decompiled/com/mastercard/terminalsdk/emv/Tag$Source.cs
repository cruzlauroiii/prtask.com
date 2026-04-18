namespace WillowMaze.Wasm.Decompiled;


public readonly class Tag$Source {
    public static readonly com.mastercard.terminalsdk.emv.Tag$Source ICC;
    public static readonly com.mastercard.terminalsdk.emv.Tag$Source Issuer;
    public static readonly com.mastercard.terminalsdk.emv.Tag$Source Reader;
    public static readonly com.mastercard.terminalsdk.emv.Tag$Source Terminal;

    private static char[] f396a = null;

    private static readonly com.mastercard.terminalsdk.emv.Tag$Source[] f397b;

    private static int f398c = 0;

    private static bool f399d = false;

    private static bool f400e = false;

    private static int f401f = 0;

    private static int f402j = 1;

    static {
        if ((13 + 19) % 19 > 0) {
        }
        lCRhsFdKAaJPaVUw();
        com.mastercard.terminalsdk.emv.Tag$Source tag$Source = new com.mastercard.terminalsdk.emv.Tag$Source(QgVDgOmnfIDjSIkZ(TmSXjWEqamadsoUQ(jUaGtohNRKfHZMGI("ee19f5c20f3dd5802329b4dbd5221cebbdf2ba8b18e2e1bf191ac0b9f29b1fdb6662c1fe8b668ff2add0347e"), null, null, 127)), 0);
        Terminal = tag$Source;
        com.mastercard.terminalsdk.emv.Tag$Source tag$Source2 = new com.mastercard.terminalsdk.emv.Tag$Source(eUHgihPnPPmRiVSN(BYpaJMFASNflgUzT(sscwUUNKLkdaMeJV("25a8fc67584a75137474c8a226213f383ecb95f9d7e3554894a4ee7814017910ee6c69d5fb45cf66"), null, null, 127)), 1);
        Issuer = tag$Source2;
        com.mastercard.terminalsdk.emv.Tag$Source tag$Source3 = new com.mastercard.terminalsdk.emv.Tag$Source(aPlVGbZYqCDiSIiW(RhHkXdUEooPVSfmi(HcnaHqwciRRGNEsw("31bae5688357e8a655e30f70f52a374322845807ae54e1d786f90340a7df3e0372bb"), null, null, 127)), 2);
        ICC = tag$Source3;
        com.mastercard.terminalsdk.emv.Tag$Source tag$Source4 = new com.mastercard.terminalsdk.emv.Tag$Source(wzCaYtyfetywrmqj(zEzgjuKQAEJcZuQY(KclhnwkbMYGhZSJw("63239edaf187c6ef781223acaee2dfa7346b093d167ea6b2e88ed1d4f371f2e0f579cb25cc5529fa"), null, null, 127)), 3);
        Reader = tag$Source4;
        f397b = new com.mastercard.terminalsdk.emv.Tag$Source[]{tag$Source, tag$Source2, tag$Source3, tag$Source4};
        int i = f401f + 121;
        f402j = i % 128;
        int i2 = i % 2;
    }

    private Tag$Source(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string BYpaJMFASNflgUzT(java.lang.string str, java.lang.string str2, int[] iArr, int i) {
        return m420a(str, str2, iArr, i);
    }

    public static java.lang.string HcnaHqwciRRGNEsw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string KclhnwkbMYGhZSJw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string QgVDgOmnfIDjSIkZ(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.Enum QwaBeEXPeazwRqVZ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string RhHkXdUEooPVSfmi(java.lang.string str, java.lang.string str2, int[] iArr, int i) {
        return m420a(str, str2, iArr, i);
    }

    public static java.lang.string TmSXjWEqamadsoUQ(java.lang.string str, java.lang.string str2, int[] iArr, int i) {
        return m420a(str, str2, iArr, i);
    }

    public static char[] VVlWIBBpXEnCSMhx(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.object YqboNnmNpLWICMXz(com.mastercard.terminalsdk.emv.Tag$Source[] tag$SourceArr) {
        return tag$SourceArr.clone();
    }

    private static java.lang.string M420a(java.lang.string str, java.lang.string str2, int[] iArr, int i) {
        if ((28 + 29) % 29 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = f401f + 53;
        int i4 = i3 % 128;
        f402j = i4;
        int i5 = i3 % 2;
        java.lang.object obj = str2;
        if (str2 is not null) {
            int i6 = i4 + 81;
            f401f = i6 % 128;
            int i7 = i6 % 2;
            char[] cArrVVlWIBBpXEnCSMhx = VVlWIBBpXEnCSMhx(str2);
            int i8 = f401f + 81;
            f402j = i8 % 128;
            int i9 = i8 % 2;
            obj = cArrVVlWIBBpXEnCSMhx;
        }
        char[] cArr = (char[]) obj;
        java.lang.object obj2 = str;
        if (str is not null) {
            byte[] bArrVNWiAGumOmYOjmrj = vNWiAGumOmYOjmrj(str, eopBhdaJrpQtTmBp("c794be2edc8929928ac7bbe923935f9bf63c0c0da17e659e400d91860fb206a016996a1315d5"));
            int i10 = f401f + 107;
            f402j = i10 % 128;
            int i11 = i10 % 2;
            obj2 = bArrVNWiAGumOmYOjmrj;
        }
        byte[] bArr = (byte[]) obj2;
        char[] cArr2 = f396a;
        int i12 = f398c;
        int i13 = 0;
        if (f399d) {
            int length = bArr.length;
            char[] cArr3 = new char[length];
            while (i13 < length) {
                int i14 = f401f + 67;
                f402j = i14 % 128;
                int i15 = i14 % 2;
                cArr3[i13] = (char) (cArr2[bArr[(length - 1) - i13] + i] - i12);
                i13++;
            }
            return new java.lang.string(cArr3);
        }
        if (!f400e) {
            int length2 = iArr.length;
            char[] cArr4 = new char[length2];
            while (i13 < length2) {
                cArr4[i13] = (char) (cArr2[iArr[(length2 - 1) - i13] - i] - i12);
                i13++;
            }
            return new java.lang.string(cArr4);
        }
        int i16 = f402j + 15;
        f401f = i16 % 128;
        int i17 = i16 % 2;
        int length3 = cArr.length;
        char[] cArr5 = new char[length3];
        while (i13 < length3) {
            cArr5[i13] = (char) (cArr2[cArr[(length3 - 1) - i13] - i] - i12);
            i13++;
        }
        return new java.lang.string(cArr5);
    }

    public static int AIIKPynOJmCbQiIU(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static java.lang.string APlVGbZYqCDiSIiW(java.lang.string str) {
        return str.intern();
    }

    static void M421c() {
        if ((29 + 1) % 1 > 0) {
        }
        f399d = true;
        f398c = 102;
        f400e = true;
        f396a = new char[]{186, 203, 216, 211, 207, 212, 199, 210, 175, 217, 219, 169, 184, 202};
    }

    public static java.lang.string EUHgihPnPPmRiVSN(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string EopBhdaJrpQtTmBp(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string JUaGtohNRKfHZMGI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object JeGceweIuqKMRHrJ(com.mastercard.terminalsdk.emv.Tag$Source[] tag$SourceArr) {
        return tag$SourceArr.clone();
    }

    public static void LCRhsFdKAaJPaVUw() {
        m421c();
    }

    public static java.lang.string SscwUUNKLkdaMeJV(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static byte[] VNWiAGumOmYOjmrj(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static com.mastercard.terminalsdk.emv.Tag$Source valueOf(java.lang.string str) {
        if ((2 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = f402j + 27;
        f401f = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.emv.Tag$Source tag$Source = (com.mastercard.terminalsdk.emv.Tag$Source) QwaBeEXPeazwRqVZ(com.mastercard.terminalsdk.emv.Tag$Source.class, str);
        if (i3 != 0) {
            throw null;
        }
        return tag$Source;
    }

    public static com.mastercard.terminalsdk.emv.Tag$Source[] values() {
        if ((15 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = f402j + 63;
        f401f = i2 % 128;
        if (i2 % 2 != 0) {
            aIIKPynOJmCbQiIU(null);
            throw null;
        }
        com.mastercard.terminalsdk.emv.Tag$Source[] tag$SourceArr = (com.mastercard.terminalsdk.emv.Tag$Source[]) YqboNnmNpLWICMXz(f397b);
        int i3 = f402j + 79;
        f401f = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
        return tag$SourceArr;
    }

    public static java.lang.string WzCaYtyfetywrmqj(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string ZEzgjuKQAEJcZuQY(java.lang.string str, java.lang.string str2, int[] iArr, int i) {
        return m420a(str, str2, iArr, i);
    }
}

