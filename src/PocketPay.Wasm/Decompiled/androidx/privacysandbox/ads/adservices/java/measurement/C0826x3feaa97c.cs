namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {190}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0826x3feaa97c : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.int>, java.lang.object> {
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0826x3feaa97c(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0826x3feaa97c> r2) {
            r0 = this;
            goto Ld
        L4:
            r0.this$0 = r1
            goto L20
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
        L19:
            r0.<init>(r1, r2)
            goto L14
        L20:
            r1 = 2
            goto L19
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r1, kotlin.coroutines.Continuation<object> r2) {
            r0 = this;
            goto L19
        L4:
            r1.<init>(r0, r2)
            goto L20
        Lb:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r0.this$0
            goto L4
        L11:
            return r1
        L12:
            goto L16
        L16:
            goto L1c
        L19:
            goto L12
        L1c:
            goto L26
        L20:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L11
        L26:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1 r1 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1
            goto Lb
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<java.lang.int> r2) {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            return r0
        L8:
            goto L4
        Lc:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L1a
        L12:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L7
        L1a:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L12
        L20:
            goto L8
        L23:
            goto Lc
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<java.lang.int> r2) {
            r0 = this;
            goto L1c
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L23
        Lc:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L14
        L14:
            return r0
        L15:
            goto L19
        L19:
            goto L1f
        L1c:
            goto L15
        L1f:
            goto L4
        L23:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0826x3feaa97c) r0
            goto L29
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Lc
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r4) {
            r3 = this;
            goto L30
        L4:
            return r3
        L5:
            goto L3e
        L9:
            int r0 = r0 + r1
            goto L2a
        Lf:
            return r4
        L10:
            goto Lc3
        L14:
            r1 = r3
            goto L9f
        L19:
            kotlin.ResultKt.throwOnFailure(r4)
            goto Lad
        L20:
            return r0
        L21:
            goto L4
        L25:
            throw r3
        L26:
            goto L19
        L2a:
            int r0 = r0 % r1
            goto Lba
        L30:
            goto L41
        L33:
            goto L81
        L37:
            goto L5
        L3a:
            goto L53
        L3e:
            goto L3a
        L41:
            goto L7e
        L45:
            r3.<init>(r4)
            goto L25
        L4c:
            kotlin.ResultKt.throwOnFailure(r4)
            goto Lf
        L53:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L73
        L5b:
            if (r1 == r2) goto L60
            goto L10
        L60:
            goto L4c
        L64:
            if (r1 != 0) goto L69
            goto L26
        L69:
            goto L5b
        L6d:
            r3.label = r2
            goto La5
        L73:
            int r1 = r3.label
            goto L79
        L79:
            r2 = 1
            goto L64
        L7e:
            goto L33
        L81:
            r0 = 23
            goto Lb3
        L88:
            java.lang.string r4 = "call to 'resume' before 'invoke' with coroutine"
            goto L45
        L8e:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r4 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r4)
            goto L14
        L96:
            if (r3 == r0) goto L9b
            goto L21
        L9b:
            goto L20
        L9f:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L6d
        La5:
            java.lang.object r3 = r4.getMeasurementApiStatus(r1)
            goto L96
        Lad:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r4 = r3.this$0
            goto L8e
        Lb3:
            r1 = 19
            goto L9
        Lba:
            if (r0 <= 0) goto Lbf
            goto L3a
        Lbf:
            goto L37
        Lc3:
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException
            goto L88
    }
}

