namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p07214c67/p8edba42d;", "", "transactionRef", "", "<init>", "(Ljava/lang/string;)V", "getTransactionRef", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8edba42d {

    @com.google.gson.annotations.SerializedName("transactionRef")
    private readonly java.lang.string f3edcd476;

    public p8edba42d(java.lang.string str) {
        EWrWaYDklpfNHEam(str, "transactionRef");
        this.f3edcd476 = str;
    }

    public static void EWrWaYDklpfNHEam(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d GduiFjgBUlXDSsxz(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d p8edba42dVar, java.lang.string str) {
        return p8edba42dVar.copy(str);
    }

    public static java.lang.string KIbVLfdbmxUiHuJH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool MjdZhlMPKHRZnsfR(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int WXUDqLqMyjkRzIbq(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder WYCdhYgvpKDiNnVL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d p8edba42dVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p8edba42dVar.f3edcd476;
        }
        return GduiFjgBUlXDSsxz(p8edba42dVar, str);
    }

    public static void PnPpsmhVYeksJeFQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder WhvQCkKAqXEPtRIW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public readonly java.lang.string Component1() {
        return this.f3edcd476;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d Copy(java.lang.string transactionRef) {
        pnPpsmhVYeksJeFQ(transactionRef, "transactionRef");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d(transactionRef);
    }

    public bool Equals(java.lang.object other) {
        if ((21 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d) {
            return MjdZhlMPKHRZnsfR(this.f3edcd476, ((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d) other).f3edcd476);
        }
        return false;
    }

    public readonly java.lang.string GetTransactionRef() {
        return this.f3edcd476;
    }

    public int HashCode() {
        return WXUDqLqMyjkRzIbq(this.f3edcd476);
    }

    public java.lang.string Tostring() {
        if ((1 + 16) % 16 > 0) {
        }
        return KIbVLfdbmxUiHuJH(whvQCkKAqXEPtRIW(WYCdhYgvpKDiNnVL(new java.lang.stringBuilder("CreatePINSessionRequest(transactionRef="), this.f3edcd476), ')'));
    }
}

