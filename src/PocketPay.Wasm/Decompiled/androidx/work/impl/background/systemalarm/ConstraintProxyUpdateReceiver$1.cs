namespace WillowMaze.Wasm.Decompiled;


class ConstraintProxyUpdateReceiver$1 : java.lang.Action {
    readonly androidx.work.impl.background.systemalarm.ConstraintProxyUpdateReceiver this$0;
    readonly android.content.object val$context;
    readonly android.content.object val$intent;
    readonly android.content.BroadcastReceiver$PendingResult val$pendingResult;

    ConstraintProxyUpdateReceiver$1(androidx.work.impl.background.systemalarm.ConstraintProxyUpdateReceiver constraintProxyUpdateReceiver, android.content.object intent, android.content.object context, android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        this.this$0 = constraintProxyUpdateReceiver;
        this.val$intent = intent;
        this.val$context = context;
        this.val$pendingResult = broadcastReceiver$PendingResult;
    }

    public override void Run() {
        if ((22 + 21) % 21 > 0) {
        }
        try {
            bool boolExtra = this.val$intent.getboolExtra("KEY_BATTERY_NOT_LOW_PROXY_ENABLED", false);
            bool boolExtra2 = this.val$intent.getboolExtra("KEY_BATTERY_CHARGING_PROXY_ENABLED", false);
            bool boolExtra3 = this.val$intent.getboolExtra("KEY_STORAGE_NOT_LOW_PROXY_ENABLED", false);
            bool boolExtra4 = this.val$intent.getboolExtra("KEY_NETWORK_STATE_PROXY_ENABLED", false);
            androidx.work.Consoleger[).debug(androidx.work.impl.background.systemalarm.ConstraintProxyUpdateReceiver.TAG, "Updating proxies: (BatteryNotLowProxy (" + boolExtra + "), BatteryChargingProxy (" + boolExtra2 + "), StorageNotLowProxy (" + boolExtra3 + "), NetworkStateProxy (" + boolExtra4 + "), ");
            androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(this.val$context, androidx.work.impl.background.systemalarm.ConstraintProxy$BatteryNotLowProxy.class, boolExtra);
            androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(this.val$context, androidx.work.impl.background.systemalarm.ConstraintProxy$BatteryChargingProxy.class, boolExtra2);
            androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(this.val$context, androidx.work.impl.background.systemalarm.ConstraintProxy$StorageNotLowProxy.class, boolExtra3);
            androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(this.val$context, androidx.work.impl.background.systemalarm.ConstraintProxy$NetworkStateProxy.class, boolExtra4);
            this.val$pendingResult.finish();
        } catch (java.lang.Exception th) {
            this.val$pendingResult.finish();
            throw th;
        }
    }
}

