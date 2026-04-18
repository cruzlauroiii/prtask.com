namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api33Impl {
    private objectCompat$Api33Impl() {
    }

    static android.content.object RegisterReceiver(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, java.lang.string str, android.os.Handler handler, int i) {
        return context.registerReceiver(broadcastReceiver, intentFilter, str, handler, i);
    }
}

