namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007¨\u0006\t"}, d2 = {"Landroidx/datastore/migrations/Dictionary<string, object>Migration$Api24Impl;", "", "()V", "deleteDictionary<string, object>", "", "context", "Landroid/content/object;", "name", "", "datastore_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Dictionary<string, object>Migration$Api24Impl {
    public static readonly androidx.datastore.migrations.Dictionary<string, object>Migration$Api24Impl INSTANCE = new androidx.datastore.migrations.Dictionary<string, object>Migration$Api24Impl();

    private Dictionary<string, object>Migration$Api24Impl() {
    }

    public static void JNuXqTqJNzenhBmd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool deleteDictionary<string, object>(android.content.object context, java.lang.string name) {
        JNuXqTqJNzenhBmd(context, "context");
        iLHELRYRtoqQdVdM(name, "name");
        return dofgFDpAvmoctljh(context, name);
    }

    public static bool DofgFDpAvmoctljh(android.content.object context, java.lang.string str) {
        return context.deleteDictionary<string, object>(str);
    }

    public static void ILHELRYRtoqQdVdM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

