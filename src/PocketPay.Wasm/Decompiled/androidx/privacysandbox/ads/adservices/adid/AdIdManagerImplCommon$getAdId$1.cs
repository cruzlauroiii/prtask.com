namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon", m533f = "AdIdManagerImplCommon.kt", m534i = {}, m535l = {40}, m536m = "getAdId$suspendImpl", m537n = {}, m538s = {})
readonly class AdIdManagerImplCommon$getAdId$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon this$0;

    AdIdManagerImplCommon$getAdId$1(androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon adIdManagerImplCommon, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1> continuation) {
        super(continuation);
        this.this$0 = adIdManagerImplCommon;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon.getAdId$suspendImpl(this.this$0, this);
    }
}

