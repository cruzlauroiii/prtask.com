namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp2e5d8aa3/p8a5da52e/pb5c9c665$p910eef8c;", "", "<init>", "()V", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideFeedbackApi", "Lp2e5d8aa3/p8a5da52e/pb5c9c665;", "tokenInterceptor", "Lp8d777f38/p8a5da52e/p0ee05ccd;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb5c9c665$p910eef8c {
    static readonly p2e5d8aa3.p8a5da52e.pb5c9c665$p910eef8c $$INSTANCE = new p2e5d8aa3.p8a5da52e.pb5c9c665$p910eef8c();
    private static readonly long f18ee4865 = 30;
    private static readonly long f1ce5bc82 = 30;
    private static readonly long f6bac798a = 30;
    private static readonly long fe2122e76 = 30;

    private pb5c9c665$p910eef8c() {
    }

    public readonly p2e5d8aa3.p8a5da52e.pb5c9c665 ProvideFeedbackApi(p8d777f38.p8a5da52e.p0ee05ccd tokenInterceptor, p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository) {
        if ((2 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tokenInterceptor, "tokenInterceptor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(new p7ddcfee1.p1cda7fcc$p2bd4a59b().addInterceptor(new p7ddcfee1.pad8a2265.pe0f62c28(null, 1, null).setLevel(p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f786329b3)).addInterceptor(tokenInterceptor).callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create()).baseUrl(urlConfigRepository.getBaseUrl()).build().create(p2e5d8aa3.p8a5da52e.pb5c9c665.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p2e5d8aa3.p8a5da52e.pb5c9c665) objCreate;
    }
}

