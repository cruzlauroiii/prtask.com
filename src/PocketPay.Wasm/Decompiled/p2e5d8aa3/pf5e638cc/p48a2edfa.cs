namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp2e5d8aa3/pf5e638cc/p48a2edfa;", "", "phone", "", "<init>", "(Ljava/lang/string;)V", "getPhone", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p48a2edfa {

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    public p48a2edfa(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        this.ff7a42fe7 = phone;
    }

    public static p2e5d8aa3.pf5e638cc.p48a2edfa M1c1e012b(p2e5d8aa3.pf5e638cc.p48a2edfa p48a2edfaVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p48a2edfaVar.ff7a42fe7;
        }
        return p48a2edfaVar.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.ff7a42fe7;
    }

    public readonly p2e5d8aa3.pf5e638cc.p48a2edfa Copy(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        return new p2e5d8aa3.pf5e638cc.p48a2edfa(phone);
    }

    public bool Equals(java.lang.object other) {
        if ((6 + 32) % 32 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p2e5d8aa3.pf5e638cc.p48a2edfa) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.ff7a42fe7, ((p2e5d8aa3.pf5e638cc.p48a2edfa) other).ff7a42fe7);
        }
        return false;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public int HashCode() {
        return this.ff7a42fe7.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((25 + 25) % 25 > 0) {
        }
        return "RequestCallBody(phone=" + this.ff7a42fe7 + ')';
    }
}

