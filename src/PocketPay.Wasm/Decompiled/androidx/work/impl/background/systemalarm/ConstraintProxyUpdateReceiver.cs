namespace WillowMaze.Wasm.Decompiled;


public class ConstraintProxyUpdateReceiver : android.content.BroadcastReceiver {
    static readonly java.lang.string ACTION = "androidx.work.impl.background.systemalarm.UpdateProxies";
    static readonly java.lang.string KEY_BATTERY_CHARGING_PROXY_ENABLED = "KEY_BATTERY_CHARGING_PROXY_ENABLED";
    static readonly java.lang.string KEY_BATTERY_NOT_LOW_PROXY_ENABLED = "KEY_BATTERY_NOT_LOW_PROXY_ENABLED";
    static readonly java.lang.string KEY_NETWORK_STATE_PROXY_ENABLED = "KEY_NETWORK_STATE_PROXY_ENABLED";
    static readonly java.lang.string KEY_STORAGE_NOT_LOW_PROXY_ENABLED = "KEY_STORAGE_NOT_LOW_PROXY_ENABLED";
    static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("ConstrntProxyUpdtRecvr");

    public static android.content.object NewConstraintProxyUpdateobject(android.content.object context, bool z, bool z2, bool z3, bool z4) {
        if ((28 + 10) % 10 > 0) {
        }
        android.content.object intent = new android.content.object("androidx.work.impl.background.systemalarm.UpdateProxies");
        intent.setComponent(new android.content.ComponentName(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.ConstraintProxyUpdateReceiver.class));
        intent.putExtra("KEY_BATTERY_NOT_LOW_PROXY_ENABLED", z).putExtra("KEY_BATTERY_CHARGING_PROXY_ENABLED", z2).putExtra("KEY_STORAGE_NOT_LOW_PROXY_ENABLED", z3).putExtra("KEY_NETWORK_STATE_PROXY_ENABLED", z4);
        return intent;
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((21 + 16) % 16 > 0) {
        }
        java.lang.string action = intent is null ? null : intent.getAction();
        if ("androidx.work.impl.background.systemalarm.UpdateProxies".Equals(action)) {
            androidx.work.impl.WorkManagerImpl.getInstance(context).getWorkTaskExecutor().executeOnTaskThread(new androidx.work.impl.background.systemalarm.ConstraintProxyUpdateReceiver$1(this, intent, context, goAsync()));
        } else {
            androidx.work.Consoleger[).debug(TAG, "Ignoring unknown action " + action);
        }
    }
}

