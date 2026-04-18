namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\u0010\u0000\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u0002\u0012\u0004\u0012\u00020\u00040\u0001\"\u0004\b\u0000\u0010\u00032\u0006\u0010\u0005\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Lkotlin/ValueTuple;", "Landroidx/datastore/core/State;", "T", "", "locked"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4", m533f = "DataStoreImpl.kt", m534i = {0, 1}, m535l = {306, 309}, m536m = "invokeSuspend", m537n = {"locked", "locked"}, m538s = {"Z$0", "Z$0"})
readonly class DataStoreImpl$readDataAndUpdateCache$4<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.bool, kotlin.coroutines.Continuation<? super kotlin.ValueTuple<? : androidx.datastore.core.State<T>, ? : java.lang.bool>>, java.lang.object> {
    readonly int $cachedVersion;
    java.lang.object L$0;
    bool Z$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataAndUpdateCache$4(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, int i, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
        this.$cachedVersion = i;
    }

    public static bool ACIWagcZYssglBKM(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void FimtMhgNSqssXIIo(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void HoqteurKzOCDWHrb(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ImsnBjMhsxadBxts(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.getVersion(continuation);
    }

    public static kotlin.ValueTuple MCrTGUgfChGRPNWl(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static java.lang.object PAoGbiGdIjCSKpYs(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4 dataStoreImpl$readDataAndUpdateCache$4, java.lang.object obj) {
        return dataStoreImpl$readDataAndUpdateCache$4.invokeSuspend(obj);
    }

    public static androidx.datastore.core.InterProcessCoordinator PHbjcANLOuPiNmLP(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static void YKMhQHBCPytgVZzq(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.bool YKdSPYyUuYzKbwgF(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool YYxqQsmksLasHoTY(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static java.lang.object JdFeiwbviCzGBnBa(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    public static bool LtkPhWykmrFmRFFW(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.object PXkMVgADybuxCSYQ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object PdzSxwAwUwKVxIYL(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4 dataStoreImpl$readDataAndUpdateCache$4, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataAndUpdateCache$4.invoke(z, continuation);
    }

    public static kotlin.coroutines.Continuation RsRZTsLfzSvtlbZG(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4 dataStoreImpl$readDataAndUpdateCache$4, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataAndUpdateCache$4.create(obj, continuation);
    }

    public static int SyYAPfoqYpjlrIoJ(java.lang.Number number) {
        return number.intValue();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((3 + 20) % 20 > 0) {
        }
        androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4 dataStoreImpl$readDataAndUpdateCache$4 = new androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4(this.this$0, this.$cachedVersion, continuation);
        dataStoreImpl$readDataAndUpdateCache$4.Z$0 = ACIWagcZYssglBKM((java.lang.bool) obj);
        return dataStoreImpl$readDataAndUpdateCache$4;
    }

    public override java.lang.object Invoke(java.lang.bool bool, java.lang.object obj) {
        return pdzSxwAwUwKVxIYL(this, ltkPhWykmrFmRFFW(bool), (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(bool z, kotlin.coroutines.Continuation<? super kotlin.ValueTuple<? : androidx.datastore.core.State<T>, java.lang.bool>> continuation) {
        return PAoGbiGdIjCSKpYs((androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4) rsRZTsLfzSvtlbZG(this, YKdSPYyUuYzKbwgF(z), continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.Exception th;
        bool z;
        int iSyYAPfoqYpjlrIoJ;
        ?? r1;
        androidx.datastore.core.ReadException readException;
        ?? r12;
        if ((19 + 26) % 26 > 0) {
        }
        java.lang.object objPXkMVgADybuxCSYQ = pXkMVgADybuxCSYQ();
        ?? r13 = this.label;
        try {
            readException = (androidx.datastore.core.State) obj;
            r12 = r13;
        } catch (java.lang.Exception th2) {
            if (r13 == 0) {
                iSyYAPfoqYpjlrIoJ = this.$cachedVersion;
                th = th2;
                r1 = r13;
            } else {
                androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorPHbjcANLOuPiNmLP = PHbjcANLOuPiNmLP(this.this$0);
                androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$4<T> dataStoreImpl$readDataAndUpdateCache$4 = this;
                this.L$0 = th2;
                this.Z$0 = r13;
                this.label = 2;
                java.lang.object objImsnBjMhsxadBxts = ImsnBjMhsxadBxts(interProcessCoordinatorPHbjcANLOuPiNmLP, dataStoreImpl$readDataAndUpdateCache$4);
                if (objImsnBjMhsxadBxts != objPXkMVgADybuxCSYQ) {
                    obj = objImsnBjMhsxadBxts;
                    th = th2;
                    z = r13 == true ? 1 : 0;
                    iSyYAPfoqYpjlrIoJ = syYAPfoqYpjlrIoJ((java.lang.Number) obj);
                    r1 = z;
                }
            }
        }
        if (r13 == 0) {
            YKMhQHBCPytgVZzq(obj);
            bool z2 = this.Z$0;
            this.Z$0 = z2;
            this.label = 1;
            obj = jdFeiwbviCzGBnBa(this.this$0, z2, this);
            r13 = z2;
            if (obj == objPXkMVgADybuxCSYQ) {
                return objPXkMVgADybuxCSYQ;
            }
        } else {
            if (r13 != 1) {
                if (r13 != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                z = this.Z$0;
                th = (java.lang.Exception) this.L$0;
                HoqteurKzOCDWHrb(obj);
                iSyYAPfoqYpjlrIoJ = syYAPfoqYpjlrIoJ((java.lang.Number) obj);
                r1 = z;
                readException = new androidx.datastore.core.ReadException(th, iSyYAPfoqYpjlrIoJ);
                r12 = r1;
                return MCrTGUgfChGRPNWl(readException, YYxqQsmksLasHoTY(r12));
            }
            bool z3 = this.Z$0;
            FimtMhgNSqssXIIo(obj);
            r13 = z3;
        }
        return MCrTGUgfChGRPNWl(readException, YYxqQsmksLasHoTY(r12));
    }
}

