namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/core/Data;", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1", m533f = "DataStoreImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 2, 2, 2}, m535l = {437, 458, 546, 468}, m536m = "invokeSuspend", m537n = {"updateLock", "initializationComplete", "currentData", "updateLock", "initializationComplete", "currentData", "api", "initializationComplete", "currentData", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2"})
readonly class DataStoreImpl$InitDataStore$doRun$initData$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<? super androidx.datastore.core.Data<T>>, java.lang.object> {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    readonly androidx.datastore.core.DataStoreImpl$InitDataStore this$1;

    DataStoreImpl$InitDataStore$doRun$initData$1(androidx.datastore.core.DataStoreImpl dataStoreImpl, androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore, kotlin.coroutines.Continuation continuation) {
        super(1, continuation);
        this.this$0 = dataStoreImpl;
        this.this$1 = dataStoreImpl$InitDataStore;
    }

    public static void FhrZWDMyZKkQhlgJ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object GvGElVOrjyoWTbkU(androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1 dataStoreImpl$InitDataStore$doRun$initData$1, java.lang.object obj) {
        return dataStoreImpl$InitDataStore$doRun$initData$1.invokeSuspend(obj);
    }

    public static java.lang.object IoQFvUzlNWthEvon(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object OPHNuKNWmeYVZOWc(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    public static java.lang.object PYZxuPiHtJWyyruC(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.getVersion(continuation);
    }

    public static java.util.IEnumerator PncpbDYofdmGDVqg(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object QzhNPBsXOFTvBPaD(androidx.datastore.core.Data data2) {
        return data2.getValue();
    }

    public static kotlinx.coroutines.sync.Mutex SSpBcEHYvnMBLLLQ(bool z, int i, java.lang.object obj) {
        return kotlinx.coroutines.sync.MutexKt.Mutex$default(z, i, obj);
    }

    public static kotlin.coroutines.Continuation XCZwFRLUcnFXMxVm(androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1 dataStoreImpl$InitDataStore$doRun$initData$1, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$InitDataStore$doRun$initData$1.create(continuation);
    }

    public static java.util.List YTPGOYeFlMKvanTX(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore) {
        return androidx.datastore.core.DataStoreImpl$InitDataStore.access$getInitTasks$p(dataStoreImpl$InitDataStore);
    }

    public static java.lang.object ZgQCtKViKsZqPahv(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return mutex.lock(obj, continuation);
    }

    public static int DgDchxoirujNWCmx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void GNkbkuiYlhaHWsAH(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object IFlyaCiSEKjqFTJN() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.datastore.core.InterProcessCoordinator LVfozPnVXfUWPDjq(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static void LufXQOKXDSdOEWAd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int LxEtEoMQHGESeRTz(java.lang.Number number) {
        return number.intValue();
    }

    public static void MRPtIRINDSSOLTDW(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore, java.util.List list) {
        androidx.datastore.core.DataStoreImpl$InitDataStore.access$setInitTasks$p(dataStoreImpl$InitDataStore, list);
    }

    public static void MuXvWWmtFhJVaUpV(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object REDijTHtZidRULnc(androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1 dataStoreImpl$InitDataStore$doRun$initData$1, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$InitDataStore$doRun$initData$1.invoke(continuation);
    }

    public static void RUkRjNtFRPYQposJ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void RduXWrhzAoFWmPCN(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object TwqxCMNNFFKeUzBa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool UVnuIXBSNmNxQtOk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YxvRYXzPuPyiiNQT(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((15 + 22) % 22 > 0) {
        }
        return new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1(this.this$0, this.this$1, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return rEDijTHtZidRULnc(this, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<? super androidx.datastore.core.Data<T>> continuation) {
        return GvGElVOrjyoWTbkU((androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1) XCZwFRLUcnFXMxVm(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.IEnumerator itPncpbDYofdmGDVqg;
        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1 dataStoreImpl$InitDataStore$doRun$initData$1$api$1;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        kotlin.jvm.internal.Ref$boolRef ref$boolRef;
        kotlinx.coroutines.sync.Mutex mutex;
        int i;
        java.lang.object obj2;
        kotlinx.coroutines.sync.Mutex mutex2;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef2;
        kotlin.jvm.internal.Ref$boolRef ref$boolRef2;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef3;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef4;
        kotlin.jvm.internal.Ref$boolRef ref$boolRef3;
        kotlinx.coroutines.sync.Mutex mutexSSpBcEHYvnMBLLLQ;
        T t;
        int iDgDchxoirujNWCmx;
        java.lang.object objPYZxuPiHtJWyyruC;
        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1<T> dataStoreImpl$InitDataStore$doRun$initData$1;
        kotlin.jvm.functions.Function2 function2;
        if ((32 + 8) % 8 > 0) {
        }
        java.lang.object objIFlyaCiSEKjqFTJN = iFlyaCiSEKjqFTJN();
        int i2 = this.label;
        if (i2 == 0) {
            FhrZWDMyZKkQhlgJ(obj);
            mutexSSpBcEHYvnMBLLLQ = SSpBcEHYvnMBLLLQ(false, 1, null);
            ref$boolRef3 = new kotlin.jvm.internal.Ref$boolRef();
            ref$objectRef3 = new kotlin.jvm.internal.Ref$objectRef();
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1<T> dataStoreImpl$InitDataStore$doRun$initData$12 = this;
            this.L$0 = mutexSSpBcEHYvnMBLLLQ;
            this.L$1 = ref$boolRef3;
            this.L$2 = ref$objectRef3;
            this.L$3 = ref$objectRef3;
            this.label = 1;
            obj = OPHNuKNWmeYVZOWc(dataStoreImpl, true, dataStoreImpl$InitDataStore$doRun$initData$12);
            if (obj != objIFlyaCiSEKjqFTJN) {
                ref$objectRef4 = ref$objectRef3;
            }
            return objIFlyaCiSEKjqFTJN;
        }
        if (i2 == 1) {
            ref$objectRef3 = (kotlin.jvm.internal.Ref$objectRef) this.L$3;
            ref$objectRef4 = (kotlin.jvm.internal.Ref$objectRef) this.L$2;
            ref$boolRef3 = (kotlin.jvm.internal.Ref$boolRef) this.L$1;
            mutexSSpBcEHYvnMBLLLQ = (kotlinx.coroutines.sync.Mutex) this.L$0;
            rUkRjNtFRPYQposJ(obj);
        } else {
            if (i2 == 2) {
                itPncpbDYofdmGDVqg = (java.util.IEnumerator) this.L$4;
                dataStoreImpl$InitDataStore$doRun$initData$1$api$1 = (androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1) this.L$3;
                ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) this.L$2;
                ref$boolRef = (kotlin.jvm.internal.Ref$boolRef) this.L$1;
                mutex = (kotlinx.coroutines.sync.Mutex) this.L$0;
                yxvRYXzPuPyiiNQT(obj);
                while (uVnuIXBSNmNxQtOk(itPncpbDYofdmGDVqg)) {
                    function2 = (kotlin.jvm.functions.Function2) twqxCMNNFFKeUzBa(itPncpbDYofdmGDVqg);
                    this.L$0 = mutex;
                    this.L$1 = ref$boolRef;
                    this.L$2 = ref$objectRef;
                    this.L$3 = dataStoreImpl$InitDataStore$doRun$initData$1$api$1;
                    this.L$4 = itPncpbDYofdmGDVqg;
                    this.label = 2;
                    if (IoQFvUzlNWthEvon(function2, dataStoreImpl$InitDataStore$doRun$initData$1$api$1, this) != objIFlyaCiSEKjqFTJN) {
                        return objIFlyaCiSEKjqFTJN;
                    }
                }
                ref$objectRef4 = ref$objectRef;
                ref$boolRef2 = ref$boolRef;
                mutex2 = mutex;
                mRPtIRINDSSOLTDW(this.this$1, null);
                dataStoreImpl$InitDataStore$doRun$initData$1 = this;
                this.L$0 = ref$boolRef2;
                this.L$1 = ref$objectRef4;
                this.L$2 = mutex2;
                this.L$3 = null;
                this.L$4 = null;
                this.label = 3;
                if (ZgQCtKViKsZqPahv(mutex2, null, dataStoreImpl$InitDataStore$doRun$initData$1) != objIFlyaCiSEKjqFTJN) {
                    ref$objectRef2 = ref$objectRef4;
                    try {
                        ref$boolRef2.element = true;
                        kotlin.Unit unit = kotlin.Unit.INSTANCE;
                        muXvWWmtFhJVaUpV(mutex2, null);
                        t = ref$objectRef2.element;
                        T t2 = ref$objectRef2.element;
                        iDgDchxoirujNWCmx = t2 is not null ? dgDchxoirujNWCmx(t2) : 0;
                        androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorLVfozPnVXfUWPDjq = lVfozPnVXfUWPDjq(this.this$0);
                        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1<T> dataStoreImpl$InitDataStore$doRun$initData$13 = this;
                        this.L$0 = t;
                        this.L$1 = null;
                        this.L$2 = null;
                        this.I$0 = iDgDchxoirujNWCmx;
                        this.label = 4;
                        objPYZxuPiHtJWyyruC = PYZxuPiHtJWyyruC(interProcessCoordinatorLVfozPnVXfUWPDjq, dataStoreImpl$InitDataStore$doRun$initData$13);
                        if (objPYZxuPiHtJWyyruC != objIFlyaCiSEKjqFTJN) {
                            obj = objPYZxuPiHtJWyyruC;
                            obj2 = t;
                            i = iDgDchxoirujNWCmx;
                        }
                    } catch (java.lang.Exception th) {
                        gNkbkuiYlhaHWsAH(mutex2, null);
                        throw th;
                    }
                }
                return objIFlyaCiSEKjqFTJN;
            }
            if (i2 == 3) {
                mutex2 = (kotlinx.coroutines.sync.Mutex) this.L$2;
                ref$objectRef2 = (kotlin.jvm.internal.Ref$objectRef) this.L$1;
                ref$boolRef2 = (kotlin.jvm.internal.Ref$boolRef) this.L$0;
                rduXWrhzAoFWmPCN(obj);
                ref$boolRef2.element = true;
                kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                muXvWWmtFhJVaUpV(mutex2, null);
                t = ref$objectRef2.element;
                T t22 = ref$objectRef2.element;
                if (t22 is not null) {
                }
                androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorLVfozPnVXfUWPDjq2 = lVfozPnVXfUWPDjq(this.this$0);
                androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1<T> dataStoreImpl$InitDataStore$doRun$initData$132 = this;
                this.L$0 = t;
                this.L$1 = null;
                this.L$2 = null;
                this.I$0 = iDgDchxoirujNWCmx;
                this.label = 4;
                objPYZxuPiHtJWyyruC = PYZxuPiHtJWyyruC(interProcessCoordinatorLVfozPnVXfUWPDjq2, dataStoreImpl$InitDataStore$doRun$initData$132);
                if (objPYZxuPiHtJWyyruC != objIFlyaCiSEKjqFTJN) {
                    obj = objPYZxuPiHtJWyyruC;
                    obj2 = t;
                    i = iDgDchxoirujNWCmx;
                }
                return objIFlyaCiSEKjqFTJN;
            }
            if (i2 != 4) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            i = this.I$0;
            obj2 = this.L$0;
            lufXQOKXDSdOEWAd(obj);
        }
        return new androidx.datastore.core.Data(obj2, i, lxEtEoMQHGESeRTz((java.lang.Number) obj));
        ref$objectRef3.element = (T) QzhNPBsXOFTvBPaD((androidx.datastore.core.Data) obj);
        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1 dataStoreImpl$InitDataStore$doRun$initData$1$api$12 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1$api$1(mutexSSpBcEHYvnMBLLLQ, ref$boolRef3, ref$objectRef4, this.this$0);
        java.util.List listYTPGOYeFlMKvanTX = YTPGOYeFlMKvanTX(this.this$1);
        if (listYTPGOYeFlMKvanTX is null) {
            ref$boolRef2 = ref$boolRef3;
            mutex2 = mutexSSpBcEHYvnMBLLLQ;
        } else {
            itPncpbDYofdmGDVqg = PncpbDYofdmGDVqg(listYTPGOYeFlMKvanTX);
            mutex = mutexSSpBcEHYvnMBLLLQ;
            ref$boolRef = ref$boolRef3;
            ref$objectRef = ref$objectRef4;
            dataStoreImpl$InitDataStore$doRun$initData$1$api$1 = dataStoreImpl$InitDataStore$doRun$initData$1$api$12;
            while (uVnuIXBSNmNxQtOk(itPncpbDYofdmGDVqg)) {
                function2 = (kotlin.jvm.functions.Function2) twqxCMNNFFKeUzBa(itPncpbDYofdmGDVqg);
                this.L$0 = mutex;
                this.L$1 = ref$boolRef;
                this.L$2 = ref$objectRef;
                this.L$3 = dataStoreImpl$InitDataStore$doRun$initData$1$api$1;
                this.L$4 = itPncpbDYofdmGDVqg;
                this.label = 2;
                if (IoQFvUzlNWthEvon(function2, dataStoreImpl$InitDataStore$doRun$initData$1$api$1, this) != objIFlyaCiSEKjqFTJN) {
                    return objIFlyaCiSEKjqFTJN;
                }
            }
            ref$objectRef4 = ref$objectRef;
            ref$boolRef2 = ref$boolRef;
            mutex2 = mutex;
        }
        mRPtIRINDSSOLTDW(this.this$1, null);
        dataStoreImpl$InitDataStore$doRun$initData$1 = this;
        this.L$0 = ref$boolRef2;
        this.L$1 = ref$objectRef4;
        this.L$2 = mutex2;
        this.L$3 = null;
        this.L$4 = null;
        this.label = 3;
        if (ZgQCtKViKsZqPahv(mutex2, null, dataStoreImpl$InitDataStore$doRun$initData$1) != objIFlyaCiSEKjqFTJN) {
            ref$objectRef2 = ref$objectRef4;
            ref$boolRef2.element = true;
            kotlin.Unit unit22 = kotlin.Unit.INSTANCE;
            muXvWWmtFhJVaUpV(mutex2, null);
            t = ref$objectRef2.element;
            T t222 = ref$objectRef2.element;
            if (t222 is not null) {
            }
            androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorLVfozPnVXfUWPDjq22 = lVfozPnVXfUWPDjq(this.this$0);
            androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1<T> dataStoreImpl$InitDataStore$doRun$initData$1322 = this;
            this.L$0 = t;
            this.L$1 = null;
            this.L$2 = null;
            this.I$0 = iDgDchxoirujNWCmx;
            this.label = 4;
            objPYZxuPiHtJWyyruC = PYZxuPiHtJWyyruC(interProcessCoordinatorLVfozPnVXfUWPDjq22, dataStoreImpl$InitDataStore$doRun$initData$1322);
            if (objPYZxuPiHtJWyyruC != objIFlyaCiSEKjqFTJN) {
                obj = objPYZxuPiHtJWyyruC;
                obj2 = t;
                i = iDgDchxoirujNWCmx;
                return new androidx.datastore.core.Data(obj2, i, lxEtEoMQHGESeRTz((java.lang.Number) obj));
            }
        }
        return objIFlyaCiSEKjqFTJN;
    }
}

