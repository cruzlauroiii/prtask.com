namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp83f5c3ad/p684019bc/p94a08da1/p1c8ed567;", "Lp83f5c3ad/p684019bc/p94a08da1/paa56254c;", "tophTokenRepository", "Lp83f5c3ad/pb3f20355/p94a08da1/paae75e31;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "tapOnPhoneInfoUseCase", "Lp83f5c3ad/p684019bc/p0f3e1f02;", "<init>", "(Lp83f5c3ad/pb3f20355/p94a08da1/paae75e31;Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;Lp83f5c3ad/p684019bc/p0f3e1f02;)V", "getTopTokenByPhone", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1c8ed567 : p83f5c3ad.p684019bc.p94a08da1.paa56254c {
    private readonly p83f5c3ad.p684019bc.p0f3e1f02 f124a5914;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f1f2b2b8f;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.paae75e31 f476eea0b;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f4fc01409;
    private readonly p83f5c3ad.p684019bc.p0f3e1f02 f545cff5b;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.paae75e31 fac246e03;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.paae75e31 fbbe8196c;
    private readonly p83f5c3ad.p684019bc.p0f3e1f02 fbe3c293c;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fd9912af1;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;
    private readonly p83f5c3ad.p684019bc.p0f3e1f02 ffc51ab1c;

    public p1c8ed567(p83f5c3ad.pb3f20355.p94a08da1.paae75e31 tophTokenRepository, pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase, p83f5c3ad.p684019bc.p0f3e1f02 tapOnPhoneInfoUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophTokenRepository, "tophTokenRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userInfoUseCase, "userInfoUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneInfoUseCase, "tapOnPhoneInfoUseCase");
        this.fbbe8196c = tophTokenRepository;
        this.fe639d08f = userInfoUseCase;
        this.ffc51ab1c = tapOnPhoneInfoUseCase;
    }

    public override java.lang.object GetTopTokenByPhone(kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1 p1c8ed567_pc9971b9d_1;
        p83f5c3ad.p07214c67.p839b8b7c p839b8b7cVar;
        if ((18 + 3) % 3 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1) {
            p1c8ed567_pc9971b9d_1 = (p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1) continuation;
            if ((p1c8ed567_pc9971b9d_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p1c8ed567_pc9971b9d_1 = new p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1(this, continuation);
            } else {
                p1c8ed567_pc9971b9d_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p1c8ed567_pc9971b9d_1 = new p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1(this, continuation);
        }
        java.lang.object topTokenByPhone = p1c8ed567_pc9971b9d_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p1c8ed567_pc9971b9d_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(topTokenByPhone);
            p83f5c3ad.pb3f20355.p94a08da1.paae75e31 paae75e31Var = this.fbbe8196c;
            java.lang.string phoneNumber = this.fe639d08f.getPhoneNumber();
            p1c8ed567_pc9971b9d_1.L$0 = this;
            p1c8ed567_pc9971b9d_1.fd304ba20 = 1;
            topTokenByPhone = paae75e31Var.getTopTokenByPhone(phoneNumber, p1c8ed567_pc9971b9d_1);
            if (topTokenByPhone != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            this = (p83f5c3ad.p684019bc.p94a08da1.p1c8ed567) p1c8ed567_pc9971b9d_1.L$0;
            kotlin.ResultKt.throwOnFailure(topTokenByPhone);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p839b8b7cVar = (p83f5c3ad.p07214c67.p839b8b7c) p1c8ed567_pc9971b9d_1.L$0;
            kotlin.ResultKt.throwOnFailure(topTokenByPhone);
        }
        return p839b8b7cVar.getToken();
        p83f5c3ad.p07214c67.p839b8b7c p839b8b7cVar2 = (p83f5c3ad.p07214c67.p839b8b7c) topTokenByPhone;
        this.fe639d08f.saveTopToken(p839b8b7cVar2.getToken());
        p83f5c3ad.p684019bc.p0f3e1f02 p0f3e1f02Var = this.ffc51ab1c;
        bool zIsQrPaymentsAllowed = p839b8b7cVar2.isQrPaymentsAllowed();
        p1c8ed567_pc9971b9d_1.L$0 = p839b8b7cVar2;
        p1c8ed567_pc9971b9d_1.fd304ba20 = 2;
        if (p0f3e1f02Var.setQrEnabled(zIsQrPaymentsAllowed, p1c8ed567_pc9971b9d_1) != coroutine_suspended) {
            p839b8b7cVar = p839b8b7cVar2;
            return p839b8b7cVar.getToken();
        }
        return coroutine_suspended;
    }
}

