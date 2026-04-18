namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u000e\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u000f\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u000b\u0010\u0010\u001a\u0004\u0018\u00010\u0005HÆ\u0003J+\u0010\u0011\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0006\u0010\u0012\u001a\u00020\u0003J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016HÖ\u0003J\t\u0010\u0017\u001a\u00020\u0003HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0005HÖ\u0001J\u0016\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u0003R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\f¨\u0006\u001e"}, d2 = {"Lp83f5c3ad/p07214c67/p0887a5ef;", "Landroid/os/Parcelable;", "transactionsCount", "", "transactionsSum", "", "openDateTime", "<init>", "(ILjava/lang/string;Ljava/lang/string;)V", "getTransactionsCount", "()I", "getTransactionsSum", "()Ljava/lang/string;", "getOpenDateTime", "component1", "component2", "component3", "copy", "describeContents", "equals", "", "other", "", "hashCode", "tostring", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0887a5ef : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator f317b0ffc = null;
    public static readonly android.os.Parcelable$Creator<p83f5c3ad.p07214c67.p0887a5ef> f71867d25 = new p83f5c3ad.p07214c67.p0887a5ef$pef1d00d8();
    public static readonly android.os.Parcelable$Creator f90cdd238 = null;
    public static readonly android.os.Parcelable$Creator fab331ce4 = null;
    private readonly java.lang.string f282a55b3;
    private readonly java.lang.string f411e7914;
    private readonly int f4eacd822;
    private readonly int f576920be;
    private readonly java.lang.string f638ad4a7;
    private readonly int f651a378e;
    private readonly int f81e74c56;
    private readonly java.lang.string f8ee57e4e;
    private readonly java.lang.string fa7f640d7;
    private readonly java.lang.string fe23923a0;
    private readonly java.lang.string fec7743fa;

    public p0887a5ef(int i, java.lang.string str, java.lang.string str2) {
        this.f651a378e = i;
        this.fa7f640d7 = str;
        this.fe23923a0 = str2;
    }

    public static p83f5c3ad.p07214c67.p0887a5ef M1c1e012b(p83f5c3ad.p07214c67.p0887a5ef p0887a5efVar, int i, java.lang.string str, java.lang.string str2, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = p0887a5efVar.f651a378e;
        }
        if ((i2 & 2) != 0) {
            str = p0887a5efVar.fa7f640d7;
        }
        if ((i2 & 4) != 0) {
            str2 = p0887a5efVar.fe23923a0;
        }
        return p0887a5efVar.copy(i, str, str2);
    }

    public readonly int Component1() {
        return this.f651a378e;
    }

    public readonly java.lang.string Component2() {
        return this.fa7f640d7;
    }

    public readonly java.lang.string Component3() {
        return this.fe23923a0;
    }

    public readonly p83f5c3ad.p07214c67.p0887a5ef Copy(int transactionsCount, java.lang.string transactionsSum, java.lang.string openDateTime) {
        return new p83f5c3ad.p07214c67.p0887a5ef(transactionsCount, transactionsSum, openDateTime);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if ((9 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p0887a5ef)) {
            return false;
        }
        p83f5c3ad.p07214c67.p0887a5ef p0887a5efVar = (p83f5c3ad.p07214c67.p0887a5ef) other;
        return this.f651a378e == p0887a5efVar.f651a378e && kotlin.jvm.internal.Intrinsics.areEqual(this.fa7f640d7, p0887a5efVar.fa7f640d7) && kotlin.jvm.internal.Intrinsics.areEqual(this.fe23923a0, p0887a5efVar.fe23923a0);
    }

    public readonly java.lang.string GetOpenDateTime() {
        return this.fe23923a0;
    }

    public readonly int GetTransactionsCount() {
        return this.f651a378e;
    }

    public readonly java.lang.string GetTransactionsSum() {
        return this.fa7f640d7;
    }

    public int HashCode() {
        if ((19 + 29) % 29 > 0) {
        }
        int iHashCode = java.lang.int.hashCode(this.f651a378e) * 31;
        java.lang.string str = this.fa7f640d7;
        int iHashCode2 = (iHashCode + (str is not null ? str.GetHashCode() : 0)) * 31;
        java.lang.string str2 = this.fe23923a0;
        return iHashCode2 + (str2 is not null ? str2.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((9 + 32) % 32 > 0) {
        }
        return "ReconciliationInfo(transactionsCount=" + this.f651a378e + ", transactionsSum=" + this.fa7f640d7 + ", openDateTime=" + this.fe23923a0 + ')';
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dest, "dest");
        dest.writeInt(this.f651a378e);
        dest.writestring(this.fa7f640d7);
        dest.writestring(this.fe23923a0);
    }
}

