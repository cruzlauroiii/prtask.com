namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$getAdSelectionDataAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataOutcome;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$getAdSelectionDataAsync$1", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {361}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0818x63036bbf : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest $getAdSelectionDataRequest;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl this$0;

    C0818x63036bbf(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.adselection.C0818x63036bbf> r3) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L19
        L13:
            r0.$getAdSelectionDataRequest = r2
            goto L1f
        L19:
            r0.this$0 = r1
            goto L13
        L1f:
            r1 = 2
            goto L24
        L24:
            r0.<init>(r1, r3)
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1e
        L4:
            androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest r1 = r1.$getAdSelectionDataRequest
            goto L2b
        La:
            goto L21
        Ld:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L4
        L13:
            return r2
        L14:
            goto La
        L18:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$getAdSelectionDataAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$getAdSelectionDataAsync$1
            goto Ld
        L1e:
            goto L14
        L21:
            goto L18
        L25:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L13
        L2b:
            r2.<init>(r0, r1, r3)
            goto L25
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome> r2) {
            r0 = this;
            goto L12
        L4:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L19
        Lc:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L12:
            goto L1a
        L15:
            goto Lc
        L19:
            return r0
        L1a:
            goto L1e
        L1e:
            goto L15
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome> r2) {
            r0 = this;
            goto L1a
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L21
        La:
            return r0
        Lb:
            goto L17
        Lf:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L29
        L17:
            goto L1d
        L1a:
            goto Lb
        L1d:
            goto Lf
        L21:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto La
        L29:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$getAdSelectionDataAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.adselection.C0818x63036bbf) r0
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L26
        L4:
            return r5
        L5:
            goto L91
        L9:
            return r0
        La:
            goto L85
        Le:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L5d
        L14:
            r4.label = r2
            goto L39
        L1a:
            int r0 = r0 + r1
            goto L4a
        L20:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L7d
        L26:
            goto Lc4
        L29:
            goto Lae
        L2d:
            androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest r1 = r4.$getAdSelectionDataRequest
            goto L78
        L33:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L14
        L39:
            java.lang.object r4 = r5.getAdSelectionData(r1, r3)
            goto Lb8
        L41:
            if (r0 <= 0) goto L46
            goto Laa
        L46:
            goto La7
        L4a:
            int r0 = r0 % r1
            goto L41
        L50:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L64
        L58:
            r2 = 1
            goto L9e
        L5d:
            r4.<init>(r5)
            goto Lc8
        L64:
            int r1 = r4.label
            goto L58
        L6a:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L20
        L71:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L2d
        L78:
            r3 = r4
            goto L33
        L7d:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager r5 = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl.access$getMAdSelectionManager$p(r5)
            goto L71
        L85:
            return r4
        L86:
            goto Lc1
        L8a:
            r1 = 6
            goto L1a
        L91:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Le
        L97:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L4
        L9e:
            if (r1 != 0) goto La3
            goto Lc9
        La3:
            goto Lcd
        La7:
            goto L86
        Laa:
            goto L50
        Lae:
            r0 = 8
            goto L8a
        Lb5:
            goto L29
        Lb8:
            if (r4 == r0) goto Lbd
            goto La
        Lbd:
            goto L9
        Lc1:
            goto Laa
        Lc4:
            goto Lb5
        Lc8:
            throw r4
        Lc9:
            goto L6a
        Lcd:
            if (r1 == r2) goto Ld2
            goto L5
        Ld2:
            goto L97
    }
}

