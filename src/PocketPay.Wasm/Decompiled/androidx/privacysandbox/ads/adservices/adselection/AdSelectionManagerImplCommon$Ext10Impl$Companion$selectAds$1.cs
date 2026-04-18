namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion", m533f = "AdSelectionManagerImplCommon.kt", m534i = {0, 0}, m535l = {231}, m536m = "selectAds", m537n = {"adSelectionManager", "adSelectionFromOutcomesConfig"}, m538s = {"L$0", "L$1"})
readonly class AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion this$0;

    AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1(androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion adSelectionManagerImplCommon$Ext10Impl$Companion, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1> continuation) {
        super(continuation);
        this.this$0 = adSelectionManagerImplCommon$Ext10Impl$Companion;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.selectAds(null, null, this);
    }
}

