namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {143}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0827x2c3ae252 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ android.net.Uri $attributionSource;
    readonly /* synthetic */ android.view.InputEvent $inputEvent;
    int label;
    readonly /* synthetic */ androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl this$0;

    C0827x2c3ae252(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl r1, android.net.Uri r2, android.view.InputEvent r3, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0827x2c3ae252> r4) {
            r0 = this;
            goto L25
        L4:
            r0.$inputEvent = r3
            goto La
        La:
            r1 = 2
            goto L18
        Lf:
            r0.$attributionSource = r2
            goto L4
        L15:
            goto L28
        L18:
            r0.<init>(r1, r4)
            goto L2c
        L1f:
            r0.this$0 = r1
            goto Lf
        L25:
            goto L2d
        L28:
            goto L1f
        L2c:
            return
        L2d:
            goto L15
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto La
        L4:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L33
        La:
            goto L65
        Ld:
            goto L5b
        L11:
            int r0 = r0 % r1
            goto L3e
        L17:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r0 = r2.this$0
            goto L1d
        L1d:
            android.net.Uri r1 = r2.$attributionSource
            goto L26
        L23:
            goto Ld
        L26:
            android.view.InputEvent r2 = r2.$inputEvent
            goto L54
        L2c:
            r1 = 30
            goto L38
        L33:
            return r3
        L34:
            goto L62
        L38:
            int r0 = r0 + r1
            goto L11
        L3e:
            if (r0 <= 0) goto L43
            goto L50
        L43:
            goto L4d
        L47:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1 r3 = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1
            goto L17
        L4d:
            goto L34
        L50:
            goto L47
        L54:
            r3.<init>(r0, r1, r2, r4)
            goto L4
        L5b:
            r0 = 28
            goto L2c
        L62:
            goto L50
        L65:
            goto L23
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1a
        L4:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L1d
        L14:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto L21
        L1a:
            goto Ld
        L1d:
            goto L14
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L14
        L4:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L21
        Lc:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L2a
        L14:
            goto L2b
        L17:
            goto L4
        L1b:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto Lc
        L21:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1 r0 = (androidx.privacysandbox.ads.adservices.java.measurement.C0827x2c3ae252) r0
            goto L1b
        L27:
            goto L17
        L2a:
            return r0
        L2b:
            goto L27
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
            r5 = this;
            goto L66
        L4:
            r5.<init>(r6)
            goto L90
        Lb:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto L4
        L11:
            r2 = 1
            goto L79
        L16:
            r4 = r5
            goto Ld5
        L1b:
            return r0
        L1c:
            goto L23
        L20:
            goto L69
        L23:
            kotlin.Unit r5 = kotlin.Unit.INSTANCE
            goto L6d
        L29:
            if (r5 == r0) goto L2e
            goto L1c
        L2e:
            goto L1b
        L32:
            androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl r6 = r5.this$0
            goto L88
        L38:
            int r0 = r0 % r1
            goto L56
        L3e:
            goto L6e
        L41:
            goto L9c
        L45:
            r5.label = r2
            goto Lab
        L4b:
            int r1 = r5.label
            goto L11
        L51:
            goto L1c
        L52:
            goto Lcf
        L56:
            if (r0 <= 0) goto L5b
            goto L41
        L5b:
            goto L3e
        L5f:
            r1 = 2
            goto Lc3
        L66:
            goto La7
        L69:
            goto Lbc
        L6d:
            return r5
        L6e:
            goto La4
        L72:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L51
        L79:
            if (r1 != 0) goto L7e
            goto L91
        L7e:
            goto Lb3
        L82:
            android.net.Uri r1 = r5.$attributionSource
            goto Lc9
        L88:
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager r6 = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks.Api33Ext5JavaImpl.access$getMMeasurementManager$p(r6)
            goto L82
        L90:
            throw r5
        L91:
            goto L95
        L95:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L32
        L9c:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L4b
        La4:
            goto L41
        La7:
            goto L20
        Lab:
            java.lang.object r5 = r6.registerSource(r1, r3, r4)
            goto L29
        Lb3:
            if (r1 == r2) goto Lb8
            goto L52
        Lb8:
            goto L72
        Lbc:
            r0 = 3
            goto L5f
        Lc3:
            int r0 = r0 + r1
            goto L38
        Lc9:
            android.view.InputEvent r3 = r5.$inputEvent
            goto L16
        Lcf:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto Lb
        Ld5:
            kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
            goto L45
    }
}

