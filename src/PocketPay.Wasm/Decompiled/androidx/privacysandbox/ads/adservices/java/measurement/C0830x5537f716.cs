namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebSourceAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebSourceAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {172}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0830x5537f716 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0830x5537f716(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0830x5537f716> r3) {
            r0 = this;
            goto L1e
        L4:
            r1 = 2
            goto L9
        L9:
            r0.<init>(r1, r3)
            goto L10
        L10:
            return
        L11:
            goto L1b
        L15:
            r0.$request = r2
            goto L4
        L1b:
            goto L21
        L1e:
            goto L11
        L21:
            goto L25
        L25:
            r0.this$0 = r1
            goto L15
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L1f
        Lb:
            return r2
        Lc:
            goto L16
        L10:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r1.this$0
            goto L25
        L16:
            goto L7
        L19:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Lb
        L1f:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebSourceAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebSourceAsync$1
            goto L10
        L25:
            androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest r1 = r1.$request
            goto L2b
        L2b:
            r2.<init>(r0, r1, r3)
            goto L19
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L10
        L4:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto La
        La:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L10:
            goto L1b
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            return r0
        L1b:
            goto L17
        L1f:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L1a
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L25
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L10
        La:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebSourceAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0830x5537f716) r0
            goto L4
        L10:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L18
        L18:
            return r0
        L19:
            goto L2c
        L1d:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto La
        L25:
            goto L19
        L28:
            goto L1d
        L2c:
            goto L28
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto Lcf
        L4:
            r0 = 21
            goto Lb1
        Lb:
            return r0
        Lc:
            goto L70
        L10:
            r4.label = r2
            goto L1c
        L16:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L10
        L1c:
            java.lang.object r4 = r5.registerWebSource(r1, r3)
            goto L46
        L24:
            goto L8f
        L27:
            goto Lbf
        L2b:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Lab
        L31:
            r2 = 1
            goto L99
        L36:
            int r1 = r4.label
            goto L31
        L3c:
            throw r4
        L3d:
            goto Lb8
        L41:
            r3 = r4
            goto L16
        L46:
            if (r4 == r0) goto L4b
            goto Lc
        L4b:
            goto Lb
        L4f:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r5 = r4.this$0
            goto Lc7
        L55:
            androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest r1 = r4.$request
            goto L41
        L5b:
            r4.<init>(r5)
            goto L3c
        L62:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L36
        L6a:
            int r0 = r0 + r1
            goto L7d
        L70:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto Lc2
        L76:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L93
        L7d:
            int r0 = r0 % r1
            goto L83
        L83:
            if (r0 <= 0) goto L88
            goto L8f
        L88:
            goto L8c
        L8c:
            goto Lc3
        L8f:
            goto L62
        L93:
            goto Lc
        L95:
            goto L2b
        L99:
            if (r1 != 0) goto L9e
            goto L3d
        L9e:
            goto La2
        La2:
            if (r1 == r2) goto La7
            goto L95
        La7:
            goto L76
        Lab:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L5b
        Lb1:
            r1 = 7
            goto L6a
        Lb8:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L4f
        Lbf:
            goto Ld2
        Lc2:
            return r4
        Lc3:
            goto L24
        Lc7:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r5 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r5)
            goto L55
        Lcf:
            goto L27
        Ld2:
            goto L4
    }
}

