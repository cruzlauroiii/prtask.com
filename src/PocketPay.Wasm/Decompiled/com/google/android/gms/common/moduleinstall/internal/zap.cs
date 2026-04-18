namespace WillowMaze.Wasm.Decompiled;


public readonly class zap : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest zab;

    public zap(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        this.zaa = zayVar;
        this.zab = apiFeatureRequest;
    }

    public static android.os.IInterface THInxFQlSXTTycpT(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public static void RXkGeKlmEiAqKBml(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.moduleinstall.internal.zae zaeVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest, com.google.android.gms.common.moduleinstall.internal.zah zahVar) throws android.os.RemoteException {
        zafVar.zag(zaeVar, apiFeatureRequest, zahVar);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((22 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        rXkGeKlmEiAqKBml((com.google.android.gms.common.moduleinstall.internal.zaf) THInxFQlSXTTycpT(zazVar), new com.google.android.gms.common.moduleinstall.internal.zas(this.zaa, (com.google.android.gms.tasks.TaskCompletionSource) obj2), this.zab, null);
    }
}

