namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e", m533f = "FeedbackRepositoryImpl.kt", m534i = {}, m535l = {13}, m536m = "sendFeedback", m537n = {}, m538s = {})
readonly class pe4d60e7e$pe925c10c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f21b3de10;
    int f464c50ef;
    java.lang.object f60ba2f70;
    java.lang.object fb4a88417;
    int fbe8c702a;
    int fbeb8925f;
    int fd304ba20;
    readonly p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e this$0;

    pe4d60e7e$pe925c10c$1(p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e pe4d60e7eVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1> continuation) {
        super(continuation);
        this.this$0 = pe4d60e7eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.sendFeedback(null, this);
    }
}

