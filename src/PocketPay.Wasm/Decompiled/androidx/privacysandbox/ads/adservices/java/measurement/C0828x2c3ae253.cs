namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$2 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$2", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {154}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0828x2c3ae253 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0828x2c3ae253(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0828x2c3ae253> r3) {
            r0 = this;
            goto La
        L4:
            r0.$request = r2
            goto L1a
        La:
            goto L27
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0.this$0 = r1
            goto L4
        L1a:
            r1 = 2
            goto L1f
        L1f:
            r0.<init>(r1, r3)
            goto L26
        L26:
            return
        L27:
            goto L11
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L4
        L4:
            goto L28
        L7:
            goto L1a
        Lb:
            androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest r1 = r1.$request
            goto L20
        L11:
            goto L7
        L14:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L27
        L1a:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$2 r2 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$2
            goto L2c
        L20:
            r2.<init>(r0, r1, r3)
            goto L14
        L27:
            return r2
        L28:
            goto L11
        L2c:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r1.this$0
            goto Lb
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1a
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L1d
        Lc:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L12:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L4
        L1a:
            goto L5
        L1d:
            goto Lc
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L12
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L12
        L4:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L24
        Lc:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$2 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0828x2c3ae253) r0
            goto L29
        L12:
            goto L25
        L15:
            goto L1c
        L19:
            goto L15
        L1c:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Lc
        L24:
            return r0
        L25:
            goto L19
        L29:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L31
        L4:
            r0 = 27
            goto L1f
        Lb:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r5 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r5)
            goto L4a
        L13:
            goto L34
        L16:
            if (r4 == r0) goto L1b
            goto L2d
        L1b:
            goto L2c
        L1f:
            r1 = 23
            goto L44
        L26:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto Lbc
        L2c:
            return r0
        L2d:
            goto L7c
        L31:
            goto L69
        L34:
            goto L4
        L38:
            throw r4
        L39:
            goto L5f
        L3d:
            goto La0
        L40:
            goto Lc3
        L44:
            int r0 = r0 + r1
            goto La9
        L4a:
            androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest r1 = r4.$request
            goto Ld1
        L50:
            int r1 = r4.label
            goto La4
        L56:
            if (r0 <= 0) goto L5b
            goto L40
        L5b:
            goto L3d
        L5f:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L88
        L66:
            goto L40
        L69:
            goto L13
        L6d:
            if (r1 != 0) goto L72
            goto L39
        L72:
            goto L8e
        L76:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto Lcb
        L7c:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L9f
        L82:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L26
        L88:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r5 = r4.this$0
            goto Lb
        L8e:
            if (r1 == r2) goto L93
            goto Lb8
        L93:
            goto Laf
        L97:
            java.lang.object r4 = r5.registerSource(r1, r3)
            goto L16
        L9f:
            return r4
        La0:
            goto L66
        La4:
            r2 = 1
            goto L6d
        La9:
            int r0 = r0 % r1
            goto L56
        Laf:
            kotlin.ResultKt.throwOnFailure(r5)
            goto Lb6
        Lb6:
            goto L2d
        Lb8:
            goto L82
        Lbc:
            r4.<init>(r5)
            goto L38
        Lc3:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L50
        Lcb:
            r4.label = r2
            goto L97
        Ld1:
            r3 = r4
            goto L76
    }
}

