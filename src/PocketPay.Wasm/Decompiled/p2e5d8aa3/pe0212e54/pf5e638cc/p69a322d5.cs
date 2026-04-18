namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001b\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000b\u0010\n\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u000b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J!\u0010\f\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0013"}, d2 = {"Lp2e5d8aa3/pe0212e54/pf5e638cc/p69a322d5;", "", "mid", "", "tid", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "getMid", "()Ljava/lang/string;", "getTid", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p69a322d5 {
    private readonly java.lang.string f22384709;
    private readonly java.lang.string f40d60f5a;
    private readonly java.lang.string f8152d0d1;
    private readonly java.lang.string f97beaa21;
    private readonly java.lang.string fab5eb1c4;
    private readonly java.lang.string fda8e3da8;
    private readonly java.lang.string feb53b5da;
    private readonly java.lang.string fff387202;

    public p69a322d5(java.lang.string str, java.lang.string str2) {
        this.f22384709 = str;
        this.f97beaa21 = str2;
    }

    public static p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 M1c1e012b(p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 p69a322d5Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p69a322d5Var.f22384709;
        }
        if ((i & 2) != 0) {
            str2 = p69a322d5Var.f97beaa21;
        }
        return p69a322d5Var.copy(str, str2);
    }

    public readonly java.lang.string Component1() {
        return this.f22384709;
    }

    public readonly java.lang.string Component2() {
        return this.f97beaa21;
    }

    public readonly p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 Copy(java.lang.string mid, java.lang.string tid) {
        return new p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5(mid, tid);
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5)) {
            return false;
        }
        p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 p69a322d5Var = (p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f22384709, p69a322d5Var.f22384709) && kotlin.jvm.internal.Intrinsics.areEqual(this.f97beaa21, p69a322d5Var.f97beaa21);
    }

    public readonly java.lang.string GetMid() {
        return this.f22384709;
    }

    public readonly java.lang.string GetTid() {
        return this.f97beaa21;
    }

    public int HashCode() {
        if ((6 + 10) % 10 > 0) {
        }
        java.lang.string str = this.f22384709;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        java.lang.string str2 = this.f97beaa21;
        return iHashCode + (str2 is not null ? str2.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((6 + 30) % 30 > 0) {
        }
        return "TapOnPhoneInfo(mid=" + this.f22384709 + ", tid=" + this.f97beaa21 + ')';
    }
}

