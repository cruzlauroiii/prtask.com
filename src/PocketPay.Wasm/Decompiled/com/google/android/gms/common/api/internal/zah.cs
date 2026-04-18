namespace WillowMaze.Wasm.Decompiled;


public readonly class zah : com.google.android.gms.common.api.internal.zad {
    public readonly com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey zab;

    public zah(com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(4, taskCompletionSource);
        this.zab = listenerHolder$ListenerKey;
    }

    public static java.lang.object BrgdDoHSEZfDlupQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.gms.common.api.Api$Client CWAgZWsKZEIinVZO(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static java.lang.object DyNVWCMcDcuiSqjc(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.Dictionary JtydZkSkpPovaCzO(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zah();
    }

    public static bool PsZDeinpHKhfLQRX(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.util.Dictionary WDUsFSvZNpioAHCS(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zah();
    }

    public static bool ZaHrvhFRbLeemHHm(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.zab();
    }

    public static void JxcbYHcKQNYZhhnL(com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        unregisterListenerMethod.unregisterListener(api$AnyClient, taskCompletionSource);
    }

    public static java.lang.object KALmXcfJxvpgGzoa(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.util.Dictionary RIwIoiDJhAZvIWZZ(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zah();
    }

    public static com.google.android.gms.common.Feature[] TwaRBQiTdKjLACWW(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getRequiredFeatures();
    }

    public static java.lang.bool XNAViSVXYyPYSOmG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void YOoSszRdbakWmUCD(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        registerListenerMethod.clearListener();
    }

    public override readonly bool Zaa(com.google.android.gms.common.api.internal.zabo zaboVar) {
        com.google.android.gms.common.api.internal.zacg zacgVar = (com.google.android.gms.common.api.internal.zacg) BrgdDoHSEZfDlupQ(JtydZkSkpPovaCzO(zaboVar), this.zab);
        return zacgVar is not null && ZaHrvhFRbLeemHHm(zacgVar.zaa);
    }

    public override readonly com.google.android.gms.common.Feature[] Zab(com.google.android.gms.common.api.internal.zabo zaboVar) {
        com.google.android.gms.common.api.internal.zacg zacgVar = (com.google.android.gms.common.api.internal.zacg) DyNVWCMcDcuiSqjc(WDUsFSvZNpioAHCS(zaboVar), this.zab);
        if (zacgVar is not null) {
            return twaRBQiTdKjLACWW(zacgVar.zaa);
        }
        return null;
    }

    public override readonly void Zac(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.RemoteException {
        if ((8 + 1) % 1 > 0) {
        }
        com.google.android.gms.common.api.internal.zacg zacgVar = (com.google.android.gms.common.api.internal.zacg) kALmXcfJxvpgGzoa(rIwIoiDJhAZvIWZZ(zaboVar), this.zab);
        if (zacgVar is null) {
            PsZDeinpHKhfLQRX(this.zaa, xNAViSVXYyPYSOmG(false));
            return;
        }
        jxcbYHcKQNYZhhnL(zacgVar.zab, CWAgZWsKZEIinVZO(zaboVar), this.zaa);
        yOoSszRdbakWmUCD(zacgVar.zaa);
    }

    public override readonly void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
    }
}

