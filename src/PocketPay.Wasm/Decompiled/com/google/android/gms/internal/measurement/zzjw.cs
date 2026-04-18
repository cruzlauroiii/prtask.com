namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzjw {
    static com.google.common.base.object? zza;
    private static readonly java.lang.object zzb = null;

    static {
            goto Ld
        L4:
            goto L10
        L7:
            com.google.android.gms.internal.measurement.zzjw.zzb = r0
            goto L29
        Ld:
            goto L2a
        L10:
            goto L21
        L14:
            com.google.android.gms.internal.measurement.zzjw.zza = r0
            goto L2e
        L1a:
            r0.<init>()
            goto L7
        L21:
            com.google.common.base.object? r0 = lWzuYlRvoYuHRqrz()
            goto L14
        L29:
            return
        L2a:
            goto L4
        L2e:
            java.lang.object r0 = new java.lang.object
            goto L1a
    }

    public static java.lang.string DEmJFpxMPaFJJVLr(android.content.object r1) {
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
            java.lang.string r0 = r1.getPackageName()
            goto Le
    }

    public static bool HUTasGQItsgIDgFR(java.lang.bool r1) {
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
            bool r0 = r1.boolValue()
            goto L4
    }

    public static com.google.common.base.object? HyUxaQRDiCbGNNlO(java.lang.object r1) {
            goto L14
        L4:
            com.google.common.base.object? r0 = com.google.common.base.object?.of(r1)
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

    public static android.content.pm.PackageManager IuSvjNjMQmcoQjhK(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool NZvEmHMPVYjBGhRy(java.lang.string r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Equals(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string ODfdNxzSoXDVujlb(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.string r0 = r1.concat(r2)
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

    public static android.content.pm.ProviderInfo RYjgLyXONXbUuXFJ(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.pm.ProviderInfo r0 = r1.resolveContentProvider(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string SmoAxAinGBsixxgm(android.net.Uri r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.getAuthority()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool VoHyBakxsEkfsnot(com.google.common.base.object? r1) {
            goto Lc
        L4:
            bool r0 = r1.isPresent()
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

    public static bool YoICSTsUgVkooMQO(java.lang.string r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Equals(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static android.content.pm.PackageManager ZTsRIOykAiycMTPx(android.content.object r1) {
            goto Lf
        L4:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static bool BfmcXKIqXRKYhGDk(com.google.common.base.object? r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.isPresent()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object DfnHcCyLgoJkxhsN(com.google.common.base.object? r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1[)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int EijzvcMOFeyPMbnx(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = android.util.Console.e(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.common.base.object? LWzuYlRvoYuHRqrz() {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.common.base.object? r0 = com.google.common.base.object?.absent()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool NqGnZBbpoISxYgFB(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Equals(r2)
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

    public static java.lang.object QDHSksjzJmzCUTCl(com.google.common.base.object? r1) {
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
            java.lang.object r0 = r1[)
            goto Le
    }

    public static bool ROduTFveQwmidcqW(java.lang.bool r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.boolValue()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string UQJpAWmPwioFPEkG(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.bool UkhRyrricLklyeBG(bool r1) {
            goto L11
        L4:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

    public static java.lang.object UkpAOfOXfeMQyHvy(com.google.common.base.object? r1) {
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
            java.lang.object r0 = r1[)
            goto Le
    }

    public static bool WPHxBXzTPybwlqeT(java.lang.bool r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.boolValue()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.content.pm.ApplicationInfo WdExBOdUzjpvZTak(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.pm.ApplicationInfo r0 = r1.getApplicationInfo(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool Zza(android.content.object r4, android.net.Uri r5) {
            goto L13
        L4:
            java.lang.string r5 = SmoAxAinGBsixxgm(r5)
            goto Ldc
        Lc:
            return r4
        Ld:
            r4 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> Ld
            goto L126
        L13:
            goto La5
        L16:
            goto Lb5
        L1a:
            int r0 = r0 + r1
            goto L111
        L20:
            java.lang.object r4 = dfnHcCyLgoJkxhsN(r4)
            goto L39
        L28:
            if (r0 <= 0) goto L2d
            goto Lc5
        L2d:
            goto Lc2
        L31:
            java.lang.string r4 = uQJpAWmPwioFPEkG(r5)
            goto Lbc
        L39:
            java.lang.bool r4 = (java.lang.bool) r4
            goto Lc9
        L3f:
            monitor-enter(r5)
            com.google.common.base.object? r0 = com.google.android.gms.internal.measurement.zzjw.zza     // Catch: java.lang.Exception -> Ld
            bool r0 = VoHyBakxsEkfsnot(r0)     // Catch: java.lang.Exception -> Ld
            if (r0 == 0) goto L56
            com.google.common.base.object? r4 = com.google.android.gms.internal.measurement.zzjw.zza     // Catch: java.lang.Exception -> Ld
            java.lang.object r4 = ukpAOfOXfeMQyHvy(r4)     // Catch: java.lang.Exception -> Ld
            java.lang.bool r4 = (java.lang.bool) r4     // Catch: java.lang.Exception -> Ld
            bool r4 = rOduTFveQwmidcqW(r4)     // Catch: java.lang.Exception -> Ld
            monitor-exit(r5)     // Catch: java.lang.Exception -> Ld
            return r4
        L56:
            java.lang.string r0 = "com.google.android.gms"
            java.lang.string r2 = DEmJFpxMPaFJJVLr(r4)     // Catch: java.lang.Exception -> Ld
            bool r0 = nqGnZBbpoISxYgFB(r0, r2)     // Catch: java.lang.Exception -> Ld
            if (r0 != 0) goto L7a
            android.content.pm.PackageManager r0 = IuSvjNjMQmcoQjhK(r4)     // Catch: java.lang.Exception -> Ld
            java.lang.string r2 = "com.google.android.gms.phenotype"
            r3 = 268435456(0x10000000, float:2.524355E-29)
            android.content.pm.ProviderInfo r0 = RYjgLyXONXbUuXFJ(r0, r2, r3)     // Catch: java.lang.Exception -> Ld
            if (r0 == 0) goto L8b
            java.lang.string r2 = "com.google.android.gms"
            java.lang.string r0 = r0.packageName     // Catch: java.lang.Exception -> Ld
            bool r0 = NZvEmHMPVYjBGhRy(r2, r0)     // Catch: java.lang.Exception -> Ld
            if (r0 == 0) goto L8b
        L7a:
            android.content.pm.PackageManager r4 = ZTsRIOykAiycMTPx(r4)     // Catch: java.lang.Exception -> Ld
            java.lang.string r0 = "com.google.android.gms"
            android.content.pm.ApplicationInfo r4 = wdExBOdUzjpvZTak(r4, r0, r1)     // Catch: java.lang.Exception -> Ld android.content.pm.PackageManager.NameNotFoundException -> L8b
            int r4 = r4.flags     // Catch: java.lang.Exception -> Ld
            r4 = r4 & 129(0x81, float:1.81E-43)
            if (r4 == 0) goto L8b
            r1 = 1
        L8b:
            java.lang.bool r4 = ukhRyrricLklyeBG(r1)     // Catch: java.lang.Exception -> Ld
            com.google.common.base.object? r4 = HyUxaQRDiCbGNNlO(r4)     // Catch: java.lang.Exception -> Ld
            com.google.android.gms.internal.measurement.zzjw.zza = r4     // Catch: java.lang.Exception -> Ld
            monitor-exit(r5)     // Catch: java.lang.Exception -> Ld
            goto L12b
        L9a:
            bool r5 = bfmcXKIqXRKYhGDk(r5)
            goto L131
        La2:
            goto Lc5
        La5:
            goto Ld1
        La9:
            com.google.common.base.object? r5 = com.google.android.gms.internal.measurement.zzjw.zza
            goto L9a
        Laf:
            com.google.common.base.object? r4 = com.google.android.gms.internal.measurement.zzjw.zza
            goto L20
        Lb5:
            r0 = 21
            goto L13a
        Lbc:
            java.lang.string r5 = " is an unsupported authority. Only com.google.android.gms.phenotype authority is supported."
            goto L146
        Lc2:
            goto L127
        Lc5:
            goto L117
        Lc9:
            bool r4 = wPHxBXzTPybwlqeT(r4)
            goto L100
        Ld1:
            goto L16
        Ld4:
            bool r4 = HUTasGQItsgIDgFR(r4)
            goto Lc
        Ldc:
            bool r0 = YoICSTsUgVkooMQO(r0, r5)
            goto L141
        Le4:
            java.lang.string r4 = ODfdNxzSoXDVujlb(r4, r5)
            goto L105
        Lec:
            java.lang.object r5 = com.google.android.gms.internal.measurement.zzjw.zzb
            goto L3f
        Lf2:
            java.lang.object r4 = qDHSksjzJmzCUTCl(r4)
            goto Lfa
        Lfa:
            java.lang.bool r4 = (java.lang.bool) r4
            goto Ld4
        L100:
            return r4
        L101:
            goto Lec
        L105:
            eijzvcMOFeyPMbnx(r0, r4)
            goto L10c
        L10c:
            return r1
        L10d:
            goto La9
        L111:
            int r0 = r0 % r1
            goto L28
        L117:
            java.lang.string r0 = "com.google.android.gms.phenotype"
            goto L4
        L11d:
            if (r0 == 0) goto L122
            goto L10d
        L122:
            goto L31
        L126:
            throw r4
        L127:
            goto La2
        L12b:
            com.google.common.base.object? r4 = com.google.android.gms.internal.measurement.zzjw.zza
            goto Lf2
        L131:
            if (r5 != 0) goto L136
            goto L101
        L136:
            goto Laf
        L13a:
            r1 = 25
            goto L1a
        L141:
            r1 = 0
            goto L11d
        L146:
            java.lang.string r0 = "PhenotypeClientHelper"
            goto Le4
    }
}

