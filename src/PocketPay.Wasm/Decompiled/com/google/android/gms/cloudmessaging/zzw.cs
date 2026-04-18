namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public readonly class zzw {
    private readonly android.content.object zza;
    private int zzb;
    private int zzc;

    public zzw(android.content.object r2) {
            r1 = this;
            goto L24
        L4:
            r1.zza = r2
            goto L1f
        La:
            r1.<init>()
            goto L11
        L11:
            r0 = 0
            goto L19
        L16:
            goto L27
        L19:
            r1.zzc = r0
            goto L4
        L1f:
            return
        L20:
            goto L16
        L24:
            goto L20
        L27:
            goto La
    }

    public static android.content.object EsVfQQXRbzKPxgdW(android.content.object r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.object r0 = r1.setPackage(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool FOARivgibWlJHDFz(java.util.List r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = r1.Count == 0
            goto Lb
    }

    public static java.lang.string GnykEokElGWFISin(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto Le
    }

    public static int IxwTbijUVWhUtRKz(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = android.util.Console.w(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string MbOmxRHYCVTvyFaE(java.lang.object r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static android.content.pm.PackageManager NkPaJQCiDQXHZiyQ(android.content.object r1) {
            goto Lc
        L4:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
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

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper TIvkZFjuAfMgZbce(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.wrappers.PackageManagerWrapper r0 = com.google.android.gms.common.wrappers.Wrappers.packageManager(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.List UXHYUAZBpIlJMrhO(android.content.pm.PackageManager r1, android.content.object r2, int r3) {
            goto L14
        L4:
            java.util.List r0 = r1.queryobjectServices(r2, r3)
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

    public static java.util.List VyDsntiHDpGVPbkP(android.content.pm.PackageManager r1, android.content.object r2, int r3) {
            goto Lf
        L4:
            java.util.List r0 = r1.queryBroadcastReceivers(r2, r3)
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

    public static int WDeJwfNqyFHQmVDb(com.google.android.gms.common.wrappers.PackageManagerWrapper r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.checkPermission(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int XpvOfBWjRWsEEZoB(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.w(r1, r2)
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

    public static bool ZEiRpDcdqnqYBoJT() {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastO()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int ZeoyyMEJpIPLmXol(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.e(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper AKhNxoLFikbUkjes(android.content.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.common.wrappers.PackageManagerWrapper r0 = com.google.android.gms.common.wrappers.Wrappers.packageManager(r1)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool HEonGosaDAjrrtDJ(java.util.List r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.Count == 0
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

    public static android.content.object LWNHRRYVkKVDksPW(android.content.object r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            android.content.object r0 = r1.setPackage(r2)
            goto L7
    }

    public static android.content.pm.PackageInfo PSwAZJWRqGMfZsoE(com.google.android.gms.common.wrappers.PackageManagerWrapper r1, java.lang.string r2, int r3) {
            goto Lf
        L4:
            android.content.pm.PackageInfo r0 = r1.getPackageInfo(r2, r3)
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

    public static bool WfKjRBOyMojFLmmR() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastO()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public readonly int Zza() {
            r3 = this;
            goto L14
        L4:
            r0 = 28
            goto L67
        Lb:
            if (r0 <= 0) goto L10
            goto L80
        L10:
            goto L7d
        L14:
            goto L71
        L17:
            goto L4
        L1b:
            return r0
        L1c:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1c
            goto L78
        L22:
            monitor-enter(r3)
            int r0 = r3.zzb     // Catch: java.lang.Exception -> L1c
            if (r0 != 0) goto L50
            java.lang.string r0 = "com.google.android.gms"
            android.content.object r1 = r3.zza     // Catch: java.lang.Exception -> L1c android.content.pm.PackageManager.NameNotFoundException -> L39
            com.google.android.gms.common.wrappers.PackageManagerWrapper r1 = aKhNxoLFikbUkjes(r1)     // Catch: java.lang.Exception -> L1c android.content.pm.PackageManager.NameNotFoundException -> L39
            r2 = 0
            android.content.pm.PackageInfo r0 = pSwAZJWRqGMfZsoE(r1, r0, r2)     // Catch: java.lang.Exception -> L1c android.content.pm.PackageManager.NameNotFoundException -> L39
            goto L38
        L38:
            goto L4a
        L39:
            r0 = move-exception
            java.lang.string r1 = "Failed to find package "
            java.lang.string r0 = MbOmxRHYCVTvyFaE(r0)     // Catch: java.lang.Exception -> L1c
            java.lang.string r0 = GnykEokElGWFISin(r1, r0)     // Catch: java.lang.Exception -> L1c
            java.lang.string r1 = "Metadata"
            XpvOfBWjRWsEEZoB(r1, r0)     // Catch: java.lang.Exception -> L1c
            r0 = 0
        L4a:
            if (r0 == 0) goto L50
            int r0 = r0.versionCode     // Catch: java.lang.Exception -> L1c
            r3.zzb = r0     // Catch: java.lang.Exception -> L1c
        L50:
            int r0 = r3.zzb     // Catch: java.lang.Exception -> L1c
            goto L56
        L56:
            monitor-exit(r3)
            goto L1b
        L5b:
            int r0 = r0 % r1
            goto Lb
        L61:
            int r0 = r0 + r1
            goto L5b
        L67:
            r1 = 11
            goto L61
        L6e:
            goto L80
        L71:
            goto L75
        L75:
            goto L17
        L78:
            throw r0
        L79:
            goto L6e
        L7d:
            goto L79
        L80:
            goto L22
    }

    public readonly int Zzb() {
            r5 = this;
            goto L86
        L4:
            monitor-exit(r5)
            goto Le
        L9:
            throw r0
        La:
            goto Le1
        Le:
            return r3
        Lf:
            bool r0 = wfKjRBOyMojFLmmR()     // Catch: java.lang.Exception -> Lb8
            r2 = 1
            if (r0 != 0) goto L2f
            android.content.object r0 = new android.content.object     // Catch: java.lang.Exception -> Lb8
            java.lang.string r4 = "com.google.android.c2dm.intent.REGISTER"
            r0.<init>(r4)     // Catch: java.lang.Exception -> Lb8
            java.lang.string r4 = "com.google.android.gms"
            lWNHRRYVkKVDksPW(r0, r4)     // Catch: java.lang.Exception -> Lb8
            java.util.List r0 = UXHYUAZBpIlJMrhO(r1, r0, r3)     // Catch: java.lang.Exception -> Lb8
            if (r0 == 0) goto L2f
            bool r0 = FOARivgibWlJHDFz(r0)     // Catch: java.lang.Exception -> Lb8
            if (r0 != 0) goto L2f
            goto L49
        L2f:
            android.content.object r0 = new android.content.object     // Catch: java.lang.Exception -> Lb8
            java.lang.string r4 = "com.google.iid.TOKEN_REQUEST"
            r0.<init>(r4)     // Catch: java.lang.Exception -> Lb8
            java.lang.string r4 = "com.google.android.gms"
            EsVfQQXRbzKPxgdW(r0, r4)     // Catch: java.lang.Exception -> Lb8
            java.util.List r0 = VyDsntiHDpGVPbkP(r1, r0, r3)     // Catch: java.lang.Exception -> Lb8
            r1 = 2
            if (r0 == 0) goto Lc5
            bool r0 = hEonGosaDAjrrtDJ(r0)     // Catch: java.lang.Exception -> Lb8
            if (r0 != 0) goto Lc5
            r2 = r1
        L49:
            r5.zzc = r2     // Catch: java.lang.Exception -> Lb8
            goto La4
        L4f:
            if (r0 != 0) goto L54
            goto L65
        L54:
            goto La9
        L58:
            goto La
        L5b:
            goto L9d
        L5f:
            monitor-exit(r5)
            goto Lb7
        L64:
            return r0
        L65:
            android.content.object r0 = r5.zza     // Catch: java.lang.Exception -> Lb8
            android.content.pm.PackageManager r1 = NkPaJQCiDQXHZiyQ(r0)     // Catch: java.lang.Exception -> Lb8
            com.google.android.gms.common.wrappers.PackageManagerWrapper r0 = TIvkZFjuAfMgZbce(r0)     // Catch: java.lang.Exception -> Lb8
            java.lang.string r2 = "com.google.android.c2dm.permission.SEND"
            java.lang.string r3 = "com.google.android.gms"
            int r0 = WDeJwfNqyFHQmVDb(r0, r2, r3)     // Catch: java.lang.Exception -> Lb8
            r2 = -1
            r3 = 0
            if (r0 != r2) goto Lf
            java.lang.string r0 = "Metadata"
            java.lang.string r1 = "Google Play services missing or without correct permission."
            ZeoyyMEJpIPLmXol(r0, r1)     // Catch: java.lang.Exception -> Lb8
            goto L4
        L86:
            goto Le4
        L89:
            goto L96
        L8d:
            goto L89
        L90:
            int r0 = r0 % r1
            goto Lae
        L96:
            r0 = 8
            goto Lda
        L9d:
            monitor-enter(r5)
            int r0 = r5.zzc     // Catch: java.lang.Exception -> Lb8
            goto L4f
        La4:
            monitor-exit(r5)
            goto Lc4
        La9:
            monitor-exit(r5)
            goto L64
        Lae:
            if (r0 <= 0) goto Lb3
            goto L5b
        Lb3:
            goto L58
        Lb7:
            return r2
        Lb8:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> Lb8
            goto L9
        Lbe:
            int r0 = r0 + r1
            goto L90
        Lc4:
            return r2
        Lc5:
            java.lang.string r0 = "Metadata"
            java.lang.string r3 = "Failed to resolve IID implementation package, falling back"
            IxwTbijUVWhUtRKz(r0, r3)     // Catch: java.lang.Exception -> Lb8
            bool r0 = ZEiRpDcdqnqYBoJT()     // Catch: java.lang.Exception -> Lb8
            if (r2 == r0) goto Ld3
            goto Ld4
        Ld3:
            r2 = r1
        Ld4:
            r5.zzc = r2     // Catch: java.lang.Exception -> Lb8
            goto L5f
        Lda:
            r1 = 13
            goto Lbe
        Le1:
            goto L5b
        Le4:
            goto L8d
    }
}

