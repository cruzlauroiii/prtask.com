namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp2567a5ec/p8a5da52e/p2e0b51db$p910eef8c;", "", "<init>", "()V", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideLKTokenApi", "Lp2567a5ec/p8a5da52e/p2e0b51db;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "feature-web-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2e0b51db$p910eef8c {
    static readonly p2567a5ec.p8a5da52e.p2e0b51db$p910eef8c $$INSTANCE = new p2567a5ec.p8a5da52e.p2e0b51db$p910eef8c();
    private static readonly long f18ee4865 = 30;
    private static readonly long fcaba0ea6 = 30;

    private p2e0b51db$p910eef8c() {
    }

    public readonly p2567a5ec.p8a5da52e.p2e0b51db ProvideLKTokenApi(p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository) {
        if ((10 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(new p7ddcfee1.p1cda7fcc$p2bd4a59b().callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create()).baseUrl(urlConfigRepository.getBaseUrl()).build().create(p2567a5ec.p8a5da52e.p2e0b51db.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p2567a5ec.p8a5da52e.p2e0b51db) objCreate;
    }
}

