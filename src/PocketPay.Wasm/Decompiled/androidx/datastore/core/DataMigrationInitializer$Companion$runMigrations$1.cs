namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataMigrationInitializer$Companion", m533f = "DataMigrationInitializer.kt", m534i = {0, 1}, m535l = {42, 57}, m536m = "runMigrations", m537n = {"cleanUps", "cleanUpFailure"}, m538s = {"L$0", "L$0"})
readonly class DataMigrationInitializer$Companion$runMigrations$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataMigrationInitializer$Companion this$0;

    DataMigrationInitializer$Companion$runMigrations$1(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1> continuation) {
        super(continuation);
        this.this$0 = dataMigrationInitializer$Companion;
    }

    public static java.lang.object QknkqUJALEWWnBHl(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, java.util.List list, androidx.datastore.core.InitializerApi initializerApi, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataMigrationInitializer$Companion.access$runMigrations(dataMigrationInitializer$Companion, list, initializerApi, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return QknkqUJALEWWnBHl(this.this$0, null, null, this);
    }
}

