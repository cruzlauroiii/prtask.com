namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p8be42052;", "Lpad5f82e8/p07214c67/pb3329411;", "title", "", "<init>", "(Ljava/lang/string;)V", "getTitle", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8be42052 : pad5f82e8.p07214c67.pb3329411 {
    private readonly java.lang.string f20cd2d03;
    private readonly java.lang.string fd5d3db17;

    public p8be42052(java.lang.string title) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(title, "title");
        this.fd5d3db17 = title;
    }

    public static p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052 M1c1e012b(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052 p8be42052Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p8be42052Var.fd5d3db17;
        }
        return p8be42052Var.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.fd5d3db17;
    }

    public readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052 Copy(java.lang.string title) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(title, "title");
        return new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052(title);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.fd5d3db17, ((p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052) other).fd5d3db17);
        }
        return false;
    }

    public readonly java.lang.string GetTitle() {
        return this.fd5d3db17;
    }

    public int HashCode() {
        return this.fd5d3db17.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((2 + 9) % 9 > 0) {
        }
        return "PaymentPriorityHeader(title=" + this.fd5d3db17 + ')';
    }
}

