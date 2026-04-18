namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzbo : com.google.android.gms.tasks.Continuation {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzbo zza = null;

    static {
            goto L4
        L4:
            goto L19
        L7:
            goto L1d
        Lb:
            com.google.android.gms.internal.location.zzbo.zza = r0
            goto L18
        L11:
            r0.<init>()
            goto Lb
        L18:
            return
        L19:
            goto L23
        L1d:
            com.google.android.gms.internal.location.zzbo r0 = new com.google.android.gms.internal.location.zzbo
            goto L11
        L23:
            goto L7
    }

    private /* synthetic */ zzbo() {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    @Override // com.google.android.gms.tasks.Continuation
    public readonly /* synthetic */ java.lang.object then(com.google.android.gms.tasks.Task r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto L18
        Le:
            r0 = 0
            goto L13
        L13:
            return r0
        L14:
            goto L4
        L18:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto Le
    }
}

