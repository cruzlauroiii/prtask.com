namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\r\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0005HÆ\u0003J'\u0010\u0011\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0005HÆ\u0001J\u0006\u0010\u0012\u001a\u00020\u0013J\u0013\u0010\u0014\u001a\u00020\u00152\b\u0010\u0016\u001a\u0004\u0018\u00010\u0017HÖ\u0003J\t\u0010\u0018\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0019\u001a\u00020\u0005HÖ\u0001J\u0016\u0010\u001a\u001a\u00020\u001b2\u0006\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u001e\u001a\u00020\u0013R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0006\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\f¨\u0006\u001f"}, d2 = {"Lp83f5c3ad/p07214c67/pbc0ca418;", "Landroid/os/Parcelable;", "balance", "", "currency", "", "lastPan4Digits", "<init>", "(JLjava/lang/string;Ljava/lang/string;)V", "getBalance", "()J", "getCurrency", "()Ljava/lang/string;", "getLastPan4Digits", "component1", "component2", "component3", "copy", "describeContents", "", "equals", "", "other", "", "hashCode", "tostring", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbc0ca418 : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator f32ff2a16 = null;
    public static readonly android.os.Parcelable$Creator<p83f5c3ad.p07214c67.pbc0ca418> f71867d25 = new p83f5c3ad.p07214c67.pbc0ca418$pef1d00d8();
    public static readonly android.os.Parcelable$Creator f89f5ab82 = null;
    public static readonly android.os.Parcelable$Creator fe0bd3165 = null;
    public static readonly android.os.Parcelable$Creator fe844e3ba = null;
    private readonly long f078ba7d3;
    private readonly java.lang.string f1af03898;
    private readonly long f2069ca79;
    private readonly java.lang.string f2c2011ba;
    private readonly java.lang.string f586b3b24;
    private readonly java.lang.string f7b8de9e0;
    private readonly long f816304e0;
    private readonly java.lang.string fca3715df;
    private readonly java.lang.string fd1e39477;

    public pbc0ca418(long j, java.lang.string currency, java.lang.string lastPan4Digits) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lastPan4Digits, "lastPan4Digits");
        this.f2069ca79 = j;
        this.f1af03898 = currency;
        this.f586b3b24 = lastPan4Digits;
    }

    public static p83f5c3ad.p07214c67.pbc0ca418 M1c1e012b(p83f5c3ad.p07214c67.pbc0ca418 pbc0ca418Var, long j, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = pbc0ca418Var.f2069ca79;
        }
        if ((i & 2) != 0) {
            str = pbc0ca418Var.f1af03898;
        }
        if ((i & 4) != 0) {
            str2 = pbc0ca418Var.f586b3b24;
        }
        return pbc0ca418Var.copy(j, str, str2);
    }

    public readonly long Component1() {
        if ((6 + 2) % 2 > 0) {
        }
        return this.f2069ca79;
    }

    public readonly java.lang.string Component2() {
        return this.f1af03898;
    }

    public readonly java.lang.string Component3() {
        return this.f586b3b24;
    }

    public readonly p83f5c3ad.p07214c67.pbc0ca418 Copy(long balance, java.lang.string currency, java.lang.string lastPan4Digits) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lastPan4Digits, "lastPan4Digits");
        return new p83f5c3ad.p07214c67.pbc0ca418(balance, currency, lastPan4Digits);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.pbc0ca418)) {
            return false;
        }
        p83f5c3ad.p07214c67.pbc0ca418 pbc0ca418Var = (p83f5c3ad.p07214c67.pbc0ca418) other;
        return this.f2069ca79 == pbc0ca418Var.f2069ca79 && kotlin.jvm.internal.Intrinsics.areEqual(this.f1af03898, pbc0ca418Var.f1af03898) && kotlin.jvm.internal.Intrinsics.areEqual(this.f586b3b24, pbc0ca418Var.f586b3b24);
    }

    public readonly long GetBalance() {
        if ((4 + 30) % 30 > 0) {
        }
        return this.f2069ca79;
    }

    public readonly java.lang.string GetCurrency() {
        return this.f1af03898;
    }

    public readonly java.lang.string GetLastPan4Digits() {
        return this.f586b3b24;
    }

    public int HashCode() {
        if ((20 + 3) % 3 > 0) {
        }
        return (((java.lang.long.hashCode(this.f2069ca79) * 31) + this.f1af03898.GetHashCode()) * 31) + this.f586b3b24.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((17 + 12) % 12 > 0) {
        }
        return "BalanceResponse(balance=" + this.f2069ca79 + ", currency=" + this.f1af03898 + ", lastPan4Digits=" + this.f586b3b24 + ')';
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        if ((7 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dest, "dest");
        dest.writelong(this.f2069ca79);
        dest.writestring(this.f1af03898);
        dest.writestring(this.f586b3b24);
    }
}

