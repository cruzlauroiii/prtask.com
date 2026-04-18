namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzbv : com.google.android.gms.tasks.Continuation {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzbv zza = null;

    static {
            goto L4
        L4:
            goto L22
        L7:
            goto L1b
        Lb:
            r0.<init>()
            goto L12
        L12:
            com.google.android.gms.internal.location.zzbv.zza = r0
            goto L21
        L18:
            goto L7
        L1b:
            com.google.android.gms.internal.location.zzbv r0 = new com.google.android.gms.internal.location.zzbv
            goto Lb
        L21:
            return
        L22:
            goto L18
    }

    private /* synthetic */ zzbv() {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    @Override // com.google.android.gms.tasks.Continuation
    public readonly /* synthetic */ java.lang.object then(com.google.android.gms.tasks.Task r1) {
            r0 = this;
            goto L4
        L4:
            goto L1a
        L7:
            goto L13
        Lb:
            r0 = 0
            goto L19
        L10:
            goto L7
        L13:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto Lb
        L19:
            return r0
        L1a:
            goto L10
    }
}

