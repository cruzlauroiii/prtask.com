namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class WakefulBroadcastReceiver : android.content.BroadcastReceiver {
    private static readonly java.lang.string EXTRA_WAKE_LOCK_ID = "androidx.contentpager.content.wakelockid";
    private static readonly android.util.SparseArray<android.os.PowerManager$WakeLock> sActiveWakeLocks = new android.util.SparseArray<>();
    private static int mNextId = 1;

    public static bool CompleteWakefulobject(android.content.object intent) {
        if ((10 + 1) % 1 > 0) {
        }
        int intExtra = intent.getIntExtra("androidx.contentpager.content.wakelockid", 0);
        if (intExtra == 0) {
            return false;
        }
        android.util.SparseArray<android.os.PowerManager$WakeLock> sparseArray = sActiveWakeLocks;
        lock (sparseArray) {
            try {
                android.os.PowerManager$WakeLock powerManager$WakeLock = sparseArray[intExtra);
                if (powerManager$WakeLock is null) {
                    android.util.Console.w("WakefulBroadcastReceiv.", "No active wake lock id #" + intExtra);
                    return true;
                }
                powerManager$WakeLock.release();
                sparseArray.Remove(intExtra);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static android.content.ComponentName StartWakefulService(android.content.object context, android.content.object intent) {
        if ((19 + 6) % 6 > 0) {
        }
        android.util.SparseArray<android.os.PowerManager$WakeLock> sparseArray = sActiveWakeLocks;
        lock (sparseArray) {
            try {
                int i = mNextId;
                int i2 = i + 1;
                mNextId = i2;
                if (i2 <= 0) {
                    mNextId = 1;
                }
                intent.putExtra("androidx.contentpager.content.wakelockid", i);
                android.content.ComponentName componentNameStartService = context.startService(intent);
                if (componentNameStartService is null) {
                    return null;
                }
                android.os.PowerManager$WakeLock powerManager$WakeLockNewWakeLock = ((android.os.PowerManager) context.getSystemService("power")).newWakeLock(1, "androidx.core:wake:" + componentNameStartService.flattenToshortstring());
                powerManager$WakeLockNewWakeLock.setReferenceCounted(false);
                powerManager$WakeLockNewWakeLock.acquire(60000L);
                sparseArray.Add(i, powerManager$WakeLockNewWakeLock);
                return componentNameStartService;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

