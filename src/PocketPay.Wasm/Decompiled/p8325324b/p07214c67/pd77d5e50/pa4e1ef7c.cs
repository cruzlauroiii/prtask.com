namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0018\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lp8325324b/p07214c67/pd77d5e50/pa4e1ef7c;", "", "currentSellPositionDbEntity", "Lp8325324b/p07214c67/pd77d5e50/p0160554c;", "taxDbEntity", "Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;", "<init>", "(Lp8325324b/p07214c67/pd77d5e50/p0160554c;Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;)V", "getCurrentSellPositionDbEntity", "()Lp8325324b/p07214c67/pd77d5e50/p0160554c;", "getTaxDbEntity", "()Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-sell-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa4e1ef7c {
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f2e64bd5a;
    private readonly p8325324b.p07214c67.pd77d5e50.p0160554c f399e7ae0;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f3b7d9b65;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f40180886;
    private readonly p8325324b.p07214c67.pd77d5e50.p0160554c f4094fe83;
    private readonly p8325324b.p07214c67.pd77d5e50.p0160554c f69aa6470;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f985a7bbd;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed fc674c7c3;

    public pa4e1ef7c(p8325324b.p07214c67.pd77d5e50.p0160554c currentSellPositionDbEntity, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentSellPositionDbEntity, "currentSellPositionDbEntity");
        this.f399e7ae0 = currentSellPositionDbEntity;
        this.f3b7d9b65 = pf22d65edVar;
    }

    public static p8325324b.p07214c67.pd77d5e50.pa4e1ef7c M1c1e012b(p8325324b.p07214c67.pd77d5e50.pa4e1ef7c pa4e1ef7cVar, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p0160554cVar = pa4e1ef7cVar.f399e7ae0;
        }
        if ((i & 2) != 0) {
            pf22d65edVar = pa4e1ef7cVar.f3b7d9b65;
        }
        return pa4e1ef7cVar.copy(p0160554cVar, pf22d65edVar);
    }

    public readonly p8325324b.p07214c67.pd77d5e50.p0160554c Component1() {
        return this.f399e7ae0;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed Component2() {
        return this.f3b7d9b65;
    }

    public readonly p8325324b.p07214c67.pd77d5e50.pa4e1ef7c Copy(p8325324b.p07214c67.pd77d5e50.p0160554c currentSellPositionDbEntity, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed taxDbEntity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentSellPositionDbEntity, "currentSellPositionDbEntity");
        return new p8325324b.p07214c67.pd77d5e50.pa4e1ef7c(currentSellPositionDbEntity, taxDbEntity);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p8325324b.p07214c67.pd77d5e50.pa4e1ef7c)) {
            return false;
        }
        p8325324b.p07214c67.pd77d5e50.pa4e1ef7c pa4e1ef7cVar = (p8325324b.p07214c67.pd77d5e50.pa4e1ef7c) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f399e7ae0, pa4e1ef7cVar.f399e7ae0) && kotlin.jvm.internal.Intrinsics.areEqual(this.f3b7d9b65, pa4e1ef7cVar.f3b7d9b65);
    }

    public readonly p8325324b.p07214c67.pd77d5e50.p0160554c GetCurrentSellPositionDbEntity() {
        return this.f399e7ae0;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed GetTaxDbEntity() {
        return this.f3b7d9b65;
    }

    public int HashCode() {
        int iHashCode = this.f399e7ae0.GetHashCode() * 31;
        pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar = this.f3b7d9b65;
        return iHashCode + (pf22d65edVar is not null ? pf22d65edVar.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((9 + 20) % 20 > 0) {
        }
        return "CurrentSellPositionDbData(currentSellPositionDbEntity=" + this.f399e7ae0 + ", taxDbEntity=" + this.f3b7d9b65 + ')';
    }
}

