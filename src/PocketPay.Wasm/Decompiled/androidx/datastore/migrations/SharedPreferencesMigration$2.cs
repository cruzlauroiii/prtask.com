namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.migrations.Dictionary<string, object>Migration$2", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Dictionary<string, object>Migration$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int label;

    Dictionary<string, object>Migration$2(kotlin.coroutines.Continuation<? super androidx.datastore.migrations.Dictionary<string, object>Migration$2> continuation) {
        super(2, continuation);
    }

    public static java.lang.object DIHDahSFrYbTEcta(androidx.datastore.migrations.Dictionary<string, object>Migration$2 sharedPreferencesMigration$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$2.invoke2(obj, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static java.lang.object MxFVDLQuPzgDwOqq(androidx.datastore.migrations.Dictionary<string, object>Migration$2 sharedPreferencesMigration$2, java.lang.object obj) {
        return sharedPreferencesMigration$2.invokeSuspend(obj);
    }

    public static java.lang.object TEnNiAGXXTSbTvdO() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Continuation DvBUGNTsbUaFeGLZ(androidx.datastore.migrations.Dictionary<string, object>Migration$2 sharedPreferencesMigration$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigration$2.create(obj, continuation);
    }

    public static void IZzLEgXMdOwmVudb(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.bool XQomJKFNucyDscRj(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.migrations.Dictionary<string, object>Migration$2(continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return DIHDahSFrYbTEcta(this, obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return MxFVDLQuPzgDwOqq((androidx.datastore.migrations.Dictionary<string, object>Migration$2) dvBUGNTsbUaFeGLZ(this, t, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        TEnNiAGXXTSbTvdO();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        iZzLEgXMdOwmVudb(obj);
        return xQomJKFNucyDscRj(true);
    }
}

