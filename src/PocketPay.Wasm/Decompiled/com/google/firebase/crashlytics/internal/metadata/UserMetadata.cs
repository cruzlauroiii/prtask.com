namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class UserMetadata {
    public static readonly java.lang.string INTERNAL_KEYDATA_FILENAME = "internal-keys";
    public static readonly java.lang.string KEYDATA_FILENAME = "keys";
    public static readonly int MAX_ATTRIBUTES = 64;
    public static readonly int MAX_ATTRIBUTE_SIZE = 1024;
    public static readonly int MAX_INTERNAL_KEY_SIZE = 8192;
    public static readonly int MAX_ROLLOUT_ASSIGNMENTS = 128;
    public static readonly java.lang.string ROLLOUTS_STATE_FILENAME = "rollouts-state";
    public static readonly java.lang.string USERDATA_FILENAME = "user-data";
    private readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers;
    private readonly com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary customKeys;
    private readonly com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary internalKeys;
    private readonly com.google.firebase.crashlytics.internal.metadata.MetaDataStore metaDataStore;
    private readonly com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList rolloutsState;
    private java.lang.string sessionIdentifier;
    private readonly java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> userId;

    private class SerializeableKeysDictionary {
        private readonly bool isInternal;
        readonly java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> map;
        private readonly java.util.concurrent.atomic.object<java.lang.Action> queuedSerializer;
        readonly /* synthetic */ com.google.firebase.crashlytics.internal.metadata.UserMetadata this$0;

        public SerializeableKeysDictionary(com.google.firebase.crashlytics.internal.metadata.UserMetadata r2, bool r3) {
                r1 = this;
                goto L5e
            L4:
                r0 = 0
                goto L23
            L9:
                r1.isInternal = r3
                goto L72
            Lf:
                r2.<init>(r0, r3)
                goto L2a
            L16:
                r2.<init>(r0)
                goto L1d
            L1d:
                r1.queuedSerializer = r2
                goto L9
            L23:
                r3.<init>(r2, r0)
                goto L65
            L2a:
                java.util.concurrent.atomic.AtomicMarkableReference r3 = new java.util.concurrent.atomic.AtomicMarkableReference
                goto L4
            L30:
                r0 = 64
                goto Lf
            L36:
                return
            L37:
                goto L3b
            L3b:
                goto L61
            L3e:
                r1.this$0 = r2
                goto L6b
            L44:
                java.util.concurrent.atomic.object r2 = new java.util.concurrent.atomic.object
                goto L59
            L4a:
                if (r3 != 0) goto L4f
                goto L79
            L4f:
                goto L53
            L53:
                r3 = 8192(0x2000, float:1.148E-41)
                goto L78
            L59:
                r0 = 0
                goto L16
            L5e:
                goto L37
            L61:
                goto L3e
            L65:
                r1.map = r3
                goto L36
            L6b:
                r1.<init>()
                goto L44
            L72:
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r2 = new com.google.firebase.crashlytics.internal.metadata.KeysDictionary
                goto L4a
            L78:
                goto L7f
            L79:
                goto L7d
            L7d:
                r3 = 1024(0x400, float:1.435E-42)
            L7f:
                goto L30
        }

        public static java.lang.object ABVhrFbAOQMMLeeX(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                java.lang.object r0 = r1.getReference()
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        public static void ABVhrFbAOQMMLeeX(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, int r2, short r3, char r4) {
                goto L29
            L4:
                int r3 = r2 + r1
                goto L10
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L20
            L10:
                double r0 = (double) r3
                goto L15
            L15:
                return
            L16:
                goto L26
            L1a:
                r0 = 42
                goto La
            L20:
                int r2 = r0 * r1
                goto L4
            L26:
                goto L2c
            L29:
                goto L16
            L2c:
                goto L1a
        }

        public static void ABVhrFbAOQMMLeeX(java.util.concurrent.atomic.AtomicMarkableReference r0, char r1, byte r2, int r3, short r4) {
                goto L15
            L4:
                int r3 = r2 + r1
                goto L1c
            La:
                return
            Lb:
                goto L21
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L15:
                goto Lb
            L18:
                goto L24
            L1c:
                double r0 = (double) r3
                goto La
            L21:
                goto L18
            L24:
                r0 = 42
                goto Lf
            L2a:
                int r2 = r0 * r1
                goto L4
        }

        public static void ABVhrFbAOQMMLeeX(java.util.concurrent.atomic.AtomicMarkableReference r0, int r1, short r2, byte r3, char r4) {
                goto L29
            L4:
                double r0 = (double) r3
                goto L21
            L9:
                r0 = 42
                goto L1b
            Lf:
                int r2 = r0 * r1
                goto L15
            L15:
                int r3 = r2 + r1
                goto L4
            L1b:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L21:
                return
            L22:
                goto L26
            L26:
                goto L2c
            L29:
                goto L22
            L2c:
                goto L9
        }

        public static java.lang.object AuFErmUHkKoLpyFy(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto Lf
            L4:
                java.lang.object r0 = r1.getReference()
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

        public static void AuFErmUHkKoLpyFy(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, float r2, bool r3, char r4) {
                goto L1a
            L4:
                int r3 = r2 + r1
                goto L10
            La:
                int r2 = r0 * r1
                goto L4
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
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L27:
                r0 = 42
                goto L21
            L2d:
                goto L1d
        }

        public static void AuFErmUHkKoLpyFy(java.util.concurrent.atomic.AtomicMarkableReference r0, char r1, byte r2, float r3, bool r4) {
                goto L15
            L4:
                int r2 = r0 * r1
                goto Lf
            La:
                return
            Lb:
                goto L21
            Lf:
                int r3 = r2 + r1
                goto L1c
            L15:
                goto Lb
            L18:
                goto L24
            L1c:
                double r0 = (double) r3
                goto La
            L21:
                goto L18
            L24:
                r0 = 42
                goto L2a
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static void AuFErmUHkKoLpyFy(java.util.concurrent.atomic.AtomicMarkableReference r0, char r1, float r2, bool r3, byte r4) {
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
                goto L1c
            L16:
                r1 = 210(0xd2, float:2.94E-43)
                goto L22
            L1c:
                r0 = 42
                goto L16
            L22:
                int r2 = r0 * r1
                goto L9
            L28:
                goto L12
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static java.lang.object CZdBQypuVRdoxxTM(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto L11
            L4:
                java.lang.object r0 = r1.getReference()
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

        public static void CZdBQypuVRdoxxTM(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, int r2, char r3, short r4) {
                goto L18
            L4:
                r0 = 42
                goto L12
            La:
                goto L1b
            Ld:
                double r0 = (double) r3
                goto L25
            L12:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L18:
                goto L26
            L1b:
                goto L4
            L1f:
                int r2 = r0 * r1
                goto L2a
            L25:
                return
            L26:
                goto La
            L2a:
                int r3 = r2 + r1
                goto Ld
        }

        public static void CZdBQypuVRdoxxTM(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, short r2, char r3, int r4) {
                goto L1a
            L4:
                int r2 = r0 * r1
                goto L21
            La:
                return
            Lb:
                goto L2d
            Lf:
                r0 = 42
                goto L27
            L15:
                double r0 = (double) r3
                goto La
            L1a:
                goto Lb
            L1d:
                goto Lf
            L21:
                int r3 = r2 + r1
                goto L15
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L2d:
                goto L1d
        }

        public static void CZdBQypuVRdoxxTM(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, short r2, int r3, char r4) {
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
                r0 = 42
                goto L1e
            L19:
                double r0 = (double) r3
                goto L4
            L1e:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L24:
                int r3 = r2 + r1
                goto L19
            L2a:
                int r2 = r0 * r1
                goto L24
        }

        public static void EiMPuXpJxEwaesox(java.util.concurrent.atomic.object r0, java.lang.object r1, java.lang.object r2, float r3, bool r4, char r5, int r6) {
                goto La
            L4:
                int r3 = r2 + r1
                goto L2b
            La:
                goto L1e
            Ld:
                goto L11
            L11:
                r0 = 42
                goto L22
            L17:
                int r2 = r0 * r1
                goto L4
            L1d:
                return
            L1e:
                goto L28
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto L17
            L28:
                goto Ld
            L2b:
                double r0 = (double) r3
                goto L1d
        }

        public static void EiMPuXpJxEwaesox(java.util.concurrent.atomic.object r0, java.lang.object r1, java.lang.object r2, int r3, char r4, float r5, bool r6) {
                goto L23
            L4:
                int r3 = r2 + r1
                goto L1e
            La:
                goto L26
            Ld:
                int r2 = r0 * r1
                goto L4
            L13:
                return
            L14:
                goto La
            L18:
                r1 = 210(0xd2, float:2.94E-43)
                goto Ld
            L1e:
                double r0 = (double) r3
                goto L13
            L23:
                goto L14
            L26:
                goto L2a
            L2a:
                r0 = 42
                goto L18
        }

        public static void EiMPuXpJxEwaesox(java.util.concurrent.atomic.object r0, java.lang.object r1, java.lang.object r2, int r3, float r4, bool r5, char r6) {
                goto L15
            L4:
                int r3 = r2 + r1
                goto L10
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L10:
                double r0 = (double) r3
                goto L25
            L15:
                goto L26
            L18:
                goto L2a
            L1c:
                goto L18
            L1f:
                int r2 = r0 * r1
                goto L4
            L25:
                return
            L26:
                goto L1c
            L2a:
                r0 = 42
                goto La
        }

        public static bool EiMPuXpJxEwaesox(java.util.concurrent.atomic.object r1, java.lang.object r2, java.lang.object r3) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                bool r0 = androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(r1, r2, r3)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static void EsFciNtuzfnKrdKe(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
                goto L10
            L4:
                r0.set(r1, r2)
                goto Lb
            Lb:
                return
            Lc:
                goto L17
            L10:
                goto Lc
            L13:
                goto L4
            L17:
                goto L13
        }

        public static void EsFciNtuzfnKrdKe(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, byte r3, float r4, short r5, java.lang.string r6) {
                goto L18
            L4:
                goto L1b
            L7:
                int r2 = r0 * r1
                goto Ld
            Ld:
                int r3 = r2 + r1
                goto L2b
            L13:
                return
            L14:
                goto L4
            L18:
                goto L14
            L1b:
                goto L1f
            L1f:
                r0 = 42
                goto L25
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L7
            L2b:
                double r0 = (double) r3
                goto L13
        }

        public static void EsFciNtuzfnKrdKe(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, float r3, java.lang.string r4, short r5, byte r6) {
                goto L1e
            L4:
                int r3 = r2 + r1
                goto L2b
            La:
                goto L21
            Ld:
                return
            Le:
                goto La
            L12:
                r0 = 42
                goto L18
            L18:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            L1e:
                goto Le
            L21:
                goto L12
            L25:
                int r2 = r0 * r1
                goto L4
            L2b:
                double r0 = (double) r3
                goto Ld
        }

        public static void EsFciNtuzfnKrdKe(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, java.lang.string r3, float r4, byte r5, short r6) {
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

        public static void GhQRrNigLeQRZTKm(java.util.concurrent.atomic.object r0, java.lang.object r1) {
                goto Le
            L4:
                goto L11
            L7:
                r0.set(r1)
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

        public static void GhQRrNigLeQRZTKm(java.util.concurrent.atomic.object r0, java.lang.object r1, byte r2, int r3, java.lang.string r4, float r5) {
                goto L23
            L4:
                goto L26
            L7:
                return
            L8:
                goto L4
            Lc:
                int r2 = r0 * r1
                goto L1d
            L12:
                double r0 = (double) r3
                goto L7
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lc
            L1d:
                int r3 = r2 + r1
                goto L12
            L23:
                goto L8
            L26:
                goto L2a
            L2a:
                r0 = 42
                goto L17
        }

        public static void GhQRrNigLeQRZTKm(java.util.concurrent.atomic.object r0, java.lang.object r1, int r2, float r3, byte r4, java.lang.string r5) {
                goto L1d
            L4:
                double r0 = (double) r3
                goto L18
            L9:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            Lf:
                int r2 = r0 * r1
                goto L2a
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
                goto L9
            L2a:
                int r3 = r2 + r1
                goto L4
        }

        public static void GhQRrNigLeQRZTKm(java.util.concurrent.atomic.object r0, java.lang.object r1, int r2, float r3, java.lang.string r4, byte r5) {
                goto L18
            L4:
                goto L1b
            L7:
                double r0 = (double) r3
                goto L2b
            Lc:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            L12:
                int r3 = r2 + r1
                goto L7
            L18:
                goto L2c
            L1b:
                goto L1f
            L1f:
                r0 = 42
                goto Lc
            L25:
                int r2 = r0 * r1
                goto L12
            L2b:
                return
            L2c:
                goto L4
        }

        public static java.util.Dictionary HVsFjGqBOKQUxyMS(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r1) {
                goto L11
            L4:
                java.util.Dictionary r0 = r1.getKeys()
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

        public static void HVsFjGqBOKQUxyMS(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, char r2, short r3, bool r4) {
                goto L4
            L4:
                goto L1d
            L7:
                goto Lb
            Lb:
                r0 = 42
                goto L11
            L11:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L17:
                double r0 = (double) r3
                goto L1c
            L1c:
                return
            L1d:
                goto L27
            L21:
                int r2 = r0 * r1
                goto L2a
            L27:
                goto L7
            L2a:
                int r3 = r2 + r1
                goto L17
        }

        public static void HVsFjGqBOKQUxyMS(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, short r1, java.lang.string r2, char r3, bool r4) {
                goto L23
            L4:
                goto L26
            L7:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            Ld:
                return
            Le:
                goto L4
            L12:
                int r3 = r2 + r1
                goto L1e
            L18:
                r0 = 42
                goto L7
            L1e:
                double r0 = (double) r3
                goto Ld
            L23:
                goto Le
            L26:
                goto L18
            L2a:
                int r2 = r0 * r1
                goto L12
        }

        public static void HVsFjGqBOKQUxyMS(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, bool r1, java.lang.string r2, char r3, short r4) {
                goto L10
            L4:
                int r3 = r2 + r1
                goto L23
            La:
                r0 = 42
                goto L1d
            L10:
                goto L2c
            L13:
                goto La
            L17:
                int r2 = r0 * r1
                goto L4
            L1d:
                r1 = 210(0xd2, float:2.94E-43)
                goto L17
            L23:
                double r0 = (double) r3
                goto L2b
            L28:
                goto L13
            L2b:
                return
            L2c:
                goto L28
        }

        public static void JtOpPuOyUZRbSnkF(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
                goto L13
            L4:
                return
            L5:
                goto L9
            L9:
                goto L16
            Lc:
                r0.set(r1, r2)
                goto L4
            L13:
                goto L5
            L16:
                goto Lc
        }

        public static void JtOpPuOyUZRbSnkF(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, int r3, char r4, byte r5, java.lang.string r6) {
                goto Lc
            L4:
                double r0 = (double) r3
                goto L19
            L9:
                goto Lf
            Lc:
                goto L1a
            Lf:
                goto L1e
            L13:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L19:
                return
            L1a:
                goto L9
            L1e:
                r0 = 42
                goto L13
            L24:
                int r3 = r2 + r1
                goto L4
            L2a:
                int r2 = r0 * r1
                goto L24
        }

        public static void JtOpPuOyUZRbSnkF(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, int r3, char r4, java.lang.string r5, byte r6) {
                goto L4
            L4:
                goto L12
            L7:
                goto L16
            Lb:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L11:
                return
            L12:
                goto L1c
            L16:
                r0 = 42
                goto Lb
            L1c:
                goto L7
            L1f:
                double r0 = (double) r3
                goto L11
            L24:
                int r3 = r2 + r1
                goto L1f
            L2a:
                int r2 = r0 * r1
                goto L24
        }

        public static void JtOpPuOyUZRbSnkF(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, int r3, java.lang.string r4, byte r5, char r6) {
                goto L29
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L23
            La:
                return
            Lb:
                goto L1a
            Lf:
                int r3 = r2 + r1
                goto L15
            L15:
                double r0 = (double) r3
                goto La
            L1a:
                goto L2c
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

        public static com.google.android.gms.tasks.Task OuLXDvokZuDOBYWY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r1, java.lang.Action r2) {
                goto L14
            L4:
                com.google.android.gms.tasks.Task r0 = r1.submit(r2)
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

        public static void OuLXDvokZuDOBYWY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, byte r2, int r3, short r4, bool r5) {
                goto L21
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L10
            L10:
                int r2 = r0 * r1
                goto L16
            L16:
                int r3 = r2 + r1
                goto L28
            L1c:
                return
            L1d:
                goto L2d
            L21:
                goto L1d
            L24:
                goto L4
            L28:
                double r0 = (double) r3
                goto L1c
            L2d:
                goto L24
        }

        public static void OuLXDvokZuDOBYWY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, short r2, byte r3, int r4, bool r5) {
                goto L23
            L4:
                goto L26
            L7:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            Ld:
                double r0 = (double) r3
                goto L12
            L12:
                return
            L13:
                goto L4
            L17:
                r0 = 42
                goto L7
            L1d:
                int r3 = r2 + r1
                goto Ld
            L23:
                goto L13
            L26:
                goto L17
            L2a:
                int r2 = r0 * r1
                goto L1d
        }

        public static void OuLXDvokZuDOBYWY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, short r2, int r3, byte r4, bool r5) {
                goto L15
            L4:
                int r3 = r2 + r1
                goto L1c
            La:
                return
            Lb:
                goto L27
            Lf:
                r0 = 42
                goto L2a
            L15:
                goto Lb
            L18:
                goto Lf
            L1c:
                double r0 = (double) r3
                goto La
            L21:
                int r2 = r0 * r1
                goto L4
            L27:
                goto L18
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
        }

        public static void OxJayCMzIXKQmuhp(java.util.concurrent.atomic.AtomicMarkableReference r0, float r1, bool r2, int r3, java.lang.string r4) {
                goto L13
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            La:
                goto L16
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
                int r2 = r0 * r1
                goto Ld
            L25:
                return
            L26:
                goto La
            L2a:
                r0 = 42
                goto L4
        }

        public static void OxJayCMzIXKQmuhp(java.util.concurrent.atomic.AtomicMarkableReference r0, int r1, float r2, java.lang.string r3, bool r4) {
                goto L12
            L4:
                double r0 = (double) r3
                goto L2b
            L9:
                int r3 = r2 + r1
                goto L4
            Lf:
                goto L15
            L12:
                goto L2c
            L15:
                goto L19
            L19:
                r0 = 42
                goto L25
            L1f:
                int r2 = r0 * r1
                goto L9
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L2b:
                return
            L2c:
                goto Lf
        }

        public static void OxJayCMzIXKQmuhp(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, bool r2, float r3, int r4) {
                goto L16
            L4:
                int r2 = r0 * r1
                goto L10
            La:
                r0 = 42
                goto L22
            L10:
                int r3 = r2 + r1
                goto L28
            L16:
                goto L1e
            L19:
                goto La
            L1d:
                return
            L1e:
                goto L2d
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L28:
                double r0 = (double) r3
                goto L1d
            L2d:
                goto L19
        }

        public static bool OxJayCMzIXKQmuhp(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto L11
            L4:
                bool r0 = r1.isMarked()
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

        public static void TGjfYuRNTattEXHQ(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0) {
                goto L10
            L4:
                r0.scheduleSerializationTaskIfNeeded()
                goto Lb
            Lb:
                return
            Lc:
                goto L17
            L10:
                goto Lc
            L13:
                goto L4
            L17:
                goto L13
        }

        public static void TGjfYuRNTattEXHQ(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, byte r1, char r2, java.lang.string r3, int r4) {
                goto L1a
            L4:
                double r0 = (double) r3
                goto L9
            L9:
                return
            La:
                goto L2d
            Le:
                int r3 = r2 + r1
                goto L4
            L14:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L1a:
                goto La
            L1d:
                goto L27
            L21:
                int r2 = r0 * r1
                goto Le
            L27:
                r0 = 42
                goto L14
            L2d:
                goto L1d
        }

        public static void TGjfYuRNTattEXHQ(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, byte r1, java.lang.string r2, int r3, char r4) {
                goto L9
            L4:
                return
            L5:
                goto L21
            L9:
                goto L5
            Lc:
                goto L2a
            L10:
                int r3 = r2 + r1
                goto L16
            L16:
                double r0 = (double) r3
                goto L4
            L1b:
                int r2 = r0 * r1
                goto L10
            L21:
                goto Lc
            L24:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1b
            L2a:
                r0 = 42
                goto L24
        }

        public static void TGjfYuRNTattEXHQ(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, char r1, int r2, byte r3, java.lang.string r4) {
                goto L1b
            L4:
                int r2 = r0 * r1
                goto L15
            La:
                r0 = 42
                goto L2a
            L10:
                return
            L11:
                goto L27
            L15:
                int r3 = r2 + r1
                goto L22
            L1b:
                goto L11
            L1e:
                goto La
            L22:
                double r0 = (double) r3
                goto L10
            L27:
                goto L1e
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static java.lang.object VrwsOkkodnnItndF(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto L11
            L4:
                java.lang.object r0 = r1.getReference()
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

        public static void VrwsOkkodnnItndF(java.util.concurrent.atomic.AtomicMarkableReference r0, char r1, bool r2, float r3, byte r4) {
                goto L29
            L4:
                double r0 = (double) r3
                goto L9
            L9:
                return
            La:
                goto L20
            Le:
                r0 = 42
                goto L1a
            L14:
                int r2 = r0 * r1
                goto L23
            L1a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L14
            L20:
                goto L2c
            L23:
                int r3 = r2 + r1
                goto L4
            L29:
                goto La
            L2c:
                goto Le
        }

        public static void VrwsOkkodnnItndF(java.util.concurrent.atomic.AtomicMarkableReference r0, float r1, bool r2, byte r3, char r4) {
                goto L4
            L4:
                goto L1a
            L7:
                goto L13
            Lb:
                goto L7
            Le:
                double r0 = (double) r3
                goto L19
            L13:
                r0 = 42
                goto L2a
            L19:
                return
            L1a:
                goto Lb
            L1e:
                int r2 = r0 * r1
                goto L24
            L24:
                int r3 = r2 + r1
                goto Le
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1e
        }

        public static void VrwsOkkodnnItndF(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, byte r2, char r3, float r4) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L2a
            Lb:
                return
            Lc:
                goto L27
            L10:
                int r2 = r0 * r1
                goto L1c
            L16:
                r1 = 210(0xd2, float:2.94E-43)
                goto L10
            L1c:
                int r3 = r2 + r1
                goto L22
            L22:
                double r0 = (double) r3
                goto Lb
            L27:
                goto L7
            L2a:
                r0 = 42
                goto L16
        }

        public static java.lang.object ZMLsWWMeTusxRYuX(java.util.concurrent.atomic.AtomicMarkableReference r1) {
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
                java.lang.object r0 = r1.getReference()
                goto Lb
        }

        public static void ZMLsWWMeTusxRYuX(java.util.concurrent.atomic.AtomicMarkableReference r0, short r1, float r2, bool r3, byte r4) {
                goto L1d
            L4:
                int r3 = r2 + r1
                goto L18
            La:
                return
            Lb:
                goto Lf
            Lf:
                goto L20
            L12:
                int r2 = r0 * r1
                goto L4
            L18:
                double r0 = (double) r3
                goto La
            L1d:
                goto Lb
            L20:
                goto L2a
            L24:
                r1 = 210(0xd2, float:2.94E-43)
                goto L12
            L2a:
                r0 = 42
                goto L24
        }

        public static void ZMLsWWMeTusxRYuX(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, byte r2, float r3, short r4) {
                goto L1e
            L4:
                return
            L5:
                goto Lf
            L9:
                int r2 = r0 * r1
                goto L18
            Lf:
                goto L21
            L12:
                r0 = 42
                goto L25
            L18:
                int r3 = r2 + r1
                goto L2b
            L1e:
                goto L5
            L21:
                goto L12
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L9
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static void ZMLsWWMeTusxRYuX(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, byte r2, short r3, float r4) {
                goto L20
            L4:
                int r3 = r2 + r1
                goto La
            La:
                double r0 = (double) r3
                goto L15
            Lf:
                int r2 = r0 * r1
                goto L4
            L15:
                return
            L16:
                goto L27
            L1a:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L20:
                goto L16
            L23:
                goto L2a
            L27:
                goto L23
            L2a:
                r0 = 42
                goto L1a
        }

        public static void AxvPTeWhCAMrgYyV(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, bool r3) {
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
                r0.writeKeyData(r1, r2, r3)
                goto Lb
        }

        public static void AxvPTeWhCAMrgYyV(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, bool r3, float r4, java.lang.string r5, int r6, short r7) {
                goto L9
            L4:
                return
            L5:
                goto L16
            L9:
                goto L5
            Lc:
                goto L19
            L10:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L16:
                goto Lc
            L19:
                r0 = 42
                goto L10
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

        public static void AxvPTeWhCAMrgYyV(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, bool r3, float r4, java.lang.string r5, short r6, int r7) {
                goto L29
            L4:
                r0 = 42
                goto L23
            La:
                double r0 = (double) r3
                goto L18
            Lf:
                int r3 = r2 + r1
                goto La
            L15:
                goto L2c
            L18:
                return
            L19:
                goto L15
            L1d:
                int r2 = r0 * r1
                goto Lf
            L23:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1d
            L29:
                goto L19
            L2c:
                goto L4
        }

        public static void AxvPTeWhCAMrgYyV(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, bool r3, int r4, float r5, short r6, java.lang.string r7) {
                goto L16
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            La:
                r0 = 42
                goto L4
            L10:
                int r3 = r2 + r1
                goto L2b
            L16:
                goto L1e
            L19:
                goto La
            L1d:
                return
            L1e:
                goto L22
            L22:
                goto L19
            L25:
                int r2 = r0 * r1
                goto L10
            L2b:
                double r0 = (double) r3
                goto L1d
        }

        public static void DECrqosldbfzjxjN(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0) {
                goto L13
            L4:
                r0.serializeIfMarked()
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

        public static void DECrqosldbfzjxjN(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, short r2, bool r3, float r4) {
                goto L9
            L4:
                return
            L5:
                goto L16
            L9:
                goto L5
            Lc:
                goto L24
            L10:
                int r3 = r2 + r1
                goto L19
            L16:
                goto Lc
            L19:
                double r0 = (double) r3
                goto L4
            L1e:
                int r2 = r0 * r1
                goto L10
            L24:
                r0 = 42
                goto L2a
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1e
        }

        public static void DECrqosldbfzjxjN(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, short r1, float r2, bool r3, java.lang.string r4) {
                goto L1b
            L4:
                return
            L5:
                goto L28
            L9:
                int r3 = r2 + r1
                goto L2b
            Lf:
                int r2 = r0 * r1
                goto L9
            L15:
                r0 = 42
                goto L22
            L1b:
                goto L5
            L1e:
                goto L15
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L28:
                goto L1e
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static void DECrqosldbfzjxjN(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, short r1, bool r2, float r3, java.lang.string r4) {
                goto La
            L4:
                int r2 = r0 * r1
                goto L11
            La:
                goto L27
            Ld:
                goto L1d
            L11:
                int r3 = r2 + r1
                goto L2b
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L1d:
                r0 = 42
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

        public static com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers JuOAWXYSyDocYnsI(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
                goto Lf
            L4:
                com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r0 = com.google.firebase.crashlytics.internal.metadata.UserMetadata.access$000(r1)
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

        public static void JuOAWXYSyDocYnsI(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, java.lang.string r1, float r2, bool r3, byte r4) {
                goto L29
            L4:
                int r2 = r0 * r1
                goto L23
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L10:
                double r0 = (double) r3
                goto L1b
            L15:
                r0 = 42
                goto La
            L1b:
                return
            L1c:
                goto L20
            L20:
                goto L2c
            L23:
                int r3 = r2 + r1
                goto L10
            L29:
                goto L1c
            L2c:
                goto L15
        }

        public static void JuOAWXYSyDocYnsI(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, java.lang.string r1, bool r2, float r3, byte r4) {
                goto L16
            L4:
                int r3 = r2 + r1
                goto L26
            La:
                r0 = 42
                goto L1d
            L10:
                int r2 = r0 * r1
                goto L4
            L16:
                goto L2c
            L19:
                goto La
            L1d:
                r1 = 210(0xd2, float:2.94E-43)
                goto L10
            L23:
                goto L19
            L26:
                double r0 = (double) r3
                goto L2b
            L2b:
                return
            L2c:
                goto L23
        }

        public static void JuOAWXYSyDocYnsI(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, byte r2, java.lang.string r3, float r4) {
                goto L1e
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            La:
                return
            Lb:
                goto L15
            Lf:
                r0 = 42
                goto L4
            L15:
                goto L21
            L18:
                int r3 = r2 + r1
                goto L2b
            L1e:
                goto Lb
            L21:
                goto Lf
            L25:
                int r2 = r0 * r1
                goto L18
            L2b:
                double r0 = (double) r3
                goto La
        }

        public static java.lang.string KdWiekWiilFVdcpZ(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
                goto Lf
            L4:
                java.lang.string r0 = com.google.firebase.crashlytics.internal.metadata.UserMetadata.access$100(r1)
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

        public static void KdWiekWiilFVdcpZ(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, byte r1, float r2, char r3, java.lang.string r4) {
                goto L12
            L4:
                goto L15
            L7:
                int r2 = r0 * r1
                goto L24
            Ld:
                double r0 = (double) r3
                goto L19
            L12:
                goto L1a
            L15:
                goto L2a
            L19:
                return
            L1a:
                goto L4
            L1e:
                r1 = 210(0xd2, float:2.94E-43)
                goto L7
            L24:
                int r3 = r2 + r1
                goto Ld
            L2a:
                r0 = 42
                goto L1e
        }

        public static void KdWiekWiilFVdcpZ(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, char r1, float r2, byte r3, java.lang.string r4) {
                goto L4
            L4:
                goto L21
            L7:
                goto L11
            Lb:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1a
            L11:
                r0 = 42
                goto Lb
            L17:
                goto L7
            L1a:
                int r2 = r0 * r1
                goto L2a
            L20:
                return
            L21:
                goto L17
            L25:
                double r0 = (double) r3
                goto L20
            L2a:
                int r3 = r2 + r1
                goto L25
        }

        public static void KdWiekWiilFVdcpZ(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, java.lang.string r1, float r2, byte r3, char r4) {
                goto L23
            L4:
                int r3 = r2 + r1
                goto L1e
            La:
                return
            Lb:
                goto L15
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L18
            L15:
                goto L26
            L18:
                int r2 = r0 * r1
                goto L4
            L1e:
                double r0 = (double) r3
                goto La
            L23:
                goto Lb
            L26:
                goto L2a
            L2a:
                r0 = 42
                goto Lf
        }

        public static void OVcvOiUcaNdgzife(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1) {
                goto Le
            L4:
                r0.setKeys(r1)
                goto L15
            Lb:
                goto L11
            Le:
                goto L16
            L11:
                goto L4
            L15:
                return
            L16:
                goto Lb
        }

        public static void OVcvOiUcaNdgzife(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, bool r2, char r3, short r4, int r5) {
                goto L29
            L4:
                double r0 = (double) r3
                goto L1b
            L9:
                int r3 = r2 + r1
                goto L4
            Lf:
                int r2 = r0 * r1
                goto L9
            L15:
                r0 = 42
                goto L20
            L1b:
                return
            L1c:
                goto L26
            L20:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L26:
                goto L2c
            L29:
                goto L1c
            L2c:
                goto L15
        }

        public static void OVcvOiUcaNdgzife(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, bool r2, int r3, char r4, short r5) {
                goto L20
            L4:
                return
            L5:
                goto L2d
            L9:
                int r3 = r2 + r1
                goto L15
            Lf:
                r0 = 42
                goto L1a
            L15:
                double r0 = (double) r3
                goto L4
            L1a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L27
            L20:
                goto L5
            L23:
                goto Lf
            L27:
                int r2 = r0 * r1
                goto L9
            L2d:
                goto L23
        }

        public static void OVcvOiUcaNdgzife(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, bool r2, short r3, int r4, char r5) {
                goto L10
            L4:
                r0 = 42
                goto L20
            La:
                int r2 = r0 * r1
                goto L1a
            L10:
                goto L2c
            L13:
                goto L4
            L17:
                goto L13
            L1a:
                int r3 = r2 + r1
                goto L26
            L20:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L26:
                double r0 = (double) r3
                goto L2b
            L2b:
                return
            L2c:
                goto L17
        }

        public static java.lang.object OxljeKAvQtmVrTKh(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                java.lang.object r0 = r1.getReference()
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static void OxljeKAvQtmVrTKh(java.util.concurrent.atomic.AtomicMarkableReference r0, short r1, char r2, bool r3, float r4) {
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
                int r2 = r0 * r1
                goto L1f
            L1f:
                int r3 = r2 + r1
                goto L14
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L19
            L2b:
                return
            L2c:
                goto La
        }

        public static void OxljeKAvQtmVrTKh(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, float r2, short r3, char r4) {
                goto L10
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            La:
                int r3 = r2 + r1
                goto L25
            L10:
                goto L21
            L13:
                goto L17
            L17:
                r0 = 42
                goto L4
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

        public static void OxljeKAvQtmVrTKh(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, short r2, float r3, char r4) {
                goto Lf
            L4:
                r0 = 42
                goto L2a
            La:
                double r0 = (double) r3
                goto L25
            Lf:
                goto L26
            L12:
                goto L4
            L16:
                int r2 = r0 * r1
                goto L1f
            L1c:
                goto L12
            L1f:
                int r3 = r2 + r1
                goto La
            L25:
                return
            L26:
                goto L1c
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L16
        }

        public static java.util.Dictionary PbYwqDtXoWOXKacn(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                java.util.Dictionary r0 = r1.getKeys()
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static void PbYwqDtXoWOXKacn(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, float r1, char r2, bool r3, java.lang.string r4) {
                goto L10
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L10:
                goto L23
            L13:
                goto L4
            L17:
                double r0 = (double) r3
                goto L22
            L1c:
                int r3 = r2 + r1
                goto L17
            L22:
                return
            L23:
                goto L27
            L27:
                goto L13
            L2a:
                int r2 = r0 * r1
                goto L1c
        }

        public static void PbYwqDtXoWOXKacn(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, float r1, java.lang.string r2, bool r3, char r4) {
                goto L9
            L4:
                double r0 = (double) r3
                goto L2b
            L9:
                goto L2c
            Lc:
                goto L19
            L10:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            L16:
                goto Lc
            L19:
                r0 = 42
                goto L10
            L1f:
                int r3 = r2 + r1
                goto L4
            L25:
                int r2 = r0 * r1
                goto L1f
            L2b:
                return
            L2c:
                goto L16
        }

        public static void PbYwqDtXoWOXKacn(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, bool r1, char r2, float r3, java.lang.string r4) {
                goto L10
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L10:
                goto L1d
            L13:
                goto L4
            L17:
                double r0 = (double) r3
                goto L1c
            L1c:
                return
            L1d:
                goto L27
            L21:
                int r3 = r2 + r1
                goto L17
            L27:
                goto L13
            L2a:
                int r2 = r0 * r1
                goto L21
        }

        public static void PlbtvWPIqGVlTBPL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0) {
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
                r0.scheduleSerializationTaskIfNeeded()
                goto Lb
        }

        public static void PlbtvWPIqGVlTBPL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, char r1, float r2, java.lang.string r3, short r4) {
                goto L4
            L4:
                goto L1a
            L7:
                goto L24
            Lb:
                double r0 = (double) r3
                goto L19
            L10:
                int r3 = r2 + r1
                goto Lb
            L16:
                goto L7
            L19:
                return
            L1a:
                goto L16
            L1e:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L24:
                r0 = 42
                goto L1e
            L2a:
                int r2 = r0 * r1
                goto L10
        }

        public static void PlbtvWPIqGVlTBPL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, float r1, short r2, java.lang.string r3, char r4) {
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
                int r3 = r2 + r1
                goto L16
            L21:
                int r2 = r0 * r1
                goto L1b
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L2d:
                goto L12
        }

        public static void PlbtvWPIqGVlTBPL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, short r1, char r2, java.lang.string r3, float r4) {
                goto L15
            L4:
                r0 = 42
                goto L27
            La:
                return
            Lb:
                goto L2d
            Lf:
                int r2 = r0 * r1
                goto L1c
            L15:
                goto Lb
            L18:
                goto L4
            L1c:
                int r3 = r2 + r1
                goto L22
            L22:
                double r0 = (double) r3
                goto La
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L2d:
                goto L18
        }

        public static com.google.firebase.crashlytics.internal.metadata.MetaDataStore RbrNwoBErAjlniyw(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
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
                com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = com.google.firebase.crashlytics.internal.metadata.UserMetadata.access$200(r1)
                goto L4
        }

        public static void RbrNwoBErAjlniyw(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, float r1, short r2, char r3, int r4) {
                goto Ld
            L4:
                r0 = 42
                goto L2a
            La:
                goto L10
            Ld:
                goto L1a
            L10:
                goto L4
            L14:
                double r0 = (double) r3
                goto L19
            L19:
                return
            L1a:
                goto La
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

        public static void RbrNwoBErAjlniyw(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, int r1, char r2, short r3, float r4) {
                goto L1b
            L4:
                int r3 = r2 + r1
                goto L10
            La:
                int r2 = r0 * r1
                goto L4
            L10:
                double r0 = (double) r3
                goto L2b
            L15:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L1b:
                goto L2c
            L1e:
                goto L22
            L22:
                r0 = 42
                goto L15
            L28:
                goto L1e
            L2b:
                return
            L2c:
                goto L28
        }

        public static void RbrNwoBErAjlniyw(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, int r1, float r2, char r3, short r4) {
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
                int r3 = r2 + r1
                goto L1f
            L19:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L1f:
                double r0 = (double) r3
                goto Le
            L24:
                r0 = 42
                goto L19
            L2a:
                int r2 = r0 * r1
                goto L13
        }

        public static void STvRYRawGriAkEXf(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
                goto Lc
            L4:
                goto Lf
            L7:
                return
            L8:
                goto L4
            Lc:
                goto L8
            Lf:
                goto L13
            L13:
                r0.set(r1, r2)
                goto L7
        }

        public static void STvRYRawGriAkEXf(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, byte r3, char r4, bool r5, short r6) {
                goto L17
            L4:
                goto L1a
            L7:
                int r2 = r0 * r1
                goto L2a
            Ld:
                double r0 = (double) r3
                goto L12
            L12:
                return
            L13:
                goto L4
            L17:
                goto L13
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
                goto Ld
        }

        public static void STvRYRawGriAkEXf(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, char r3, short r4, byte r5, bool r6) {
                goto Lc
            L4:
                double r0 = (double) r3
                goto L2b
            L9:
                goto Lf
            Lc:
                goto L2c
            Lf:
                goto L13
            L13:
                r0 = 42
                goto L19
            L19:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L1f:
                int r2 = r0 * r1
                goto L25
            L25:
                int r3 = r2 + r1
                goto L4
            L2b:
                return
            L2c:
                goto L9
        }

        public static void STvRYRawGriAkEXf(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, bool r3, byte r4, short r5, char r6) {
                goto L23
            L4:
                double r0 = (double) r3
                goto L12
            L9:
                int r3 = r2 + r1
                goto L4
            Lf:
                goto L26
            L12:
                return
            L13:
                goto Lf
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L1d:
                r0 = 42
                goto L17
            L23:
                goto L13
            L26:
                goto L1d
            L2a:
                int r2 = r0 * r1
                goto L9
        }

        private void ScheduleSerializationTaskIfNeeded() {
                r3 = this;
                goto L4f
            L4:
                com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r3 = juOAWXYSyDocYnsI(r3)
                goto L18
            Lc:
                goto L52
            Lf:
                if (r0 <= 0) goto L14
                goto L67
            L14:
                goto L64
            L18:
                com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r3 = r3.diskWrite
                goto L56
            L1e:
                com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary$$ExternalSyntheticLambda0 r0 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary$$ExternalSyntheticLambda0
                goto L72
            L24:
                int r0 = r0 + r1
                goto L2f
            L2a:
                return
            L2b:
                goto L3b
            L2f:
                int r0 = r0 % r1
                goto Lf
            L35:
                java.util.concurrent.atomic.object<java.lang.Action> r1 = r3.queuedSerializer
                goto L42
            L3b:
                goto L67
            L3e:
                goto Lc
            L42:
                r2 = 0
                goto L47
            L47:
                bool r1 = EiMPuXpJxEwaesox(r1, r2, r0)
                goto L7f
            L4f:
                goto L3e
            L52:
                goto L6b
            L56:
                OuLXDvokZuDOBYWY(r3, r0)
            L59:
                goto L2a
            L5d:
                r1 = 5
                goto L24
            L64:
                goto L2b
            L67:
                goto L1e
            L6b:
                r0 = 27
                goto L5d
            L72:
                r0.<init>(r3)
                goto L35
            L79:
                com.google.firebase.crashlytics.internal.metadata.UserMetadata r3 = r3.this$0
                goto L4
            L7f:
                if (r1 != 0) goto L84
                goto L59
            L84:
                goto L79
        }

        private void ScheduleSerializationTaskIfNeeded(short r1, bool r2, byte r3, float r4) {
                r0 = this;
                goto L24
            L4:
                int r3 = r2 + r1
                goto L2b
            La:
                return
            Lb:
                goto L15
            Lf:
                r0 = 42
                goto L18
            L15:
                goto L27
            L18:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1e
            L1e:
                int r2 = r0 * r1
                goto L4
            L24:
                goto Lb
            L27:
                goto Lf
            L2b:
                double r0 = (double) r3
                goto La
        }

        private void ScheduleSerializationTaskIfNeeded(bool r1, short r2, byte r3, float r4) {
                r0 = this;
                goto L29
            L4:
                return
            L5:
                goto Lf
            L9:
                int r3 = r2 + r1
                goto L24
            Lf:
                goto L2c
            L12:
                int r2 = r0 * r1
                goto L9
            L18:
                r0 = 42
                goto L1e
            L1e:
                r1 = 210(0xd2, float:2.94E-43)
                goto L12
            L24:
                double r0 = (double) r3
                goto L4
            L29:
                goto L5
            L2c:
                goto L18
        }

        private void ScheduleSerializationTaskIfNeeded(bool r1, short r2, float r3, byte r4) {
                r0 = this;
                goto L9
            L4:
                return
            L5:
                goto L27
            L9:
                goto L5
            Lc:
                goto L10
            L10:
                r0 = 42
                goto L16
            L16:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L1c:
                double r0 = (double) r3
                goto L4
            L21:
                int r3 = r2 + r1
                goto L1c
            L27:
                goto Lc
            L2a:
                int r2 = r0 * r1
                goto L21
        }

        private void SerializeIfMarked() {
                r4 = this;
                goto L91
            L4:
                r0 = 29
                goto L8a
            Lb:
                throw r0
            Lc:
                goto L18
            L10:
                java.lang.string r2 = kdWiekWiilFVdcpZ(r2)
                goto L84
            L18:
                goto L9b
            L1b:
                goto L2d
            L1f:
                int r0 = r0 % r1
                goto L6e
            L25:
                com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1 = rbrNwoBErAjlniyw(r1)
                goto L7e
            L2d:
                goto L94
            L30:
                monitor-enter(r4)
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r0 = r4.map     // Catch: java.lang.Exception -> L78
                bool r0 = OxJayCMzIXKQmuhp(r0)     // Catch: java.lang.Exception -> L78
                if (r0 == 0) goto L52
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r0 = r4.map     // Catch: java.lang.Exception -> L78
                java.lang.object r0 = oxljeKAvQtmVrTKh(r0)     // Catch: java.lang.Exception -> L78
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r0     // Catch: java.lang.Exception -> L78
                java.util.Dictionary r0 = HVsFjGqBOKQUxyMS(r0)     // Catch: java.lang.Exception -> L78
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r1 = r4.map     // Catch: java.lang.Exception -> L78
                java.lang.object r2 = AuFErmUHkKoLpyFy(r1)     // Catch: java.lang.Exception -> L78
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r2 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r2     // Catch: java.lang.Exception -> L78
                r3 = 0
                EsFciNtuzfnKrdKe(r1, r2, r3)     // Catch: java.lang.Exception -> L78
                goto L53
            L52:
                r0 = 0
            L53:
                monitor-exit(r4)     // Catch: java.lang.Exception -> L78
                goto L58
            L58:
                if (r0 != 0) goto L5d
                goto L6a
            L5d:
                goto L9f
            L61:
                int r0 = r0 + r1
                goto L1f
            L67:
                axvPTeWhCAMrgYyV(r1, r2, r0, r4)
            L6a:
                goto L77
            L6e:
                if (r0 <= 0) goto L73
                goto L9b
            L73:
                goto L98
            L77:
                return
            L78:
                r0 = move-exception
                monitor-exit(r4)     // Catch: java.lang.Exception -> L78
                goto Lb
            L7e:
                com.google.firebase.crashlytics.internal.metadata.UserMetadata r2 = r4.this$0
                goto L10
            L84:
                bool r4 = r4.isInternal
                goto L67
            L8a:
                r1 = 17
                goto L61
            L91:
                goto L1b
            L94:
                goto L4
            L98:
                goto Lc
            L9b:
                goto L30
            L9f:
                com.google.firebase.crashlytics.internal.metadata.UserMetadata r1 = r4.this$0
                goto L25
        }

        private void SerializeIfMarked(float r1, java.lang.string r2, byte r3, int r4) {
                r0 = this;
                goto La
            L4:
                int r3 = r2 + r1
                goto L22
            La:
                goto L18
            Ld:
                goto L2a
            L11:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1c
            L17:
                return
            L18:
                goto L27
            L1c:
                int r2 = r0 * r1
                goto L4
            L22:
                double r0 = (double) r3
                goto L17
            L27:
                goto Ld
            L2a:
                r0 = 42
                goto L11
        }

        private void SerializeIfMarked(int r1, java.lang.string r2, byte r3, float r4) {
                r0 = this;
                goto L4
            L4:
                goto L12
            L7:
                goto Lb
            Lb:
                r0 = 42
                goto L27
            L11:
                return
            L12:
                goto L2d
            L16:
                double r0 = (double) r3
                goto L11
            L1b:
                int r3 = r2 + r1
                goto L16
            L21:
                int r2 = r0 * r1
                goto L1b
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L2d:
                goto L7
        }

        private void SerializeIfMarked(java.lang.string r1, int r2, byte r3, float r4) {
                r0 = this;
                goto L26
            L4:
                double r0 = (double) r3
                goto L15
            L9:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1a
            Lf:
                int r3 = r2 + r1
                goto L4
            L15:
                return
            L16:
                goto L2d
            L1a:
                int r2 = r0 * r1
                goto Lf
            L20:
                r0 = 42
                goto L9
            L26:
                goto L16
            L29:
                goto L20
            L2d:
                goto L29
        }

        public static void UDObaNrRRrfDWCid(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, java.lang.string r2, int r3, java.lang.string r4, bool r5, char r6) {
                goto L18
            L4:
                goto L1b
            L7:
                int r3 = r2 + r1
                goto L25
            Ld:
                int r2 = r0 * r1
                goto L7
            L13:
                return
            L14:
                goto L4
            L18:
                goto L14
            L1b:
                goto L1f
            L1f:
                r0 = 42
                goto L2a
            L25:
                double r0 = (double) r3
                goto L13
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto Ld
        }

        public static void UDObaNrRRrfDWCid(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, java.lang.string r2, int r3, bool r4, char r5, java.lang.string r6) {
                goto L4
            L4:
                goto L12
            L7:
                goto L2a
            Lb:
                int r3 = r2 + r1
                goto L16
            L11:
                return
            L12:
                goto L27
            L16:
                double r0 = (double) r3
                goto L11
            L1b:
                r1 = 210(0xd2, float:2.94E-43)
                goto L21
            L21:
                int r2 = r0 * r1
                goto Lb
            L27:
                goto L7
            L2a:
                r0 = 42
                goto L1b
        }

        public static void UDObaNrRRrfDWCid(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.lang.string r1, java.lang.string r2, bool r3, int r4, char r5, java.lang.string r6) {
                goto L18
            L4:
                double r0 = (double) r3
                goto L2b
            L9:
                goto L1b
            Lc:
                r0 = 42
                goto L12
            L12:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            L18:
                goto L2c
            L1b:
                goto Lc
            L1f:
                int r2 = r0 * r1
                goto L25
            L25:
                int r3 = r2 + r1
                goto L4
            L2b:
                return
            L2c:
                goto L9
        }

        public static bool UDObaNrRRrfDWCid(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r1, java.lang.string r2, java.lang.string r3) {
                goto L11
            L4:
                bool r0 = r1.setKey(r2, r3)
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

        public static java.lang.object WZdUnqxXjAZyZsnh(java.util.concurrent.atomic.AtomicMarkableReference r1) {
                goto Lf
            L4:
                goto L12
            L7:
                java.lang.object r0 = r1.getReference()
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

        public static void WZdUnqxXjAZyZsnh(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, char r2, int r3, java.lang.string r4) {
                goto L15
            L4:
                return
            L5:
                goto L1c
            L9:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            Lf:
                int r3 = r2 + r1
                goto L25
            L15:
                goto L5
            L18:
                goto L1f
            L1c:
                goto L18
            L1f:
                r0 = 42
                goto L9
            L25:
                double r0 = (double) r3
                goto L4
            L2a:
                int r2 = r0 * r1
                goto Lf
        }

        public static void WZdUnqxXjAZyZsnh(java.util.concurrent.atomic.AtomicMarkableReference r0, char r1, java.lang.string r2, byte r3, int r4) {
                goto L23
            L4:
                int r2 = r0 * r1
                goto Ld
            La:
                goto L26
            Ld:
                int r3 = r2 + r1
                goto L19
            L13:
                r0 = 42
                goto L2a
            L19:
                double r0 = (double) r3
                goto L1e
            L1e:
                return
            L1f:
                goto La
            L23:
                goto L1f
            L26:
                goto L13
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static void WZdUnqxXjAZyZsnh(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, int r2, char r3, byte r4) {
                goto L20
            L4:
                r0 = 42
                goto L1a
            La:
                return
            Lb:
                goto L27
            Lf:
                double r0 = (double) r3
                goto La
            L14:
                int r2 = r0 * r1
                goto L2a
            L1a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L14
            L20:
                goto Lb
            L23:
                goto L4
            L27:
                goto L23
            L2a:
                int r3 = r2 + r1
                goto Lf
        }

        public java.util.Dictionary<java.lang.string, java.lang.string> GetKeys() {
                r0 = this;
                goto L4
            L4:
                goto L1b
            L7:
                goto Lb
            Lb:
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r0 = r0.map
                goto L27
            L11:
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r0
                goto L1f
            L17:
                goto L7
            L1a:
                return r0
            L1b:
                goto L17
            L1f:
                java.util.Dictionary r0 = pbYwqDtXoWOXKacn(r0)
                goto L1a
            L27:
                java.lang.object r0 = ABVhrFbAOQMMLeeX(r0)
                goto L11
        }

        /* JADX INFO: renamed from: lambda$scheduleSerializationTaskIfNeeded$0$com-google-firebase-crashlytics-internal-metadata-UserMetadata$SerializeableKeysDictionary */
        /* synthetic */ void m376xb9b680d3() {
                r2 = this;
                goto L2a
            L4:
                r0 = 14
                goto L18
            Lb:
                int r0 = r0 + r1
                goto L1f
            L11:
                goto L3e
            L14:
                goto L57
            L18:
                r1 = 29
                goto Lb
            L1f:
                int r0 = r0 % r1
                goto L31
            L25:
                r1 = 0
                goto L42
            L2a:
                goto L53
            L2d:
                goto L4
            L31:
                if (r0 <= 0) goto L36
                goto L14
            L36:
                goto L11
            L3a:
                goto L2d
            L3d:
                return
            L3e:
                goto L50
            L42:
                GhQRrNigLeQRZTKm(r0, r1)
                goto L49
            L49:
                dECrqosldbfzjxjN(r2)
                goto L3d
            L50:
                goto L14
            L53:
                goto L3a
            L57:
                java.util.concurrent.atomic.object<java.lang.Action> r0 = r2.queuedSerializer
                goto L25
        }

        public bool SetKey(java.lang.string r2, java.lang.string r3) {
                r1 = this;
                goto Lb
            L4:
                TGjfYuRNTattEXHQ(r1)
                goto L12
            Lb:
                goto L40
            Le:
                goto L19
            L12:
                return r0
            L13:
                r2 = move-exception
                monitor-exit(r1)     // Catch: java.lang.Exception -> L13
                goto L3f
            L19:
                monitor-enter(r1)
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r0 = r1.map     // Catch: java.lang.Exception -> L13
                java.lang.object r0 = CZdBQypuVRdoxxTM(r0)     // Catch: java.lang.Exception -> L13
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r0     // Catch: java.lang.Exception -> L13
                bool r2 = uDObaNrRRrfDWCid(r0, r2, r3)     // Catch: java.lang.Exception -> L13
                if (r2 != 0) goto L2b
                r2 = 0
                monitor-exit(r1)     // Catch: java.lang.Exception -> L13
                return r2
            L2b:
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r2 = r1.map     // Catch: java.lang.Exception -> L13
                java.lang.object r3 = ZMLsWWMeTusxRYuX(r2)     // Catch: java.lang.Exception -> L13
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r3 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r3     // Catch: java.lang.Exception -> L13
                r0 = 1
                JtOpPuOyUZRbSnkF(r2, r3, r0)     // Catch: java.lang.Exception -> L13
                monitor-exit(r1)     // Catch: java.lang.Exception -> L13
                goto L4
            L3c:
                goto Le
            L3f:
                throw r2
            L40:
                goto L3c
        }

        public void SetKeys(java.util.Dictionary<java.lang.string, java.lang.string> r3) {
                r2 = this;
                goto L2b
            L4:
                if (r0 <= 0) goto L9
                goto L20
            L9:
                goto L1d
            Ld:
                int r0 = r0 % r1
                goto L4
            L13:
                goto L20
            L16:
                goto L1a
            L1a:
                goto L2e
            L1d:
                goto L5e
            L20:
                goto L40
            L24:
                r0 = 3
                goto L32
            L2b:
                goto L16
            L2e:
                goto L24
            L32:
                r1 = 7
                goto L69
            L39:
                return
            L3a:
                r3 = move-exception
                monitor-exit(r2)     // Catch: java.lang.Exception -> L3a
                goto L5d
            L40:
                monitor-enter(r2)
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r0 = r2.map     // Catch: java.lang.Exception -> L3a
                java.lang.object r0 = VrwsOkkodnnItndF(r0)     // Catch: java.lang.Exception -> L3a
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r0     // Catch: java.lang.Exception -> L3a
                oVcvOiUcaNdgzife(r0, r3)     // Catch: java.lang.Exception -> L3a
                java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r3 = r2.map     // Catch: java.lang.Exception -> L3a
                java.lang.object r0 = wZdUnqxXjAZyZsnh(r3)     // Catch: java.lang.Exception -> L3a
                com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r0     // Catch: java.lang.Exception -> L3a
                r1 = 1
                sTvRYRawGriAkEXf(r3, r0, r1)     // Catch: java.lang.Exception -> L3a
                monitor-exit(r2)     // Catch: java.lang.Exception -> L3a
                goto L62
            L5d:
                throw r3
            L5e:
                goto L13
            L62:
                plbtvWPIqGVlTBPL(r2)
                goto L39
            L69:
                int r0 = r0 + r1
                goto Ld
        }
    }

    public static /* synthetic */ void $r8$lambda$3X8WdNkX736bNwxQHCtA6p6RiHg(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0) {
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
            xYHbrjhZCBGRYWfF(r0)
            goto L4
    }

    public static /* synthetic */ void $r8$lambda$3X8WdNkX736bNwxQHCtA6p6RiHg(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, short r1, char r2, bool r3, int r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            r0 = 42
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L1e
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L2c
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L9
    }

    public static /* synthetic */ void $r8$lambda$3X8WdNkX736bNwxQHCtA6p6RiHg(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, short r1, int r2, char r3, bool r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L23
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L1d
    }

    public static /* synthetic */ void $r8$lambda$3X8WdNkX736bNwxQHCtA6p6RiHg(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, short r2, char r3, int r4) {
            goto L24
        L4:
            goto L27
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            r0 = 42
            goto L18
        L12:
            int r3 = r2 + r1
            goto L7
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            goto L2c
        L27:
            goto Lc
        L2b:
            return
        L2c:
            goto L4
    }

    public UserMetadata(java.lang.string r4, com.google.firebase.crashlytics.internal.persistence.stringStore r5, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r6) {
            r3 = this;
            goto Lf
        L4:
            r2 = 0
            goto L8e
        L9:
            int r0 = r0 + r1
            goto Lb9
        Lf:
            goto L54
        L12:
            goto Lb2
        L16:
            r2 = 128(0x80, float:1.8E-43)
            goto L95
        L1c:
            r3.sessionIdentifier = r4
            goto L39
        L22:
            r4.<init>(r5)
            goto L70
        L29:
            if (r0 <= 0) goto L2e
            goto L79
        L2e:
            goto L76
        L32:
            r3.<init>()
            goto L4b
        L39:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r4 = new com.google.firebase.crashlytics.internal.metadata.MetaDataStore
            goto L22
        L3f:
            r3.rolloutsState = r0
            goto L45
        L45:
            java.util.concurrent.atomic.AtomicMarkableReference r0 = new java.util.concurrent.atomic.AtomicMarkableReference
            goto L4
        L4b:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary
            goto L84
        L51:
            goto L79
        L54:
            goto L9c
        L58:
            r0.<init>(r3, r2)
            goto La6
        L5f:
            return
        L60:
            goto L51
        L64:
            r3.customKeys = r0
            goto L6a
        L6a:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary
            goto L89
        L70:
            r3.metaDataStore = r4
            goto Lac
        L76:
            goto L60
        L79:
            goto L32
        L7d:
            r1 = 3
            goto L9
        L84:
            r1 = 0
            goto L9f
        L89:
            r2 = 1
            goto L58
        L8e:
            r0.<init>(r2, r1)
            goto Lc5
        L95:
            r0.<init>(r2)
            goto L3f
        L9c:
            goto L12
        L9f:
            r0.<init>(r3, r1)
            goto L64
        La6:
            r3.internalKeys = r0
            goto Lbf
        Lac:
            r3.crashlyticsWorkers = r6
            goto L5f
        Lb2:
            r0 = 10
            goto L7d
        Lb9:
            int r0 = r0 % r1
            goto L29
        Lbf:
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0 = new com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList
            goto L16
        Lc5:
            r3.userId = r0
            goto L1c
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BvkcGUvPPPjzXubx() {
            goto L14
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void BvkcGUvPPPjzXubx(char r0, int r1, byte r2, bool r3) {
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

    public static void BvkcGUvPPPjzXubx(int r0, byte r1, char r2, bool r3) {
            goto L1d
        L4:
            return
        L5:
            goto L9
        L9:
            goto L20
        Lc:
            int r3 = r2 + r1
            goto L18
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L12
        L2a:
            int r2 = r0 * r1
            goto Lc
    }

    public static void BvkcGUvPPPjzXubx(bool r0, byte r1, char r2, int r3) {
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

    public static void CcTsOrToenZJlhHa(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.set(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void CcTsOrToenZJlhHa(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, float r3, short r4, char r5, int r6) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            r0 = 42
            goto L15
    }

    public static void CcTsOrToenZJlhHa(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, int r3, float r4, short r5, char r6) {
            goto La
        L4:
            r0 = 42
            goto L14
        La:
            goto L21
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            return
        L21:
            goto L11
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void CcTsOrToenZJlhHa(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, short r3, int r4, char r5, float r6) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L1b
        L13:
            goto L25
        L17:
            goto L13
        L1a:
            return
        L1b:
            goto L17
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void DNWALhkGBiDrqeoS(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, bool r2, int r3, float r4) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L24
        L12:
            int r2 = r0 * r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            int r3 = r2 + r1
            goto Ld
        L24:
            return
        L25:
            goto La
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void DNWALhkGBiDrqeoS(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, byte r2, float r3, int r4) {
            goto L4
        L4:
            goto L11
        L7:
            goto L15
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L21
        L15:
            r0 = 42
            goto L24
        L1b:
            int r3 = r2 + r1
            goto Lb
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void DNWALhkGBiDrqeoS(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, float r2, int r3, byte r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            r0 = 42
            goto Le
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static bool DNWALhkGBiDrqeoS(java.util.concurrent.atomic.AtomicMarkableReference r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isMarked()
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

    public static java.lang.string EElfQPxjOZxuiSnE(java.lang.stringBuilder r1) {
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

    public static void EElfQPxjOZxuiSnE(java.lang.stringBuilder r0, byte r1, java.lang.string r2, bool r3, int r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
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
            goto L17
    }

    public static void EElfQPxjOZxuiSnE(java.lang.stringBuilder r0, bool r1, byte r2, java.lang.string r3, int r4) {
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
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            goto Lc
        L24:
            int r2 = r0 * r1
            goto L1b
        L2a:
            r0 = 42
            goto L10
    }

    public static void EElfQPxjOZxuiSnE(java.lang.stringBuilder r0, bool r1, java.lang.string r2, byte r3, int r4) {
            goto L14
        L4:
            return
        L5:
            goto L1b
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L1e
        L14:
            goto L5
        L17:
            goto L24
        L1b:
            goto L17
        L1e:
            int r3 = r2 + r1
            goto L9
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static java.util.Dictionary EMBlIgooqmQRNZwO(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1) {
            goto Lf
        L4:
            java.util.Dictionary r0 = r1.getKeys()
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

    public static void EMBlIgooqmQRNZwO(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, float r1, int r2, short r3, bool r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            r0 = 42
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L13
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void EMBlIgooqmQRNZwO(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, int r1, short r2, float r3, bool r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto L24
        Lf:
            int r3 = r2 + r1
            goto L4
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void EMBlIgooqmQRNZwO(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, short r1, bool r2, int r3, float r4) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            r0 = 42
            goto L23
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L29:
            goto L5
        L2c:
            goto L1a
    }

    public static void EpcwXLJPsNjlfpwT(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, byte r3, char r4, java.lang.string r5, short r6) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
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
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            r0 = 42
            goto Lf
    }

    public static void EpcwXLJPsNjlfpwT(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, byte r4, char r5, short r6) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L26
        L23:
            goto Ld
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void EpcwXLJPsNjlfpwT(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, short r3, char r4, java.lang.string r5, byte r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            int r3 = r2 + r1
            goto L24
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto L4
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto L1e
    }

    public static bool EpcwXLJPsNjlfpwT(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.setKey(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string FieWghWRGtjAGTMY(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getUserId()
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

    public static void FieWghWRGtjAGTMY(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, int r1, byte r2, bool r3, java.lang.string r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            r0 = 42
            goto L27
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L23
        L18:
            goto L9
        L1c:
            int r2 = r0 * r1
            goto Lf
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2d:
            goto L18
    }

    public static void FieWghWRGtjAGTMY(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, int r2, java.lang.string r3, byte r4) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L2a
        L13:
            double r0 = (double) r3
            goto L7
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            r0 = 42
            goto L24
    }

    public static void FieWghWRGtjAGTMY(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, java.lang.string r2, int r3, byte r4) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L2b
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
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L22:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static int FvQEZvFFReHPdqip(java.util.HashDictionary r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.Count
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FvQEZvFFReHPdqip(java.util.HashDictionary r0, byte r1, int r2, char r3, java.lang.string r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L10:
            return
        L11:
            goto L15
        L15:
            goto L21
        L18:
            int r2 = r0 * r1
            goto L25
        L1e:
            goto L11
        L21:
            goto L4
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void FvQEZvFFReHPdqip(java.util.HashDictionary r0, char r1, byte r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L24
        Lb:
            int r3 = r2 + r1
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            double r0 = (double) r3
            goto L11
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

    public static void FvQEZvFFReHPdqip(java.util.HashDictionary r0, java.lang.string r1, int r2, byte r3, char r4) {
            goto L14
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L2a
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            goto L17
        L2a:
            r0 = 42
            goto L1b
    }

    public static java.util.Dictionary GeZlIFsomPmzzxkH(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1) {
            goto Lc
        L4:
            java.util.Dictionary r0 = r1.getKeys()
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

    public static void GeZlIFsomPmzzxkH(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, float r1, short r2, bool r3, java.lang.string r4) {
            goto L1c
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L16
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            goto L27
        L1f:
            goto La
        L23:
            goto L1f
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void GeZlIFsomPmzzxkH(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, short r1, java.lang.string r2, float r3, bool r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L25
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
            goto L4
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void GeZlIFsomPmzzxkH(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, bool r1, java.lang.string r2, short r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            double r0 = (double) r3
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            r0 = 42
            goto L18
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static java.lang.string HFuUEwsJkubsSGxQ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.readUserId(r2)
            goto L4
    }

    public static void HFuUEwsJkubsSGxQ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, byte r2, int r3, char r4, float r5) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L1a
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static void HFuUEwsJkubsSGxQ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, byte r2, int r3, float r4, char r5) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            goto L21
        L13:
            return
        L14:
            goto L10
        L18:
            r0 = 42
            goto L4
        L1e:
            goto L14
        L21:
            goto L18
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void HFuUEwsJkubsSGxQ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, float r2, byte r3, int r4, char r5) {
            goto L1a
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L1a:
            goto L5
        L1d:
            goto L9
        L21:
            int r2 = r0 * r1
            goto L2a
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void IUXGtFDCmhvLUIFl(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, byte r2, float r3, bool r4, short r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L1f
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            r0 = 42
            goto L4
        L1c:
            goto L27
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto L16
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void IUXGtFDCmhvLUIFl(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, bool r2, byte r3, float r4, short r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L7
    }

    public static void IUXGtFDCmhvLUIFl(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, bool r2, float r3, short r4, byte r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L15
        L10:
            return
        L11:
            goto L20
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto L26
        L23:
            goto L11
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1a
    }

    public static bool IUXGtFDCmhvLUIFl(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1, java.util.List r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.updateRolloutAssignmentList(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void JFavxBeBCcZLxrlL(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, short r2, byte r3, java.lang.string r4, char r5) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void JFavxBeBCcZLxrlL(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, short r2, java.lang.string r3, byte r4, char r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        Lf:
            goto L1b
        L12:
            int r2 = r0 * r1
            goto L1f
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            r0 = 42
            goto L9
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void JFavxBeBCcZLxrlL(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.util.List r1, short r2, java.lang.string r3, char r4, byte r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L1e
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L27
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L1b
    }

    public static bool JFavxBeBCcZLxrlL(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1, java.util.List r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.updateRolloutAssignmentList(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void JGwpIWthkdsXgzLS(java.util.IEnumerator r0, float r1, byte r2, char r3, int r4) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L15
        Le:
            goto La
        L11:
            goto L18
        L15:
            goto L11
        L18:
            r0 = 42
            goto L1e
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

    public static void JGwpIWthkdsXgzLS(java.util.IEnumerator r0, int r1, byte r2, char r3, float r4) {
            goto L10
        L4:
            r0 = 42
            goto L1f
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L17
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void JGwpIWthkdsXgzLS(java.util.IEnumerator r0, int r1, char r2, float r3, byte r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r0 = 42
            goto L4
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L13
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static bool JGwpIWthkdsXgzLS(java.util.IEnumerator r1) {
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

    public static void JiIEdulbNWIabIby(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, float r3, byte r4, int r5, java.lang.string r6) {
            goto L15
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L4
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L10
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L18
    }

    public static void JiIEdulbNWIabIby(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, float r3, int r4, byte r5, java.lang.string r6) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            return
        Lb:
            goto L20
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L15
    }

    public static void JiIEdulbNWIabIby(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, java.lang.string r2, int r3, java.lang.string r4, float r5, byte r6) {
            goto L13
        L4:
            goto L16
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            goto L26
        L16:
            goto L7
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static bool JiIEdulbNWIabIby(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.setKey(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder JmkgQQFSxjjckIMc(java.lang.stringBuilder r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void JmkgQQFSxjjckIMc(java.lang.stringBuilder r0, int r1, byte r2, java.lang.string r3, bool r4, int r5) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            r0 = 42
            goto L2a
        L13:
            double r0 = (double) r3
            goto L1f
        L18:
            goto L20
        L1b:
            goto Ld
        L1f:
            return
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static void JmkgQQFSxjjckIMc(java.lang.stringBuilder r0, int r1, java.lang.string r2, byte r3, bool r4, int r5) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L1f
        L12:
            goto L8
        L15:
            goto L2a
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r0 = 42
            goto L19
    }

    public static void JmkgQQFSxjjckIMc(java.lang.stringBuilder r0, int r1, bool r2, int r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            return
        L5:
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L2c
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto Lf
    }

    public static java.util.List LPpTejZEJFbRRIFX(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.List r0 = r1.getRolloutAssignmentList()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void LPpTejZEJFbRRIFX(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, int r1, bool r2, short r3, java.lang.string r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L23
        L13:
            goto L27
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto L1c
        L2d:
            goto L13
    }

    public static void LPpTejZEJFbRRIFX(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.lang.string r1, int r2, short r3, bool r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            r0 = 42
            goto La
        L20:
            goto L16
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void LPpTejZEJFbRRIFX(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto L1e
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            goto L2c
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L18
        L2b:
            return
        L2c:
            goto L15
    }

    public static java.util.IEnumerator LYKbDIoBqCYYySEG(java.util.HashSet r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.IEnumerator r0 = r1.GetEnumerator()
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

    public static void LYKbDIoBqCYYySEG(java.util.HashSet r0, float r1, char r2, int r3, short r4) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L22
        L1b:
            goto L23
        L1e:
            goto La
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void LYKbDIoBqCYYySEG(java.util.HashSet r0, float r1, char r2, short r3, int r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r0 = 42
            goto L23
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L1f
        L2c:
            goto La
    }

    public static void LYKbDIoBqCYYySEG(java.util.HashSet r0, int r1, float r2, short r3, char r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            r0 = 42
            goto L11
        L1d:
            goto L7
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static java.util.List MmiZOMVKYkUfhCBZ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.List r0 = r1.readRolloutsState(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void MmiZOMVKYkUfhCBZ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, float r2, bool r3, short r4, byte r5) {
            goto L4
        L4:
            goto L18
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L25
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            return
        L18:
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L11
        L22:
            goto L7
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void MmiZOMVKYkUfhCBZ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, short r2, float r3, bool r4, byte r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            r0 = 42
            goto L2a
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
    }

    public static void MmiZOMVKYkUfhCBZ(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, float r3, short r4, byte r5) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L25
        L1c:
            goto Lc
        L1f:
            r0 = 42
            goto L10
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void NukFFJHdWcFPAFeL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.util.Dictionary r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.setKeys(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void NukFFJHdWcFPAFeL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.util.Dictionary r1, byte r2, char r3, bool r4, int r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L21
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto L17
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void NukFFJHdWcFPAFeL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.util.Dictionary r1, char r2, byte r3, bool r4, int r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto Ld
        L2b:
            return
        L2c:
            goto L4
    }

    public static void NukFFJHdWcFPAFeL(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.util.Dictionary r1, char r2, int r3, byte r4, bool r5) {
            goto L29
        L4:
            r0 = 42
            goto L1d
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto Lf
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static java.lang.object ObJvXeSROaOSePRp(java.util.concurrent.atomic.AtomicMarkableReference r1) {
            goto Lf
        L4:
            java.lang.object r0 = r1.getReference()
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

    public static void ObJvXeSROaOSePRp(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, short r2, char r3, bool r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto La
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void ObJvXeSROaOSePRp(java.util.concurrent.atomic.AtomicMarkableReference r0, byte r1, bool r2, char r3, short r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L1b
        L10:
            r0 = 42
            goto L1e
        L16:
            double r0 = (double) r3
            goto Lb
        L1b:
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void ObJvXeSROaOSePRp(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, short r2, char r3, byte r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L14
        L14:
            r0 = 42
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static java.util.List QSIhWhsmujfZSfAS(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1) {
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
            java.util.List r0 = r1.getRolloutAssignmentList()
            goto Le
    }

    public static void QSIhWhsmujfZSfAS(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, int r1, java.lang.string r2, byte r3, char r4) {
            goto L1d
        L4:
            return
        L5:
            goto L15
        L9:
            int r3 = r2 + r1
            goto L18
        Lf:
            r0 = 42
            goto L24
        L15:
            goto L20
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto Lf
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void QSIhWhsmujfZSfAS(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, int r1, java.lang.string r2, char r3, byte r4) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L2a
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
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void QSIhWhsmujfZSfAS(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, java.lang.string r1, int r2, char r3, byte r4) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto Le
        L2c:
            goto L4
    }

    public static java.lang.string RhRAmYpsopGngFPg(java.lang.string r1, int r2) {
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
            java.lang.string r0 = com.google.firebase.crashlytics.internal.metadata.KeysDictionary.sanitizestring(r1, r2)
            goto L4
    }

    public static void RhRAmYpsopGngFPg(java.lang.string r0, int r1, byte r2, bool r3, int r4, short r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L2c
        Lc:
            return
        Ld:
            goto L9
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto Ld
        L2c:
            goto L11
    }

    public static void RhRAmYpsopGngFPg(java.lang.string r0, int r1, short r2, int r3, bool r4, byte r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
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

    public static void RhRAmYpsopGngFPg(java.lang.string r0, int r1, bool r2, short r3, int r4, byte r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L24
        L13:
            goto L17
        L17:
            r0 = 42
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L2b
        L23:
            return
        L24:
            goto L28
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static com.google.android.gms.tasks.Task SOmfLvBGDxxpFVFu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r1, java.lang.Action r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.submit(r2)
            goto L4
    }

    public static void SOmfLvBGDxxpFVFu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, char r2, java.lang.string r3, short r4, bool r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L15
        L10:
            return
        L11:
            goto L21
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void SOmfLvBGDxxpFVFu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, char r2, bool r3, java.lang.string r4, short r5) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            int r3 = r2 + r1
            goto L1f
        Lf:
            goto L5
        L12:
            goto L19
        L16:
            goto L12
        L19:
            r0 = 42
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void SOmfLvBGDxxpFVFu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, java.lang.string r2, short r3, bool r4, char r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L1a
        Lf:
            return
        L10:
            goto L26
        L14:
            int r2 = r0 * r1
            goto L20
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            int r3 = r2 + r1
            goto L4
        L26:
            goto L2c
        L29:
            goto L10
        L2c:
            goto L9
    }

    public static java.lang.object SjOFGROcrnvLmiXr(java.util.concurrent.atomic.AtomicMarkableReference r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.getReference()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void SjOFGROcrnvLmiXr(java.util.concurrent.atomic.AtomicMarkableReference r0, int r1, float r2, char r3, java.lang.string r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            double r0 = (double) r3
            goto La
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto Lb
        L2c:
            goto L17
    }

    public static void SjOFGROcrnvLmiXr(java.util.concurrent.atomic.AtomicMarkableReference r0, int r1, java.lang.string r2, char r3, float r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L27
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L10
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void SjOFGROcrnvLmiXr(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.string r1, int r2, float r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void SshPIyAAEtoSbXWr(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2) {
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
            r0.writeRolloutState(r1, r2)
            goto Le
    }

    public static void SshPIyAAEtoSbXWr(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, char r3, float r4, short r5, int r6) {
            goto L15
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L1c
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L15:
            goto L1d
        L18:
            goto L4
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L18
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void SshPIyAAEtoSbXWr(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, float r3, int r4, short r5, char r6) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L21
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
            return
        L1d:
            goto L26
        L21:
            double r0 = (double) r3
            goto L1c
        L26:
            goto L2c
        L29:
            goto L1d
        L2c:
            goto La
    }

    public static void SshPIyAAEtoSbXWr(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, int r3, float r4, short r5, char r6) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L22
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            int r3 = r2 + r1
            goto L1d
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static void UBrIsAgxeGWTitLV(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
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
            r0.set(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static void UBrIsAgxeGWTitLV(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, char r3, java.lang.string r4, bool r5, int r6) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            goto L1b
        L18:
            goto L26
        L1b:
            goto L9
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto L15
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void UBrIsAgxeGWTitLV(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, java.lang.string r3, char r4, int r5, bool r6) {
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
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r0 = 42
            goto L1e
    }

    public static void UBrIsAgxeGWTitLV(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, java.lang.string r3, int r4, bool r5, char r6) {
            goto L4
        L4:
            goto L18
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
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
            r0 = 42
            goto Lb
    }

    public static java.util.HashSet UbTnDWsuSdbPcQPe(java.util.Dictionary r1) {
            goto Lf
        L4:
            java.util.HashSet r0 = r1.entryHashSet()
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

    public static void UbTnDWsuSdbPcQPe(java.util.Dictionary r0, byte r1, float r2, char r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void UbTnDWsuSdbPcQPe(java.util.Dictionary r0, char r1, float r2, byte r3, bool r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L26
        L10:
            goto L1c
        L13:
            r0 = 42
            goto L20
        L19:
            goto L2c
        L1c:
            goto L13
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static void UbTnDWsuSdbPcQPe(java.util.Dictionary r0, float r1, bool r2, char r3, byte r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            double r0 = (double) r3
            goto L1c
        Lf:
            goto L1d
        L12:
            goto L24
        L16:
            int r3 = r2 + r1
            goto La
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L12
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void VCdZzDAsCpGgXtct(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.writeRolloutState(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void VCdZzDAsCpGgXtct(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, byte r3, char r4, short r5, int r6) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L20
        L17:
            goto L7
        L1a:
            r0 = 42
            goto Lb
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static void VCdZzDAsCpGgXtct(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, char r3, int r4, byte r5, short r6) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L10
        Ld:
            goto L1a
        L10:
            goto L1e
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto La
        L1e:
            r0 = 42
            goto L4
        L24:
            int r3 = r2 + r1
            goto L14
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void VCdZzDAsCpGgXtct(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.List r2, short r3, char r4, byte r5, int r6) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L23
        L18:
            goto L2a
        L1c:
            int r2 = r0 * r1
            goto Lf
        L22:
            return
        L23:
            goto L27
        L27:
            goto L18
        L2a:
            r0 = 42
            goto L4
    }

    public static java.lang.string VzdmZoSaYAJQrpfN(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.getUserId()
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

    public static void VzdmZoSaYAJQrpfN(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, byte r1, char r2, short r3, int r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r0 = 42
            goto L23
        L12:
            return
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L7
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L13
        L2c:
            goto Lc
    }

    public static void VzdmZoSaYAJQrpfN(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, char r1, int r2, short r3, byte r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            double r0 = (double) r3
            goto L24
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto L7
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static void VzdmZoSaYAJQrpfN(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, short r1, int r2, byte r3, char r4) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L20
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static void WlHjAchNZHRsknig(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2) {
            goto Lb
        L4:
            r0.set(r1, r2)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void WlHjAchNZHRsknig(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, int r3, char r4, java.lang.string r5, bool r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            goto L23
        Ld:
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r0 = 42
            goto L11
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L17
        L2d:
            goto Ld
    }

    public static void WlHjAchNZHRsknig(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, java.lang.string r3, char r4, bool r5, int r6) {
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0 = 42
            goto L24
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
        L19:
            double r0 = (double) r3
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void WlHjAchNZHRsknig(java.util.concurrent.atomic.AtomicMarkableReference r0, java.lang.object r1, bool r2, java.lang.string r3, int r4, bool r5, char r6) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1c
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L1d
        L18:
            goto Lf
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L18
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void WlizLzhGbbQOKZuK(java.util.List r0, char r1, byte r2, bool r3, int r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L18
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
            int r3 = r2 + r1
            goto L10
        L2a:
            r0 = 42
            goto La
    }

    public static void WlizLzhGbbQOKZuK(java.util.List r0, char r1, bool r2, int r3, byte r4) {
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L1d:
            r0 = 42
            goto L17
        L23:
            int r2 = r0 * r1
            goto L9
        L29:
            goto L5
        L2c:
            goto L1d
    }

    public static void WlizLzhGbbQOKZuK(java.util.List r0, int r1, byte r2, char r3, bool r4) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L24
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static bool WlizLzhGbbQOKZuK(java.util.List r1) {
            goto L11
        L4:
            bool r0 = r1.Count == 0
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

    public static java.lang.string XHRycInVVQtOxTcX(com.google.firebase.crashlytics.internal.metadata.UserMetadata r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getUserId()
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

    public static void XHRycInVVQtOxTcX(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, float r1, int r2, char r3, short r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void XHRycInVVQtOxTcX(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, float r1, short r2, char r3, int r4) {
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
            int r3 = r2 + r1
            goto Le
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
            return
        L2c:
            goto L4
    }

    public static void XHRycInVVQtOxTcX(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, short r1, int r2, char r3, float r4) {
            goto L23
        L4:
            r0 = 42
            goto L1a
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L14
    }

    public static void XcCobvMdvOlGhOsD(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.m359w(r1)
            goto L7
    }

    public static void XcCobvMdvOlGhOsD(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, int r3, short r4, float r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            r0 = 42
            goto L9
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto L26
        L1e:
            return
        L1f:
            goto L1b
        L23:
            goto L1f
        L26:
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void XcCobvMdvOlGhOsD(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, short r3, int r4, char r5) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            return
        L1d:
            goto L28
        L21:
            goto L1d
        L24:
            goto L10
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L1c
    }

    public static void XcCobvMdvOlGhOsD(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, int r3, float r4, char r5) {
            goto L1e
        L4:
            r0 = 42
            goto L18
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L21
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto L14
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static java.util.Dictionary ZPGSnDYaikbsqrxG(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1, java.lang.string r2, bool r3) {
            goto L14
        L4:
            java.util.Dictionary r0 = r1.readKeyData(r2, r3)
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

    public static void ZPGSnDYaikbsqrxG(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, byte r3, int r4, float r5, bool r6) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L27
        L19:
            r0 = 42
            goto L4
        L1f:
            return
        L20:
            goto L16
        L24:
            goto L20
        L27:
            goto L19
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void ZPGSnDYaikbsqrxG(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, float r3, bool r4, int r5, byte r6) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            return
        L11:
            goto L15
        L15:
            goto L26
        L18:
            double r0 = (double) r3
            goto L10
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L11
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void ZPGSnDYaikbsqrxG(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, bool r3, float r4, byte r5, int r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            goto L29
        Ld:
            goto L22
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r0 = 42
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void ZdwLiHLKuCcOPHVO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.writeUserData(r1, r2)
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

    public static void ZdwLiHLKuCcOPHVO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, short r3, char r4, bool r5, float r6) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L27
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void ZdwLiHLKuCcOPHVO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, short r3, float r4, bool r5, char r6) {
            goto L24
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            goto L27
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            goto L5
        L27:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void ZdwLiHLKuCcOPHVO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, short r3, bool r4, char r5, float r6) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L22
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static java.util.Dictionary ZorAMzgtgNnjqKtY(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1) {
            goto Lf
        L4:
            java.util.Dictionary r0 = r1.getKeys()
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

    public static void ZorAMzgtgNnjqKtY(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, char r1, int r2, short r3, java.lang.string r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L1e
        L14:
            return
        L15:
            goto Lb
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void ZorAMzgtgNnjqKtY(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, char r1, short r2, int r3, java.lang.string r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            goto L2c
        L18:
            int r2 = r0 * r1
            goto L4
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

    public static void ZorAMzgtgNnjqKtY(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, int r2, short r3, char r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L21
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    static /* synthetic */ com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers access$000(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r0 = r0.crashlyticsWorkers
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    static /* synthetic */ void access$000(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, byte r1, int r2, short r3, char r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L10:
            r0 = 42
            goto La
        L16:
            return
        L17:
            goto L28
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            goto L17
        L24:
            goto L10
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L16
    }

    static /* synthetic */ void access$000(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, char r1, int r2, short r3, byte r4) {
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

    static /* synthetic */ void access$000(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, short r1, int r2, char r3, byte r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L16
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            r0 = 42
            goto Lb
        L1c:
            int r2 = r0 * r1
            goto L25
        L22:
            goto L7
        L25:
            int r3 = r2 + r1
            goto L11
        L2b:
            return
        L2c:
            goto L22
    }

    static /* synthetic */ java.lang.string access$100(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0) {
            goto La
        L4:
            java.lang.string r0 = r0.sessionIdentifier
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, byte r1, int r2, java.lang.string r3, char r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L1e
        L13:
            r0 = 42
            goto L23
        L19:
            return
        L1a:
            goto La
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L1a
        L2c:
            goto L13
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, java.lang.string r1, byte r2, int r3, char r4) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, java.lang.string r1, int r2, char r3, byte r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L16
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L10
        L2d:
            goto Lc
    }

    static /* synthetic */ com.google.firebase.crashlytics.internal.metadata.MetaDataStore access$200(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0) {
            goto La
        L4:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = r0.metaDataStore
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }

    static /* synthetic */ void access$200(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, float r1, char r2, byte r3, bool r4) {
            goto L26
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L4
        L2d:
            goto L29
    }

    static /* synthetic */ void access$200(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, char r2, byte r3, float r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto L1a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L26
        L1d:
            r0 = 42
            goto L4
        L23:
            goto Lb
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    static /* synthetic */ void access$200(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, bool r1, float r2, byte r3, char r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L23
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            r0 = 42
            goto Ld
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

    public static void BpHLmGZMzSIvhXQO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            r0.writeUserData(r1, r2)
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

    public static void BpHLmGZMzSIvhXQO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, char r3, java.lang.string r4, int r5, short r6) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L26
        L12:
            return
        L13:
            goto Lf
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto L13
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L17
    }

    public static void BpHLmGZMzSIvhXQO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, int r3, char r4, short r5, java.lang.string r6) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r3 = r2 + r1
            goto La
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            r0 = 42
            goto L1a
        L26:
            goto L10
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void BpHLmGZMzSIvhXQO(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, short r4, char r5, int r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            int r3 = r2 + r1
            goto L4
        L1d:
            r0 = 42
            goto L9
        L23:
            int r2 = r0 * r1
            goto L17
        L29:
            goto L13
        L2c:
            goto L1d
    }

    public static java.lang.object CfAXiXagjbQscESx(java.util.concurrent.atomic.AtomicMarkableReference r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1.getReference()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void CfAXiXagjbQscESx(java.util.concurrent.atomic.AtomicMarkableReference r0, short r1, byte r2, int r3, bool r4) {
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
            goto L21
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            goto L10
        L1d:
            goto L24
        L21:
            goto L1d
        L24:
            r0 = 42
            goto L14
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void CfAXiXagjbQscESx(java.util.concurrent.atomic.AtomicMarkableReference r0, short r1, int r2, bool r3, byte r4) {
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
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto L12
    }

    public static void CfAXiXagjbQscESx(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, short r2, int r3, byte r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            goto L21
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            return
        L21:
            goto L11
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static java.util.List DdbBZLMwYgwtxGfY(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1) {
            goto Lc
        L4:
            java.util.List r0 = r1.getReportRolloutsState()
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

    public static void DdbBZLMwYgwtxGfY(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, float r1, short r2, bool r3, byte r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            r0 = 42
            goto Lf
        L29:
            goto L16
        L2c:
            goto L23
    }

    public static void DdbBZLMwYgwtxGfY(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, short r1, float r2, bool r3, byte r4) {
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
            goto L27
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            goto L10
        L1d:
            goto L9
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void DdbBZLMwYgwtxGfY(com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0, bool r1, short r2, float r3, byte r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L20
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            return
        L20:
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            r0 = 42
            goto L24
    }

    public static com.google.android.gms.tasks.Task EzxKHmOnTwomScIe(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r1, java.lang.Action r2) {
            goto Lf
        L4:
            com.google.android.gms.tasks.Task r0 = r1.submit(r2)
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

    public static void EzxKHmOnTwomScIe(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, byte r2, java.lang.string r3, bool r4, short r5) {
            goto L24
        L4:
            return
        L5:
            goto L9
        L9:
            goto L27
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r0 = 42
            goto Lc
        L24:
            goto L5
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void EzxKHmOnTwomScIe(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, java.lang.string r2, bool r3, byte r4, short r5) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            double r0 = (double) r3
            goto L4
        L18:
            int r3 = r2 + r1
            goto L13
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

    public static void EzxKHmOnTwomScIe(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, bool r2, short r3, byte r4, java.lang.string r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            r0 = 42
            goto L2a
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void FpbJCJSJVVFfswpb(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1) {
            goto L10
        L4:
            r0.setKeys(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void FpbJCJSJVVFfswpb(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, int r2, java.lang.string r3, float r4, short r5) {
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
            goto L2a
        L15:
            int r3 = r2 + r1
            goto L9
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            goto L11
        L2a:
            r0 = 42
            goto L21
    }

    public static void FpbJCJSJVVFfswpb(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, int r2, short r3, float r4, java.lang.string r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L2c
        L12:
            goto L22
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            r0 = 42
            goto L4
        L28:
            goto L12
        L2b:
            return
        L2c:
            goto L28
    }

    public static void FpbJCJSJVVFfswpb(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, java.lang.string r2, float r3, int r4, short r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto Le
        L25:
            r0 = 42
            goto L14
        L2b:
            return
        L2c:
            goto Lb
    }

    public static java.lang.string FxUuplAvYCUrDRQs(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.readUserId(r2)
            goto Le
    }

    public static void FxUuplAvYCUrDRQs(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, char r2, bool r3, byte r4, float r5) {
            goto L12
        L4:
            r0 = 42
            goto L2a
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void FxUuplAvYCUrDRQs(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, float r2, byte r3, char r4, bool r5) {
            goto La
        L4:
            r0 = 42
            goto L17
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L1d
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void FxUuplAvYCUrDRQs(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, float r2, char r3, bool r4, byte r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            r0 = 42
            goto L24
        Lf:
            goto L20
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static java.lang.string HbUPMJOnDjpzcTEe(java.lang.string r1, int r2) {
            goto Lf
        L4:
            java.lang.string r0 = com.google.firebase.crashlytics.internal.metadata.KeysDictionary.sanitizestring(r1, r2)
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

    public static void HbUPMJOnDjpzcTEe(java.lang.string r0, int r1, byte r2, float r3, char r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            goto L29
        Ld:
            goto L1c
        L11:
            double r0 = (double) r3
            goto L28
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void HbUPMJOnDjpzcTEe(java.lang.string r0, int r1, byte r2, java.lang.string r3, char r4, float r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            int r2 = r0 * r1
            goto L1c
        L28:
            goto L7
        L2b:
            return
        L2c:
            goto L28
    }

    public static void HbUPMJOnDjpzcTEe(java.lang.string r0, int r1, float r2, java.lang.string r3, char r4, byte r5) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto Ld
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
            goto L24
        L1d:
            goto L13
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto L17
    }

    public static java.util.Dictionary JeyfBvfgeerMPuoQ(java.util.Dictionary r1) {
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
            java.util.Dictionary r0 = java.util.ICollections.unmodifiableDictionary(r1)
            goto L4
        L18:
            goto Lc
    }

    public static void JeyfBvfgeerMPuoQ(java.util.Dictionary r0, byte r1, short r2, char r3, int r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L24
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r0 = 42
            goto L1e
    }

    public static void JeyfBvfgeerMPuoQ(java.util.Dictionary r0, char r1, short r2, byte r3, int r4) {
            goto L24
        L4:
            r0 = 42
            goto L1e
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L27
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void JeyfBvfgeerMPuoQ(java.util.Dictionary r0, short r1, int r2, byte r3, char r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L1c
        L15:
            goto L11
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            double r0 = (double) r3
            goto L10
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2a:
            r0 = 42
            goto L24
    }

    public static com.google.firebase.crashlytics.internal.metadata.UserMetadata LoadFromExistingSession(java.lang.string r3, com.google.firebase.crashlytics.internal.persistence.stringStore r4, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r5) {
            goto Lbc
        L4:
            r1 = 32
            goto L12
        Lb:
            r0 = 16
            goto L4
        L12:
            int r0 = r0 + r1
            goto L87
        L18:
            r1.<init>(r3, r4, r5)
            goto L7c
        L1f:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = new com.google.firebase.crashlytics.internal.metadata.MetaDataStore
            goto L5d
        L25:
            if (r0 <= 0) goto L2a
            goto L4d
        L2a:
            goto L4a
        L2e:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r4 = r1.internalKeys
            goto Lb0
        L34:
            UBrIsAgxeGWTitLV(r4, r2, r5)
            goto Lde
        L3b:
            java.util.List r3 = MmiZOMVKYkUfhCBZ(r0, r3)
            goto L43
        L43:
            IUXGtFDCmhvLUIFl(r4, r3)
            goto L77
        L4a:
            goto L78
        L4d:
            goto L1f
        L51:
            goto L4d
        L54:
            goto Ld3
        L58:
            r5 = 0
            goto Lcb
        L5d:
            r0.<init>(r4)
            goto Lb6
        L64:
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r4 = r1.userId
            goto Ld6
        L6a:
            fpbJCJSJVVFfswpb(r4, r2)
            goto L64
        L71:
            java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r4 = r4.map
            goto La8
        L77:
            return r1
        L78:
            goto L51
        L7c:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r4 = r1.customKeys
            goto L71
        L82:
            r2 = 1
            goto Lc3
        L87:
            int r0 = r0 % r1
            goto L25
        L8d:
            tcSFxiiTkgKYWhTm(r4, r2)
            goto L2e
        L94:
            java.lang.object r4 = rsxcHtWXorLEKPNL(r4)
            goto L9c
        L9c:
            com.google.firebase.crashlytics.internal.metadata.KeysDictionary r4 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r4
            goto L82
        La2:
            com.google.firebase.crashlytics.internal.metadata.KeysDictionary r4 = (com.google.firebase.crashlytics.internal.metadata.KeysDictionary) r4
            goto L58
        La8:
            java.lang.object r4 = ObJvXeSROaOSePRp(r4)
            goto La2
        Lb0:
            java.util.concurrent.atomic.AtomicMarkableReference<com.google.firebase.crashlytics.internal.metadata.KeysDictionary> r4 = r4.map
            goto L94
        Lb6:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata r1 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata
            goto L18
        Lbc:
            goto L54
        Lbf:
            goto Lb
        Lc3:
            java.util.Dictionary r2 = ZPGSnDYaikbsqrxG(r0, r3, r2)
            goto L6a
        Lcb:
            java.util.Dictionary r2 = lrpRMSrvCgIflPWT(r0, r3, r5)
            goto L8d
        Ld3:
            goto Lbf
        Ld6:
            java.lang.string r2 = fxUuplAvYCUrDRQs(r0, r3)
            goto L34
        Lde:
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r4 = r1.rolloutsState
            goto L3b
    }

    public static void LoadFromExistingSession(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r2, int r3, float r4, short r5, byte r6) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto Ld
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
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
            goto L4
        L29:
            goto L25
        L2c:
            goto L7
    }

    public static void LoadFromExistingSession(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r2, short r3, byte r4, int r5, float r6) {
            goto L4
        L4:
            goto L12
        L7:
            goto L25
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            return
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            r0 = 42
            goto L16
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void LoadFromExistingSession(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r2, short r3, float r4, byte r5, int r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L2c
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1e:
            r0 = 42
            goto L18
        L24:
            return
        L25:
            goto L15
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static java.util.Dictionary LrpRMSrvCgIflPWT(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r1, java.lang.string r2, bool r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.Dictionary r0 = r1.readKeyData(r2, r3)
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

    public static void LrpRMSrvCgIflPWT(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, byte r3, char r4, short r5, float r6) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L25
        L16:
            goto L1e
        L19:
            goto La
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L19
        L25:
            double r0 = (double) r3
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void LrpRMSrvCgIflPWT(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, float r3, byte r4, char r5, short r6) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L20
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
            goto Le
    }

    public static void LrpRMSrvCgIflPWT(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, bool r2, float r3, char r4, byte r5, short r6) {
            goto L4
        L4:
            goto L21
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L2a
        L11:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto L11
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static java.lang.object MPIhleYFyNUUdopk(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void MPIhleYFyNUUdopk(java.util.IEnumerator r0, float r1, int r2, java.lang.string r3, bool r4) {
            goto L24
        L4:
            r0 = 42
            goto L1e
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            return
        L11:
            goto L15
        L15:
            goto L27
        L18:
            int r2 = r0 * r1
            goto La
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            goto L11
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void MPIhleYFyNUUdopk(java.util.IEnumerator r0, float r1, bool r2, int r3, java.lang.string r4) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L12:
            int r3 = r2 + r1
            goto L24
        L18:
            r0 = 42
            goto Lc
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto L18
    }

    public static void MPIhleYFyNUUdopk(java.util.IEnumerator r0, int r1, java.lang.string r2, float r3, bool r4) {
            goto L20
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
            goto L2d
        L1a:
            r0 = 42
            goto L27
        L20:
            goto L16
        L23:
            goto L1a
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2d:
            goto L23
    }

    public static java.util.Dictionary MQlAXNbOOALAngpr(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1) {
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
            java.util.Dictionary r0 = r1.getKeys()
            goto L7
    }

    public static void MQlAXNbOOALAngpr(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, int r1, bool r2, short r3, java.lang.string r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto L9
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void MQlAXNbOOALAngpr(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, java.lang.string r1, int r2, bool r3, short r4) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L12:
            goto L5
        L15:
            goto L24
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void MQlAXNbOOALAngpr(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, bool r1, short r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L4
        L29:
            goto L1c
        L2c:
            goto L23
    }

    public static java.util.Dictionary OnVyfdBPaDbDgpQW(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r1) {
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
            java.util.Dictionary r0 = r1.getKeys()
            goto L7
    }

    public static void OnVyfdBPaDbDgpQW(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, byte r1, float r2, java.lang.string r3, bool r4) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            goto L26
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto Ld
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void OnVyfdBPaDbDgpQW(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, byte r1, bool r2, float r3, java.lang.string r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            double r0 = (double) r3
            goto L1c
        Lf:
            goto L1d
        L12:
            goto L24
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L12
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void OnVyfdBPaDbDgpQW(com.google.firebase.crashlytics.internal.metadata.UserMetadata.SerializeableKeysDictionary r0, float r1, java.lang.string r2, byte r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            r0 = 42
            goto L9
        L1c:
            goto L12
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

    public static void PzsevDmQGSgHGyLc(java.util.Dictionary r0, char r1, float r2, java.lang.string r3, short r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L22
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void PzsevDmQGSgHGyLc(java.util.Dictionary r0, char r1, java.lang.string r2, float r3, short r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            r0 = 42
            goto L1c
        L15:
            goto L23
        L18:
            goto Lf
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            return
        L23:
            goto L27
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void PzsevDmQGSgHGyLc(java.util.Dictionary r0, float r1, short r2, java.lang.string r3, char r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    public static bool PzsevDmQGSgHGyLc(java.util.Dictionary r1) {
            goto L11
        L4:
            bool r0 = r1.Count == 0
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

    public static java.lang.object RabdPKAMPEsEKxlk(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.getValue()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void RabdPKAMPEsEKxlk(java.util.Dictionary.Entry r0, java.lang.string r1, bool r2, short r3, int r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
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
            goto L4
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void RabdPKAMPEsEKxlk(java.util.Dictionary.Entry r0, bool r1, java.lang.string r2, short r3, int r4) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L22
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
            int r3 = r2 + r1
            goto L16
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static void RabdPKAMPEsEKxlk(java.util.Dictionary.Entry r0, bool r1, short r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            goto L7
        L1f:
            r0 = 42
            goto Lb
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static java.lang.string ReadUserId(java.lang.string r1, com.google.firebase.crashlytics.internal.persistence.stringStore r2) {
            goto L1b
        L4:
            goto L1e
        L7:
            return r1
        L8:
            goto L4
        Lc:
            java.lang.string r1 = HFuUEwsJkubsSGxQ(r0, r1)
            goto L7
        L14:
            r0.<init>(r2)
            goto Lc
        L1b:
            goto L8
        L1e:
            goto L22
        L22:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = new com.google.firebase.crashlytics.internal.metadata.MetaDataStore
            goto L14
    }

    public static void ReadUserId(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2, int r3, byte r4, short r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L2c
        L1e:
            goto L15
        L22:
            goto L1e
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto L22
    }

    public static void ReadUserId(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, java.lang.string r2, short r3, byte r4, int r5) {
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

    public static void ReadUserId(java.lang.string r0, com.google.firebase.crashlytics.internal.persistence.stringStore r1, short r2, byte r3, java.lang.string r4, int r5) {
            goto L17
        L4:
            goto L1a
        L7:
            int r2 = r0 * r1
            goto L24
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
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static java.lang.object RsxcHtWXorLEKPNL(java.util.concurrent.atomic.AtomicMarkableReference r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.getReference()
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

    public static void RsxcHtWXorLEKPNL(java.util.concurrent.atomic.AtomicMarkableReference r0, short r1, int r2, char r3, bool r4) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L10:
            goto L27
        L13:
            return
        L14:
            goto L10
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            goto L14
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void RsxcHtWXorLEKPNL(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, char r2, short r3, int r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L17
        L11:
            int r3 = r2 + r1
            goto L25
        L17:
            r1 = 210(0xd2, float:2.94E-43)
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
            int r2 = r0 * r1
            goto L11
    }

    public static void RsxcHtWXorLEKPNL(java.util.concurrent.atomic.AtomicMarkableReference r0, bool r1, short r2, char r3, int r4) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L20
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            goto La
        L20:
            goto L24
        L24:
            r0 = 42
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void SAYjbAZMDVTehibo(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2) {
            goto L13
        L4:
            r0.writeKeyData(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void SAYjbAZMDVTehibo(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, float r3, bool r4, java.lang.string r5, int r6) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L21
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            return
        L1d:
            goto L27
        L21:
            r0 = 42
            goto L10
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void SAYjbAZMDVTehibo(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, java.lang.string r3, int r4, bool r5, float r6) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L24
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void SAYjbAZMDVTehibo(com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0, java.lang.string r1, java.util.Dictionary r2, bool r3, float r4, int r5, java.lang.string r6) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L20
        L11:
            r0 = 42
            goto L1a
        L17:
            goto L7
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto Lb
        L2b:
            return
        L2c:
            goto L17
    }

    private void SerializeUserDataIfNeeded() {
            r4 = this;
            goto L81
        L4:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = r4.metaDataStore
            goto L69
        La:
            goto L84
        Ld:
            goto L7d
        L10:
            goto L38
        L14:
            goto L10
        L17:
            goto La
        L1b:
            return
        L1c:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1c
            goto L7c
        L22:
            int r0 = r0 % r1
            goto L59
        L28:
            if (r2 != 0) goto L2d
            goto L65
        L2d:
            goto L4
        L31:
            r0 = 7
            goto L75
        L38:
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r0 = r4.userId
            goto L3e
        L3e:
            monitor-enter(r0)
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r1 = r4.userId     // Catch: java.lang.Exception -> L1c
            bool r1 = DNWALhkGBiDrqeoS(r1)     // Catch: java.lang.Exception -> L1c
            r2 = 0
            if (r1 == 0) goto L53
            java.lang.string r1 = VzdmZoSaYAJQrpfN(r4)     // Catch: java.lang.Exception -> L1c
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r3 = r4.userId     // Catch: java.lang.Exception -> L1c
            CcTsOrToenZJlhHa(r3, r1, r2)     // Catch: java.lang.Exception -> L1c
            r2 = 1
            goto L54
        L53:
            r1 = 0
        L54:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1c
            goto L28
        L59:
            if (r0 <= 0) goto L5e
            goto L10
        L5e:
            goto Ld
        L62:
            ZdwLiHLKuCcOPHVO(r0, r4, r1)
        L65:
            goto L1b
        L69:
            java.lang.string r4 = r4.sessionIdentifier
            goto L62
        L6f:
            int r0 = r0 + r1
            goto L22
        L75:
            r1 = 10
            goto L6f
        L7c:
            throw r4
        L7d:
            goto L14
        L81:
            goto L17
        L84:
            goto L31
    }

    private void SerializeUserDataIfNeeded(int r1, bool r2, byte r3, java.lang.string r4) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L1f
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    private void SerializeUserDataIfNeeded(bool r1, byte r2, int r3, java.lang.string r4) {
            r0 = this;
            goto L20
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
            goto L27
        L1a:
            r0 = 42
            goto L2a
        L20:
            goto L16
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    private void SerializeUserDataIfNeeded(bool r1, int r2, byte r3, java.lang.string r4) {
            r0 = this;
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L21
        L18:
            r0 = 42
            goto L4
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void TcSFxiiTkgKYWhTm(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1) {
            goto Lb
        L4:
            r0.setKeys(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void TcSFxiiTkgKYWhTm(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, byte r2, int r3, java.lang.string r4, bool r5) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L22
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L28
        L1b:
            goto L29
        L1e:
            goto La
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void TcSFxiiTkgKYWhTm(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, int r2, bool r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto La
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
            goto L4
    }

    public static void TcSFxiiTkgKYWhTm(com.google.firebase.crashlytics.internal.metadata.KeysDictionary r0, java.util.Dictionary r1, bool r2, int r3, java.lang.string r4, byte r5) {
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

    public static java.lang.string TfWIhLKQFcrKUUIF(java.lang.string r1, int r2) {
            goto Lf
        L4:
            java.lang.string r0 = com.google.firebase.crashlytics.internal.metadata.KeysDictionary.sanitizestring(r1, r2)
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

    public static void TfWIhLKQFcrKUUIF(java.lang.string r0, int r1, byte r2, char r3, short r4, java.lang.string r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L18
        L13:
            goto L1f
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            r0 = 42
            goto L4
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void TfWIhLKQFcrKUUIF(java.lang.string r0, int r1, java.lang.string r2, byte r3, char r4, short r5) {
            goto Lf
        L4:
            return
        L5:
            goto L28
        L9:
            int r2 = r0 * r1
            goto L22
        Lf:
            goto L5
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            r0 = 42
            goto L16
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void TfWIhLKQFcrKUUIF(java.lang.string r0, int r1, short r2, java.lang.string r3, char r4, byte r5) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static java.lang.object TtzyipRKIJzaBhjE(java.util.HashDictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static void TtzyipRKIJzaBhjE(java.util.HashDictionary r0, java.lang.object r1, java.lang.object r2, byte r3, java.lang.string r4, int r5, bool r6) {
            goto L21
        L4:
            r0 = 42
            goto L15
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            int r3 = r2 + r1
            goto L28
        L21:
            goto Lb
        L24:
            goto L4
        L28:
            double r0 = (double) r3
            goto La
        L2d:
            goto L24
    }

    public static void TtzyipRKIJzaBhjE(java.util.HashDictionary r0, java.lang.object r1, java.lang.object r2, java.lang.string r3, int r4, bool r5, byte r6) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L14
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto L20
        L17:
            int r2 = r0 * r1
            goto L4
        L1d:
            goto Lb
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            r0 = 42
            goto L24
    }

    public static void TtzyipRKIJzaBhjE(java.util.HashDictionary r0, java.lang.object r1, java.lang.object r2, bool r3, byte r4, java.lang.string r5, int r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L1b
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L15
        L2a:
            r0 = 42
            goto L1e
    }

    public static void UZNEbXdoCwqCLHxs(java.util.Dictionary r0, byte r1, float r2, int r3, short r4) {
            goto L1a
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
            goto L27
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            int r3 = r2 + r1
            goto La
        L27:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void UZNEbXdoCwqCLHxs(java.util.Dictionary r0, short r1, float r2, byte r3, int r4) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto Ld
        L29:
            goto Le
        L2c:
            goto L7
    }

    public static void UZNEbXdoCwqCLHxs(java.util.Dictionary r0, short r1, int r2, byte r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L26
        Ld:
            goto L1f
        L11:
            int r3 = r2 + r1
            goto L1a
        L17:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L4
        L25:
            return
        L26:
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static bool UZNEbXdoCwqCLHxs(java.util.Dictionary r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.Count == 0
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void UjAvBxHwudgBlTff(java.lang.string r0, java.lang.string r1, float r2, bool r3, int r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L18
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
            r0 = 42
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void UjAvBxHwudgBlTff(java.lang.string r0, java.lang.string r1, bool r2, float r3, int r4, short r5) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r0 = 42
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L2a
        L20:
            goto Lb
        L23:
            goto L14
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void UjAvBxHwudgBlTff(java.lang.string r0, java.lang.string r1, bool r2, int r3, float r4, short r5) {
            goto L29
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L24
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L4
        L29:
            goto L5
        L2c:
            goto L9
    }

    public static bool UjAvBxHwudgBlTff(java.lang.string r1, java.lang.string r2) {
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
            bool r0 = com.google.firebase.crashlytics.internal.common.CommonUtils.nullSafeEquals(r1, r2)
            goto Lb
    }

    public static void WoZuLbeYMUhvKsdF(java.util.HashDictionary r0, java.lang.object r1, int r2, char r3, bool r4, byte r5) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L24
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L18:
            r0 = 42
            goto L12
        L1e:
            int r2 = r0 * r1
            goto L7
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L18
    }

    public static void WoZuLbeYMUhvKsdF(java.util.HashDictionary r0, java.lang.object r1, bool r2, byte r3, char r4, int r5) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            r0 = 42
            goto L4
        L20:
            goto Lb
        L23:
            goto L1a
        L27:
            int r3 = r2 + r1
            goto L15
        L2d:
            goto L23
    }

    public static void WoZuLbeYMUhvKsdF(java.util.HashDictionary r0, java.lang.object r1, bool r2, char r3, byte r4, int r5) {
            goto L23
        L4:
            r0 = 42
            goto L18
        La:
            goto L26
        Ld:
            int r2 = r0 * r1
            goto L2a
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
            goto L1f
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static bool WoZuLbeYMUhvKsdF(java.util.HashDictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.ContainsKey(r2)
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

    public static com.google.android.gms.tasks.Task WziZzGQouaqBzjLE(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r1, java.lang.Action r2) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.submit(r2)
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

    public static void WziZzGQouaqBzjLE(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, char r2, java.lang.string r3, float r4, int r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L24
        Lf:
            goto L2c
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L18
    }

    public static void WziZzGQouaqBzjLE(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, float r2, java.lang.string r3, char r4, int r5) {
            goto L24
        L4:
            goto L27
        L7:
            int r2 = r0 * r1
            goto L1e
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L1a
        L27:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void WziZzGQouaqBzjLE(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r0, java.lang.Action r1, int r2, char r3, java.lang.string r4, float r5) {
            goto L1a
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
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L1d
    }

    public static void XYHbrjhZCBGRYWfF(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.serializeUserDataIfNeeded()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void XYHbrjhZCBGRYWfF(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, byte r1, int r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L16
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            goto L7
        L1f:
            int r3 = r2 + r1
            goto L11
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void XYHbrjhZCBGRYWfF(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, float r1, byte r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            r0 = 42
            goto L20
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1b
        L16:
            return
        L17:
            goto L26
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L2c
        L29:
            goto L17
        L2c:
            goto L4
    }

    public static void XYHbrjhZCBGRYWfF(com.google.firebase.crashlytics.internal.metadata.UserMetadata r0, int r1, byte r2, java.lang.string r3, float r4) {
            goto Ld
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L1f
        L1a:
            return
        L1b:
            goto La
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.stringBuilder XgZbIgraOrJLYPDk(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void XgZbIgraOrJLYPDk(java.lang.stringBuilder r0, java.lang.string r1, float r2, short r3, char r4, java.lang.string r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            r0 = 42
            goto L7
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void XgZbIgraOrJLYPDk(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, float r4, short r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L4
    }

    public static void XgZbIgraOrJLYPDk(java.lang.stringBuilder r0, java.lang.string r1, short r2, java.lang.string r3, float r4, char r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L1b
        Ld:
            goto L2a
        L11:
            goto Ld
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            return
        L1b:
            goto L11
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.object YCcoSZMLaLkuKCxo(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.getKey()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void YCcoSZMLaLkuKCxo(java.util.Dictionary.Entry r0, float r1, int r2, java.lang.string r3, short r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            goto L1b
        L10:
            goto L14
        L14:
            r0 = 42
            goto L2a
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L7
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void YCcoSZMLaLkuKCxo(java.util.Dictionary.Entry r0, float r1, short r2, int r3, java.lang.string r4) {
            goto L17
        L4:
            goto L1a
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            r0 = 42
            goto L1e
    }

    public static void YCcoSZMLaLkuKCxo(java.util.Dictionary.Entry r0, java.lang.string r1, short r2, int r3, float r4) {
            goto L24
        L4:
            goto L27
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            r0 = 42
            goto L7
        L24:
            goto Le
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetCustomKeys() {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            java.util.Dictionary r0 = GeZlIFsomPmzzxkH(r0)
            goto L1c
        L13:
            goto L7
        L16:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = r0.customKeys
            goto Lb
        L1c:
            return r0
        L1d:
            goto L13
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetCustomKeys(java.util.Dictionary<java.lang.string, java.lang.string> r7) {
            r6 = this;
            goto L72
        L4:
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1
            goto Ld1
        La:
            return r6
        Lb:
            goto Lf7
        Lf:
            java.lang.string r2 = RhRAmYpsopGngFPg(r2, r3)
            goto L16c
        L17:
            int r7 = r7 + 1
            goto L147
        L1d:
            r7 = 0
        L1e:
            goto Lc9
        L22:
            bool r0 = uZNEbXdoCwqCLHxs(r7)
            goto L4c
        L2a:
            java.lang.string r7 = EElfQPxjOZxuiSnE(r7)
            goto L138
        L32:
            goto L1e
        L33:
            goto L15b
        L37:
            ttzyipRKIJzaBhjE(r0, r2, r1)
            goto L32
        L3e:
            java.util.HashSet r6 = UbTnDWsuSdbPcQPe(r7)
            goto L164
        L46:
            goto L149
        L48:
            goto L17
        L4c:
            if (r0 != 0) goto L51
            goto L105
        L51:
            goto L115
        L55:
            java.util.Dictionary r6 = onVyfdBPaDbDgpQW(r6)
            goto L104
        L5d:
            goto Lb
        L60:
            goto L22
        L64:
            java.lang.object r1 = mPIhleYFyNUUdopk(r6)
            goto L4
        L6c:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L87
        L72:
            goto Lfa
        L75:
            goto La4
        L79:
            bool r4 = woZuLbeYMUhvKsdF(r0, r2)
            goto Lee
        L81:
            java.lang.string r1 = " keys when adding event specific keys. Maximum allowable: 1024"
            goto Lc1
        L87:
            java.lang.string r2 = "Ignored "
            goto L131
        L8d:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r6 = r6.customKeys
            goto L11b
        L93:
            java.util.Dictionary r6 = jeyfBvfgeerMPuoQ(r0)
            goto La
        L9b:
            if (r4 >= r5) goto La0
            goto L149
        La0:
            goto L79
        La4:
            r0 = 19
            goto Le7
        Lab:
            r0.<init>(r6)
            goto L3e
        Lb2:
            if (r1 != 0) goto Lb7
            goto L33
        Lb7:
            goto L64
        Lbb:
            int r0 = r0 % r1
            goto L177
        Lc1:
            java.lang.stringBuilder r7 = xgZbIgraOrJLYPDk(r7, r1)
            goto L2a
        Lc9:
            bool r1 = JGwpIWthkdsXgzLS(r6)
            goto Lb2
        Ld1:
            java.lang.object r2 = yCcoSZMLaLkuKCxo(r1)
            goto L12b
        Ld9:
            java.lang.string r1 = tfWIhLKQFcrKUUIF(r1, r3)
            goto L37
        Le1:
            r3 = 1024(0x400, float:1.435E-42)
            goto Lf
        Le7:
            r1 = 30
            goto L155
        Lee:
            if (r4 != 0) goto Lf3
            goto L48
        Lf3:
            goto L46
        Lf7:
            goto L60
        Lfa:
            goto L174
        Lfe:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto Lab
        L104:
            return r6
        L105:
            goto L8d
        L109:
            java.lang.string r1 = (java.lang.string) r1
            goto Ld9
        L10f:
            r5 = 64
            goto L9b
        L115:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r6 = r6.customKeys
            goto L55
        L11b:
            java.util.Dictionary r6 = mQlAXNbOOALAngpr(r6)
            goto Lfe
        L123:
            java.lang.object r1 = rabdPKAMPEsEKxlk(r1)
            goto L109
        L12b:
            java.lang.string r2 = (java.lang.string) r2
            goto Le1
        L131:
            r1.<init>(r2)
            goto L14d
        L138:
            XcCobvMdvOlGhOsD(r6, r7)
        L13b:
            goto L93
        L13f:
            com.google.firebase.crashlytics.internal.Consoleger r6 = BvkcGUvPPPjzXubx()
            goto L6c
        L147:
            goto L1e
        L149:
            goto L123
        L14d:
            java.lang.stringBuilder r7 = JmkgQQFSxjjckIMc(r1, r7)
            goto L81
        L155:
            int r0 = r0 + r1
            goto Lbb
        L15b:
            if (r7 > 0) goto L160
            goto L13b
        L160:
            goto L13f
        L164:
            java.util.IEnumerator r6 = LYKbDIoBqCYYySEG(r6)
            goto L1d
        L16c:
            int r4 = FvQEZvFFReHPdqip(r0)
            goto L10f
        L174:
            goto L75
        L177:
            if (r0 <= 0) goto L17c
            goto L60
        L17c:
            goto L5d
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetInternalKeys() {
            r0 = this;
            goto Lc
        L4:
            java.util.Dictionary r0 = ZorAMzgtgNnjqKtY(r0)
            goto L1c
        Lc:
            goto L1d
        Lf:
            goto L16
        L13:
            goto Lf
        L16:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = r0.internalKeys
            goto L4
        L1c:
            return r0
        L1d:
            goto L13
    }

    public java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport.Session.Event.RolloutAssignment> GetRolloutsState() {
            r0 = this;
            goto La
        L4:
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0 = r0.rolloutsState
            goto L19
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
        L19:
            java.util.List r0 = ddbBZLMwYgwtxGfY(r0)
            goto L14
    }

    public java.lang.string GetUserId() {
            r0 = this;
            goto L15
        L4:
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r0 = r0.userId
            goto La
        La:
            java.lang.object r0 = SjOFGROcrnvLmiXr(r0)
            goto L1c
        L12:
            goto L18
        L15:
            goto L23
        L18:
            goto L4
        L1c:
            java.lang.string r0 = (java.lang.string) r0
            goto L22
        L22:
            return r0
        L23:
            goto L12
    }

    /* JADX INFO: renamed from: lambda$setNewSession$0$com-google-firebase-crashlytics-internal-metadata-UserMetadata */
    /* synthetic */ void m374xeeb41fb7(java.lang.string r3, java.util.Dictionary r4, java.util.List r5) {
            r2 = this;
            goto L20
        L4:
            SshPIyAAEtoSbXWr(r2, r3, r5)
        L7:
            goto L6c
        Lb:
            int r0 = r0 % r1
            goto L97
        L11:
            if (r0 != 0) goto L16
            goto L48
        L16:
            goto L71
        L1a:
            int r0 = r0 + r1
            goto Lb
        L20:
            goto L57
        L23:
            goto L8d
        L27:
            goto L6d
        L2a:
            goto L4c
        L2e:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = r2.metaDataStore
            goto L7e
        L34:
            bool r4 = WlizLzhGbbQOKZuK(r5)
            goto L5b
        L3c:
            if (r0 == 0) goto L41
            goto L81
        L41:
            goto L2e
        L45:
            bpHLmGZMzSIvhXQO(r0, r3, r1)
        L48:
            goto L85
        L4c:
            java.lang.string r0 = XHRycInVVQtOxTcX(r2)
            goto L11
        L54:
            goto L2a
        L57:
            goto L94
        L5b:
            if (r4 == 0) goto L60
            goto L7
        L60:
            goto La0
        L64:
            java.lang.string r1 = FieWghWRGtjAGTMY(r2)
            goto L45
        L6c:
            return
        L6d:
            goto L54
        L71:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = r2.metaDataStore
            goto L64
        L77:
            r1 = 11
            goto L1a
        L7e:
            sAYjbAZMDVTehibo(r0, r3, r4)
        L81:
            goto L34
        L85:
            bool r0 = pzsevDmQGSgHGyLc(r4)
            goto L3c
        L8d:
            r0 = 3
            goto L77
        L94:
            goto L23
        L97:
            if (r0 <= 0) goto L9c
            goto L2a
        L9c:
            goto L27
        La0:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r2 = r2.metaDataStore
            goto L4
    }

    /* JADX INFO: renamed from: lambda$updateRolloutsState$1$com-google-firebase-crashlytics-internal-metadata-UserMetadata */
    /* synthetic */ void m375x8982b7e8(java.util.List r2) {
            r1 = this;
            goto L11
        L4:
            java.lang.string r1 = r1.sessionIdentifier
            goto La
        La:
            VCdZzDAsCpGgXtct(r0, r1, r2)
            goto L1e
        L11:
            goto L1f
        L14:
            goto L18
        L18:
            com.google.firebase.crashlytics.internal.metadata.MetaDataStore r0 = r1.metaDataStore
            goto L4
        L1e:
            return
        L1f:
            goto L23
        L23:
            goto L14
    }

    public bool SetCustomKey(java.lang.string r1, java.lang.string r2) {
            r0 = this;
            goto L11
        L4:
            bool r0 = JiIEdulbNWIabIby(r0, r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L1e
        L11:
            goto Ld
        L14:
            goto L18
        L18:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = r0.customKeys
            goto L4
        L1e:
            goto L14
    }

    public void SetCustomKeys(java.util.Dictionary<java.lang.string, java.lang.string> r1) {
            r0 = this;
            goto L14
        L4:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = r0.customKeys
            goto Ld
        La:
            goto L17
        Ld:
            NukFFJHdWcFPAFeL(r0, r1)
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

    public bool SetInternalKey(java.lang.string r1, java.lang.string r2) {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            goto L7
        Le:
            bool r0 = EpcwXLJPsNjlfpwT(r0, r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
        L1b:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r0 = r0.internalKeys
            goto Le
    }

    public void SetNewSession(java.lang.string r6) {
            r5 = this;
            goto L51
        L4:
            goto L13
        L7:
            goto L41
        Lb:
            r1 = 14
            goto L58
        L12:
            throw r5
        L13:
            goto L47
        L17:
            r0 = 14
            goto Lb
        L1e:
            monitor-enter(r0)
            r5.sessionIdentifier = r6     // Catch: java.lang.Exception -> L3b
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$SerializeableKeysDictionary r1 = r5.customKeys     // Catch: java.lang.Exception -> L3b
            java.util.Dictionary r1 = EMBlIgooqmQRNZwO(r1)     // Catch: java.lang.Exception -> L3b
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r2 = r5.rolloutsState     // Catch: java.lang.Exception -> L3b
            java.util.List r2 = LPpTejZEJFbRRIFX(r2)     // Catch: java.lang.Exception -> L3b
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r3 = r5.crashlyticsWorkers     // Catch: java.lang.Exception -> L3b
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r3 = r3.diskWrite     // Catch: java.lang.Exception -> L3b
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda1 r4 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda1     // Catch: java.lang.Exception -> L3b
            r4.<init>(r5, r6, r1, r2)     // Catch: java.lang.Exception -> L3b
            SOmfLvBGDxxpFVFu(r3, r4)     // Catch: java.lang.Exception -> L3b
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3b
            return
        L3b:
            r5 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3b
            goto L12
        L41:
            java.lang.string r0 = r5.sessionIdentifier
            goto L1e
        L47:
            goto L7
        L4a:
            goto L4e
        L4e:
            goto L54
        L51:
            goto L4a
        L54:
            goto L17
        L58:
            int r0 = r0 + r1
            goto L67
        L5e:
            if (r0 <= 0) goto L63
            goto L7
        L63:
            goto L4
        L67:
            int r0 = r0 % r1
            goto L5e
    }

    public void SetUserId(java.lang.string r4) {
            r3 = this;
            goto L46
        L4:
            goto L49
        L7:
            if (r0 <= 0) goto Lc
            goto L7b
        Lc:
            goto L78
        L10:
            r0.<init>(r3)
            goto L6b
        L17:
            monitor-enter(r0)
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r1 = r3.userId     // Catch: java.lang.Exception -> L80
            java.lang.object r1 = cfAXiXagjbQscESx(r1)     // Catch: java.lang.Exception -> L80
            java.lang.string r1 = (java.lang.string) r1     // Catch: java.lang.Exception -> L80
            bool r1 = ujAvBxHwudgBlTff(r4, r1)     // Catch: java.lang.Exception -> L80
            if (r1 == 0) goto L28
            monitor-exit(r0)     // Catch: java.lang.Exception -> L80
            return
        L28:
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r1 = r3.userId     // Catch: java.lang.Exception -> L80
            r2 = 1
            WlHjAchNZHRsknig(r1, r4, r2)     // Catch: java.lang.Exception -> L80
            monitor-exit(r0)     // Catch: java.lang.Exception -> L80
            goto L72
        L33:
            r1 = 20
            goto L4d
        L3a:
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda2 r0 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda2
            goto L10
        L40:
            r0 = 1024(0x400, float:1.435E-42)
            goto L8d
        L46:
            goto L89
        L49:
            goto L59
        L4d:
            int r0 = r0 + r1
            goto L65
        L53:
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r4 = r4.diskWrite
            goto L3a
        L59:
            r0 = 31
            goto L33
        L60:
            throw r3
        L61:
            goto L86
        L65:
            int r0 = r0 % r1
            goto L7
        L6b:
            ezxKHmOnTwomScIe(r4, r0)
            goto L7f
        L72:
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r4 = r3.crashlyticsWorkers
            goto L53
        L78:
            goto L61
        L7b:
            goto L40
        L7f:
            return
        L80:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L80
            goto L60
        L86:
            goto L7b
        L89:
            goto L4
        L8d:
            java.lang.string r4 = hbUPMJOnDjpzcTEe(r4, r0)
            goto L95
        L95:
            java.util.concurrent.atomic.AtomicMarkableReference<java.lang.string> r0 = r3.userId
            goto L17
    }

    public bool UpdateRolloutsState(java.util.List<com.google.firebase.crashlytics.internal.metadata.RolloutAssignment> r4) {
            r3 = this;
            goto L3c
        L4:
            throw r3
        L5:
            goto L29
        L9:
            r0 = 11
            goto L6a
        L10:
            if (r0 <= 0) goto L15
            goto L1c
        L15:
            goto L19
        L19:
            goto L5
        L1c:
            goto L23
        L20:
            goto L3f
        L23:
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r0 = r3.rolloutsState
            goto L43
        L29:
            goto L1c
        L2c:
            goto L20
        L30:
            int r0 = r0 % r1
            goto L10
        L36:
            int r0 = r0 + r1
            goto L30
        L3c:
            goto L2c
        L3f:
            goto L9
        L43:
            monitor-enter(r0)
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r1 = r3.rolloutsState     // Catch: java.lang.Exception -> L64
            bool r4 = JFavxBeBCcZLxrlL(r1, r4)     // Catch: java.lang.Exception -> L64
            if (r4 != 0) goto L4f
            r3 = 0
            monitor-exit(r0)     // Catch: java.lang.Exception -> L64
            return r3
        L4f:
            com.google.firebase.crashlytics.internal.metadata.RolloutAssignmentList r4 = r3.rolloutsState     // Catch: java.lang.Exception -> L64
            java.util.List r4 = QSIhWhsmujfZSfAS(r4)     // Catch: java.lang.Exception -> L64
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers r1 = r3.crashlyticsWorkers     // Catch: java.lang.Exception -> L64
            com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker r1 = r1.diskWrite     // Catch: java.lang.Exception -> L64
            com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda0 r2 = new com.google.firebase.crashlytics.internal.metadata.UserMetadata$$ExternalSyntheticLambda0     // Catch: java.lang.Exception -> L64
            r2.<init>(r3, r4)     // Catch: java.lang.Exception -> L64
            wziZzGQouaqBzjLE(r1, r2)     // Catch: java.lang.Exception -> L64
            r3 = 1
            monitor-exit(r0)     // Catch: java.lang.Exception -> L64
            return r3
        L64:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L64
            goto L4
        L6a:
            r1 = 27
            goto L36
    }
}

