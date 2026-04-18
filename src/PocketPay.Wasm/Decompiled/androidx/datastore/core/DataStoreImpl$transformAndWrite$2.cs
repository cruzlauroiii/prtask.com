namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0004\n\u0002\b\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001H\u008a@"}, d2 = {"<anonymous>", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$transformAndWrite$2", m533f = "DataStoreImpl.kt", m534i = {1, 2}, m535l = {330, 331, 337}, m536m = "invokeSuspend", m537n = {"curData", "newData"}, m538s = {"L$0", "L$0"})
readonly class DataStoreImpl$transformAndWrite$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly kotlin.coroutines.Coroutineobject $callerobject;
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> $transform;
    java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$transformAndWrite$2(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$transformAndWrite$2> continuation) {
        super(1, continuation);
        this.this$0 = dataStoreImpl;
        this.$callerobject = coroutineobject;
        this.$transform = function2;
    }

    public static kotlin.coroutines.Continuation BpZnbPQCQNBkBySS(androidx.datastore.core.DataStoreImpl$transformAndWrite$2 dataStoreImpl$transformAndWrite$2, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$transformAndWrite$2.create(continuation);
    }

    public static java.lang.object HTvnbpRmszcoRkQM(androidx.datastore.core.DataStoreImpl$transformAndWrite$2 dataStoreImpl$transformAndWrite$2, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$transformAndWrite$2.invoke(continuation);
    }

    public static java.lang.object ILrJtMcLYvdHmqtx(androidx.datastore.core.DataStoreImpl dataStoreImpl, java.lang.object obj, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl.writeData$datastore_core_release(obj, z, continuation);
    }

    public static java.lang.object LKtvpxFhgrgWDrli(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    public static void NiTQrjRtqPqKIFfq(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void PPfuHUVlEZgBBoOG(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object RSMjjbfHPMKXvYLc(androidx.datastore.core.DataStoreImpl$transformAndWrite$2 dataStoreImpl$transformAndWrite$2, java.lang.object obj) {
        return dataStoreImpl$transformAndWrite$2.invokeSuspend(obj);
    }

    public static java.lang.object SYrrZYmMEJrgdznW() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object WLncBTMfwJeVMKwo(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.BuildersKt.withobject(coroutineobject, function2, continuation);
    }

    public static void MybuMMjPVmawEbNz(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object NCMfuFIPMXCgEQlv(androidx.datastore.core.Data data2) {
        return data2.getValue();
    }

    public static bool PAcNlkTMpOAeaNcV(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void XJpcPSpvgLoFaSXm(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void YlUfHaBtaQxqZRbi(androidx.datastore.core.Data data2) {
        data2.checkHashCode();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((3 + 29) % 29 > 0) {
        }
        return new androidx.datastore.core.DataStoreImpl$transformAndWrite$2(this.this$0, this.$callerobject, this.$transform, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return HTvnbpRmszcoRkQM(this, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<T> continuation) {
        return RSMjjbfHPMKXvYLc((androidx.datastore.core.DataStoreImpl$transformAndWrite$2) BpZnbPQCQNBkBySS(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.datastore.core.Data data2;
        androidx.datastore.core.DataStoreImpl<T> dataStoreImpl;
        androidx.datastore.core.DataStoreImpl$transformAndWrite$2<T> dataStoreImpl$transformAndWrite$2;
        if ((11 + 32) % 32 > 0) {
        }
        java.lang.object objSYrrZYmMEJrgdznW = SYrrZYmMEJrgdznW();
        int i = this.label;
        if (i == 0) {
            xJpcPSpvgLoFaSXm(obj);
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl2 = this.this$0;
            androidx.datastore.core.DataStoreImpl$transformAndWrite$2<T> dataStoreImpl$transformAndWrite$22 = this;
            this.label = 1;
            obj = LKtvpxFhgrgWDrli(dataStoreImpl2, true, dataStoreImpl$transformAndWrite$22);
            if (obj != objSYrrZYmMEJrgdznW) {
            }
            return objSYrrZYmMEJrgdznW;
        }
        if (i == 1) {
            NiTQrjRtqPqKIFfq(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                java.lang.object obj2 = this.L$0;
                mybuMMjPVmawEbNz(obj);
                return obj2;
            }
            data2 = (androidx.datastore.core.Data) this.L$0;
            PPfuHUVlEZgBBoOG(obj);
        }
        ylUfHaBtaQxqZRbi(data2);
        if (!pAcNlkTMpOAeaNcV(nCMfuFIPMXCgEQlv(data2), obj)) {
            dataStoreImpl = this.this$0;
            dataStoreImpl$transformAndWrite$2 = this;
            this.L$0 = obj;
            this.label = 3;
            if (ILrJtMcLYvdHmqtx(dataStoreImpl, obj, true, dataStoreImpl$transformAndWrite$2) == objSYrrZYmMEJrgdznW) {
                return objSYrrZYmMEJrgdznW;
            }
        }
        return obj;
        data2 = (androidx.datastore.core.Data) obj;
        kotlin.coroutines.Coroutineobject coroutineobject = this.$callerobject;
        androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1 dataStoreImpl$transformAndWrite$2$newData$1 = new androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1(this.$transform, data2, null);
        androidx.datastore.core.DataStoreImpl$transformAndWrite$2<T> dataStoreImpl$transformAndWrite$23 = this;
        this.L$0 = data2;
        this.label = 2;
        obj = WLncBTMfwJeVMKwo(coroutineobject, dataStoreImpl$transformAndWrite$2$newData$1, dataStoreImpl$transformAndWrite$23);
        if (obj != objSYrrZYmMEJrgdznW) {
            ylUfHaBtaQxqZRbi(data2);
            if (!pAcNlkTMpOAeaNcV(nCMfuFIPMXCgEQlv(data2), obj)) {
                dataStoreImpl = this.this$0;
                dataStoreImpl$transformAndWrite$2 = this;
                this.L$0 = obj;
                this.label = 3;
                if (ILrJtMcLYvdHmqtx(dataStoreImpl, obj, true, dataStoreImpl$transformAndWrite$2) == objSYrrZYmMEJrgdznW) {
                }
            }
            return obj;
        }
        return objSYrrZYmMEJrgdznW;
    }
}

