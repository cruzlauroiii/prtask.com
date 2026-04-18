namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebTriggerAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebTriggerAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {182}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0831x91b1fc89 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest $request;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0831x91b1fc89(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest r2, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0831x91b1fc89> r3) {
            r0 = this;
            goto L1f
        L4:
            r0.<init>(r1, r3)
            goto L26
        Lb:
            r0.$request = r2
            goto L1a
        L11:
            r0.this$0 = r1
            goto Lb
        L17:
            goto L22
        L1a:
            r1 = 2
            goto L4
        L1f:
            goto L27
        L22:
            goto L11
        L26:
            return
        L27:
            goto L17
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto La
        L4:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r1.this$0
            goto L1e
        La:
            goto L2e
        Ld:
            goto L18
        L11:
            r2.<init>(r0, r1, r3)
            goto L27
        L18:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebTriggerAsync$1 r2 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebTriggerAsync$1
            goto L4
        L1e:
            androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest r1 = r1.$request
            goto L11
        L24:
            goto Ld
        L27:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L2d
        L2d:
            return r2
        L2e:
            goto L24
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Ld
        Ld:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L1b
        L15:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L7
        L1b:
            return r0
        L1c:
            goto L4
        L20:
            goto L1c
        L23:
            goto L15
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1b
        L1b:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerWebTriggerAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0831x91b1fc89) r0
            goto L21
        L21:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L27
        L27:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto Lb
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r5) {
            r4 = this;
            goto L4
        L4:
            goto L61
        L7:
            goto Lce
        Lb:
            goto L7
        Le:
            goto La3
        L11:
            goto L7c
        L15:
            int r0 = r0 % r1
            goto L99
        L1b:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L84
        L22:
            r4.label = r2
            goto L6a
        L28:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r5 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r5)
            goto L93
        L30:
            if (r1 != 0) goto L35
            goto Lca
        L35:
            goto La7
        L39:
            goto L78
        L3a:
            goto L45
        L3e:
            r4.<init>(r5)
            goto Lc9
        L45:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto Lb6
        L4b:
            int r1 = r4.label
            goto L72
        L51:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto La2
        L57:
            kotlin.ResultKt.throwOnFailure(r5)
            goto L39
        L5e:
            goto L11
        L61:
            goto Lb
        L65:
            r3 = r4
            goto Lbc
        L6a:
            java.lang.object r4 = r5.registerWebTrigger(r1, r3)
            goto L8a
        L72:
            r2 = 1
            goto L30
        L77:
            return r0
        L78:
            goto L51
        L7c:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4b
        L84:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r5 = r4.this$0
            goto L28
        L8a:
            if (r4 == r0) goto L8f
            goto L78
        L8f:
            goto L77
        L93:
            androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest r1 = r4.$request
            goto L65
        L99:
            if (r0 <= 0) goto L9e
            goto L11
        L9e:
            goto Le
        La2:
            return r4
        La3:
            goto L5e
        La7:
            if (r1 == r2) goto Lac
            goto L3a
        Lac:
            goto L57
        Lb0:
            int r0 = r0 + r1
            goto L15
        Lb6:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L3e
        Lbc:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L22
        Lc2:
            r1 = 29
            goto Lb0
        Lc9:
            throw r4
        Lca:
            goto L1b
        Lce:
            r0 = 9
            goto Lc2
    }
}

