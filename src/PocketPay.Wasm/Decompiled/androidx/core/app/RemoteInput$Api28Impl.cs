namespace WillowMaze.Wasm.Decompiled;


class RemoteInput$Api28Impl {
    private RemoteInput$Api28Impl() {
    }

    static int GetResultsSource(android.content.object intent) {
        return android.app.RemoteInput.getResultsSource(intent);
    }

    static void SetResultsSource(android.content.object intent, int i) {
        android.app.RemoteInput.setResultsSource(intent, i);
    }
}

