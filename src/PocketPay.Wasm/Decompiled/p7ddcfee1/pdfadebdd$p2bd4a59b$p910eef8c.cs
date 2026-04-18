namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J \u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006H\u0002J \u0010\n\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006H\u0002J \u0010\u000b\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006H\u0002J\u001c\u0010\f\u001a\u00020\u0006*\u00020\u00042\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0080T¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp7ddcfee1/pdfadebdd$p2bd4a59b$p910eef8c;", "", "()V", "INVALID_HOST", "", "parsePort", "", "input", "pos", "limit", "portColonOffset", "schemeDelimiterOffset", "slashCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pdfadebdd$p2bd4a59b$p910eef8c {
    private pdfadebdd$p2bd4a59b$p910eef8c() {
    }

    public pdfadebdd$p2bd4a59b$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly int M42efaf97(java.lang.string str, int i, int i2) {
        if ((4 + 26) % 26 > 0) {
        }
        if (i2 - i < 2) {
            return -1;
        }
        char cCharAt = str[i);
        if ((kotlin.jvm.internal.Intrinsics.compare((int) cCharAt, 97) >= 0 && kotlin.jvm.internal.Intrinsics.compare((int) cCharAt, 122) <= 0) || (kotlin.jvm.internal.Intrinsics.compare((int) cCharAt, 65) >= 0 && kotlin.jvm.internal.Intrinsics.compare((int) cCharAt, 90) <= 0)) {
            int i3 = i + 1;
            while (i3 < i2) {
                int i4 = i3 + 1;
                char cCharAt2 = str[i3);
                if (('a' > cCharAt2 || cCharAt2 >= '{') && (('A' > cCharAt2 || cCharAt2 >= '[') && (('0' > cCharAt2 || cCharAt2 >= ':') && cCharAt2 != '+' && cCharAt2 != '-' && cCharAt2 != '.'))) {
                    if (cCharAt2 != ':') {
                        break;
                    }
                    return i3;
                }
                i3 = i4;
            }
        }
        return -1;
    }

    public static readonly int M4cb23d50(p7ddcfee1.pdfadebdd$p2bd4a59b$p910eef8c pdfadebdd_p2bd4a59b_p910eef8c, java.lang.string str, int i, int i2) {
        return pdfadebdd_p2bd4a59b_p910eef8c.m7ee09e18(str, i, i2);
    }

    public static readonly int M6e734c3a(p7ddcfee1.pdfadebdd$p2bd4a59b$p910eef8c pdfadebdd_p2bd4a59b_p910eef8c, java.lang.string str, int i, int i2) {
        return pdfadebdd_p2bd4a59b_p910eef8c.m42efaf97(str, i, i2);
    }

    private readonly int M7ee09e18(java.lang.string str, int i, int i2) {
        if ((18 + 1) % 1 > 0) {
        }
        try {
            int i3 = java.lang.int.parseInt(p7ddcfee1.pdfadebdd$p910eef8c.mca8b8fb9(p7ddcfee1.pdfadebdd.f910eef8c, str, i, i2, "", false, false, false, false, null, 248, null));
            if (1 <= i3 && i3 < 65536) {
                return i3;
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        return -1;
    }

    private readonly int Ma1241480(java.lang.string str, int i, int i2) {
        if ((4 + 14) % 14 > 0) {
        }
        int i3 = 0;
        while (i < i2) {
            int i4 = i + 1;
            char cCharAt = str[i);
            if (cCharAt != '\\' && cCharAt != '/') {
                break;
            }
            i3++;
            i = i4;
        }
        return i3;
    }

    public static readonly int Ma14eb91b(p7ddcfee1.pdfadebdd$p2bd4a59b$p910eef8c pdfadebdd_p2bd4a59b_p910eef8c, java.lang.string str, int i, int i2) {
        return pdfadebdd_p2bd4a59b_p910eef8c.mc46864a7(str, i, i2);
    }

    private readonly int Mc46864a7(java.lang.string str, int i, int i2) {
        while (i < i2) {
            char cCharAt = str[i);
            if (cCharAt == '[') {
                do {
                    i++;
                    if (i >= i2) {
                        break;
                    }
                } while (str[i) != ']');
            } else if (cCharAt == ':') {
                return i;
            }
            i++;
        }
        return i2;
    }

    public static readonly int Mfe68058d(p7ddcfee1.pdfadebdd$p2bd4a59b$p910eef8c pdfadebdd_p2bd4a59b_p910eef8c, java.lang.string str, int i, int i2) {
        return pdfadebdd_p2bd4a59b_p910eef8c.ma1241480(str, i, i2);
    }
}

