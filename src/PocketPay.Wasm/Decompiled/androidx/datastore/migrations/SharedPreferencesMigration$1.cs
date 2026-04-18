namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.migrations.Dictionary<string, object>Migration$1", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Dictionary<string, object>Migration$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int label;

    Dictionary<string, object>Migration$1(kotlin.coroutines.Continuation<? super androidx.datastore.migrations.Dictionary<string, object>Migration$1> continuation) {
        super(2, continuation);
    }

    public static void FkfsXyfcMLelQqqn(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object MsGHdHeuPTXbwkVm(androidx.datastore.migrations.Dictionary<string, object>Migration$1 sharedPreferencesMigration$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$1.invoke2(obj, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static kotlin.coroutines.Continuation SXrNaZJafPZxzFUL(androidx.datastore.migrations.Dictionary<string, object>Migration$1 sharedPreferencesMigration$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$1.create(obj, continuation);
    }

    public static java.lang.object IIahGmrddRlKMNXO(androidx.datastore.migrations.Dictionary<string, object>Migration$1 sharedPreferencesMigration$1, java.lang.object obj) {
        return sharedPreferencesMigration$1.invokeSuspend(obj);
    }

    public static java.lang.object LJwYhFmcpdCenwiA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.bool SJsTltEeIqwBBQkz(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.migrations.Dictionary<string, object>Migration$1(continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return MsGHdHeuPTXbwkVm(this, obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return iIahGmrddRlKMNXO((androidx.datastore.migrations.Dictionary<string, object>Migration$1) SXrNaZJafPZxzFUL(this, t, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        lJwYhFmcpdCenwiA();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        FkfsXyfcMLelQqqn(obj);
        return sJsTltEeIqwBBQkz(true);
    }
}

