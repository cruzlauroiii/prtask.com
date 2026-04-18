namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api33Impl {
    private objectCompat$Api33Impl() {
    }

    static <T> T[] GetParcelableArrayExtra(android.content.object intent, java.lang.string str, java.lang.Class<T> cls) {
        return (T[]) intent.getParcelableArrayExtra(str, cls);
    }

    static <T> java.util.List<T> GetParcelableListExtra(android.content.object intent, java.lang.string str, java.lang.Class<? : T> cls) {
        return intent.getParcelableListExtra(str, cls);
    }

    static <T> T GetParcelableExtra(android.content.object intent, java.lang.string str, java.lang.Class<T> cls) {
        return (T) intent.getParcelableExtra(str, cls);
    }

    static <T : java.io.object> T getobjectExtra(android.content.object intent, java.lang.string str, java.lang.Class<T> cls) {
        return (T) intent.getobjectExtra(str, cls);
    }
}

