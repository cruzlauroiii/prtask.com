namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class stringStore {
    private static readonly java.lang.string CRASHLYTICS_PATH_V1 = ".com.google.firebase.crashlytics.files.v1";
    private static readonly java.lang.string CRASHLYTICS_PATH_V2 = ".com.google.firebase.crashlytics.files.v2";
    private static readonly java.lang.string CRASHLYTICS_PATH_V3 = ".crashlytics.v3";
    private static readonly java.lang.string NATIVE_REPORTS_PATH = "native-reports";
    private static readonly java.lang.string NATIVE_SESSION_SUBDIR = "native";
    private static readonly java.lang.string PRIORITY_REPORTS_PATH = "priority-reports";
    private static readonly java.lang.string REPORTS_PATH = "reports";
    private static readonly java.lang.string SESSIONS_PATH = "open-sessions";
    private readonly java.io.string crashlyticsDir;
    private readonly java.io.string filesDir;
    private readonly java.io.string nativeReportsDir;
    private readonly java.io.string priorityReportsDir;
    readonly java.lang.string processName;
    private readonly java.io.string reportsDir;
    private readonly java.io.string sessionsDir;

    public stringStore(android.content.object r4) {
            r3 = this;
            goto Lc7
        L4:
            java.lang.stringBuilder r1 = NGucgbSboIkTyQip(r1, r2)
            goto L58
        Lc:
            java.io.string r0 = new java.io.string
            goto L24
        L12:
            r3.filesDir = r4
            goto L116
        L18:
            java.lang.string r2 = java.io.string.separator
            goto L4
        L1e:
            goto Le5
        L20:
            goto Le3
        L24:
            java.lang.string r1 = "reports"
            goto L51
        L2a:
            java.io.string r0 = new java.io.string
            goto L14f
        L30:
            java.lang.string r2 = ".crashlytics.v3"
            goto Ldc
        L36:
            java.lang.string r1 = "priority-reports"
            goto L148
        L3c:
            java.lang.string r0 = wzRIwkZyHYXewfDx(r0)
            goto L93
        L44:
            int r0 = r0 % r1
            goto L10d
        L4a:
            r1 = 28
            goto L7d
        L51:
            r0.<init>(r4, r1)
            goto L105
        L58:
            java.lang.string r0 = lHPwSePpwMeQWzWK(r0)
            goto La7
        L60:
            r1.<init>(r4, r0)
            goto L67
        L67:
            java.io.string r4 = QAGccgfmkHvFNKxw(r1)
            goto Lce
        L6f:
            r3.reportsDir = r0
            goto L131
        L75:
            java.lang.string r0 = YxAMssokaWpqoiGg(r0)
            goto L1e
        L7d:
            int r0 = r0 + r1
            goto L44
        L83:
            r0.<init>(r4, r1)
            goto Lf6
        L8a:
            if (r1 != 0) goto L8f
            goto L20
        L8f:
            goto L164
        L93:
            r3.processName = r0
            goto L13a
        L99:
            java.io.string r0 = MzSbCjSujmYDraaw(r0)
            goto Lba
        La1:
            java.io.string r1 = new java.io.string
            goto L60
        La7:
            java.lang.stringBuilder r0 = AkMaGnDAyNzCCXjb(r1, r0)
            goto L75
        Laf:
            java.io.string r0 = new java.io.string
            goto L125
        Lb5:
            return
        Lb6:
            goto Lfe
        Lba:
            r3.priorityReportsDir = r0
            goto Laf
        Lc0:
            r3.<init>()
            goto L12b
        Lc7:
            goto L101
        Lca:
            goto Le9
        Lce:
            r3.crashlyticsDir = r4
            goto L2a
        Ld4:
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails r0 = TCNXncXgicNZyINs(r0, r4)
            goto L3c
        Ldc:
            r1.<init>(r2)
            goto L18
        Le3:
            java.lang.string r0 = ".com.google.firebase.crashlytics.files.v1"
        Le5:
            goto La1
        Le9:
            r0 = 6
            goto L4a
        Lf0:
            r3.nativeReportsDir = r4
            goto Lb5
        Lf6:
            java.io.string r4 = bYSOStDMrxIPWejQ(r0)
            goto Lf0
        Lfe:
            goto L160
        L101:
            goto L137
        L105:
            java.io.string r0 = JZMuEkXJfwDqZyuN(r0)
            goto L6f
        L10d:
            if (r0 <= 0) goto L112
            goto L160
        L112:
            goto L15d
        L116:
            bool r1 = JEURdcXNVIDBKmev(r3)
            goto L8a
        L11e:
            r0.<init>(r4, r1)
            goto L155
        L125:
            java.lang.string r1 = "native-reports"
            goto L83
        L12b:
            com.google.firebase.crashlytics.internal.ProcessDetailsProvider r0 = com.google.firebase.crashlytics.internal.ProcessDetailsProvider.INSTANCE
            goto Ld4
        L131:
            java.io.string r0 = new java.io.string
            goto L36
        L137:
            goto Lca
        L13a:
            java.io.string r4 = rRyHpBXLkrDikntl(r4)
            goto L12
        L142:
            r3.sessionsDir = r0
            goto Lc
        L148:
            r0.<init>(r4, r1)
            goto L99
        L14f:
            java.lang.string r1 = "open-sessions"
            goto L11e
        L155:
            java.io.string r0 = dzdDheVXwTRworIw(r0)
            goto L142
        L15d:
            goto Lb6
        L160:
            goto Lc0
        L164:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L30
    }

    public static void AVltZwlAdNvKUJIn(java.lang.string r0, char r1, short r2, int r3, byte r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            r0 = 42
            goto L1e
        Lf:
            goto L1a
        L12:
            goto L9
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void AVltZwlAdNvKUJIn(java.lang.string r0, int r1, short r2, byte r3, char r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            goto L1c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            goto L27
        L1c:
            goto L20
        L20:
            r0 = 42
            goto Ld
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void AVltZwlAdNvKUJIn(java.lang.string r0, short r1, char r2, int r3, byte r4) {
            goto L15
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L4
        L1c:
            int r3 = r2 + r1
            goto L10
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static bool AVltZwlAdNvKUJIn(java.lang.string r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Count == 0
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.stringBuilder AkMaGnDAyNzCCXjb(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void AkMaGnDAyNzCCXjb(java.lang.stringBuilder r0, java.lang.string r1, float r2, int r3, bool r4, byte r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L29
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void AkMaGnDAyNzCCXjb(java.lang.stringBuilder r0, java.lang.string r1, float r2, bool r3, int r4, byte r5) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L28
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            r0 = 42
            goto La
        L21:
            goto L11
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void AkMaGnDAyNzCCXjb(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, byte r4, float r5) {
            goto L29
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static java.util.List BKKhplteEGuqVWeb(java.lang.object[] r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.List r0 = safeArrayToList(r1)
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

    public static void BKKhplteEGuqVWeb(java.lang.object[] r0, byte r1, java.lang.string r2, short r3, char r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            goto L12
        Ld:
            goto L22
        L11:
            return
        L12:
            goto L28
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r0 = 42
            goto L4
        L28:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void BKKhplteEGuqVWeb(java.lang.object[] r0, java.lang.string r1, byte r2, char r3, short r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L15:
            return
        L16:
            goto L20
        L1a:
            int r2 = r0 * r1
            goto L2a
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void BKKhplteEGuqVWeb(java.lang.object[] r0, short r1, char r2, byte r3, java.lang.string r4) {
            goto L1f
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L22
        Ld:
            int r3 = r2 + r1
            goto L26
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            r0 = 42
            goto L13
        L1f:
            goto L2c
        L22:
            goto L19
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static java.io.string DMfTxjNJNNVJbWdU(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2) {
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
            java.io.string r0 = r1.getSessionDir(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void DMfTxjNJNNVJbWdU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, byte r2, char r3, int r4, bool r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L2a
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            int r2 = r0 * r1
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void DMfTxjNJNNVJbWdU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, byte r3, char r4, int r5) {
            goto Ld
        L4:
            r0 = 42
            goto L2a
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L4
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void DMfTxjNJNNVJbWdU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, byte r3, int r4, char r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L1b
        L18:
            goto L20
        L1b:
            goto L24
        L1f:
            return
        L20:
            goto L15
        L24:
            r0 = 42
            goto L9
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void DWLyQDzvaJnkQaaC(java.io.string r0, float r1, int r2, short r3, bool r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L1f
        L15:
            goto L26
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void DWLyQDzvaJnkQaaC(java.io.string r0, short r1, bool r2, int r3, float r4) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L18
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            r0 = 42
            goto L2a
        L18:
            int r3 = r2 + r1
            goto Ld
        L1e:
            goto L26
        L21:
            goto L12
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static void DWLyQDzvaJnkQaaC(java.io.string r0, bool r1, short r2, int r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L26
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static java.io.string[] DWLyQDzvaJnkQaaC(java.io.string r1) {
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
            java.io.string[] r0 = r1.liststrings()
            goto Lb
        L18:
            goto L7
    }

    public static void DWxunmTSbIWaHqNe(java.io.string r0, float r1, bool r2, byte r3, java.lang.string r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L13
        L9:
            goto L14
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            return
        L14:
            goto L10
        L18:
            int r2 = r0 * r1
            goto L24
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void DWxunmTSbIWaHqNe(java.io.string r0, java.lang.string r1, byte r2, bool r3, float r4) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            goto L5
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto L14
        L27:
            r0 = 42
            goto Le
        L2d:
            goto L1d
    }

    public static void DWxunmTSbIWaHqNe(java.io.string r0, bool r1, java.lang.string r2, byte r3, float r4) {
            goto L1e
        L4:
            goto L21
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L18:
            int r3 = r2 + r1
            goto L7
        L1e:
            goto L2c
        L21:
            goto Lc
        L25:
            int r2 = r0 * r1
            goto L18
        L2b:
            return
        L2c:
            goto L4
    }

    public static java.io.string[] DWxunmTSbIWaHqNe(java.io.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.io.string[] r0 = r1.liststrings()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void EADJdpDXtobmmDfG(java.io.string r0, java.io.stringnameFilter r1, bool r2, char r3, java.lang.string r4, float r5) {
            goto L19
        L4:
            goto L1c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        Ld:
            int r3 = r2 + r1
            goto L20
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            goto L26
        L1c:
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L7
    }

    public static void EADJdpDXtobmmDfG(java.io.string r0, java.io.stringnameFilter r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            goto L1c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            int r3 = r2 + r1
            goto L26
        L19:
            goto L2c
        L1c:
            goto L20
        L20:
            r0 = 42
            goto Ld
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static void EADJdpDXtobmmDfG(java.io.string r0, java.io.stringnameFilter r1, bool r2, java.lang.string r3, char r4, float r5) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L14
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static java.io.string[] EADJdpDXtobmmDfG(java.io.string r1, java.io.stringnameFilter r2) {
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
            java.io.string[] r0 = r1.liststrings(r2)
            goto Lb
    }

    public static void ENYrDNWbDyFOCKTA(java.io.string r0, float r1, bool r2, java.lang.string r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L17
        La:
            goto L1e
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L28
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r2 = r0 * r1
            goto L11
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto Ld
    }

    public static void ENYrDNWbDyFOCKTA(java.io.string r0, java.lang.string r1, bool r2, float r3, char r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r0 = 42
            goto La
    }

    public static void ENYrDNWbDyFOCKTA(java.io.string r0, bool r1, java.lang.string r2, char r3, float r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L20
        Lf:
            r0 = 42
            goto L1a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static bool ENYrDNWbDyFOCKTA(java.io.string r1) {
            goto Lf
        L4:
            bool r0 = recursiveDelete(r1)
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

    public static java.util.List FJbczLmZceBHvkkQ(java.lang.object[] r1) {
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
            java.util.List r0 = safeArrayToList(r1)
            goto L4
    }

    public static void FJbczLmZceBHvkkQ(java.lang.object[] r0, byte r1, short r2, bool r3, char r4) {
            goto L4
        L4:
            goto L18
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L21
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void FJbczLmZceBHvkkQ(java.lang.object[] r0, short r1, char r2, bool r3, byte r4) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            r0 = 42
            goto L4
        L1a:
            goto L10
        L1d:
            goto L14
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto La
        L2d:
            goto L1d
    }

    public static void FJbczLmZceBHvkkQ(java.lang.object[] r0, bool r1, byte r2, short r3, char r4) {
            goto L29
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r0 = 42
            goto L9
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            int r2 = r0 * r1
            goto L12
        L29:
            goto L5
        L2c:
            goto L18
    }

    public static java.util.List FetmfDJCiDeqkdny(java.lang.object[] r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.List r0 = safeArrayToList(r1)
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

    public static void FetmfDJCiDeqkdny(java.lang.object[] r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L21
        Ld:
            int r2 = r0 * r1
            goto L25
        L13:
            r0 = 42
            goto L4
        L19:
            return
        L1a:
            goto La
        L1e:
            goto L1a
        L21:
            goto L13
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void FetmfDJCiDeqkdny(java.lang.object[] r0, short r1, bool r2, java.lang.string r3, char r4) {
            goto L1b
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L22
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
            goto L4
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void FetmfDJCiDeqkdny(java.lang.object[] r0, bool r1, char r2, short r3, java.lang.string r4) {
            goto L1e
        L4:
            r0 = 42
            goto L18
        La:
            int r3 = r2 + r1
            goto L13
        L10:
            goto L21
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static java.lang.stringBuilder FwLAvusSHZONVmgB(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static void FwLAvusSHZONVmgB(java.lang.stringBuilder r0, java.lang.string r1, int r2, byte r3, java.lang.string r4, short r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            double r0 = (double) r3
            goto L1f
        L13:
            r0 = 42
            goto L24
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            return
        L20:
            goto Lb
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            int r3 = r2 + r1
            goto Le
    }

    public static void FwLAvusSHZONVmgB(java.lang.stringBuilder r0, java.lang.string r1, int r2, short r3, java.lang.string r4, byte r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r0 = 42
            goto L25
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto La
        L1c:
            int r3 = r2 + r1
            goto L10
        L22:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            return
        L2c:
            goto L22
    }

    public static void FwLAvusSHZONVmgB(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, int r3, byte r4, short r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L1d
        L12:
            goto L9
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    public static void GlChndLLYqiJVcfR(java.io.string r0, java.io.stringnameFilter r1, float r2, byte r3, int r4, char r5) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            int r3 = r2 + r1
            goto L22
        L15:
            goto L5
        L18:
            goto L27
        L1c:
            int r2 = r0 * r1
            goto Lf
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            r0 = 42
            goto L9
        L2d:
            goto L18
    }

    public static void GlChndLLYqiJVcfR(java.io.string r0, java.io.stringnameFilter r1, float r2, char r3, byte r4, int r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            goto L26
        Ld:
            r0 = 42
            goto L2a
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            return
        L1f:
            goto La
        L23:
            goto L1f
        L26:
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void GlChndLLYqiJVcfR(java.io.string r0, java.io.stringnameFilter r1, int r2, byte r3, char r4, float r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            goto L2c
        Ld:
            goto L25
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
            r0 = 42
            goto L4
        L2b:
            return
        L2c:
            goto L22
    }

    public static java.io.string[] GlChndLLYqiJVcfR(java.io.string r1, java.io.stringnameFilter r2) {
            goto L14
        L4:
            java.io.string[] r0 = r1.liststrings(r2)
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

    public static java.util.List HiCfBUVZFZkjbAFu(java.lang.object[] r1) {
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
            java.util.List r0 = java.util.Arrays.asList(r1)
            goto Le
    }

    public static void HiCfBUVZFZkjbAFu(java.lang.object[] r0, byte r1, java.lang.string r2, bool r3, float r4) {
            goto L4
        L4:
            goto L27
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L2b
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
            goto L7
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void HiCfBUVZFZkjbAFu(java.lang.object[] r0, float r1, java.lang.string r2, byte r3, bool r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            r0 = 42
            goto L4
        L15:
            goto L20
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void HiCfBUVZFZkjbAFu(java.lang.object[] r0, bool r1, float r2, java.lang.string r3, byte r4) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L24
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            r0 = 42
            goto L18
        L24:
            double r0 = (double) r3
            goto L7
        L29:
            goto L8
        L2c:
            goto L1e
    }

    public static void HmbwuTYkDAFWxvmw(com.google.firebase.crashlytics.internal.persistence.stringStore r0, char r1, bool r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L12
        L23:
            goto L8
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lc
    }

    public static void HmbwuTYkDAFWxvmw(com.google.firebase.crashlytics.internal.persistence.stringStore r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L2a
        L16:
            goto L23
        L19:
            goto L10
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L27
        L27:
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void HmbwuTYkDAFWxvmw(com.google.firebase.crashlytics.internal.persistence.stringStore r0, bool r1, java.lang.string r2, short r3, char r4) {
            goto L23
        L4:
            r0 = 42
            goto L14
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            goto L26
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            goto L10
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static bool HmbwuTYkDAFWxvmw(com.google.firebase.crashlytics.internal.persistence.stringStore r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.useV3stringSystem()
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

    public static void IUhXOoAxxepWdpWq(java.io.string r0, java.io.stringnameFilter r1, char r2, float r3, java.lang.string r4, int r5) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            return
        Lb:
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            r0 = 42
            goto Lf
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            goto Lb
        L23:
            goto L15
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void IUhXOoAxxepWdpWq(java.io.string r0, java.io.stringnameFilter r1, char r2, java.lang.string r3, float r4, int r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            goto L2c
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            r0 = 42
            goto L23
        L1e:
            return
        L1f:
            goto L9
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto L1f
        L2c:
            goto L18
    }

    public static void IUhXOoAxxepWdpWq(java.io.string r0, java.io.stringnameFilter r1, java.lang.string r2, int r3, char r4, float r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            r0 = 42
            goto L1f
        L1c:
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static java.lang.string[] IUhXOoAxxepWdpWq(java.io.string r1, java.io.stringnameFilter r2) {
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
            java.lang.string[] r0 = r1.list(r2)
            goto Le
    }

    public static java.io.string IruvmRgSWsSEVrwU(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2) {
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
            java.io.string r0 = r1.getSessionDir(r2)
            goto L4
    }

    public static void IruvmRgSWsSEVrwU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, byte r3, java.lang.string r4, float r5) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L22
        L13:
            int r2 = r0 * r1
            goto La
        L19:
            r0 = 42
            goto L4
        L1f:
            goto L27
        L22:
            goto L19
        L26:
            return
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void IruvmRgSWsSEVrwU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, float r2, java.lang.string r3, char r4, byte r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L12
        Ld:
            goto L1c
        L11:
            return
        L12:
            goto L22
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            r0 = 42
            goto L4
        L22:
            goto Ld
        L25:
            int r2 = r0 * r1
            goto L16
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void IruvmRgSWsSEVrwU(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, byte r3, float r4, char r5) {
            goto L19
        L4:
            r0 = 42
            goto L20
        La:
            int r3 = r2 + r1
            goto L26
        L10:
            goto L1c
        L13:
            int r2 = r0 * r1
            goto La
        L19:
            goto L2c
        L1c:
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static java.util.List Itarswwktkpjcuza(java.lang.object[] r1) {
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
            java.util.List r0 = safeArrayToList(r1)
            goto Lb
    }

    public static void Itarswwktkpjcuza(java.lang.object[] r0, java.lang.string r1, short r2, bool r3, float r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L2c
        L17:
            int r3 = r2 + r1
            goto La
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            r0 = 42
            goto L4
        L29:
            goto L10
        L2c:
            goto L23
    }

    public static void Itarswwktkpjcuza(java.lang.object[] r0, java.lang.string r1, bool r2, short r3, float r4) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto Lb
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto Lf
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L1d
    }

    public static void Itarswwktkpjcuza(java.lang.object[] r0, short r1, java.lang.string r2, float r3, bool r4) {
            goto L1b
        L4:
            r0 = 42
            goto L27
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L23
        L1e:
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2d:
            goto L1e
    }

    public static void JEURdcXNVIDBKmev(com.google.firebase.crashlytics.internal.persistence.stringStore r0, int r1, char r2, bool r3, short r4) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            goto L8
        L15:
            goto L19
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void JEURdcXNVIDBKmev(com.google.firebase.crashlytics.internal.persistence.stringStore r0, short r1, char r2, bool r3, int r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r0 = 42
            goto L24
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto L1d
        L18:
            goto L9
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void JEURdcXNVIDBKmev(com.google.firebase.crashlytics.internal.persistence.stringStore r0, short r1, int r2, char r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            return
        Lb:
            goto L1a
        Lf:
            r0 = 42
            goto L23
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static bool JEURdcXNVIDBKmev(com.google.firebase.crashlytics.internal.persistence.stringStore r1) {
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
            bool r0 = r1.useV3stringSystem()
            goto L4
    }

    public static java.io.string JZMuEkXJfwDqZyuN(java.io.string r1) {
            goto L14
        L4:
            java.io.string r0 = prepareBaseDir(r1)
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

    public static void JZMuEkXJfwDqZyuN(java.io.string r0, char r1, float r2, byte r3, bool r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L21
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            return
        L1a:
            goto La
        L1e:
            goto L1a
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            r0 = 42
            goto Ld
    }

    public static void JZMuEkXJfwDqZyuN(java.io.string r0, float r1, char r2, byte r3, bool r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L16
        L13:
            goto L1b
        L16:
            goto L1f
        L1a:
            return
        L1b:
            goto L10
        L1f:
            r0 = 42
            goto La
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void JZMuEkXJfwDqZyuN(java.io.string r0, float r1, char r2, bool r3, byte r4) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            goto Lc
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L1f
    }

    public static void KyoUmwyMHqZdPHFp(java.io.string r0, short r1, java.lang.string r2, bool r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L18
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void KyoUmwyMHqZdPHFp(java.io.string r0, short r1, bool r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L22
        L10:
            r0 = 42
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    public static void KyoUmwyMHqZdPHFp(java.io.string r0, short r1, bool r2, java.lang.string r3, int r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L2c
        L13:
            goto L25
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto L13
        L25:
            r0 = 42
            goto La
        L2b:
            return
        L2c:
            goto L22
    }

    public static java.io.string[] KyoUmwyMHqZdPHFp(java.io.string r1) {
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
            java.io.string[] r0 = r1.liststrings()
            goto L4
        L18:
            goto Lc
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LUxcbhewCohZEpKR() {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void LUxcbhewCohZEpKR(char r0, int r1, byte r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L2a
        Le:
            int r2 = r0 * r1
            goto L1f
        L14:
            return
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            r0 = 42
            goto L19
    }

    public static void LUxcbhewCohZEpKR(int r0, bool r1, byte r2, char r3) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void LUxcbhewCohZEpKR(bool r0, byte r1, int r2, char r3) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            r0 = 42
            goto L18
        L10:
            goto L2c
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L14
        L2c:
            goto La
    }

    public static java.lang.string MbLTuzIdRHJCxtzO(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Lb
    }

    public static void MbLTuzIdRHJCxtzO(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, short r4) {
            goto L11
        L4:
            return
        L5:
            goto L9
        L9:
            goto L14
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            goto L5
        L14:
            goto L24
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void MbLTuzIdRHJCxtzO(java.lang.stringBuilder r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1a
        L7:
            goto L24
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L19
        L16:
            goto L7
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r2 = r0 * r1
            goto Lb
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void MbLTuzIdRHJCxtzO(java.lang.stringBuilder r0, short r1, bool r2, int r3, java.lang.string r4) {
            goto L17
        L4:
            return
        L5:
            goto L14
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            goto L1a
        L17:
            goto L5
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static void MfCtgbRzftEyVBGw(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.m351d(r1)
            goto Le
    }

    public static void MfCtgbRzftEyVBGw(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, byte r3, short r4, int r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L20
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L4
        L29:
            goto L10
        L2c:
            goto L23
    }

    public static void MfCtgbRzftEyVBGw(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, int r3, byte r4, short r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r0 = 42
            goto L25
        L10:
            return
        L11:
            goto L22
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto L11
        L1e:
            goto La
        L22:
            goto L1e
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void MfCtgbRzftEyVBGw(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, int r2, float r3, byte r4, short r5) {
            goto L13
        L4:
            r0 = 42
            goto Ld
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L13:
            goto L2c
        L16:
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            return
        L2c:
            goto La
    }

    public static java.io.string MzSbCjSujmYDraaw(java.io.string r1) {
            goto Lc
        L4:
            java.io.string r0 = prepareBaseDir(r1)
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

    public static void MzSbCjSujmYDraaw(java.io.string r0, byte r1, char r2, java.lang.string r3, short r4) {
            goto L14
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L1b
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2d:
            goto L17
    }

    public static void MzSbCjSujmYDraaw(java.io.string r0, byte r1, java.lang.string r2, char r3, short r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            r0 = 42
            goto Lf
        L1b:
            return
        L1c:
            goto L26
        L20:
            int r3 = r2 + r1
            goto La
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto L15
    }

    public static void MzSbCjSujmYDraaw(java.io.string r0, java.lang.string r1, short r2, char r3, byte r4) {
            goto L29
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L12
        Lf:
            goto L2c
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static java.lang.stringBuilder NGucgbSboIkTyQip(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void NGucgbSboIkTyQip(java.lang.stringBuilder r0, java.lang.string r1, int r2, char r3, bool r4, java.lang.string r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r0 = 42
            goto L1a
        L10:
            goto L2c
        L13:
            goto La
        L17:
            goto L13
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static void NGucgbSboIkTyQip(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, bool r4, int r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto Lb
        L2a:
            r0 = 42
            goto L10
    }

    public static void NGucgbSboIkTyQip(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, int r3, bool r4, char r5) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            goto L5
        L15:
            goto L19
        L19:
            r0 = 42
            goto Lc
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void NsRCKTQbLAeHNQTW(java.io.string r0, byte r1, int r2, short r3, float r4) {
            goto L1d
        L4:
            r0 = 42
            goto L24
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void NsRCKTQbLAeHNQTW(java.io.string r0, float r1, short r2, int r3, byte r4) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L23
        L1a:
            r0 = 42
            goto L9
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto Lf
        L29:
            goto L5
        L2c:
            goto L1a
    }

    public static void NsRCKTQbLAeHNQTW(java.io.string r0, int r1, byte r2, float r3, short r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L1b
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r0 = 42
            goto L4
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static bool NsRCKTQbLAeHNQTW(java.io.string r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = recursiveDelete(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void NyrjPGzmheFSPAKX(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1) {
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
            r0.cleanupstringSystemDir(r1)
            goto L4
    }

    public static void NyrjPGzmheFSPAKX(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, float r3, short r4, java.lang.string r5) {
            goto L1b
        L4:
            r0 = 42
            goto L15
        La:
            return
        Lb:
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto Lb
        L1e:
            goto L4
        L22:
            goto L1e
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void NyrjPGzmheFSPAKX(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, java.lang.string r3, float r4, short r5) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L2a
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto La
        L1f:
            return
        L20:
            goto L16
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void NyrjPGzmheFSPAKX(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, float r2, java.lang.string r3, char r4, short r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            return
        Lb:
            goto L20
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    public static java.lang.string OjyeHgVMhLFBoMHZ(java.io.string r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.getPath()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void OjyeHgVMhLFBoMHZ(java.io.string r0, float r1, int r2, byte r3, short r4) {
            goto L15
        L4:
            r0 = 42
            goto L1c
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void OjyeHgVMhLFBoMHZ(java.io.string r0, int r1, short r2, float r3, byte r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L2a
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            goto L26
        L21:
            goto L12
        L25:
            return
        L26:
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void OjyeHgVMhLFBoMHZ(java.io.string r0, short r1, byte r2, float r3, int r4) {
            goto L18
        L4:
            r0 = 42
            goto L1f
        La:
            goto L1b
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            goto L26
        L1b:
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static java.io.string QAGccgfmkHvFNKxw(java.io.string r1) {
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
            java.io.string r0 = prepareBaseDir(r1)
            goto L7
    }

    public static void QAGccgfmkHvFNKxw(java.io.string r0, int r1, java.lang.string r2, byte r3, bool r4) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L10:
            goto L2c
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            int r2 = r0 * r1
            goto L13
        L24:
            return
        L25:
            goto L10
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void QAGccgfmkHvFNKxw(java.io.string r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L9
        L4:
            return
        L5:
            goto L15
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            goto Lc
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static void QAGccgfmkHvFNKxw(java.io.string r0, bool r1, int r2, byte r3, java.lang.string r4) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L28
        L16:
            goto L24
        L19:
            goto La
        L1d:
            int r2 = r0 * r1
            goto L10
        L23:
            return
        L24:
            goto L2d
        L28:
            double r0 = (double) r3
            goto L23
        L2d:
            goto L19
    }

    public static void REBrIbXULbsYfabz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L13
        L4:
            r0.m353e(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void REBrIbXULbsYfabz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, byte r2, java.lang.string r3, bool r4, int r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            r0 = 42
            goto L21
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto La
        L1d:
            goto Le
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L14
    }

    public static void REBrIbXULbsYfabz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.string r2, int r3, bool r4, byte r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            goto L26
        L19:
            return
        L1a:
            goto L16
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    public static void REBrIbXULbsYfabz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, int r3, byte r4, java.lang.string r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L2c
        L1e:
            goto L10
        L22:
            goto L1e
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            return
        L2c:
            goto L22
    }

    public static void RXiqxKHSjReBRPbO(java.io.string r0, byte r1, bool r2, int r3, char r4) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            int r2 = r0 * r1
            goto L27
        L20:
            goto L16
        L23:
            goto La
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L23
    }

    public static void RXiqxKHSjReBRPbO(java.io.string r0, char r1, byte r2, bool r3, int r4) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L1a
        L13:
            goto L26
        L16:
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L1f
    }

    public static void RXiqxKHSjReBRPbO(java.io.string r0, int r1, byte r2, char r3, bool r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L1c
        L11:
            return
        L12:
            goto L27
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L16
    }

    public static java.io.string[] RXiqxKHSjReBRPbO(java.io.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.io.string[] r0 = r1.liststrings()
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

    public static com.google.firebase.crashlytics.internal.Consoleger RZPCcpGyNyGjqQjc() {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void RZPCcpGyNyGjqQjc(short r0, java.lang.string r1, bool r2, char r3) {
            goto L24
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L1b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            return
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L27
        L24:
            goto L17
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void RZPCcpGyNyGjqQjc(short r0, bool r1, java.lang.string r2, char r3) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            int r2 = r0 * r1
            goto L12
        L29:
            goto Le
        L2c:
            goto L4
    }

    public static void RZPCcpGyNyGjqQjc(bool r0, java.lang.string r1, char r2, short r3) {
            goto L29
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L1a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static void SZbdhRxGkjRZarPN(java.io.string r0, byte r1, bool r2, java.lang.string r3, float r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1f
        Lb:
            return
        Lc:
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            goto L7
        L1f:
            r0 = 42
            goto L10
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void SZbdhRxGkjRZarPN(java.io.string r0, java.lang.string r1, float r2, bool r3, byte r4) {
            goto L23
        L4:
            goto L26
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L12:
            return
        L13:
            goto L4
        L17:
            r0 = 42
            goto Lc
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L13
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void SZbdhRxGkjRZarPN(java.io.string r0, bool r1, java.lang.string r2, byte r3, float r4) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto L5
        L2c:
            goto Lc
    }

    public static java.lang.string[] SZbdhRxGkjRZarPN(java.io.string r1) {
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
            java.lang.string[] r0 = r1.list()
            goto L4
    }

    public static void SvjNYxxHRcmwvavk(java.io.string r0, byte r1, java.lang.string r2, short r3, float r4) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            goto Lb
        L23:
            goto Lf
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L1b
    }

    public static void SvjNYxxHRcmwvavk(java.io.string r0, byte r1, short r2, float r3, java.lang.string r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            r0 = 42
            goto L1d
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L23:
            goto Lb
        L26:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void SvjNYxxHRcmwvavk(java.io.string r0, java.lang.string r1, short r2, byte r3, float r4) {
            goto L1b
        L4:
            return
        L5:
            goto L22
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L25
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static bool SvjNYxxHRcmwvavk(java.io.string r1) {
            goto Lc
        L4:
            bool r0 = r1.isDirectory()
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

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails TCNXncXgicNZyINs(com.google.firebase.crashlytics.internal.ProcessDetailsProvider r1, android.content.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails r0 = r1.getCurrentProcessDetails(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void TCNXncXgicNZyINs(com.google.firebase.crashlytics.internal.ProcessDetailsProvider r0, android.content.object r1, byte r2, bool r3, short r4, java.lang.string r5) {
            goto L21
        L4:
            double r0 = (double) r3
            goto L28
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
            r0 = 42
            goto Lf
        L21:
            goto L29
        L24:
            goto L1b
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static void TCNXncXgicNZyINs(com.google.firebase.crashlytics.internal.ProcessDetailsProvider r0, android.content.object r1, java.lang.string r2, bool r3, byte r4, short r5) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L10:
            r0 = 42
            goto La
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L2c
        L1f:
            goto L10
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L1f
        L2b:
            return
        L2c:
            goto L28
    }

    public static void TCNXncXgicNZyINs(com.google.firebase.crashlytics.internal.ProcessDetailsProvider r0, android.content.object r1, short r2, java.lang.string r3, byte r4, bool r5) {
            goto L20
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L1b
        L10:
            return
        L11:
            goto L27
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L11
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void TGWNOhBKIUVPyQYO(java.io.string r0, char r1, short r2, bool r3, float r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L20
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            r0 = 42
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void TGWNOhBKIUVPyQYO(java.io.string r0, short r1, float r2, char r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L27
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2d:
            goto L12
    }

    public static void TGWNOhBKIUVPyQYO(java.io.string r0, bool r1, float r2, short r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L20
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static bool TGWNOhBKIUVPyQYO(java.io.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.exists()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.util.List TisENRuIzllJzgnk(java.lang.object[] r1) {
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
            java.util.List r0 = safeArrayToList(r1)
            goto L4
        L18:
            goto Lc
    }

    public static void TisENRuIzllJzgnk(java.lang.object[] r0, float r1, char r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L21
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto Lb
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2a:
            r0 = 42
            goto L24
    }

    public static void TisENRuIzllJzgnk(java.lang.object[] r0, int r1, char r2, float r3, java.lang.string r4) {
            goto Ld
        L4:
            r0 = 42
            goto L25
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L4
        L14:
            int r2 = r0 * r1
            goto L1f
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void TisENRuIzllJzgnk(java.lang.object[] r0, java.lang.string r1, int r2, char r3, float r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L24
        L10:
            double r0 = (double) r3
            goto L1f
        L15:
            goto L20
        L18:
            goto La
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static java.io.string WZPivivdNUeaJSTK(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2) {
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
            java.io.string r0 = r1.getSessionDir(r2)
            goto Lb
    }

    public static void WZPivivdNUeaJSTK(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, byte r2, int r3, char r4, java.lang.string r5) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L19:
            r0 = 42
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void WZPivivdNUeaJSTK(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, byte r2, java.lang.string r3, int r4, char r5) {
            goto L18
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1b
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            goto L5
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto Lc
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void WZPivivdNUeaJSTK(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, int r2, java.lang.string r3, char r4, byte r5) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L10:
            r0 = 42
            goto La
        L16:
            goto L2c
        L19:
            goto L10
        L1d:
            goto L19
        L20:
            int r2 = r0 * r1
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L1d
    }

    public static java.util.List WppcxyHrFLWoXquk(java.lang.object[] r1) {
            goto L11
        L4:
            java.util.List r0 = safeArrayToList(r1)
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

    public static void WppcxyHrFLWoXquk(java.lang.object[] r0, char r1, int r2, float r3, short r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            r0 = 42
            goto L21
        L1a:
            goto L10
        L1d:
            goto L14
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void WppcxyHrFLWoXquk(java.lang.object[] r0, float r1, char r2, short r3, int r4) {
            goto L23
        L4:
            return
        L5:
            goto L1a
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            r0 = 42
            goto L2a
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto Le
        L23:
            goto L5
        L26:
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void WppcxyHrFLWoXquk(java.lang.object[] r0, short r1, int r2, char r3, float r4) {
            goto L29
        L4:
            r0 = 42
            goto L20
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            return
        L11:
            goto L26
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L4
    }

    public static void YcjNtZVZPlzcfmtT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.cleanupstringSystemDirs(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void YcjNtZVZPlzcfmtT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, float r2, bool r3, java.lang.string r4, int r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            r0 = 42
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto Lc
    }

    public static void YcjNtZVZPlzcfmtT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, float r3, java.lang.string r4, int r5) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L27
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1d:
            int r3 = r2 + r1
            goto L2b
        L23:
            goto L13
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void YcjNtZVZPlzcfmtT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, int r3, float r4, java.lang.string r5) {
            goto L1d
        L4:
            return
        L5:
            goto L1a
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            goto L20
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.string YxAMssokaWpqoiGg(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto L7
    }

    public static void YxAMssokaWpqoiGg(java.lang.stringBuilder r0, char r1, float r2, java.lang.string r3, short r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void YxAMssokaWpqoiGg(java.lang.stringBuilder r0, float r1, short r2, java.lang.string r3, char r4) {
            goto L14
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1b
        L14:
            goto L10
        L17:
            goto L4
        L1b:
            goto L17
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void YxAMssokaWpqoiGg(java.lang.stringBuilder r0, java.lang.string r1, short r2, char r3, float r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            int r2 = r0 * r1
            goto L15
        L29:
            goto L1f
        L2c:
            goto Lf
    }

    public static void BVYOYmzyUEWMIjaw(java.io.string r0, int r1, float r2, bool r3, short r4) {
            goto L15
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L4
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void BVYOYmzyUEWMIjaw(java.io.string r0, bool r1, float r2, int r3, short r4) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r0 = 42
            goto L9
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void BVYOYmzyUEWMIjaw(java.io.string r0, bool r1, short r2, int r3, float r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L1f
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto Le
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2b:
            return
        L2c:
            goto L4
    }

    public static bool BVYOYmzyUEWMIjaw(java.io.string r1) {
            goto Lf
        L4:
            bool r0 = recursiveDelete(r1)
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

    public static java.io.string BYSOStDMrxIPWejQ(java.io.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.io.string r0 = prepareBaseDir(r1)
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

    public static void BYSOStDMrxIPWejQ(java.io.string r0, java.lang.string r1, byte r2, short r3, bool r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            r0 = 42
            goto L2a
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void BYSOStDMrxIPWejQ(java.io.string r0, java.lang.string r1, short r2, byte r3, bool r4) {
            goto Lf
        L4:
            r0 = 42
            goto L1e
        La:
            double r0 = (double) r3
            goto L19
        Lf:
            goto L1a
        L12:
            goto L4
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void BYSOStDMrxIPWejQ(java.io.string r0, short r1, java.lang.string r2, byte r3, bool r4) {
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
            r0 = 42
            goto L24
        L19:
            double r0 = (double) r3
            goto Lb
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static int BibuZCXsWJOpHBWs(java.lang.string r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.Length
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void BibuZCXsWJOpHBWs(java.lang.string r0, byte r1, short r2, char r3, bool r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            goto Lb
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto Lf
        L27:
            r0 = 42
            goto L14
        L2d:
            goto L1d
    }

    public static void BibuZCXsWJOpHBWs(java.lang.string r0, byte r1, short r2, bool r3, char r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L25
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto L13
        L25:
            int r3 = r2 + r1
            goto L1d
        L2b:
            return
        L2c:
            goto L22
    }

    public static void BibuZCXsWJOpHBWs(java.lang.string r0, char r1, short r2, bool r3, byte r4) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L25
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L21
        L19:
            goto La
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2b:
            double r0 = (double) r3
            goto L20
    }

    private void CleanupstringSystemDir(java.lang.string r3) {
            r2 = this;
            goto L82
        L4:
            int r0 = r0 % r1
            goto L5d
        La:
            r1 = 18
            goto L39
        L11:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L33
        L17:
            return
        L18:
            goto L47
        L1c:
            bool r2 = TGWNOhBKIUVPyQYO(r0)
            goto L8f
        L24:
            r0.<init>(r2, r3)
            goto L1c
        L2b:
            java.lang.string r3 = eYlcUhwJBSPsgfix(r3)
            goto La3
        L33:
            java.lang.string r1 = "Deleted previous Crashlytics file system: "
            goto L56
        L39:
            int r0 = r0 + r1
            goto L4
        L3f:
            com.google.firebase.crashlytics.internal.Consoleger r2 = LUxcbhewCohZEpKR()
            goto L11
        L47:
            goto L7e
        L4a:
            goto L98
        L4e:
            java.lang.string r0 = OjyeHgVMhLFBoMHZ(r0)
            goto L9b
        L56:
            r3.<init>(r1)
            goto L4e
        L5d:
            if (r0 <= 0) goto L62
            goto L7e
        L62:
            goto L7b
        L66:
            r0 = 29
            goto La
        L6d:
            java.io.string r2 = r2.filesDir
            goto L24
        L73:
            bool r2 = bVYOYmzyUEWMIjaw(r0)
            goto Laa
        L7b:
            goto L18
        L7e:
            goto L89
        L82:
            goto L4a
        L85:
            goto L66
        L89:
            java.io.string r0 = new java.io.string
            goto L6d
        L8f:
            if (r2 != 0) goto L94
            goto La6
        L94:
            goto L73
        L98:
            goto L85
        L9b:
            java.lang.stringBuilder r3 = eErzOcTeYITaqOhn(r3, r0)
            goto L2b
        La3:
            MfCtgbRzftEyVBGw(r2, r3)
        La6:
            goto L17
        Laa:
            if (r2 != 0) goto Laf
            goto La6
        Laf:
            goto L3f
    }

    private void CleanupstringSystemDir(java.lang.string r1, float r2, short r3, java.lang.string r4, bool r5) {
            r0 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L1a
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto Lb
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    private void CleanupstringSystemDir(java.lang.string r1, short r2, bool r3, float r4, java.lang.string r5) {
            r0 = this;
            goto L9
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            goto L17
        Lc:
            goto L24
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L16:
            return
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            goto Lc
        L24:
            r0 = 42
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    private void CleanupstringSystemDir(java.lang.string r1, bool r2, float r3, java.lang.string r4, short r5) {
            r0 = this;
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            r0 = 42
            goto L1b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto Lc
    }

    private void CleanupstringSystemDirs(java.lang.string r4) {
            r3 = this;
            goto L15
        L4:
            int r0 = r0 + r1
            goto L1c
        La:
            bool r0 = prHMhhdwCekldziu(r0)
            goto L28
        L12:
            goto L18
        L15:
            goto L47
        L18:
            goto La3
        L1c:
            int r0 = r0 % r1
            goto L82
        L22:
            com.google.firebase.crashlytics.internal.persistence.stringStore$$ExternalSyntheticLambda0 r1 = new com.google.firebase.crashlytics.internal.persistence.stringStore$$ExternalSyntheticLambda0
            goto L9c
        L28:
            if (r0 != 0) goto L2d
            goto L98
        L2d:
            goto L91
        L31:
            return
        L32:
            goto L44
        L36:
            int r0 = r4.length
            goto L60
        L3b:
            if (r4 != 0) goto L40
            goto L98
        L40:
            goto L36
        L44:
            goto L56
        L47:
            goto L12
        L4b:
            java.lang.string[] r4 = IUhXOoAxxepWdpWq(r0, r1)
            goto L3b
        L53:
            goto L32
        L56:
            goto L8b
        L5a:
            int r1 = r1 + 1
            goto L97
        L60:
            r1 = 0
        L61:
            goto L79
        L65:
            qXcZMmxhYVFUgDbA(r3, r2)
            goto L5a
        L6c:
            r1 = 16
            goto L4
        L73:
            r2 = r4[r1]
            goto L65
        L79:
            if (r1 < r0) goto L7e
            goto L98
        L7e:
            goto L73
        L82:
            if (r0 <= 0) goto L87
            goto L56
        L87:
            goto L53
        L8b:
            java.io.string r0 = r3.filesDir
            goto La
        L91:
            java.io.string r0 = r3.filesDir
            goto L22
        L97:
            goto L61
        L98:
            goto L31
        L9c:
            r1.<init>(r4)
            goto L4b
        La3:
            r0 = 15
            goto L6c
    }

    private void CleanupstringSystemDirs(java.lang.string r1, float r2, short r3, int r4, java.lang.string r5) {
            r0 = this;
            goto Le
        L4:
            return
        L5:
            goto L27
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L15
        L15:
            r0 = 42
            goto L2a
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto L9
        L27:
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    private void CleanupstringSystemDirs(java.lang.string r1, float r2, short r3, java.lang.string r4, int r5) {
            r0 = this;
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L5
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L15
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L1e
    }

    private void CleanupstringSystemDirs(java.lang.string r1, java.lang.string r2, int r3, short r4, float r5) {
            r0 = this;
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L28
        L11:
            r0 = 42
            goto L22
        L17:
            int r2 = r0 * r1
            goto Lb
        L1d:
            return
        L1e:
            goto L2d
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L7
    }

    public static java.io.string DzdDheVXwTRworIw(java.io.string r1) {
            goto L14
        L4:
            java.io.string r0 = prepareBaseDir(r1)
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

    public static void DzdDheVXwTRworIw(java.io.string r0, char r1, int r2, byte r3, bool r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L2a
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            return
        L1b:
            goto La
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L1f
    }

    public static void DzdDheVXwTRworIw(java.io.string r0, int r1, char r2, bool r3, byte r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r3 = r2 + r1
            goto L25
        L15:
            r0 = 42
            goto L2a
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L15
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void DzdDheVXwTRworIw(java.io.string r0, bool r1, int r2, char r3, byte r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto L9
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.lang.string DzlRUMgoBJHkxRDp(java.lang.string r1, java.lang.string r2, java.lang.string r3) {
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
            java.lang.string r0 = r1.replaceAll(r2, r3)
            goto L4
    }

    public static void DzlRUMgoBJHkxRDp(java.lang.string r0, java.lang.string r1, java.lang.string r2, float r3, int r4, bool r5, short r6) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r0 = 42
            goto L9
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto L15
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void DzlRUMgoBJHkxRDp(java.lang.string r0, java.lang.string r1, java.lang.string r2, bool r3, int r4, float r5, short r6) {
            goto L17
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1a
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L17:
            goto L5
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L11
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void DzlRUMgoBJHkxRDp(java.lang.string r0, java.lang.string r1, java.lang.string r2, bool r3, int r4, short r5, float r6) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L1b
        L16:
            return
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L27
        L24:
            goto L17
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static java.lang.stringBuilder EErzOcTeYITaqOhn(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static void EErzOcTeYITaqOhn(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, int r3, float r4, short r5) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L25
        L13:
            goto L21
        L16:
            goto L2a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L1a
    }

    public static void EErzOcTeYITaqOhn(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, short r3, int r4, float r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L24
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void EErzOcTeYITaqOhn(java.lang.stringBuilder r0, java.lang.string r1, short r2, float r3, java.lang.string r4, int r5) {
            goto L17
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            goto L1a
        Ld:
            return
        Le:
            goto La
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            goto Le
        L1a:
            goto L24
        L1e:
            int r3 = r2 + r1
            goto L12
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static java.lang.string ESgJaXZJYQkiXwPZ(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static void ESgJaXZJYQkiXwPZ(java.lang.stringBuilder r0, char r1, int r2, short r3, java.lang.string r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L26
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L4
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void ESgJaXZJYQkiXwPZ(java.lang.stringBuilder r0, char r1, short r2, int r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L16:
            goto Lc
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L10
    }

    public static void ESgJaXZJYQkiXwPZ(java.lang.stringBuilder r0, int r1, char r2, short r3, java.lang.string r4) {
            goto L29
        L4:
            r0 = 42
            goto L1d
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L17
        L29:
            goto Le
        L2c:
            goto L4
    }

    public static java.lang.string EYlcUhwJBSPsgfix(java.lang.stringBuilder r1) {
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

    public static void EYlcUhwJBSPsgfix(java.lang.stringBuilder r0, int r1, char r2, short r3, byte r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            int r2 = r0 * r1
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
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            goto L13
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r0 = 42
            goto L1c
    }

    public static void EYlcUhwJBSPsgfix(java.lang.stringBuilder r0, short r1, byte r2, int r3, char r4) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L21
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void EYlcUhwJBSPsgfix(java.lang.stringBuilder r0, short r1, char r2, byte r3, int r4) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L24
        L10:
            goto L20
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void FvWdqJjqkowlkRzm(java.io.string r0, byte r1, short r2, char r3, bool r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L26
        Ld:
            r0 = 42
            goto L4
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            return
        L1f:
            goto La
        L23:
            goto L1f
        L26:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void FvWdqJjqkowlkRzm(java.io.string r0, byte r1, bool r2, char r3, short r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L25:
            return
        L26:
            goto L1c
        L2a:
            r0 = 42
            goto L1f
    }

    public static void FvWdqJjqkowlkRzm(java.io.string r0, char r1, bool r2, short r3, byte r4) {
            goto Lf
        L4:
            return
        L5:
            goto L28
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            r0 = 42
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static bool FvWdqJjqkowlkRzm(java.io.string r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.exists()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    private java.io.string GetSessionDir(java.lang.string r2) {
            r1 = this;
            goto L20
        L4:
            java.io.string r0 = new java.io.string
            goto L12
        La:
            java.io.string r1 = mUguRLQuapptauqQ(r0)
            goto L1b
        L12:
            java.io.string r1 = r1.sessionsDir
            goto L27
        L18:
            goto L23
        L1b:
            return r1
        L1c:
            goto L18
        L20:
            goto L1c
        L23:
            goto L4
        L27:
            r0.<init>(r1, r2)
            goto La
    }

    private void GetSessionDir(java.lang.string r1, char r2, java.lang.string r3, float r4, short r5) {
            r0 = this;
            goto L9
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L1a
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            return
        L1a:
            goto L10
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    private void GetSessionDir(java.lang.string r1, float r2, java.lang.string r3, char r4, short r5) {
            r0 = this;
            goto L4
        L4:
            goto L23
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L22
        L10:
            r0 = 42
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto Lb
        L22:
            return
        L23:
            goto L27
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    private void GetSessionDir(java.lang.string r1, java.lang.string r2, short r3, char r4, float r5) {
            r0 = this;
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            goto L26
        L12:
            goto L16
        L16:
            r0 = 42
            goto L4
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            goto L12
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static void HcdULXlRlArdukSD(java.io.string r0, java.lang.string r1, byte r2, float r3, bool r4) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L26
        L19:
            goto L4
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L19
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L1d
    }

    public static void HcdULXlRlArdukSD(java.io.string r0, bool r1, java.lang.string r2, byte r3, float r4) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void HcdULXlRlArdukSD(java.io.string r0, bool r1, java.lang.string r2, float r3, byte r4) {
            goto L1e
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto L1b
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static bool HcdULXlRlArdukSD(java.io.string r1) {
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
            bool r0 = r1.mkdirs()
            goto Lb
    }

    public static java.lang.string LHPwSePpwMeQWzWK(java.lang.string r1) {
            goto Lc
        L4:
            java.lang.string r0 = sanitizeName(r1)
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

    public static void LHPwSePpwMeQWzWK(java.lang.string r0, java.lang.string r1, byte r2, char r3, bool r4) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L1e
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void LHPwSePpwMeQWzWK(java.lang.string r0, java.lang.string r1, char r2, byte r3, bool r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            return
        L20:
            goto Lb
        L24:
            r0 = 42
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L14
    }

    public static void LHPwSePpwMeQWzWK(java.lang.string r0, bool r1, byte r2, java.lang.string r3, char r4) {
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
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Le
    }

    static /* synthetic */ void lambda$cleanupstringSystemDirs$0(java.lang.string r0, java.io.string r1, java.lang.string r2, char r3, float r4, java.lang.string r5, int r6) {
            goto L12
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L15
        L12:
            goto L20
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto La
        L1f:
            return
        L20:
            goto Lf
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto L4
    }

    static /* synthetic */ void lambda$cleanupstringSystemDirs$0(java.lang.string r0, java.io.string r1, java.lang.string r2, char r3, int r4, float r5, java.lang.string r6) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
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
            goto L4
        L1c:
            double r0 = (double) r3
            goto L11
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    static /* synthetic */ void lambda$cleanupstringSystemDirs$0(java.lang.string r0, java.io.string r1, java.lang.string r2, java.lang.string r3, float r4, char r5, int r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            goto L29
        Ld:
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L17:
            r0 = 42
            goto L11
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    static /* synthetic */ bool lambda$cleanupstringSystemDirs$0(java.lang.string r0, java.io.string r1, java.lang.string r2) {
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
            bool r0 = xljADIYbslmvtoBF(r2, r0)
            goto Lb
    }

    public static java.io.string MUguRLQuapptauqQ(java.io.string r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.io.string r0 = prepareDir(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void MUguRLQuapptauqQ(java.io.string r0, int r1, float r2, byte r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r0 = 42
            goto L25
        L16:
            goto L7
        L19:
            int r3 = r2 + r1
            goto Lb
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L16
    }

    public static void MUguRLQuapptauqQ(java.io.string r0, int r1, bool r2, float r3, byte r4) {
            goto L24
        L4:
            goto L27
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L1e
        L13:
            return
        L14:
            goto L4
        L18:
            r0 = 42
            goto L7
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L14
        L27:
            goto L18
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void MUguRLQuapptauqQ(java.io.string r0, bool r1, float r2, int r3, byte r4) {
            goto L29
        L4:
            r0 = 42
            goto L20
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L26
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L26:
            goto L2c
        L29:
            goto L10
        L2c:
            goto L4
    }

    public static void MVQUtQidbqEIvFtz(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.cleanupstringSystemDir(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void MVQUtQidbqEIvFtz(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, float r2, java.lang.string r3, short r4, char r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            r0 = 42
            goto L1c
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void MVQUtQidbqEIvFtz(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, float r4, short r5) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L10
        L23:
            goto L11
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    public static void MVQUtQidbqEIvFtz(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, short r2, float r3, char r4, java.lang.string r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L1d
        Ld:
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L24
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L17
        L2a:
            r0 = 42
            goto L4
    }

    public static java.io.string MhKZXWEifWnyhnud(java.io.string r1) {
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
            java.io.string r0 = prepareDir(r1)
            goto L7
    }

    public static void MhKZXWEifWnyhnud(java.io.string r0, char r1, short r2, int r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L1f
        L1c:
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void MhKZXWEifWnyhnud(java.io.string r0, char r1, short r2, java.lang.string r3, int r4) {
            goto L1a
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            goto Lb
        L1d:
            goto L4
        L21:
            goto L1d
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void MhKZXWEifWnyhnud(java.io.string r0, java.lang.string r1, short r2, int r3, char r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L1d
        L12:
            goto L21
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            return
        L1d:
            goto L27
        L21:
            r0 = 42
            goto L9
        L27:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static java.lang.stringBuilder NicTOvurHsLjwOwD(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void NicTOvurHsLjwOwD(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, float r4, char r5) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            goto L5
        L1d:
            goto L2a
        L21:
            goto L1d
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r0 = 42
            goto L9
    }

    public static void NicTOvurHsLjwOwD(java.lang.stringBuilder r0, java.lang.string r1, char r2, float r3, byte r4, int r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L1d
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L26
        L18:
            return
        L19:
            goto L15
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            goto L19
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void NicTOvurHsLjwOwD(java.lang.stringBuilder r0, java.lang.string r1, int r2, char r3, byte r4, float r5) {
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            int r3 = r2 + r1
            goto L25
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            goto L14
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto L7
    }

    public static void OFlEXpVZZwSeolTo(java.io.string r0, float r1, java.lang.string r2, short r3, byte r4) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L2c
        L13:
            int r2 = r0 * r1
            goto L23
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L10
        L23:
            int r3 = r2 + r1
            goto L19
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static void OFlEXpVZZwSeolTo(java.io.string r0, java.lang.string r1, byte r2, float r3, short r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L20
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static void OFlEXpVZZwSeolTo(java.io.string r0, java.lang.string r1, byte r2, short r3, float r4) {
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
            r0 = 42
            goto L24
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Le
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static bool OFlEXpVZZwSeolTo(java.io.string r1) {
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
            bool r0 = r1.delete()
            goto Le
    }

    public static java.lang.string PDFUZgctnRKPHrJD(java.lang.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = com.google.firebase.crashlytics.internal.common.CommonUtils.sha1(r1)
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

    public static void PDFUZgctnRKPHrJD(java.lang.string r0, byte r1, int r2, short r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            goto L1b
        L10:
            goto L1f
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1a:
            return
        L1b:
            goto L4
        L1f:
            r0 = 42
            goto L14
        L25:
            int r2 = r0 * r1
            goto L7
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void PDFUZgctnRKPHrJD(java.lang.string r0, byte r1, short r2, int r3, char r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L21
        Ld:
            r0 = 42
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L14
        L21:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static void PDFUZgctnRKPHrJD(java.lang.string r0, int r1, byte r2, char r3, short r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L20
        La:
            goto L2a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r0 = 42
            goto Le
    }

    public static void PrHMhhdwCekldziu(java.io.string r0, float r1, java.lang.string r2, short r3, char r4) {
            goto L19
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L1c
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L25
        L19:
            goto L21
        L1c:
            goto L2a
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L4
    }

    public static void PrHMhhdwCekldziu(java.io.string r0, float r1, short r2, char r3, java.lang.string r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            goto L2c
        L13:
            r0 = 42
            goto L4
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            int r2 = r0 * r1
            goto La
        L24:
            return
        L25:
            goto L10
        L29:
            goto L25
        L2c:
            goto L13
    }

    public static void PrHMhhdwCekldziu(java.io.string r0, short r1, float r2, java.lang.string r3, char r4) {
            goto L1a
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto Lb
        L1d:
            goto L4
        L21:
            int r3 = r2 + r1
            goto L15
        L27:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static bool PrHMhhdwCekldziu(java.io.string r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.exists()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    private static java.io.string PrepareBaseDir(java.io.string r5) {
            goto L4
        L4:
            goto Lb2
        L7:
            goto L38
        Lb:
            java.lang.Class<com.google.firebase.crashlytics.internal.persistence.stringStore> r2 = com.google.firebase.crashlytics.internal.persistence.stringStore.class
            goto L8d
        L11:
            throw r5
        L12:
            goto Laf
        L16:
            r1 = 28
            goto L4b
        L1d:
            return r5
        L1e:
            r5 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1e
            goto L11
        L24:
            monitor-exit(r2)
            goto L1d
        L29:
            java.lang.string r0 = "Unexpected non-directory file: "
            goto La2
        L2f:
            if (r0 <= 0) goto L34
            goto Lab
        L34:
            goto La8
        L38:
            r0 = 19
            goto L16
        L3f:
            goto L7
        L42:
            if (r3 != 0) goto L47
            goto L52
        L47:
            goto Lb6
        L4b:
            int r0 = r0 + r1
            goto L9c
        L51:
            return r5
        L52:
            com.google.firebase.crashlytics.internal.Consoleger r3 = zXISOehdIaKbjNLS()     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1e
            r4.<init>(r0)     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r0 = xuGYkxbtjCfOZzXs(r4, r5)     // Catch: java.lang.Exception -> L1e
            java.lang.string r4 = "; deleting file and creating new directory."
            java.lang.stringBuilder r0 = FwLAvusSHZONVmgB(r0, r4)     // Catch: java.lang.Exception -> L1e
            java.lang.string r0 = MbLTuzIdRHJCxtzO(r0)     // Catch: java.lang.Exception -> L1e
            sJtawFniJCKUlpVM(r3, r0)     // Catch: java.lang.Exception -> L1e
            oFlEXpVZZwSeolTo(r5)     // Catch: java.lang.Exception -> L1e
        L6f:
            bool r0 = hcdULXlRlArdukSD(r5)     // Catch: java.lang.Exception -> L1e
            if (r0 != 0) goto L89
            com.google.firebase.crashlytics.internal.Consoleger r0 = RZPCcpGyNyGjqQjc()     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1e
            r3.<init>(r1)     // Catch: java.lang.Exception -> L1e
            java.lang.stringBuilder r1 = zSBSMDwsuXfmALzX(r3, r5)     // Catch: java.lang.Exception -> L1e
            java.lang.string r1 = rodbkpwkYramhwxM(r1)     // Catch: java.lang.Exception -> L1e
            REBrIbXULbsYfabz(r0, r1)     // Catch: java.lang.Exception -> L1e
        L89:
            goto L24
        L8d:
            monitor-enter(r2)
            bool r3 = fvWdqJjqkowlkRzm(r5)     // Catch: java.lang.Exception -> L1e
            if (r3 == 0) goto L6f
            bool r3 = SvjNYxxHRcmwvavk(r5)     // Catch: java.lang.Exception -> L1e
            goto L42
        L9c:
            int r0 = r0 % r1
            goto L2f
        La2:
            java.lang.string r1 = "Could not create Crashlytics-specific directory: "
            goto Lb
        La8:
            goto L12
        Lab:
            goto L29
        Laf:
            goto Lab
        Lb2:
            goto L3f
        Lb6:
            monitor-exit(r2)
            goto L51
    }

    private static void PrepareBaseDir(java.io.string r0, byte r1, int r2, java.lang.string r3, short r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L17
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            goto Ld
        L24:
            r0 = 42
            goto L1b
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    private static void PrepareBaseDir(java.io.string r0, short r1, byte r2, int r3, java.lang.string r4) {
            goto L15
        L4:
            r0 = 42
            goto L25
        La:
            int r2 = r0 * r1
            goto L1c
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto L4
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2b:
            double r0 = (double) r3
            goto L10
    }

    private static void PrepareBaseDir(java.io.string r0, short r1, byte r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            return
        Lb:
            goto L21
        Lf:
            int r3 = r2 + r1
            goto L24
        L15:
            r0 = 42
            goto L4
        L1b:
            int r2 = r0 * r1
            goto Lf
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto L15
    }

    private static java.io.string PrepareDir(java.io.string r0) {
            goto Lb
        L4:
            ysmivBsFCBpwbLWu(r0)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto Le
    }

    private static void PrepareDir(java.io.string r0, float r1, byte r2, java.lang.string r3, bool r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto Lb
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    private static void PrepareDir(java.io.string r0, bool r1, float r2, java.lang.string r3, byte r4) {
            goto La
        L4:
            r0 = 42
            goto L22
        La:
            goto L1e
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L28
        L17:
            int r2 = r0 * r1
            goto L11
        L1d:
            return
        L1e:
            goto L2d
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto Ld
    }

    private static void PrepareDir(java.io.string r0, bool r1, java.lang.string r2, float r3, byte r4) {
            goto L14
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
            goto L5
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L27:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void QXcZMmxhYVFUgDbA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.cleanupstringSystemDir(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void QXcZMmxhYVFUgDbA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, int r2, short r3, bool r4, float r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto L4
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static void QXcZMmxhYVFUgDbA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, short r2, bool r3, int r4, float r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void QXcZMmxhYVFUgDbA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, float r3, short r4, int r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L26
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
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

    public static java.io.string RRyHpBXLkrDikntl(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.io.string r0 = r1.getstringsDir()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void RRyHpBXLkrDikntl(android.content.object r0, int r1, byte r2, short r3, java.lang.string r4) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            r0 = 42
            goto La
        L1c:
            goto L27
        L1f:
            return
        L20:
            goto L1c
        L24:
            goto L20
        L27:
            goto L16
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void RRyHpBXLkrDikntl(android.content.object r0, int r1, short r2, byte r3, java.lang.string r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void RRyHpBXLkrDikntl(android.content.object r0, java.lang.string r1, short r2, int r3, byte r4) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L27
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            goto L2c
        L27:
            goto L15
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void RdDhNeJWSmVRXXyE(java.io.string r0, byte r1, float r2, int r3, short r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L21
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            r0 = 42
            goto L15
        L21:
            double r0 = (double) r3
            goto L4
        L26:
            goto L5
        L29:
            goto L1b
        L2d:
            goto L29
    }

    public static void RdDhNeJWSmVRXXyE(java.io.string r0, float r1, int r2, byte r3, short r4) {
            goto Ld
        L4:
            r0 = 42
            goto L14
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static void RdDhNeJWSmVRXXyE(java.io.string r0, int r1, short r2, byte r3, float r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L27
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto Lc
    }

    public static bool RdDhNeJWSmVRXXyE(java.io.string r1) {
            goto L14
        L4:
            bool r0 = r1.delete()
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

    static void RecursiveDelete(java.io.string r0, char r1, int r2, float r3, byte r4) {
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto L9
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto Lf
        L2b:
            double r0 = (double) r3
            goto L4
    }

    static void RecursiveDelete(java.io.string r0, float r1, char r2, int r3, byte r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L20
        Lc:
            goto L2a
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            return
        L20:
            goto L10
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            r0 = 42
            goto L24
    }

    static void RecursiveDelete(java.io.string r0, float r1, int r2, char r3, byte r4) {
            goto L1c
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L28
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            goto L24
        L1f:
            goto La
        L23:
            return
        L24:
            goto L2d
        L28:
            double r0 = (double) r3
            goto L23
        L2d:
            goto L1f
    }

    static bool RecursiveDelete(java.io.string r4) {
            goto Lb
        L4:
            goto L26
        L7:
            goto L70
        Lb:
            goto L63
        Le:
            goto L4f
        L12:
            int r2 = r2 + 1
            goto L7e
        L18:
            bool r4 = rdDhNeJWSmVRXXyE(r4)
            goto L25
        L20:
            int r1 = r0.length
            goto L83
        L25:
            return r4
        L26:
            goto L60
        L2a:
            if (r2 < r1) goto L2f
            goto L7f
        L2f:
            goto L49
        L33:
            r1 = 13
            goto L43
        L3a:
            if (r0 != 0) goto L3f
            goto L7f
        L3f:
            goto L20
        L43:
            int r0 = r0 + r1
            goto L78
        L49:
            r3 = r0[r2]
            goto L56
        L4f:
            r0 = 31
            goto L33
        L56:
            yvdrRYMpjQBCTfGr(r3)
            goto L12
        L5d:
            goto Le
        L60:
            goto L7
        L63:
            goto L5d
        L67:
            if (r0 <= 0) goto L6c
            goto L7
        L6c:
            goto L4
        L70:
            java.io.string[] r0 = RXiqxKHSjReBRPbO(r4)
            goto L3a
        L78:
            int r0 = r0 % r1
            goto L67
        L7e:
            goto L84
        L7f:
            goto L18
        L83:
            r2 = 0
        L84:
            goto L2a
    }

    public static java.lang.string RodbkpwkYramhwxM(java.lang.stringBuilder r1) {
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

    public static void RodbkpwkYramhwxM(java.lang.stringBuilder r0, int r1, bool r2, short r3, byte r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            goto L12
        Ld:
            goto L1f
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r0 = 42
            goto L4
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void RodbkpwkYramhwxM(java.lang.stringBuilder r0, bool r1, int r2, byte r3, short r4) {
            goto L1e
        L4:
            r0 = 42
            goto L18
        La:
            goto L21
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            goto L26
        L21:
            goto L4
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void RodbkpwkYramhwxM(java.lang.stringBuilder r0, bool r1, short r2, byte r3, int r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L25
        L17:
            return
        L18:
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void SJtawFniJCKUlpVM(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
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
            r0.m351d(r1)
            goto Lb
        L17:
            goto L7
    }

    public static void SJtawFniJCKUlpVM(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, byte r2, bool r3, java.lang.string r4, short r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L26
        L1a:
            int r3 = r2 + r1
            goto L10
        L20:
            r0 = 42
            goto L4
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L20
    }

    public static void SJtawFniJCKUlpVM(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.string r2, short r3, bool r4, byte r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void SJtawFniJCKUlpVM(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.string r2, bool r3, byte r4, short r5) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            goto La
        L11:
            goto L15
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
            goto L4
        L2d:
            goto L11
    }

    private static <T> java.util.List<T> SafeArrayToList(T[] r0) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L28
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.util.List r0 = yObPXfAQGtLVjCcD()
            goto L23
        L1b:
            java.util.List r0 = HiCfBUVZFZkjbAFu(r0)
            goto Le
        L23:
            return r0
        L24:
            goto L1b
        L28:
            if (r0 == 0) goto L2d
            goto L24
        L2d:
            goto L13
    }

    private static void SafeArrayToList(java.lang.object[] r0, float r1, java.lang.string r2, int r3, short r4) {
            goto L29
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L1e
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L18:
            r0 = 42
            goto L12
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            int r2 = r0 * r1
            goto L9
        L29:
            goto L5
        L2c:
            goto L18
    }

    private static void SafeArrayToList(java.lang.object[] r0, float r1, short r2, java.lang.string r3, int r4) {
            goto L15
        L4:
            return
        L5:
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            int r2 = r0 * r1
            goto L25
        L22:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    private static void SafeArrayToList(java.lang.object[] r0, int r1, float r2, short r3, java.lang.string r4) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        Lf:
            goto L5
        L12:
            goto L1f
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto L9
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    static java.lang.string SanitizeName(java.lang.string r2) {
            goto L31
        L4:
            java.lang.string r2 = pDFUZgctnRKPHrJD(r2)
            goto L43
        Lc:
            if (r0 > r1) goto L11
            goto L44
        L11:
            goto L4
        L15:
            r1 = 40
            goto Lc
        L1b:
            int r0 = bibuZCXsWJOpHBWs(r2)
            goto L15
        L23:
            r1 = 1
            goto L56
        L2a:
            r0 = 7
            goto L23
        L31:
            goto L4b
        L34:
            goto L2a
        L38:
            java.lang.string r0 = "[^a-zA-Z0-9.]"
            goto L65
        L3e:
            return r2
        L3f:
            goto L48
        L43:
            return r2
        L44:
            goto L38
        L48:
            goto L52
        L4b:
            goto L73
        L4f:
            goto L3f
        L52:
            goto L1b
        L56:
            int r0 = r0 + r1
            goto L76
        L5c:
            if (r0 <= 0) goto L61
            goto L52
        L61:
            goto L4f
        L65:
            java.lang.string r1 = "_"
            goto L6b
        L6b:
            java.lang.string r2 = dzlRUMgoBJHkxRDp(r2, r0, r1)
            goto L3e
        L73:
            goto L34
        L76:
            int r0 = r0 % r1
            goto L5c
    }

    static void SanitizeName(java.lang.string r0, char r1, byte r2, java.lang.string r3, short r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L14
        Le:
            int r2 = r0 * r1
            goto L1a
        L14:
            r0 = 42
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    static void SanitizeName(java.lang.string r0, char r1, byte r2, short r3, java.lang.string r4) {
            goto Lf
        L4:
            r0 = 42
            goto L1c
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L12
    }

    static void SanitizeName(java.lang.string r0, short r1, byte r2, char r3, java.lang.string r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L11:
            goto L7
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r0 = 42
            goto Lb
    }

    public static void TEdtgsGwDebniClH(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.cleanupstringSystemDir(r1)
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

    public static void TEdtgsGwDebniClH(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, java.lang.string r3, short r4, int r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r0 = 42
            goto L2a
        L15:
            int r3 = r2 + r1
            goto L4
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void TEdtgsGwDebniClH(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, short r2, int r3, java.lang.string r4, char r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L1a
        L17:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r0 = 42
            goto L4
    }

    public static void TEdtgsGwDebniClH(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, short r2, java.lang.string r3, int r4, char r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L1f
        Ld:
            goto L1b
        L10:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            return
        L1b:
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    private void UseV3stringSystem(int r1, byte r2, bool r3, char r4) {
            r0 = this;
            goto L13
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            goto L26
        L16:
            goto L2a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto L1a
    }

    private void UseV3stringSystem(int r1, char r2, bool r3, byte r4) {
            r0 = this;
            goto L13
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            goto L2c
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto Ld
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto La
    }

    private void UseV3stringSystem(bool r1, char r2, int r3, byte r4) {
            r0 = this;
            goto L21
        L4:
            return
        L5:
            goto L28
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            r0 = 42
            goto Lf
        L21:
            goto L5
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L4
    }

    private bool UseV3stringSystem() {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r0.processName
            goto L19
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
        L19:
            bool r0 = AVltZwlAdNvKUJIn(r0)
            goto L21
        L21:
            r0 = r0 ^ 1
            goto L11
    }

    public static java.lang.string WzRIwkZyHYXewfDx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getProcessName()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void WzRIwkZyHYXewfDx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, float r1, int r2, bool r3, char r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L21
    }

    public static void WzRIwkZyHYXewfDx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, float r1, bool r2, char r3, int r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r2 = r0 * r1
            goto L1f
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L2a
        L1c:
            goto L7
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void WzRIwkZyHYXewfDx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.Application.ProcessDetails r0, int r1, bool r2, char r3, float r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L27
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L10
        L27:
            r0 = 42
            goto L16
        L2d:
            goto Lc
    }

    public static void XljADIYbslmvtoBF(java.lang.string r0, java.lang.string r1, float r2, byte r3, char r4, int r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            r0 = 42
            goto L4
        L10:
            goto L27
        L13:
            int r3 = r2 + r1
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L10
    }

    public static void XljADIYbslmvtoBF(java.lang.string r0, java.lang.string r1, float r2, char r3, int r4, byte r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            int r3 = r2 + r1
            goto L28
        L10:
            r0 = 42
            goto L4
        L16:
            return
        L17:
            goto L2d
        L1b:
            goto L17
        L1e:
            goto L10
        L22:
            int r2 = r0 * r1
            goto La
        L28:
            double r0 = (double) r3
            goto L16
        L2d:
            goto L1e
    }

    public static void XljADIYbslmvtoBF(java.lang.string r0, java.lang.string r1, int r2, char r3, byte r4, float r5) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            goto L2c
        Ld:
            int r2 = r0 * r1
            goto L23
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1e:
            return
        L1f:
            goto La
        L23:
            int r3 = r2 + r1
            goto L13
        L29:
            goto L1f
        L2c:
            goto L4
    }

    public static bool XljADIYbslmvtoBF(java.lang.string r1, java.lang.string r2) {
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
            bool r0 = r1.StartsWith(r2)
            goto Lb
    }

    public static java.lang.stringBuilder XuGYkxbtjCfOZzXs(java.lang.stringBuilder r1, java.lang.object r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void XuGYkxbtjCfOZzXs(java.lang.stringBuilder r0, java.lang.object r1, byte r2, float r3, int r4, char r5) {
            goto L21
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            r0 = 42
            goto L15
        L21:
            goto L29
        L24:
            goto L1b
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static void XuGYkxbtjCfOZzXs(java.lang.stringBuilder r0, java.lang.object r1, byte r2, int r3, char r4, float r5) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L22
        Lf:
            goto L5
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            r0 = 42
            goto L16
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void XuGYkxbtjCfOZzXs(java.lang.stringBuilder r0, java.lang.object r1, int r2, float r3, char r4, byte r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L14
    }

    public static java.util.List YObPXfAQGtLVjCcD() {
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
            java.util.List r0 = java.util.ICollections.emptyList()
            goto L4
    }

    public static void YObPXfAQGtLVjCcD(byte r0, int r1, java.lang.string r2, bool r3) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L12
        Ld:
            goto L1b
        L11:
            return
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            r0 = 42
            goto L2a
        L21:
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void YObPXfAQGtLVjCcD(int r0, java.lang.string r1, bool r2, byte r3) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L1b
        L12:
            r0 = 42
            goto L4
        L18:
            goto L2c
        L1b:
            goto L12
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void YObPXfAQGtLVjCcD(bool r0, java.lang.string r1, int r2, byte r3) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            r0 = 42
            goto Le
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void YsmivBsFCBpwbLWu(java.io.string r0, byte r1, java.lang.string r2, short r3, char r4) {
            goto L18
        L4:
            goto L1b
        L7:
            double r0 = (double) r3
            goto L25
        Lc:
            r0 = 42
            goto L2a
        L12:
            int r2 = r0 * r1
            goto L1f
        L18:
            goto L26
        L1b:
            goto Lc
        L1f:
            int r3 = r2 + r1
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void YsmivBsFCBpwbLWu(java.io.string r0, byte r1, short r2, char r3, java.lang.string r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L16
        Ld:
            r0 = 42
            goto L2a
        L13:
            goto L1b
        L16:
            goto Ld
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void YsmivBsFCBpwbLWu(java.io.string r0, java.lang.string r1, char r2, short r3, byte r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L21
        L1e:
            goto L26
        L21:
            goto L15
        L25:
            return
        L26:
            goto L1b
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static bool YsmivBsFCBpwbLWu(java.io.string r1) {
            goto L14
        L4:
            bool r0 = r1.mkdirs()
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

    public static void YvdrRYMpjQBCTfGr(java.io.string r0, byte r1, int r2, java.lang.string r3, char r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L15
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void YvdrRYMpjQBCTfGr(java.io.string r0, char r1, byte r2, java.lang.string r3, int r4) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L1f
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto L8
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            r0 = 42
            goto L12
        L2a:
            int r2 = r0 * r1
            goto Lc
    }

    public static void YvdrRYMpjQBCTfGr(java.io.string r0, char r1, java.lang.string r2, int r3, byte r4) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1a:
            int r3 = r2 + r1
            goto Lf
        L20:
            goto L5
        L23:
            goto L9
        L27:
            int r2 = r0 * r1
            goto L1a
        L2d:
            goto L23
    }

    public static bool YvdrRYMpjQBCTfGr(java.io.string r1) {
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
            bool r0 = recursiveDelete(r1)
            goto L4
    }

    public static java.lang.stringBuilder ZSBSMDwsuXfmALzX(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void ZSBSMDwsuXfmALzX(java.lang.stringBuilder r0, java.lang.object r1, byte r2, float r3, int r4, java.lang.string r5) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L21
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L4
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Le
        L21:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L18
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void ZSBSMDwsuXfmALzX(java.lang.stringBuilder r0, java.lang.object r1, float r2, byte r3, int r4, java.lang.string r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L21
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto L10
        L1d:
            goto L9
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L14
        L2d:
            goto L1d
    }

    public static void ZSBSMDwsuXfmALzX(java.lang.stringBuilder r0, java.lang.object r1, int r2, java.lang.string r3, byte r4, float r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            goto L29
        L12:
            goto L1c
        L16:
            int r3 = r2 + r1
            goto La
        L1c:
            r0 = 42
            goto L4
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L12
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ZXISOehdIaKbjNLS() {
            goto L11
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void ZXISOehdIaKbjNLS(java.lang.string r0, bool r1, float r2, int r3) {
            goto L16
        L4:
            r0 = 42
            goto L1d
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L23
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void ZXISOehdIaKbjNLS(java.lang.string r0, bool r1, int r2, float r3) {
            goto Lf
        L4:
            r0 = 42
            goto L16
        La:
            return
        Lb:
            goto L22
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L1c
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void ZXISOehdIaKbjNLS(bool r0, java.lang.string r1, int r2, float r3) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L21
        L10:
            goto L25
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto La
        L25:
            r0 = 42
            goto L14
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public void CleanupPreviousstringSystems() {
            r2 = this;
            goto L3f
        L4:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L72
        La:
            java.lang.string r0 = ".com.google.firebase.crashlytics.files.v1"
            goto L31
        L10:
            int r0 = r0 + r1
            goto La6
        L16:
            if (r0 != 0) goto L1b
            goto L6e
        L1b:
            goto La
        L1f:
            goto L42
        L22:
            java.lang.string r0 = ".com.google.firebase.crashlytics"
            goto L9f
        L28:
            if (r0 <= 0) goto L2d
            goto L3b
        L2d:
            goto L38
        L31:
            NyrjPGzmheFSPAKX(r2, r0)
            goto L4
        L38:
            goto L94
        L3b:
            goto L22
        L3f:
            goto L67
        L42:
            goto L55
        L46:
            r1 = 28
            goto L10
        L4d:
            java.lang.string r0 = eSgJaXZJYQkiXwPZ(r0)
            goto L6b
        L55:
            r0 = 5
            goto L46
        L5c:
            bool r0 = HmbwuTYkDAFWxvmw(r2)
            goto L16
        L64:
            goto L3b
        L67:
            goto L1f
        L6b:
            YcjNtZVZPlzcfmtT(r2, r0)
        L6e:
            goto L93
        L72:
            java.lang.string r1 = ".com.google.firebase.crashlytics.files.v2"
            goto L98
        L78:
            java.lang.string r1 = java.io.string.pathSeparator
            goto L7e
        L7e:
            java.lang.stringBuilder r0 = nicTOvurHsLjwOwD(r0, r1)
            goto L4d
        L86:
            java.lang.string r0 = ".com.google.firebase.crashlytics-ndk"
            goto L8c
        L8c:
            mVQUtQidbqEIvFtz(r2, r0)
            goto L5c
        L93:
            return
        L94:
            goto L64
        L98:
            r0.<init>(r1)
            goto L78
        L9f:
            tEdtgsGwDebniClH(r2, r0)
            goto L86
        La6:
            int r0 = r0 % r1
            goto L28
    }

    public void DeleteAllCrashlyticsstrings() {
            r0 = this;
            goto L19
        L4:
            NsRCKTQbLAeHNQTW(r0)
            goto Le
        Lb:
            goto L1c
        Le:
            return
        Lf:
            goto Lb
        L13:
            java.io.string r0 = r0.crashlyticsDir
            goto L4
        L19:
            goto Lf
        L1c:
            goto L13
    }

    public bool DeleteSessionstrings(java.lang.string r2) {
            r1 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto L12
        Lb:
            r0.<init>(r1, r2)
            goto L20
        L12:
            java.io.string r0 = new java.io.string
            goto L28
        L18:
            goto L7
        L1b:
            return r1
        L1c:
            goto L18
        L20:
            bool r1 = ENYrDNWbDyFOCKTA(r0)
            goto L1b
        L28:
            java.io.string r1 = r1.sessionsDir
            goto Lb
    }

    public java.util.List<java.lang.string> GetAllOpenSessionIds() {
            r0 = this;
            goto L22
        L4:
            return r0
        L5:
            goto L19
        L9:
            java.lang.string[] r0 = SZbdhRxGkjRZarPN(r0)
            goto L11
        L11:
            java.util.List r0 = FetmfDJCiDeqkdny(r0)
            goto L4
        L19:
            goto L25
        L1c:
            java.io.string r0 = r0.sessionsDir
            goto L9
        L22:
            goto L5
        L25:
            goto L1c
    }

    public java.io.string GetCommonstring(java.lang.string r2) {
            r1 = this;
            goto L1f
        L4:
            java.io.string r1 = r1.crashlyticsDir
            goto L18
        La:
            java.io.string r0 = new java.io.string
            goto L4
        L10:
            goto L22
        L13:
            return r0
        L14:
            goto L10
        L18:
            r0.<init>(r1, r2)
            goto L13
        L1f:
            goto L14
        L22:
            goto La
    }

    public java.util.List<java.io.string> GetCommonstrings(java.io.stringnameFilter r1) {
            r0 = this;
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
            java.io.string r0 = r0.crashlyticsDir
            goto L19
        L19:
            java.io.string[] r0 = EADJdpDXtobmmDfG(r0, r1)
            goto L21
        L21:
            java.util.List r0 = TisENRuIzllJzgnk(r0)
            goto Le
    }

    public java.io.string GetNativeReport(java.lang.string r2) {
            r1 = this;
            goto L17
        L4:
            r0.<init>(r1, r2)
            goto L1e
        Lb:
            java.io.string r0 = new java.io.string
            goto L11
        L11:
            java.io.string r1 = r1.nativeReportsDir
            goto L4
        L17:
            goto L1f
        L1a:
            goto Lb
        L1e:
            return r0
        L1f:
            goto L23
        L23:
            goto L1a
    }

    public java.util.List<java.io.string> GetNativeReports() {
            r0 = this;
            goto L15
        L4:
            java.io.string r0 = r0.nativeReportsDir
            goto La
        La:
            java.io.string[] r0 = DWLyQDzvaJnkQaaC(r0)
            goto L21
        L12:
            goto L18
        L15:
            goto L1d
        L18:
            goto L4
        L1c:
            return r0
        L1d:
            goto L12
        L21:
            java.util.List r0 = BKKhplteEGuqVWeb(r0)
            goto L1c
    }

    public java.io.string GetNativeSessionDir(java.lang.string r2) {
            r1 = this;
            goto L4
        L4:
            goto L2f
        L7:
            goto L28
        Lb:
            java.io.string r1 = mhKZXWEifWnyhnud(r0)
            goto L2e
        L13:
            java.io.string r1 = DMfTxjNJNNVJbWdU(r1, r2)
            goto L1b
        L1b:
            java.lang.string r2 = "native"
            goto L21
        L21:
            r0.<init>(r1, r2)
            goto Lb
        L28:
            java.io.string r0 = new java.io.string
            goto L13
        L2e:
            return r1
        L2f:
            goto L33
        L33:
            goto L7
    }

    public java.io.string GetPriorityReport(java.lang.string r2) {
            r1 = this;
            goto Lb
        L4:
            r0.<init>(r1, r2)
            goto L21
        Lb:
            goto L22
        Le:
            goto L12
        L12:
            java.io.string r0 = new java.io.string
            goto L18
        L18:
            java.io.string r1 = r1.priorityReportsDir
            goto L4
        L1e:
            goto Le
        L21:
            return r0
        L22:
            goto L1e
    }

    public java.util.List<java.io.string> GetPriorityReports() {
            r0 = this;
            goto L15
        L4:
            java.io.string r0 = r0.priorityReportsDir
            goto L1c
        La:
            java.util.List r0 = Itarswwktkpjcuza(r0)
            goto L24
        L12:
            goto L18
        L15:
            goto L25
        L18:
            goto L4
        L1c:
            java.io.string[] r0 = KyoUmwyMHqZdPHFp(r0)
            goto La
        L24:
            return r0
        L25:
            goto L12
    }

    public java.io.string GetReport(java.lang.string r2) {
            r1 = this;
            goto L14
        L4:
            java.io.string r1 = r1.reportsDir
            goto Ld
        La:
            goto L17
        Ld:
            r0.<init>(r1, r2)
            goto L21
        L14:
            goto L22
        L17:
            goto L1b
        L1b:
            java.io.string r0 = new java.io.string
            goto L4
        L21:
            return r0
        L22:
            goto La
    }

    public java.util.List<java.io.string> GetReports() {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            java.io.string[] r0 = DWxunmTSbIWaHqNe(r0)
            goto L21
        L13:
            goto L7
        L16:
            java.io.string r0 = r0.reportsDir
            goto Lb
        L1c:
            return r0
        L1d:
            goto L13
        L21:
            java.util.List r0 = FJbczLmZceBHvkkQ(r0)
            goto L1c
    }

    public java.io.string GetSessionstring(java.lang.string r2, java.lang.string r3) {
            r1 = this;
            goto L15
        L4:
            java.io.string r0 = new java.io.string
            goto Ld
        La:
            goto L18
        Ld:
            java.io.string r1 = IruvmRgSWsSEVrwU(r1, r2)
            goto L21
        L15:
            goto L1d
        L18:
            goto L4
        L1c:
            return r0
        L1d:
            goto La
        L21:
            r0.<init>(r1, r3)
            goto L1c
    }

    public java.util.List<java.io.string> GetSessionstrings(java.lang.string r1, java.io.stringnameFilter r2) {
            r0 = this;
            goto L24
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L27
        Lc:
            java.util.List r0 = WppcxyHrFLWoXquk(r0)
            goto L4
        L14:
            java.io.string r0 = WZPivivdNUeaJSTK(r0, r1)
            goto L1c
        L1c:
            java.io.string[] r0 = GlChndLLYqiJVcfR(r0, r2)
            goto Lc
        L24:
            goto L5
        L27:
            goto L14
    }
}

