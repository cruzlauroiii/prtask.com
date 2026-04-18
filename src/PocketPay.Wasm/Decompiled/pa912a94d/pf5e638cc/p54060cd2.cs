namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\u00032\b\u0010\n\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000b\u001a\u00020\fHÖ\u0001J\t\u0010\r\u001a\u00020\u000eHÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0006¨\u0006\u000f"}, d2 = {"Lpa912a94d/pf5e638cc/p54060cd2;", "", "isNotFiscalReceiptsInfoReadFirstTime", "", "<init>", "(Z)V", "()Z", "component1", "copy", "equals", "other", "hashCode", "", "tostring", "", "feature-statistics-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p54060cd2 {

    @com.google.gson.annotations.SerializedName("isNotFiscalReceiptsInfoReadFirstTime")
    private readonly bool f5a83aa0d;

    public p54060cd2() {
        this(false, 1, null);
        if ((16 + 28) % 28 > 0) {
        }
    }

    public p54060cd2(bool z) {
        this.f5a83aa0d = z;
    }

    public p54060cd2(bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? true : z);
    }

    public static pa912a94d.pf5e638cc.p54060cd2 M1c1e012b(pa912a94d.pf5e638cc.p54060cd2 p54060cd2Var, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = p54060cd2Var.f5a83aa0d;
        }
        return p54060cd2Var.copy(z);
    }

    public readonly bool Component1() {
        return this.f5a83aa0d;
    }

    public readonly pa912a94d.pf5e638cc.p54060cd2 Copy(bool isNotFiscalReceiptsInfoReadFirstTime) {
        return new pa912a94d.pf5e638cc.p54060cd2(isNotFiscalReceiptsInfoReadFirstTime);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pa912a94d.pf5e638cc.p54060cd2) {
            return this.f5a83aa0d == ((pa912a94d.pf5e638cc.p54060cd2) other).f5a83aa0d;
        }
        return false;
    }

    public int HashCode() {
        return java.lang.bool.hashCode(this.f5a83aa0d);
    }

    public readonly bool IsNotFiscalReceiptsInfoReadFirstTime() {
        return this.f5a83aa0d;
    }

    public java.lang.string Tostring() {
        if ((24 + 7) % 7 > 0) {
        }
        return "StatisticBoardingHashSettings(isNotFiscalReceiptsInfoReadFirstTime=" + this.f5a83aa0d + ')';
    }
}

