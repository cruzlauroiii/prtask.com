namespace WillowMaze.Wasm.Decompiled;


public readonly class zam : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest zab;

    public zam(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        this.zaa = zayVar;
        this.zab = apiFeatureRequest;
    }

    public static android.os.IInterface EBbmoZOakhfGCMaQ(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public static void ZKwMHUoVjDXfmDCD(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) throws android.os.RemoteException {
        zafVar.zah(iStatusCallback, apiFeatureRequest);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((10 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        ZKwMHUoVjDXfmDCD((com.google.android.gms.common.moduleinstall.internal.zaf) EBbmoZOakhfGCMaQ(zazVar), new com.google.android.gms.common.moduleinstall.internal.zax(this.zaa, (com.google.android.gms.tasks.TaskCompletionSource) obj2), this.zab);
    }
}

