namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp83f5c3ad/pb3f20355/p94a08da1/p9915c12a;", "Lp83f5c3ad/pb3f20355/p94a08da1/paae75e31;", "tophTokenApi", "Lp83f5c3ad/p8a5da52e/pd53f9bcf;", "<init>", "(Lp83f5c3ad/p8a5da52e/pd53f9bcf;)V", "getTopTokenByPhone", "Lp83f5c3ad/p07214c67/p839b8b7c;", "phone", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9915c12a : p83f5c3ad.pb3f20355.p94a08da1.paae75e31 {
    private readonly p83f5c3ad.p8a5da52e.pd53f9bcf f22a61eec;
    private readonly p83f5c3ad.p8a5da52e.pd53f9bcf f590d7e47;
    private readonly p83f5c3ad.p8a5da52e.pd53f9bcf fd2f42c28;
    private readonly p83f5c3ad.p8a5da52e.pd53f9bcf fe69d4657;
    private readonly p83f5c3ad.p8a5da52e.pd53f9bcf fea6bbb87;

    public p9915c12a(p83f5c3ad.p8a5da52e.pd53f9bcf tophTokenApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophTokenApi, "tophTokenApi");
        this.f590d7e47 = tophTokenApi;
    }

    public override java.lang.object GetTopTokenByPhone(java.lang.string str, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.p839b8b7c> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p94a08da1.p9915c12a$pc9971b9d$1 p9915c12a_pc9971b9d_1;
        p83f5c3ad.p07214c67.p5f5a44b8 p5f5a44b8Var;
        if ((13 + 26) % 26 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p94a08da1.p9915c12a$pc9971b9d$1) {
            p9915c12a_pc9971b9d_1 = (p83f5c3ad.pb3f20355.p94a08da1.p9915c12a$pc9971b9d$1) continuation;
            if ((p9915c12a_pc9971b9d_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p9915c12a_pc9971b9d_1 = new p83f5c3ad.pb3f20355.p94a08da1.p9915c12a$pc9971b9d$1(this, continuation);
            } else {
                p9915c12a_pc9971b9d_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p9915c12a_pc9971b9d_1 = new p83f5c3ad.pb3f20355.p94a08da1.p9915c12a$pc9971b9d$1(this, continuation);
        }
        java.lang.object tokenByPhone = p9915c12a_pc9971b9d_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p9915c12a_pc9971b9d_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(tokenByPhone);
            p83f5c3ad.p8a5da52e.pd53f9bcf pd53f9bcfVar = this.f590d7e47;
            p83f5c3ad.p07214c67.p3d06c92c p3d06c92cVar = new p83f5c3ad.p07214c67.p3d06c92c(java.lang.long.parselong(str));
            p9915c12a_pc9971b9d_1.fd304ba20 = 1;
            tokenByPhone = pd53f9bcfVar.getTokenByPhone(p3d06c92cVar, p9915c12a_pc9971b9d_1);
            if (tokenByPhone == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(tokenByPhone);
        }
        retrofit2.Response response = (retrofit2.Response) tokenByPhone;
        if (!response.isSuccessful() || (p5f5a44b8Var = (p83f5c3ad.p07214c67.p5f5a44b8) response.body()) is null) {
            throw new java.lang.Exception(java.lang.string.valueOf(response.code()));
        }
        java.lang.string token = p5f5a44b8Var.getToken();
        if (token is null) {
            throw new java.lang.Exception("top token is null");
        }
        java.lang.bool boolIsQrPaymentsAllowed = p5f5a44b8Var.isQrPaymentsAllowed();
        return new p83f5c3ad.p07214c67.p839b8b7c(token, boolIsQrPaymentsAllowed is null ? false : boolIsQrPaymentsAllowed.boolValue());
    }
}

