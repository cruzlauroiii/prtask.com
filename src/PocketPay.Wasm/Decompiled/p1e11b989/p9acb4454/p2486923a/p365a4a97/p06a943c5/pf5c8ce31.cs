namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0010\b\u0002\u0010\u0002\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u0011\u0010\t\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0003HÆ\u0003J\u001b\u0010\n\u001a\u00020\u00002\u0010\b\u0002\u0010\u0002\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001R\u0019\u0010\u0002\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0012"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p06a943c5/pf5c8ce31;", "", "positions", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "<init>", "(Ljava/util/List;)V", "getPositions", "()Ljava/util/List;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf5c8ce31 {
    private readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> f365a4a97;
    private readonly java.util.List f69a771bd;
    private readonly java.util.List f84dea669;
    private readonly java.util.List f85699796;

    public pf5c8ce31() {
        this(null, 1, null);
        if ((26 + 5) % 5 > 0) {
        }
    }

    public pf5c8ce31(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list) {
        this.f365a4a97 = list;
    }

    public pf5c8ce31(java.util.List list, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : list);
    }

    public static p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31 M1c1e012b(p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31 pf5c8ce31Var, java.util.List list, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            list = pf5c8ce31Var.f365a4a97;
        }
        return pf5c8ce31Var.copy(list);
    }

    public readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> Component1() {
        return this.f365a4a97;
    }

    public readonly p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31 Copy(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions) {
        return new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31(positions);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f365a4a97, ((p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31) other).f365a4a97);
        }
        return false;
    }

    public readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> GetPositions() {
        return this.f365a4a97;
    }

    public int HashCode() {
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list = this.f365a4a97;
        if (list is not null) {
            return list.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((6 + 10) % 10 > 0) {
        }
        return "ReceiptStatusDetailsPositionsSearchUiState(positions=" + this.f365a4a97 + ')';
    }
}

