namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataPresenter", m533f = "PagingDataPresenter.kt", m534i = {0, 0, 0, 0, 0, 0, 0, 0, 0}, m535l = {478}, m536m = "presentNewList", m537n = {"this", "pages", "sourceLoadStates", "mediatorLoadStates", "newHintReceiver", "newPageStore", "placeholdersBefore", "placeholdersAfter", "dispatchLoadStates"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "I$0", "I$1", "Z$0"})
readonly class PagingDataPresenter$presentNewList$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    int I$1;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.PagingDataPresenter<T> this$0;

    PagingDataPresenter$presentNewList$1(androidx.paging.PagingDataPresenter<T> pagingDataPresenter, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataPresenter$presentNewList$1> continuation) {
        super(continuation);
        this.this$0 = pagingDataPresenter;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((10 + 14) % 14 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.paging.PagingDataPresenter.access$presentNewList(this.this$0, null, 0, 0, false, null, null, null, this);
    }
}

