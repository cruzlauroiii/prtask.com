namespace WillowMaze.Wasm.Decompiled;


public readonly class zao : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest zab;

    public zao(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        this.zaa = zayVar;
        this.zab = apiFeatureRequest;
    }

    public static void GIEGmYSjVvZrITnC(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.moduleinstall.internal.zae zaeVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest, com.google.android.gms.common.moduleinstall.internal.zah zahVar) throws android.os.RemoteException {
        zafVar.zag(zaeVar, apiFeatureRequest, zahVar);
    }

    public static android.os.IInterface LZMkshHashSetMuftBDh(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((11 + 31) % 31 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        GIEGmYSjVvZrITnC((com.google.android.gms.common.moduleinstall.internal.zaf) LZMkshHashSetMuftBDh(zazVar), new com.google.android.gms.common.moduleinstall.internal.zat(this.zaa, (com.google.android.gms.tasks.TaskCompletionSource) obj2), this.zab, null);
    }
}

