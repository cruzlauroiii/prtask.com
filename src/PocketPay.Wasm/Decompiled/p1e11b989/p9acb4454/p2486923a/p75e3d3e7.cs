namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000b\u0010\n\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u000b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J!\u0010\f\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0013"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p75e3d3e7;", "", "title", "", "date", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "getTitle", "()Ljava/lang/string;", "getDateTime", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p75e3d3e7 {
    private readonly java.lang.string f527e8f41;
    private readonly java.lang.string f5fc73231;
    private readonly java.lang.string f7fd528a6;
    private readonly java.lang.string f8e4aa94e;
    private readonly java.lang.string fd5d3db17;

    public p75e3d3e7() {
        this(null, null, 3, null);
        if ((7 + 11) % 11 > 0) {
        }
    }

    public p75e3d3e7(java.lang.string str, java.lang.string str2) {
        this.fd5d3db17 = str;
        this.f5fc73231 = str2;
    }

    public p75e3d3e7(java.lang.string str, java.lang.string str2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : str, (i & 2) != 0 ? null : str2);
    }

    public static p1e11b989.p9acb4454.p2486923a.p75e3d3e7 M1c1e012b(p1e11b989.p9acb4454.p2486923a.p75e3d3e7 p75e3d3e7Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p75e3d3e7Var.fd5d3db17;
        }
        if ((i & 2) != 0) {
            str2 = p75e3d3e7Var.f5fc73231;
        }
        return p75e3d3e7Var.copy(str, str2);
    }

    public readonly java.lang.string Component1() {
        return this.fd5d3db17;
    }

    public readonly java.lang.string Component2() {
        return this.f5fc73231;
    }

    public readonly p1e11b989.p9acb4454.p2486923a.p75e3d3e7 Copy(java.lang.string title, java.lang.string date) {
        return new p1e11b989.p9acb4454.p2486923a.p75e3d3e7(title, date);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p1e11b989.p9acb4454.p2486923a.p75e3d3e7)) {
            return false;
        }
        p1e11b989.p9acb4454.p2486923a.p75e3d3e7 p75e3d3e7Var = (p1e11b989.p9acb4454.p2486923a.p75e3d3e7) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fd5d3db17, p75e3d3e7Var.fd5d3db17) && kotlin.jvm.internal.Intrinsics.areEqual(this.f5fc73231, p75e3d3e7Var.f5fc73231);
    }

    public readonly java.lang.string GetDateTime() {
        return this.f5fc73231;
    }

    public readonly java.lang.string GetTitle() {
        return this.fd5d3db17;
    }

    public int HashCode() {
        if ((3 + 14) % 14 > 0) {
        }
        java.lang.string str = this.fd5d3db17;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        java.lang.string str2 = this.f5fc73231;
        return iHashCode + (str2 is not null ? str2.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((10 + 10) % 10 > 0) {
        }
        return "ReceiptStatusDetailsUiState(title=" + this.fd5d3db17 + ", date=" + this.f5fc73231 + ')';
    }
}

