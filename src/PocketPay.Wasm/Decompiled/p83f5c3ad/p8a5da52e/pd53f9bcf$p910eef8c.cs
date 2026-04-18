namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J'\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b\"\u00020\f¢\u0006\u0002\u0010\rR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp83f5c3ad/p8a5da52e/pd53f9bcf$p910eef8c;", "", "<init>", "()V", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideTophTokenApi", "Lp83f5c3ad/p8a5da52e/pd53f9bcf;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "listInterceptors", "", "Lp7ddcfee1/p06050a91;", "(Lp8d777f38/pb3f20355/pea436584/pb0a8252a;[Lp7ddcfee1/p06050a91;)Lp83f5c3ad/p8a5da52e/pd53f9bcf;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd53f9bcf$p910eef8c {
    static readonly p83f5c3ad.p8a5da52e.pd53f9bcf$p910eef8c $$INSTANCE = new p83f5c3ad.p8a5da52e.pd53f9bcf$p910eef8c();
    private static readonly long f18ee4865 = 30;
    private static readonly long fd8ee6778 = 30;
    private static readonly long fee0e82a5 = 30;

    private pd53f9bcf$p910eef8c() {
    }

    public readonly p83f5c3ad.p8a5da52e.pd53f9bcf ProvideTophTokenApi(p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository, p7ddcfee1.p06050a91... listInterceptors) {
        if ((3 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listInterceptors, "listInterceptors");
        p7ddcfee1.p1cda7fcc$p2bd4a59b p1cda7fcc_p2bd4a59b = new p7ddcfee1.p1cda7fcc$p2bd4a59b();
        for (p7ddcfee1.p06050a91 p06050a91Var : listInterceptors) {
            p1cda7fcc_p2bd4a59b.addInterceptor(p06050a91Var);
        }
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(p1cda7fcc_p2bd4a59b.callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create()).baseUrl(urlConfigRepository.getBaseUrl()).build().create(p83f5c3ad.p8a5da52e.pd53f9bcf.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p83f5c3ad.p8a5da52e.pd53f9bcf) objCreate;
    }
}

