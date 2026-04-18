namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001e\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0096@¢\u0006\u0002\u0010\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpa912a94d/pac143fb7/p318e397f;", "Lpa912a94d/pac143fb7/p3f4efdf7;", "statisticsRepository", "Lpa912a94d/pb3f20355/p7038e93e;", "<init>", "(Lpa912a94d/pb3f20355/p7038e93e;)V", "getStatisticInfo", "", "Lpa912a94d/pf5e638cc/pa92065b1;", "filter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "(Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p318e397f : pa912a94d.pac143fb7.p3f4efdf7 {
    private readonly pa912a94d.pb3f20355.p7038e93e f0b7758f0;
    private readonly pa912a94d.pb3f20355.p7038e93e f4017f883;
    private readonly pa912a94d.pb3f20355.p7038e93e f91bc0ec3;
    private readonly pa912a94d.pb3f20355.p7038e93e f921567a8;
    private readonly pa912a94d.pb3f20355.p7038e93e fd9537682;

    public p318e397f(pa912a94d.pb3f20355.p7038e93e statisticsRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statisticsRepository, "statisticsRepository");
        this.f921567a8 = statisticsRepository;
    }

    public override java.lang.object GetStatisticInfo(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar, kotlin.coroutines.Continuation<? super java.util.List<pa912a94d.pf5e638cc.pa92065b1>> continuation) {
        return this.f921567a8.getStatisticInfo(pd7778d0cVar, continuation);
    }
}

