namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0005HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0015"}, d2 = {"Lp83f5c3ad/p07214c67/p4536d9ae;", "", "activationType", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pdc33845b;", "activationCredentials", "", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pdc33845b;Ljava/lang/string;)V", "getActivationType", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pdc33845b;", "getActivationCredentials", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4536d9ae {
    private readonly java.lang.string f02c520f0;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b f13ffb74e;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b f679a74df;
    private readonly java.lang.string f70930827;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b f885109fe;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b fdbbae706;

    public p4536d9ae(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b activationType, java.lang.string activationCredentials) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activationType, "activationType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activationCredentials, "activationCredentials");
        this.f679a74df = activationType;
        this.f70930827 = activationCredentials;
    }

    public static p83f5c3ad.p07214c67.p4536d9ae M1c1e012b(p83f5c3ad.p07214c67.p4536d9ae p4536d9aeVar, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b pdc33845bVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pdc33845bVar = p4536d9aeVar.f679a74df;
        }
        if ((i & 2) != 0) {
            str = p4536d9aeVar.f70930827;
        }
        return p4536d9aeVar.copy(pdc33845bVar, str);
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b Component1() {
        return this.f679a74df;
    }

    public readonly java.lang.string Component2() {
        return this.f70930827;
    }

    public readonly p83f5c3ad.p07214c67.p4536d9ae Copy(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b activationType, java.lang.string activationCredentials) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activationType, "activationType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activationCredentials, "activationCredentials");
        return new p83f5c3ad.p07214c67.p4536d9ae(activationType, activationCredentials);
    }

    public bool Equals(java.lang.object other) {
        if ((17 + 18) % 18 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p4536d9ae)) {
            return false;
        }
        p83f5c3ad.p07214c67.p4536d9ae p4536d9aeVar = (p83f5c3ad.p07214c67.p4536d9ae) other;
        return this.f679a74df == p4536d9aeVar.f679a74df && kotlin.jvm.internal.Intrinsics.areEqual(this.f70930827, p4536d9aeVar.f70930827);
    }

    public readonly java.lang.string GetActivationCredentials() {
        return this.f70930827;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b GetActivationType() {
        return this.f679a74df;
    }

    public int HashCode() {
        return (this.f679a74df.GetHashCode() * 31) + this.f70930827.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((12 + 31) % 31 > 0) {
        }
        return "ActivationInfo(activationType=" + this.f679a74df + ", activationCredentials=" + this.f70930827 + ')';
    }
}

