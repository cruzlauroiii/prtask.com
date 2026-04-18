namespace WillowMaze.Wasm.Decompiled;


public abstract class Tag$Rule {
    public static readonly com.mastercard.terminalsdk.emv.Tag$Rule MOD4;
    public static readonly com.mastercard.terminalsdk.emv.Tag$Rule NONE;
    public static readonly com.mastercard.terminalsdk.emv.Tag$Rule VAR_MIN;

    private static readonly com.mastercard.terminalsdk.emv.Tag$Rule[] f392b;

    private static int f393c = 0;

    private static int f394d = 1;

    private static char[] f395e;

    static {
        if ((30 + 29) % 29 > 0) {
        }
        vbpPdqsqyHhUTyMB();
        try {
            com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule = (com.mastercard.terminalsdk.emv.Tag$Rule) fleNFKDPILdBTMsu(HGFhocTGJitumBby((java.lang.Class) nwmYErOxQmPHkOpw(37, 37, (char) 25530), new java.lang.Class[]{java.lang.string.class, java.lang.int.TYPE}), new java.lang.object[]{XxWDkWMTyMuLPQRX(uQMLRxpFBQCPZNII(KdFyhYPZQznnjNrp("dd25c5a02e927ef2682a6f97c2be4a22659bfc04214805f8d03ccb5cc68a3cef"), new int[]{0, 4, 0, 0}, true)), ZytJIEsgxgpfWSzE(0)});
            NONE = tag$Rule;
            try {
                com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule2 = (com.mastercard.terminalsdk.emv.Tag$Rule) jydqzqxNwltXqJBP(sPBkWxrFMyyrRDBE((java.lang.Class) ZfvejYXuAolXKXSh(37, 74, (char) 0), new java.lang.Class[]{java.lang.string.class, java.lang.int.TYPE}), new java.lang.object[]{PFQECzxPfYlXdUTV(BJahfQNpLdcqeYTN(EhIxrFKOAYOHlTmw("ad162c88821f656ef1d254fbac3a5edc48272e97a5217254ecfd98db680013ac"), new int[]{4, 4, 0, 0}, true)), OcuPyfueBddbRIbf(1)});
                MOD4 = tag$Rule2;
                try {
                    com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule3 = (com.mastercard.terminalsdk.emv.Tag$Rule) IiTESoutdmFeONTZ(wAcOgnrPLRyLmoZT((java.lang.Class) EEGmeYpFeCYpBPYW(37, 111, (char) 1552), new java.lang.Class[]{java.lang.string.class, java.lang.int.TYPE}), new java.lang.object[]{CqHxcKQFtVsRqgmo(QKGfWvgFNOYxyRiK(UgakgiQHBdAqPQDy("0c643d5496b854fabbdb211aeae33095ad3de63880d95e5ce969757b036e86bf50167c"), new int[]{8, 7, 91, 6}, false)), wJESOTckxDHYlDlY(2)});
                    VAR_MIN = tag$Rule3;
                    f392b = new com.mastercard.terminalsdk.emv.Tag$Rule[]{tag$Rule, tag$Rule2, tag$Rule3};
                    int i = f393c + 23;
                    f394d = i % 128;
                    int i2 = i % 2;
                } catch (java.lang.Exception th) {
                    java.lang.Exception thJqRWnRdCHcdswLUt = JqRWnRdCHcdswLUt(th);
                    if (thJqRWnRdCHcdswLUt is not null) {
                        throw thJqRWnRdCHcdswLUt;
                    }
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                java.lang.Exception thXHLTKXIlkWJeeixU = XHLTKXIlkWJeeixU(th2);
                if (thXHLTKXIlkWJeeixU is not null) {
                    throw thXHLTKXIlkWJeeixU;
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            java.lang.Exception thYGBSKQIgGjkSsjqm = YGBSKQIgGjkSsjqm(th3);
            if (thYGBSKQIgGjkSsjqm is not null) {
                throw thYGBSKQIgGjkSsjqm;
            }
            throw th3;
        }
    }

    private Tag$Rule(java.lang.string str, int i) {
        super(str, i);
    }

    public Tag$Rule(java.lang.string str, int i, java.lang.object obj) {
        this(str, i);
    }

    public static java.lang.string BJahfQNpLdcqeYTN(java.lang.string str, int[] iArr, bool z) {
        return m418c(str, iArr, z);
    }

    public static java.lang.string CqHxcKQFtVsRqgmo(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.object EEGmeYpFeCYpBPYW(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static java.lang.string EhIxrFKOAYOHlTmw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void EwDBAlnpsVonleSF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GWIgWDwFKFEoYiGC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.reflect.Constructor HGFhocTGJitumBby(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static void IXnfQrfXjXpqaiDq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object IiTESoutdmFeONTZ(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.Exception JqRWnRdCHcdswLUt(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.string KdFyhYPZQznnjNrp(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static byte[] OQhmElMrFWoPcWPo(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.int OcuPyfueBddbRIbf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string PFQECzxPfYlXdUTV(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string QKGfWvgFNOYxyRiK(java.lang.string str, int[] iArr, bool z) {
        return m418c(str, iArr, z);
    }

    public static void RrhwLXCoJFQsZKul(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.Enum TKlRtdxRFMuZMCcq(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string UgakgiQHBdAqPQDy(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Exception XHLTKXIlkWJeeixU(java.lang.Exception th) {
        return th.getCause();
    }

    public static void XvVkiRnCuwCiQUde(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string XxWDkWMTyMuLPQRX(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.Exception YGBSKQIgGjkSsjqm(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.object ZfvejYXuAolXKXSh(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static java.lang.int ZytJIEsgxgpfWSzE(int i) {
        return java.lang.int.valueOf(i);
    }

    private static java.lang.string M418c(java.lang.string str, int[] iArr, bool z) {
        if ((27 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        java.lang.object objOQhmElMrFWoPcWPo = str;
        if (str is not null) {
            objOQhmElMrFWoPcWPo = OQhmElMrFWoPcWPo(str, tPmMbHzseBdGhYzv("85cc5dc519ea8f23e32e87d7cd3ebe15b3f124667926e7ae4e8acc83c95ca4d65e2839b4ff85"));
        }
        byte[] bArr = (byte[]) objOQhmElMrFWoPcWPo;
        int i2 = iArr[0];
        int i3 = iArr[1];
        int i4 = iArr[2];
        int i5 = iArr[3];
        char[] cArr = new char[i3];
        RrhwLXCoJFQsZKul(f395e, i2, cArr, 0, i3);
        if (bArr is not null) {
            char[] cArr2 = new char[i3];
            char c = 0;
            for (int i6 = 0; i6 < i3; i6++) {
                int i7 = f394d + 55;
                int i8 = i7 % 128;
                f393c = i8;
                if (i7 % 2 != 0 ? bArr[i6] == 0 : bArr[i6] == 1) {
                    int i9 = i8 + 5;
                    f394d = i9 % 128;
                    int i10 = i9 % 2;
                    cArr2[i6] = (char) (((cArr[i6] << 1) + 1) - c);
                } else {
                    cArr2[i6] = (char) ((cArr[i6] << 1) - c);
                }
                c = cArr2[i6];
            }
            cArr = cArr2;
        }
        if (i5 > 0) {
            int i11 = f394d + 83;
            f393c = i11 % 128;
            if (i11 % 2 == 0) {
                char[] cArr3 = new char[i3];
                iDUHxWctgZjsfrMA(cArr, 0, cArr3, 0, i3);
                int i12 = i3 - i5;
                XvVkiRnCuwCiQUde(cArr3, 0, cArr, i12, i5);
                EwDBAlnpsVonleSF(cArr3, i5, cArr, 0, i12);
            } else {
                char[] cArr4 = new char[i3];
                hpNnbaZHQOdiVjtU(cArr, 1, cArr4, 1, i3);
                GWIgWDwFKFEoYiGC(cArr4, 0, cArr, i3 * i5, i5);
                IXnfQrfXjXpqaiDq(cArr4, i5, cArr, 1, i3 << i5);
            }
        }
        if (!(!z)) {
            char[] cArr5 = new char[i3];
            for (int i13 = 0; i13 < i3; i13++) {
                cArr5[i13] = cArr[(i3 - i13) - 1];
            }
            cArr = cArr5;
        }
        if (i4 > 0) {
            int i14 = f394d + 5;
            f393c = i14 % 128;
            int i15 = i14 % 2;
            for (int i16 = 0; i16 < i3; i16++) {
                cArr[i16] = (char) (cArr[i16] - iArr[2]);
            }
        }
        return new java.lang.string(cArr);
    }

    static void M419c() {
        f395e = new char[]{'\"', 'I', 'N', 'N', 26, '<', 'I', 'N', 'N', 164, 179, 177, 166, 166, 173};
    }

    public static java.lang.object FleNFKDPILdBTMsu(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static void HpNnbaZHQOdiVjtU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void IDUHxWctgZjsfrMA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object JydqzqxNwltXqJBP(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.object NwmYErOxQmPHkOpw(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static java.lang.reflect.Constructor SPBkWxrFMyyrRDBE(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.string TPmMbHzseBdGhYzv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UQMLRxpFBQCPZNII(java.lang.string str, int[] iArr, bool z) {
        return m418c(str, iArr, z);
    }

    public static java.lang.object UnSEvUQYdsmxLaNh(com.mastercard.terminalsdk.emv.Tag$Rule[] tag$RuleArr) {
        return tag$RuleArr.clone();
    }

    public static com.mastercard.terminalsdk.emv.Tag$Rule valueOf(java.lang.string str) {
        if ((28 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = f393c + 65;
        f394d = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.emv.Tag$Rule tag$Rule = (com.mastercard.terminalsdk.emv.Tag$Rule) TKlRtdxRFMuZMCcq(com.mastercard.terminalsdk.emv.Tag$Rule.class, str);
        int i4 = f394d + 35;
        f393c = i4 % 128;
        int i5 = i4 % 2;
        return tag$Rule;
    }

    public static com.mastercard.terminalsdk.emv.Tag$Rule[] values() {
        if ((15 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = f393c + 45;
        f394d = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.emv.Tag$Rule[] tag$RuleArr = (com.mastercard.terminalsdk.emv.Tag$Rule[]) unSEvUQYdsmxLaNh(f392b);
        int i4 = f394d + 83;
        f393c = i4 % 128;
        if (i4 % 2 != 0) {
            int i5 = 41 / 0;
        }
        return tag$RuleArr;
    }

    public static void VbpPdqsqyHhUTyMB() {
        m419c();
    }

    public static java.lang.reflect.Constructor WAcOgnrPLRyLmoZT(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.int WJESOTckxDHYlDlY(int i) {
        return java.lang.int.valueOf(i);
    }

    public abstract bool ProcessRule(byte[] bArr);
}

