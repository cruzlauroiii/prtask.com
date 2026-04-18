namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageEvent$StaticList", m533f = "PageEvent.kt", m534i = {0, 0, 0}, m535l = {48}, m536m = "map", m537n = {"this", "transform", "destination$iv$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class PageEvent$StaticList$map$1<R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int label;
    java.lang.object result;
    readonly androidx.paging.PageEvent$StaticList<T> this$0;

    PageEvent$StaticList$map$1(androidx.paging.PageEvent$StaticList<T> pageEvent$StaticList, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent$StaticList$map$1> continuation) {
        super(continuation);
        this.this$0 = pageEvent$StaticList;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.map(null, this);
    }
}

