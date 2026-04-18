namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$joinCustomAudienceAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$joinCustomAudienceAsync$1", m533f = "CustomAudienceManagerTasks.kt", m534i = {}, m535l = {145}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0823x15d14809 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl this$0;

    C0823x15d14809(androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.customaudience.C0823x15d14809> r3) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>(r1, r3)
            goto L26
        Lb:
            goto L27
        Le:
            goto L1d
        L12:
            r0.$request = r2
            goto L18
        L18:
            r1 = 2
            goto L4
        L1d:
            r0.this$0 = r1
            goto L12
        L23:
            goto Le
        L26:
            return
        L27:
            goto L23
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L2b
        L4:
            r2.<init>(r0, r1, r3)
            goto L11
        Lb:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L1f
        L11:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1a
        L17:
            goto L2e
        L1a:
            return r2
        L1b:
            goto L17
        L1f:
            androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest r1 = r1.$request
            goto L4
        L25:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$joinCustomAudienceAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$joinCustomAudienceAsync$1
            goto Lb
        L2b:
            goto L1b
        L2e:
            goto L25
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto La
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L14
        La:
            goto L23
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1a
        L1a:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L22
        L22:
            return r0
        L23:
            goto L11
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L19
        L10:
            goto Lc
        L13:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        L19:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L21
        L21:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$joinCustomAudienceAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.customaudience.C0823x15d14809) r0
            goto L13
        L27:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto La
        L4:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L4b
        La:
            goto L74
        Ld:
            goto Lbd
        L11:
            goto L4c
        L14:
            goto Lc4
        L18:
            if (r4 == r0) goto L1d
            goto L28
        L1d:
            goto L27
        L21:
            int r1 = r4.label
            goto L83
        L27:
            return r0
        L28:
            goto L4
        L2c:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L50
        L32:
            int r0 = r0 + r1
            goto L94
        L38:
            androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager r5 = androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl.access$getMCustomAudienceManager$p(r5)
            goto L8d
        L40:
            throw r4
        L41:
            goto Ld5
        L45:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L56
        L4b:
            return r4
        L4c:
            goto L71
        L50:
            r4.label = r2
            goto La0
        L56:
            r4.<init>(r5)
            goto L40
        L5d:
            androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest r1 = r4.$request
            goto L88
        L63:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L78
        L6a:
            r1 = 5
            goto L32
        L71:
            goto L14
        L74:
            goto La8
        L78:
            goto L28
        L79:
            goto L9a
        L7d:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L38
        L83:
            r2 = 1
            goto Lcc
        L88:
            r3 = r4
            goto L2c
        L8d:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L5d
        L94:
            int r0 = r0 % r1
            goto Lab
        L9a:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L45
        La0:
            java.lang.object r4 = r5.joinCustomAudience(r1, r3)
            goto L18
        La8:
            goto Ld
        Lab:
            if (r0 <= 0) goto Lb0
            goto L14
        Lb0:
            goto L11
        Lb4:
            if (r1 == r2) goto Lb9
            goto L79
        Lb9:
            goto L63
        Lbd:
            r0 = 11
            goto L6a
        Lc4:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L21
        Lcc:
            if (r1 != 0) goto Ld1
            goto L41
        Ld1:
            goto Lb4
        Ld5:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L7d
    }
}

