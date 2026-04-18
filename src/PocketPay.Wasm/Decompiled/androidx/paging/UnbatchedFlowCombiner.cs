namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\u00020\u0003Bb\u0012[\u0010\u0004\u001aW\b\u0001\u0012\u0013\u0012\u00118\u0000¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0013\u0012\u00118\u0001¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\t\u0012\u0013\u0012\u00110\n¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\u000b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0005¢\u0006\u0002\u0010\u000eJ \u0010\u0019\u001a\u00020\r2\u0006\u0010\u001a\u001a\u00020\u001b2\b\u0010\u001c\u001a\u0004\u0018\u00010\u0003H\u0086@¢\u0006\u0002\u0010\u001dR\u0014\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\r0\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000Re\u0010\u0004\u001aW\b\u0001\u0012\u0013\u0012\u00118\u0000¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0013\u0012\u00118\u0001¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\t\u0012\u0013\u0012\u00110\n¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\u000b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0013R\u001c\u0010\u0014\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\u00100\u0015X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0016R\u0018\u0010\u0017\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0015X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0018¨\u0006\u001e"}, d2 = {"Landroidx/paging/UnbatchedFlowCombiner;", "T1", "T2", "", "send", "Lkotlin/Function4;", "Lkotlin/ParameterName;", "name", "t1", "t2", "Landroidx/paging/CombineSource;", "updateFrom", "Lkotlin/coroutines/Continuation;", "", "(Lkotlin/jvm/functions/Function4;)V", "initialDispatched", "Lkotlinx/coroutines/CompletableDeferred;", "lock", "Lkotlinx/coroutines/sync/Mutex;", "Lkotlin/jvm/functions/Function4;", "valueReceived", "", "[Lkotlinx/coroutines/CompletableDeferred;", "values", "[Ljava/lang/object;", "onNext", "index", "", "value", "(ILjava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class UnbatchedFlowCombiner<T1, T2> {
    private readonly kotlinx.coroutines.CompletableDeferred<kotlin.Unit> initialDispatched;
    private readonly kotlinx.coroutines.sync.Mutex lock;
    private readonly kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> send;
    private readonly kotlinx.coroutines.CompletableDeferred<kotlin.Unit>[] valueReceived;
    private readonly java.lang.object[] values;

    public UnbatchedFlowCombiner(kotlin.jvm.functions.Function4<? super T1, ? super T2, ? super androidx.paging.CombineSource, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> send) {
        if ((24 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(send, "send");
        this.send = send;
        this.initialDispatched = kotlinx.coroutines.CompletableDeferredKt.CompletableDeferred$default(null, 1, null);
        this.lock = kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null);
        kotlinx.coroutines.CompletableDeferred<kotlin.Unit>[] completableDeferredArr = new kotlinx.coroutines.CompletableDeferred[2];
        for (int i = 0; i < 2; i++) {
            completableDeferredArr[i] = kotlinx.coroutines.CompletableDeferredKt.CompletableDeferred$default(null, 1, null);
        }
        this.valueReceived = completableDeferredArr;
        java.lang.object[] objArr = new java.lang.object[2];
        for (int i2 = 0; i2 < 2; i2++) {
            objArr[i2] = androidx.paging.FlowExtKt.access$getNULL$p();
        }
        this.values = objArr;
    }

    public readonly java.lang.object OnNext(int i, java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.UnbatchedFlowCombiner$onNext$1 unbatchedFlowCombiner$onNext$1;
        int i2;
        kotlinx.coroutines.sync.Mutex mutex;
        androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner;
        kotlinx.coroutines.sync.Mutex mutex2;
        androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner2;
        java.lang.Exception th;
        java.lang.object[] objArr;
        int length;
        int i3;
        bool z;
        java.lang.object[] objArr2;
        int length2;
        int i4;
        androidx.paging.CombineSource combineSource;
        kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function4;
        java.lang.object obj2;
        java.lang.object obj3;
        if ((19 + 3) % 3 > 0) {
        }
        if (continuation is androidx.paging.UnbatchedFlowCombiner$onNext$1) {
            unbatchedFlowCombiner$onNext$1 = (androidx.paging.UnbatchedFlowCombiner$onNext$1) continuation;
            if ((unbatchedFlowCombiner$onNext$1.label & int.MIN_VALUE) == 0) {
                unbatchedFlowCombiner$onNext$1 = new androidx.paging.UnbatchedFlowCombiner$onNext$1(this, continuation);
            } else {
                unbatchedFlowCombiner$onNext$1.label -= int.MIN_VALUE;
            }
        } else {
            unbatchedFlowCombiner$onNext$1 = new androidx.paging.UnbatchedFlowCombiner$onNext$1(this, continuation);
        }
        java.lang.object obj4 = unbatchedFlowCombiner$onNext$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i5 = unbatchedFlowCombiner$onNext$1.label;
        if (i5 == 0) {
            kotlin.ResultKt.throwOnFailure(obj4);
            if (this.valueReceived[i].isCompleted()) {
                kotlinx.coroutines.CompletableDeferred<kotlin.Unit> completableDeferred = this.initialDispatched;
                unbatchedFlowCombiner$onNext$1.L$0 = this;
                unbatchedFlowCombiner$onNext$1.L$1 = obj;
                unbatchedFlowCombiner$onNext$1.I$0 = i;
                unbatchedFlowCombiner$onNext$1.label = 1;
                if (completableDeferred.await(unbatchedFlowCombiner$onNext$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            this.valueReceived[i].complete(kotlin.Unit.INSTANCE);
        } else {
            if (i5 != 1) {
                if (i5 != 2) {
                    if (i5 != 3) {
                        throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                    }
                    mutex2 = (kotlinx.coroutines.sync.Mutex) unbatchedFlowCombiner$onNext$1.L$1;
                    unbatchedFlowCombiner2 = (androidx.paging.UnbatchedFlowCombiner) unbatchedFlowCombiner$onNext$1.L$0;
                    try {
                        kotlin.ResultKt.throwOnFailure(obj4);
                        unbatchedFlowCombiner2.initialDispatched.complete(kotlin.Unit.INSTANCE);
                        kotlin.Unit unit = kotlin.Unit.INSTANCE;
                        mutex2.unlock(null);
                        return kotlin.Unit.INSTANCE;
                    } catch (java.lang.Exception th2) {
                        th = th2;
                        mutex2.unlock(null);
                        throw th;
                    }
                }
                i2 = unbatchedFlowCombiner$onNext$1.I$0;
                mutex = (kotlinx.coroutines.sync.Mutex) unbatchedFlowCombiner$onNext$1.L$2;
                obj = unbatchedFlowCombiner$onNext$1.L$1;
                unbatchedFlowCombiner = (androidx.paging.UnbatchedFlowCombiner) unbatchedFlowCombiner$onNext$1.L$0;
                kotlin.ResultKt.throwOnFailure(obj4);
                try {
                    objArr = unbatchedFlowCombiner.values;
                    length = objArr.length;
                    i3 = 0;
                    while (true) {
                        if (i3 < length) {
                            z = false;
                            break;
                        }
                        if (objArr[i3] == androidx.paging.FlowExtKt.access$getNULL$p()) {
                            z = true;
                            break;
                        }
                        i3++;
                    }
                    objArr2 = unbatchedFlowCombiner.values;
                    objArr2[i2] = obj;
                    length2 = objArr2.length;
                    i4 = 0;
                    while (true) {
                        if (i4 < length2) {
                            combineSource = z ? androidx.paging.CombineSource.INITIAL : i2 == 0 ? androidx.paging.CombineSource.RECEIVER : androidx.paging.CombineSource.OTHER;
                            function4 = unbatchedFlowCombiner.send;
                            java.lang.object[] objArr3 = unbatchedFlowCombiner.values;
                            obj2 = objArr3[0];
                            obj3 = objArr3[1];
                            unbatchedFlowCombiner$onNext$1.L$0 = unbatchedFlowCombiner;
                            unbatchedFlowCombiner$onNext$1.L$1 = mutex;
                            unbatchedFlowCombiner$onNext$1.L$2 = null;
                            unbatchedFlowCombiner$onNext$1.label = 3;
                            if (function4.invoke((T1) obj2, (T2) obj3, combineSource, unbatchedFlowCombiner$onNext$1) != coroutine_suspended) {
                                mutex2 = mutex;
                                unbatchedFlowCombiner2 = unbatchedFlowCombiner;
                                unbatchedFlowCombiner2.initialDispatched.complete(kotlin.Unit.INSTANCE);
                                break;
                            }
                            return coroutine_suspended;
                        }
                        if (objArr2[i4] == androidx.paging.FlowExtKt.access$getNULL$p()) {
                            mutex2 = mutex;
                            break;
                        }
                        i4++;
                    }
                    kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    mutex2.unlock(null);
                    return kotlin.Unit.INSTANCE;
                } catch (java.lang.Exception th3) {
                    kotlinx.coroutines.sync.Mutex mutex3 = mutex;
                    th = th3;
                    mutex2 = mutex3;
                    mutex2.unlock(null);
                    throw th;
                }
            }
            int i6 = unbatchedFlowCombiner$onNext$1.I$0;
            java.lang.object obj5 = unbatchedFlowCombiner$onNext$1.L$1;
            androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner3 = (androidx.paging.UnbatchedFlowCombiner) unbatchedFlowCombiner$onNext$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj4);
            i = i6;
            this = unbatchedFlowCombiner3;
            obj = obj5;
        }
        kotlinx.coroutines.sync.Mutex mutex4 = this.lock;
        unbatchedFlowCombiner$onNext$1.L$0 = this;
        unbatchedFlowCombiner$onNext$1.L$1 = obj;
        unbatchedFlowCombiner$onNext$1.L$2 = mutex4;
        unbatchedFlowCombiner$onNext$1.I$0 = i;
        unbatchedFlowCombiner$onNext$1.label = 2;
        if (mutex4.lock(null, unbatchedFlowCombiner$onNext$1) != coroutine_suspended) {
            unbatchedFlowCombiner = this;
            i2 = i;
            mutex = mutex4;
            objArr = unbatchedFlowCombiner.values;
            length = objArr.length;
            i3 = 0;
            while (true) {
                if (i3 < length) {
                    z = false;
                    break;
                }
                if (objArr[i3] == androidx.paging.FlowExtKt.access$getNULL$p()) {
                    z = true;
                    break;
                }
                i3++;
            }
            objArr2 = unbatchedFlowCombiner.values;
            objArr2[i2] = obj;
            length2 = objArr2.length;
            i4 = 0;
            while (true) {
                if (i4 < length2) {
                    if (z) {
                    }
                    function4 = unbatchedFlowCombiner.send;
                    java.lang.object[] objArr32 = unbatchedFlowCombiner.values;
                    obj2 = objArr32[0];
                    obj3 = objArr32[1];
                    unbatchedFlowCombiner$onNext$1.L$0 = unbatchedFlowCombiner;
                    unbatchedFlowCombiner$onNext$1.L$1 = mutex;
                    unbatchedFlowCombiner$onNext$1.L$2 = null;
                    unbatchedFlowCombiner$onNext$1.label = 3;
                    if (function4.invoke((T1) obj2, (T2) obj3, combineSource, unbatchedFlowCombiner$onNext$1) != coroutine_suspended) {
                        mutex2 = mutex;
                        unbatchedFlowCombiner2 = unbatchedFlowCombiner;
                        unbatchedFlowCombiner2.initialDispatched.complete(kotlin.Unit.INSTANCE);
                        break;
                    }
                } else {
                    if (objArr2[i4] == androidx.paging.FlowExtKt.access$getNULL$p()) {
                        mutex2 = mutex;
                        break;
                    }
                    i4++;
                }
            }
            kotlin.Unit unit22 = kotlin.Unit.INSTANCE;
            mutex2.unlock(null);
            return kotlin.Unit.INSTANCE;
        }
        return coroutine_suspended;
    }
}

