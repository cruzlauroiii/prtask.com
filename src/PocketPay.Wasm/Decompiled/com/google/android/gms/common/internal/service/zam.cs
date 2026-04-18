namespace WillowMaze.Wasm.Decompiled;


public readonly class zam : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.internal.TelemetryData zaa;

    public zam(com.google.android.gms.common.internal.TelemetryData telemetryData) {
        this.zaa = telemetryData;
    }

    public static android.os.IInterface DodloekOjWAHLEdN(com.google.android.gms.common.internal.service.zap zapVar) {
        return zapVar.getService();
    }

    public static void ZBQQkVCOueznNgfv(com.google.android.gms.common.internal.service.zai zaiVar, com.google.android.gms.common.internal.TelemetryData telemetryData) throws android.os.RemoteException {
        zaiVar.zae(telemetryData);
    }

    public static void MxWgSKXDXMMAuYGc(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.common.internal.service.zap zapVar = (com.google.android.gms.common.internal.service.zap) obj;
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        int i = com.google.android.gms.common.internal.service.zao.zab;
        ZBQQkVCOueznNgfv((com.google.android.gms.common.internal.service.zai) DodloekOjWAHLEdN(zapVar), this.zaa);
        mxWgSKXDXMMAuYGc(taskCompletionSource, null);
    }
}

