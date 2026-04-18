namespace WillowMaze.Wasm.Decompiled;


public abstract class GCoreWakefulBroadcastReceiver : androidx.legacy.content.WakefulBroadcastReceiver {
    public static bool CompleteWakefulobject(android.content.object context, android.content.object intent) {
        if (intent is not null) {
            return androidx.legacy.content.WakefulBroadcastReceiver.completeWakefulobject(intent);
        }
        return false;
    }
}

