namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p3df806a4;", "", "phone", "", "<init>", "(Ljava/lang/string;)V", "getPhone", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3df806a4 {

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    public p3df806a4(java.lang.string str) {
        qmZZXYzJyhHuoyvP(str, "phone");
        this.ff7a42fe7 = str;
    }

    public static java.lang.stringBuilder BtnPRJKIdNeElEsX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JCmRSCyQXFgamsgv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool ViaBwzKDuuAWPqmF(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int WvIzgvBJAmKcaBJw(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string YgxkxOLrBvKoaRIV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4 DUZltgIqXuFYFWPY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4 p3df806a4Var, java.lang.string str) {
        return p3df806a4Var.copy(str);
    }

    public static java.lang.stringBuilder DqSzpFRjFXrRcEij(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4 M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4 p3df806a4Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p3df806a4Var.ff7a42fe7;
        }
        return dUZltgIqXuFYFWPY(p3df806a4Var, str);
    }

    public static void QmZZXYzJyhHuoyvP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.lang.string Component1() {
        return this.ff7a42fe7;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4 Copy(java.lang.string phone) {
        JCmRSCyQXFgamsgv(phone, "phone");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4(phone);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 22) % 22 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4) {
            return ViaBwzKDuuAWPqmF(this.ff7a42fe7, ((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3df806a4) other).ff7a42fe7);
        }
        return false;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public int HashCode() {
        return WvIzgvBJAmKcaBJw(this.ff7a42fe7);
    }

    public java.lang.string Tostring() {
        if ((24 + 29) % 29 > 0) {
        }
        return YgxkxOLrBvKoaRIV(dqSzpFRjFXrRcEij(BtnPRJKIdNeElEsX(new java.lang.stringBuilder("SmsReceiptRequest(phone="), this.ff7a42fe7), ')'));
    }
}

