namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {132}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0825x759ed5b3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.measurement.DeletionRequest $deletionRequest;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0825x759ed5b3(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, androidx.privacysandbox.ads.adservices.measurement.DeletionRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0825x759ed5b3> r3) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            r0.$deletionRequest = r2
            goto L19
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L1e
        L19:
            r1 = 2
            goto L24
        L1e:
            r0.this$0 = r1
            goto L7
        L24:
            r0.<init>(r1, r3)
            goto Ld
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto La
        L4:
            androidx.privacysandbox.ads.adservices.measurement.DeletionRequest r1 = r1.$deletionRequest
            goto L1a
        La:
            goto L28
        Ld:
            goto L21
        L11:
            goto Ld
        L14:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L27
        L1a:
            r2.<init>(r0, r1, r3)
            goto L14
        L21:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1
            goto L2c
        L27:
            return r2
        L28:
            goto L11
        L2c:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r1.this$0
            goto L4
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto Lf
        Lc:
            goto L23
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L1a
        L1a:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L20:
            goto L10
        L23:
            goto L14
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L28
        L4:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0825x759ed5b3) r0
            goto Lf
        La:
            return r0
        Lb:
            goto L15
        Lf:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L18
        L15:
            goto L2b
        L18:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto La
        L20:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L4
        L28:
            goto Lb
        L2b:
            goto L20
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto Laf
        L4:
            return r0
        L5:
            goto L78
        L9:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto Lc8
        Lf:
            if (r1 == r2) goto L14
            goto L68
        L14:
            goto Lbc
        L18:
            r1 = 23
            goto L84
        L1f:
            goto L3f
        L22:
            goto L75
        L26:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r5 = r4.this$0
            goto L34
        L2c:
            java.lang.object r4 = r5.deleteRegistrations(r1, r3)
            goto L52
        L34:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r5 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r5)
            goto Lb6
        L3c:
            goto La0
        L3f:
            goto L43
        L43:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L7e
        L4b:
            r0 = 22
            goto L18
        L52:
            if (r4 == r0) goto L57
            goto L5
        L57:
            goto L4
        L5b:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto Lcf
        L61:
            int r0 = r0 % r1
            goto L6c
        L67:
            goto L5
        L68:
            goto La9
        L6c:
            if (r0 <= 0) goto L71
            goto L3f
        L71:
            goto L3c
        L75:
            goto Lb2
        L78:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L9f
        L7e:
            int r1 = r4.label
            goto Lc3
        L84:
            int r0 = r0 + r1
            goto L61
        L8a:
            throw r4
        L8b:
            goto L98
        L8f:
            if (r1 != 0) goto L94
            goto L8b
        L94:
            goto Lf
        L98:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L26
        L9f:
            return r4
        La0:
            goto L1f
        La4:
            r3 = r4
            goto L5b
        La9:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L9
        Laf:
            goto L22
        Lb2:
            goto L4b
        Lb6:
            androidx.privacysandbox.ads.adservices.measurement.DeletionRequest r1 = r4.$deletionRequest
            goto La4
        Lbc:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L67
        Lc3:
            r2 = 1
            goto L8f
        Lc8:
            r4.<init>(r5)
            goto L8a
        Lcf:
            r4.label = r2
            goto L2c
    }
}

