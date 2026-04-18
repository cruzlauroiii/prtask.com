namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u001f\u0010\b\u001a\u00020\t2\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b\"\u00020\f¢\u0006\u0002\u0010\rR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp83f5c3ad/p8a5da52e/p40de21f4$p910eef8c;", "", "<init>", "()V", "BASE_Uri", "", "CONNECTION_TIMEOUT_IN_SECONDS", "", "provideTophAuthDeviceApi", "Lp83f5c3ad/p8a5da52e/p40de21f4;", "listInterceptors", "", "Lp7ddcfee1/p06050a91;", "([Lp7ddcfee1/p06050a91;)Lp83f5c3ad/p8a5da52e/p40de21f4;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p40de21f4$p910eef8c {
    private static readonly long f18ee4865 = 30;
    private static readonly long f3dbc130c = 30;
    private static readonly java.lang.string f42405375 = null;
    private static readonly java.lang.string f62e00520 = null;
    private static readonly java.lang.string f8701ffd1 = null;
    private static readonly long fc276e24e = 30;
    private static readonly long fd1174bd3 = 30;
    private static readonly java.lang.string fe710ffed = null;
    private static readonly long ffb43e12e = 30;
    private static readonly java.lang.string f0bc6479c = com.decryptstringmanager.Decryptstring.decryptstring("fe4e28c7b12679448d28ade2b6e6b366dc31beb3c7102a3c3dffdabebcafbe604af1b36a0af0a9c27a86bb76264de3e151ef88875f079c67310fec1fa1a1b8d4520f1e");
    static readonly p83f5c3ad.p8a5da52e.p40de21f4$p910eef8c $$INSTANCE = new p83f5c3ad.p8a5da52e.p40de21f4$p910eef8c();

    private p40de21f4$p910eef8c() {
    }

    public readonly p83f5c3ad.p8a5da52e.p40de21f4 ProvideTophAuthDeviceApi(p7ddcfee1.p06050a91... listInterceptors) {
        if ((32 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listInterceptors, "listInterceptors");
        p7ddcfee1.p1cda7fcc$p2bd4a59b p1cda7fcc_p2bd4a59b = new p7ddcfee1.p1cda7fcc$p2bd4a59b();
        for (p7ddcfee1.p06050a91 p06050a91Var : listInterceptors) {
            p1cda7fcc_p2bd4a59b.addInterceptor(p06050a91Var);
        }
        java.lang.object objCreate = new paa20ed97.pb9794896$p2bd4a59b().client(p1cda7fcc_p2bd4a59b.callTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).readTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).writeTimeout(30L, java.util.concurrent.TimeUnit.SECONDS).build()).addConverterFactory(paa20ed97.p0ea7dd4d.p67166080.pae55e461.create()).baseUrl(com.decryptstringmanager.Decryptstring.decryptstring("8ab32d795ee044318f7b130e085850ced8c5160330831ee593bac1b35044985e28e1998ba957645038e0bba640ede7decc8a64699e9e173c82491d217a0c378062ef94")).build().create(p83f5c3ad.p8a5da52e.p40de21f4.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCreate, "create(...)");
        return (p83f5c3ad.p8a5da52e.p40de21f4) objCreate;
    }
}

