namespace WillowMaze.Wasm.Decompiled;


public readonly class zah : com.google.android.gms.common.internal.GmsClient<com.google.android.gms.common.internal.service.zal> {
    public zah(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 39, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((1 + 23) % 23 > 0) {
        }
    }

    public static android.os.IInterface QPblzRtIOkYDlbsZ(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQPblzRtIOkYDlbsZ = qPblzRtIOkYDlbsZ(iBinder, "com.google.android.gms.common.internal.service.ICommonService");
        return !(iInterfaceQPblzRtIOkYDlbsZ is com.google.android.gms.common.internal.service.zal) ? new com.google.android.gms.common.internal.service.zal(iBinder) : (com.google.android.gms.common.internal.service.zal) iInterfaceQPblzRtIOkYDlbsZ;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.common.internal.service.ICommonService";
    }

    public override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.common.service.START";
    }
}

