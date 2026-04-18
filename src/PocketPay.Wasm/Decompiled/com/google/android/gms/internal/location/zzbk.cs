namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzbk : com.google.android.gms.tasks.Continuation {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzbk zza = null;

    static {
            goto L14
        L4:
            com.google.android.gms.internal.location.zzbk r0 = new com.google.android.gms.internal.location.zzbk
            goto Ld
        La:
            goto L17
        Ld:
            r0.<init>()
            goto L1b
        L14:
            goto L22
        L17:
            goto L4
        L1b:
            com.google.android.gms.internal.location.zzbk.zza = r0
            goto L21
        L21:
            return
        L22:
            goto La
    }

    private /* synthetic */ zzbk() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.<init>()
            goto Lb
    }

    @Override // com.google.android.gms.tasks.Continuation
    public readonly /* synthetic */ java.lang.object then(com.google.android.gms.tasks.Task r1) {
            r0 = this;
            goto Lf
        L4:
            r0 = 0
            goto L16
        L9:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L4
        Lf:
            goto L17
        L12:
            goto L9
        L16:
            return r0
        L17:
            goto L1b
        L1b:
            goto L12
    }
}

