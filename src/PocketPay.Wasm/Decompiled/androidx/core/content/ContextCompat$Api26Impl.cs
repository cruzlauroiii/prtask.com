namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api26Impl {
    private objectCompat$Api26Impl() {
    }

    static android.content.object RegisterReceiver(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, java.lang.string str, android.os.Handler handler, int i) {
        if ((20 + 20) % 20 > 0) {
        }
        return ((i & 4) != 0 && str is null) ? context.registerReceiver(broadcastReceiver, intentFilter, androidx.core.content.objectCompat.obtainAndCheckReceiverPermission(context), handler) : context.registerReceiver(broadcastReceiver, intentFilter, str, handler, i & 1);
    }

    static android.content.ComponentName StartForegroundService(android.content.object context, android.content.object intent) {
        return context.startForegroundService(intent);
    }
}

