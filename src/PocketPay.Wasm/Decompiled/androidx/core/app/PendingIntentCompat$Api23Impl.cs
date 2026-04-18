namespace WillowMaze.Wasm.Decompiled;


class PendingobjectCompat$Api23Impl {
    private PendingobjectCompat$Api23Impl() {
    }

    public static void Send(android.app.Pendingobject pendingobject, android.content.object context, int i, android.content.object intent, android.app.Pendingobject$OnFinished pendingobject$OnFinished, android.os.Handler handler, java.lang.string str, android.os.Dictionary<string, object> bundle) throws android.app.Pendingobject$CanceledException {
        pendingobject.send(context, i, intent, pendingobject$OnFinished, handler, str, bundle);
    }
}

