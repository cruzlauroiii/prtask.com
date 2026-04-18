namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J6\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\t2\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp83f5c3ad/pb3f20355/p70a17ffa/pdb329010;", "Lp83f5c3ad/pb3f20355/p8592f9a7;", "tophOrderApi", "Lp83f5c3ad/p8a5da52e/p7b8552a1;", "<init>", "(Lp83f5c3ad/p8a5da52e/p7b8552a1;)V", "sendOrderTophAcquiring", "", "userId", "", "phone", "fio", "inn", "regionId", "", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;ILkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdb329010 : p83f5c3ad.pb3f20355.p8592f9a7 {
    private readonly p83f5c3ad.p8a5da52e.p7b8552a1 f6babd50a;
    private readonly p83f5c3ad.p8a5da52e.p7b8552a1 f873471ec;

    public pdb329010(p83f5c3ad.p8a5da52e.p7b8552a1 tophOrderApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophOrderApi, "tophOrderApi");
        this.f6babd50a = tophOrderApi;
    }

    public override java.lang.object SendOrderTophAcquiring(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1 pdb329010_pa2c7189b_1;
        if ((20 + 8) % 8 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1) {
            pdb329010_pa2c7189b_1 = (p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1) continuation;
            if ((pdb329010_pa2c7189b_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pdb329010_pa2c7189b_1 = new p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1(this, continuation);
            } else {
                pdb329010_pa2c7189b_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pdb329010_pa2c7189b_1 = new p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1(this, continuation);
        }
        java.lang.object objSendOrder = pdb329010_pa2c7189b_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = pdb329010_pa2c7189b_1.fd304ba20;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(objSendOrder);
            p83f5c3ad.p8a5da52e.p7b8552a1 p7b8552a1Var = this.f6babd50a;
            p83f5c3ad.p07214c67.p1f723f91 p1f723f91Var = new p83f5c3ad.p07214c67.p1f723f91(str, str2, str3, str4, i);
            pdb329010_pa2c7189b_1.fd304ba20 = 1;
            objSendOrder = p7b8552a1Var.sendOrder(p1f723f91Var, pdb329010_pa2c7189b_1);
            if (objSendOrder == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objSendOrder);
        }
        retrofit2.Response response = (retrofit2.Response) objSendOrder;
        if (response.code() == 409) {
            throw new p83f5c3ad.p8a5da52e.pe9025916();
        }
        if (response.isSuccessful()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new java.lang.IllegalStateException("error while send toph order".tostring());
    }
}

