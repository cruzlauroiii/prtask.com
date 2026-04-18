namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {327}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0820x3453cbdf : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest $reportImpressionRequest;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl this$0;

    C0820x3453cbdf(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.adselection.C0820x3453cbdf> r3) {
            r0 = this;
            goto L12
        L4:
            r0.$reportImpressionRequest = r2
            goto La
        La:
            r1 = 2
            goto L1f
        Lf:
            goto L15
        L12:
            goto L27
        L15:
            goto L19
        L19:
            r0.this$0 = r1
            goto L4
        L1f:
            r0.<init>(r1, r3)
            goto L26
        L26:
            return
        L27:
            goto Lf
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L17
        L4:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L2d
        La:
            r2.<init>(r0, r1, r3)
            goto L4
        L11:
            androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest r1 = r1.$reportImpressionRequest
            goto La
        L17:
            goto L2e
        L1a:
            goto L27
        L1e:
            goto L1a
        L21:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L11
        L27:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1
            goto L21
        L2d:
            return r2
        L2e:
            goto L1e
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L18
        Lb:
            return r0
        Lc:
            goto L1e
        L10:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto Lb
        L18:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L1e:
            goto L7
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L10
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L23
        L7:
            goto L14
        Lb:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        L11:
            goto L7
        L14:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1c
        L1c:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.adselection.C0820x3453cbdf) r0
            goto Lb
        L22:
            return r0
        L23:
            goto L11
        L27:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L22
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L19
        L4:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L36
        Lc:
            int r0 = r0 % r1
            goto L20
        L12:
            goto L5f
        L15:
            goto Lbf
        L19:
            goto L15
        L1c:
            goto L63
        L20:
            if (r0 <= 0) goto L25
            goto L5f
        L25:
            goto L5c
        L29:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L30
        L30:
            goto Lb2
        L32:
            goto Ld0
        L36:
            int r1 = r4.label
            goto L9c
        L3c:
            return r4
        L3d:
            goto L12
        L41:
            java.lang.object r4 = r5.reportImpression(r1, r3)
            goto La1
        L49:
            throw r4
        L4a:
            goto Ld6
        L4e:
            if (r1 == r2) goto L53
            goto L32
        L53:
            goto L29
        L57:
            r3 = r4
            goto L6a
        L5c:
            goto L3d
        L5f:
            goto L4
        L63:
            r0 = 6
            goto L70
        L6a:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L90
        L70:
            r1 = 13
            goto L96
        L77:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L83
        L7d:
            androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest r1 = r4.$reportImpressionRequest
            goto L57
        L83:
            r4.<init>(r5)
            goto L49
        L8a:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto Lc2
        L90:
            r4.label = r2
            goto L41
        L96:
            int r0 = r0 + r1
            goto Lc
        L9c:
            r2 = 1
            goto Lb6
        La1:
            if (r4 == r0) goto La6
            goto Lb2
        La6:
            goto Lb1
        Laa:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L7d
        Lb1:
            return r0
        Lb2:
            goto Lca
        Lb6:
            if (r1 != 0) goto Lbb
            goto L4a
        Lbb:
            goto L4e
        Lbf:
            goto L1c
        Lc2:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager r5 = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl.access$getMAdSelectionManager$p(r5)
            goto Laa
        Lca:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L3c
        Ld0:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L77
        Ld6:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L8a
    }
}

