namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u00052\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\n¨\u0006\u0013"}, d2 = {"Lp83f5c3ad/p07214c67/p839b8b7c;", "", "token", "", "isQrPaymentsAllowed", "", "<init>", "(Ljava/lang/string;Z)V", "getToken", "()Ljava/lang/string;", "()Z", "component1", "component2", "copy", "equals", "other", "hashCode", "", "tostring", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p839b8b7c {
    private readonly bool f15cfefc3;
    private readonly java.lang.string f517a23d3;
    private readonly bool f53de8078;
    private readonly java.lang.string f93ead262;
    private readonly java.lang.string f94a08da1;
    private readonly java.lang.string fbebea4b6;
    private readonly java.lang.string ff395c6ea;

    public p839b8b7c(java.lang.string token, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(token, "token");
        this.f94a08da1 = token;
        this.f15cfefc3 = z;
    }

    public static p83f5c3ad.p07214c67.p839b8b7c M1c1e012b(p83f5c3ad.p07214c67.p839b8b7c p839b8b7cVar, java.lang.string str, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p839b8b7cVar.f94a08da1;
        }
        if ((i & 2) != 0) {
            z = p839b8b7cVar.f15cfefc3;
        }
        return p839b8b7cVar.copy(str, z);
    }

    public readonly java.lang.string Component1() {
        return this.f94a08da1;
    }

    public readonly bool Component2() {
        return this.f15cfefc3;
    }

    public readonly p83f5c3ad.p07214c67.p839b8b7c Copy(java.lang.string token, bool isQrPaymentsAllowed) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(token, "token");
        return new p83f5c3ad.p07214c67.p839b8b7c(token, isQrPaymentsAllowed);
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 7) % 7 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p839b8b7c)) {
            return false;
        }
        p83f5c3ad.p07214c67.p839b8b7c p839b8b7cVar = (p83f5c3ad.p07214c67.p839b8b7c) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f94a08da1, p839b8b7cVar.f94a08da1) && this.f15cfefc3 == p839b8b7cVar.f15cfefc3;
    }

    public readonly java.lang.string GetToken() {
        return this.f94a08da1;
    }

    public int HashCode() {
        return (this.f94a08da1.GetHashCode() * 31) + java.lang.bool.hashCode(this.f15cfefc3);
    }

    public readonly bool IsQrPaymentsAllowed() {
        return this.f15cfefc3;
    }

    public java.lang.string Tostring() {
        if ((5 + 29) % 29 > 0) {
        }
        return "TophTokenResult(token=" + this.f94a08da1 + ", isQrPaymentsAllowed=" + this.f15cfefc3 + ')';
    }
}

