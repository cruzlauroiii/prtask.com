namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0003J\u0019\u0010\n\u001a\u00020\u00002\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0012"}, d2 = {"Lp83f5c3ad/p2486923a/pcaf9b6b9/p8ab4166c;", "", "qrInfoEvent", "Lpad5f82e8/p07214c67/pa4ecfc70;", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "<init>", "(Lpad5f82e8/p07214c67/pa4ecfc70;)V", "getQrInfoEvent", "()Lpad5f82e8/p07214c67/pa4ecfc70;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8ab4166c {
    private readonly domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae> f4baa7b55;
    private readonly pad5f82e8.p07214c67.pa4ecfc70 f69685d19;

    public p8ab4166c() {
        this(null, 1, null);
        if ((26 + 17) % 17 > 0) {
        }
    }

    public p8ab4166c(domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae> qrInfoEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(qrInfoEvent, "qrInfoEvent");
        this.f4baa7b55 = qrInfoEvent;
    }

    public p8ab4166c(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading() : pa4ecfc70Var);
    }

    public static p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c M1c1e012b(p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c p8ab4166cVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pa4ecfc70Var = p8ab4166cVar.f4baa7b55;
        }
        return p8ab4166cVar.copy(pa4ecfc70Var);
    }

    public readonly domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae> Component1() {
        return this.f4baa7b55;
    }

    public readonly p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c Copy(domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae> qrInfoEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(qrInfoEvent, "qrInfoEvent");
        return new p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c(qrInfoEvent);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f4baa7b55, ((p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c) other).f4baa7b55);
        }
        return false;
    }

    public readonly domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae> GetQrInfoEvent() {
        return this.f4baa7b55;
    }

    public int HashCode() {
        return this.f4baa7b55.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((22 + 27) % 27 > 0) {
        }
        return "TophQrInfoUiState(qrInfoEvent=" + this.f4baa7b55 + ')';
    }
}

