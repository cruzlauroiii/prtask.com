namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzp : com.google.android.gms.internal.location.zza : com.google.android.gms.internal.location.zzr {
    zzp(android.os.IBinder r2) {
            r1 = this;
            goto L14
        L4:
            java.lang.string r0 = "com.google.android.gms.location.internal.IFusedLocationProviderCallback"
            goto Ld
        La:
            goto L17
        Ld:
            r1.<init>(r2, r0)
            goto L1b
        L14:
            goto L1c
        L17:
            goto L4
        L1b:
            return
        L1c:
            goto La
    }

    @Override // com.google.android.gms.internal.location.zzr
    public readonly void Zzd(com.google.android.gms.internal.location.zzl r1) throws android.os.RemoteException {
            r0 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto Lb
        Lb:
            r0 = 0
            goto L10
        L10:
            throw r0
        L11:
            goto L15
        L15:
            goto L7
    }

    @Override // com.google.android.gms.internal.location.zzr
    public readonly void Zze() throws android.os.RemoteException {
            r0 = this;
            goto L11
        L4:
            r0 = 0
            goto Lc
        L9:
            goto L14
        Lc:
            throw r0
        Ld:
            goto L9
        L11:
            goto Ld
        L14:
            goto L4
    }
}

