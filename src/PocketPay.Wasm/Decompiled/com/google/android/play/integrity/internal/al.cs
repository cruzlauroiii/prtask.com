namespace WillowMaze.Wasm.Decompiled;


public readonly class al {
    public static java.lang.string AFoudpVwsBjHkIXu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int BIEtojEsZJLbOELS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string JZulWGagtbZWBdYH(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.play.integrity.internal.am.m293a(str, objArr);
    }

    public static java.lang.string TPaKYXoBrtKCRUCF(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.play.integrity.internal.am.m293a(str, objArr);
    }

    public static java.lang.string TmoFoKhgJUzwGLYN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int VcxXdXIJVYMwUlOM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder VqrSdATRyRzcQxYI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int YQqjxWkODRRjXtYk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int M289a(int i, int i2, java.lang.string str) {
        java.lang.string strHwAODQHVdtWmfUrT;
        if (i >= 0 && i < i2) {
            return i;
        }
        if (i < 0) {
            strHwAODQHVdtWmfUrT = TPaKYXoBrtKCRUCF("%s (%s) must not be negative", new java.lang.object[]{"index", ouakPBvjAAQGYgbU(i)});
        } else {
            if (i2 < 0) {
                java.lang.stringBuilder sb = new java.lang.stringBuilder("negative size: ");
                vQJGPYTqkoLxiJcz(sb, i2);
                throw new java.lang.IllegalArgumentException(AFoudpVwsBjHkIXu(sb));
            }
            strHwAODQHVdtWmfUrT = hwAODQHVdtWmfUrT("%s (%s) must be less than size (%s)", new java.lang.object[]{"index", VcxXdXIJVYMwUlOM(i), poScxcpeYERkyiBx(i2)});
        }
        throw new java.lang.IndexOutOfBoundsException(strHwAODQHVdtWmfUrT);
    }

    public static java.lang.int AdTlNiXzKsGkfole(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int M290b(int i, int i2, java.lang.string str) {
        if (i >= 0 && i <= i2) {
            return i;
        }
        throw new java.lang.IndexOutOfBoundsException(mNrWOErcPhrkghcd(i, i2, "index"));
    }

    public static void M291c(int i, int i2, int i3) {
        if (i >= 0 && i2 >= i && i2 <= i3) {
        } else {
            throw new java.lang.IndexOutOfBoundsException((i >= 0 && i <= i3) ? (i2 >= 0 && i2 <= i3) ? oOZEUJakYZvTOrAK("end index (%s) must not be less than start index (%s)", new java.lang.object[]{kgWWEaEvdPNegMfZ(i2), BIEtojEsZJLbOELS(i)}) : nUapGnNzVYMkWQSm(i2, i3, "end index") : iLZjCkXcccBabrtT(i, i3, "start index"));
        }
    }

    private static java.lang.string M292d(int i, int i2, java.lang.string str) {
        if (i < 0) {
            return JZulWGagtbZWBdYH("%s (%s) must not be negative", new java.lang.object[]{str, adTlNiXzKsGkfole(i)});
        }
        if (i2 >= 0) {
            return sfsNfxRHmWIEKKMW("%s (%s) must not be greater than size (%s)", new java.lang.object[]{str, YQqjxWkODRRjXtYk(i), ejzjAGNOKtANapuf(i2)});
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("negative size: ");
        VqrSdATRyRzcQxYI(sb, i2);
        throw new java.lang.IllegalArgumentException(TmoFoKhgJUzwGLYN(sb));
    }

    public static java.lang.int EjzjAGNOKtANapuf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string HwAODQHVdtWmfUrT(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.play.integrity.internal.am.m293a(str, objArr);
    }

    public static java.lang.string ILZjCkXcccBabrtT(int i, int i2, java.lang.string str) {
        return m292d(i, i2, str);
    }

    public static java.lang.int KgWWEaEvdPNegMfZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string MNrWOErcPhrkghcd(int i, int i2, java.lang.string str) {
        return m292d(i, i2, str);
    }

    public static java.lang.string NUapGnNzVYMkWQSm(int i, int i2, java.lang.string str) {
        return m292d(i, i2, str);
    }

    public static java.lang.string OOZEUJakYZvTOrAK(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.play.integrity.internal.am.m293a(str, objArr);
    }

    public static java.lang.int OuakPBvjAAQGYgbU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int PoScxcpeYERkyiBx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string SfsNfxRHmWIEKKMW(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.play.integrity.internal.am.m293a(str, objArr);
    }

    public static java.lang.stringBuilder VQJGPYTqkoLxiJcz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }
}

