namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
public readonly class zzi {
    private static readonly java.util.HashSet zza = null;
    private static readonly java.util.HashSet zzb = null;
    private static readonly java.util.Dictionary zzc = null;
    private static readonly com.google.android.play.core.appupdate.internal.zzm zzd = null;

    static {
            goto L72
        L4:
            java.lang.string r4 = "app_update"
            goto Ldd
        La:
            r1 = 2
            goto L98
        Lf:
            r2[r5] = r4
            goto Lc2
        L15:
            r1[r3] = r2
            goto L37
        L1b:
            java.lang.string[] r1 = new java.lang.string[r1]
            goto Le3
        L21:
            goto L75
        L24:
            r1 = 4
            goto L59
        L2b:
            r1[r5] = r2
            goto Le9
        L31:
            java.lang.string r1 = "PlayCoreVersion"
            goto L85
        L37:
            java.lang.string r2 = "unity"
            goto L2b
        L3d:
            if (r0 <= 0) goto L42
            goto L7c
        L42:
            goto L79
        L46:
            r0 = 6
            goto L24
        L4d:
            goto L7c
        L50:
            goto L21
        L54:
            r3 = 0
            goto L4
        L59:
            int r0 = r0 + r1
            goto Lca
        L5f:
            r0.<init>(r1)
            goto Lbc
        L66:
            com.google.android.play.core.appupdate.internal.zzi.zzd = r0
            goto Lb7
        L6c:
            com.google.android.play.core.appupdate.internal.zzm r0 = new com.google.android.play.core.appupdate.internal.zzm
            goto L31
        L72:
            goto L50
        L75:
            goto L46
        L79:
            goto Lb8
        L7c:
            goto La4
        L80:
            r5 = 1
            goto Lf
        L85:
            r0.<init>(r1)
            goto L66
        L8c:
            java.lang.string r4 = "review"
            goto L80
        L92:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto L1b
        L98:
            java.lang.string[] r2 = new java.lang.string[r1]
            goto L54
        L9e:
            com.google.android.play.core.appupdate.internal.zzi.zzc = r0
            goto L6c
        La4:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto La
        Laa:
            com.google.android.play.core.appupdate.internal.zzi.zza = r0
            goto L92
        Lb0:
            r0.<init>(r2)
            goto Laa
        Lb7:
            return
        Lb8:
            goto L4d
        Lbc:
            com.google.android.play.core.appupdate.internal.zzi.zzb = r0
            goto Ld0
        Lc2:
            java.util.List r2 = vRFFrGMsFDxwpqHO(r2)
            goto Lb0
        Lca:
            int r0 = r0 % r1
            goto L3d
        Ld0:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto Ld6
        Ld6:
            r0.<init>()
            goto L9e
        Ldd:
            r2[r3] = r4
            goto L8c
        Le3:
            java.lang.string r2 = "native"
            goto L15
        Le9:
            java.util.List r1 = ljtqDVkLJXUwbdOi(r1)
            goto L5f
    }

    public static java.lang.object EDjziJMOwcCwxqgb(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
    }

    public static bool AzCgvXRhtQdYeFbs(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.ContainsKey(r2)
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

    public static java.lang.object IhocxdooBmKiMBwa(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
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

    public static java.lang.int JyVXdSzvdCyshIMk(int r1) {
            goto Lc
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.util.List LjtqDVkLJXUwbdOi(java.lang.object[] r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.List r0 = java.util.Arrays.asList(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.util.List VRFFrGMsFDxwpqHO(java.lang.object[] r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.List r0 = java.util.Arrays.asList(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object XZKhJUeLENlxTNdk(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lf
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.util.Dictionary Zza(java.lang.string r5) {
            goto L6c
        L4:
            if (r0 <= 0) goto L9
            goto L5f
        L9:
            goto L5c
        Ld:
            goto L5f
        L10:
            goto L69
        L14:
            return r0
        L15:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L15
            goto L79
        L1b:
            r0 = 22
            goto L50
        L22:
            monitor-enter(r5)
            java.util.Dictionary r0 = com.google.android.play.core.appupdate.internal.zzi.zzc     // Catch: java.lang.Exception -> L15
            java.lang.string r1 = "app_update"
            bool r2 = azCgvXRhtQdYeFbs(r0, r1)     // Catch: java.lang.Exception -> L15
            if (r2 != 0) goto L40
            java.util.HashDictionary r2 = new java.util.HashDictionary     // Catch: java.lang.Exception -> L15
            r2.<init>()     // Catch: java.lang.Exception -> L15
            java.lang.string r3 = "java"
            r4 = 11004(0x2afc, float:1.542E-41)
            java.lang.int r4 = jyVXdSzvdCyshIMk(r4)     // Catch: java.lang.Exception -> L15
            EDjziJMOwcCwxqgb(r2, r3, r4)     // Catch: java.lang.Exception -> L15
            xZKhJUeLENlxTNdk(r0, r1, r2)     // Catch: java.lang.Exception -> L15
        L40:
            java.lang.object r0 = ihocxdooBmKiMBwa(r0, r1)     // Catch: java.lang.Exception -> L15
            java.util.Dictionary r0 = (java.util.Dictionary) r0     // Catch: java.lang.Exception -> L15
            goto L57
        L4a:
            java.lang.Class<com.google.android.play.core.appupdate.internal.zzi> r5 = com.google.android.play.core.appupdate.internal.zzi.class
            goto L22
        L50:
            r1 = 24
            goto L73
        L57:
            monitor-exit(r5)
            goto L14
        L5c:
            goto L7a
        L5f:
            goto L4a
        L63:
            int r0 = r0 % r1
            goto L4
        L69:
            goto L6f
        L6c:
            goto L10
        L6f:
            goto L1b
        L73:
            int r0 = r0 + r1
            goto L63
        L79:
            throw r0
        L7a:
            goto Ld
    }
}

