namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$updateAdCounterHistogramAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$updateAdCounterHistogramAsync$1", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {338}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0821x64bcb5a8 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest $updateAdCounterHistogramRequest;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl this$0;

    C0821x64bcb5a8(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.adselection.C0821x64bcb5a8> r3) {
            r0 = this;
            goto L24
        L4:
            r0.this$0 = r1
            goto L19
        La:
            r0.<init>(r1, r3)
            goto L1f
        L11:
            goto L27
        L14:
            r1 = 2
            goto La
        L19:
            r0.$updateAdCounterHistogramRequest = r2
            goto L14
        L1f:
            return
        L20:
            goto L11
        L24:
            goto L20
        L27:
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L26
        L4:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$updateAdCounterHistogramAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$updateAdCounterHistogramAsync$1
            goto L17
        La:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L2d
        L10:
            r2.<init>(r0, r1, r3)
            goto La
        L17:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L20
        L1d:
            goto L29
        L20:
            androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest r1 = r1.$updateAdCounterHistogramRequest
            goto L10
        L26:
            goto L2e
        L29:
            goto L4
        L2d:
            return r2
        L2e:
            goto L1d
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1d
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lf
        La:
            return r0
        Lb:
            goto L24
        Lf:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L15
        L15:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto La
        L1d:
            goto Lb
        L20:
            goto L4
        L24:
            goto L20
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L17
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        La:
            return r0
        Lb:
            goto L1e
        Lf:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L21
        L17:
            goto Lb
        L1a:
            goto Lf
        L1e:
            goto L1a
        L21:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$updateAdCounterHistogramAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.adselection.C0821x64bcb5a8) r0
            goto L4
        L27:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto La
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L7f
        L4:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L2f
        La:
            if (r1 == r2) goto Lf
            goto L6f
        Lf:
            goto L38
        L13:
            r0 = 15
            goto L92
        L1a:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L79
        L21:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager r5 = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl.access$getMAdSelectionManager$p(r5)
            goto L1a
        L29:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Lc8
        L2f:
            r4.label = r2
            goto L3f
        L35:
            goto L82
        L38:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L6e
        L3f:
            java.lang.object r4 = r5.updateAdCounterHistogram(r1, r3)
            goto L47
        L47:
            if (r4 == r0) goto L4c
            goto Lc4
        L4c:
            goto Lc3
        L50:
            if (r1 != 0) goto L55
            goto Lbf
        L55:
            goto La
        L59:
            if (r0 <= 0) goto L5e
            goto L89
        L5e:
            goto L86
        L62:
            goto L89
        L65:
            goto L35
        L69:
            r2 = 1
            goto L50
        L6e:
            goto Lc4
        L6f:
            goto L29
        L73:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto La5
        L79:
            androidx.privacysandbox.ads.adservices.adselection.UpdateAdCounterHistogramRequest r1 = r4.$updateAdCounterHistogramRequest
            goto L8d
        L7f:
            goto L65
        L82:
            goto L13
        L86:
            goto La6
        L89:
            goto Ld4
        L8d:
            r3 = r4
            goto L4
        L92:
            r1 = 25
            goto Lce
        L99:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L21
        L9f:
            int r0 = r0 % r1
            goto L59
        La5:
            return r4
        La6:
            goto L62
        Laa:
            r4.<init>(r5)
            goto Lbe
        Lb1:
            int r1 = r4.label
            goto L69
        Lb7:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L99
        Lbe:
            throw r4
        Lbf:
            goto Lb7
        Lc3:
            return r0
        Lc4:
            goto L73
        Lc8:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto Laa
        Lce:
            int r0 = r0 + r1
            goto L9f
        Ld4:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lb1
    }
}

