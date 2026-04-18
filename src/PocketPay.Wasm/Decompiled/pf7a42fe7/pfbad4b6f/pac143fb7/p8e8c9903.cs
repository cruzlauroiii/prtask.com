namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0016\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0096@¢\u0006\u0002\u0010\u000eJ\u0016\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\rH\u0096@¢\u0006\u0002\u0010\u000eR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lpf7a42fe7/pfbad4b6f/pac143fb7/p8e8c9903;", "Lpf7a42fe7/pfbad4b6f/pac143fb7/p8a3a546e;", "phoneVerificationRepository", "Lpf7a42fe7/pfbad4b6f/pb3f20355/p9e85afc0;", "tokenRepository", "Lp8d777f38/pb3f20355/pd9ae119c/pfa2012fc;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "<init>", "(Lpf7a42fe7/pfbad4b6f/pb3f20355/p9e85afc0;Lp8d777f38/pb3f20355/pd9ae119c/pfa2012fc;Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;)V", "getSms", "", "phone", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "validateCode", "", "code", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8e8c9903 : pf7a42fe7.pfbad4b6f.pac143fb7.p8a3a546e {
    private readonly pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 f2378c16f;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f47a65b68;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc f496a5ac6;
    private readonly pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 f7733fd7e;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f7cb50cf9;
    private readonly pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 f7da71503;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc fa231dfc2;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe3c01158;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc fe960cdd9;

    public p8e8c9903(pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 phoneVerificationRepository, p8d777f38.pb3f20355.pd9ae119c.pfa2012fc tokenRepository, pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneVerificationRepository, "phoneVerificationRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tokenRepository, "tokenRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userInfoUseCase, "userInfoUseCase");
        this.f2378c16f = phoneVerificationRepository;
        this.f496a5ac6 = tokenRepository;
        this.fe639d08f = userInfoUseCase;
    }

    public override java.lang.object GetSms(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1 p8e8c9903_pa165c402_1;
        if ((27 + 21) % 21 > 0) {
        }
        if (continuation is pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1) {
            p8e8c9903_pa165c402_1 = (pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1) continuation;
            if ((p8e8c9903_pa165c402_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p8e8c9903_pa165c402_1 = new pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1(this, continuation);
            } else {
                p8e8c9903_pa165c402_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p8e8c9903_pa165c402_1 = new pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1(this, continuation);
        }
        java.lang.object sms = p8e8c9903_pa165c402_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p8e8c9903_pa165c402_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(sms);
            this.f496a5ac6.clearToken();
            pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 p9e85afc0Var = this.f2378c16f;
            p8e8c9903_pa165c402_1.L$0 = this;
            p8e8c9903_pa165c402_1.fd304ba20 = 1;
            sms = p9e85afc0Var.getSms(str, p8e8c9903_pa165c402_1);
            if (sms == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903) p8e8c9903_pa165c402_1.L$0;
            kotlin.ResultKt.throwOnFailure(sms);
        }
        this.fe639d08f.saveSmsUuid((java.lang.string) sms);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object ValidateCode(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return this.f2378c16f.validateCode(this.fe639d08f.getSmsUuid(), str, continuation);
    }
}

