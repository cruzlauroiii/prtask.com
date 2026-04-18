namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0018\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lp4670093c/p07214c67/pd77d5e50/pc0a36d40;", "", "currentPaybackPositionDbEntity", "Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;", "taxDbEntity", "Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;", "<init>", "(Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;)V", "getCurrentPaybackPositionDbEntity", "()Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;", "getTaxDbEntity", "()Lpad5f82e8/p07214c67/pd77d5e50/pf22d65ed;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-payback-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc0a36d40 {
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f3b7d9b65;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f530ac8dc;
    private readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e f8107888b;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed f86b7fcb8;
    private readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e fadff1b5f;
    private readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed fb437fdb9;
    private readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e fdecb686b;

    public pc0a36d40(p4670093c.p07214c67.pd77d5e50.pb1f8808e currentPaybackPositionDbEntity, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentPaybackPositionDbEntity, "currentPaybackPositionDbEntity");
        this.fdecb686b = currentPaybackPositionDbEntity;
        this.f3b7d9b65 = pf22d65edVar;
    }

    public static p4670093c.p07214c67.pd77d5e50.pc0a36d40 M1c1e012b(p4670093c.p07214c67.pd77d5e50.pc0a36d40 pc0a36d40Var, p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pb1f8808eVar = pc0a36d40Var.fdecb686b;
        }
        if ((i & 2) != 0) {
            pf22d65edVar = pc0a36d40Var.f3b7d9b65;
        }
        return pc0a36d40Var.copy(pb1f8808eVar, pf22d65edVar);
    }

    public readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e Component1() {
        return this.fdecb686b;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed Component2() {
        return this.f3b7d9b65;
    }

    public readonly p4670093c.p07214c67.pd77d5e50.pc0a36d40 Copy(p4670093c.p07214c67.pd77d5e50.pb1f8808e currentPaybackPositionDbEntity, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed taxDbEntity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentPaybackPositionDbEntity, "currentPaybackPositionDbEntity");
        return new p4670093c.p07214c67.pd77d5e50.pc0a36d40(currentPaybackPositionDbEntity, taxDbEntity);
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 10) % 10 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4670093c.p07214c67.pd77d5e50.pc0a36d40)) {
            return false;
        }
        p4670093c.p07214c67.pd77d5e50.pc0a36d40 pc0a36d40Var = (p4670093c.p07214c67.pd77d5e50.pc0a36d40) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fdecb686b, pc0a36d40Var.fdecb686b) && kotlin.jvm.internal.Intrinsics.areEqual(this.f3b7d9b65, pc0a36d40Var.f3b7d9b65);
    }

    public readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e GetCurrentPaybackPositionDbEntity() {
        return this.fdecb686b;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.pf22d65ed GetTaxDbEntity() {
        return this.f3b7d9b65;
    }

    public int HashCode() {
        int iHashCode = this.fdecb686b.GetHashCode() * 31;
        pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar = this.f3b7d9b65;
        return iHashCode + (pf22d65edVar is not null ? pf22d65edVar.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((28 + 23) % 23 > 0) {
        }
        return "CurrentPaybackPositionDbData(currentPaybackPositionDbEntity=" + this.fdecb686b + ", taxDbEntity=" + this.f3b7d9b65 + ')';
    }
}

