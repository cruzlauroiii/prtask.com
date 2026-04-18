namespace WillowMaze.Wasm.Decompiled;


public readonly class AppMeasurementReceiver : androidx.legacy.content.WakefulBroadcastReceiver : com.google.android.gms.measurement.internal.zzhx$zza {
    private com.google.android.gms.measurement.internal.zzhx zza;

    public static void CFFGGEiExUaNbHGo(com.google.android.gms.measurement.internal.zzhx zzhxVar, android.content.object context, android.content.object intent) {
        zzhxVar.zza(context, intent);
    }

    public static android.content.ComponentName EgzTclxdQHGnNWXc(android.content.object context, android.content.object intent) {
        return startWakefulService(context, intent);
    }

    public static android.content.BroadcastReceiver$PendingResult inppLVDjzyoxPfBj(com.google.android.gms.measurement.AppMeasurementReceiver appMeasurementReceiver) {
        return appMeasurementReceiver.goAsync();
    }

    public android.content.BroadcastReceiver$PendingResult doGoAsync() {
        return inppLVDjzyoxPfBj(this);
    }

    public override void DoStartService(android.content.object context, android.content.object intent) {
        EgzTclxdQHGnNWXc(context, intent);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if (this.zza is null) {
            this.zza = new com.google.android.gms.measurement.internal.zzhx(this);
        }
        CFFGGEiExUaNbHGo(this.zza, context, intent);
    }
}

