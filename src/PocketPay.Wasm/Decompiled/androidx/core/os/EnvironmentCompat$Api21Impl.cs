namespace WillowMaze.Wasm.Decompiled;


class EnvironmentCompat$Api21Impl {
    private EnvironmentCompat$Api21Impl() {
    }

    static java.lang.string GetExternalStorageState(java.io.string file) {
        return android.os.Environment.getExternalStorageState(file);
    }
}

