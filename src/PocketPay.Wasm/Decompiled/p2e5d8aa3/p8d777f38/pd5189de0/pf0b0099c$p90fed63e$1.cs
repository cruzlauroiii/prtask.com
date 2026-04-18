namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c", m533f = "LocationRepositoryImpl.kt", m534i = {0}, m535l = {33}, m536m = "updateUserLocation", m537n = {"this"}, m538s = {"L$0"})
readonly class pf0b0099c$p90fed63e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f017a1fa3;
    java.lang.object f43e181a6;
    java.lang.object f5a59d567;
    int f5b60c42b;
    int f69adad59;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe134491c;
    readonly p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c this$0;

    pf0b0099c$p90fed63e$1(p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c pf0b0099cVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.pd5189de0.pf0b0099c$p90fed63e$1> continuation) {
        super(continuation);
        this.this$0 = pf0b0099cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateUserLocation(this);
    }
}

