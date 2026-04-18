namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\b\u0005\b\u0082\u0004\u0018\u00002\u00020\u0001BD\u0012=\u0010\u0002\u001a9\u00125\u00123\b\u0001\u0012\u0019\u0012\u0017\u0012\u0004\u0012\u00028\u00000\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\n0\t\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u00040\u0003¢\u0006\u0002\u0010\fJ\u000e\u0010\u000e\u001a\u00020\nH\u0094@¢\u0006\u0002\u0010\u000fRG\u0010\r\u001a;\u00125\u00123\b\u0001\u0012\u0019\u0012\u0017\u0012\u0004\u0012\u00028\u00000\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\n0\t\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/datastore/core/DataStoreImpl$InitDataStore;", "Landroidx/datastore/core/RunOnce;", "initTasksList", "", "Lkotlin/Function2;", "Landroidx/datastore/core/InitializerApi;", "Lkotlin/ParameterName;", "name", "api", "Lkotlin/coroutines/Continuation;", "", "", "(Landroidx/datastore/core/DataStoreImpl;Ljava/util/List;)V", "initTasks", "doRun", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$InitDataStore : androidx.datastore.core.RunOnce {
    private java.util.List<? : kotlin.jvm.functions.Function2<? super androidx.datastore.core.InitializerApi<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object>> initTasks;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    public DataStoreImpl$InitDataStore(androidx.datastore.core.DataStoreImpl dataStoreImpl, java.util.List<? : kotlin.jvm.functions.Function2<? super androidx.datastore.core.InitializerApi<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object>> list) {
        YMepovvMjymZbPTE(list, "initTasksList");
        this.this$0 = dataStoreImpl;
        this.initTasks = SmWwDxmCVTmyksLu(list);
    }

    public static void EOvzXtEaBItPAGPV(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void EolTrTqjAkTKIUqM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool OJiAvOdBTOAOupIY(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.List SmWwDxmCVTmyksLu(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toList(iterable);
    }

    public static void YMepovvMjymZbPTE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ZFzRDictionaryLmZcffPKO(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.lock(function1, continuation);
    }

    public static readonly java.util.List access$getInitTasks$p(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore) {
        return dataStoreImpl$InitDataStore.initTasks;
    }

    public static readonly void access$setInitTasks$p(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore, java.util.List list) {
        dataStoreImpl$InitDataStore.initTasks = list;
    }

    public static void ApMmmoryDzqJmjVR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.core.DataStoreInMemoryCache GGDhrRGevAEiwDLe(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static androidx.datastore.core.State HDeeXCQVBaLiSxMk(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache, androidx.datastore.core.State state) {
        return dataStoreInMemoryCache.tryUpdate(state);
    }

    public static void IMPJDYCwticKOCDJ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object OPlsnUsAuagMyGua() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.datastore.core.InterProcessCoordinator TUygVaDbChHEuIpJ(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static java.lang.object UHZlEErohqRLIbpY(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    /*
    */
    protected override java.lang.object DoRun(kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$1 dataStoreImpl$InitDataStore$doRun$1;
        androidx.datastore.core.Data data2;
        if ((16 + 14) % 14 > 0) {
        }
        if (continuation is androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$1) {
            dataStoreImpl$InitDataStore$doRun$1 = (androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$1) continuation;
            if ((dataStoreImpl$InitDataStore$doRun$1.label & int.MIN_VALUE) == 0) {
                dataStoreImpl$InitDataStore$doRun$1 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$1(this, continuation);
            } else {
                dataStoreImpl$InitDataStore$doRun$1.label -= int.MIN_VALUE;
            }
        } else {
            dataStoreImpl$InitDataStore$doRun$1 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$1(this, continuation);
        }
        java.lang.object objUHZlEErohqRLIbpY = dataStoreImpl$InitDataStore$doRun$1.result;
        java.lang.object objOPlsnUsAuagMyGua = oPlsnUsAuagMyGua();
        int i = dataStoreImpl$InitDataStore$doRun$1.label;
        if (i == 0) {
            iMPJDYCwticKOCDJ(objUHZlEErohqRLIbpY);
            java.util.List<? : kotlin.jvm.functions.Function2<? super androidx.datastore.core.InitializerApi<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object>> list = this.initTasks;
            if (list == 0) {
                androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
                dataStoreImpl$InitDataStore$doRun$1.L$0 = this;
                dataStoreImpl$InitDataStore$doRun$1.label = 1;
                objUHZlEErohqRLIbpY = uHZlEErohqRLIbpY(dataStoreImpl, false, dataStoreImpl$InitDataStore$doRun$1);
            } else {
                EOvzXtEaBItPAGPV(list);
                if (OJiAvOdBTOAOupIY(list)) {
                    androidx.datastore.core.DataStoreImpl<T> dataStoreImpl2 = this.this$0;
                    dataStoreImpl$InitDataStore$doRun$1.L$0 = this;
                    dataStoreImpl$InitDataStore$doRun$1.label = 1;
                    objUHZlEErohqRLIbpY = uHZlEErohqRLIbpY(dataStoreImpl2, false, dataStoreImpl$InitDataStore$doRun$1);
                } else {
                    androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorTUygVaDbChHEuIpJ = tUygVaDbChHEuIpJ(this.this$0);
                    androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1 dataStoreImpl$InitDataStore$doRun$initData$1 = new androidx.datastore.core.DataStoreImpl$InitDataStore$doRun$initData$1(this.this$0, this, null);
                    dataStoreImpl$InitDataStore$doRun$1.L$0 = this;
                    dataStoreImpl$InitDataStore$doRun$1.label = 2;
                    objUHZlEErohqRLIbpY = ZFzRDictionaryLmZcffPKO(interProcessCoordinatorTUygVaDbChHEuIpJ, dataStoreImpl$InitDataStore$doRun$initData$1, dataStoreImpl$InitDataStore$doRun$1);
                }
            }
            return objOPlsnUsAuagMyGua;
        }
        if (i == 1) {
            this = (androidx.datastore.core.DataStoreImpl$InitDataStore) dataStoreImpl$InitDataStore$doRun$1.L$0;
            apMmmoryDzqJmjVR(objUHZlEErohqRLIbpY);
            data2 = (androidx.datastore.core.Data) objUHZlEErohqRLIbpY;
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (androidx.datastore.core.DataStoreImpl$InitDataStore) dataStoreImpl$InitDataStore$doRun$1.L$0;
            EolTrTqjAkTKIUqM(objUHZlEErohqRLIbpY);
            data2 = (androidx.datastore.core.Data) objUHZlEErohqRLIbpY;
        }
        hDeeXCQVBaLiSxMk(gGDhrRGevAEiwDLe(this.this$0), data2);
        return kotlin.Unit.INSTANCE;
    }
}

