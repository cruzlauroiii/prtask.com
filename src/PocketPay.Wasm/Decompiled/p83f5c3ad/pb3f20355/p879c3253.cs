namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp83f5c3ad/pb3f20355/p879c3253;", "Lp83f5c3ad/pb3f20355/pe7d2429f;", "tophAuthDeviceApi", "Lp83f5c3ad/p8a5da52e/p40de21f4;", "<init>", "(Lp83f5c3ad/p8a5da52e/p40de21f4;)V", "authDevice", "", "tophAuthDeviceRequest", "Lp83f5c3ad/p07214c67/pd239a801;", "(Lp83f5c3ad/p07214c67/pd239a801;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p879c3253 : p83f5c3ad.pb3f20355.pe7d2429f {
    private readonly p83f5c3ad.p8a5da52e.p40de21f4 f02efc922;
    private readonly p83f5c3ad.p8a5da52e.p40de21f4 f1001f3d2;
    private readonly p83f5c3ad.p8a5da52e.p40de21f4 f49050ac8;
    private readonly p83f5c3ad.p8a5da52e.p40de21f4 fb0f458d6;
    private readonly p83f5c3ad.p8a5da52e.p40de21f4 fd5628990;

    public p879c3253(p83f5c3ad.p8a5da52e.p40de21f4 tophAuthDeviceApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophAuthDeviceApi, "tophAuthDeviceApi");
        this.fb0f458d6 = tophAuthDeviceApi;
    }

    public override java.lang.object AuthDevice(p83f5c3ad.p07214c67.pd239a801 pd239a801Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1 p879c3253_pb15d30e0_1;
        if ((29 + 13) % 13 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1) {
            p879c3253_pb15d30e0_1 = (p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1) continuation;
            if ((p879c3253_pb15d30e0_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p879c3253_pb15d30e0_1 = new p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1(this, continuation);
            } else {
                p879c3253_pb15d30e0_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p879c3253_pb15d30e0_1 = new p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1(this, continuation);
        }
        java.lang.object objAuthDevice = p879c3253_pb15d30e0_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p879c3253_pb15d30e0_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAuthDevice);
            p83f5c3ad.p8a5da52e.p40de21f4 p40de21f4Var = this.fb0f458d6;
            p879c3253_pb15d30e0_1.fd304ba20 = 1;
            objAuthDevice = p40de21f4Var.authDevice(pd239a801Var, p879c3253_pb15d30e0_1);
            if (objAuthDevice == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objAuthDevice);
        }
        if (((retrofit2.Response) objAuthDevice).isSuccessful()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new java.lang.Exception("Error while toph auth device");
    }
}

