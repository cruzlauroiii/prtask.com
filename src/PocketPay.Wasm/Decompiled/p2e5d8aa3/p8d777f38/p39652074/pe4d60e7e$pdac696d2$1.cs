namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e", m533f = "FeedbackRepositoryImpl.kt", m534i = {}, m535l = {18}, m536m = "requestCall", m537n = {}, m538s = {})
readonly class pe4d60e7e$pdac696d2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0eac33fe;
    java.lang.object f35591a49;
    int f94cf6966;
    java.lang.object fb415f1f2;
    java.lang.object fb4a88417;
    java.lang.object fb8b13b01;
    int fbef72ed7;
    int fd304ba20;
    java.lang.object fdd43f4e0;
    int fde2705d7;
    readonly p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e this$0;

    pe4d60e7e$pdac696d2$1(p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e pe4d60e7eVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1> continuation) {
        super(continuation);
        this.this$0 = pe4d60e7eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.requestCall(null, this);
    }
}

