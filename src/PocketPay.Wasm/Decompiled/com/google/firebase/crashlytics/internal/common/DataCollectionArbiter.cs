namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class DataICollectionArbiter {
    private static readonly java.lang.string FIREBASE_CRASHLYTICS_COLLECTION_ENABLED = "firebase_crashlytics_collection_enabled";
    private java.lang.bool crashlyticsDataICollectionEnabled;
    com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> dataICollectionEnabledTask;
    private readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> dataICollectionExplicitlyApproved;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private bool setInManifest;
    private readonly android.content.Dictionary<string, object> sharedPreferences;
    private readonly java.lang.object taskLock;
    bool taskResolved;

    public DataICollectionArbiter(com.google.firebase.FirebaseApp r3) {
            r2 = this;
            goto L50
        L4:
            java.lang.object r0 = new java.lang.object
            goto La
        La:
            r0.<init>()
            goto Lb0
        L11:
            goto L53
        L14:
            r2.crashlyticsDataICollectionEnabled = r3
            goto L81
        L1a:
            int r0 = r0 + r1
            goto Lc6
        L20:
            r1.<init>()
            goto Laa
        L27:
            com.google.android.gms.tasks.TaskCompletionSource r1 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L20
        L2d:
            r0 = 11
            goto L34
        L34:
            r1 = 11
            goto L1a
        L3b:
            r2.firebaseApp = r3
            goto Ld3
        L41:
            goto L60
        L44:
            goto L11
        L48:
            java.lang.bool r3 = nDmqXGmTLlVuKZRA(r2, r1)
        L4c:
            goto L14
        L50:
            goto L44
        L53:
            goto L2d
        L57:
            com.google.android.gms.tasks.TaskCompletionSource r1 = new com.google.android.gms.tasks.TaskCompletionSource
            goto Lbf
        L5d:
            goto Ldc
        L60:
            goto Lcc
        L64:
            r2.setInManifest = r1
            goto L57
        L6a:
            java.lang.bool r3 = OclwavqHhBWQdCsC(r2)
            goto Lb6
        L72:
            r2.sharedPreferences = r3
            goto L6a
        L78:
            if (r0 <= 0) goto L7d
            goto L60
        L7d:
            goto L5d
        L81:
            monitor-enter(r0)
            bool r3 = dHyVaXdvGVsVHkJj(r2)     // Catch: java.lang.Exception -> L93
            if (r3 == 0) goto L91
            com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r3 = r2.dataICollectionEnabledTask     // Catch: java.lang.Exception -> L93
            r1 = 0
            mzPTXkYEHJssdIgq(r3, r1)     // Catch: java.lang.Exception -> L93
            r3 = 1
            r2.taskResolved = r3     // Catch: java.lang.Exception -> L93
        L91:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L93
            return
        L93:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L93
            goto Ldb
        L99:
            r2.dataICollectionExplicitlyApproved = r1
            goto Le0
        L9f:
            r2.taskResolved = r1
            goto L64
        La5:
            r1 = 0
            goto L9f
        Laa:
            r2.dataICollectionEnabledTask = r1
            goto La5
        Lb0:
            r2.taskLock = r0
            goto L27
        Lb6:
            if (r3 == 0) goto Lbb
            goto L4c
        Lbb:
            goto L48
        Lbf:
            r1.<init>()
            goto L99
        Lc6:
            int r0 = r0 % r1
            goto L78
        Lcc:
            r2.<init>()
            goto L4
        Ld3:
            android.content.Dictionary<string, object> r3 = nhsBfyHiQglMlSWC(r1)
            goto L72
        Ldb:
            throw r2
        Ldc:
            goto L41
        Le0:
            android.content.object r1 = ZLRaRYUhFwsFcDKX(r3)
            goto L3b
    }

    public static android.content.pm.PackageManager CIoOHVZoAiDTVLUR(android.content.object r1) {
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
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto Lb
    }

    public static void CIoOHVZoAiDTVLUR(android.content.object r0, byte r1, bool r2, int r3, short r4) {
            goto L1f
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto La
        L26:
            return
        L27:
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void CIoOHVZoAiDTVLUR(android.content.object r0, int r1, short r2, bool r3, byte r4) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L15
        Lc:
            r0 = 42
            goto L25
        L12:
            goto L2c
        L15:
            goto Lc
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2b:
            return
        L2c:
            goto L9
    }

    public static void CIoOHVZoAiDTVLUR(android.content.object r0, bool r1, short r2, int r3, byte r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            r0 = 42
            goto L9
        L15:
            int r2 = r0 * r1
            goto L22
        L1b:
            goto L29
        L1e:
            goto Lf
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void DRMNypoGScJMZPEA(android.content.Dictionary<string, object>.Editor r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.apply()
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

    public static void DRMNypoGScJMZPEA(android.content.Dictionary<string, object>.Editor r0, float r1, bool r2, java.lang.string r3, short r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            int r2 = r0 * r1
            goto L4
        L1d:
            goto L13
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            r0 = 42
            goto La
    }

    public static void DRMNypoGScJMZPEA(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, float r3, short r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            goto L26
        Ld:
            goto L1f
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L4
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void DRMNypoGScJMZPEA(android.content.Dictionary<string, object>.Editor r0, bool r1, short r2, java.lang.string r3, float r4) {
            goto L17
        L4:
            goto L1a
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            goto Le
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L12
    }

    public static void EEyOsyqvUGCFHeRs(com.google.firebase.FirebaseApp r0, float r1, short r2, char r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            goto L2c
        Ld:
            r0 = 42
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto L14
        L2c:
            goto Ld
    }

    public static void EEyOsyqvUGCFHeRs(com.google.firebase.FirebaseApp r0, int r1, float r2, short r3, char r4) {
            goto L1e
        L4:
            r0 = 42
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            goto Lb
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void EEyOsyqvUGCFHeRs(com.google.firebase.FirebaseApp r0, short r1, char r2, int r3, float r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            goto L17
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto Lc
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto L10
    }

    public static bool EEyOsyqvUGCFHeRs(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.isDataICollectionDefaultEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.bool FFaYEGeWQgmbgkDJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1, android.content.object r2) {
            goto L14
        L4:
            java.lang.bool r0 = r1.getDataICollectionValueFromManifest(r2)
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

    public static void FFaYEGeWQgmbgkDJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, int r2, byte r3, short r4, java.lang.string r5) {
            goto L18
        L4:
            goto L1b
        L7:
            r0 = 42
            goto L1f
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void FFaYEGeWQgmbgkDJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, java.lang.string r2, byte r3, short r4, int r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L15
        Lb:
            return
        Lc:
            goto L2d
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            r0 = 42
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L7
    }

    public static void FFaYEGeWQgmbgkDJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, java.lang.string r2, short r3, int r4, byte r5) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            return
        L17:
            goto L28
        L1b:
            goto L17
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L10
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void FKBDJLjkIfORKLfv(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.m351d(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void FKBDJLjkIfORKLfv(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, bool r3, java.lang.string r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L24
        L16:
            goto Lc
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void FKBDJLjkIfORKLfv(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, byte r3, java.lang.string r4, short r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L26
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            r0 = 42
            goto L2a
        L23:
            goto L10
        L26:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
    }

    public static void FKBDJLjkIfORKLfv(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, java.lang.string r3, byte r4, short r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto Ld
    }

    public static java.lang.string FRouIKwhLtQaUHor(java.lang.string r1, java.lang.object[] r2) {
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
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto L7
    }

    public static void FRouIKwhLtQaUHor(java.lang.string r0, java.lang.object[] r1, int r2, short r3, byte r4, java.lang.string r5) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1b
        L10:
            r0 = 42
            goto L4
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L10
        L2d:
            goto L29
    }

    public static void FRouIKwhLtQaUHor(java.lang.string r0, java.lang.object[] r1, java.lang.string r2, int r3, short r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L21
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r0 = 42
            goto L10
        L27:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void FRouIKwhLtQaUHor(java.lang.string r0, java.lang.object[] r1, short r2, int r3, byte r4, java.lang.string r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L4
        L18:
            int r2 = r0 * r1
            goto L23
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Lb
        L2c:
            goto L12
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GCnQBPxbPDKzFrgY() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void GCnQBPxbPDKzFrgY(char r0, byte r1, float r2, short r3) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L19
        L13:
            r0 = 42
            goto L23
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L1f
        L2c:
            goto L13
    }

    public static void GCnQBPxbPDKzFrgY(char r0, float r1, short r2, byte r3) {
            goto L1a
        L4:
            r0 = 42
            goto L14
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1a:
            goto Lb
        L1d:
            goto L4
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L1d
    }

    public static void GCnQBPxbPDKzFrgY(float r0, byte r1, char r2, short r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r3 = r2 + r1
            goto L19
        L16:
            goto L7
        L19:
            double r0 = (double) r3
            goto Lb
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void HaDJOBfTMAxspikn(android.os.Dictionary<string, object> r0, java.lang.string r1, byte r2, short r3, float r4, int r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            r0 = 42
            goto L24
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto L7
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static void HaDJOBfTMAxspikn(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2, short r3, float r4, byte r5) {
            goto La
        L4:
            r0 = 42
            goto L1d
        La:
            goto L27
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L23:
            goto Ld
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void HaDJOBfTMAxspikn(android.os.Dictionary<string, object> r0, java.lang.string r1, short r2, float r3, int r4, byte r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L21
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L24
        L1a:
            goto La
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static bool HaDJOBfTMAxspikn(android.os.Dictionary<string, object> r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.ContainsKey(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.gms.tasks.Task IFuoostOpLmbNjQm(com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L4
    }

    public static void IFuoostOpLmbNjQm(com.google.android.gms.tasks.TaskCompletionSource r0, float r1, bool r2, java.lang.string r3, char r4) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            r0 = 42
            goto L14
        L20:
            goto Lb
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void IFuoostOpLmbNjQm(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.string r1, char r2, float r3, bool r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            goto L2c
        Ld:
            r0 = 42
            goto L4
        L13:
            int r3 = r2 + r1
            goto L24
        L19:
            return
        L1a:
            goto La
        L1e:
            int r2 = r0 * r1
            goto L13
        L24:
            double r0 = (double) r3
            goto L19
        L29:
            goto L1a
        L2c:
            goto Ld
    }

    public static void IFuoostOpLmbNjQm(com.google.android.gms.tasks.TaskCompletionSource r0, bool r1, float r2, char r3, java.lang.string r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto Lf
        L20:
            r0 = 42
            goto L9
        L26:
            goto L5
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static android.content.Dictionary<string, object>.Editor ILYFYggIeeHjWATR(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void ILYFYggIeeHjWATR(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, float r2, int r3, java.lang.string r4, bool r5) {
            goto L1e
        L4:
            return
        L5:
            goto L1b
        L9:
            r0 = 42
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L21
        L1e:
            goto L5
        L21:
            goto L9
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void ILYFYggIeeHjWATR(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, float r2, java.lang.string r3, bool r4, int r5) {
            goto L12
        L4:
            goto L15
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            goto L20
        L15:
            goto L19
        L19:
            r0 = 42
            goto L7
        L1f:
            return
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void ILYFYggIeeHjWATR(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, int r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L26
        L15:
            int r3 = r2 + r1
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            double r0 = (double) r3
            goto L10
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void JyFUkuGkAKUbZIvV(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, byte r2, int r3, short r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto L13
        Le:
            double r0 = (double) r3
            goto L25
        L13:
            r0 = 42
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Le
    }

    public static void JyFUkuGkAKUbZIvV(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, byte r2, short r3, int r4, char r5) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L26
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            goto L13
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            return
        L26:
            goto L1c
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void JyFUkuGkAKUbZIvV(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, char r2, int r3, short r4, byte r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L18
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            r0 = 42
            goto Lf
        L29:
            goto L19
        L2c:
            goto L23
    }

    public static bool JyFUkuGkAKUbZIvV(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.tryHashSetResult(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static com.google.android.gms.tasks.Task MlYaXnmmhJoJmvMW(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.waitForAutomaticDataICollectionEnabled()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void MlYaXnmmhJoJmvMW(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, int r1, short r2, char r3, bool r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L23
        L13:
            r0 = 42
            goto L7
        L19:
            return
        L1a:
            goto L4
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L1a
        L2c:
            goto L13
    }

    public static void MlYaXnmmhJoJmvMW(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, int r2, short r3, char r4) {
            goto Le
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L2a
        L15:
            int r3 = r2 + r1
            goto L9
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto L11
        L24:
            int r2 = r0 * r1
            goto L15
        L2a:
            r0 = 42
            goto L1b
    }

    public static void MlYaXnmmhJoJmvMW(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, short r2, char r3, int r4) {
            goto L1a
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L24
        L10:
            return
        L11:
            goto L21
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto L4
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static java.lang.bool OclwavqHhBWQdCsC(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.bool r0 = r1.getDataICollectionValueFromDictionary<string, object>()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void OclwavqHhBWQdCsC(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, java.lang.string r1, byte r2, bool r3, float r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L21
        L19:
            return
        L1a:
            goto L16
        L1e:
            goto L1a
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r0 = 42
            goto L10
    }

    public static void OclwavqHhBWQdCsC(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, java.lang.string r1, bool r2, float r3, byte r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            goto L1c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            r0 = 42
            goto Ld
        L19:
            goto L27
        L1c:
            goto L13
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void OclwavqHhBWQdCsC(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, byte r2, java.lang.string r3, float r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L1b
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L10
        L2d:
            goto L29
    }

    public static void PMUAllSyMOVGazSF(java.lang.bool r0, byte r1, java.lang.string r2, float r3, bool r4) {
            goto L4
        L4:
            goto L27
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L11:
            r0 = 42
            goto Lb
        L17:
            int r2 = r0 * r1
            goto L20
        L1d:
            goto L7
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void PMUAllSyMOVGazSF(java.lang.bool r0, bool r1, byte r2, float r3, java.lang.string r4) {
            goto L11
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L14
        L11:
            goto La
        L14:
            goto L2a
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            r0 = 42
            goto L24
    }

    public static void PMUAllSyMOVGazSF(java.lang.bool r0, bool r1, byte r2, java.lang.string r3, float r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            r0 = 42
            goto L18
        Lf:
            goto L2c
        L12:
            int r2 = r0 * r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L9
    }

    public static bool PMUAllSyMOVGazSF(java.lang.bool r1) {
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
            bool r0 = r1.boolValue()
            goto L7
    }

    public static android.content.Dictionary<string, object>.Editor PPHHfoUbdHzGYjEu(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, bool r3) {
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
            android.content.Dictionary<string, object>$Editor r0 = r1.putbool(r2, r3)
            goto L4
    }

    public static void PPHHfoUbdHzGYjEu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, char r3, float r4, bool r5, short r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L1b
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            return
        L1b:
            goto L11
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L14
    }

    public static void PPHHfoUbdHzGYjEu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, short r3, bool r4, float r5, char r6) {
            goto L21
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L28
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L5
        L24:
            goto L1b
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L24
    }

    public static void PPHHfoUbdHzGYjEu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, bool r3, char r4, short r5, float r6) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L21
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L10
        L2a:
            r0 = 42
            goto L13
    }

    public static java.lang.bool PWunahPVPJwyUHob(bool r1) {
            goto L14
        L4:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

    public static void PWunahPVPJwyUHob(bool r0, char r1, java.lang.string r2, float r3, bool r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L23
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L23:
            int r3 = r2 + r1
            goto L7
        L29:
            goto Ld
        L2c:
            goto L17
    }

    public static void PWunahPVPJwyUHob(bool r0, float r1, char r2, bool r3, java.lang.string r4) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L1a
        L10:
            goto L26
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            return
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void PWunahPVPJwyUHob(bool r0, java.lang.string r1, float r2, bool r3, char r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto L15
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto Lf
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void RoPxktUAxYkPFcyn(android.content.Dictionary<string, object> r0, java.lang.bool r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            storeDataICollectionValueInDictionary<string, object>(r0, r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void RoPxktUAxYkPFcyn(android.content.Dictionary<string, object> r0, java.lang.bool r1, short r2, char r3, bool r4, float r5) {
            goto L19
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L20
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L1c
        L19:
            goto L27
        L1c:
            goto La
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L26:
            return
        L27:
            goto L16
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void RoPxktUAxYkPFcyn(android.content.Dictionary<string, object> r0, java.lang.bool r1, short r2, float r3, char r4, bool r5) {
            goto L1e
        L4:
            return
        L5:
            goto L9
        L9:
            goto L21
        Lc:
            r0 = 42
            goto L2a
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L5
        L21:
            goto Lc
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void RoPxktUAxYkPFcyn(android.content.Dictionary<string, object> r0, java.lang.bool r1, short r2, bool r3, char r4, float r5) {
            goto L29
        L4:
            return
        L5:
            goto L15
        L9:
            int r2 = r0 * r1
            goto L1d
        Lf:
            r0 = 42
            goto L23
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L29:
            goto L5
        L2c:
            goto Lf
    }

    public static java.lang.bool SajnTnzucQclDmKB(bool r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

    public static void SajnTnzucQclDmKB(bool r0, int r1, java.lang.string r2, bool r3, float r4) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L19
        L16:
            goto L12
        L19:
            r0 = 42
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void SajnTnzucQclDmKB(bool r0, java.lang.string r1, int r2, bool r3, float r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L9
        L29:
            goto L1c
        L2c:
            goto L23
    }

    public static void SajnTnzucQclDmKB(bool r0, bool r1, float r2, java.lang.string r3, int r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L27
        L14:
            int r2 = r0 * r1
            goto L9
        L1a:
            goto L10
        L1d:
            goto L2a
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L27:
            goto L1d
        L2a:
            r0 = 42
            goto L21
    }

    public static android.content.pm.ApplicationInfo ULFOgTPQlmsgRcoO(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
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

    public static void ULFOgTPQlmsgRcoO(android.content.pm.PackageManager r0, java.lang.string r1, int r2, byte r3, float r4, bool r5, java.lang.string r6) {
            goto L1d
        L4:
            return
        L5:
            goto L1a
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L20
        L1d:
            goto L5
        L20:
            goto L9
        L24:
            int r3 = r2 + r1
            goto L15
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void ULFOgTPQlmsgRcoO(android.content.pm.PackageManager r0, java.lang.string r1, int r2, float r3, bool r4, java.lang.string r5, byte r6) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            goto L1e
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r2 = r0 * r1
            goto L25
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto Ld
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void ULFOgTPQlmsgRcoO(android.content.pm.PackageManager r0, java.lang.string r1, int r2, java.lang.string r3, byte r4, bool r5, float r6) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L20
        Ld:
            int r3 = r2 + r1
            goto L18
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L24
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void VMOAILxkmzbHSeJK(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, char r2, int r3, short r4, byte r5) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto Le
        L26:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void VMOAILxkmzbHSeJK(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, int r2, char r3, short r4, byte r5) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            goto Le
        L1b:
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2a:
            r0 = 42
            goto L24
    }

    public static void VMOAILxkmzbHSeJK(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, int r2, short r3, byte r4, char r5) {
            goto Ld
        L4:
            r0 = 42
            goto L25
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L4
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto La
    }

    public static bool VMOAILxkmzbHSeJK(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.tryHashSetResult(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void VYIxrWhErdLJrtfD(java.lang.bool r0, java.lang.object r1, int r2, float r3, byte r4, short r5) {
            goto L1d
        L4:
            return
        L5:
            goto Le
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L20
        L11:
            int r3 = r2 + r1
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void VYIxrWhErdLJrtfD(java.lang.bool r0, java.lang.object r1, short r2, float r3, int r4, byte r5) {
            goto L14
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L24
        L21:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void VYIxrWhErdLJrtfD(java.lang.bool r0, java.lang.object r1, short r2, int r3, float r4, byte r5) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L20
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto L13
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r2 = r0 * r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static bool VYIxrWhErdLJrtfD(java.lang.bool r1, java.lang.object r2) {
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

    public static void WuLslsLRzPdKOmJS(java.lang.bool r0, float r1, char r2, bool r3, int r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            goto L2c
        Ld:
            goto L25
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L4
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto Ld
        L25:
            r0 = 42
            goto L11
        L2b:
            return
        L2c:
            goto L22
    }

    public static void WuLslsLRzPdKOmJS(java.lang.bool r0, float r1, bool r2, char r3, int r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L1e
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L22
        L1d:
            return
        L1e:
            goto L28
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void WuLslsLRzPdKOmJS(java.lang.bool r0, int r1, float r2, bool r3, char r4) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L1a
        L12:
            return
        L13:
            goto Lf
        L17:
            goto L13
        L1a:
            goto L24
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static bool WuLslsLRzPdKOmJS(java.lang.bool r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.boolValue()
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

    public static java.lang.string YYzdUavhAVckRiaj(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getPackageName()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void YYzdUavhAVckRiaj(android.content.object r0, char r1, float r2, byte r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L25
        Le:
            return
        Lf:
            goto L4
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto Le
    }

    public static void YYzdUavhAVckRiaj(android.content.object r0, float r1, char r2, byte r3, int r4) {
            goto Lf
        L4:
            return
        L5:
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void YYzdUavhAVckRiaj(android.content.object r0, int r1, byte r2, float r3, char r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L21
        L1a:
            goto La
        L1d:
            goto L14
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static android.content.object ZLRaRYUhFwsFcDKX(com.google.firebase.FirebaseApp r1) {
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
            android.content.object r0 = r1.getApplicationobject()
            goto L4
    }

    public static void ZLRaRYUhFwsFcDKX(com.google.firebase.FirebaseApp r0, int r1, float r2, short r3, char r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L21
        Ld:
            goto L17
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            r0 = 42
            goto L25
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void ZLRaRYUhFwsFcDKX(com.google.firebase.FirebaseApp r0, short r1, float r2, int r3, char r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L1e
        Ld:
            int r3 = r2 + r1
            goto L24
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            double r0 = (double) r3
            goto L13
        L29:
            goto L14
        L2c:
            goto L7
    }

    public static void ZLRaRYUhFwsFcDKX(com.google.firebase.FirebaseApp r0, short r1, int r2, float r3, char r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L21
        Ld:
            int r2 = r0 * r1
            goto L18
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor ZSSUVzicGuaqiIXt(android.content.Dictionary<string, object> r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void ZSSUVzicGuaqiIXt(android.content.Dictionary<string, object> r0, byte r1, java.lang.string r2, bool r3, short r4) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r0 = 42
            goto L2a
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto Lc
        L23:
            goto L5
        L26:
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
    }

    public static void ZSSUVzicGuaqiIXt(android.content.Dictionary<string, object> r0, byte r1, bool r2, java.lang.string r3, short r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L18
        L10:
            goto L20
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void ZSSUVzicGuaqiIXt(android.content.Dictionary<string, object> r0, bool r1, byte r2, short r3, java.lang.string r4) {
            goto L18
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L10:
            goto L1b
        L13:
            return
        L14:
            goto L10
        L18:
            goto L14
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static java.lang.bool ZqygABNphTHSdlUF(android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.bool r0 = readCrashlyticsDataICollectionEnabledFromManifest(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void ZqygABNphTHSdlUF(android.content.object r0, float r1, int r2, java.lang.string r3, bool r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L12
        Ld:
            goto L1e
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            double r0 = (double) r3
            goto L11
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void ZqygABNphTHSdlUF(android.content.object r0, float r1, java.lang.string r2, int r3, bool r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L1b
        L13:
            goto L1f
        L17:
            goto L13
        L1a:
            return
        L1b:
            goto L17
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void ZqygABNphTHSdlUF(android.content.object r0, bool r1, int r2, java.lang.string r3, float r4) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L1f
        L18:
            goto Le
        L1b:
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            r0 = 42
            goto L24
    }

    public static com.google.android.gms.tasks.Task BohobtvbsPSYwdti(com.google.android.gms.tasks.Task r1, com.google.android.gms.tasks.Task r2) {
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
            com.google.android.gms.tasks.Task r0 = com.google.firebase.crashlytics.internal.concurrency.CrashlyticsTasks.race(r1, r2)
            goto Le
    }

    public static void BohobtvbsPSYwdti(com.google.android.gms.tasks.Task r0, com.google.android.gms.tasks.Task r1, byte r2, short r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            double r0 = (double) r3
            goto L7
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto Lc
        L23:
            r0 = 42
            goto L11
        L29:
            goto L8
        L2c:
            goto L23
    }

    public static void BohobtvbsPSYwdti(com.google.android.gms.tasks.Task r0, com.google.android.gms.tasks.Task r1, char r2, short r3, byte r4, java.lang.string r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L13
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            int r3 = r2 + r1
            goto Le
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void BohobtvbsPSYwdti(com.google.android.gms.tasks.Task r0, com.google.android.gms.tasks.Task r1, short r2, java.lang.string r3, byte r4, char r5) {
            goto L23
        L4:
            return
        L5:
            goto L20
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            goto L26
        L23:
            goto L5
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void DDMbnGOlsgVEWzpj(android.content.Dictionary<string, object> r0, java.lang.string r1, int r2, byte r3, java.lang.string r4, short r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void DDMbnGOlsgVEWzpj(android.content.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2, int r3, short r4, byte r5) {
            goto L14
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L2a
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L21:
            goto L17
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r0 = 42
            goto L1b
    }

    public static void DDMbnGOlsgVEWzpj(android.content.Dictionary<string, object> r0, java.lang.string r1, short r2, int r3, byte r4, java.lang.string r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            r0 = 42
            goto L19
        L25:
            int r2 = r0 * r1
            goto L13
        L2b:
            double r0 = (double) r3
            goto Le
    }

    public static bool DDMbnGOlsgVEWzpj(android.content.Dictionary<string, object> r1, java.lang.string r2) {
            goto Lc
        L4:
            bool r0 = r1.Contains(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void DHyVaXdvGVsVHkJj(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, byte r1, char r2, java.lang.string r3, float r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L27
        L15:
            r0 = 42
            goto L2a
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L11
        L23:
            goto L15
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void DHyVaXdvGVsVHkJj(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, byte r1, float r2, char r3, java.lang.string r4) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto L19
        Lf:
            goto L15
        L12:
            goto L1a
        L15:
            goto L2a
        L19:
            return
        L1a:
            goto Lf
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r0 = 42
            goto L1e
    }

    public static void DHyVaXdvGVsVHkJj(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, char r1, float r2, byte r3, java.lang.string r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static bool DHyVaXdvGVsVHkJj(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1) {
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
            bool r0 = r1.isAutomaticDataICollectionEnabled()
            goto Lb
    }

    public static java.lang.bool ECdhREzJrSlySBNF(bool r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ECdhREzJrSlySBNF(bool r0, byte r1, bool r2, short r3, java.lang.string r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L20
        L18:
            return
        L19:
            goto L15
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2a:
            r0 = 42
            goto L24
    }

    public static void ECdhREzJrSlySBNF(bool r0, java.lang.string r1, short r2, byte r3, bool r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L17
        L12:
            goto L24
        L16:
            return
        L17:
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L21:
            goto L12
        L24:
            r0 = 42
            goto L1b
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void ECdhREzJrSlySBNF(bool r0, java.lang.string r1, short r2, bool r3, byte r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r0 = 42
            goto La
        L2d:
            goto L1d
    }

    public static android.content.object FJAquwVsVxVApYFX(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.object r0 = r1.getApplicationobject()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FJAquwVsVxVApYFX(com.google.firebase.FirebaseApp r0, char r1, float r2, java.lang.string r3, byte r4) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            goto L8
        L20:
            goto L24
        L24:
            r0 = 42
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static void FJAquwVsVxVApYFX(com.google.firebase.FirebaseApp r0, char r1, java.lang.string r2, byte r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L17
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L26
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L23:
            goto L7
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void FJAquwVsVxVApYFX(com.google.firebase.FirebaseApp r0, java.lang.string r1, byte r2, char r3, float r4) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void FOuDZzkHKoAnMjHu(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.m354e(r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void FOuDZzkHKoAnMjHu(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, short r3, java.lang.string r4, float r5, bool r6) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            r0 = 42
            goto L4
        L1e:
            return
        L1f:
            goto Lf
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void FOuDZzkHKoAnMjHu(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, short r3, bool r4, java.lang.string r5, float r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            goto L7
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void FOuDZzkHKoAnMjHu(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, bool r3, short r4, java.lang.string r5, float r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L1b
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            return
        L1b:
            goto L11
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L14
    }

    private java.lang.bool GetDataICollectionValueFromManifest(android.content.object r2) {
            r1 = this;
            goto L49
        L4:
            java.lang.bool r1 = eCdhREzJrSlySBNF(r1)
            goto L50
        Lc:
            return r1
        Ld:
            goto L55
        L11:
            if (r2 == 0) goto L16
            goto Ld
        L16:
            goto L20
        L1a:
            r1.setInManifest = r2
            goto L39
        L20:
            r2 = 0
            goto L1a
        L25:
            r1.setInManifest = r0
            goto L2b
        L2b:
            java.lang.bool r1 = java.lang.bool.TRUE
            goto L31
        L31:
            bool r1 = VYIxrWhErdLJrtfD(r1, r2)
            goto L4
        L39:
            r1 = 0
            goto Lc
        L3e:
            java.lang.bool r2 = ZqygABNphTHSdlUF(r2)
            goto L11
        L46:
            goto L4c
        L49:
            goto L51
        L4c:
            goto L3e
        L50:
            return r1
        L51:
            goto L46
        L55:
            r0 = 1
            goto L25
    }

    private void GetDataICollectionValueFromManifest(android.content.object r1, byte r2, float r3, short r4, char r5) {
            r0 = this;
            goto L1a
        L4:
            return
        L5:
            goto L27
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L21
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    private void GetDataICollectionValueFromManifest(android.content.object r1, float r2, char r3, short r4, byte r5) {
            r0 = this;
            goto L4
        L4:
            goto L23
        L7:
            goto L27
        Lb:
            int r2 = r0 * r1
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L11
        L2d:
            goto L7
    }

    private void GetDataICollectionValueFromManifest(android.content.object r1, short r2, char r3, float r4, byte r5) {
            r0 = this;
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L21
        Ld:
            goto L25
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            r0 = 42
            goto L17
        L2b:
            double r0 = (double) r3
            goto L20
    }

    private java.lang.bool getDataICollectionValueFromDictionary<string, object>() {
            r2 = this;
            goto L25
        L4:
            java.lang.bool r2 = PWunahPVPJwyUHob(r2)
            goto L78
        Lc:
            r0 = 0
            goto L60
        L11:
            int r0 = r0 + r1
            goto L2c
        L17:
            goto L28
        L1a:
            return r2
        L1b:
            goto L6b
        L1f:
            android.content.Dictionary<string, object> r0 = r2.sharedPreferences
            goto L86
        L25:
            goto L6e
        L28:
            goto L41
        L2c:
            int r0 = r0 % r1
            goto L57
        L32:
            bool r2 = zoTDVYnopycGiWFZ(r2, r1, r0)
            goto L4
        L3a:
            goto L1b
        L3d:
            goto L1f
        L41:
            r0 = 25
            goto L48
        L48:
            r1 = 3
            goto L11
        L4f:
            bool r0 = dDMbnGOlsgVEWzpj(r0, r1)
            goto L7d
        L57:
            if (r0 <= 0) goto L5c
            goto L3d
        L5c:
            goto L3a
        L60:
            r2.setInManifest = r0
            goto L72
        L66:
            r0 = 1
            goto L32
        L6b:
            goto L3d
        L6e:
            goto L17
        L72:
            android.content.Dictionary<string, object> r2 = r2.sharedPreferences
            goto L66
        L78:
            return r2
        L79:
            goto L8c
        L7d:
            if (r0 != 0) goto L82
            goto L79
        L82:
            goto Lc
        L86:
            java.lang.string r1 = "firebase_crashlytics_collection_enabled"
            goto L4f
        L8c:
            r2 = 0
            goto L1a
    }

    private void getDataICollectionValueFromDictionary<string, object>(byte r1, int r2, float r3, char r4) {
            r0 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L21
        L15:
            int r2 = r0 * r1
            goto L24
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto Lb
        L2a:
            r0 = 42
            goto L1b
    }

    private void getDataICollectionValueFromDictionary<string, object>(char r1, float r2, byte r3, int r4) {
            r0 = this;
            goto L1e
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L1b
        L2a:
            r0 = 42
            goto L15
    }

    private void getDataICollectionValueFromDictionary<string, object>(int r1, float r2, char r3, byte r4) {
            r0 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L1a
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1a:
            r0 = 42
            goto L14
        L20:
            return
        L21:
            goto L11
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    private void IsFirebaseDataICollectionDefaultEnabled(byte r1, int r2, char r3, short r4) {
            r0 = this;
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto Lf
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    private void IsFirebaseDataICollectionDefaultEnabled(char r1, byte r2, int r3, short r4) {
            r0 = this;
            goto L4
        L4:
            goto L1e
        L7:
            goto L17
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L22
        L17:
            r0 = 42
            goto Lb
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L7
    }

    private void IsFirebaseDataICollectionDefaultEnabled(int r1, byte r2, short r3, char r4) {
            r0 = this;
            goto L12
        L4:
            r0 = 42
            goto L2a
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            goto L20
        L15:
            goto L4
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    private bool IsFirebaseDataICollectionDefaultEnabled() {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            r0 = 0
            goto L19
        Lc:
            goto L1a
        Lf:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp     // Catch: java.lang.IllegalStateException -> L1f
            bool r0 = EEyOsyqvUGCFHeRs(r0)     // Catch: java.lang.IllegalStateException -> L1f
            goto L1e
        L19:
            return r0
        L1a:
            goto L4
        L1e:
            return r0
        L1f:
            goto L7
    }

    public static void KlYticpfTqhBJoan(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, byte r1, float r2, bool r3, char r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r0 = 42
            goto L20
        L1b:
            return
        L1c:
            goto L2d
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L26:
            goto L1c
        L29:
            goto L15
        L2d:
            goto L29
    }

    public static void KlYticpfTqhBJoan(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, char r1, bool r2, float r3, byte r4) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            goto L27
        L1e:
            r0 = 42
            goto Lf
        L24:
            goto L2c
        L27:
            goto L1e
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void KlYticpfTqhBJoan(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, byte r2, float r3, char r4) {
            goto L29
        L4:
            return
        L5:
            goto L1a
        L9:
            int r3 = r2 + r1
            goto L15
        Lf:
            r0 = 42
            goto L1d
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L2c
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L9
        L29:
            goto L5
        L2c:
            goto Lf
    }

    public static bool KlYticpfTqhBJoan(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1) {
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
            bool r0 = r1.isAutomaticDataICollectionEnabled()
            goto L4
    }

    private void LogDataICollectionState(bool r3) {
            r2 = this;
            goto L3e
        L4:
            goto L34
        L5:
            goto L32
        L9:
            java.lang.string r2 = FRouIKwhLtQaUHor(r1, r2)
            goto Lb6
        L11:
            java.lang.string r2 = "global Firebase setting"
            goto L65
        L17:
            r1 = 2
            goto La9
        L1e:
            if (r0 == 0) goto L23
            goto L66
        L23:
            goto L11
        L27:
            return
        L28:
            goto Laf
        L2c:
            java.lang.string r2 = "firebase_crashlytics_collection_enabled manifest flag"
            goto L60
        L32:
            java.lang.string r3 = "DISABLED"
        L34:
            goto L93
        L38:
            java.lang.string r2 = "API"
        L3a:
            goto L83
        L3e:
            goto Lb2
        L41:
            goto L6a
        L45:
            java.lang.string r1 = "Crashlytics automatic data collection %s by %s."
            goto L8b
        L4b:
            int r0 = r0 % r1
            goto L7a
        L51:
            java.lang.string r3 = "ENABLED"
            goto L4
        L57:
            if (r3 != 0) goto L5c
            goto L5
        L5c:
            goto L51
        L60:
            goto L3a
        L61:
            goto L38
        L65:
            goto L3a
        L66:
            goto L9c
        L6a:
            r0 = 7
            goto L17
        L71:
            if (r2 != 0) goto L76
            goto L61
        L76:
            goto L2c
        L7a:
            if (r0 <= 0) goto L7f
            goto La5
        L7f:
            goto La2
        L83:
            com.google.firebase.crashlytics.internal.Consoleger r0 = GCnQBPxbPDKzFrgY()
            goto L45
        L8b:
            java.lang.object[] r2 = new java.lang.object[]{r3, r2}
            goto L9
        L93:
            java.lang.bool r0 = r2.crashlyticsDataICollectionEnabled
            goto L1e
        L99:
            goto L41
        L9c:
            bool r2 = r2.setInManifest
            goto L71
        La2:
            goto L28
        La5:
            goto L57
        La9:
            int r0 = r0 + r1
            goto L4b
        Laf:
            goto La5
        Lb2:
            goto L99
        Lb6:
            FKBDJLjkIfORKLfv(r0, r2)
            goto L27
    }

    private void LogDataICollectionState(bool r1, byte r2, java.lang.string r3, short r4, bool r5) {
            r0 = this;
            goto L1b
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L22
        L1b:
            goto L29
        L1e:
            goto L4
        L22:
            int r3 = r2 + r1
            goto La
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    private void LogDataICollectionState(bool r1, java.lang.string r2, byte r3, bool r4, short r5) {
            r0 = this;
            goto Lc
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto Lf
        Lc:
            goto L26
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L2a
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    private void LogDataICollectionState(bool r1, bool r2, short r3, byte r4, java.lang.string r5) {
            r0 = this;
            goto L4
        L4:
            goto L2c
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L23
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            r0 = 42
            goto L11
        L1d:
            int r2 = r0 * r1
            goto Lb
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static void MzPTXkYEHJssdIgq(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, byte r2, char r3, float r4, int r5) {
            goto L1e
        L4:
            goto L21
        L7:
            double r0 = (double) r3
            goto L25
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L7
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L18
    }

    public static void MzPTXkYEHJssdIgq(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, char r2, byte r3, float r4, int r5) {
            goto L4
        L4:
            goto L23
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            r0 = 42
            goto Lb
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static void MzPTXkYEHJssdIgq(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, float r2, int r3, char r4, byte r5) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L10
        L2a:
            r0 = 42
            goto La
    }

    public static bool MzPTXkYEHJssdIgq(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.tryHashSetResult(r2)
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

    public static java.lang.bool NDmqXGmTLlVuKZRA(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1, android.content.object r2) {
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
            java.lang.bool r0 = r1.getDataICollectionValueFromManifest(r2)
            goto Le
    }

    public static void NDmqXGmTLlVuKZRA(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, java.lang.string r2, byte r3, short r4, bool r5) {
            goto La
        L4:
            r0 = 42
            goto L25
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L11
        L22:
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2b:
            return
        L2c:
            goto L22
    }

    public static void NDmqXGmTLlVuKZRA(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, short r2, byte r3, bool r4, java.lang.string r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L2a
        L10:
            return
        L11:
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1b:
            goto Lc
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L15
    }

    public static void NDmqXGmTLlVuKZRA(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, android.content.object r1, short r2, bool r3, byte r4, java.lang.string r5) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            goto L8
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lc
    }

    public static android.content.Dictionary<string, object> NhsBfyHiQglMlSWC(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.Dictionary<string, object> r0 = com.google.firebase.crashlytics.internal.common.CommonUtils.getSharedPrefs(r1)
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

    public static void NhsBfyHiQglMlSWC(android.content.object r0, byte r1, java.lang.string r2, char r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto Lf
    }

    public static void NhsBfyHiQglMlSWC(android.content.object r0, int r1, char r2, java.lang.string r3, byte r4) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            r0 = 42
            goto L24
        L1d:
            goto L5
        L20:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void NhsBfyHiQglMlSWC(android.content.object r0, int r1, java.lang.string r2, byte r3, char r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L20
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L26
        L23:
            goto L10
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1a
    }

    public static com.google.firebase.crashlytics.internal.Consoleger OFIYxAEgwjlcaEkM() {
            goto Lf
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void OFIYxAEgwjlcaEkM(byte r0, java.lang.string r1, float r2, char r3) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L2c
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L1f
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L17
    }

    public static void OFIYxAEgwjlcaEkM(char r0, java.lang.string r1, float r2, byte r3) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            return
        L11:
            goto L27
        L15:
            goto L11
        L18:
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L10
        L27:
            goto L18
        L2a:
            r0 = 42
            goto La
    }

    public static void OFIYxAEgwjlcaEkM(java.lang.string r0, float r1, byte r2, char r3) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            r0 = 42
            goto L23
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            return
        L1f:
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L29:
            goto L1f
        L2c:
            goto L12
    }

    private static java.lang.bool ReadCrashlyticsDataICollectionEnabledFromManifest(android.content.object r3) {
            goto L7b
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = oFIYxAEgwjlcaEkM()
            goto L44
        Lc:
            java.lang.string r0 = "firebase_crashlytics_collection_enabled"
            android.content.pm.PackageManager r1 = CIoOHVZoAiDTVLUR(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            if (r1 == 0) goto L5b
            java.lang.string r3 = YYzdUavhAVckRiaj(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            r2 = 128(0x80, float:1.8E-43)
            android.content.pm.ApplicationInfo r3 = ULFOgTPQlmsgRcoO(r1, r3, r2)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            if (r3 == 0) goto L5b
            android.os.Dictionary<string, object> r1 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            if (r1 == 0) goto L5b
            android.os.Dictionary<string, object> r1 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            bool r1 = HaDJOBfTMAxspikn(r1, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            if (r1 == 0) goto L5b
            android.os.Dictionary<string, object> r3 = r3.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            bool r3 = xesAdIpBCSjSDfzR(r3, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            java.lang.bool r3 = SajnTnzucQclDmKB(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L76
            goto L75
        L3a:
            r3 = 0
            goto L3f
        L3f:
            return r3
        L40:
            goto L68
        L44:
            java.lang.string r1 = "Could not read data collection permission from manifest"
            goto L58
        L4a:
            r1 = 6
            goto L6f
        L51:
            goto L40
        L54:
            goto Lc
        L58:
            fOuDZzkHKoAnMjHu(r0, r1, r3)
        L5b:
            goto L3a
        L5f:
            if (r0 <= 0) goto L64
            goto L54
        L64:
            goto L51
        L68:
            goto L54
        L6b:
            goto L8f
        L6f:
            int r0 = r0 + r1
            goto L82
        L75:
            return r3
        L76:
            r3 = move-exception
            goto L4
        L7b:
            goto L6b
        L7e:
            goto L88
        L82:
            int r0 = r0 % r1
            goto L5f
        L88:
            r0 = 10
            goto L4a
        L8f:
            goto L7e
    }

    private static void ReadCrashlyticsDataICollectionEnabledFromManifest(android.content.object r0, byte r1, short r2, int r3, bool r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L18
        L13:
            goto L25
        L17:
            return
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            goto L13
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L17
    }

    private static void ReadCrashlyticsDataICollectionEnabledFromManifest(android.content.object r0, int r1, byte r2, short r3, bool r4) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L1b
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r0 = 42
            goto L27
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto L12
    }

    private static void ReadCrashlyticsDataICollectionEnabledFromManifest(android.content.object r0, int r1, bool r2, short r3, byte r4) {
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            r0 = 42
            goto L7
        L18:
            int r3 = r2 + r1
            goto Ld
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    private static void storeDataICollectionValueInDictionary<string, object>(android.content.Dictionary<string, object> r1, java.lang.bool r2) {
            goto L9
        L4:
            goto L23
        L5:
            goto L20
        L9:
            goto L30
        Lc:
            goto L27
        L10:
            DRMNypoGScJMZPEA(r1)
            goto L2f
        L17:
            if (r2 != 0) goto L1c
            goto L5
        L1c:
            goto L44
        L20:
            ILYFYggIeeHjWATR(r1, r0)
        L23:
            goto L10
        L27:
            android.content.Dictionary<string, object>$Editor r1 = ZSSUVzicGuaqiIXt(r1)
            goto L3e
        L2f:
            return
        L30:
            goto L3b
        L34:
            PPHHfoUbdHzGYjEu(r1, r0, r2)
            goto L4
        L3b:
            goto Lc
        L3e:
            java.lang.string r0 = "firebase_crashlytics_collection_enabled"
            goto L17
        L44:
            bool r2 = PMUAllSyMOVGazSF(r2)
            goto L34
    }

    private static void storeDataICollectionValueInDictionary<string, object>(android.content.Dictionary<string, object> r0, java.lang.bool r1, byte r2, float r3, short r4, int r5) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            goto L1a
        L17:
            goto La
        L1a:
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto Le
    }

    private static void storeDataICollectionValueInDictionary<string, object>(android.content.Dictionary<string, object> r0, java.lang.bool r1, byte r2, short r3, float r4, int r5) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            r0 = 42
            goto L10
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto Lc
    }

    private static void storeDataICollectionValueInDictionary<string, object>(android.content.Dictionary<string, object> r0, java.lang.bool r1, int r2, short r3, byte r4, float r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            r0 = 42
            goto L21
        L15:
            goto Lb
        L18:
            goto Lf
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static com.google.android.gms.tasks.Task SxLaxLufJjleMIIx(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void SxLaxLufJjleMIIx(com.google.android.gms.tasks.TaskCompletionSource r0, char r1, bool r2, java.lang.string r3, byte r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            r0 = 42
            goto La
        L16:
            return
        L17:
            goto L27
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L17
        L23:
            goto L10
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void SxLaxLufJjleMIIx(com.google.android.gms.tasks.TaskCompletionSource r0, bool r1, byte r2, char r3, java.lang.string r4) {
            goto L12
        L4:
            r0 = 42
            goto L1f
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            goto L15
        L12:
            goto L26
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto La
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void SxLaxLufJjleMIIx(com.google.android.gms.tasks.TaskCompletionSource r0, bool r1, byte r2, java.lang.string r3, char r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L13
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r0 = 42
            goto La
    }

    public static void VKafUhoWhYnYZDmE(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1) {
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
            r0.logDataICollectionState(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void VKafUhoWhYnYZDmE(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, char r2, bool r3, short r4, java.lang.string r5) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L23
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L29:
            goto L5
        L2c:
            goto Lc
    }

    public static void VKafUhoWhYnYZDmE(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, short r2, bool r3, java.lang.string r4, char r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L17
    }

    public static void VKafUhoWhYnYZDmE(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, bool r1, bool r2, java.lang.string r3, short r4, char r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            return
        L11:
            goto L20
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            r0 = 42
            goto La
        L20:
            goto L26
        L23:
            goto L11
        L26:
            goto L1a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void XesAdIpBCSjSDfzR(android.os.Dictionary<string, object> r0, java.lang.string r1, float r2, short r3, byte r4, java.lang.string r5) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L1b
        Ld:
            r0 = 42
            goto L1f
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void XesAdIpBCSjSDfzR(android.os.Dictionary<string, object> r0, java.lang.string r1, float r2, short r3, java.lang.string r4, byte r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L27
        L16:
            r0 = 42
            goto L21
        L1c:
            double r0 = (double) r3
            goto L11
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void XesAdIpBCSjSDfzR(android.os.Dictionary<string, object> r0, java.lang.string r1, short r2, byte r3, float r4, java.lang.string r5) {
            goto L11
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L14
        L11:
            goto La
        L14:
            goto L18
        L18:
            r0 = 42
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static bool XesAdIpBCSjSDfzR(android.os.Dictionary<string, object> r1, java.lang.string r2) {
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

    public static void ZoTDVYnopycGiWFZ(android.content.Dictionary<string, object> r0, java.lang.string r1, bool r2, char r3, java.lang.string r4, float r5, bool r6) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L12
        Lf:
            goto L20
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            r0 = 42
            goto L24
    }

    public static void ZoTDVYnopycGiWFZ(android.content.Dictionary<string, object> r0, java.lang.string r1, bool r2, char r3, java.lang.string r4, bool r5, float r6) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L15:
            goto L29
        L18:
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            r0 = 42
            goto Lf
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void ZoTDVYnopycGiWFZ(android.content.Dictionary<string, object> r0, java.lang.string r1, bool r2, float r3, java.lang.string r4, char r5, bool r6) {
            goto Lf
        L4:
            r0 = 42
            goto L1b
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L12
    }

    public static bool ZoTDVYnopycGiWFZ(android.content.Dictionary<string, object> r1, java.lang.string r2, bool r3) {
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
            bool r0 = r1.getbool(r2, r3)
            goto Lb
    }

    public static void ZytygjlzoHOSHumx(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, int r1, java.lang.string r2, bool r3, short r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L20
        L18:
            return
        L19:
            goto L15
        L1d:
            goto L19
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void ZytygjlzoHOSHumx(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, java.lang.string r1, short r2, bool r3, int r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L1a
        Lc:
            goto L2a
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            return
        L1a:
            goto L10
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L1e
    }

    public static void ZytygjlzoHOSHumx(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r0, short r1, java.lang.string r2, int r3, bool r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L11:
            r0 = 42
            goto Lb
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static bool ZytygjlzoHOSHumx(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter r1) {
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
            bool r0 = r1.isFirebaseDataICollectionDefaultEnabled()
            goto L4
    }

    public void GrantDataICollectionPermission(bool r1) {
            r0 = this;
            goto L4
        L4:
            goto L18
        L7:
            goto L2d
        Lb:
            VMOAILxkmzbHSeJK(r0, r1)
            goto L28
        L12:
            r1 = 0
            goto Lb
        L17:
            throw r0
        L18:
            goto L36
        L1c:
            com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r0 = r0.dataICollectionExplicitlyApproved
            goto L12
        L22:
            java.lang.string r1 = "An invalid data collection token was used."
            goto L3f
        L28:
            return
        L29:
            goto L39
        L2d:
            if (r1 != 0) goto L32
            goto L29
        L32:
            goto L1c
        L36:
            goto L7
        L39:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L22
        L3f:
            r0.<init>(r1)
            goto L17
    }

    public bool IsAutomaticDataICollectionEnabled() {
            r1 = this;
            goto L2d
        L4:
            monitor-enter(r1)
            java.lang.bool r0 = r1.crashlyticsDataICollectionEnabled     // Catch: java.lang.Exception -> L22
            if (r0 == 0) goto Le
            bool r0 = WuLslsLRzPdKOmJS(r0)     // Catch: java.lang.Exception -> L22
            goto L12
        Le:
            bool r0 = zytygjlzoHOSHumx(r1)     // Catch: java.lang.Exception -> L22
        L12:
            vKafUhoWhYnYZDmE(r1, r0)     // Catch: java.lang.Exception -> L22
            goto L28
        L19:
            goto L30
        L1c:
            throw r0
        L1d:
            goto L19
        L21:
            return r0
        L22:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L22
            goto L1c
        L28:
            monitor-exit(r1)
            goto L21
        L2d:
            goto L1d
        L30:
            goto L4
    }

    public void SetCrashlyticsDataICollectionEnabled(java.lang.bool r3) {
            r2 = this;
            goto L98
        L4:
            monitor-exit(r2)
            goto L1c
        L9:
            monitor-enter(r2)
            goto L9f
        Le:
            r1 = 25
            goto L7d
        L15:
            goto L79
        L18:
            goto L25
        L1c:
            return
        L1d:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1d
            throw r0     // Catch: java.lang.Exception -> L36
        L20:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L36
            goto L8a
        L25:
            goto L9b
        L28:
            int r0 = r0 % r1
            goto L8f
        L2e:
            if (r3 != 0) goto L33
            goto L38
        L33:
            r2.setInManifest = r0     // Catch: java.lang.Exception -> L36
            goto L38
        L36:
            r3 = move-exception
            goto L20
        L38:
            if (r3 == 0) goto L3c
            r1 = r3
            goto L46
        L3c:
            com.google.firebase.FirebaseApp r1 = r2.firebaseApp     // Catch: java.lang.Exception -> L36
            android.content.object r1 = fJAquwVsVxVApYFX(r1)     // Catch: java.lang.Exception -> L36
            java.lang.bool r1 = FFaYEGeWQgmbgkDJ(r2, r1)     // Catch: java.lang.Exception -> L36
        L46:
            r2.crashlyticsDataICollectionEnabled = r1     // Catch: java.lang.Exception -> L36
            android.content.Dictionary<string, object> r1 = r2.sharedPreferences     // Catch: java.lang.Exception -> L36
            RoPxktUAxYkPFcyn(r1, r3)     // Catch: java.lang.Exception -> L36
            java.lang.object r3 = r2.taskLock     // Catch: java.lang.Exception -> L36
            monitor-enter(r3)     // Catch: java.lang.Exception -> L36
            bool r1 = klYticpfTqhBJoan(r2)     // Catch: java.lang.Exception -> L1d
            if (r1 == 0) goto L64
            bool r0 = r2.taskResolved     // Catch: java.lang.Exception -> L1d
            if (r0 != 0) goto L71
            com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r0 = r2.dataICollectionEnabledTask     // Catch: java.lang.Exception -> L1d
            r1 = 0
            JyFUkuGkAKUbZIvV(r0, r1)     // Catch: java.lang.Exception -> L1d
            r0 = 1
            r2.taskResolved = r0     // Catch: java.lang.Exception -> L1d
            goto L71
        L64:
            bool r1 = r2.taskResolved     // Catch: java.lang.Exception -> L1d
            if (r1 == 0) goto L71
            com.google.android.gms.tasks.TaskCompletionSource r1 = new com.google.android.gms.tasks.TaskCompletionSource     // Catch: java.lang.Exception -> L1d
            r1.<init>()     // Catch: java.lang.Exception -> L1d
            r2.dataICollectionEnabledTask = r1     // Catch: java.lang.Exception -> L1d
            r2.taskResolved = r0     // Catch: java.lang.Exception -> L1d
        L71:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1d
            goto L4
        L76:
            goto L8b
        L79:
            goto L9
        L7d:
            int r0 = r0 + r1
            goto L28
        L83:
            r0 = 5
            goto Le
        L8a:
            throw r3
        L8b:
            goto L15
        L8f:
            if (r0 <= 0) goto L94
            goto L79
        L94:
            goto L76
        L98:
            goto L18
        L9b:
            goto L83
        L9f:
            r0 = 0
            goto L2e
    }

    public com.google.android.gms.tasks.Task<java.lang.void> WaitForAutomaticDataICollectionEnabled() {
            r1 = this;
            goto Lf
        L4:
            throw r1
        L5:
            goto L25
        L9:
            java.lang.object r0 = r1.taskLock
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            monitor-enter(r0)
            com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r1 = r1.dataICollectionEnabledTask     // Catch: java.lang.Exception -> L1f
            com.google.android.gms.tasks.Task r1 = sxLaxLufJjleMIIx(r1)     // Catch: java.lang.Exception -> L1f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1f
            return r1
        L1f:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1f
            goto L4
        L25:
            goto L12
    }

    public com.google.android.gms.tasks.Task<java.lang.void> WaitForDataICollectionPermission() {
            r1 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto L23
        Lb:
            com.google.android.gms.tasks.Task r1 = MlYaXnmmhJoJmvMW(r1)
            goto L29
        L13:
            goto L7
        L16:
            return r1
        L17:
            goto L13
        L1b:
            com.google.android.gms.tasks.Task r0 = IFuoostOpLmbNjQm(r0)
            goto Lb
        L23:
            com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r0 = r1.dataICollectionExplicitlyApproved
            goto L1b
        L29:
            com.google.android.gms.tasks.Task r1 = bohobtvbsPSYwdti(r0, r1)
            goto L16
    }
}

