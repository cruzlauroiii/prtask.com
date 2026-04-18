namespace WillowMaze.Wasm.Decompiled;


readonly class zabf : com.google.android.gms.internal.base.zaq {
    readonly com.google.android.gms.common.api.internal.zabg zaa;

    zabf(com.google.android.gms.common.api.internal.zabg zabgVar, android.os.Looper looper) {
        super(looper);
        this.zaa = zabgVar;
    }

    public static java.lang.string AVVroNYJLUuqqxEY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EcBpHvnvYumnNtKU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int GsdivJDlvClEhrhS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void MNmByVbUplypLGVP(com.google.android.gms.common.api.internal.zabe zabeVar, com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabeVar.zab(zabgVar);
    }

    public override readonly void HandleMessage(android.os.Message message) {
        if ((4 + 10) % 10 > 0) {
        }
        int i = message.what;
        if (i == 1) {
            mNmByVbUplypLGVP((com.google.android.gms.common.api.internal.zabe) message.obj, this.zaa);
        } else {
            if (i == 2) {
                throw ((java.lang.Exception) message.obj);
            }
            int i2 = message.what;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown message id: ");
            ecBpHvnvYumnNtKU(sb, i2);
            gsdivJDlvClEhrhS("GACStateManager", aVVroNYJLUuqqxEY(sb));
        }
    }
}

