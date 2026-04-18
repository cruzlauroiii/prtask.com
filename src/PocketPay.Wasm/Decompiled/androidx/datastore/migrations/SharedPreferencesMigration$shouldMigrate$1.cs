namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.migrations.Dictionary<string, object>Migration", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {0}, m535l = {151}, m536m = "shouldMigrate", m537n = {"this"}, m538s = {"L$0"})
readonly class Dictionary<string, object>Migration$shouldMigrate$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.migrations.Dictionary<string, object>Migration<T> this$0;

    Dictionary<string, object>Migration$shouldMigrate$1(androidx.datastore.migrations.Dictionary<string, object>Migration<T> sharedPreferencesMigration, kotlin.coroutines.Continuation<? super androidx.datastore.migrations.Dictionary<string, object>Migration$shouldMigrate$1> continuation) {
        super(continuation);
        this.this$0 = sharedPreferencesMigration;
    }

    public static java.lang.object HnGZJojTHNVHttCc(androidx.datastore.migrations.Dictionary<string, object>Migration sharedPreferencesMigration, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration.shouldMigrate(obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return hnGZJojTHNVHttCc(this.this$0, null, this);
    }
}

