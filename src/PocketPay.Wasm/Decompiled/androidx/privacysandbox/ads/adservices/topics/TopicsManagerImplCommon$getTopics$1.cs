namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon", m533f = "TopicsManagerImplCommon.kt", m534i = {}, m535l = {40}, m536m = "getTopics$suspendImpl", m537n = {}, m538s = {})
readonly class TopicsManagerImplCommon$getTopics$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon this$0;

    TopicsManagerImplCommon$getTopics$1(androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon topicsManagerImplCommon, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1> continuation) {
        super(continuation);
        this.this$0 = topicsManagerImplCommon;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon.getTopics$suspendImpl(this.this$0, null, this);
    }
}

