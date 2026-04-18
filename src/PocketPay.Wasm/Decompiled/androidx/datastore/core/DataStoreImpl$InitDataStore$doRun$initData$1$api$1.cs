namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001JA\u0010\u0002\u001a\u00028\u000021\u0010\u0003\u001a-\b\u0001\u0012\u0013\u0012\u00118\u0000¢\u0006\f\b\u0005\u0012\b\b\u0006\u0012\u0004\b\b(\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0004H\u0096@¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"androidx/datastore/core/DataStoreImpl$InitDataStore$doRun$initData$1$api$1", "Landroidx/datastore/core/InitializerApi;", "updateData", "transform", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "t", "Lkotlin/coroutines/Continuation;", "", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreImpl$InitDataStore$doRun$initData$1$api$1<T> : androidx.datastore.core.InitializerApi<T> {
    readonly kotlin.jvm.internal.Ref$objectRef<T> $currentData;
    readonly kotlin.jvm.internal.Ref$boolRef $initializationComplete;
    readonly kotlinx.coroutines.sync.Mutex $updateLock;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$InitDataStore$doRun$initData$1$api$1(kotlinx.coroutines.sync.Mutex mutex, kotlin.jvm.internal.Ref$boolRef ref$boolRef, kotlin.jvm.internal.Ref$objectRef<T> ref$objectRef, androidx.datastore.core.DataStoreImpl<T> dataStoreImpl) {
        this.$updateLock = mutex;
        this.$initializationComplete = ref$boolRef;
        this.$currentData = ref$objectRef;
        this.this$0 = dataStoreImpl;
    }

    public static bool CWKhKvtGBtCZnRMj(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void FVRLIrrOLydpbiyv(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object FYYMZgPSugAXBCvS() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object OgKYQOHlrvRbqZPu(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.string RvPLePJuYGCqeWfQ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void CREKfOPHYagJEFmh(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static void GzeuTAcYsOGFNtwp(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void KVqylFqkdqdsGjoK(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object KguYUVhRFmqXLuzf(androidx.datastore.core.DataStoreImpl dataStoreImpl, java.lang.object obj, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl.writeData$datastore_core_release(obj, z, continuation);
    }

    public static void QSyyYimuvgTnFsgw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object UZbYoKzKRMVWjdYF(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return mutex.lock(obj, continuation);
    }

    public static void WHhPQrKYBxlrQExg(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public override java.lang.object UpdateData(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1 dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1;
        kotlinx.coroutines.sync.Mutex mutex;
        kotlin.jvm.internal.Ref$boolRef ref$boolRef;
        kotlin.jvm.internal.Ref$objectRef<T> ref$objectRef;
        androidx.datastore.core.DataStoreImpl<T> dataStoreImpl;
        kotlinx.coroutines.sync.Mutex mutex2;
        kotlinx.coroutines.sync.Mutex mutex3;
        kotlin.jvm.internal.Ref$objectRef<T> ref$objectRef2;
        T t;
        if ((15 + 9) % 9 > 0) {
        }
        if (continuation is androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1) {
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1 = (androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1) continuation;
            if ((dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label & int.MIN_VALUE) == 0) {
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1(this, continuation);
            } else {
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label -= int.MIN_VALUE;
            }
        } else {
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1(this, continuation);
        }
        java.lang.object obj = dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.result;
        java.lang.object objFYYMZgPSugAXBCvS = FYYMZgPSugAXBCvS();
        int i = dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label;
        try {
            if (i == 0) {
                kVqylFqkdqdsGjoK(obj);
                mutex = this.$updateLock;
                ref$boolRef = this.$initializationComplete;
                ref$objectRef = this.$currentData;
                dataStoreImpl = this.this$0;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0 = function2;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1 = mutex;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2 = ref$boolRef;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$3 = ref$objectRef;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$4 = dataStoreImpl;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label = 1;
                if (uZbYoKzKRMVWjdYF(mutex, null, dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1) != objFYYMZgPSugAXBCvS) {
                }
                return objFYYMZgPSugAXBCvS;
            }
            if (i != 1) {
                if (i != 2) {
                    if (i != 3) {
                        throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                    }
                    t = (T) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2;
                    ref$objectRef2 = (kotlin.jvm.internal.Ref$objectRef) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1;
                    mutex2 = (kotlinx.coroutines.sync.Mutex) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0;
                    try {
                        gzeuTAcYsOGFNtwp(obj);
                        ref$objectRef2.element = t;
                        T t2 = ref$objectRef2.element;
                        cREKfOPHYagJEFmh(mutex2, null);
                        return t2;
                    } catch (java.lang.Exception th) {
                        th = th;
                        wHhPQrKYBxlrQExg(mutex2, null);
                        throw th;
                    }
                }
                dataStoreImpl = (androidx.datastore.core.DataStoreImpl) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2;
                ref$objectRef2 = (kotlin.jvm.internal.Ref$objectRef) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1;
                mutex3 = (kotlinx.coroutines.sync.Mutex) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0;
                try {
                    FVRLIrrOLydpbiyv(obj);
                    if (!CWKhKvtGBtCZnRMj(obj, ref$objectRef2.element)) {
                        dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0 = mutex3;
                        dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1 = ref$objectRef2;
                        dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2 = obj;
                        dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label = 3;
                        if (kguYUVhRFmqXLuzf(dataStoreImpl, obj, false, dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1) != objFYYMZgPSugAXBCvS) {
                            t = (T) obj;
                            mutex2 = mutex3;
                            ref$objectRef2.element = t;
                        }
                        return objFYYMZgPSugAXBCvS;
                    }
                    mutex2 = mutex3;
                    T t22 = ref$objectRef2.element;
                    cREKfOPHYagJEFmh(mutex2, null);
                    return t22;
                } catch (java.lang.Exception th2) {
                    th = th2;
                    mutex2 = mutex3;
                    wHhPQrKYBxlrQExg(mutex2, null);
                    throw th;
                }
            }
            dataStoreImpl = (androidx.datastore.core.DataStoreImpl) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$4;
            kotlin.jvm.internal.Ref$objectRef<T> ref$objectRef3 = (kotlin.jvm.internal.Ref$objectRef) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$3;
            ref$boolRef = (kotlin.jvm.internal.Ref$boolRef) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2;
            kotlinx.coroutines.sync.Mutex mutex4 = (kotlinx.coroutines.sync.Mutex) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1;
            kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function22 = (kotlin.jvm.functions.Function2) dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0;
            qSyyYimuvgTnFsgw(obj);
            ref$objectRef = ref$objectRef3;
            function2 = function22;
            mutex = mutex4;
            if (ref$boolRef.element) {
                throw new java.lang.IllegalStateException(RvPLePJuYGCqeWfQ("InitializerApi.updateData should not be called after initialization is complete."));
            }
            T t3 = ref$objectRef.element;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0 = mutex;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1 = ref$objectRef;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2 = dataStoreImpl;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$3 = null;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$4 = null;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label = 2;
            java.lang.object objOgKYQOHlrvRbqZPu = OgKYQOHlrvRbqZPu(function2, t3, dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1);
            if (objOgKYQOHlrvRbqZPu != objFYYMZgPSugAXBCvS) {
                mutex3 = mutex;
                obj = objOgKYQOHlrvRbqZPu;
                ref$objectRef2 = ref$objectRef;
                if (!CWKhKvtGBtCZnRMj(obj, ref$objectRef2.element)) {
                    dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$0 = mutex3;
                    dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$1 = ref$objectRef2;
                    dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.L$2 = obj;
                    dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1.label = 3;
                    if (kguYUVhRFmqXLuzf(dataStoreImpl, obj, false, dataStoreImpl$InitDataStore$doRun$initData$1$api$1$updateData$1) != objFYYMZgPSugAXBCvS) {
                        t = (T) obj;
                        mutex2 = mutex3;
                        ref$objectRef2.element = t;
                    }
                } else {
                    mutex2 = mutex3;
                }
                T t222 = ref$objectRef2.element;
                cREKfOPHYagJEFmh(mutex2, null);
                return t222;
            }
            return objFYYMZgPSugAXBCvS;
        } catch (java.lang.Exception th3) {
            th = th3;
            mutex2 = mutex;
            wHhPQrKYBxlrQExg(mutex2, null);
            throw th;
        }
    }
}

