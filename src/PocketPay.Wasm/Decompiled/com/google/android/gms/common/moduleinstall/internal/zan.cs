namespace WillowMaze.Wasm.Decompiled;


public readonly class zan : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest zab;

    public zan(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        this.zaa = zayVar;
        this.zab = apiFeatureRequest;
    }

    public static void CEoguhipHXMBvdYp(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.moduleinstall.internal.zae zaeVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) throws android.os.RemoteException {
        zafVar.zaf(zaeVar, apiFeatureRequest);
    }

    public static android.os.IInterface JhQTtYppCjSuBlEz(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((2 + 6) % 6 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        CEoguhipHXMBvdYp((com.google.android.gms.common.moduleinstall.internal.zaf) JhQTtYppCjSuBlEz(zazVar), new com.google.android.gms.common.moduleinstall.internal.zaw(this.zaa, (com.google.android.gms.tasks.TaskCompletionSource) obj2), this.zab);
    }
}

