namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class DataICollectionConfigStorage {
    public static readonly java.lang.string DATA_COLLECTION_DEFAULT_ENABLED = "firebase_data_collection_default_enabled";
    private static readonly java.lang.string FIREBASE_APP_PREFS = "com.google.firebase.common.prefs:";
    private bool dataICollectionDefaultEnabled;
    private readonly android.content.object deviceProtectedobject;
    private readonly com.google.firebase.events.Publisher publisher;
    private readonly android.content.Dictionary<string, object> sharedPreferences;

    public DataICollectionConfigStorage(android.content.object r3, java.lang.string r4, com.google.firebase.events.Publisher r5) {
            r2 = this;
            goto L81
        L4:
            java.lang.string r1 = "com.google.firebase.common.prefs:"
            goto L9c
        La:
            goto L84
        Ld:
            int r0 = r0 % r1
            goto L40
        L13:
            r2.sharedPreferences = r3
            goto L96
        L19:
            goto L3c
        L1c:
            goto L34
        L20:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L4
        L26:
            int r0 = r0 + r1
            goto Ld
        L2c:
            java.lang.string r4 = uQtsXLxavWwKyHCj(r4)
            goto L6e
        L34:
            r2.<init>()
            goto L58
        L3b:
            return
        L3c:
            goto L73
        L40:
            if (r0 <= 0) goto L45
            goto L1c
        L45:
            goto L19
        L49:
            r0 = 11
            goto L7a
        L50:
            java.lang.stringBuilder r4 = iHwOHrIxuVIlyKEx(r0, r4)
            goto L2c
        L58:
            android.content.object r3 = WnwuiaBLtAwwBNYC(r3)
            goto L60
        L60:
            r2.deviceProtectedobject = r3
            goto L20
        L66:
            bool r3 = lqqiQxQsOGfUHHnk(r2)
            goto L90
        L6e:
            r0 = 0
            goto L88
        L73:
            goto L1c
        L76:
            goto La
        L7a:
            r1 = 23
            goto L26
        L81:
            goto L76
        L84:
            goto L49
        L88:
            android.content.Dictionary<string, object> r3 = sAjCsetbvDjrypFx(r3, r4, r0)
            goto L13
        L90:
            r2.dataICollectionDefaultEnabled = r3
            goto L3b
        L96:
            r2.publisher = r5
            goto L66
        L9c:
            r0.<init>(r1)
            goto L50
    }

    public static void JhAkRIHTRdJNQsya(com.google.firebase.events.Publisher r0, com.google.firebase.events.Event r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.publish(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void JjhvZNuVGBzXNdDK(android.content.Dictionary<string, object>.Editor r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.apply()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static bool ORHfJQOHJScXDhIi(com.google.firebase.internal.DataICollectionConfigStorage r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.readManifestDataICollectionEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void TlpLsDayeBXyCWRn(com.google.firebase.internal.DataICollectionConfigStorage r0, bool r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.updateDataICollectionDefaultEnabled(r1)
            goto L4
    }

    public static android.content.object WnwuiaBLtAwwBNYC(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.object r0 = directBootSafe(r1)
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

    public static android.content.Dictionary<string, object>.Editor ZHfPVahFvfEmbjdL(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, bool r3) {
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
            android.content.Dictionary<string, object>$Editor r0 = r1.putbool(r2, r3)
            goto Lb
    }

    public static android.content.pm.ApplicationInfo ZMUuFQtQSkxhjIoB(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.content.pm.ApplicationInfo r0 = r1.getApplicationInfo(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.content.pm.PackageManager AjdpqadmuVIsqWvH(android.content.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
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

    public static android.content.Dictionary<string, object>.Editor CgBBvfHsgOjCskiz(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
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
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto L7
    }

    private static android.content.object DirectBootSafe(android.content.object r0) {
            goto Lf
        L4:
            android.content.object r0 = tkBDZtaSvfzUvwXi(r0)
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

    public static void FgpPsUBXWDpTdGcg(android.content.Dictionary<string, object>.Editor r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.apply()
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.stringBuilder IHwOHrIxuVIlyKEx(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor KXgoBPFyaPHdEbGB(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool LqqiQxQsOGfUHHnk(com.google.firebase.internal.DataICollectionConfigStorage r1) {
            goto Lc
        L4:
            bool r0 = r1.readAutoDataICollectionEnabled()
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

    public static bool MddJwXZEgqQgvTrE(com.google.firebase.internal.DataICollectionConfigStorage r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.readManifestDataICollectionEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool MecGRLigxgcxXWAI(android.content.Dictionary<string, object> r1, java.lang.string r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            bool r0 = r1.getbool(r2, r3)
            goto Le
    }

    public static bool NUKboqbUxBxUxFuF(android.os.Dictionary<string, object> r1, java.lang.string r2) {
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
            bool r0 = r1.getbool(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void NiBTBPsvaTHGJkqg(com.google.firebase.internal.DataICollectionConfigStorage r0, bool r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.updateDataICollectionDefaultEnabled(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static bool OTYkAnVAUJzgbjJb(android.os.Dictionary<string, object> r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.ContainsKey(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string QHwMKkPwwItHoMra(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getPackageName()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool QjlxaAPmLEWMxRHI(java.lang.bool r1, java.lang.object r2) {
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
            bool r0 = r1.Equals(r2)
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor QzNTBXsQNvGProSC(android.content.Dictionary<string, object> r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    private bool ReadAutoDataICollectionEnabled() {
            r2 = this;
            goto L4c
        L4:
            goto L75
        L7:
            goto L24
        Lb:
            android.content.Dictionary<string, object> r2 = r2.sharedPreferences
            goto L47
        L11:
            if (r0 <= 0) goto L16
            goto L75
        L16:
            goto L72
        L1a:
            return r2
        L1b:
            goto L5b
        L1f:
            return r2
        L20:
            goto L4
        L24:
            goto L4f
        L27:
            java.lang.string r1 = "firebase_data_collection_default_enabled"
            goto L79
        L2d:
            r0 = 10
            goto L40
        L34:
            int r0 = r0 % r1
            goto L11
        L3a:
            int r0 = r0 + r1
            goto L34
        L40:
            r1 = 1
            goto L3a
        L47:
            r0 = 1
            goto L53
        L4c:
            goto L7
        L4f:
            goto L2d
        L53:
            bool r2 = mecGRLigxgcxXWAI(r2, r1, r0)
            goto L1a
        L5b:
            bool r2 = mddJwXZEgqQgvTrE(r2)
            goto L1f
        L63:
            if (r0 != 0) goto L68
            goto L1b
        L68:
            goto Lb
        L6c:
            android.content.Dictionary<string, object> r0 = r2.sharedPreferences
            goto L27
        L72:
            goto L20
        L75:
            goto L6c
        L79:
            bool r0 = ywcELxMTxqKcLxyy(r0, r1)
            goto L63
    }

    private bool ReadManifestDataICollectionEnabled() {
            r3 = this;
            goto Lc
        L4:
            return r3
        L5:
            goto L5c
        L9:
            goto Lf
        Lc:
            goto L4a
        Lf:
            goto L61
        L13:
            int r0 = r0 % r1
            goto L73
        L19:
            java.lang.string r0 = "firebase_data_collection_default_enabled"
            android.content.object r1 = r3.deviceProtectedobject     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            android.content.pm.PackageManager r1 = ajdpqadmuVIsqWvH(r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            if (r1 == 0) goto L5
            android.content.object r3 = r3.deviceProtectedobject     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            java.lang.string r3 = qHwMKkPwwItHoMra(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            r2 = 128(0x80, float:1.8E-43)
            android.content.pm.ApplicationInfo r3 = ZMUuFQtQSkxhjIoB(r1, r3, r2)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            if (r3 == 0) goto L5
            android.os.Dictionary<string, object> r1 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            if (r1 == 0) goto L5
            android.os.Dictionary<string, object> r1 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            bool r1 = oTYkAnVAUJzgbjJb(r1, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            if (r1 == 0) goto L5
            android.os.Dictionary<string, object> r3 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            bool r3 = nUKboqbUxBxUxFuF(r3, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L5
            goto L4
        L47:
            goto L58
        L4a:
            goto L9
        L4e:
            r1 = 3
            goto L6d
        L55:
            goto L69
        L58:
            goto L19
        L5c:
            r3 = 1
            goto L68
        L61:
            r0 = 16
            goto L4e
        L68:
            return r3
        L69:
            goto L47
        L6d:
            int r0 = r0 + r1
            goto L13
        L73:
            if (r0 <= 0) goto L78
            goto L58
        L78:
            goto L55
    }

    public static android.content.Dictionary<string, object> SAjCsetbvDjrypFx(android.content.object r1, java.lang.string r2, int r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.content.object TkBDZtaSvfzUvwXi(android.content.object r1) {
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
            android.content.object r0 = androidx.core.content.objectCompat.createDeviceProtectedStorageobject(r1)
            goto L4
    }

    public static java.lang.string UQtsXLxavWwKyHCj(java.lang.stringBuilder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    private void UpdateDataICollectionDefaultEnabled(bool r5) {
            r4 = this;
            goto L1b
        L4:
            int r0 = r0 % r1
            goto L29
        La:
            return
        Lb:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> Lb
            goto L60
        L11:
            r0 = 25
            goto L32
        L18:
            goto L1e
        L1b:
            goto L25
        L1e:
            goto L11
        L22:
            goto L68
        L25:
            goto L18
        L29:
            if (r0 <= 0) goto L2e
            goto L68
        L2e:
            goto L65
        L32:
            r1 = 15
            goto L39
        L39:
            int r0 = r0 + r1
            goto L4
        L3f:
            monitor-enter(r4)
            bool r0 = r4.dataICollectionDefaultEnabled     // Catch: java.lang.Exception -> Lb
            if (r0 == r5) goto L57
            r4.dataICollectionDefaultEnabled = r5     // Catch: java.lang.Exception -> Lb
            com.google.firebase.events.Publisher r0 = r4.publisher     // Catch: java.lang.Exception -> Lb
            com.google.firebase.events.Event r1 = new com.google.firebase.events.Event     // Catch: java.lang.Exception -> Lb
            java.lang.Class<com.google.firebase.DataICollectionDefaultChange> r2 = com.google.firebase.DataICollectionDefaultChange.class
            com.google.firebase.DataICollectionDefaultChange r3 = new com.google.firebase.DataICollectionDefaultChange     // Catch: java.lang.Exception -> Lb
            r3.<init>(r5)     // Catch: java.lang.Exception -> Lb
            r1.<init>(r2, r3)     // Catch: java.lang.Exception -> Lb
            JhAkRIHTRdJNQsya(r0, r1)     // Catch: java.lang.Exception -> Lb
        L57:
            goto L5b
        L5b:
            monitor-exit(r4)
            goto La
        L60:
            throw r5
        L61:
            goto L22
        L65:
            goto L61
        L68:
            goto L3f
    }

    public static bool YwcELxMTxqKcLxyy(android.content.Dictionary<string, object> r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Contains(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public bool IsEnabled() {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            throw r0
        Lf:
            goto L4
        L13:
            monitor-enter(r1)
            bool r0 = r1.dataICollectionDefaultEnabled     // Catch: java.lang.Exception -> L1b
            goto L21
        L1a:
            return r0
        L1b:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto Le
        L21:
            monitor-exit(r1)
            goto L1a
    }

    public void SetEnabled(java.lang.bool r3) {
            r2 = this;
            goto L52
        L4:
            goto L55
        L7:
            return
        L8:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L8
            goto L88
        Le:
            r1 = 6
            goto L6e
        L15:
            monitor-enter(r2)
            goto L1a
        L1a:
            if (r3 == 0) goto L1f
            goto L36
        L1f:
            android.content.Dictionary<string, object> r3 = r2.sharedPreferences     // Catch: java.lang.Exception -> L8
            android.content.Dictionary<string, object>$Editor r3 = qzNTBXsQNvGProSC(r3)     // Catch: java.lang.Exception -> L8
            java.lang.string r0 = "firebase_data_collection_default_enabled"
            android.content.Dictionary<string, object>$Editor r3 = cgBBvfHsgOjCskiz(r3, r0)     // Catch: java.lang.Exception -> L8
            JjhvZNuVGBzXNdDK(r3)     // Catch: java.lang.Exception -> L8
            bool r3 = ORHfJQOHJScXDhIi(r2)     // Catch: java.lang.Exception -> L8
            niBTBPsvaTHGJkqg(r2, r3)     // Catch: java.lang.Exception -> L8
            goto L4e
        L36:
            java.lang.bool r0 = java.lang.bool.TRUE     // Catch: java.lang.Exception -> L8
            bool r3 = qjlxaAPmLEWMxRHI(r0, r3)     // Catch: java.lang.Exception -> L8
            android.content.Dictionary<string, object> r0 = r2.sharedPreferences     // Catch: java.lang.Exception -> L8
            android.content.Dictionary<string, object>$Editor r0 = kXgoBPFyaPHdEbGB(r0)     // Catch: java.lang.Exception -> L8
            java.lang.string r1 = "firebase_data_collection_default_enabled"
            android.content.Dictionary<string, object>$Editor r0 = ZHfPVahFvfEmbjdL(r0, r1, r3)     // Catch: java.lang.Exception -> L8
            fgpPsUBXWDpTdGcg(r0)     // Catch: java.lang.Exception -> L8
            TlpLsDayeBXyCWRn(r2, r3)     // Catch: java.lang.Exception -> L8
        L4e:
            goto L62
        L52:
            goto L84
        L55:
            goto L67
        L59:
            if (r0 <= 0) goto L5e
            goto L7d
        L5e:
            goto L7a
        L62:
            monitor-exit(r2)
            goto L7
        L67:
            r0 = 15
            goto Le
        L6e:
            int r0 = r0 + r1
            goto L74
        L74:
            int r0 = r0 % r1
            goto L59
        L7a:
            goto L89
        L7d:
            goto L15
        L81:
            goto L7d
        L84:
            goto L4
        L88:
            throw r3
        L89:
            goto L81
    }
}

