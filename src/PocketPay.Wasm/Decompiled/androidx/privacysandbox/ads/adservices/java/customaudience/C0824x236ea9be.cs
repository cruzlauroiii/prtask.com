namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1", m533f = "CustomAudienceManagerTasks.kt", m534i = {}, m535l = {166}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0824x236ea9be : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl this$0;

    C0824x236ea9be(androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl r1, androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.customaudience.C0824x236ea9be> r3) {
            r0 = this;
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            r1 = 2
            goto L14
        Le:
            r0.this$0 = r1
            goto L1b
        L14:
            r0.<init>(r1, r3)
            goto L4
        L1b:
            r0.$request = r2
            goto L9
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto Le
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1f
        L4:
            goto L22
        L7:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1
            goto L19
        Ld:
            return r2
        Le:
            goto L4
        L12:
            r2.<init>(r0, r1, r3)
            goto L2c
        L19:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r0 = r1.this$0
            goto L26
        L1f:
            goto Le
        L22:
            goto L7
        L26:
            androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest r1 = r1.$request
            goto L12
        L2c:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Ld
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L18
        L4:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L22
        Lc:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L12:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Lc
        L18:
            goto L23
        L1b:
            goto L12
        L1f:
            goto L1b
        L22:
            return r0
        L23:
            goto L1f
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Lc
        Lc:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.customaudience.C0824x236ea9be) r0
            goto L1a
        L12:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L27
        L1a:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L12
        L20:
            goto L28
        L23:
            goto L4
        L27:
            return r0
        L28:
            goto L2c
        L2c:
            goto L23
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto Laa
        L4:
            int r1 = r4.label
            goto L83
        La:
            return r0
        Lb:
            goto L23
        Lf:
            r0 = 1
            goto L54
        L16:
            androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl r5 = r4.this$0
            goto L5b
        L1c:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L16
        L23:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L90
        L29:
            java.lang.object r4 = r5.leaveCustomAudience(r1, r3)
            goto L4b
        L31:
            r3 = r4
            goto Lbd
        L36:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L70
        L3c:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L36
        L42:
            if (r0 <= 0) goto L47
            goto Ld5
        L47:
            goto Ld2
        L4b:
            if (r4 == r0) goto L50
            goto Lb
        L50:
            goto La
        L54:
            r1 = 16
            goto Lb1
        L5b:
            androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager r5 = androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks.Api33Ext4JavaImpl.access$getMCustomAudienceManager$p(r5)
            goto L77
        L63:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L7e
        L6a:
            androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest r1 = r4.$request
            goto L31
        L70:
            r4.<init>(r5)
            goto La5
        L77:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L6a
        L7e:
            goto Lb
        L7f:
            goto L3c
        L83:
            r2 = 1
            goto Lc3
        L88:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4
        L90:
            return r4
        L91:
            goto L9e
        L95:
            if (r1 == r2) goto L9a
            goto L7f
        L9a:
            goto L63
        L9e:
            goto Ld5
        La1:
            goto Ld9
        La5:
            throw r4
        La6:
            goto L1c
        Laa:
            goto La1
        Lad:
            goto Lf
        Lb1:
            int r0 = r0 + r1
            goto Lb7
        Lb7:
            int r0 = r0 % r1
            goto L42
        Lbd:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto Lcc
        Lc3:
            if (r1 != 0) goto Lc8
            goto La6
        Lc8:
            goto L95
        Lcc:
            r4.label = r2
            goto L29
        Ld2:
            goto L91
        Ld5:
            goto L88
        Ld9:
            goto Lad
    }
}

