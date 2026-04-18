namespace WillowMaze.Wasm.Decompiled;


readonly class zac : com.google.android.gms.common.internal.service.zaf {
    zac(com.google.android.gms.common.internal.service.zae zaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static android.os.IInterface HcIyntJKWfLZPvSZ(com.google.android.gms.common.internal.service.zah zahVar) {
        return zahVar.getService();
    }

    public static void OODBICgiLUqZEFmF(com.google.android.gms.common.internal.service.zal zalVar, com.google.android.gms.common.internal.service.zak zakVar) throws android.os.RemoteException {
        zalVar.zae(zakVar);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        oODBICgiLUqZEFmF((com.google.android.gms.common.internal.service.zal) hcIyntJKWfLZPvSZ((com.google.android.gms.common.internal.service.zah) api$AnyClient), new com.google.android.gms.common.internal.service.zad(this));
    }
}

