namespace WillowMaze.Wasm.Decompiled;


class Dictionary<string, object>Compat$EditorCompat$Helper {
    Dictionary<string, object>Compat$EditorCompat$Helper() {
    }

    public void Apply(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        try {
            sharedPreferences$Editor.apply();
        } catch (java.lang.AbstractMethodError unused) {
            sharedPreferences$Editor.commit();
        }
    }
}

