namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\u001d\u0010\f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0015"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p3601146c$pc4408d33;", "Lpad5f82e8/p07214c67/p1e11b989/p3601146c;", "beforePurchasePrice", "Ljava/math/decimal;", "afterPurchasePrice", "<init>", "(Ljava/math/decimal;Ljava/math/decimal;)V", "getBeforePurchasePrice", "()Ljava/math/decimal;", "getAfterPurchasePrice", "component1", "component2", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3601146c$pc4408d33 : pad5f82e8.p07214c67.p1e11b989.p3601146c {

    @com.google.gson.annotations.SerializedName("purchase_price")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f04b7b08d;

    @com.google.gson.annotations.SerializedName("after_purchase_price")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f13e0d97b;

    public p3601146c$pc4408d33(java.math.decimal bigDecimal, java.math.decimal bigDecimal2) {
        super(null);
        gXUhyiSDkgXkmjrS(bigDecimal, "beforePurchasePrice");
        wRVkuTzTLPQWgXYA(bigDecimal2, "afterPurchasePrice");
        this.f04b7b08d = bigDecimal;
        this.f13e0d97b = bigDecimal2;
    }

    public static int DiqILMqnMbzhGnQR(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 FVNmLINRgxKduPhD(pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 p3601146c_pc4408d33, java.math.decimal bigDecimal, java.math.decimal bigDecimal2) {
        return p3601146c_pc4408d33.copy(bigDecimal, bigDecimal2);
    }

    public static void LAGecqelWUQVeEcz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder LeSnjWdFMXGGesor(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool MeKKiQelLMXEZwnd(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool RAxkNlqyaOyQkQgJ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void SpjhrLKlfsaffmRs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string VIbGgpmOBRXfGVOX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XtkjZozYzKUuOYkF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void GXUhyiSDkgXkmjrS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder GcGVpvECZwbGWLWX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder INIHelZtHDfOxNoU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 m1c1e012b(pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 p3601146c_pc4408d33, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bigDecimal = p3601146c_pc4408d33.f04b7b08d;
        }
        if ((i & 2) != 0) {
            bigDecimal2 = p3601146c_pc4408d33.f13e0d97b;
        }
        return FVNmLINRgxKduPhD(p3601146c_pc4408d33, bigDecimal, bigDecimal2);
    }

    public static int SCaIyDpGnqyZSHff(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static void WRVkuTzTLPQWgXYA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.math.decimal Component1() {
        return this.f04b7b08d;
    }

    public readonly java.math.decimal Component2() {
        return this.f13e0d97b;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 copy(java.math.decimal beforePurchasePrice, java.math.decimal afterPurchasePrice) {
        LAGecqelWUQVeEcz(beforePurchasePrice, "beforePurchasePrice");
        SpjhrLKlfsaffmRs(afterPurchasePrice, "afterPurchasePrice");
        return new pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33(beforePurchasePrice, afterPurchasePrice);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33)) {
            return false;
        }
        pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33 p3601146c_pc4408d33 = (pad5f82e8.p07214c67.p1e11b989.p3601146c$pc4408d33) other;
        return RAxkNlqyaOyQkQgJ(this.f04b7b08d, p3601146c_pc4408d33.f04b7b08d) && MeKKiQelLMXEZwnd(this.f13e0d97b, p3601146c_pc4408d33.f13e0d97b);
    }

    public readonly java.math.decimal GetAfterPurchasePrice() {
        return this.f13e0d97b;
    }

    public readonly java.math.decimal GetBeforePurchasePrice() {
        return this.f04b7b08d;
    }

    public int HashCode() {
        return (DiqILMqnMbzhGnQR(this.f04b7b08d) * 31) + sCaIyDpGnqyZSHff(this.f13e0d97b);
    }

    public java.lang.string Tostring() {
        if ((12 + 18) % 18 > 0) {
        }
        return VIbGgpmOBRXfGVOX(iNIHelZtHDfOxNoU(LeSnjWdFMXGGesor(gcGVpvECZwbGWLWX(XtkjZozYzKUuOYkF(new java.lang.stringBuilder("Accept(beforePurchasePrice="), this.f04b7b08d), ", afterPurchasePrice="), this.f13e0d97b), ')'));
    }
}

