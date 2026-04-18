namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp2e5d8aa3/pad5f82e8/pac143fb7/pe8418d1d/pae09dfc9;", "Lp2e5d8aa3/pe8418d1d/pac143fb7/pbdabceb1;", "verifyRepository", "Lp2e5d8aa3/pe8418d1d/pb3f20355/p9057c15e;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "<init>", "(Lp2e5d8aa3/pe8418d1d/pb3f20355/p9057c15e;Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;)V", "getVerifyCode", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pae09dfc9 : p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 {
    private readonly p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e f227ac695;
    private readonly p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e f3fc6120b;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f3fc86495;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f4ba74ee5;
    private readonly p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e f7c646874;
    private readonly p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e fb863096f;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;

    public pae09dfc9(p2e5d8aa3.pe8418d1d.pb3f20355.p9057c15e verifyRepository, pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(verifyRepository, "verifyRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userInfoUseCase, "userInfoUseCase");
        this.fb863096f = verifyRepository;
        this.fe639d08f = userInfoUseCase;
    }

    public override java.lang.object GetVerifyCode(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return this.fb863096f.getVerifyCode(this.fe639d08f.getUserId(), continuation);
    }
}

