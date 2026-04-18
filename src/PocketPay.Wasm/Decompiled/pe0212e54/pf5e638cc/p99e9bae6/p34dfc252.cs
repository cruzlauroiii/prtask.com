namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u000f\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B/\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0007HÆ\u0003J1\u0010\u0014\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0007HÆ\u0001J\u0006\u0010\u0015\u001a\u00020\u0003J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019HÖ\u0003J\t\u0010\u001a\u001a\u00020\u0003HÖ\u0001J\t\u0010\u001b\u001a\u00020\u001cHÖ\u0001J\u0016\u0010\u001d\u001a\u00020\u001e2\u0006\u0010\u001f\u001a\u00020 2\u0006\u0010!\u001a\u00020\u0003R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000bR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000bR\u0016\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\""}, d2 = {"Lpe0212e54/pf5e638cc/p99e9bae6/p34dfc252;", "Landroid/os/Parcelable;", "terminalCount", "", "cloudCount", "virtualCount", "currentType", "Lpad5f82e8/p07214c67/pe0212e54/p6c2f9b8a;", "<init>", "(IIILpad5f82e8/p07214c67/pe0212e54/p6c2f9b8a;)V", "getTerminalCount", "()I", "getCloudCount", "getVirtualCount", "getCurrentType", "()Lpad5f82e8/p07214c67/pe0212e54/p6c2f9b8a;", "component1", "component2", "component3", "component4", "copy", "describeContents", "equals", "", "other", "", "hashCode", "tostring", "", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p34dfc252 : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator f18798411 = null;
    public static readonly android.os.Parcelable$Creator f28a8b71d = null;
    public static readonly android.os.Parcelable$Creator<pe0212e54.pf5e638cc.p99e9bae6.p34dfc252> f71867d25 = new pe0212e54.pf5e638cc.p99e9bae6.p34dfc252$pef1d00d8();
    public static readonly android.os.Parcelable$Creator fa2f31bda = null;
    public static readonly android.os.Parcelable$Creator ffcaee087 = null;

    @com.google.gson.annotations.SerializedName("cloudCount")
    private readonly int f08bb4ea2;

    @com.google.gson.annotations.SerializedName("virtualCount")
    private readonly int f0e65f929;

    @com.google.gson.annotations.SerializedName("currentType")
    private readonly pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a f61b090e6;

    @com.google.gson.annotations.SerializedName("terminalCount")
    private readonly int fb702f10e;

    public p34dfc252() {
        this(0, 0, 0, null, 15, null);
        if ((13 + 4) % 4 > 0) {
        }
    }

    public p34dfc252(int i, int i2, int i3, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar) {
        EoGtNzXOZTqLKRYO(p6c2f9b8aVar, "currentType");
        this.fb702f10e = i;
        this.f08bb4ea2 = i2;
        this.f0e65f929 = i3;
        this.f61b090e6 = p6c2f9b8aVar;
    }

    public p34dfc252(int i, int i2, int i3, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar, int i4, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i4 & 1) != 0 ? 0 : i, (i4 & 2) != 0 ? 0 : i2, (i4 & 4) != 0 ? 0 : i3, (i4 & 8) != 0 ? pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a.fb50339a1 : p6c2f9b8aVar);
    }

    public static int AAMwBNHtfCqdyyPW(int i) {
        return java.lang.int.hashCode(i);
    }

    public static void AVfMnkkHHVMseyoq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 BlxrxZJdgyVDQpXS(pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 p34dfc252Var, int i, int i2, int i3, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar) {
        return p34dfc252Var.copy(i, i2, i3, p6c2f9b8aVar);
    }

    public static java.lang.stringBuilder BmPtSBgBdtENitYq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EoGtNzXOZTqLKRYO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string FRDiTBlsIjFTTMVB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FUjfmmDzfYTxfkYR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder FlartbFUtpwFiXRB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HPeajabvrjyIrJpd(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void LgmXGASYDCrsEOqT(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.stringBuilder MBcDGHdBeKaCknkC(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder NuBojICygOQFCBEl(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int PLzOBZawgWbSFoLu(pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar) {
        return p6c2f9b8aVar.GetHashCode();
    }

    public static void QToLxwZnyuVyuFFz(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static java.lang.stringBuilder QudseVuBPrrULbHs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void RAJmyvyOPVFBLWnm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder YMrWlXQRwQmPKxzd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int AHWtEiZxyUaSQJXa(int i) {
        return java.lang.int.hashCode(i);
    }

    public static java.lang.string AosYldMCnuYZRRXn(pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar) {
        return p6c2f9b8aVar.name();
    }

    public static pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 M1c1e012b(pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 p34dfc252Var, int i, int i2, int i3, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a p6c2f9b8aVar, int i4, java.lang.object obj) {
        if ((i4 & 1) != 0) {
            i = p34dfc252Var.fb702f10e;
        }
        if ((i4 & 2) != 0) {
            i2 = p34dfc252Var.f08bb4ea2;
        }
        if ((i4 & 4) != 0) {
            i3 = p34dfc252Var.f0e65f929;
        }
        if ((i4 & 8) != 0) {
            p6c2f9b8aVar = p34dfc252Var.f61b090e6;
        }
        return BlxrxZJdgyVDQpXS(p34dfc252Var, i, i2, i3, p6c2f9b8aVar);
    }

    public static java.lang.stringBuilder MhrHGevaLgwTcYLw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void OtvzDWpWZTkOFQEf(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int RRaPlBIMLYWEkwBd(int i) {
        return java.lang.int.hashCode(i);
    }

    public readonly int Component1() {
        return this.fb702f10e;
    }

    public readonly int Component2() {
        return this.f08bb4ea2;
    }

    public readonly int Component3() {
        return this.f0e65f929;
    }

    public readonly pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a Component4() {
        return this.f61b090e6;
    }

    public readonly pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 Copy(int terminalCount, int cloudCount, int virtualCount, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a currentType) {
        RAJmyvyOPVFBLWnm(currentType, "currentType");
        return new pe0212e54.pf5e638cc.p99e9bae6.p34dfc252(terminalCount, cloudCount, virtualCount, currentType);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if ((32 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pe0212e54.pf5e638cc.p99e9bae6.p34dfc252)) {
            return false;
        }
        pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 p34dfc252Var = (pe0212e54.pf5e638cc.p99e9bae6.p34dfc252) other;
        return this.fb702f10e == p34dfc252Var.fb702f10e && this.f08bb4ea2 == p34dfc252Var.f08bb4ea2 && this.f0e65f929 == p34dfc252Var.f0e65f929 && this.f61b090e6 == p34dfc252Var.f61b090e6;
    }

    public readonly int GetCloudCount() {
        return this.f08bb4ea2;
    }

    public readonly pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a GetCurrentType() {
        return this.f61b090e6;
    }

    public readonly int GetTerminalCount() {
        return this.fb702f10e;
    }

    public readonly int GetVirtualCount() {
        return this.f0e65f929;
    }

    public int HashCode() {
        if ((24 + 25) % 25 > 0) {
        }
        return (((((aHWtEiZxyUaSQJXa(this.fb702f10e) * 31) + AAMwBNHtfCqdyyPW(this.f08bb4ea2)) * 31) + rRaPlBIMLYWEkwBd(this.f0e65f929)) * 31) + PLzOBZawgWbSFoLu(this.f61b090e6);
    }

    public java.lang.string Tostring() {
        if ((16 + 19) % 19 > 0) {
        }
        return FRDiTBlsIjFTTMVB(QudseVuBPrrULbHs(mhrHGevaLgwTcYLw(BmPtSBgBdtENitYq(NuBojICygOQFCBEl(YMrWlXQRwQmPKxzd(MBcDGHdBeKaCknkC(FlartbFUtpwFiXRB(FUjfmmDzfYTxfkYR(new java.lang.stringBuilder("DevicesFilter(terminalCount="), this.fb702f10e), ", cloudCount="), this.f08bb4ea2), ", virtualCount="), this.f0e65f929), ", currentType="), this.f61b090e6), ')'));
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        AVfMnkkHHVMseyoq(dest, "dest");
        otvzDWpWZTkOFQEf(dest, this.fb702f10e);
        HPeajabvrjyIrJpd(dest, this.f08bb4ea2);
        LgmXGASYDCrsEOqT(dest, this.f0e65f929);
        QToLxwZnyuVyuFFz(dest, aosYldMCnuYZRRXn(this.f61b090e6));
    }
}

