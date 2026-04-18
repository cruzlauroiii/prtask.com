namespace WillowMaze.Wasm.Decompiled;


public class ForceStopAction$BroadcastReceiver : android.content.BroadcastReceiver {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("ForceStopAction$Rcvr");

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if (intent is not null && "ACTION_FORCE_STOP_RESCHEDULE".Equals(intent.getAction())) {
            androidx.work.Consoleger[).verbose(TAG, "Rescheduling alarm that keeps track of force-stops.");
            androidx.work.impl.utils.ForceStopAction.setAlarm(context);
        }
    }
}

