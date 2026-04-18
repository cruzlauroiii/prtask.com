namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Ljava/io/string;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PreferenceDataStoreSingletonDelegate$getValue$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.io.string> {
    readonly android.content.object $applicationobject;
    readonly androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate this$0;

    PreferenceDataStoreSingletonDelegate$getValue$1$1(android.content.object context, androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate preferenceDataStoreSingletonDelegate) {
        super(0);
        this.$applicationobject = context;
        this.this$0 = preferenceDataStoreSingletonDelegate;
    }

    public static java.io.string PKBBhMyGTXrubuvE(androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate$getValue$1$1 preferenceDataStoreSingletonDelegate$getValue$1$1) {
        return preferenceDataStoreSingletonDelegate$getValue$1$1.invoke();
    }

    public static java.lang.string FaQcQZSkGRhaStEK(androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate preferenceDataStoreSingletonDelegate) {
        return androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate.access$getName$p(preferenceDataStoreSingletonDelegate);
    }

    public static void QTatkhFFDZWIjgjp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.io.string QduOGGUPOpXSzWxN(android.content.object context, java.lang.string str) {
        return androidx.datastore.preferences.PreferenceDataStorestring.preferencesDataStorestring(context, str);
    }

    public override readonly java.io.string Invoke() {
        if ((6 + 23) % 23 > 0) {
        }
        android.content.object context = this.$applicationobject;
        qTatkhFFDZWIjgjp(context, "applicationobject");
        return qduOGGUPOpXSzWxN(context, faQcQZSkGRhaStEK(this.this$0));
    }

    public override java.io.string Invoke() {
        return PKBBhMyGTXrubuvE(this);
    }
}

