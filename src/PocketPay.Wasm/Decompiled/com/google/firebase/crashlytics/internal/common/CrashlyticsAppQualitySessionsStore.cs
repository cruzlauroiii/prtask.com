namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class CrashlyticsAppQualitySessionsStore {
    private static readonly java.lang.string AQS_SESSION_ID_FILENAME_PREFIX = "aqs.";
    private static readonly java.io.stringnameFilter AQS_SESSION_ID_FILE_FILTER = null;
    private static readonly java.util.Comparator<java.io.string> FILE_RECENCY_COMPARATOR = null;
    private java.lang.string appQualitySessionId;
    private readonly com.google.firebase.crashlytics.internal.persistence.stringStore fileStore;
    private java.lang.string sessionId;

    static {
            goto L2f
        L4:
            com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore.FILE_RECENCY_COMPARATOR = r0
            goto L24
        La:
            r0.<init>()
            goto L17
        L11:
            com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore$$ExternalSyntheticLambda0 r0 = new com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore$$ExternalSyntheticLambda0
            goto La
        L17:
            com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore.AQS_SESSION_ID_FILE_FILTER = r0
            goto L29
        L1d:
            r0.<init>()
            goto L4
        L24:
            return
        L25:
            goto L36
        L29:
            com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore$$ExternalSyntheticLambda1 r0 = new com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore$$ExternalSyntheticLambda1
            goto L1d
        L2f:
            goto L25
        L32:
            goto L11
        L36:
            goto L32
    }

    CrashlyticsAppQualitySessionsStore(com.google.firebase.crashlytics.internal.persistence.stringStore r2) {
            r1 = this;
            goto L2a
        L4:
            r1.<init>()
            goto L1f
        Lb:
            r1.fileStore = r2
            goto L11
        L11:
            return
        L12:
            goto L1c
        L16:
            r1.appQualitySessionId = r0
            goto Lb
        L1c:
            goto L2d
        L1f:
            r0 = 0
            goto L24
        L24:
            r1.sessionId = r0
            goto L16
        L2a:
            goto L12
        L2d:
            goto L4
    }

    public static java.io.string BqaAOFKtNBDJLmAA(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.io.string r0 = r1.getSessionstring(r2, r3)
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

    public static void BqaAOFKtNBDJLmAA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, bool r4, short r5, java.lang.string r6) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L4
        L27:
            int r3 = r2 + r1
            goto La
        L2d:
            goto L1d
    }

    public static void BqaAOFKtNBDJLmAA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, short r3, bool r4, java.lang.string r5, char r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L12
        Ld:
            goto L1f
        L11:
            return
        L12:
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void BqaAOFKtNBDJLmAA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, bool r3, java.lang.string r4, char r5, short r6) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L21
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L9
        L2a:
            r0 = 42
            goto Lc
    }

    public static java.util.List CubNrTlAOTXxxGnE(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2, java.io.stringnameFilter r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.List r0 = r1.getSessionstrings(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void CubNrTlAOTXxxGnE(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.io.stringnameFilter r2, byte r3, bool r4, java.lang.string r5, char r6) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1c:
            goto Lc
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void CubNrTlAOTXxxGnE(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.io.stringnameFilter r2, char r3, bool r4, byte r5, java.lang.string r6) {
            goto La
        L4:
            r0 = 42
            goto L22
        La:
            goto L29
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L28
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void CubNrTlAOTXxxGnE(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.io.stringnameFilter r2, char r3, bool r4, java.lang.string r5, byte r6) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L10:
            int r3 = r2 + r1
            goto L1b
        L16:
            return
        L17:
            goto L20
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L10
        L29:
            goto L17
        L2c:
            goto L4
    }

    public static int EVtPpLypxVPgjAXD(long r1, long r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = java.lang.long.compare(r1, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void EVtPpLypxVPgjAXD(long r0, long r2, byte r4, int r5, char r6, java.lang.string r7) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L18
        L12:
            r0 = 42
            goto L2a
        L18:
            return
        L19:
            goto L4
        L1d:
            int r2 = r0 * r1
            goto L7
        L23:
            goto L19
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void EVtPpLypxVPgjAXD(long r0, long r2, char r4, java.lang.string r5, int r6, byte r7) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            int r3 = r2 + r1
            goto L10
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L29:
            goto L19
        L2c:
            goto L4
    }

    public static void EVtPpLypxVPgjAXD(long r0, long r2, java.lang.string r4, int r5, char r6, byte r7) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            return
        L16:
            goto L20
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L1a
        L29:
            goto L16
        L2c:
            goto L23
    }

    public static void GDsWdjSWckaULMcU(java.lang.string r0, java.lang.string r1, byte r2, bool r3, java.lang.string r4, float r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L21
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L25
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void GDsWdjSWckaULMcU(java.lang.string r0, java.lang.string r1, bool r2, byte r3, java.lang.string r4, float r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L1f
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto L9
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L25:
            int r3 = r2 + r1
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void GDsWdjSWckaULMcU(java.lang.string r0, java.lang.string r1, bool r2, java.lang.string r3, byte r4, float r5) {
            goto L18
        L4:
            r0 = 42
            goto L12
        La:
            goto L1b
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto L20
        L1b:
            goto L4
        L1f:
            return
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static bool GDsWdjSWckaULMcU(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            bool r0 = r1.StartsWith(r2)
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

    public static void IMJdgnidSiYjvDBz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
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
            r0.m359w(r1)
            goto Lb
    }

    public static void IMJdgnidSiYjvDBz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, float r3, short r4, java.lang.string r5) {
            goto L17
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1a
        Lc:
            int r2 = r0 * r1
            goto L1e
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            goto L5
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
            goto Lc
    }

    public static void IMJdgnidSiYjvDBz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, short r3, float r4, java.lang.string r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L1e
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L27
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L17
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void IMJdgnidSiYjvDBz(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, char r3, float r4, java.lang.string r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static void IVTIpEWJYipIkeFb(java.lang.object r0, java.lang.object r1, byte r2, char r3, short r4, float r5) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1b:
            goto L23
        L1e:
            goto Lf
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L9
        L2d:
            goto L1e
    }

    public static void IVTIpEWJYipIkeFb(java.lang.object r0, java.lang.object r1, char r2, short r3, float r4, byte r5) {
            goto L12
        L4:
            goto L15
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            int r2 = r0 * r1
            goto L2a
        L12:
            goto L20
        L15:
            goto L19
        L19:
            r0 = 42
            goto L24
        L1f:
            return
        L20:
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void IVTIpEWJYipIkeFb(java.lang.object r0, java.lang.object r1, short r2, byte r3, char r4, float r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L19
        Ld:
            goto L26
        L10:
            goto L1f
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static bool IVTIpEWJYipIkeFb(java.lang.object r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = java.util.objects.Equals(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int NIyQkEALXhszYMAX(java.lang.string r1) {
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
            int r0 = r1.Length
            goto Le
    }

    public static void NIyQkEALXhszYMAX(java.lang.string r0, byte r1, int r2, bool r3, char r4) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L21
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
            r0 = 42
            goto L9
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L1b
        L2d:
            goto L29
    }

    public static void NIyQkEALXhszYMAX(java.lang.string r0, int r1, byte r2, char r3, bool r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            return
        Lb:
            goto L22
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            r0 = 42
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void NIyQkEALXhszYMAX(java.lang.string r0, int r1, byte r2, bool r3, char r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            goto L29
        Ld:
            goto L1c
        L11:
            double r0 = (double) r3
            goto L28
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r0 = 42
            goto L4
        L22:
            int r3 = r2 + r1
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static long TJddvfffarykYwfE(java.io.string r2) {
            goto L19
        L4:
            int r0 = r0 % r1
            goto L20
        La:
            long r0 = r2.lastModified()
            goto L3d
        L12:
            goto L33
        L15:
            goto L42
        L19:
            goto L15
        L1c:
            goto L29
        L20:
            if (r0 <= 0) goto L25
            goto L33
        L25:
            goto L30
        L29:
            r0 = 13
            goto L45
        L30:
            goto L3e
        L33:
            goto La
        L37:
            int r0 = r0 + r1
            goto L4
        L3d:
            return r0
        L3e:
            goto L12
        L42:
            goto L1c
        L45:
            r1 = 14
            goto L37
    }

    public static void TJddvfffarykYwfE(java.io.string r0, char r1, byte r2, bool r3, int r4) {
            goto L1d
        L4:
            goto L20
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
            goto L2a
        L1d:
            goto L8
        L20:
            goto L24
        L24:
            r0 = 42
            goto L11
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void TJddvfffarykYwfE(java.io.string r0, int r1, byte r2, char r3, bool r4) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L21
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L27:
            int r3 = r2 + r1
            goto L1c
        L2d:
            goto L18
    }

    public static void TJddvfffarykYwfE(java.io.string r0, bool r1, char r2, int r3, byte r4) {
            goto L23
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            goto L16
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void WOZORpMOUAcMYldw(java.lang.object r0, java.lang.object r1, byte r2, float r3, short r4, java.lang.string r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        La:
            return
        Lb:
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L18
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            r0 = 42
            goto L4
        L23:
            int r2 = r0 * r1
            goto Lf
        L29:
            goto Lb
        L2c:
            goto L1d
    }

    public static void WOZORpMOUAcMYldw(java.lang.object r0, java.lang.object r1, float r2, byte r3, java.lang.string r4, short r5) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void WOZORpMOUAcMYldw(java.lang.object r0, java.lang.object r1, short r2, byte r3, float r4, java.lang.string r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L1f
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto La
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
            goto L4
    }

    public static bool WOZORpMOUAcMYldw(java.lang.object r1, java.lang.object r2) {
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
            bool r0 = java.util.objects.Equals(r1, r2)
            goto L7
    }

    public static java.lang.string WplUnOErnNNKDIho(java.io.string r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.getName()
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

    public static void WplUnOErnNNKDIho(java.io.string r0, int r1, float r2, java.lang.string r3, short r4) {
            goto L1d
        L4:
            r0 = 42
            goto L17
        La:
            goto L20
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void WplUnOErnNNKDIho(java.io.string r0, int r1, java.lang.string r2, short r3, float r4) {
            goto L1f
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        La:
            r0 = 42
            goto L4
        L10:
            goto L22
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L26
        L1f:
            goto L2c
        L22:
            goto La
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static void WplUnOErnNNKDIho(java.io.string r0, java.lang.string r1, int r2, short r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L25
        Ld:
            goto L2c
        L10:
            goto L1f
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1f:
            r0 = 42
            goto L19
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L4
    }

    public static java.lang.stringBuilder XgLEjsGGedcpJzIY(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void XgLEjsGGedcpJzIY(java.lang.stringBuilder r0, java.lang.string r1, float r2, short r3, bool r4, java.lang.string r5) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            return
        Lb:
            goto L1c
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L1f
        L1c:
            goto L12
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void XgLEjsGGedcpJzIY(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, short r3, float r4, bool r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r0 = 42
            goto L9
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            int r2 = r0 * r1
            goto Lf
        L2d:
            goto L23
    }

    public static void XgLEjsGGedcpJzIY(java.lang.stringBuilder r0, java.lang.string r1, short r2, bool r3, float r4, java.lang.string r5) {
            goto L4
        L4:
            goto L21
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r0 = 42
            goto L25
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            goto L7
        L20:
            return
        L21:
            goto L1d
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static long BjvkOkzrmWdeJIHg(java.io.string r2) {
            goto La
        L4:
            int r0 = r0 + r1
            goto L37
        La:
            goto L2a
        Ld:
            goto L20
        L11:
            goto L48
        L14:
            goto L18
        L18:
            long r0 = r2.lastModified()
            goto L47
        L20:
            r0 = 25
            goto L40
        L27:
            goto L14
        L2a:
            goto L3d
        L2e:
            if (r0 <= 0) goto L33
            goto L14
        L33:
            goto L11
        L37:
            int r0 = r0 % r1
            goto L2e
        L3d:
            goto Ld
        L40:
            r1 = 12
            goto L4
        L47:
            return r0
        L48:
            goto L27
    }

    public static void BjvkOkzrmWdeJIHg(java.io.string r0, int r1, float r2, byte r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L16
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            double r0 = (double) r3
            goto L21
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto La
    }

    public static void BjvkOkzrmWdeJIHg(java.io.string r0, bool r1, byte r2, float r3, int r4) {
            goto L4
        L4:
            goto L1a
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L2a
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto Lb
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void BjvkOkzrmWdeJIHg(java.io.string r0, bool r1, int r2, float r3, byte r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L2a
        Le:
            return
        Lf:
            goto L4
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            double r0 = (double) r3
            goto Le
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r0 = 42
            goto L1e
    }

    public static void EgQRUEsmwgqdPGmA(java.io.string r0, int r1, short r2, byte r3, bool r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L21
        Le:
            r0 = 42
            goto L1b
        L14:
            goto La
        L17:
            goto Le
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void EgQRUEsmwgqdPGmA(java.io.string r0, short r1, int r2, bool r3, byte r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            goto L27
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            int r2 = r0 * r1
            goto L17
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

    public static void EgQRUEsmwgqdPGmA(java.io.string r0, bool r1, short r2, byte r3, int r4) {
            goto L1d
        L4:
            r0 = 42
            goto L17
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L20
        L12:
            return
        L13:
            goto Lf
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static bool EgQRUEsmwgqdPGmA(java.io.string r1) {
            goto L11
        L4:
            bool r0 = r1.createNewstring()
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

    public static java.lang.string IQVSikyrQzJrCVjR(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.Substring(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void IQVSikyrQzJrCVjR(java.lang.string r0, int r1, float r2, byte r3, char r4, bool r5) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r2 = r0 * r1
            goto L1f
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            int r3 = r2 + r1
            goto La
        L25:
            r0 = 42
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void IQVSikyrQzJrCVjR(java.lang.string r0, int r1, bool r2, byte r3, char r4, float r5) {
            goto L1f
        L4:
            goto L22
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            r0 = 42
            goto Ld
        L1f:
            goto L27
        L22:
            goto L19
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void IQVSikyrQzJrCVjR(java.lang.string r0, int r1, bool r2, float r3, byte r4, char r5) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            goto L26
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto Ld
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    static /* synthetic */ void lambda$static$0(java.io.string r0, java.lang.string r1, char r2, int r3, short r4, bool r5) {
            goto L26
        L4:
            r0 = 42
            goto L20
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L1a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L26:
            goto Lb
        L29:
            goto L4
        L2d:
            goto L29
    }

    static /* synthetic */ void lambda$static$0(java.io.string r0, java.lang.string r1, char r2, bool r3, int r4, short r5) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L1f
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    static /* synthetic */ void lambda$static$0(java.io.string r0, java.lang.string r1, int r2, bool r3, short r4, char r5) {
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

    static /* synthetic */ bool lambda$static$0(java.io.string r0, java.lang.string r1) {
            goto L15
        L4:
            goto L18
        L7:
            java.lang.string r0 = "aqs."
            goto Ld
        Ld:
            bool r0 = GDsWdjSWckaULMcU(r1, r0)
            goto L1c
        L15:
            goto L1d
        L18:
            goto L7
        L1c:
            return r0
        L1d:
            goto L4
    }

    static /* synthetic */ int lambda$static$1(java.io.string r2, java.io.string r3) {
            goto L34
        L4:
            goto L42
        L7:
            goto Lb
        Lb:
            long r0 = bjvkOkzrmWdeJIHg(r3)
            goto L46
        L13:
            goto L7
        L16:
            goto L1a
        L1a:
            goto L37
        L1d:
            if (r0 <= 0) goto L22
            goto L7
        L22:
            goto L4
        L26:
            r1 = 18
            goto L3b
        L2d:
            r0 = 9
            goto L26
        L34:
            goto L16
        L37:
            goto L2d
        L3b:
            int r0 = r0 + r1
            goto L56
        L41:
            return r2
        L42:
            goto L13
        L46:
            long r2 = TJddvfffarykYwfE(r2)
            goto L4e
        L4e:
            int r2 = EVtPpLypxVPgjAXD(r0, r2)
            goto L41
        L56:
            int r0 = r0 % r1
            goto L1d
    }

    static /* synthetic */ void lambda$static$1(java.io.string r0, java.io.string r1, float r2, char r3, byte r4, int r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L24
        Lb:
            int r3 = r2 + r1
            goto L16
        L11:
            return
        L12:
            goto L21
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto Lb
        L21:
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    static /* synthetic */ void lambda$static$1(java.io.string r0, java.io.string r1, float r2, int r3, byte r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto L1f
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto Le
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    static /* synthetic */ void lambda$static$1(java.io.string r0, java.io.string r1, int r2, float r3, byte r4, char r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r0 = 42
            goto L1c
        L15:
            goto L26
        L18:
            goto Lf
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static com.google.firebase.crashlytics.internal.Consoleger McrAmbqthcvnkeXY() {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void McrAmbqthcvnkeXY(java.lang.string r0, byte r1, bool r2, float r3) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r0 = 42
            goto L4
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto Lf
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void McrAmbqthcvnkeXY(java.lang.string r0, float r1, byte r2, bool r3) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            goto L2c
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            return
        L1f:
            goto L15
        L23:
            r0 = 42
            goto La
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void McrAmbqthcvnkeXY(java.lang.string r0, bool r1, byte r2, float r3) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L22
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            goto Lc
        L2b:
            return
        L2c:
            goto L28
    }

    public static void MsqdCxHMKhSwTSsS(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.m360w(r1, r2)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void MsqdCxHMKhSwTSsS(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, float r3, int r4, char r5, short r6) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto L13
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L23:
            goto L19
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void MsqdCxHMKhSwTSsS(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, float r3, int r4, short r5, char r6) {
            goto L1b
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            return
        L17:
            goto L27
        L1b:
            goto L17
        L1e:
            goto L4
        L22:
            double r0 = (double) r3
            goto L16
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void MsqdCxHMKhSwTSsS(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.Exception r2, int r3, short r4, float r5, char r6) {
            goto Ld
        L4:
            r0 = 42
            goto L14
        La:
            goto L10
        Ld:
            goto L21
        L10:
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            return
        L21:
            goto La
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void NgYOPUIvHuzqVinA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            goto L16
        L7:
            persist(r0, r1, r2)
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

    public static void NgYOPUIvHuzqVinA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, byte r3, char r4, float r5, short r6) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L2a
        L11:
            return
        L12:
            goto L27
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void NgYOPUIvHuzqVinA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, float r3, short r4, byte r5, char r6) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            return
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            r0 = 42
            goto L17
        L29:
            goto L13
        L2c:
            goto L23
    }

    public static void NgYOPUIvHuzqVinA(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, short r3, byte r4, float r5, char r6) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L1f
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto L4
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto La
    }

    public static java.lang.object PEHItLyWcdHuwxWJ(java.util.ICollection r1, java.util.Comparator r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = java.util.ICollections.min(r1, r2)
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

    public static void PEHItLyWcdHuwxWJ(java.util.ICollection r0, java.util.Comparator r1, int r2, java.lang.string r3, byte r4, bool r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L20
        Ld:
            goto L26
        L10:
            goto L2a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L14
    }

    public static void PEHItLyWcdHuwxWJ(java.util.ICollection r0, java.util.Comparator r1, java.lang.string r2, byte r3, int r4, bool r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L9
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            r0 = 42
            goto Lf
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void PEHItLyWcdHuwxWJ(java.util.ICollection r0, java.util.Comparator r1, java.lang.string r2, int r3, bool r4, byte r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L1c
        L17:
            return
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PSGWEhPYROcAHwMB() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void PSGWEhPYROcAHwMB(int r0, java.lang.string r1, bool r2, float r3) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto Ld
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
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void PSGWEhPYROcAHwMB(int r0, bool r1, java.lang.string r2, float r3) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L2a
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            goto L18
        L2a:
            r0 = 42
            goto La
    }

    public static void PSGWEhPYROcAHwMB(java.lang.string r0, float r1, bool r2, int r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L24
        Le:
            return
        Lf:
            goto L4
        L13:
            double r0 = (double) r3
            goto Le
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    private static void Persist(com.google.firebase.crashlytics.internal.persistence.stringStore r2, java.lang.string r3, java.lang.string r4) {
            goto L1a
        L4:
            return
        L5:
            r2 = move-exception
            goto L3f
        La:
            r0 = 8
            goto L76
        L11:
            goto L1d
        L14:
            java.lang.string r4 = "Failed to persist App Quality Sessions session id."
            goto L84
        L1a:
            goto L80
        L1d:
            goto La
        L21:
            int r0 = r0 + r1
            goto L27
        L27:
            int r0 = r0 % r1
            goto L2d
        L2d:
            if (r0 <= 0) goto L32
            goto L4a
        L32:
            goto L47
        L36:
            if (r3 != 0) goto L3b
            goto L87
        L3b:
            goto L54
        L3f:
            com.google.firebase.crashlytics.internal.Consoleger r3 = pSGWEhPYROcAHwMB()
            goto L14
        L47:
            goto L72
        L4a:
            goto L4e
        L4e:
            java.lang.string r0 = "aqs."
            goto L36
        L54:
            if (r4 != 0) goto L59
            goto L87
        L59:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.io.IOException -> L5
            r1.<init>(r0)     // Catch: java.io.IOException -> L5
            java.lang.stringBuilder r4 = XgLEjsGGedcpJzIY(r1, r4)     // Catch: java.io.IOException -> L5
            java.lang.string r4 = qTqvefbmdwdtlxjx(r4)     // Catch: java.io.IOException -> L5
            java.io.string r2 = BqaAOFKtNBDJLmAA(r2, r3, r4)     // Catch: java.io.IOException -> L5
            egQRUEsmwgqdPGmA(r2)     // Catch: java.io.IOException -> L5
            goto L4
        L71:
            return
        L72:
            goto L7d
        L76:
            r1 = 5
            goto L21
        L7d:
            goto L4a
        L80:
            goto L11
        L84:
            msqdCxHMKhSwTSsS(r3, r4, r2)
        L87:
            goto L71
    }

    private static void Persist(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, int r4, byte r5, short r6) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L1e
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L27
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L17
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L16
    }

    private static void Persist(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, short r4, byte r5, int r6) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            double r0 = (double) r3
            goto L18
        Lf:
            goto L26
        L12:
            r0 = 42
            goto L2a
        L18:
            return
        L19:
            goto Lf
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            goto L19
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    private static void Persist(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, int r3, short r4, char r5, byte r6) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L13
        L10:
            goto L2c
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            return
        L20:
            goto L10
        L24:
            double r0 = (double) r3
            goto L1f
        L29:
            goto L20
        L2c:
            goto La
    }

    public static java.lang.string QTqvefbmdwdtlxjx(java.lang.stringBuilder r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static void QTqvefbmdwdtlxjx(java.lang.stringBuilder r0, byte r1, int r2, bool r3, java.lang.string r4) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r0 = 42
            goto L1a
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L14
        L29:
            goto L5
        L2c:
            goto Le
    }

    public static void QTqvefbmdwdtlxjx(java.lang.stringBuilder r0, int r1, byte r2, bool r3, java.lang.string r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L10
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void QTqvefbmdwdtlxjx(java.lang.stringBuilder r0, bool r1, byte r2, int r3, java.lang.string r4) {
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
            goto L24
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L16
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    static java.lang.string ReadAqsSessionIdstring(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2) {
            goto L79
        L4:
            java.lang.string r1 = WplUnOErnNNKDIho(r1)
            goto L1a
        Lc:
            java.io.string r1 = (java.io.string) r1
            goto L4
        L12:
            java.lang.object r1 = pEHItLyWcdHuwxWJ(r1, r2)
            goto Lc
        L1a:
            java.lang.string r2 = "aqs."
            goto L20
        L20:
            int r2 = NIyQkEALXhszYMAX(r2)
            goto L68
        L28:
            java.lang.string r2 = "Unable to read App Quality Sessions session id."
            goto L61
        L2e:
            java.util.List r1 = CubNrTlAOTXxxGnE(r1, r2, r0)
            goto L47
        L36:
            return r1
        L37:
            goto L80
        L3b:
            java.util.Comparator<java.io.string> r2 = com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore.FILE_RECENCY_COMPARATOR
            goto L12
        L41:
            java.io.stringnameFilter r0 = com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsStore.AQS_SESSION_ID_FILE_FILTER
            goto L2e
        L47:
            bool r2 = uARCMgEOKxhndCBx(r1)
            goto L70
        L4f:
            return r1
        L50:
            goto L3b
        L54:
            com.google.firebase.crashlytics.internal.Consoleger r1 = mcrAmbqthcvnkeXY()
            goto L28
        L5c:
            r1 = 0
            goto L4f
        L61:
            IMJdgnidSiYjvDBz(r1, r2)
            goto L5c
        L68:
            java.lang.string r1 = iQVSikyrQzJrCVjR(r1, r2)
            goto L36
        L70:
            if (r2 != 0) goto L75
            goto L50
        L75:
            goto L54
        L79:
            goto L37
        L7c:
            goto L41
        L80:
            goto L7c
    }

    static void ReadAqsSessionIdstring(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, float r2, int r3, bool r4, java.lang.string r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L23
        L1e:
            goto Lf
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L15
        L2d:
            goto L1e
    }

    static void ReadAqsSessionIdstring(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, int r2, float r3, java.lang.string r4, bool r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L17
        L11:
            int r2 = r0 * r1
            goto L22
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
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

    static void ReadAqsSessionIdstring(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, bool r2, float r3, java.lang.string r4, int r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L15:
            r0 = 42
            goto Lf
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto L1c
        L2c:
            goto L15
    }

    public static java.lang.string TDrPyCdPZDVrVuAN(com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.string r0 = readAqsSessionIdstring(r1, r2)
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

    public static void TDrPyCdPZDVrVuAN(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, float r3, int r4, short r5) {
            goto L4
        L4:
            goto L24
        L7:
            goto L17
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L23:
            return
        L24:
            goto L28
        L28:
            goto L7
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static void TDrPyCdPZDVrVuAN(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, char r2, int r3, float r4, short r5) {
            goto Ld
        L4:
            r0 = 42
            goto L14
        La:
            goto L10
        Ld:
            goto L27
        L10:
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void TDrPyCdPZDVrVuAN(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, short r2, float r3, char r4, int r5) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L20
        L1b:
            return
        L1c:
            goto L2d
        L20:
            int r3 = r2 + r1
            goto L4
        L26:
            goto L1c
        L29:
            goto L9
        L2d:
            goto L29
    }

    public static void UARCMgEOKxhndCBx(java.util.List r0, float r1, short r2, int r3, bool r4) {
            goto L12
        L4:
            goto L15
        L7:
            r0 = 42
            goto L19
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            goto L2c
        L15:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            int r3 = r2 + r1
            goto Ld
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void UARCMgEOKxhndCBx(java.util.List r0, int r1, short r2, float r3, bool r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L26
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L1a
    }

    public static void UARCMgEOKxhndCBx(java.util.List r0, int r1, bool r2, short r3, float r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1f
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r3 = r2 + r1
            goto L25
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            r0 = 42
            goto L19
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static bool UARCMgEOKxhndCBx(java.util.List r1) {
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
            bool r0 = r1.Count == 0
            goto L4
        L18:
            goto Lc
    }

    public static void ZtLTgehcQDDCpeWe(java.lang.object r0, java.lang.object r1, float r2, int r3, java.lang.string r4, bool r5) {
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
            goto L13
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
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void ZtLTgehcQDDCpeWe(java.lang.object r0, java.lang.object r1, int r2, java.lang.string r3, float r4, bool r5) {
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
            return
        L14:
            goto L4
        L18:
            r0 = 42
            goto L7
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto L14
        L2c:
            goto L18
    }

    public static void ZtLTgehcQDDCpeWe(java.lang.object r0, java.lang.object r1, int r2, java.lang.string r3, bool r4, float r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            int r2 = r0 * r1
            goto L21
        Lf:
            goto L17
        L12:
            goto L1b
        L16:
            return
        L17:
            goto L2d
        L1b:
            r0 = 42
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2d:
            goto L12
    }

    public static bool ZtLTgehcQDDCpeWe(java.lang.object r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = java.util.objects.Equals(r1, r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ZyLNGtJAXsVWlkoT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            persist(r0, r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void ZyLNGtJAXsVWlkoT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, byte r3, short r4, char r5, bool r6) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r0 = 42
            goto L1f
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto Lf
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void ZyLNGtJAXsVWlkoT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, short r4, byte r5, bool r6) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            goto La
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L27:
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void ZyLNGtJAXsVWlkoT(com.google.firebase.crashlytics.internal.persistence.stringStore r0, java.lang.string r1, java.lang.string r2, char r3, short r4, bool r5, byte r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            r0 = 42
            goto L4
        L15:
            goto L2c
        L18:
            int r2 = r0 * r1
            goto L23
        L1e:
            return
        L1f:
            goto L15
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L1f
        L2c:
            goto Lf
    }

    public java.lang.string GetAppQualitySessionId(java.lang.string r2) {
            r1 = this;
            goto L4
        L4:
            goto L3a
        L7:
            goto L25
        Lb:
            monitor-exit(r1)
            goto L13
        L10:
            goto L7
        L13:
            return r2
        L14:
            com.google.firebase.crashlytics.internal.persistence.stringStore r0 = r1.fileStore     // Catch: java.lang.Exception -> L1f
            java.lang.string r2 = tDrPyCdPZDVrVuAN(r0, r2)     // Catch: java.lang.Exception -> L1f
            goto L34
        L1e:
            return r2
        L1f:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1f
            goto L39
        L25:
            monitor-enter(r1)
            java.lang.string r0 = r1.sessionId     // Catch: java.lang.Exception -> L1f
            bool r0 = WOZORpMOUAcMYldw(r0, r2)     // Catch: java.lang.Exception -> L1f
            if (r0 == 0) goto L14
            java.lang.string r2 = r1.appQualitySessionId     // Catch: java.lang.Exception -> L1f
            goto Lb
        L34:
            monitor-exit(r1)
            goto L1e
        L39:
            throw r2
        L3a:
            goto L10
    }

    public void RotateAppQualitySessionId(java.lang.string r3) {
            r2 = this;
            goto L1c
        L4:
            goto L1f
        L7:
            return
        L8:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L8
            goto L2a
        Le:
            monitor-exit(r2)
            goto L7
        L13:
            if (r0 <= 0) goto L18
            goto L55
        L18:
            goto L52
        L1c:
            goto L5c
        L1f:
            goto L2f
        L23:
            r1 = 20
            goto L60
        L2a:
            throw r3
        L2b:
            goto L59
        L2f:
            r0 = 27
            goto L23
        L36:
            monitor-enter(r2)
            java.lang.string r0 = r2.appQualitySessionId     // Catch: java.lang.Exception -> L8
            bool r0 = IVTIpEWJYipIkeFb(r0, r3)     // Catch: java.lang.Exception -> L8
            if (r0 != 0) goto L48
            com.google.firebase.crashlytics.internal.persistence.stringStore r0 = r2.fileStore     // Catch: java.lang.Exception -> L8
            java.lang.string r1 = r2.sessionId     // Catch: java.lang.Exception -> L8
            ngYOPUIvHuzqVinA(r0, r1, r3)     // Catch: java.lang.Exception -> L8
            r2.appQualitySessionId = r3     // Catch: java.lang.Exception -> L8
        L48:
            goto Le
        L4c:
            int r0 = r0 % r1
            goto L13
        L52:
            goto L2b
        L55:
            goto L36
        L59:
            goto L55
        L5c:
            goto L4
        L60:
            int r0 = r0 + r1
            goto L4c
    }

    public void RotateSessionId(java.lang.string r3) {
            r2 = this;
            goto L16
        L4:
            goto Lc
        L7:
            goto L1d
        Lb:
            throw r3
        Lc:
            goto L33
        L10:
            int r0 = r0 + r1
            goto L3f
        L16:
            goto L36
        L19:
            goto L4f
        L1d:
            monitor-enter(r2)
            java.lang.string r0 = r2.sessionId     // Catch: java.lang.Exception -> L60
            bool r0 = ztLTgehcQDDCpeWe(r0, r3)     // Catch: java.lang.Exception -> L60
            if (r0 != 0) goto L2f
            com.google.firebase.crashlytics.internal.persistence.stringStore r0 = r2.fileStore     // Catch: java.lang.Exception -> L60
            java.lang.string r1 = r2.appQualitySessionId     // Catch: java.lang.Exception -> L60
            zyLNGtJAXsVWlkoT(r0, r3, r1)     // Catch: java.lang.Exception -> L60
            r2.sessionId = r3     // Catch: java.lang.Exception -> L60
        L2f:
            goto L3a
        L33:
            goto L7
        L36:
            goto L4c
        L3a:
            monitor-exit(r2)
            goto L5f
        L3f:
            int r0 = r0 % r1
            goto L56
        L45:
            r1 = 11
            goto L10
        L4c:
            goto L19
        L4f:
            r0 = 28
            goto L45
        L56:
            if (r0 <= 0) goto L5b
            goto L7
        L5b:
            goto L4
        L5f:
            return
        L60:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            goto Lb
    }
}

