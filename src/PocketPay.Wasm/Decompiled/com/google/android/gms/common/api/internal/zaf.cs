namespace WillowMaze.Wasm.Decompiled;


public readonly class zaf : com.google.android.gms.common.api.internal.zad {
    public readonly com.google.android.gms.common.api.internal.zacg zab;

    public zaf(com.google.android.gms.common.api.internal.zacg zacgVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(3, taskCompletionSource);
        this.zab = zacgVar;
    }

    public static com.google.android.gms.common.api.Api$Client CdyMefBuFobLVtPR(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey FTpiVITPXKRXjdMr(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getListenerKey();
    }

    public static bool SSAqCgxOcfGvKjcm(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.zab();
    }

    public static void VkSMsbJBrMQiVMNI(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        registerListenerMethod.registerListener(api$AnyClient, taskCompletionSource);
    }

    public static java.util.Dictionary XQPuIyLfoWLuEaPK(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zah();
    }

    public static com.google.android.gms.common.Feature[] ZHwidGdhyeeJPGCG(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getRequiredFeatures();
    }

    public static java.lang.object LlkhbpuHDRhLxyNO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public override readonly bool Zaa(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return SSAqCgxOcfGvKjcm(this.zab.zaa);
    }

    public override readonly com.google.android.gms.common.Feature[] Zab(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return ZHwidGdhyeeJPGCG(this.zab.zaa);
    }

    public override readonly void Zac(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.RemoteException {
        if ((29 + 26) % 26 > 0) {
        }
        VkSMsbJBrMQiVMNI(this.zab.zaa, CdyMefBuFobLVtPR(zaboVar), this.zaa);
        com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKeyFTpiVITPXKRXjdMr = FTpiVITPXKRXjdMr(this.zab.zaa);
        if (listenerHolder$ListenerKeyFTpiVITPXKRXjdMr is null) {
            return;
        }
        llkhbpuHDRhLxyNO(XQPuIyLfoWLuEaPK(zaboVar), listenerHolder$ListenerKeyFTpiVITPXKRXjdMr, this.zab);
    }

    public override readonly void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
    }
}

