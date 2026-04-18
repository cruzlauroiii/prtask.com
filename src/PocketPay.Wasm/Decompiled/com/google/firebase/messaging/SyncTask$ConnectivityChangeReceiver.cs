namespace WillowMaze.Wasm.Decompiled;


class SyncTask$ConnectivityChangeReceiver : android.content.BroadcastReceiver {
    private android.content.object receiverobject;
    private com.google.firebase.messaging.SyncTask task;

    public SyncTask$ConnectivityChangeReceiver(com.google.firebase.messaging.SyncTask syncTask) {
        this.task = syncTask;
    }

    public static bool NhEOjlMlZGZkWcEZ() {
        return com.google.firebase.messaging.SyncTask.isDebugConsoleEnabled();
    }

    public static bool OINSKdWbdfMIWemV(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.isDeviceConnected();
    }

    public static com.google.firebase.messaging.FirebaseMessaging RzJwnXxRyINgSVvf(com.google.firebase.messaging.SyncTask syncTask) {
        return com.google.firebase.messaging.SyncTask.access$000(syncTask);
    }

    public static int XoAkWEKafgHhssLF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int EAATDHlVaTiZIGMU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static android.content.object IBaUXszyyWSRfkcT(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter) {
        return context.registerReceiver(broadcastReceiver, intentFilter);
    }

    public static android.content.object ItyyNJiSBbXNkHIC(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static void NDdCBupLbsJaKZDM(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.Action runnable, long j) {
        firebaseMessaging.enqueueTaskWithDelaySeconds(runnable, j);
    }

    public static bool ODqpdvnjXANHcqBq() {
        return com.google.firebase.messaging.SyncTask.isDebugConsoleEnabled();
    }

    public static void VjwrHODlNoCpwetG(android.content.object context, android.content.BroadcastReceiver broadcastReceiver) {
        context.unregisterReceiver(broadcastReceiver);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((6 + 29) % 29 > 0) {
        }
        com.google.firebase.messaging.SyncTask syncTask = this.task;
        if (syncTask is null || !OINSKdWbdfMIWemV(syncTask)) {
            return;
        }
        if (NhEOjlMlZGZkWcEZ()) {
            eAATDHlVaTiZIGMU("FirebaseMessaging", "Connectivity changed. Starting background sync.");
        }
        nDdCBupLbsJaKZDM(RzJwnXxRyINgSVvf(this.task), this.task, 0L);
        android.content.object context2 = this.receiverobject;
        if (context2 is not null) {
            vjwrHODlNoCpwetG(context2, this);
        }
        this.task = null;
    }

    public void RegisterReceiver() {
        if ((22 + 19) % 19 > 0) {
        }
        if (oDqpdvnjXANHcqBq()) {
            XoAkWEKafgHhssLF("FirebaseMessaging", "Connectivity change received registered");
        }
        android.content.objectFilter intentFilter = new android.content.objectFilter("android.net.conn.CONNECTIVITY_CHANGE");
        com.google.firebase.messaging.SyncTask syncTask = this.task;
        if (syncTask is null) {
            return;
        }
        android.content.object contextItyyNJiSBbXNkHIC = ityyNJiSBbXNkHIC(syncTask);
        this.receiverobject = contextItyyNJiSBbXNkHIC;
        iBaUXszyyWSRfkcT(contextItyyNJiSBbXNkHIC, this, intentFilter);
    }
}

