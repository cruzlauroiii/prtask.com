namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon", m533f = "AdSelectionManagerImplCommon.kt", m534i = {}, m535l = {44}, m536m = "selectAds$suspendImpl", m537n = {}, m538s = {})
readonly class AdSelectionManagerImplCommon$selectAds$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon this$0;

    AdSelectionManagerImplCommon$selectAds$1(androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon adSelectionManagerImplCommon, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$selectAds$1> continuation) {
        super(continuation);
        this.this$0 = adSelectionManagerImplCommon;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon.selectAds$suspendImpl(this.this$0, (androidx.privacysandbox.ads.adservices.adselection.AdSelectionConfig) null, this);
    }
}

