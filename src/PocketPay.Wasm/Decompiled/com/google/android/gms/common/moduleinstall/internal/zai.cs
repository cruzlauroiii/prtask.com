namespace WillowMaze.Wasm.Decompiled;


public readonly class zai : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly java.util.concurrent.atomic.object zab;
    public readonly com.google.android.gms.common.moduleinstall.InstallStatusListener zac;
    public readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest zad;
    public readonly com.google.android.gms.common.moduleinstall.internal.zaab zae;

    public zai(com.google.android.gms.common.moduleinstall.internal.zay zayVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest, com.google.android.gms.common.moduleinstall.internal.zaab zaabVar) {
        this.zaa = zayVar;
        this.zab = atomicReference;
        this.zac = installStatusListener;
        this.zad = apiFeatureRequest;
        this.zae = zaabVar;
    }

    public static android.os.IInterface TDaJFcwZaefIPZbT(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public static void YOaxeqNvRFsSfxnd(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.moduleinstall.internal.zae zaeVar, com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest, com.google.android.gms.common.moduleinstall.internal.zah zahVar) throws android.os.RemoteException {
        zafVar.zag(zaeVar, apiFeatureRequest, zahVar);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((8 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        YOaxeqNvRFsSfxnd((com.google.android.gms.common.moduleinstall.internal.zaf) TDaJFcwZaefIPZbT(zazVar), new com.google.android.gms.common.moduleinstall.internal.zau(this.zaa, this.zab, (com.google.android.gms.tasks.TaskCompletionSource) obj2, this.zac), this.zad, this.zae);
    }
}

