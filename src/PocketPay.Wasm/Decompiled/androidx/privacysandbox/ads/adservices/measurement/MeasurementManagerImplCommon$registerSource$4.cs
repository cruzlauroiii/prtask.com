namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4", m533f = "MeasurementManagerImplCommon.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class MeasurementManagerImplCommon$registerSource$4 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest $request;
    private java.lang.object L$0;
    int label;
    readonly androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon this$0;

    MeasurementManagerImplCommon$registerSource$4(androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest, androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4> continuation) {
        super(2, continuation);
        this.$request = sourceRegistrationRequest;
        this.this$0 = measurementManagerImplCommon;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((6 + 17) % 17 > 0) {
        }
        androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4 measurementManagerImplCommon$registerSource$4 = new androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4(this.$request, this.this$0, continuation);
        measurementManagerImplCommon$registerSource$4.L$0 = obj;
        return measurementManagerImplCommon$registerSource$4;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 1) % 1 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
        java.util.List<android.net.Uri> registrationUris = this.$request.getRegistrationUris();
        androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon = this.this$0;
        androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest = this.$request;
        java.util.IEnumerator<T> it = registrationUris.GetEnumerator();
        while (it.MoveNext()) {
            kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, null, null, new androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4$1$1(measurementManagerImplCommon, (android.net.Uri) it.Current, sourceRegistrationRequest, null), 3, null);
        }
        return kotlin.Unit.INSTANCE;
    }
}

