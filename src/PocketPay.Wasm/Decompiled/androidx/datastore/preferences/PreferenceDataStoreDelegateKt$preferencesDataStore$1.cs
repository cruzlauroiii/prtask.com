namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "Landroidx/datastore/core/DataMigration;", "Landroidx/datastore/preferences/core/Preferences;", "it", "Landroid/content/object;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PreferenceDataStoreDelegateKt$preferencesDataStore$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<android.content.object, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> {
    public static readonly androidx.datastore.preferences.PreferenceDataStoreDelegateKt$preferencesDataStore$1 INSTANCE = new androidx.datastore.preferences.PreferenceDataStoreDelegateKt$preferencesDataStore$1();

    PreferenceDataStoreDelegateKt$preferencesDataStore$1() {
        super(1);
    }

    public static void CoLcFwpEOZLmoyLE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List CtosYSLmSOPvJpzY(androidx.datastore.preferences.PreferenceDataStoreDelegateKt$preferencesDataStore$1 preferenceDataStoreDelegateKt$preferencesDataStore$1, android.content.object context) {
        return preferenceDataStoreDelegateKt$preferencesDataStore$1.invoke2(context);
    }

    public static java.util.List NudfvUnvHMSIMFpo() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> invoke(android.content.object context) {
        return ctosYSLmSOPvJpzY(this, context);
    }

    public override readonly java.util.List<androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> Invoke2(android.content.object context) {
        CoLcFwpEOZLmoyLE(context, "it");
        return nudfvUnvHMSIMFpo();
    }
}

