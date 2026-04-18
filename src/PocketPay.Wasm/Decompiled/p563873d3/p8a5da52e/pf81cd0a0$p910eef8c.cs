namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp563873d3/p8a5da52e/pf81cd0a0$p910eef8c;", "", "<init>", "()V", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideRegistrationDeviceApi", "Lp563873d3/p8a5da52e/pf81cd0a0;", "tokenInterceptor", "Lp8d777f38/p8a5da52e/p0ee05ccd;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf81cd0a0$p910eef8c {
    static readonly p563873d3.p8a5da52e.pf81cd0a0$p910eef8c $$INSTANCE = new p563873d3.p8a5da52e.pf81cd0a0$p910eef8c();
    private static readonly long f18ee4865 = 30;
    private static readonly long f1ea2a20e = 30;
    private static readonly long f8954a50b = 30;
    private static readonly long fd0cb7ac7 = 30;
    private static readonly long fe09eeb09 = 30;

    private pf81cd0a0$p910eef8c() {
    }

    public readonly p563873d3.p8a5da52e.pf81cd0a0 ProvideRegistrationDeviceApi(p8d777f38.p8a5da52e.p0ee05ccd tokenInterceptor, p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository) {
        if ((18 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tokenInterceptor, "tokenInterceptor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(new p7ddcfee1.p1cda7fcc$p2bd4a59b().addInterceptor(new p7ddcfee1.pad8a2265.pe0f62c28(null, 1, null).setLevel(p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f786329b3)).addInterceptor(tokenInterceptor).callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create(new com.google.gson.GsonBuilder().serializeNulls().create())).baseUrl(urlConfigRepository.getBaseUrl()).build().create(p563873d3.p8a5da52e.pf81cd0a0.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p563873d3.p8a5da52e.pf81cd0a0) objCreate;
    }
}

