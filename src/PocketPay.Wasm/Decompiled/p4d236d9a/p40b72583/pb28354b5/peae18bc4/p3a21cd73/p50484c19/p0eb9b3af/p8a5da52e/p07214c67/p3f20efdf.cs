namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p3f20efdf;", "", "email", "", "<init>", "(Ljava/lang/string;)V", "getEmail", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3f20efdf {

    @com.google.gson.annotations.SerializedName("email")
    private readonly java.lang.string f0c83f57c;

    public p3f20efdf(java.lang.string str) {
        JFMHKuyAevvCniFA(str, "email");
        this.f0c83f57c = str;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf CKpsBZXnhNXNOTQP(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf p3f20efdfVar, java.lang.string str) {
        return p3f20efdfVar.copy(str);
    }

    public static void JFMHKuyAevvCniFA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LTcVYhYAztWsUTHx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int PYLefBoIfFvucsfi(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder RqRnEzjRPztRBTWT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DgyfMnkXBXBLVAZF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf p3f20efdfVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p3f20efdfVar.f0c83f57c;
        }
        return CKpsBZXnhNXNOTQP(p3f20efdfVar, str);
    }

    public static java.lang.stringBuilder PPcUQXdIAHboklwN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool RmCQskRYzbcFYMJT(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string Component1() {
        return this.f0c83f57c;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf Copy(java.lang.string email) {
        LTcVYhYAztWsUTHx(email, "email");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf(email);
    }

    public bool Equals(java.lang.object other) {
        if ((17 + 19) % 19 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf) {
            return rmCQskRYzbcFYMJT(this.f0c83f57c, ((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p3f20efdf) other).f0c83f57c);
        }
        return false;
    }

    public readonly java.lang.string GetEmail() {
        return this.f0c83f57c;
    }

    public int HashCode() {
        return PYLefBoIfFvucsfi(this.f0c83f57c);
    }

    public java.lang.string Tostring() {
        if ((3 + 6) % 6 > 0) {
        }
        return dgyfMnkXBXBLVAZF(pPcUQXdIAHboklwN(RqRnEzjRPztRBTWT(new java.lang.stringBuilder("EmailReceiptRequest(email="), this.f0c83f57c), ')'));
    }
}

