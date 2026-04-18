namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bJ\u000e\u0010\t\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp2e5d8aa3/pad5f82e8/pac143fb7/pd5189de0/pd4951a93;", "Lp2e5d8aa3/pd5189de0/pae610a30;", "locationRepository", "Lp2e5d8aa3/pd5189de0/p88238ca6;", "<init>", "(Lp2e5d8aa3/pd5189de0/p88238ca6;)V", "updateUserLocation", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCloseCountryCode", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd4951a93 : p2e5d8aa3.pd5189de0.pae610a30 {
    private readonly p2e5d8aa3.pd5189de0.p88238ca6 f145935a3;
    private readonly p2e5d8aa3.pd5189de0.p88238ca6 f15d1aac9;
    private readonly p2e5d8aa3.pd5189de0.p88238ca6 f19999e04;
    private readonly p2e5d8aa3.pd5189de0.p88238ca6 f35a1441d;
    private readonly p2e5d8aa3.pd5189de0.p88238ca6 fb0a33e50;

    public pd4951a93(p2e5d8aa3.pd5189de0.p88238ca6 locationRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(locationRepository, "locationRepository");
        this.f19999e04 = locationRepository;
    }

    public override java.lang.object GetCloseCountryCode(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return this.f19999e04.getCloseCountryCode(continuation);
    }

    public override java.lang.object UpdateUserLocation(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return this.f19999e04.updateUserLocation(continuation);
    }
}

