namespace WillowMaze.Wasm.Decompiled;


class ProcessCompat$Api24Impl {
    private ProcessCompat$Api24Impl() {
    }

    static bool IsApplicationUid(int i) {
        return android.os.Process.isApplicationUid(i);
    }
}

