namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p07c4b34e", m533f = "TophAuthDeviceUseCaseImpl.kt", m534i = {0}, m535l = {17, 22}, m536m = "authDevice", m537n = {"this"}, m538s = {"L$0"})
readonly class p07c4b34e$pb15d30e0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f0e446b74;
    int f95ca3323;
    int f96d0faa3;
    java.lang.object fb4a88417;
    int fca6dd016;
    int fd304ba20;
    int febd80383;
    readonly p83f5c3ad.p684019bc.p07c4b34e this$0;

    p07c4b34e$pb15d30e0$1(p83f5c3ad.p684019bc.p07c4b34e p07c4b34eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p07c4b34e$pb15d30e0$1> continuation) {
        super(continuation);
        this.this$0 = p07c4b34eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.authDevice(this);
    }
}

