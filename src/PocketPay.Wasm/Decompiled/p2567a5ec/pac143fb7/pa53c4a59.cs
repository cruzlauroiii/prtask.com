namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp2567a5ec/pac143fb7/pa53c4a59;", "Lp2567a5ec/pac143fb7/p0f66185f;", "lkTokenRepository", "Lp2567a5ec/pb3f20355/pdf8464c8;", "<init>", "(Lp2567a5ec/pb3f20355/pdf8464c8;)V", "getToken", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-web-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa53c4a59 : p2567a5ec.pac143fb7.p0f66185f {
    private readonly p2567a5ec.pb3f20355.pdf8464c8 f31562f49;
    private readonly p2567a5ec.pb3f20355.pdf8464c8 f62b50bae;
    private readonly p2567a5ec.pb3f20355.pdf8464c8 f83104f19;
    private readonly p2567a5ec.pb3f20355.pdf8464c8 fd18a9971;

    public pa53c4a59(p2567a5ec.pb3f20355.pdf8464c8 lkTokenRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lkTokenRepository, "lkTokenRepository");
        this.fd18a9971 = lkTokenRepository;
    }

    public override java.lang.object GetToken(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return this.fd18a9971.getToken(continuation);
    }
}

