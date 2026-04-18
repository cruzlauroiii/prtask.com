namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class Metadata {
    private static readonly java.lang.string ACTION_C2DM_REGISTER = "com.google.android.c2dm.intent.REGISTER";
    private static readonly java.lang.string ACTION_IID_TOKEN_REQUEST = "com.google.iid.TOKEN_REQUEST";
    static readonly int GMSCORE_NOT_FOUND = 0;
    private static readonly java.lang.string GMSCORE_SEND_PERMISSION = "com.google.android.c2dm.permission.SEND";
    static readonly java.lang.string GMS_PACKAGE = "com.google.android.gms";
    static readonly int IID_VIA_RECEIVER = 2;
    static readonly int IID_VIA_SERVICE = 1;
    private java.lang.string appVersionCode;
    private java.lang.string appVersionName;
    private readonly android.content.object context;
    private int gmsVersionCode;
    private int iidImplementation;

    Metadata(android.content.object r2) {
            r1 = this;
            goto L24
        L4:
            goto L27
        L7:
            r1.iidImplementation = r0
            goto L19
        Ld:
            return
        Le:
            goto L4
        L12:
            r1.<init>()
            goto L1f
        L19:
            r1.context = r2
            goto Ld
        L1f:
            r0 = 0
            goto L7
        L24:
            goto Le
        L27:
            goto L12
    }

    public static java.util.List ApoWrNpLvynlnRjB(android.content.pm.PackageManager r1, android.content.object r2, int r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.util.List r0 = r1.queryobjectServices(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static android.content.pm.PackageManager BUhXxlcXzvnhfKuN(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
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

    public static java.lang.string CKQPfqGQKJuMZwPq(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.getPackageName()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int DycyBkDLvTrZfEoS(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.w(r1, r2)
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

    public static android.content.pm.PackageInfo EKqVRChFdTqYygGw(com.google.firebase.messaging.Metadata r1, java.lang.string r2) {
            goto L14
        L4:
            android.content.pm.PackageInfo r0 = r1.getPackageInfo(r2)
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

    public static android.content.object FjPAWaCxhgSjCkzd(android.content.object r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.object r0 = r1.setPackage(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int GFZFdTzpZYfSOQYI(com.google.firebase.messaging.Metadata r1) {
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
            int r0 = r1.getIidImplementation()
            goto L4
        L18:
            goto Lc
    }

    public static int GgMnkDCLSQWQcCOK(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto L7
    }

    public static android.content.object HfcPDzQBuRtFAVgV(android.content.object r1, java.lang.string r2) {
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
            android.content.object r0 = r1.setPackage(r2)
            goto Le
    }

    public static bool HyAyMhoCQrKbxoEk() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastO()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static android.content.pm.PackageInfo INURzUuROvBGvXlB(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
            goto L14
        L4:
            android.content.pm.PackageInfo r0 = r1.getPackageInfo(r2, r3)
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

    public static void MOacVFlzFVFYycgl(com.google.firebase.messaging.Metadata r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.populateAppVersionInfo()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static java.lang.string MbNbgKGGMripdFVr(com.google.firebase.FirebaseOptions r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getGcmSenderId()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool OAfbQGmMPFyRPmpB() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastO()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ONVEQCPdTvOWfKbD(com.google.firebase.messaging.Metadata r0) {
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
            r0.populateAppVersionInfo()
            goto Lb
        L17:
            goto L7
    }

    public static com.google.firebase.FirebaseOptions RLwFHzxkWxVthOru(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.util.List SpvRJPxrNgkxVURw(android.content.pm.PackageManager r1, android.content.object r2, int r3) {
            goto Lc
        L4:
            java.util.List r0 = r1.queryBroadcastReceivers(r2, r3)
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

    public static java.lang.string ATVeYhgixbMWarOR(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool AYqgSLhPcjvGKidX(java.lang.string r1) {
            goto L14
        L4:
            bool r0 = r1.Count == 0
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

    public static java.lang.string CJTTiLiQqmdEPgjm(com.google.firebase.FirebaseOptions r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getApplicationId()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int CyapOgfFrAcWDJpN(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto L4
    }

    static java.lang.string GetDefaultSenderId(com.google.firebase.FirebaseApp r3) {
            goto L54
        L4:
            bool r0 = vAHiAfirVlGlzsCD(r3, r0)
            goto Lbd
        Lc:
            if (r0 < r1) goto L11
            goto Lb9
        L11:
            goto Lb8
        L15:
            com.google.firebase.FirebaseOptions r3 = xKTCWVZPPFCCsyTc(r3)
            goto L5b
        L1d:
            return r2
        L1e:
            goto Ld5
        L22:
            if (r0 != 0) goto L27
            goto L97
        L27:
            goto L96
        L2b:
            int r0 = r3.length
            goto L42
        L30:
            r3 = r3[r0]
            goto L4c
        L36:
            goto Ld6
        L39:
            goto L88
        L3d:
            r0 = 1
            goto L30
        L42:
            r1 = 2
            goto L47
        L47:
            r2 = 0
            goto Lc
        L4c:
            bool r0 = aYqgSLhPcjvGKidX(r3)
            goto L6a
        L54:
            goto L84
        L57:
            goto Lc6
        L5b:
            java.lang.string r3 = cJTTiLiQqmdEPgjm(r3)
            goto La1
        L63:
            r1 = 20
            goto L90
        L6a:
            if (r0 != 0) goto L6f
            goto L1e
        L6f:
            goto L1d
        L73:
            java.lang.string r0 = ":"
            goto L79
        L79:
            java.lang.string[] r3 = vKgFlBdwNIbwbzsI(r3, r0)
            goto L2b
        L81:
            goto L39
        L84:
            goto Lb5
        L88:
            com.google.firebase.FirebaseOptions r0 = RLwFHzxkWxVthOru(r3)
            goto Lcd
        L90:
            int r0 = r0 + r1
            goto L9b
        L96:
            return r0
        L97:
            goto L15
        L9b:
            int r0 = r0 % r1
            goto Lac
        La1:
            java.lang.string r0 = "1:"
            goto L4
        La7:
            return r3
        La8:
            goto L73
        Lac:
            if (r0 <= 0) goto Lb1
            goto L39
        Lb1:
            goto L36
        Lb5:
            goto L57
        Lb8:
            return r2
        Lb9:
            goto L3d
        Lbd:
            if (r0 == 0) goto Lc2
            goto La8
        Lc2:
            goto La7
        Lc6:
            r0 = 21
            goto L63
        Lcd:
            java.lang.string r0 = MbNbgKGGMripdFVr(r0)
            goto L22
        Ld5:
            return r3
        Ld6:
            goto L81
    }

    private android.content.pm.PackageInfo GetPackageInfo(java.lang.string r2) {
            r1 = this;
            goto L2d
        L4:
            java.lang.stringBuilder r1 = nQAtnruAyGFJWsxU(r2, r1)
            goto L18
        Lc:
            cyapOgfFrAcWDJpN(r2, r1)
            goto L4e
        L13:
            return r1
        L14:
            goto L45
        L18:
            java.lang.string r1 = aTVeYhgixbMWarOR(r1)
            goto L48
        L20:
            java.lang.string r0 = "Failed to find package "
            goto L26
        L26:
            r2.<init>(r0)
            goto L4
        L2d:
            goto L14
        L30:
            android.content.object r1 = r1.context     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L40
            android.content.pm.PackageManager r1 = BUhXxlcXzvnhfKuN(r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L40
            r0 = 0
            android.content.pm.PackageInfo r1 = INURzUuROvBGvXlB(r1, r2, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L40
            goto L3f
        L3f:
            return r1
        L40:
            r1 = move-exception
            goto L53
        L45:
            goto L30
        L48:
            java.lang.string r2 = "FirebaseMessaging"
            goto Lc
        L4e:
            r1 = 0
            goto L13
        L53:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L20
    }

    public static java.lang.string JXaInjAKRLrlWWlm(int r1) {
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
            java.lang.string r0 = java.lang.int.tostring(r1)
            goto Lb
    }

    public static int NDoUFimbBrVheCES(java.util.List r1) {
            goto L11
        L4:
            int r0 = r1.Count
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

    public static java.lang.stringBuilder NQAtnruAyGFJWsxU(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static int PLARBpBMBgaJrzXM(java.util.List r1) {
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
            int r0 = r1.Count
            goto Lb
    }

    private void PopulateAppVersionInfo() {
            r2 = this;
            goto L41
        L4:
            throw r0
        L5:
            goto L58
        L9:
            r1 = 4
            goto L17
        L10:
            return
        L11:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L11
            goto L4
        L17:
            int r0 = r0 + r1
            goto L5f
        L1d:
            r0 = 7
            goto L9
        L24:
            monitor-enter(r2)
            android.content.object r0 = r2.context     // Catch: java.lang.Exception -> L11
            java.lang.string r0 = CKQPfqGQKJuMZwPq(r0)     // Catch: java.lang.Exception -> L11
            android.content.pm.PackageInfo r0 = rcftXEIFSjdILmyX(r2, r0)     // Catch: java.lang.Exception -> L11
            if (r0 == 0) goto L3d
            int r1 = r0.versionCode     // Catch: java.lang.Exception -> L11
            java.lang.string r1 = jXaInjAKRLrlWWlm(r1)     // Catch: java.lang.Exception -> L11
            r2.appVersionCode = r1     // Catch: java.lang.Exception -> L11
            java.lang.string r0 = r0.versionName     // Catch: java.lang.Exception -> L11
            r2.appVersionName = r0     // Catch: java.lang.Exception -> L11
        L3d:
            goto L68
        L41:
            goto L5b
        L44:
            goto L1d
        L48:
            goto L5
        L4b:
            goto L24
        L4f:
            if (r0 <= 0) goto L54
            goto L4b
        L54:
            goto L48
        L58:
            goto L4b
        L5b:
            goto L65
        L5f:
            int r0 = r0 % r1
            goto L4f
        L65:
            goto L44
        L68:
            monitor-exit(r2)
            goto L10
    }

    public static android.content.pm.PackageInfo RcftXEIFSjdILmyX(com.google.firebase.messaging.Metadata r1, java.lang.string r2) {
            goto L14
        L4:
            android.content.pm.PackageInfo r0 = r1.getPackageInfo(r2)
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

    public static android.content.pm.PackageManager USrzvXeiyBRzoRBd(android.content.object r1) {
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

    public static bool VAHiAfirVlGlzsCD(java.lang.string r1, java.lang.string r2) {
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
            bool r0 = r1.StartsWith(r2)
            goto Le
    }

    public static java.lang.string[] VKgFlBdwNIbwbzsI(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.string[] r0 = r1.Split(r2)
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

    public static int VoBleZBgyJwjdAcs(android.content.pm.PackageManager r1, java.lang.string r2, java.lang.string r3) {
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
            int r0 = r1.checkPermission(r2, r3)
            goto L7
    }

    public static com.google.firebase.FirebaseOptions XKTCWVZPPFCCsyTc(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L4
    }

    synchronized java.lang.string GetAppVersionCode() {
            r1 = this;
            goto Le
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L23
        Lb:
            goto L11
        Le:
            goto L24
        L11:
            goto L15
        L15:
            monitor-enter(r1)
            java.lang.string r0 = r1.appVersionCode     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L1d
            MOacVFlzFVFYycgl(r1)     // Catch: java.lang.Exception -> L5
        L1d:
            java.lang.string r0 = r1.appVersionCode     // Catch: java.lang.Exception -> L5
            goto L28
        L23:
            throw r0
        L24:
            goto Lb
        L28:
            monitor-exit(r1)
            goto L4
    }

    synchronized java.lang.string GetAppVersionName() {
            r1 = this;
            goto Lb
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L12
        Lb:
            goto L13
        Le:
            goto L17
        L12:
            throw r0
        L13:
            goto L25
        L17:
            monitor-enter(r1)
            java.lang.string r0 = r1.appVersionName     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L1f
            ONVEQCPdTvOWfKbD(r1)     // Catch: java.lang.Exception -> L5
        L1f:
            java.lang.string r0 = r1.appVersionName     // Catch: java.lang.Exception -> L5
            goto L28
        L25:
            goto Le
        L28:
            monitor-exit(r1)
            goto L4
    }

    synchronized int GetGmsVersionCode() {
            r1 = this;
            goto L2c
        L4:
            monitor-exit(r1)
            goto L9
        L9:
            return r0
        La:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L10
        L10:
            throw r0
        L11:
            goto L33
        L15:
            monitor-enter(r1)
            int r0 = r1.gmsVersionCode     // Catch: java.lang.Exception -> La
            if (r0 != 0) goto L26
            java.lang.string r0 = "com.google.android.gms"
            android.content.pm.PackageInfo r0 = EKqVRChFdTqYygGw(r1, r0)     // Catch: java.lang.Exception -> La
            if (r0 == 0) goto L26
            int r0 = r0.versionCode     // Catch: java.lang.Exception -> La
            r1.gmsVersionCode = r0     // Catch: java.lang.Exception -> La
        L26:
            int r0 = r1.gmsVersionCode     // Catch: java.lang.Exception -> La
            goto L4
        L2c:
            goto L11
        L2f:
            goto L15
        L33:
            goto L2f
    }

    synchronized int GetIidImplementation() {
            r5 = this;
            goto L30
        L4:
            monitor-exit(r5)
            goto L10
        L9:
            r0 = 1
            goto L91
        L10:
            return r0
        L11:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L11
            goto L6d
        L17:
            return r1
        L18:
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r3 = "Failed to resolve IID implementation package, falling back"
            DycyBkDLvTrZfEoS(r0, r3)     // Catch: java.lang.Exception -> L11
            bool r0 = OAfbQGmMPFyRPmpB()     // Catch: java.lang.Exception -> L11
            if (r0 == 0) goto L28
            r5.iidImplementation = r1     // Catch: java.lang.Exception -> L11
            goto L2a
        L28:
            r5.iidImplementation = r2     // Catch: java.lang.Exception -> L11
        L2a:
            int r0 = r5.iidImplementation     // Catch: java.lang.Exception -> L11
            goto L4
        L30:
            goto L81
        L33:
            goto L9
        L37:
            monitor-exit(r5)
            goto L17
        L3c:
            monitor-exit(r5)
            goto L41
        L41:
            return r2
        L42:
            android.content.object r1 = new android.content.object     // Catch: java.lang.Exception -> L11
            java.lang.string r4 = "com.google.iid.TOKEN_REQUEST"
            r1.<init>(r4)     // Catch: java.lang.Exception -> L11
            java.lang.string r4 = "com.google.android.gms"
            FjPAWaCxhgSjCkzd(r1, r4)     // Catch: java.lang.Exception -> L11
            java.util.List r0 = SpvRJPxrNgkxVURw(r0, r1, r3)     // Catch: java.lang.Exception -> L11
            r1 = 2
            if (r0 == 0) goto L18
            int r0 = nDoUFimbBrVheCES(r0)     // Catch: java.lang.Exception -> L11
            if (r0 <= 0) goto L18
            r5.iidImplementation = r1     // Catch: java.lang.Exception -> L11
            goto L37
        L61:
            int r0 = r0 + r1
            goto L67
        L67:
            int r0 = r0 % r1
            goto L75
        L6d:
            throw r0
        L6e:
            goto L7e
        L72:
            goto L33
        L75:
            if (r0 <= 0) goto L7a
            goto L8d
        L7a:
            goto L8a
        L7e:
            goto L8d
        L81:
            goto L72
        L85:
            monitor-exit(r5)
            goto Lca
        L8a:
            goto L6e
        L8d:
            goto Lc3
        L91:
            r1 = 24
            goto L61
        L98:
            monitor-exit(r5)
            goto L9d
        L9d:
            return r3
        L9e:
            bool r1 = HyAyMhoCQrKbxoEk()     // Catch: java.lang.Exception -> L11
            r2 = 1
            if (r1 != 0) goto L42
            android.content.object r1 = new android.content.object     // Catch: java.lang.Exception -> L11
            java.lang.string r4 = "com.google.android.c2dm.intent.REGISTER"
            r1.<init>(r4)     // Catch: java.lang.Exception -> L11
            java.lang.string r4 = "com.google.android.gms"
            HfcPDzQBuRtFAVgV(r1, r4)     // Catch: java.lang.Exception -> L11
            java.util.List r1 = ApoWrNpLvynlnRjB(r0, r1, r3)     // Catch: java.lang.Exception -> L11
            if (r1 == 0) goto L42
            int r1 = pLARBpBMBgaJrzXM(r1)     // Catch: java.lang.Exception -> L11
            if (r1 <= 0) goto L42
            r5.iidImplementation = r2     // Catch: java.lang.Exception -> L11
            goto L3c
        Lc3:
            monitor-enter(r5)
            int r0 = r5.iidImplementation     // Catch: java.lang.Exception -> L11
            goto Le8
        Lca:
            return r0
        Lcb:
            android.content.object r0 = r5.context     // Catch: java.lang.Exception -> L11
            android.content.pm.PackageManager r0 = uSrzvXeiyBRzoRBd(r0)     // Catch: java.lang.Exception -> L11
            java.lang.string r1 = "com.google.android.c2dm.permission.SEND"
            java.lang.string r2 = "com.google.android.gms"
            int r1 = voBleZBgyJwjdAcs(r0, r1, r2)     // Catch: java.lang.Exception -> L11
            r2 = -1
            r3 = 0
            if (r1 != r2) goto L9e
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r1 = "Google Play services missing or without correct permission."
            GgMnkDCLSQWQcCOK(r0, r1)     // Catch: java.lang.Exception -> L11
            goto L98
        Le8:
            if (r0 != 0) goto Led
            goto Lcb
        Led:
            goto L85
    }

    bool isGmscorePresent() {
            r0 = this;
            goto L24
        L4:
            if (r0 != 0) goto L9
            goto Le
        L9:
            goto L1f
        Ld:
            return r0
        Le:
            goto L12
        L12:
            r0 = 0
            goto L2b
        L17:
            int r0 = GFZFdTzpZYfSOQYI(r0)
            goto L4
        L1f:
            r0 = 1
            goto Ld
        L24:
            goto L2c
        L27:
            goto L17
        L2b:
            return r0
        L2c:
            goto L30
        L30:
            goto L27
    }
}

