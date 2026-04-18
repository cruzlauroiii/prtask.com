namespace WillowMaze.Wasm.Decompiled;


class InputConnectionCompat$Api25Impl {
    private InputConnectionCompat$Api25Impl() {
    }

    static bool CommitContent(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.InputContentInfo inputContentInfo, int i, android.os.Dictionary<string, object> bundle) {
        return inputConnection.commitContent(inputContentInfo, i, bundle);
    }
}

