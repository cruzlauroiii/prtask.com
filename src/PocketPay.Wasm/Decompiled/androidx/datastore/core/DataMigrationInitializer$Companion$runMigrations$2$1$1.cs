namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1", m533f = "DataMigrationInitializer.kt", m534i = {}, m535l = {45}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataMigrationInitializer$Companion$runMigrations$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.datastore.core.DataMigration<T> $migration;
    int label;

    DataMigrationInitializer$Companion$runMigrations$2$1$1(androidx.datastore.core.DataMigration<T> dataMigration, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1> continuation) {
        super(1, continuation);
        this.$migration = dataMigration;
    }

    public static void HnCRpcxbwsFjGXPp(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation KEuKJRTejlwCISmJ(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1 dataMigrationInitializer$Companion$runMigrations$2$1$1, kotlin.coroutines.Continuation continuation) {
        return dataMigrationInitializer$Companion$runMigrations$2$1$1.create(continuation);
    }

    public static java.lang.object XFkjQxvdsMxSPfmV(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1 dataMigrationInitializer$Companion$runMigrations$2$1$1, kotlin.coroutines.Continuation continuation) {
        return dataMigrationInitializer$Companion$runMigrations$2$1$1.invoke2((kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object CkHCBcmmIuyzEqUH(androidx.datastore.core.DataMigration dataMigration, kotlin.coroutines.Continuation continuation) {
        return dataMigration.cleanUp(continuation);
    }

    public static java.lang.object TSpvvLaXNqcLUqci() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void UtJnYiXuBNuxbhdW(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object VHGwyyGZrnGwFpdZ(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1 dataMigrationInitializer$Companion$runMigrations$2$1$1, java.lang.object obj) {
        return dataMigrationInitializer$Companion$runMigrations$2$1$1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1(this.$migration, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return XFkjQxvdsMxSPfmV(this, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return vHGwyyGZrnGwFpdZ((androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1) KEuKJRTejlwCISmJ(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 23) % 23 > 0) {
        }
        java.lang.object objTSpvvLaXNqcLUqci = tSpvvLaXNqcLUqci();
        int i = this.label;
        if (i == 0) {
            HnCRpcxbwsFjGXPp(obj);
            androidx.datastore.core.DataMigration<T> dataMigration = this.$migration;
            androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1 dataMigrationInitializer$Companion$runMigrations$2$1$1 = this;
            this.label = 1;
            if (ckHCBcmmIuyzEqUH(dataMigration, dataMigrationInitializer$Companion$runMigrations$2$1$1) == objTSpvvLaXNqcLUqci) {
                return objTSpvvLaXNqcLUqci;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            utJnYiXuBNuxbhdW(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

