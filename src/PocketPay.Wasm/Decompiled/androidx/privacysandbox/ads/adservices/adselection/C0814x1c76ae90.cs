namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$persistAdSelectionResult$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion", m533f = "AdSelectionManagerImplCommon.kt", m534i = {0, 0}, m535l = {231}, m536m = "persistAdSelectionResult", m537n = {"adSelectionManager", "persistAdSelectionResultRequest"}, m538s = {"L$0", "L$1"})
readonly class C0814x1c76ae90 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    /* synthetic */ java.lang.object result;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon.Ext10Impl.Companion this$0;

    C0814x1c76ae90(androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon.Ext10Impl.Companion r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.C0814x1c76ae90> r2) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0.this$0 = r1
            goto L16
        L11:
            return
        L12:
            goto L1d
        L16:
            r0.<init>(r2)
            goto L11
        L1d:
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
            r1 = this;
            goto L37
        L4:
            r2 = r2 | r0
            goto L25
        L9:
            int r2 = r1.label
            goto L31
        Lf:
            r1.result = r2
            goto L9
        L15:
            r0 = 0
            goto L43
        L1a:
            goto L3a
        L1d:
            java.lang.object r1 = r2.persistAdSelectionResult(r0, r0, r1)
            goto L3e
        L25:
            r1.label = r2
            goto L2b
        L2b:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion r2 = r1.this$0
            goto L15
        L31:
            r0 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L37:
            goto L3f
        L3a:
            goto Lf
        L3e:
            return r1
        L3f:
            goto L1a
        L43:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L1d
    }
}

