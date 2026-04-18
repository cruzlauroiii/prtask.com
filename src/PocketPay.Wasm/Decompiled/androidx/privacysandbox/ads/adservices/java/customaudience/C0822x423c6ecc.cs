namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$fetchAndJoinCustomAudienceAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$fetchAndJoinCustomAudienceAsync$1", m533f = "CustomAudienceManagerTasks.kt", m534i = {}, m535l = {156}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0822x423c6ecc : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl this$0;

    C0822x423c6ecc(androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.customaudience.C0822x423c6ecc> r3) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.<init>(r1, r3)
            goto L7
        L13:
            goto L8
        L16:
            goto L25
        L1a:
            r1 = 2
            goto Lc
        L1f:
            r0.$request = r2
            goto L1a
        L25:
            r0.this$0 = r1
            goto L1f
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto La
        L4:
            androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest r1 = r1.$request
            goto L25
        La:
            goto L21
        Ld:
            goto L17
        L11:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L4
        L17:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$fetchAndJoinCustomAudienceAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$fetchAndJoinCustomAudienceAsync$1
            goto L11
        L1d:
            goto Ld
        L20:
            return r2
        L21:
            goto L1d
        L25:
            r2.<init>(r0, r1, r3)
            goto L2c
        L2c:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L20
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto L19
        Lb:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
        L19:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lb
        L1f:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L14
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L17
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1e
        Lc:
            goto L1a
        Lf:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L24
        L17:
            goto L25
        L1a:
            goto L4
        L1e:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$fetchAndJoinCustomAudienceAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.customaudience.C0822x423c6ecc) r0
            goto L29
        L24:
            return r0
        L25:
            goto Lc
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Lf
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L71
        L4:
            java.lang.object r4 = r5.fetchAndJoinCustomAudience(r1, r3)
            goto Lb0
        Lc:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto La9
        L12:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L98
        L18:
            if (r1 == r2) goto L1d
            goto L46
        L1d:
            goto L28
        L21:
            goto Lc9
        L24:
            goto L78
        L28:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L45
        L2f:
            return r0
        L30:
            goto L12
        L34:
            r2 = 1
            goto L8f
        L39:
            int r1 = r4.label
            goto L34
        L3f:
            r4.label = r2
            goto L4
        L45:
            goto L30
        L46:
            goto L5d
        L4a:
            r1 = 8
            goto L51
        L51:
            int r0 = r0 + r1
            goto L7b
        L57:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L3f
        L5d:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Lc
        L63:
            if (r0 <= 0) goto L68
            goto Lc9
        L68:
            goto Lc6
        L6c:
            r3 = r4
            goto L57
        L71:
            goto L24
        L74:
            goto Ld5
        L78:
            goto L74
        L7b:
            int r0 = r0 % r1
            goto L63
        L81:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L87
        L87:
            androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager r5 = androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl.access$getMCustomAudienceManager$p(r5)
            goto La2
        L8f:
            if (r1 != 0) goto L94
            goto L9e
        L94:
            goto L18
        L98:
            return r4
        L99:
            goto L21
        L9d:
            throw r4
        L9e:
            goto Lbf
        La2:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto Lb9
        La9:
            r4.<init>(r5)
            goto L9d
        Lb0:
            if (r4 == r0) goto Lb5
            goto L30
        Lb5:
            goto L2f
        Lb9:
            androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest r1 = r4.$request
            goto L6c
        Lbf:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L81
        Lc6:
            goto L99
        Lc9:
            goto Lcd
        Lcd:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L39
        Ld5:
            r0 = 11
            goto L4a
    }
}

