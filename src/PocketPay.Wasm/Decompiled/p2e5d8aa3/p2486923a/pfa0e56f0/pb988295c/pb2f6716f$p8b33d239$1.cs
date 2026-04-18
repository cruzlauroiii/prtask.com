namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.paymentsettings.priority.PaymentPriorityobjectModel$onSavePaymentTypePriority$1", m533f = "PaymentPriorityobjectModel.kt", m534i = {0}, m535l = {98}, m536m = "invokeSuspend", m537n = {"devicePaymentHashSettings"}, m538s = {"L$0"})
readonly class pb2f6716f$p8b33d239$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f8283f38d;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f this$0;

    pb2f6716f$p8b33d239$1(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f pb2f6716fVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p8b33d239$1> continuation) {
        super(2, continuation);
        this.this$0 = pb2f6716fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p8b33d239$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p8b33d239$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> list;
        if ((8 + 24) % 24 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                java.util.List listM3d6d22cf = p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m3d6d22cf(this.this$0);
                if (listM3d6d22cf is null) {
                    return kotlin.Unit.INSTANCE;
                }
                java.util.List list2 = listM3d6d22cf;
                java.util.List listM80090114 = p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m80090114(this.this$0);
                java.util.List arrayList = new java.util.List();
                for (java.lang.object obj2 : listM80090114) {
                    if (!((pad5f82e8.p07214c67.pe0212e54.pb3950cbd) obj2).getSelected()) {
                        arrayList.Add(obj2);
                    }
                }
                java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> listPlus = kotlin.collections.ICollectionsKt.plus((java.util.ICollection) list2, (java.lang.IEnumerable) arrayList);
                this.L$0 = listPlus;
                this.fd304ba20 = 1;
                if (p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.mb272891c(this.this$0).setActualPaymentPriorityHashSettings(listPlus, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
                list = listPlus;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                list = (java.util.List) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.me871c9c0(this.this$0).setValue(kotlin.Unit.INSTANCE);
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m7cadda21(this.this$0, list);
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m7dadceac(this.this$0, null, 1, null);
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
        }
        return kotlin.Unit.INSTANCE;
    }
}

