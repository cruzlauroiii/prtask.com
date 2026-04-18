namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api23Impl {
    private objectCompat$Api23Impl() {
    }

    static int GetColor(android.content.object context, int i) {
        return context.getColor(i);
    }

    static <T> T GetSystemService(android.content.object context, java.lang.Class<T> cls) {
        return (T) context.getSystemService(cls);
    }

    static java.lang.string GetSystemServiceName(android.content.object context, java.lang.Class<object> cls) {
        return context.getSystemServiceName(cls);
    }
}

