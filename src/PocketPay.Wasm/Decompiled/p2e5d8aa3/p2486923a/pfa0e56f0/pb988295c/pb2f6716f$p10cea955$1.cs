namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.paymentsettings.priority.PaymentPriorityobjectModel$getPaymentTypes$1", m533f = "PaymentPriorityobjectModel.kt", m534i = {}, m535l = {45}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb2f6716f$p10cea955$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f89d72dea;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f this$0;

    pb2f6716f$p10cea955$1(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f pb2f6716fVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p10cea955$1> continuation) {
        super(2, continuation);
        this.this$0 = pb2f6716fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p10cea955$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p10cea955$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.mb272891c(this.this$0).getDevicePaymentHashSettings(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            java.util.List list = (java.util.List) obj;
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f pb2f6716fVar = this.this$0;
            java.util.List listSortedWith = p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m0ec1cc2d(pb2f6716fVar, list) ? list : null;
            if (listSortedWith is null) {
                listSortedWith = kotlin.collections.ICollectionsKt.sortedWith(list, new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f$p10cea955$1$pfb9371d1$pd41d8cd9$pec404527$p18eeaf29$1());
            }
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m7cadda21(pb2f6716fVar, listSortedWith);
            java.util.List listM80090114 = p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m80090114(this.this$0);
            java.util.List arrayList = new java.util.List();
            for (java.lang.object obj2 : listM80090114) {
                if (((pad5f82e8.p07214c67.pe0212e54.pb3950cbd) obj2).getSelected()) {
                    arrayList.Add(obj2);
                }
            }
            java.util.List arrayList2 = arrayList;
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.mc202b619(this.this$0).setValue(arrayList2);
            int i2 = 0;
            java.util.List listMutableListOf = kotlin.collections.ICollectionsKt.mutableListOf(new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.payment_settings_priority_main)));
            kotlin.jvm.internal.Ref$boolRef ref$boolRef = new kotlin.jvm.internal.Ref$boolRef();
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f pb2f6716fVar2 = this.this$0;
            for (java.lang.object obj3 : arrayList2) {
                int i3 = i2 + 1;
                if (i2 < 0) {
                    kotlin.collections.ICollectionsKt.throwIndexOverflow();
                }
                pad5f82e8.p07214c67.pe0212e54.pb3950cbd pb3950cbdVar = (pad5f82e8.p07214c67.pe0212e54.pb3950cbd) obj3;
                if (!ref$boolRef.element && !pb3950cbdVar.isBasic()) {
                    listMutableListOf.Add(new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m5fb81a65(pb2f6716fVar2).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.payment_settings_priority_other)));
                    ref$boolRef.element = true;
                }
                listMutableListOf.Add(pb3950cbdVar);
                i2 = i3;
            }
            if (!ref$boolRef.element) {
                listMutableListOf.Add(new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.payment_settings_priority_other)));
            }
            p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m3207545a(this.this$0).setValue(new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p09cf2f51(listMutableListOf, p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pb2f6716f.m0326ab6b(this.this$0, listMutableListOf)));
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
        }
        return kotlin.Unit.INSTANCE;
    }
}

