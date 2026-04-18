namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.migrations.Dictionary<string, object>Migration$3", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Dictionary<string, object>Migration$3<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int label;

    Dictionary<string, object>Migration$3(kotlin.coroutines.Continuation<? super androidx.datastore.migrations.Dictionary<string, object>Migration$3> continuation) {
        super(2, continuation);
    }

    public static java.lang.object BsjiCJrjhJFDPpfd(androidx.datastore.migrations.Dictionary<string, object>Migration$3 sharedPreferencesMigration$3, java.lang.object obj) {
        return sharedPreferencesMigration$3.invokeSuspend(obj);
    }

    public static java.lang.object HxygBSDbmSstveUK() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void DywSidcbitHNNkAA(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object EaJVdivsnCWNsQFg(androidx.datastore.migrations.Dictionary<string, object>Migration$3 sharedPreferencesMigration$3, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$3.invoke2(obj, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static java.lang.bool FVXnKdDbTFynWtZK(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static kotlin.coroutines.Continuation ZAVcfzRBZmSFqIDH(androidx.datastore.migrations.Dictionary<string, object>Migration$3 sharedPreferencesMigration$3, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$3.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.migrations.Dictionary<string, object>Migration$3(continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return eaJVdivsnCWNsQFg(this, obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return BsjiCJrjhJFDPpfd((androidx.datastore.migrations.Dictionary<string, object>Migration$3) zAVcfzRBZmSFqIDH(this, t, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        HxygBSDbmSstveUK();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        dywSidcbitHNNkAA(obj);
        return fVXnKdDbTFynWtZK(true);
    }
}

