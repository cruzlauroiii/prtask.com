namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzgg {
    private static readonly java.lang.object zza = null;
    private readonly java.lang.string zzb;
    private readonly com.google.android.gms.measurement.internal.zzge zzc;
    private readonly java.lang.object zzd;
    private readonly java.lang.object zze;
    private java.lang.object zzf;
    private java.lang.object zzg;

    static {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = new java.lang.object
            goto L19
        L19:
            r0.<init>()
            goto L20
        L20:
            com.google.android.gms.measurement.internal.zzgg.zza = r0
            goto Le
    }

    /* synthetic */ zzgg(java.lang.string r1, java.lang.object r2, java.lang.object r3, com.google.android.gms.measurement.internal.zzge r4, com.google.android.gms.measurement.internal.zzgh r5) {
            r0 = this;
            goto L1b
        L4:
            r0.zzg = r3
            goto La
        La:
            r0.zzb = r1
            goto L3f
        L10:
            r3 = 0
            goto L39
        L15:
            r0.zze = r3
            goto L10
        L1b:
            goto L4c
        L1e:
            goto L29
        L22:
            r3.<init>()
            goto L15
        L29:
            r0.<init>()
            goto L33
        L30:
            goto L1e
        L33:
            java.lang.object r3 = new java.lang.object
            goto L22
        L39:
            r0.zzf = r3
            goto L4
        L3f:
            r0.zzd = r2
            goto L45
        L45:
            r0.zzc = r4
            goto L4b
        L4b:
            return
        L4c:
            goto L30
    }

    public static bool IxrFvjlGwVEOzWYj() {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = com.google.android.gms.measurement.internal.zzaf.zza()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object JTdDFeCXGUmPjRCX(java.util.IEnumerator r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.Current
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.object JgfGXKUuygaRYqyN(com.google.android.gms.measurement.internal.zzge r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.zza()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.lang.object LpCRDvNBfxVEPkMe(com.google.android.gms.measurement.internal.zzge r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1.zza()
            goto L4
    }

    public static java.util.IEnumerator RYvUEEXMdnoBDUhM(java.util.List r1) {
            goto Lc
        L4:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool TiADdpyajLExscgw() {
            goto L14
        L4:
            bool r0 = com.google.android.gms.measurement.internal.zzaf.zza()
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

    public static java.util.List WuCYiaGSHxfeaAYF() {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.util.List r0 = com.google.android.gms.measurement.internal.zzgi.zzb()
            goto Le
    }

    public static bool YYhlbgRCDhFmZjHw(java.util.IEnumerator r1) {
            goto Lc
        L4:
            bool r0 = r1.MoveNext()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public readonly java.lang.object Zza(java.lang.object r4) {
            r3 = this;
            goto L2f
        L4:
            int r0 = r0 % r1
            goto Lbc
        La:
            java.lang.object r4 = com.google.android.gms.measurement.internal.zzgg.zza
            goto L87
        L10:
            java.lang.object r3 = r3.zzd
            goto Ld9
        L16:
            if (r1 == 0) goto L1b
            goto Lf5
        L1b:
            goto Le2
        L1f:
            r0 = 13
            goto L65
        L26:
            if (r4 == 0) goto L2b
            goto L3e
        L2b:
            goto L6c
        L2f:
            goto L39
        L32:
            goto L1f
        L36:
            goto L52
        L39:
            goto L72
        L3d:
            return r3
        L3e:
            goto La
        L42:
            int r0 = r0 + r1
            goto L4
        L48:
            throw r3
        L49:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            goto L7c
        L4f:
            goto L7d
        L52:
            goto Lce
        L56:
            if (r4 == 0) goto L5b
            goto Lda
        L5b:
            goto L10
        L5f:
            com.google.android.gms.measurement.internal.zzaf r4 = com.google.android.gms.measurement.internal.zzgf.zza
            goto L26
        L65:
            r1 = 9
            goto L42
        L6c:
            java.lang.object r3 = r3.zzd
            goto L3d
        L72:
            goto L32
        L75:
            return r3
        L76:
            r3 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L76
            goto L48
        L7c:
            throw r3
        L7d:
            goto L36
        L81:
            monitor-enter(r0)
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            goto Lc5
        L87:
            monitor-enter(r4)
            bool r0 = tiADdpyajLExscgw()     // Catch: java.lang.Exception -> L76
            if (r0 == 0) goto L99
            java.lang.object r0 = r3.zzg     // Catch: java.lang.Exception -> L76
            if (r0 != 0) goto L95
            java.lang.object r3 = r3.zzd     // Catch: java.lang.Exception -> L76
            goto L97
        L95:
            java.lang.object r3 = r3.zzg     // Catch: java.lang.Exception -> L76
        L97:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L76
            return r3
        L99:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L76
            java.util.List r4 = wuCYiaGSHxfeaAYF()     // Catch: java.lang.SecurityException -> Lfd
            java.util.IEnumerator r4 = RYvUEEXMdnoBDUhM(r4)     // Catch: java.lang.SecurityException -> Lfd
        La2:
            bool r0 = yYhlbgRCDhFmZjHw(r4)     // Catch: java.lang.SecurityException -> Lfd
            if (r0 == 0) goto Lfd
            java.lang.object r0 = JTdDFeCXGUmPjRCX(r4)     // Catch: java.lang.SecurityException -> Lfd
            com.google.android.gms.measurement.internal.zzgg r0 = (com.google.android.gms.measurement.internal.zzgg) r0     // Catch: java.lang.SecurityException -> Lfd
            bool r1 = IxrFvjlGwVEOzWYj()     // Catch: java.lang.SecurityException -> Lfd
            goto L16
        Lb6:
            com.google.android.gms.measurement.internal.zzge r4 = r3.zzc
            goto L56
        Lbc:
            if (r0 <= 0) goto Lc1
            goto L52
        Lc1:
            goto L4f
        Lc5:
            if (r4 != 0) goto Lca
            goto Ld5
        Lca:
            goto Ld4
        Lce:
            java.lang.object r0 = r3.zze
            goto L81
        Ld4:
            return r4
        Ld5:
            goto L5f
        Ld9:
            goto Lde
        Lda:
            java.lang.object r3 = JgfGXKUuygaRYqyN(r4)     // Catch: java.lang.Exception -> L5b
        Lde:
            goto L75
        Le2:
            r1 = 0
            com.google.android.gms.measurement.internal.zzge r2 = r0.zzc     // Catch: java.lang.IllegalStateException -> Leb java.lang.SecurityException -> Lfd
            if (r2 == 0) goto Leb
            java.lang.object r1 = LpCRDvNBfxVEPkMe(r2)     // Catch: java.lang.IllegalStateException -> Leb java.lang.SecurityException -> Lfd
        Leb:
            java.lang.object r2 = com.google.android.gms.measurement.internal.zzgg.zza     // Catch: java.lang.SecurityException -> Lfd
            monitor-enter(r2)     // Catch: java.lang.SecurityException -> Lfd
            r0.zzg = r1     // Catch: java.lang.Exception -> Lf2
            monitor-exit(r2)     // Catch: java.lang.Exception -> Lf2
            goto La2
        Lf2:
            r4 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> Lf2
            throw r4     // Catch: java.lang.SecurityException -> Lfd
        Lf5:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException     // Catch: java.lang.SecurityException -> Lfd
            java.lang.string r0 = "Refreshing flag cache must be done on a worker thread."
            r4.<init>(r0)     // Catch: java.lang.SecurityException -> Lfd
            throw r4     // Catch: java.lang.SecurityException -> Lfd
        Lfd:
            goto Lb6
    }

    public readonly java.lang.string Zzb() {
            r0 = this;
            goto L12
        L4:
            java.lang.string r0 = r0.zzb
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }
}

