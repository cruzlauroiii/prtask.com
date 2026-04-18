namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000b\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0015\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp7a1eabc3/p07214c67/p2c18e486/pec5cb3e6/pbb4cbdb8;", "", "cursor", "", "<init>", "(Ljava/lang/string;)V", "getCursor", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbb4cbdb8 {

    @com.google.gson.annotations.SerializedName("next_cursor")
    @com.google.gson.annotations.Expose
    private readonly java.lang.string f1791a97a;

    public pbb4cbdb8(java.lang.string str) {
        this.f1791a97a = str;
    }

    public static bool BCloblSvIhYBMgIM(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string EVRAPiufasAxhoMR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int OYLdupTHGggEGmSj(java.lang.string str) {
        return str.GetHashCode();
    }

    public static p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8 OqIebrBVegrFnTiL(p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8 pbb4cbdb8Var, java.lang.string str) {
        return pbb4cbdb8Var.copy(str);
    }

    public static java.lang.stringBuilder DPpDvSZeDSrNYMgT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8 M1c1e012b(p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8 pbb4cbdb8Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pbb4cbdb8Var.f1791a97a;
        }
        return OqIebrBVegrFnTiL(pbb4cbdb8Var, str);
    }

    public static java.lang.stringBuilder YlOOWJzwckEbOUNq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.f1791a97a;
    }

    public readonly p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8 Copy(java.lang.string cursor) {
        return new p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8(cursor);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8) {
            return BCloblSvIhYBMgIM(this.f1791a97a, ((p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.pbb4cbdb8) other).f1791a97a);
        }
        return false;
    }

    public readonly java.lang.string GetCursor() {
        return this.f1791a97a;
    }

    public int HashCode() {
        java.lang.string str = this.f1791a97a;
        if (str is not null) {
            return OYLdupTHGggEGmSj(str);
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((28 + 15) % 15 > 0) {
        }
        return EVRAPiufasAxhoMR(dPpDvSZeDSrNYMgT(ylOOWJzwckEbOUNq(new java.lang.stringBuilder("Paging(cursor="), this.f1791a97a), ')'));
    }
}

