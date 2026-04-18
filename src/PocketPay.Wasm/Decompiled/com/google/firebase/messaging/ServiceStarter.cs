namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ServiceStarter {
    static readonly java.lang.string ACTION_MESSAGING_EVENT = "com.google.firebase.MESSAGING_EVENT";
    static readonly int ERROR_ILLEGAL_STATE_EXCEPTION = 402;
    static readonly int ERROR_ILLEGAL_STATE_EXCEPTION_FALLBACK_TO_BIND = 403;
    static readonly int ERROR_NOT_FOUND = 404;
    static readonly int ERROR_SECUriTY_EXCEPTION = 401;
    public static readonly int ERROR_UNKNOWN = 500;
    private static readonly java.lang.string EXTRA_WRAPPED_INTENT = "wrapped_intent";
    private static readonly java.lang.string PERMISSIONS_MISSING_HINT = "this should normally be included by the manifest merger, but may needed to be manually added to your manifest";
    public static readonly int SUCCESS = -1;
    private static com.google.firebase.messaging.ServiceStarter instance;
    private java.lang.string firebaseMessagingServiceClassName;
    private java.lang.bool hasAccessNetworkStatePermission;
    private java.lang.bool hasWakeLockPermission;
    private readonly java.util.Queue<android.content.object> messagingEvents;

    private ServiceStarter() {
            r1 = this;
            goto L38
        L4:
            r1.hasAccessNetworkStatePermission = r0
            goto La
        La:
            java.util.ArrayQueue r0 = new java.util.ArrayQueue
            goto L29
        L10:
            r1.hasWakeLockPermission = r0
            goto L4
        L16:
            r1.firebaseMessagingServiceClassName = r0
            goto L10
        L1c:
            r1.messagingEvents = r0
            goto L30
        L22:
            r1.<init>()
            goto L3f
        L29:
            r0.<init>()
            goto L1c
        L30:
            return
        L31:
            goto L35
        L35:
            goto L3b
        L38:
            goto L31
        L3b:
            goto L22
        L3f:
            r0 = 0
            goto L16
    }

    public static int AgSmdLIXCtcNtgxb(android.content.object r1, java.lang.string r2) {
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
            int r0 = r1.checkCallingOrSelfPermission(r2)
            goto Le
    }

    public static int CSxNDAypIRUEDirQ(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static java.lang.stringBuilder DgXwfiGVDeEQasHk(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.stringBuilder FfALgPmWylBVwMyI(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static android.content.ComponentName JbLIDGSZbdFpkDEL(android.content.object r1, android.content.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.ComponentName r0 = r1.startService(r2)
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

    public static java.lang.bool JoBXkQVGBWpYlBKR(bool r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

    public static android.content.object KljsJrkPpkpoPfFl(android.content.object r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.content.object r0 = r1.setPackage(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder KugdKgaJvyMIOQJH(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static int LAixmDtTUzcGMFcP(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = android.util.Console.e(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static android.content.pm.ResolveInfo NnIvYoiCooASYIrQ(android.content.pm.PackageManager r1, android.content.object r2, int r3) {
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
            android.content.pm.ResolveInfo r0 = r1.resolveService(r2, r3)
            goto Le
    }

    public static java.lang.stringBuilder PgfObVHGfeHXZcYm(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static int QVXVpysOAckLrHvL(com.google.firebase.messaging.ServiceStarter r1, android.content.object r2, android.content.object r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.doStartService(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool QhAUqOinJRSmFEsg(com.google.firebase.messaging.ServiceStarter r1, android.content.object r2) {
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
            bool r0 = r1.hasWakeLockPermission(r2)
            goto Le
    }

    public static bool QxVPiqUHMHzwjRwm(java.lang.bool r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.boolValue()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static android.content.object SEIivAGLOrXXvucv(android.content.object r1, java.lang.string r2, java.lang.string r3) {
            goto Lf
        L4:
            android.content.object r0 = r1.setClassName(r2, r3)
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

    public static bool VJWvWGAWxUzZjYuS(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string VXLWCnVJXSUIwVBz(android.content.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getPackageName()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.stringBuilder VhDrCaNjWDLOaSJl(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.string XQdGTnHFIZkHTTmj(android.content.object r1) {
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
            java.lang.string r0 = r1.getPackageName()
            goto Le
    }

    public static java.lang.string XgpRBEQzFPdgHUKU(android.content.object r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getPackageName()
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

    public static android.content.ComponentName YptMlgGQFvtMstoV(android.content.object r1, android.content.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.ComponentName r0 = com.google.firebase.messaging.WakeLockHolder.startWakefulService(r1, r2)
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

    public static bool YwEFTFMPGoVMeXWK(java.lang.bool r1) {
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

    public static int ACbJHJKRQpjTXUMf(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string BNmWZGhACawdwTen(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string BPBgZQJpRwLvhRMH(java.lang.stringBuilder r1) {
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

    public static bool BSOgQAoRZJsfeVyY(java.lang.bool r1) {
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

    public static bool CudjuhPzHXeDdNof(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string DLURBUmgaNIyiUfW(java.lang.stringBuilder r1) {
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

    public static int DeeGTfmEwUCzPPeV(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.d(r1, r2)
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

    private int DoStartService(android.content.object r5, android.content.object r6) {
            r4 = this;
            goto L65
        L4:
            goto La6
        L7:
            goto L83
        Lb:
            SEIivAGLOrXXvucv(r6, r2, r0)
        Le:
            bool r4 = QhAUqOinJRSmFEsg(r4, r5)     // Catch: java.lang.IllegalStateException -> L5a java.lang.SecurityException -> Lbc
            if (r4 == 0) goto L19
            android.content.ComponentName r4 = YptMlgGQFvtMstoV(r5, r6)     // Catch: java.lang.IllegalStateException -> L5a java.lang.SecurityException -> Lbc
            goto L22
        L19:
            android.content.ComponentName r4 = JbLIDGSZbdFpkDEL(r5, r6)     // Catch: java.lang.IllegalStateException -> L5a java.lang.SecurityException -> Lbc
            java.lang.string r5 = "Missing wake lock permission, service start may be delayed"
            aCbJHJKRQpjTXUMf(r1, r5)     // Catch: java.lang.IllegalStateException -> L5a java.lang.SecurityException -> Lbc
        L22:
            if (r4 != 0) goto Le5
            java.lang.string r4 = "Error while delivering the message: Serviceobject not found."
            vsnHbRJKAYenjnPD(r1, r4)     // Catch: java.lang.IllegalStateException -> L5a java.lang.SecurityException -> Lbc
            goto L3c
        L2d:
            if (r0 <= 0) goto L32
            goto L7
        L32:
            goto L4
        L36:
            int r0 = r0 % r1
            goto L2d
        L3c:
            r4 = 404(0x194, float:5.66E-43)
            goto Le4
        L42:
            java.lang.string r2 = bPBgZQJpRwLvhRMH(r2)
            goto Lf6
        L4a:
            java.lang.stringBuilder r2 = DgXwfiGVDeEQasHk(r2, r0)
            goto L42
        L52:
            goto L7
        L55:
            goto Lb2
        L59:
            return r4
        L5a:
            r4 = move-exception
            goto L119
        L5f:
            r4 = 402(0x192, float:5.63E-43)
            goto Lbb
        L65:
            goto L55
        L68:
            goto L104
        L6c:
            java.lang.string r1 = "FirebaseMessaging"
            goto L8b
        L72:
            java.lang.string r5 = "Error while delivering the message to the serviceobject"
            goto Lfd
        L78:
            r4 = -1
            goto L59
        L7d:
            int r0 = r0 + r1
            goto L36
        L83:
            java.lang.string r0 = nVpTZlnCmuzljqvs(r4, r5, r6)
            goto L6c
        L8b:
            if (r0 != 0) goto L90
            goto Le
        L90:
            goto L11f
        L94:
            bool r2 = rkHifPIHjCBTcvXM(r1, r2)
            goto L9c
        L9c:
            if (r2 != 0) goto La1
            goto Lf9
        La1:
            goto Lb5
        La5:
            return r4
        La6:
            goto L52
        Laa:
            java.lang.string r4 = pfBnPjLNyYpfYpyw(r4)
            goto Lc1
        Lb2:
            goto L68
        Lb5:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Lf0
        Lbb:
            return r4
        Lbc:
            r4 = move-exception
            goto L72
        Lc1:
            LAixmDtTUzcGMFcP(r1, r4)
            goto L5f
        Lc8:
            java.lang.string r2 = kYeTaTRVgSCPlemY(r5)
            goto Lb
        Ld0:
            r4 = 401(0x191, float:5.62E-43)
            goto La5
        Ld6:
            r5.<init>(r6)
            goto L111
        Ldd:
            r1 = 8
            goto L7d
        Le4:
            return r4
        Le5:
            goto L78
        Le9:
            r2.<init>(r3)
            goto L4a
        Lf0:
            java.lang.string r3 = "Restricting intent to a specific service: "
            goto Le9
        Lf6:
            yGkxdmVXLmkYWuwW(r1, r2)
        Lf9:
            goto Lc8
        Lfd:
            wwxCiAgVpCUYgZyn(r1, r5, r4)
            goto Ld0
        L104:
            r0 = 5
            goto Ldd
        L10b:
            java.lang.string r6 = "Failed to start service while in background: "
            goto Ld6
        L111:
            java.lang.stringBuilder r4 = VhDrCaNjWDLOaSJl(r5, r4)
            goto Laa
        L119:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L10b
        L11f:
            r2 = 3
            goto L94
    }

    public static bool EzytCXHVAsJpOgXK(java.lang.bool r1) {
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

    static com.google.firebase.messaging.ServiceStarter GetInstance() {
            goto L2f
        L4:
            return r1
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto Lb
        Lb:
            throw r1
        Lc:
            goto L1c
        L10:
            monitor-exit(r0)
            goto L4
        L15:
            r1 = 26
            goto L29
        L1c:
            goto L64
        L1f:
            goto L51
        L23:
            java.lang.Class<com.google.firebase.messaging.ServiceStarter> r0 = com.google.firebase.messaging.ServiceStarter.class
            goto L36
        L29:
            int r0 = r0 + r1
            goto L54
        L2f:
            goto L1f
        L32:
            goto L5a
        L36:
            monitor-enter(r0)
            com.google.firebase.messaging.ServiceStarter r1 = com.google.firebase.messaging.ServiceStarter.instance     // Catch: java.lang.Exception -> L5
            if (r1 != 0) goto L42
            com.google.firebase.messaging.ServiceStarter r1 = new com.google.firebase.messaging.ServiceStarter     // Catch: java.lang.Exception -> L5
            r1.<init>()     // Catch: java.lang.Exception -> L5
            com.google.firebase.messaging.ServiceStarter.instance = r1     // Catch: java.lang.Exception -> L5
        L42:
            com.google.firebase.messaging.ServiceStarter r1 = com.google.firebase.messaging.ServiceStarter.instance     // Catch: java.lang.Exception -> L5
            goto L10
        L48:
            if (r0 <= 0) goto L4d
            goto L64
        L4d:
            goto L61
        L51:
            goto L32
        L54:
            int r0 = r0 % r1
            goto L48
        L5a:
            r0 = 24
            goto L15
        L61:
            goto Lc
        L64:
            goto L23
    }

    public static int GgMUscdCgzwqzzPq(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static android.content.pm.PackageManager GnrOrHuCoywjddUM(android.content.object r1) {
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
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto Le
    }

    public static java.lang.stringBuilder KNVsorkzooBEjxfT(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.string KYeTaTRVgSCPlemY(android.content.object r1) {
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
            java.lang.string r0 = r1.getPackageName()
            goto L4
        L18:
            goto Lc
    }

    public static bool KgfUPFupnMdvyqbR(java.lang.string r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int LyoBdgYxSeAlPnKe(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto L4
    }

    public static java.lang.stringBuilder NHtlwsCZFSigJuwC(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string NVpTZlnCmuzljqvs(com.google.firebase.messaging.ServiceStarter r1, android.content.object r2, android.content.object r3) {
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
            java.lang.string r0 = r1.resolveServiceClassName(r2, r3)
            goto Lb
    }

    public static bool PMMIvRQAkpCPQLyq(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.StartsWith(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string PfBnPjLNyYpfYpyw(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
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

    private java.lang.string ResolveServiceClassName(android.content.object r5, android.content.object r6) {
            r4 = this;
            goto Leb
        L4:
            int r0 = r0 + r1
            goto Lf
        La:
            monitor-exit(r4)
            goto L91
        Lf:
            int r0 = r0 % r1
            goto L1c
        L15:
            r1 = 13
            goto L4
        L1c:
            if (r0 <= 0) goto L21
            goto L7b
        L21:
            goto L78
        L25:
            goto Lee
        L28:
            return r1
        L29:
            java.lang.string r5 = "FirebaseMessaging"
            java.lang.string r6 = "Failed to resolve target intent service, skipping classname enforcement"
            CSxNDAypIRUEDirQ(r5, r6)     // Catch: java.lang.Exception -> Le5
            goto L34
        L34:
            monitor-exit(r4)
            goto Le4
        L39:
            r0 = 28
            goto L15
        L40:
            throw r5
        L41:
            goto Lf2
        L45:
            if (r1 != 0) goto L4a
            goto L92
        L4a:
            goto La
        L4e:
            monitor-exit(r4)
            goto L28
        L53:
            return r5
        L54:
            java.lang.string r5 = "FirebaseMessaging"
            java.lang.stringBuilder r2 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Le5
            r2.<init>(r0)     // Catch: java.lang.Exception -> Le5
            java.lang.string r0 = r6.packageName     // Catch: java.lang.Exception -> Le5
            java.lang.stringBuilder r0 = kNVsorkzooBEjxfT(r2, r0)     // Catch: java.lang.Exception -> Le5
            java.lang.string r2 = "/"
            java.lang.stringBuilder r0 = PgfObVHGfeHXZcYm(r0, r2)     // Catch: java.lang.Exception -> Le5
            java.lang.string r6 = r6.name     // Catch: java.lang.Exception -> Le5
            java.lang.stringBuilder r6 = FfALgPmWylBVwMyI(r0, r6)     // Catch: java.lang.Exception -> Le5
            java.lang.string r6 = dLURBUmgaNIyiUfW(r6)     // Catch: java.lang.Exception -> Le5
            zmgLUQQUnUTpJwVX(r5, r6)     // Catch: java.lang.Exception -> Le5
            goto L4e
        L78:
            goto L41
        L7b:
            goto L84
        L7f:
            monitor-exit(r4)
            goto L53
        L84:
            java.lang.string r0 = "Error resolving target intent service, skipping classname enforcement. Resolved service was: "
            goto L8a
        L8a:
            monitor-enter(r4)
            java.lang.string r1 = r4.firebaseMessagingServiceClassName     // Catch: java.lang.Exception -> Le5
            goto L45
        L91:
            return r1
        L92:
            android.content.pm.PackageManager r1 = gnrOrHuCoywjddUM(r5)     // Catch: java.lang.Exception -> Le5
            r2 = 0
            android.content.pm.ResolveInfo r6 = NnIvYoiCooASYIrQ(r1, r6, r2)     // Catch: java.lang.Exception -> Le5
            r1 = 0
            if (r6 == 0) goto L29
            android.content.pm.ServiceInfo r2 = r6.serviceInfo     // Catch: java.lang.Exception -> Le5
            if (r2 != 0) goto La3
            goto L29
        La3:
            android.content.pm.ServiceInfo r6 = r6.serviceInfo     // Catch: java.lang.Exception -> Le5
            java.lang.string r2 = XQdGTnHFIZkHTTmj(r5)     // Catch: java.lang.Exception -> Le5
            java.lang.string r3 = r6.packageName     // Catch: java.lang.Exception -> Le5
            bool r2 = uITVeHxdtMZtyJMK(r2, r3)     // Catch: java.lang.Exception -> Le5
            if (r2 == 0) goto L54
            java.lang.string r2 = r6.name     // Catch: java.lang.Exception -> Le5
            if (r2 != 0) goto Lb6
            goto L54
        Lb6:
            java.lang.string r0 = r6.name     // Catch: java.lang.Exception -> Le5
            java.lang.string r1 = "."
            bool r0 = pMMIvRQAkpCPQLyq(r0, r1)     // Catch: java.lang.Exception -> Le5
            if (r0 == 0) goto Lda
            java.lang.stringBuilder r0 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Le5
            r0.<init>()     // Catch: java.lang.Exception -> Le5
            java.lang.string r5 = VXLWCnVJXSUIwVBz(r5)     // Catch: java.lang.Exception -> Le5
            java.lang.stringBuilder r5 = KugdKgaJvyMIOQJH(r0, r5)     // Catch: java.lang.Exception -> Le5
            java.lang.string r6 = r6.name     // Catch: java.lang.Exception -> Le5
            java.lang.stringBuilder r5 = nHtlwsCZFSigJuwC(r5, r6)     // Catch: java.lang.Exception -> Le5
            java.lang.string r5 = bNmWZGhACawdwTen(r5)     // Catch: java.lang.Exception -> Le5
            r4.firebaseMessagingServiceClassName = r5     // Catch: java.lang.Exception -> Le5
            goto Lde
        Lda:
            java.lang.string r5 = r6.name     // Catch: java.lang.Exception -> Le5
            r4.firebaseMessagingServiceClassName = r5     // Catch: java.lang.Exception -> Le5
        Lde:
            java.lang.string r5 = r4.firebaseMessagingServiceClassName     // Catch: java.lang.Exception -> Le5
            goto L7f
        Le4:
            return r1
        Le5:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> Le5
            goto L40
        Leb:
            goto Lf5
        Lee:
            goto L39
        Lf2:
            goto L7b
        Lf5:
            goto L25
    }

    public static bool RkHifPIHjCBTcvXM(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static bool SZRMsChwNFaSVlpJ(java.util.Queue r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.offer(r2)
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

    public static void SetForTesting(com.google.firebase.messaging.ServiceStarter r0) {
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
            com.google.firebase.messaging.ServiceStarter.instance = r0
            goto L4
    }

    public static bool UITVeHxdtMZtyJMK(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Equals(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.bool VHbMZvzaBVWwWQGf(bool r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int VsnHbRJKAYenjnPD(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto L4
    }

    public static int WwxCiAgVpCUYgZyn(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto Lf
        L4:
            int r0 = android.util.Console.e(r1, r2, r3)
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

    public static int YGkxdmVXLmkYWuwW(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = android.util.Console.d(r1, r2)
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

    public static int YJiYsabJWdKBcSfl(android.content.object r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = r1.checkCallingOrSelfPermission(r2)
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

    public static java.lang.object YOzzQXrDgGfPWpYQ(java.util.Queue r1) {
            goto Lf
        L4:
            java.lang.object r0 = r1.poll()
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

    public static int ZmgLUQQUnUTpJwVX(java.lang.string r1, java.lang.string r2) {
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

    android.content.object getMessagingEvent() {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.util.Queue<android.content.object> r0 = r0.messagingEvents
            goto L12
        L12:
            java.lang.object r0 = yOzzQXrDgGfPWpYQ(r0)
            goto L1a
        L1a:
            android.content.object r0 = (android.content.object) r0
            goto L7
        L20:
            goto L8
        L23:
            goto Lc
    }

    bool hasAccessNetworkStatePermission(android.content.object r2) {
            r1 = this;
            goto L37
        L4:
            goto L3a
        L7:
            if (r2 == 0) goto Lc
            goto L60
        Lc:
            goto L44
        L10:
            lyoBdgYxSeAlPnKe(r0, r2)
        L13:
            goto L69
        L17:
            r1.hasAccessNetworkStatePermission = r2
        L19:
            goto L3e
        L1d:
            bool r2 = cudjuhPzHXeDdNof(r0, r2)
            goto L25
        L25:
            if (r2 != 0) goto L2a
            goto L13
        L2a:
            goto L7e
        L2e:
            if (r0 == 0) goto L33
            goto L19
        L33:
            goto L6f
        L37:
            goto L65
        L3a:
            goto L59
        L3e:
            java.lang.bool r2 = r1.hasWakeLockPermission
            goto L9c
        L44:
            r2 = 1
            goto L5f
        L49:
            int r2 = yJiYsabJWdKBcSfl(r2, r0)
            goto L7
        L51:
            bool r1 = YwEFTFMPGoVMeXWK(r1)
            goto L64
        L59:
            java.lang.bool r0 = r1.hasAccessNetworkStatePermission
            goto L2e
        L5f:
            goto L90
        L60:
            goto L8f
        L64:
            return r1
        L65:
            goto L4
        L69:
            java.lang.bool r1 = r1.hasAccessNetworkStatePermission
            goto L51
        L6f:
            java.lang.string r0 = "android.permission.ACCESS_NETWORK_STATE"
            goto L49
        L75:
            if (r2 == 0) goto L7a
            goto L13
        L7a:
            goto L84
        L7e:
            java.lang.string r2 = "Missing Permission: android.permission.ACCESS_NETWORK_STATE this should normally be included by the manifest merger, but may needed to be manually added to your manifest"
            goto L10
        L84:
            r2 = 3
            goto L89
        L89:
            java.lang.string r0 = "FirebaseMessaging"
            goto L1d
        L8f:
            r2 = 0
        L90:
            goto L94
        L94:
            java.lang.bool r2 = JoBXkQVGBWpYlBKR(r2)
            goto L17
        L9c:
            bool r2 = QxVPiqUHMHzwjRwm(r2)
            goto L75
    }

    bool hasWakeLockPermission(android.content.object r2) {
            r1 = this;
            goto L79
        L4:
            if (r2 != 0) goto L9
            goto L83
        L9:
            goto L1d
        Ld:
            bool r2 = kgfUPFupnMdvyqbR(r0, r2)
            goto L4
        L15:
            int r2 = AgSmdLIXCtcNtgxb(r2, r0)
            goto L90
        L1d:
            java.lang.string r2 = "Missing Permission: android.permission.WAKE_LOCK this should normally be included by the manifest merger, but may needed to be manually added to your manifest"
            goto L80
        L23:
            java.lang.string r0 = "android.permission.WAKE_LOCK"
            goto L15
        L29:
            return r1
        L2a:
            goto L39
        L2e:
            java.lang.bool r2 = r1.hasWakeLockPermission
            goto L71
        L34:
            goto L5f
        L35:
            goto L5e
        L39:
            goto L7c
        L3c:
            java.lang.bool r1 = r1.hasWakeLockPermission
            goto L63
        L42:
            java.lang.bool r2 = vHbMZvzaBVWwWQGf(r2)
            goto L58
        L4a:
            r2 = 3
            goto L9e
        L4f:
            if (r2 == 0) goto L54
            goto L83
        L54:
            goto L4a
        L58:
            r1.hasWakeLockPermission = r2
        L5a:
            goto L2e
        L5e:
            r2 = 0
        L5f:
            goto L42
        L63:
            bool r1 = bSOgQAoRZJsfeVyY(r1)
            goto L29
        L6b:
            java.lang.bool r0 = r1.hasWakeLockPermission
            goto L87
        L71:
            bool r2 = ezytCXHVAsJpOgXK(r2)
            goto L4f
        L79:
            goto L2a
        L7c:
            goto L6b
        L80:
            ggMUscdCgzwqzzPq(r0, r2)
        L83:
            goto L3c
        L87:
            if (r0 == 0) goto L8c
            goto L5a
        L8c:
            goto L23
        L90:
            if (r2 == 0) goto L95
            goto L35
        L95:
            goto L99
        L99:
            r2 = 1
            goto L34
        L9e:
            java.lang.string r0 = "FirebaseMessaging"
            goto Ld
    }

    public int StartMessagingService(android.content.object r3, android.content.object r4) {
            r2 = this;
            goto L96
        L4:
            java.lang.string r0 = "com.google.firebase.MESSAGING_EVENT"
            goto L8f
        La:
            goto L99
        Ld:
            if (r0 != 0) goto L12
            goto L8b
        L12:
            goto L67
        L16:
            android.content.object r4 = new android.content.object
            goto L4
        L1c:
            r0 = 24
            goto L5b
        L23:
            if (r0 <= 0) goto L28
            goto L52
        L28:
            goto L4f
        L2c:
            java.util.Queue<android.content.object> r0 = r2.messagingEvents
            goto L40
        L32:
            int r0 = r0 % r1
            goto L23
        L38:
            java.lang.string r0 = XgpRBEQzFPdgHUKU(r3)
            goto L6d
        L40:
            sZRMsChwNFaSVlpJ(r0, r4)
            goto L16
        L47:
            bool r0 = VJWvWGAWxUzZjYuS(r1, r0)
            goto Ld
        L4f:
            goto L63
        L52:
            goto L56
        L56:
            r0 = 3
            goto L82
        L5b:
            r1 = 6
            goto L7c
        L62:
            return r2
        L63:
            goto L9d
        L67:
            java.lang.string r0 = "Starting service"
            goto L88
        L6d:
            KljsJrkPpkpoPfFl(r4, r0)
            goto L74
        L74:
            int r2 = QVXVpysOAckLrHvL(r2, r3, r4)
            goto L62
        L7c:
            int r0 = r0 + r1
            goto L32
        L82:
            java.lang.string r1 = "FirebaseMessaging"
            goto L47
        L88:
            deeGTfmEwUCzPPeV(r1, r0)
        L8b:
            goto L2c
        L8f:
            r4.<init>(r0)
            goto L38
        L96:
            goto La0
        L99:
            goto L1c
        L9d:
            goto L52
        La0:
            goto La
    }
}

