namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
@java.lang.Deprecated
public class GoogleSignInClient : com.google.android.gms.common.api.GoogleApi<com.google.android.gms.auth.api.signin.GoogleSignInOptions> {
    static int zba;
    private static readonly com.google.android.gms.auth.api.signin.zba zbb = null;

    static {
            goto L52
        L4:
            goto Lc
        L7:
            goto L17
        Lb:
            return
        Lc:
            goto L59
        L10:
            r0 = 1
            goto L60
        L17:
            com.google.android.gms.auth.api.signin.zba r0 = new com.google.android.gms.auth.api.signin.zba
            goto L41
        L1d:
            r0.<init>(r1)
            goto L33
        L24:
            if (r0 <= 0) goto L29
            goto L7
        L29:
            goto L4
        L2d:
            int r0 = r0 % r1
            goto L24
        L33:
            com.google.android.gms.auth.api.signin.GoogleSignInClient.zbb = r0
            goto L3c
        L39:
            goto L55
        L3c:
            r0 = 1
            goto L4c
        L41:
            r1 = 0
            goto L1d
        L46:
            int r0 = r0 + r1
            goto L2d
        L4c:
            com.google.android.gms.auth.api.signin.GoogleSignInClient.zba = r0
            goto Lb
        L52:
            goto L5c
        L55:
            goto L10
        L59:
            goto L7
        L5c:
            goto L39
        L60:
            r1 = 3
            goto L46
    }

    GoogleSignInClient(android.app.object r3, com.google.android.gms.auth.api.signin.GoogleSignInOptions r4) {
            r2 = this;
            goto L44
        L4:
            goto L1a
        L7:
            goto L58
        Lb:
            r1 = 15
            goto L3e
        L12:
            r0 = 16
            goto Lb
        L19:
            return
        L1a:
            goto L24
        L1e:
            com.google.android.gms.common.api.internal.ApiExceptionDictionaryper r1 = new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper
            goto L37
        L24:
            goto L7
        L27:
            goto L2b
        L2b:
            goto L47
        L2e:
            if (r0 <= 0) goto L33
            goto L7
        L33:
            goto L4
        L37:
            r1.<init>()
            goto L51
        L3e:
            int r0 = r0 + r1
            goto L4b
        L44:
            goto L27
        L47:
            goto L12
        L4b:
            int r0 = r0 % r1
            goto L2e
        L51:
            r2.<init>(r3, r0, r4, r1)
            goto L19
        L58:
            com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.signin.GoogleSignInOptions> r0 = com.google.android.gms.auth.api.Auth.GOOGLE_SIGN_IN_API
            goto L1e
    }

    GoogleSignInClient(android.content.object r4, com.google.android.gms.auth.api.signin.GoogleSignInOptions r5) {
            r3 = this;
            goto L35
        L4:
            com.google.android.gms.common.api.GoogleApi$HashSettings$Builder r1 = new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder
            goto La
        La:
            r1.<init>()
            goto L3c
        L11:
            goto L5b
        L14:
            goto L4b
        L18:
            r2.<init>()
            goto L73
        L1f:
            r1 = 31
            goto L66
        L26:
            com.google.android.gms.common.api.GoogleApi$HashSettings r1 = fcuhndwIzErniRHD(r1)
            goto L5f
        L2e:
            goto L14
        L31:
            goto L51
        L35:
            goto L31
        L38:
            goto L6c
        L3c:
            com.google.android.gms.common.api.internal.ApiExceptionDictionaryper r2 = new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper
            goto L18
        L42:
            if (r0 <= 0) goto L47
            goto L14
        L47:
            goto L11
        L4b:
            com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.signin.GoogleSignInOptions> r0 = com.google.android.gms.auth.api.Auth.GOOGLE_SIGN_IN_API
            goto L4
        L51:
            goto L38
        L54:
            int r0 = r0 % r1
            goto L42
        L5a:
            return
        L5b:
            goto L2e
        L5f:
            r3.<init>(r4, r0, r5, r1)
            goto L5a
        L66:
            int r0 = r0 + r1
            goto L54
        L6c:
            r0 = 24
            goto L1f
        L73:
            com.google.android.gms.common.api.GoogleApi$HashSettings$Builder r1 = nlXfWjpeaUXudkbW(r1, r2)
            goto L26
    }

    public static int AjGvIXkVNQiktVxJ(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
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
            int r0 = r1.zba()
            goto L4
    }

    public static com.google.android.gms.common.GoogleApiAvailability CXYXftwXHKWdICOz() {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.GoogleApiAvailability r0 = com.google.android.gms.common.GoogleApiAvailability.getInstance()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.content.object FgCucwCDUXleVFSK(android.content.object r1, com.google.android.gms.auth.api.signin.GoogleSignInOptions r2) {
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
            android.content.object r0 = com.google.android.gms.auth.api.signin.internal.zbm.zbc(r1, r2)
            goto Le
    }

    public static android.content.object GOWudbJwRHiIqzmb(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.object r0 = r1.getApplicationobject()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.android.gms.common.api.Api.ApiOptions HVjqxBlJykUkcbet(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
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
            com.google.android.gms.common.api.Api$ApiOptions r0 = r1.getApiOptions()
            goto Lb
    }

    public static com.google.android.gms.common.api.PendingResult HjpMaGsbIGvbkwMB(com.google.android.gms.common.api.GoogleApiClient r1, android.content.object r2, bool r3) {
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
            com.google.android.gms.common.api.PendingResult r0 = com.google.android.gms.auth.api.signin.internal.zbm.zbg(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static android.content.object IJsUJvVlmQElqKMI(com.google.android.gms.common.GoogleApiAvailability r1, android.content.object r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.object r0 = r1.getErrorResolutionobject(r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static android.content.object MPrPlZhnCOkabYGG(android.content.object r1, com.google.android.gms.auth.api.signin.GoogleSignInOptions r2) {
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
            android.content.object r0 = com.google.android.gms.auth.api.signin.internal.zbm.zbb(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static android.content.object PTGyjQJywfUhpxPj(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.object r0 = r1.getApplicationobject()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.android.gms.common.api.Api.ApiOptions PoTbQZMmjpmCtORg(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.api.Api$ApiOptions r0 = r1.getApiOptions()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task VVswzyXqPblpWPOi(com.google.android.gms.common.api.PendingResult r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.common.internal.PendingResultUtil.tovoidTask(r1)
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

    public static com.google.android.gms.common.api.GoogleApiClient VaQwxBvcaHMoHaxH(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
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
            com.google.android.gms.common.api.GoogleApiClient r0 = r1.asGoogleApiClient()
            goto Le
    }

    public static com.google.android.gms.common.api.Api.ApiOptions VkwJkqfjIEYIfozg(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
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
            com.google.android.gms.common.api.Api$ApiOptions r0 = r1.getApiOptions()
            goto L7
    }

    public static int WJRkwWDIVVaLRtzC(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.zba()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.gms.common.api.object?PendingResult XqYAVqNQWZNABAcV(com.google.android.gms.common.api.GoogleApiClient r1, android.content.object r2, com.google.android.gms.auth.api.signin.GoogleSignInOptions r3, bool r4) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.common.api.object?PendingResult r0 = com.google.android.gms.auth.api.signin.internal.zbm.zbe(r1, r2, r3, r4)
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

    public static int YGopLkJirJsoofpW(android.content.object r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = com.google.android.gms.dynamite.DynamiteModule.getLocalVersion(r1, r2)
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

    public static int YcSFIFvaLOsiFobr(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.zba()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static android.content.object AiPcQmqEaRXhUdlx(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.object r0 = r1.getApplicationobject()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.gms.common.api.GoogleApiClient CFZdpRyNMyIafUtZ(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto Lc
        L4:
            com.google.android.gms.common.api.GoogleApiClient r0 = r1.asGoogleApiClient()
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

    public static com.google.android.gms.common.api.GoogleApiClient CPZOyXDUAqVMHZRp(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto Lf
        L4:
            com.google.android.gms.common.api.GoogleApiClient r0 = r1.asGoogleApiClient()
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

    public static com.google.android.gms.common.api.GoogleApi.HashSettings FcuhndwIzErniRHD(com.google.android.gms.common.api.GoogleApi.HashSettings.Builder r1) {
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
            com.google.android.gms.common.api.GoogleApi$HashSettings r0 = r1.build()
            goto L7
    }

    public static int GCwbGuTjenZEPowy(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L14
        L4:
            int r0 = r1.zba()
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

    public static int GnTNIJTEHLpuFgPi(com.google.android.gms.common.GoogleApiAvailability r1, android.content.object r2, int r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.isGooglePlayServicesAvailable(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.content.object HZAtkXAuuaCPqvkp(android.content.object r1, com.google.android.gms.auth.api.signin.GoogleSignInOptions r2) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.object r0 = com.google.android.gms.auth.api.signin.internal.zbm.zba(r1, r2)
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

    public static android.content.object KLEPZmKnzVnRrIIC(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto Lc
        L4:
            android.content.object r0 = r1.getApplicationobject()
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

    public static com.google.android.gms.common.api.PendingResult NiNhSvVBaAEVUjkn(com.google.android.gms.common.api.GoogleApiClient r1, android.content.object r2, bool r3) {
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
            com.google.android.gms.common.api.PendingResult r0 = com.google.android.gms.auth.api.signin.internal.zbm.zbf(r1, r2, r3)
            goto L7
    }

    public static com.google.android.gms.common.api.GoogleApi.HashSettings.Builder NlXfWjpeaUXudkbW(com.google.android.gms.common.api.GoogleApi.HashSettings.Builder r1, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper r2) {
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
            com.google.android.gms.common.api.GoogleApi$HashSettings$Builder r0 = r1.setDictionaryper(r2)
            goto L4
    }

    public static android.content.object OKbsOCydYNuGpXrS(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
            goto L14
        L4:
            android.content.object r0 = r1.getApplicationobject()
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

    public static com.google.android.gms.common.api.Api.ApiOptions QwGpLEokreYRMjPZ(com.google.android.gms.auth.api.signin.GoogleSignInClient r1) {
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
            com.google.android.gms.common.api.Api$ApiOptions r0 = r1.getApiOptions()
            goto L7
    }

    public static com.google.android.gms.tasks.Task RPIohQKdPLtKOtel(com.google.android.gms.common.api.PendingResult r1, com.google.android.gms.common.internal.PendingResultUtil.ResultConverter r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.common.internal.PendingResultUtil.toTask(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.gms.tasks.Task UVqJOZkowALYaaeL(com.google.android.gms.common.api.PendingResult r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.common.internal.PendingResultUtil.tovoidTask(r1)
            goto Lb
        L18:
            goto L7
    }

    private readonly int Zba() {
            r4 = this;
            goto L77
        L4:
            goto L7a
        L7:
            goto L73
        La:
            goto L3d
        Le:
            monitor-exit(r4)
            goto L13
        L13:
            return r0
        L14:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L14
            goto L72
        L1a:
            if (r0 <= 0) goto L1f
            goto La
        L1f:
            goto L7
        L23:
            r0 = 15
            goto L2a
        L2a:
            r1 = 19
            goto L31
        L31:
            int r0 = r0 + r1
            goto L37
        L37:
            int r0 = r0 % r1
            goto L1a
        L3d:
            monitor-enter(r4)
            int r0 = com.google.android.gms.auth.api.signin.GoogleSignInClient.zba     // Catch: java.lang.Exception -> L14
            r1 = 1
            if (r0 != r1) goto L6e
            android.content.object r0 = GOWudbJwRHiIqzmb(r4)     // Catch: java.lang.Exception -> L14
            com.google.android.gms.common.GoogleApiAvailability r1 = CXYXftwXHKWdICOz()     // Catch: java.lang.Exception -> L14
            r2 = 12451000(0xbdfcb8, float:1.7447567E-38)
            int r2 = gnTNIJTEHLpuFgPi(r1, r0, r2)     // Catch: java.lang.Exception -> L14
            if (r2 != 0) goto L58
            r0 = 4
            com.google.android.gms.auth.api.signin.GoogleSignInClient.zba = r0     // Catch: java.lang.Exception -> L14
            goto L6e
        L58:
            r3 = 0
            android.content.object r1 = IJsUJvVlmQElqKMI(r1, r0, r2, r3)     // Catch: java.lang.Exception -> L14
            if (r1 != 0) goto L6b
            java.lang.string r1 = "com.google.android.gms.auth.api.fallback"
            int r0 = YGopLkJirJsoofpW(r0, r1)     // Catch: java.lang.Exception -> L14
            if (r0 == 0) goto L6b
            r0 = 3
            com.google.android.gms.auth.api.signin.GoogleSignInClient.zba = r0     // Catch: java.lang.Exception -> L14
            goto L6e
        L6b:
            r0 = 2
            com.google.android.gms.auth.api.signin.GoogleSignInClient.zba = r0     // Catch: java.lang.Exception -> L14
        L6e:
            goto Le
        L72:
            throw r0
        L73:
            goto L7e
        L77:
            goto L81
        L7a:
            goto L23
        L7e:
            goto La
        L81:
            goto L4
    }

    public android.content.object GetSignInobject() {
            r3 = this;
            goto L1e
        L4:
            r3 = 0
            goto L6a
        L9:
            goto L21
        Lc:
            int r2 = r1 + (-1)
            goto Lac
        L12:
            return r3
        L13:
            goto Lc2
        L17:
            goto L7f
        L1a:
            goto L9
        L1e:
            goto L1a
        L21:
            goto L75
        L25:
            if (r0 <= 0) goto L2a
            goto L7f
        L2a:
            goto L7c
        L2e:
            com.google.android.gms.common.api.Api$ApiOptions r3 = qwGpLEokreYRMjPZ(r3)
            goto Lb5
        L36:
            r1 = 3
            goto L96
        L3b:
            android.content.object r3 = hZAtkXAuuaCPqvkp(r0, r3)
            goto Ld0
        L43:
            android.content.object r3 = FgCucwCDUXleVFSK(r0, r3)
            goto La7
        L4b:
            if (r2 != r1) goto L50
            goto La8
        L50:
            goto L36
        L54:
            com.google.android.gms.common.api.Api$ApiOptions r3 = HVjqxBlJykUkcbet(r3)
            goto L83
        L5c:
            int r1 = gCwbGuTjenZEPowy(r3)
            goto Lc
        L64:
            int r0 = r0 + r1
            goto L6f
        L6a:
            throw r3
        L6b:
            goto L17
        L6f:
            int r0 = r0 % r1
            goto L25
        L75:
            r0 = 15
            goto Lbb
        L7c:
            goto L6b
        L7f:
            goto L9f
        L83:
            com.google.android.gms.auth.api.signin.GoogleSignInOptions r3 = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) r3
            goto L3b
        L89:
            r1 = 2
            goto L4b
        L8e:
            android.content.object r3 = MPrPlZhnCOkabYGG(r0, r3)
            goto L12
        L96:
            if (r2 != r1) goto L9b
            goto L13
        L9b:
            goto L2e
        L9f:
            android.content.object r0 = oKbsOCydYNuGpXrS(r3)
            goto L5c
        La7:
            return r3
        La8:
            goto L54
        Lac:
            if (r1 != 0) goto Lb1
            goto Ld1
        Lb1:
            goto L89
        Lb5:
            com.google.android.gms.auth.api.signin.GoogleSignInOptions r3 = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) r3
            goto L8e
        Lbb:
            r1 = 32
            goto L64
        Lc2:
            com.google.android.gms.common.api.Api$ApiOptions r3 = PoTbQZMmjpmCtORg(r3)
            goto Lca
        Lca:
            com.google.android.gms.auth.api.signin.GoogleSignInOptions r3 = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) r3
            goto L43
        Ld0:
            return r3
        Ld1:
            goto L4
    }

    public com.google.android.gms.tasks.Task<java.lang.void> RevokeAccess() {
            r3 = this;
            goto L71
        L4:
            r2 = 3
            goto L4e
        L9:
            goto L74
        Lc:
            r1 = 19
            goto L35
        L13:
            return r3
        L14:
            goto L3b
        L18:
            android.content.object r1 = PTGyjQJywfUhpxPj(r3)
            goto L81
        L20:
            r3 = 0
        L21:
            goto L5c
        L25:
            com.google.android.gms.tasks.Task r3 = VVswzyXqPblpWPOi(r3)
            goto L13
        L2d:
            com.google.android.gms.common.api.GoogleApiClient r0 = VaQwxBvcaHMoHaxH(r3)
            goto L18
        L35:
            int r0 = r0 + r1
            goto L64
        L3b:
            goto L4a
        L3e:
            goto L9
        L42:
            r3 = 1
            goto L57
        L47:
            goto L14
        L4a:
            goto L2d
        L4e:
            if (r3 == r2) goto L53
            goto L58
        L53:
            goto L42
        L57:
            goto L21
        L58:
            goto L20
        L5c:
            com.google.android.gms.common.api.PendingResult r3 = niNhSvVBaAEVUjkn(r0, r1, r3)
            goto L25
        L64:
            int r0 = r0 % r1
            goto L78
        L6a:
            r0 = 12
            goto Lc
        L71:
            goto L3e
        L74:
            goto L6a
        L78:
            if (r0 <= 0) goto L7d
            goto L4a
        L7d:
            goto L47
        L81:
            int r3 = WJRkwWDIVVaLRtzC(r3)
            goto L4
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SignOut() {
            r3 = this;
            goto L17
        L4:
            return r3
        L5:
            goto L41
        L9:
            r2 = 3
            goto L74
        Le:
            if (r0 <= 0) goto L13
            goto L85
        L13:
            goto L82
        L17:
            goto L44
        L1a:
            goto L3a
        L1e:
            com.google.android.gms.common.api.PendingResult r3 = HjpMaGsbIGvbkwMB(r0, r1, r3)
            goto L32
        L26:
            r3 = 1
            goto L7d
        L2b:
            r1 = 15
            goto L6e
        L32:
            com.google.android.gms.tasks.Task r3 = uVqJOZkowALYaaeL(r3)
            goto L4
        L3a:
            r0 = 8
            goto L2b
        L41:
            goto L85
        L44:
            goto L48
        L48:
            goto L1a
        L4b:
            android.content.object r1 = kLEPZmKnzVnRrIIC(r3)
            goto L58
        L53:
            r3 = 0
        L54:
            goto L1e
        L58:
            int r3 = AjGvIXkVNQiktVxJ(r3)
            goto L9
        L60:
            com.google.android.gms.common.api.GoogleApiClient r0 = cPZOyXDUAqVMHZRp(r3)
            goto L4b
        L68:
            int r0 = r0 % r1
            goto Le
        L6e:
            int r0 = r0 + r1
            goto L68
        L74:
            if (r3 == r2) goto L79
            goto L7e
        L79:
            goto L26
        L7d:
            goto L54
        L7e:
            goto L53
        L82:
            goto L5
        L85:
            goto L60
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.signin.GoogleSignInAccount> SilentSignIn() {
            r4 = this;
            goto L90
        L4:
            com.google.android.gms.auth.api.signin.zba r0 = com.google.android.gms.auth.api.signin.GoogleSignInClient.zbb
            goto L10
        La:
            int r0 = r0 + r1
            goto L97
        L10:
            com.google.android.gms.tasks.Task r4 = rPIohQKdPLtKOtel(r4, r0)
            goto L7c
        L18:
            goto L70
        L1b:
            goto L5a
        L1f:
            goto L48
        L20:
            goto L47
        L24:
            r3 = 3
            goto L2e
        L29:
            r4 = 1
            goto L1f
        L2e:
            if (r4 == r3) goto L33
            goto L20
        L33:
            goto L29
        L37:
            r1 = 11
            goto La
        L3e:
            if (r0 <= 0) goto L43
            goto L70
        L43:
            goto L6d
        L47:
            r4 = 0
        L48:
            goto L5d
        L4c:
            com.google.android.gms.auth.api.signin.GoogleSignInOptions r2 = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) r2
            goto L52
        L52:
            int r4 = YcSFIFvaLOsiFobr(r4)
            goto L24
        L5a:
            goto L93
        L5d:
            com.google.android.gms.common.api.object?PendingResult r4 = XqYAVqNQWZNABAcV(r0, r1, r2, r4)
            goto L4
        L65:
            com.google.android.gms.common.api.GoogleApiClient r0 = cFZdpRyNMyIafUtZ(r4)
            goto L81
        L6d:
            goto L7d
        L70:
            goto L65
        L74:
            com.google.android.gms.common.api.Api$ApiOptions r2 = VkwJkqfjIEYIfozg(r4)
            goto L4c
        L7c:
            return r4
        L7d:
            goto L18
        L81:
            android.content.object r1 = aiPcQmqEaRXhUdlx(r4)
            goto L74
        L89:
            r0 = 19
            goto L37
        L90:
            goto L1b
        L93:
            goto L89
        L97:
            int r0 = r0 % r1
            goto L3e
    }
}

