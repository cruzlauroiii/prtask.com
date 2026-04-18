namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p879c3253", m533f = "TophAuthDeviceRepositoryImpl.kt", m534i = {}, m535l = {11}, m536m = "authDevice", m537n = {}, m538s = {})
readonly class p879c3253$pb15d30e0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f14b71eb7;
    int f7e9a0f4e;
    int fa4de5918;
    java.lang.object fb4a88417;
    int fc8562977;
    int fd304ba20;
    java.lang.object fe2598497;
    readonly p83f5c3ad.pb3f20355.p879c3253 this$0;

    p879c3253$pb15d30e0$1(p83f5c3ad.pb3f20355.p879c3253 p879c3253Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p879c3253$pb15d30e0$1> continuation) {
        super(continuation);
        this.this$0 = p879c3253Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.authDevice(null, this);
    }
}

