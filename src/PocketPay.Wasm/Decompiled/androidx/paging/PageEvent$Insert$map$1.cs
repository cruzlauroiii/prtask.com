namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageEvent$Insert", m533f = "PageEvent.kt", m534i = {0, 0, 0, 0, 0}, m535l = {128}, m536m = "map", m537n = {"transform", "this_$iv$iv", "destination$iv$iv$iv", "it", "destination$iv$iv"}, m538s = {"L$0", "L$1", "L$3", "L$5", "L$7"})
readonly class PageEvent$Insert$map$1<R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$10;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    java.lang.object L$7;
    java.lang.object L$8;
    java.lang.object L$9;
    int label;
    java.lang.object result;
    readonly androidx.paging.PageEvent$Insert<T> this$0;

    PageEvent$Insert$map$1(androidx.paging.PageEvent$Insert<T> pageEvent$Insert, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent$Insert$map$1> continuation) {
        super(continuation);
        this.this$0 = pageEvent$Insert;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.map(null, this);
    }
}

