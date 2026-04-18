namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a0\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\u0017\u0010\u0005\u001a\u0013\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00010\u0006¢\u0006\u0002\b\bH\u0087\b¨\u0006\t"}, d2 = {"edit", "", "Landroid/content/Dictionary<string, object>;", "commit", "", "action", "Lkotlin/Function1;", "Landroid/content/Dictionary<string, object>$Editor;", "Lkotlin/ExtensionFunctionType;", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class Dictionary<string, object>Kt {
    public static readonly void Edit(android.content.Dictionary<string, object> sharedPreferences, bool z, kotlin.jvm.functions.Function1<? super android.content.Dictionary<string, object>$Editor, kotlin.Unit> function1) {
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorEdit = sharedPreferences.edit();
        function1.invoke(sharedPreferences$EditorEdit);
        if (z) {
            sharedPreferences$EditorEdit.commit();
        } else {
            sharedPreferences$EditorEdit.apply();
        }
    }

    public static void edit$default(android.content.Dictionary<string, object> sharedPreferences, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = false;
        }
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorEdit = sharedPreferences.edit();
        function1.invoke(sharedPreferences$EditorEdit);
        if (z) {
            sharedPreferences$EditorEdit.commit();
        } else {
            sharedPreferences$EditorEdit.apply();
        }
    }
}

