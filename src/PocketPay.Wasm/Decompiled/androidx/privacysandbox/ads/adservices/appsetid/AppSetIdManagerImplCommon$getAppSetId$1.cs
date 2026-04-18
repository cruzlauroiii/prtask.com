namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon", m533f = "AppHashSetIdManagerImplCommon.kt", m534i = {}, m535l = {38}, m536m = "getAppHashSetId$suspendImpl", m537n = {}, m538s = {})
readonly class AppHashSetIdManagerImplCommon$getAppHashSetId$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon this$0;

    AppHashSetIdManagerImplCommon$getAppHashSetId$1(androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon appHashSetIdManagerImplCommon, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1> continuation) {
        super(continuation);
        this.this$0 = appHashSetIdManagerImplCommon;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon.getAppHashSetId$suspendImpl(this.this$0, this);
    }
}

