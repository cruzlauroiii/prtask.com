namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\nR\u0011\u0010\u000e\u001a\u00020\u000f8F¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0012"}, d2 = {"Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/p0ae043d5;", "", "phoneState", "Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;", "fioState", "innState", "regionState", "<init>", "(Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;)V", "getPhoneState", "()Lp83f5c3ad/p2486923a/p70a17ffa/p76ea0beb/pec3651a4;", "getFioState", "getInnState", "getRegionState", "formIsValid", "", "getFormIsValid", "()Z", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0ae043d5 {
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f069f58ea;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f185358e2;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f26233fb4;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f4f319ec4;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f679dc73f;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f6f27b0e4;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 f83b65b99;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fa6a0a509;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fb6ff6bfb;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fb8264c15;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fbf57cce6;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fc1797d58;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fe1479b3c;
    private readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fed8f7f3c;

    public p0ae043d5(p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 phoneState, p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 fioState, p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 innState, p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 regionState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneState, "phoneState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fioState, "fioState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(innState, "innState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(regionState, "regionState");
        this.fe1479b3c = phoneState;
        this.fb6ff6bfb = fioState;
        this.f83b65b99 = innState;
        this.f185358e2 = regionState;
    }

    public readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 GetFioState() {
        return this.fb6ff6bfb;
    }

    public readonly bool GetFormIsValid() {
        return (this.fe1479b3c is p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4$p3ac705f2) && (this.fb6ff6bfb is p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4$p3ac705f2) && (this.f83b65b99 is p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4$p3ac705f2) && (this.f185358e2 is p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4$p3ac705f2);
    }

    public readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 GetInnState() {
        return this.f83b65b99;
    }

    public readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 GetPhoneState() {
        return this.fe1479b3c;
    }

    public readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.pec3651a4 GetRegionState() {
        return this.f185358e2;
    }
}

