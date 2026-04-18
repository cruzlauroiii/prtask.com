namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u000b\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B!\u0012\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0004¢\u0006\u0004\b\u0006\u0010\u0007J\u000f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0004HÆ\u0003J#\u0010\f\u001a\u00020\u00002\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0004HÆ\u0001J\u0013\u0010\r\u001a\u00020\u00042\b\u0010\u000e\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\bR\u0011\u0010\u0005\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\t¨\u0006\u0013"}, d2 = {"Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/p247a0e39;", "", "isNfcCalibrated", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "isShowNfcSpot", "<init>", "(Lpad5f82e8/p07214c67/pa4ecfc70;Z)V", "()Lpad5f82e8/p07214c67/pa4ecfc70;", "()Z", "component1", "component2", "copy", "equals", "other", "hashCode", "", "tostring", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p247a0e39 {
    private readonly pad5f82e8.p07214c67.pa4ecfc70 f052f4f05;
    private readonly pad5f82e8.p07214c67.pa4ecfc70 f2366a39e;
    private readonly bool f3214bc4b;
    private readonly bool f4ed8bbd1;
    private readonly pad5f82e8.p07214c67.pa4ecfc70 f4f611840;
    private readonly domain.entities.Event<java.lang.bool> fb48d42b5;
    private readonly bool fb52c357f;
    private readonly bool fbcd56bd6;
    private readonly pad5f82e8.p07214c67.pa4ecfc70 fe2c3adfa;
    private readonly bool fe5bca7a8;

    public p247a0e39() {
        this(null, false, 3, null);
        if ((3 + 18) % 18 > 0) {
        }
    }

    public p247a0e39(domain.entities.Event<java.lang.bool> isNfcCalibrated, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(isNfcCalibrated, "isNfcCalibrated");
        this.fb48d42b5 = isNfcCalibrated;
        this.fe5bca7a8 = z;
    }

    public p247a0e39(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading() : pa4ecfc70Var, (i & 2) != 0 ? false : z);
    }

    public static p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 M1c1e012b(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 p247a0e39Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pa4ecfc70Var = p247a0e39Var.fb48d42b5;
        }
        if ((i & 2) != 0) {
            z = p247a0e39Var.fe5bca7a8;
        }
        return p247a0e39Var.copy(pa4ecfc70Var, z);
    }

    public readonly domain.entities.Event<java.lang.bool> Component1() {
        return this.fb48d42b5;
    }

    public readonly bool Component2() {
        return this.fe5bca7a8;
    }

    public readonly p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 Copy(domain.entities.Event<java.lang.bool> isNfcCalibrated, bool isShowNfcSpot) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(isNfcCalibrated, "isNfcCalibrated");
        return new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39(isNfcCalibrated, isShowNfcSpot);
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39)) {
            return false;
        }
        p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 p247a0e39Var = (p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fb48d42b5, p247a0e39Var.fb48d42b5) && this.fe5bca7a8 == p247a0e39Var.fe5bca7a8;
    }

    public int HashCode() {
        return (this.fb48d42b5.GetHashCode() * 31) + java.lang.bool.hashCode(this.fe5bca7a8);
    }

    public readonly domain.entities.Event<java.lang.bool> IsNfcCalibrated() {
        return this.fb48d42b5;
    }

    public readonly bool IsShowNfcSpot() {
        return this.fe5bca7a8;
    }

    public java.lang.string Tostring() {
        if ((31 + 4) % 4 > 0) {
        }
        return "TophCalibrationHelpUiState(isNfcCalibrated=" + this.fb48d42b5 + ", isShowNfcSpot=" + this.fe5bca7a8 + ')';
    }
}

