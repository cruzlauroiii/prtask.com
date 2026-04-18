namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerTriggerAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerTriggerAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {162}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0829x9b0c78cd : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ android.net.Uri $trigger;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0829x9b0c78cd(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, android.net.Uri r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0829x9b0c78cd> r3) {
            r0 = this;
            goto L10
        L4:
            r0.<init>(r1, r3)
            goto L26
        Lb:
            r1 = 2
            goto L4
        L10:
            goto L27
        L13:
            goto L20
        L17:
            r0.$trigger = r2
            goto Lb
        L1d:
            goto L13
        L20:
            r0.this$0 = r1
            goto L17
        L26:
            return
        L27:
            goto L1d
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L13
        L4:
            goto L16
        L7:
            android.net.Uri r1 = r1.$trigger
            goto L25
        Ld:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r1.this$0
            goto L7
        L13:
            goto L1b
        L16:
            goto L1f
        L1a:
            return r2
        L1b:
            goto L4
        L1f:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerTriggerAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerTriggerAsync$1
            goto Ld
        L25:
            r2.<init>(r0, r1, r3)
            goto L2c
        L2c:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1a
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1a
        L4:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L12
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L1d
        L12:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto La
        L1a:
            goto Lb
        L1d:
            goto L21
        L21:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L4
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L12
        L4:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerTriggerAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0829x9b0c78cd) r0
            goto L19
        La:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L1f
        L12:
            goto L20
        L15:
            goto L27
        L19:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto La
        L1f:
            return r0
        L20:
            goto L24
        L24:
            goto L15
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L64
        L4:
            int r0 = r0 + r1
            goto L27
        La:
            java.lang.object r4 = r5.registerTrigger(r1, r3)
            goto L6b
        L12:
            kotlin.ResultKt.throwOnFailure(r5)
            goto Lc4
        L19:
            r0 = 32
            goto L20
        L20:
            r1 = 7
            goto L4
        L27:
            int r0 = r0 % r1
            goto L33
        L2d:
            android.net.Uri r1 = r4.$trigger
            goto Ld0
        L33:
            if (r0 <= 0) goto L38
            goto L8c
        L38:
            goto L89
        L3c:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L48
        L42:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Lca
        L48:
            return r4
        L49:
            goto L95
        L4d:
            if (r1 == r2) goto L52
            goto La5
        L52:
            goto L79
        L56:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r5 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r5)
            goto L2d
        L5e:
            int r1 = r4.label
            goto L90
        L64:
            goto L98
        L67:
            goto L19
        L6b:
            if (r4 == r0) goto L70
            goto Lc0
        L70:
            goto Lbf
        L74:
            throw r4
        L75:
            goto L12
        L79:
            kotlin.ResultKt.throwOnFailure(r5)
            goto La4
        L80:
            r4.label = r2
            goto La
        L86:
            goto L67
        L89:
            goto L49
        L8c:
            goto L9c
        L90:
            r2 = 1
            goto Lb0
        L95:
            goto L8c
        L98:
            goto L86
        L9c:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L5e
        La4:
            goto Lc0
        La5:
            goto L42
        La9:
            r4.<init>(r5)
            goto L74
        Lb0:
            if (r1 != 0) goto Lb5
            goto L75
        Lb5:
            goto L4d
        Lb9:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L80
        Lbf:
            return r0
        Lc0:
            goto L3c
        Lc4:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r5 = r4.this$0
            goto L56
        Lca:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto La9
        Ld0:
            r3 = r4
            goto Lb9
    }
}

