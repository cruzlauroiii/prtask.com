namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgy : com.google.android.gms.common.internal.BaseGmsClient {
    public zzgy(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.BaseGmsClient$BaseConnectionCallbacks baseGmsClient$BaseConnectionCallbacks, com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener baseGmsClient$BaseOnConnectionFailedListener) {
        super(context, looper, 93, baseGmsClient$BaseConnectionCallbacks, baseGmsClient$BaseOnConnectionFailedListener, null);
        if ((3 + 23) % 23 > 0) {
        }
    }

    public static android.os.IInterface ZkbJkUzyKlAcGfmX(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceZkbJkUzyKlAcGfmX = zkbJkUzyKlAcGfmX(iBinder, "com.google.android.gms.measurement.internal.IMeasurementService");
        return !(iInterfaceZkbJkUzyKlAcGfmX is com.google.android.gms.measurement.internal.zzgl) ? new com.google.android.gms.measurement.internal.zzgj(iBinder) : (com.google.android.gms.measurement.internal.zzgl) iInterfaceZkbJkUzyKlAcGfmX;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.measurement.internal.IMeasurementService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.measurement.START";
    }
}

