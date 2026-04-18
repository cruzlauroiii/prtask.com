namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$persistAdSelectionResultAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$persistAdSelectionResultAsync$1", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {373}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0819xcfbf2aea : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest $persistAdSelectionResultRequest;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl this$0;

    C0819xcfbf2aea(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.adselection.C0819xcfbf2aea> r3) {
            r0 = this;
            goto L1b
        L4:
            r0.<init>(r1, r3)
            goto Lb
        Lb:
            return
        Lc:
            goto L28
        L10:
            r0.this$0 = r1
            goto L22
        L16:
            r1 = 2
            goto L4
        L1b:
            goto Lc
        L1e:
            goto L10
        L22:
            r0.$persistAdSelectionResultRequest = r2
            goto L16
        L28:
            goto L1e
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L10
        L4:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L27
        La:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L2d
        L10:
            goto L2e
        L13:
            goto L21
        L17:
            goto L13
        L1a:
            r2.<init>(r0, r1, r3)
            goto La
        L21:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$persistAdSelectionResultAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$persistAdSelectionResultAsync$1
            goto L4
        L27:
            androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest r1 = r1.$persistAdSelectionResultRequest
            goto L1a
        L2d:
            return r2
        L2e:
            goto L17
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> r2) {
            r0 = this;
            goto L18
        L4:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L1f
        Lc:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L12:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lc
        L18:
            goto L20
        L1b:
            goto L12
        L1f:
            return r0
        L20:
            goto L24
        L24:
            goto L1b
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> r2) {
            r0 = this;
            goto L1a
        L4:
            return r0
        L5:
            goto L11
        L9:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L14
        L11:
            goto L1d
        L14:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$persistAdSelectionResultAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.adselection.C0819xcfbf2aea) r0
            goto L29
        L1a:
            goto L5
        L1d:
            goto L9
        L21:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L4
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L21
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto Lb2
        L4:
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager r5 = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks.Api33Ext4JavaImpl.access$getMAdSelectionManager$p(r5)
            goto L1d
        Lc:
            androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L4
        L12:
            return r0
        L13:
            goto La8
        L17:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L69
        L1d:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L47
        L24:
            if (r1 == r2) goto L29
            goto L94
        L29:
            goto L2d
        L2d:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L93
        L34:
            r3 = r4
            goto Lb9
        L39:
            r0 = 32
            goto L62
        L40:
            r4.<init>(r5)
            goto L7b
        L47:
            androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest r1 = r4.$persistAdSelectionResultRequest
            goto L34
        L4d:
            if (r4 == r0) goto L52
            goto L13
        L52:
            goto L12
        L56:
            int r0 = r0 + r1
            goto L5c
        L5c:
            int r0 = r0 % r1
            goto L98
        L62:
            r1 = 14
            goto L56
        L69:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L40
        L6f:
            if (r1 != 0) goto L74
            goto L7c
        L74:
            goto L24
        L78:
            goto Lb5
        L7b:
            throw r4
        L7c:
            goto Lcf
        L80:
            int r1 = r4.label
            goto Lad
        L86:
            goto La9
        L89:
            goto Lc7
        L8d:
            r4.label = r2
            goto Lbf
        L93:
            return r5
        L94:
            goto L17
        L98:
            if (r0 <= 0) goto L9d
            goto L89
        L9d:
            goto L86
        La1:
            goto L89
        La4:
            goto L78
        La8:
            return r4
        La9:
            goto La1
        Lad:
            r2 = 1
            goto L6f
        Lb2:
            goto La4
        Lb5:
            goto L39
        Lb9:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L8d
        Lbf:
            java.lang.object r4 = r5.persistAdSelectionResult(r1, r3)
            goto L4d
        Lc7:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L80
        Lcf:
            kotlin.ResultKt.throwOnFailure(r5)
            goto Lc
    }
}

