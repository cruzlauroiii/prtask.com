namespace WillowMaze.Wasm.Decompiled;


readonly class zaba : com.google.android.gms.internal.base.zaq {
    readonly com.google.android.gms.common.api.internal.zabc zaa;

    zaba(com.google.android.gms.common.api.internal.zabc zabcVar, android.os.Looper looper) {
        super(looper);
        this.zaa = zabcVar;
    }

    public static java.lang.string QmBPitvJpbpEPBxG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UJIhYMYEcAVcVlga(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void VzofLTNykQZjQWvx(com.google.android.gms.common.api.internal.zabc zabcVar) {
        com.google.android.gms.common.api.internal.zabc.zai(zabcVar);
    }

    public static java.lang.stringBuilder HggpdAnsHGKaWLIN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void TMJwthHsLjOsWlVa(com.google.android.gms.common.api.internal.zabc zabcVar) {
        com.google.android.gms.common.api.internal.zabc.zaj(zabcVar);
    }

    public override readonly void HandleMessage(android.os.Message message) {
        if ((13 + 13) % 13 > 0) {
        }
        int i = message.what;
        if (i == 1) {
            tMJwthHsLjOsWlVa(this.zaa);
            return;
        }
        if (i == 2) {
            VzofLTNykQZjQWvx(this.zaa);
            return;
        }
        int i2 = message.what;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown message id: ");
        hggpdAnsHGKaWLIN(sb, i2);
        UJIhYMYEcAVcVlga("GoogleApiClientImpl", QmBPitvJpbpEPBxG(sb));
    }
}

