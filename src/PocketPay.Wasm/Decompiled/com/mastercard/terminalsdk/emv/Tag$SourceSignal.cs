namespace WillowMaze.Wasm.Decompiled;


public readonly class Tag$SourceSignal {
    public static readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal ACT;
    public static readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal DET;

    public static readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal f403K;
    public static readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal RA;

    private static readonly com.mastercard.terminalsdk.emv.Tag$SourceSignal[] f404a;

    private static char f405b = 0;

    private static char f406c = 0;

    private static char f407d = 0;

    private static char f408e = 0;

    private static int f409f = 0;

    private static int f410g = 1;

    static {
        if ((5 + 21) % 21 > 0) {
        }
        fCGPfWjJWkvLFIOp();
        com.mastercard.terminalsdk.emv.Tag$SourceSignal tag$SourceSignal = new com.mastercard.terminalsdk.emv.Tag$SourceSignal(yZnzVFkTWOgQHrvr(RqMibHodhMxvQNtz(AoYhmXWeIAuExtrd("1f377b250ca4257f55d97d0f27309ee4791610639c8d7b3d0c52068be1354161aea989fb81f7c2b2"))), 0);
        ACT = tag$SourceSignal;
        com.mastercard.terminalsdk.emv.Tag$SourceSignal tag$SourceSignal2 = new com.mastercard.terminalsdk.emv.Tag$SourceSignal(zAtGVYfrCzDjKBUk(LdFebIzPhtYRWEBL(yvBnZswzEGsgfAMd("bc578a85f518cdbaa2d12db1298a10f7386f8c46c70e2b518f04a26f2db889e77926"))), 1);
        f403K = tag$SourceSignal2;
        com.mastercard.terminalsdk.emv.Tag$SourceSignal tag$SourceSignal3 = new com.mastercard.terminalsdk.emv.Tag$SourceSignal(yDboDxdGKxYUcKsN(VvlmnkkiBjbDysue(aUmkqVKmHMHixgBK("f0f236e9b5614576b3eed2da343ada5031b31d4390409232798b5e07fbf68e6d97935bf4bbb7078c"))), 2);
        RA = tag$SourceSignal3;
        com.mastercard.terminalsdk.emv.Tag$SourceSignal tag$SourceSignal4 = new com.mastercard.terminalsdk.emv.Tag$SourceSignal(ucoiLfcKaYxqFPIH(DDTACpLmmkcuqigv(pqMZsEixkzbGdttb("49dfdd79b427ed7d6233ef764e13594f2594976ddaf0076f76c9265f35c2c1a8ed7964fb317c58c9"))), 3);
        DET = tag$SourceSignal4;
        f404a = new com.mastercard.terminalsdk.emv.Tag$SourceSignal[]{tag$SourceSignal, tag$SourceSignal2, tag$SourceSignal3, tag$SourceSignal4};
        int i = f410g + 15;
        f409f = i % 128;
        if (i % 2 != 0) {
            IJzyFKZwYUDeQfsc(null);
            throw null;
        }
    }

    private Tag$SourceSignal(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string AoYhmXWeIAuExtrd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string DDTACpLmmkcuqigv(java.lang.string str) {
        return m423c(str);
    }

    public static int IJzyFKZwYUDeQfsc(java.lang.object obj) {
        return super.GetHashCode();
    }

    public static char[] KNlfTELcpOeweTBc(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.object KQFwlPzsjcthEWRj(com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr) {
        return tag$SourceSignalArr.clone();
    }

    public static java.lang.Enum KlWNXrrfqDXbswdw(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string LdFebIzPhtYRWEBL(java.lang.string str) {
        return m423c(str);
    }

    public static java.lang.object NEQdpiAcIBDFaiEB(com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr) {
        return tag$SourceSignalArr.clone();
    }

    public static java.lang.string RqMibHodhMxvQNtz(java.lang.string str) {
        return m423c(str);
    }

    public static java.lang.string VvlmnkkiBjbDysue(java.lang.string str) {
        return m423c(str);
    }

    public static java.lang.string AUmkqVKmHMHixgBK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    static void M422b() {
        f408e = (char) 64427;
        f405b = (char) 25846;
        f406c = (char) 44095;
        f407d = (char) 26662;
    }

    private static java.lang.string M423c(java.lang.string str) {
        if ((12 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = f410g + 33;
        f409f = i2 % 128;
        int i3 = i2 % 2;
        java.lang.object objKNlfTELcpOeweTBc = str;
        if (str is not null) {
            objKNlfTELcpOeweTBc = KNlfTELcpOeweTBc(str);
        }
        char[] cArr = (char[]) objKNlfTELcpOeweTBc;
        char[] cArr2 = new char[cArr.length];
        for (int i4 = 0; i4 < cArr.length; i4 += 2) {
            int i5 = f409f + 57;
            f410g = i5 % 128;
            int i6 = i5 % 2;
            char c = cArr[i4];
            int i7 = i4 + 1;
            char c2 = cArr[i7];
            char[] cArr3 = new char[2];
            cArr3[0] = c;
            cArr3[1] = c2;
            zhPrcFIpqttRzyir(cArr3, f406c, f405b, f407d, f408e);
            cArr2[i4] = cArr3[0];
            cArr2[i7] = cArr3[1];
        }
        return new java.lang.string(cArr2, 1, (int) cArr2[0]);
    }

    public static void FCGPfWjJWkvLFIOp() {
        m422b();
    }

    public static java.lang.string PqMZsEixkzbGdttb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UcoiLfcKaYxqFPIH(java.lang.string str) {
        return str.intern();
    }

    public static com.mastercard.terminalsdk.emv.Tag$SourceSignal valueOf(java.lang.string str) {
        if ((22 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = f409f + 59;
        f410g = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.emv.Tag$SourceSignal tag$SourceSignal = (com.mastercard.terminalsdk.emv.Tag$SourceSignal) KlWNXrrfqDXbswdw(com.mastercard.terminalsdk.emv.Tag$SourceSignal.class, str);
        if (i3 == 0) {
            int i4 = 43 / 0;
        }
        return tag$SourceSignal;
    }

    public static com.mastercard.terminalsdk.emv.Tag$SourceSignal[] values() {
        if ((20 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = f409f + 39;
        f410g = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        com.mastercard.terminalsdk.emv.Tag$SourceSignal[] tag$SourceSignalArr = (com.mastercard.terminalsdk.emv.Tag$SourceSignal[]) NEQdpiAcIBDFaiEB(f404a);
        int i3 = f409f + 15;
        f410g = i3 % 128;
        int i4 = i3 % 2;
        return tag$SourceSignalArr;
    }

    public static java.lang.string YDboDxdGKxYUcKsN(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string YZnzVFkTWOgQHrvr(java.lang.string str) {
        return str.intern();
    }

    public static java.lang.string YvBnZswzEGsgfAMd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string ZAtGVYfrCzDjKBUk(java.lang.string str) {
        return str.intern();
    }

    public static void ZhPrcFIpqttRzyir(char[] cArr, char c, char c2, char c3, char c4) {
        com.mastercard.terminalsdk.internal.C0453n.m472b(cArr, c, c2, c3, c4);
    }
}

