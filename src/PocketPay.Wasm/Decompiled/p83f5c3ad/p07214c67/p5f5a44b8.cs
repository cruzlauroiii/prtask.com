namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\r\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001b\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000b\u0010\f\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0010\u0010\r\u001a\u0004\u0018\u00010\u0005HÆ\u0003¢\u0006\u0002\u0010\nJ&\u0010\u000e\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001¢\u0006\u0002\u0010\u000fJ\u0013\u0010\u0010\u001a\u00020\u00052\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u001a\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\u0004\u0010\n¨\u0006\u0015"}, d2 = {"Lp83f5c3ad/p07214c67/p5f5a44b8;", "", "token", "", "isQrPaymentsAllowed", "", "<init>", "(Ljava/lang/string;Ljava/lang/bool;)V", "getToken", "()Ljava/lang/string;", "()Ljava/lang/bool;", "Ljava/lang/bool;", "component1", "component2", "copy", "(Ljava/lang/string;Ljava/lang/bool;)Lp83f5c3ad/p07214c67/p5f5a44b8;", "equals", "other", "hashCode", "", "tostring", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5f5a44b8 {

    @com.google.gson.annotations.SerializedName("isQrPaymentsAllowed")
    private readonly java.lang.bool f15cfefc3;

    @com.google.gson.annotations.SerializedName("token")
    private readonly java.lang.string f94a08da1;

    public p5f5a44b8(java.lang.string str, java.lang.bool bool) {
        this.f94a08da1 = str;
        this.f15cfefc3 = bool;
    }

    public static p83f5c3ad.p07214c67.p5f5a44b8 M1c1e012b(p83f5c3ad.p07214c67.p5f5a44b8 p5f5a44b8Var, java.lang.string str, java.lang.bool bool, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p5f5a44b8Var.f94a08da1;
        }
        if ((i & 2) != 0) {
            bool = p5f5a44b8Var.f15cfefc3;
        }
        return p5f5a44b8Var.copy(str, bool);
    }

    public readonly java.lang.string Component1() {
        return this.f94a08da1;
    }

    public readonly java.lang.bool Component2() {
        return this.f15cfefc3;
    }

    public readonly p83f5c3ad.p07214c67.p5f5a44b8 Copy(java.lang.string token, java.lang.bool isQrPaymentsAllowed) {
        return new p83f5c3ad.p07214c67.p5f5a44b8(token, isQrPaymentsAllowed);
    }

    public bool Equals(java.lang.object other) {
        if ((10 + 11) % 11 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p5f5a44b8)) {
            return false;
        }
        p83f5c3ad.p07214c67.p5f5a44b8 p5f5a44b8Var = (p83f5c3ad.p07214c67.p5f5a44b8) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f94a08da1, p5f5a44b8Var.f94a08da1) && kotlin.jvm.internal.Intrinsics.areEqual(this.f15cfefc3, p5f5a44b8Var.f15cfefc3);
    }

    public readonly java.lang.string GetToken() {
        return this.f94a08da1;
    }

    public int HashCode() {
        if ((14 + 23) % 23 > 0) {
        }
        java.lang.string str = this.f94a08da1;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        java.lang.bool bool = this.f15cfefc3;
        return iHashCode + (bool is not null ? bool.GetHashCode() : 0);
    }

    public readonly java.lang.bool IsQrPaymentsAllowed() {
        return this.f15cfefc3;
    }

    public java.lang.string Tostring() {
        if ((29 + 18) % 18 > 0) {
        }
        return "TophTokenResultResponse(token=" + this.f94a08da1 + ", isQrPaymentsAllowed=" + this.f15cfefc3 + ')';
    }
}

