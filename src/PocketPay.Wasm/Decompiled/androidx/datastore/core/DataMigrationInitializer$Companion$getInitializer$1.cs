namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "api", "Landroidx/datastore/core/InitializerApi;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1", m533f = "DataMigrationInitializer.kt", m534i = {}, m535l = {33}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataMigrationInitializer$Companion$getInitializer$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.core.InitializerApi<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.List<androidx.datastore.core.DataMigration<T>> $migrations;
    java.lang.object L$0;
    int label;

    DataMigrationInitializer$Companion$getInitializer$1(java.util.List<? : androidx.datastore.core.DataMigration<T>> list, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1> continuation) {
        super(2, continuation);
        this.$migrations = list;
    }

    public static void ICQIBOLmDybpcwBE(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object IPKLeUwAiPxBhRMF(androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1 dataMigrationInitializer$Companion$getInitializer$1, androidx.datastore.core.InitializerApi initializerApi, kotlin.coroutines.Continuation continuation) {
        return dataMigrationInitializer$Companion$getInitializer$1.invoke(initializerApi, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object RBUGnnXcLLFXcVtQ(androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1 dataMigrationInitializer$Companion$getInitializer$1, java.lang.object obj) {
        return dataMigrationInitializer$Companion$getInitializer$1.invokeSuspend(obj);
    }

    public static java.lang.object SWvVFMvxgvssIgQm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object DxEHbRdHvZtAXCds(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, java.util.List list, androidx.datastore.core.InitializerApi initializerApi, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataMigrationInitializer$Companion.access$runMigrations(dataMigrationInitializer$Companion, list, initializerApi, continuation);
    }

    public static kotlin.coroutines.Continuation RoJcqMuHIIrzTSHd(androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1 dataMigrationInitializer$Companion$getInitializer$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataMigrationInitializer$Companion$getInitializer$1.create(obj, continuation);
    }

    public static void WDdqraLugjjNGtzO(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1 dataMigrationInitializer$Companion$getInitializer$1 = new androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1(this.$migrations, continuation);
        dataMigrationInitializer$Companion$getInitializer$1.L$0 = obj;
        return dataMigrationInitializer$Companion$getInitializer$1;
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.InitializerApi<T> initializerApi, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RBUGnnXcLLFXcVtQ((androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1) roJcqMuHIIrzTSHd(this, initializerApi, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return IPKLeUwAiPxBhRMF(this, (androidx.datastore.core.InitializerApi) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((26 + 19) % 19 > 0) {
        }
        java.lang.object objSWvVFMvxgvssIgQm = SWvVFMvxgvssIgQm();
        int i = this.label;
        if (i == 0) {
            wDdqraLugjjNGtzO(obj);
            androidx.datastore.core.InitializerApi initializerApi = (androidx.datastore.core.InitializerApi) this.L$0;
            androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion = androidx.datastore.core.DataMigrationInitializer.Companion;
            java.util.List<androidx.datastore.core.DataMigration<T>> list = this.$migrations;
            androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1<T> dataMigrationInitializer$Companion$getInitializer$1 = this;
            this.label = 1;
            if (dxEHbRdHvZtAXCds(dataMigrationInitializer$Companion, list, initializerApi, dataMigrationInitializer$Companion$getInitializer$1) == objSWvVFMvxgvssIgQm) {
                return objSWvVFMvxgvssIgQm;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ICQIBOLmDybpcwBE(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

