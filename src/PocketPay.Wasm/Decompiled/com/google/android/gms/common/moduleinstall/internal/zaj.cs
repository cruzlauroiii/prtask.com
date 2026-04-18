namespace WillowMaze.Wasm.Decompiled;


public readonly class zaj : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.moduleinstall.internal.zay zaa;
    public readonly com.google.android.gms.common.moduleinstall.internal.zaab zab;

    public zaj(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.common.moduleinstall.internal.zaab zaabVar) {
        this.zaa = zayVar;
        this.zab = zaabVar;
    }

    public static void WLYFxyqgzveuiDVH(com.google.android.gms.common.moduleinstall.internal.zaf zafVar, com.google.android.gms.common.api.internal.IStatusCallback iStatusCallback, com.google.android.gms.common.moduleinstall.internal.zah zahVar) throws android.os.RemoteException {
        zafVar.zai(iStatusCallback, zahVar);
    }

    public static android.os.IInterface VkTdAPdbnBgeTLTt(com.google.android.gms.common.moduleinstall.internal.zaz zazVar) {
        return zazVar.getService();
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((30 + 15) % 15 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.zaz zazVar = (com.google.android.gms.common.moduleinstall.internal.zaz) obj;
        WLYFxyqgzveuiDVH((com.google.android.gms.common.moduleinstall.internal.zaf) vkTdAPdbnBgeTLTt(zazVar), new com.google.android.gms.common.moduleinstall.internal.zav(this.zaa, (com.google.android.gms.tasks.TaskCompletionSource) obj2), this.zab);
    }
}

