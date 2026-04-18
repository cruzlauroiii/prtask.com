namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u001e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\u00052\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/p2486923a/pcaf9b6b9/p2c3078de$p910eef8c;", "", "<init>", "()V", "COMMON_POSITIVE_KEY", "", "newInstance", "Lp83f5c3ad/p2486923a/pcaf9b6b9/p2c3078de;", "tid", "currency", "reconciliationInfo", "Lp83f5c3ad/p07214c67/p0887a5ef;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2c3078de$p910eef8c {
    private p2c3078de$p910eef8c() {
    }

    public p2c3078de$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de NewInstance(java.lang.string tid, java.lang.string currency, p83f5c3ad.p07214c67.p0887a5ef reconciliationInfo) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tid, "tid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reconciliationInfo, "reconciliationInfo");
        p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de p2c3078deVar = new p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de();
        p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de.mb86a817e(p2c3078deVar, currency);
        p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de.m382a9e9b(p2c3078deVar, tid);
        p83f5c3ad.p2486923a.pcaf9b6b9.p2c3078de.m6b9eecdf(p2c3078deVar, reconciliationInfo);
        return p2c3078deVar;
    }
}

