namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public abstract class zzc {
    private java.lang.object zza;
    private bool zzb;
    readonly /* synthetic */ com.google.android.gms.common.internal.BaseGmsClient zzd;

    public zzc(com.google.android.gms.common.internal.BaseGmsClient r1, java.lang.object r2) {
            r0 = this;
            goto L1a
        L4:
            r0.zzd = r1
            goto L21
        La:
            r0.zzb = r1
            goto L15
        L10:
            r1 = 0
            goto La
        L15:
            return
        L16:
            goto L2e
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            r0.<init>()
            goto L28
        L28:
            r0.zza = r2
            goto L10
        L2e:
            goto L1d
    }

    public static java.lang.stringBuilder EzJBViiMbTtESdkK(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int LbrCTcfwkvPsigQo(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = android.util.Console.w(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string MoFKLbbqdEmMCHfs(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void NXYparQSSvQWNeqx(com.google.android.gms.common.internal.zzc r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.zzg()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static java.util.List PbJZKYemoWnHyOdP(com.google.android.gms.common.internal.BaseGmsClient r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.List r0 = com.google.android.gms.common.internal.BaseGmsClient.zzf(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool SIuVwNMIWGNFIjag(java.util.List r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.Remove(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void WPWGmoXvxxUkqPWe(com.google.android.gms.common.internal.zzc r0, java.lang.object r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.zza(r1)
            goto L4
        L17:
            goto Lc
    }

    public static java.util.List AossRbsWKJZcTdcV(com.google.android.gms.common.internal.BaseGmsClient r1) {
            goto L14
        L4:
            java.util.List r0 = com.google.android.gms.common.internal.BaseGmsClient.zzf(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.string FIQVcuCEapvINNdX(java.lang.object r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.tostring()
            goto L4
    }

    public static java.lang.stringBuilder KuaYJvwqblDoWfwl(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void UjsPYoMuvidZbpuI(com.google.android.gms.common.internal.zzc r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.zzf()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    protected abstract void Zza(java.lang.object r1);

    protected abstract void Zzc();

    public readonly void Zze() {
            r5 = this;
            goto L3d
        L4:
            goto L47
        L7:
            goto L3a
        Lb:
            monitor-enter(r5)
            java.lang.object r1 = r5.zza     // Catch: java.lang.Exception -> L51
            bool r2 = r5.zzb     // Catch: java.lang.Exception -> L51
            if (r2 == 0) goto L2c
            java.lang.string r2 = "GmsClient"
            java.lang.string r3 = fIQVcuCEapvINNdX(r5)     // Catch: java.lang.Exception -> L51
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L51
            r4.<init>(r0)     // Catch: java.lang.Exception -> L51
            kuaYJvwqblDoWfwl(r4, r3)     // Catch: java.lang.Exception -> L51
            java.lang.string r0 = " being reused. This is not safe."
            EzJBViiMbTtESdkK(r4, r0)     // Catch: java.lang.Exception -> L51
            java.lang.string r0 = MoFKLbbqdEmMCHfs(r4)     // Catch: java.lang.Exception -> L51
            LbrCTcfwkvPsigQo(r2, r0)     // Catch: java.lang.Exception -> L51
        L2c:
            monitor-exit(r5)     // Catch: java.lang.Exception -> L51
            goto L99
        L31:
            if (r0 <= 0) goto L36
            goto L47
        L36:
            goto L44
        L3a:
            goto L40
        L3d:
            goto L7
        L40:
            goto L83
        L44:
            goto L4c
        L47:
            goto L77
        L4b:
            throw r0
        L4c:
            goto L4
        L50:
            throw r0
        L51:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L51
            goto L4b
        L57:
            monitor-enter(r5)
            goto L91
        L5c:
            WPWGmoXvxxUkqPWe(r5, r1)
        L5f:
            goto L57
        L63:
            int r0 = r0 + r1
            goto L7d
        L69:
            NXYparQSSvQWNeqx(r5)
            goto L8a
        L70:
            r1 = 32
            goto L63
        L77:
            java.lang.string r0 = "Callback proxy "
            goto Lb
        L7d:
            int r0 = r0 % r1
            goto L31
        L83:
            r0 = 2
            goto L70
        L8a:
            return
        L8b:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L8b
            goto L50
        L91:
            r0 = 1
            r5.zzb = r0     // Catch: java.lang.Exception -> L8b
            monitor-exit(r5)     // Catch: java.lang.Exception -> L8b
            goto L69
        L99:
            if (r1 != 0) goto L9e
            goto L5f
        L9e:
            goto L5c
    }

    public readonly void Zzf() {
            r1 = this;
            goto Lc
        L4:
            monitor-enter(r1)
            goto L18
        L9:
            goto Lf
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            throw r0
        L14:
            goto L9
        L18:
            r0 = 0
            r1.zza = r0     // Catch: java.lang.Exception -> L1d
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1d
            return
        L1d:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1d
            goto L13
    }

    public readonly void Zzg() {
            r2 = this;
            goto L12
        L4:
            throw r2
        L5:
            goto L30
        L9:
            com.google.android.gms.common.internal.BaseGmsClient r0 = r2.zzd
            goto L5c
        Lf:
            goto L15
        L12:
            goto L33
        L15:
            goto L20
        L19:
            goto L5
        L1c:
            goto L55
        L20:
            r0 = 11
            goto L64
        L27:
            if (r0 <= 0) goto L2c
            goto L1c
        L2c:
            goto L19
        L30:
            goto L1c
        L33:
            goto Lf
        L37:
            int r0 = r0 % r1
            goto L27
        L3d:
            monitor-enter(r0)
            com.google.android.gms.common.internal.BaseGmsClient r1 = r2.zzd     // Catch: java.lang.Exception -> L49
            java.util.List r1 = aossRbsWKJZcTdcV(r1)     // Catch: java.lang.Exception -> L49
            SIuVwNMIWGNFIjag(r1, r2)     // Catch: java.lang.Exception -> L49
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            return
        L49:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            goto L4
        L4f:
            int r0 = r0 + r1
            goto L37
        L55:
            ujsPYoMuvidZbpuI(r2)
            goto L9
        L5c:
            java.util.List r0 = PbJZKYemoWnHyOdP(r0)
            goto L3d
        L64:
            r1 = 18
            goto L4f
    }
}

