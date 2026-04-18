namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$getAdSelectionData$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion", m533f = "AdSelectionManagerImplCommon.kt", m534i = {0, 0}, m535l = {231}, m536m = "getAdSelectionData", m537n = {"adSelectionManager", "getAdSelectionDataRequest"}, m538s = {"L$0", "L$1"})
readonly class C0813xa603879b : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    /* synthetic */ java.lang.object result;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon.Ext10Impl.Companion this$0;

    C0813xa603879b(androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon.Ext10Impl.Companion r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.C0813xa603879b> r2) {
            r0 = this;
            goto L14
        L4:
            r0.this$0 = r1
            goto La
        La:
            r0.<init>(r2)
            goto L1b
        L11:
            goto L17
        L14:
            goto L1c
        L17:
            goto L4
        L1b:
            return
        L1c:
            goto L11
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
            r1 = this;
            goto L4
        L4:
            goto L2e
        L7:
            goto L32
        Lb:
            int r2 = r1.label
            goto L27
        L11:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion r2 = r1.this$0
            goto L17
        L17:
            r0 = 0
            goto L1c
        L1c:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L3e
        L22:
            r2 = r2 | r0
            goto L38
        L27:
            r0 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L22
        L2d:
            return r1
        L2e:
            goto L46
        L32:
            r1.result = r2
            goto Lb
        L38:
            r1.label = r2
            goto L11
        L3e:
            java.lang.object r1 = r2.getAdSelectionData(r0, r0, r1)
            goto L2d
        L46:
            goto L7
    }
}

