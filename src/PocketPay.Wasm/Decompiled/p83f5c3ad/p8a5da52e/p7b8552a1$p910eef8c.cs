namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u001f\u0010\b\u001a\u00020\t2\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b\"\u00020\f¢\u0006\u0002\u0010\rR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp83f5c3ad/p8a5da52e/p7b8552a1$p910eef8c;", "", "<init>", "()V", "BASE_Uri", "", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideTophOrderApi", "Lp83f5c3ad/p8a5da52e/p7b8552a1;", "listInterceptors", "", "Lp7ddcfee1/p06050a91;", "([Lp7ddcfee1/p06050a91;)Lp83f5c3ad/p8a5da52e/p7b8552a1;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7b8552a1$p910eef8c {
    private static readonly long f18ee4865 = 30;
    private static readonly java.lang.string f6f1c3ca8 = null;
    private static readonly long f846c75e3 = 30;
    private static readonly long fa044d265 = 30;
    private static readonly long fbf30b209 = 30;
    private static readonly java.lang.string fda393e3e = null;
    private static readonly long fe20d7c17 = 30;
    private static readonly java.lang.string f0bc6479c = com.decryptstringmanager.Decryptstring.decryptstring("a096a633d11b5f779293df6db033165940325565ab636ddc56535ac33ccf6a689df0aa602d9cbc2a258816c761a110be2cb314f4dc8a6b0d1d54b37ed0ea552d4e5eafbb7a7af276d452ed");
    static readonly p83f5c3ad.p8a5da52e.p7b8552a1$p910eef8c $$INSTANCE = new p83f5c3ad.p8a5da52e.p7b8552a1$p910eef8c();

    private p7b8552a1$p910eef8c() {
    }

    public readonly p83f5c3ad.p8a5da52e.p7b8552a1 ProvideTophOrderApi(p7ddcfee1.p06050a91... listInterceptors) {
        if ((10 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listInterceptors, "listInterceptors");
        p7ddcfee1.p1cda7fcc$p2bd4a59b p1cda7fcc_p2bd4a59b = new p7ddcfee1.p1cda7fcc$p2bd4a59b();
        for (p7ddcfee1.p06050a91 p06050a91Var : listInterceptors) {
            p1cda7fcc_p2bd4a59b.addInterceptor(p06050a91Var);
        }
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(p1cda7fcc_p2bd4a59b.callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create()).baseUrl(com.decryptstringmanager.Decryptstring.decryptstring("62948502bcd121100d6f33f4a13109760adcb4370557de058652fc0b9003c9a07269522193423c40d697641e3b2e037f0759ca114941f7d8091be404933f0e8eb6e4ec6823335ec363a4a4")).build().create(p83f5c3ad.p8a5da52e.p7b8552a1.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p83f5c3ad.p8a5da52e.p7b8552a1) objCreate;
    }
}

