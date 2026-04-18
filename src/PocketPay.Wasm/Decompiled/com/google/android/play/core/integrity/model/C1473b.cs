namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.model.b */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1473b {

    /* JADX INFO: renamed from: a */
    private static readonly java.util.Dictionary f240a = null;

    /* JADX INFO: renamed from: b */
    private static readonly java.util.Dictionary f241b = null;

    static {
            goto L2e0
        L4:
            cQIihovxAZEDHBOh(r1, r12, r0)
            goto L182
        Lb:
            java.lang.int r15 = RnUzkZBSEXmBklza(r15)
            goto L2bb
        L13:
            java.lang.string r10 = "Unknown error processing integrity request.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n"
            goto L2f3
        L19:
            goto L2e3
        L1c:
            r11 = -14
            goto Lfb
        L22:
            java.lang.string r6 = "PackageManager could not find this app.\nSomething is wrong (possibly an attack). Non-actionable.\n"
            goto L1e0
        L28:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L154
        L2e:
            r1 = 18
            goto L2ed
        L35:
            r9 = -9
            goto L1b4
        L3b:
            if (r0 <= 0) goto L40
            goto L9e
        L40:
            goto L9b
        L44:
            int r0 = r0 % r1
            goto L3b
        L4a:
            java.lang.string r15 = "The StandardIntegrityTokenProvider is invalid (e.g. it is outdated).\nRequest a new integrity token provider by calling StandardIntegrityManager#prepareIntegrityToken."
            goto Le7
        L50:
            java.lang.int r2 = WKsjIAFngCzCRwGO(r2)
            goto L265
        L58:
            java.lang.int r10 = iWAPBFKnLPyUqVqy(r10)
            goto L17c
        L60:
            r16 = r10
            goto Lc0
        L66:
            java.lang.int r4 = xEMgeilnvSnnDaNE(r4)
            goto Lc6
        L6e:
            FTdCuaQELxOqMugF(r1, r6, r0)
            goto L1a1
        L75:
            java.lang.string r0 = "INTERNAL_ERROR"
            goto L290
        L7b:
            java.lang.string r0 = "INTEGRITY_TOKEN_PROVIDER_INVALID"
            goto L169
        L81:
            java.lang.string r14 = "The provided cloud project number is invalid.\nUse the cloud project number which can be found in Project info in your Google Cloud Console for the cloud project where Play Integrity API is enabled.\n"
            goto L300
        L87:
            JkKqvAdBElnjDgzV(r1, r4, r0)
            goto L21b
        L8e:
            AlGMnGcivuSWVBip(r1, r3, r0)
            goto L228
        L95:
            java.lang.string r0 = "API_NOT_AVAILABLE"
            goto L129
        L9b:
            goto L1bd
        L9e:
            goto La2
        La2:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L289
        La8:
            r8 = -8
            goto L26b
        Lad:
            ozNMwByuykhuzlvB(r1, r8, r0)
            goto L103
        Lb4:
            java.lang.string r7 = "Google Play Services is not available or version is too old.\nAsk the user to Install or Update Play Services.\n"
            goto L138
        Lba:
            java.lang.string r15 = "The provided request hash is too long. The request hash length must be less than 500 bytes.\nRetry with a shorter request hash."
            goto L273
        Lc0:
            java.lang.string r10 = "There is a error on the calling device.\nRetry with an exponential backoff.\n"
            goto L2c1
        Lc6:
            java.lang.string r5 = "Network error: unable to obtain integrity details.\nAsk the user to check for a connection.\n"
            goto L19a
        Lcc:
            java.lang.string r4 = "The Play Store app is either not installed or not the official version.\nAsk the user to install an official and recent version of Play Store.\n"
            goto L20d
        Ld2:
            JFjnEQnkFYHdKzhS(r1, r9, r0)
            goto L24e
        Ld9:
            java.lang.int r10 = bVMqdLrRmXaWyyAm(r10)
            goto Le1
        Le1:
            java.lang.string r11 = "Unknown internal Google server error.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n"
            goto L109
        Le7:
            JAtMmmUnMEObGobu(r0, r10, r15)
            goto L2d4
        Lee:
            java.lang.string r0 = "APP_NOT_INSTALLED"
            goto Lf4
        Lf4:
            ukZTUNYrnqzAcOjE(r1, r5, r0)
            goto L11c
        Lfb:
            java.lang.int r11 = osveTWWhwuJxUheM(r11)
            goto L2e7
        L103:
            java.lang.string r0 = "CANNOT_BIND_TO_SERVICE"
            goto Ld2
        L109:
            YmLKGJjYlowkJZCA(r0, r10, r11)
            goto L1c
        L110:
            java.lang.string r10 = "Binding to the service in the Play Store has failed. This can be due to having an old Play Store version installed on the device.\nAsk the user to update Play Store.\n"
            goto L206
        L116:
            com.google.android.play.core.integrity.model.C1473b.f240a = r0
            goto L28
        L11c:
            java.lang.string r0 = "PLAY_SERVICES_NOT_FOUND"
            goto L6e
        L122:
            aQnCkYPkJWBPIbep(r1, r13, r0)
            goto L2da
        L129:
            eMNaypIpRGLEbTNc(r1, r2, r0)
            goto L297
        L130:
            java.lang.int r15 = dqoxVCJrfjXOQalm(r15)
            goto L60
        L138:
            YATryGZSzJcwwMMS(r0, r6, r7)
            goto L2c8
        L13f:
            ENETwEQmCBhlBFSt(r0, r12, r13)
            goto L194
        L146:
            java.lang.int r14 = PHUSzcJodhORFEgZ(r14)
            goto Lba
        L14e:
            java.lang.string r9 = "The calling app is making too many requests to the API and hence is throttled.\nRetry with an exponential backoff.\n"
            goto L282
        L154:
            r1.<init>()
            goto L1ae
        L15b:
            goto L9e
        L15e:
            goto L19
        L162:
            joNCpdungNYjGDld(r1, r11, r0)
            goto Lee
        L169:
            r2 = r18
            goto L241
        L16f:
            r10 = -19
            goto L58
        L175:
            cnujHPAilaZyykVD(r1, r2, r0)
            goto L18e
        L17c:
            r17 = r15
            goto L4a
        L182:
            java.lang.string r0 = "APP_UID_MISMATCH"
            goto L1ff
        L188:
            r2 = r17
            goto L22e
        L18e:
            java.lang.string r0 = "CLIENT_TRANSIENT_ERROR"
            goto L188
        L194:
            r13 = -16
            goto L1ef
        L19a:
            zWwXeCAQSnldXBsd(r0, r4, r5)
            goto L25a
        L1a1:
            java.lang.string r0 = "PLAY_SERVICES_VERSION_OUTDATED"
            goto L4
        L1a7:
            CqApvmWbrhamhfcT(r0, r7, r8)
            goto La8
        L1ae:
            com.google.android.play.core.integrity.model.C1473b.f241b = r1
            goto L235
        L1b4:
            java.lang.int r9 = DUyGntBiXXJzLCTN(r9)
            goto L110
        L1bc:
            return
        L1bd:
            goto L15b
        L1c1:
            r14 = -17
            goto L146
        L1c7:
            java.lang.string r13 = "Play Services needs to be updated.\nAsk the user to update Google Play Services.\n"
            goto L13f
        L1cd:
            java.lang.int r5 = VJHHUJlTWewfqRhd(r5)
            goto L22
        L1d5:
            r6 = -6
            goto L1e7
        L1da:
            java.lang.string r0 = "GOOGLE_SERVER_UNAVAILABLE"
            goto L29d
        L1e0:
            OPbppqEgbbDjvVkA(r0, r5, r6)
            goto L1d5
        L1e7:
            java.lang.int r6 = pgNspxcncIgthSbl(r6)
            goto Lb4
        L1ef:
            java.lang.int r13 = RhXFBlWCspWXjULw(r13)
            goto L81
        L1f7:
            java.lang.int r3 = IEioEARkWuffTrjJ(r3)
            goto Lcc
        L1ff:
            wHisvuWnlKJKHITw(r1, r7, r0)
            goto L248
        L206:
            eRctMKoOhFXWqdDV(r0, r9, r10)
            goto L2b5
        L20d:
            kdytdSgUyFlMaqRK(r0, r3, r4)
            goto L2ab
        L214:
            NNQsruTIDFyHeTDf(r1, r14, r0)
            goto L1da
        L21b:
            java.lang.string r0 = "PLAY_STORE_NOT_FOUND"
            goto L8e
        L221:
            AovopjrGNgiuJjEx(r0, r11, r12)
            goto L25f
        L228:
            java.lang.string r0 = "PLAY_STORE_VERSION_OUTDATED"
            goto L162
        L22e:
            VPYcgCPPVugdsBxS(r1, r2, r0)
            goto L7b
        L235:
            r2 = -1
            goto L50
        L23a:
            vzeYXkjIPfimlbDE(r0, r2, r3)
            goto L2b0
        L241:
            RmrAAlifdXKrHsYZ(r1, r2, r0)
            goto L75
        L248:
            java.lang.string r0 = "TOO_MANY_REQUESTS"
            goto Lad
        L24e:
            java.lang.string r0 = "CLOUD_PROJECT_NUMBER_IS_INVALID"
            goto L122
        L254:
            java.lang.string r8 = "The calling app UID (user id) does not match the one from Package Manager.\nSomething is wrong (possibly an attack). Non-actionable.\n"
            goto L1a7
        L25a:
            r5 = -5
            goto L1cd
        L25f:
            r12 = -15
            goto L27a
        L265:
            java.lang.string r3 = "Standard Integrity API is not available.\nStandard Integrity API is not enabled, or the Play Store version might be old.\nRecommended actions:\n1) Make sure to be allowlisted to use Standard Integrity API.\n2) Make sure that Integrity API is enabled in Google Play Console.\n3) Ask the user to update Play Store.\n"
            goto L23a
        L26b:
            java.lang.int r8 = ksFGYmLXWXsdTHdC(r8)
            goto L14e
        L273:
            aJrirDfOHNnFycsG(r0, r14, r15)
            goto L2fa
        L27a:
            java.lang.int r12 = mqQgddXeDUxOIGCY(r12)
            goto L1c7
        L282:
            VmDinGlRWEIyAPEk(r0, r8, r9)
            goto L35
        L289:
            r0.<init>()
            goto L116
        L290:
            HiUilEmZvLSReLpn(r1, r15, r0)
            goto L1bc
        L297:
            java.lang.string r0 = "NETWORK_ERROR"
            goto L87
        L29d:
            r2 = r16
            goto L175
        L2a3:
            java.lang.int r7 = EYKwiLzHZyNitEHe(r7)
            goto L254
        L2ab:
            r4 = -3
            goto L66
        L2b0:
            r3 = -2
            goto L1f7
        L2b5:
            r10 = -12
            goto Ld9
        L2bb:
            r18 = r10
            goto L13
        L2c1:
            hwseVcDFxbdrGwDF(r0, r15, r10)
            goto L16f
        L2c8:
            r7 = -7
            goto L2a3
        L2cd:
            r0 = 29
            goto L2e
        L2d4:
            r15 = -100
            goto Lb
        L2da:
            java.lang.string r0 = "REQUEST_HASH_TOO_LONG"
            goto L214
        L2e0:
            goto L15e
        L2e3:
            goto L2cd
        L2e7:
            java.lang.string r12 = "The Play Store needs to be updated.\nAsk the user to update the Google Play Store.\n"
            goto L221
        L2ed:
            int r0 = r0 + r1
            goto L44
        L2f3:
            UynzBiYbCcZrDLsM(r0, r15, r10)
            goto L95
        L2fa:
            r15 = -18
            goto L130
        L300:
            EvTPkZncgVvXfjQV(r0, r13, r14)
            goto L1c1
    }

    public static java.lang.stringBuilder AedXVMVqeGeFbcAW(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object AlGMnGcivuSWVBip(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object AovopjrGNgiuJjEx(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object CqApvmWbrhamhfcT(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.int DUyGntBiXXJzLCTN(int r1) {
            goto L14
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object ENETwEQmCBhlBFSt(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int EYKwiLzHZyNitEHe(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static java.lang.object EvTPkZncgVvXfjQV(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object FTdCuaQELxOqMugF(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object HiUilEmZvLSReLpn(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object HjSXFbbjDoPZbKsg(java.util.Dictionary r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1[r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.int IEioEARkWuffTrjJ(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder JAnVtoIHmWAXSPhQ(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object JAtMmmUnMEObGobu(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lb
    }

    public static java.lang.object JFjnEQnkFYHdKzhS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object JkKqvAdBElnjDgzV(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object NNQsruTIDFyHeTDf(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object OPbppqEgbbDjvVkA(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.int PHUSzcJodhORFEgZ(int r1) {
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

    public static java.lang.int RhXFBlWCspWXjULw(int r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object RmrAAlifdXKrHsYZ(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
    }

    public static java.lang.int RnUzkZBSEXmBklza(int r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object SuvuaGrgCbaXZfxU(java.util.Dictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1[r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object UynzBiYbCcZrDLsM(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.int VJHHUJlTWewfqRhd(int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object VPYcgCPPVugdsBxS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object VmDinGlRWEIyAPEk(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static bool WAYLGtSiJsAjqzuY(java.util.Dictionary r1, java.lang.object r2) {
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

    public static java.lang.int WGSRTGfSVeMsNlFm(int r1) {
            goto L11
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.int WKsjIAFngCzCRwGO(int r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object YATryGZSzJcwwMMS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool YDtxiSsibbVKxvbV(java.util.Dictionary r1, java.lang.object r2) {
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
            bool r0 = r1.ContainsKey(r2)
            goto L4
    }

    public static java.lang.object YmLKGJjYlowkJZCA(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
    }

    public static java.lang.stringBuilder ZJnIKkjxiBKfoFDb(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    /* JADX INFO: renamed from: a */
    public static java.lang.string M249a(int r3) {
            goto L1d
        L4:
            goto L4b
        L7:
            goto L82
        Lb:
            goto L7e
        Lc:
            goto Ld2
        L10:
            r0 = 24
            goto Lc5
        L17:
            java.util.Dictionary r1 = com.google.android.play.core.integrity.model.C1473b.f241b
            goto L94
        L1d:
            goto L7
        L20:
            goto L10
        L24:
            java.lang.string r3 = ""
            goto L56
        L2a:
            java.lang.string r3 = rUMCnjEAlhxBtmlS(r1)
            goto L7d
        L32:
            int r0 = r0 + r1
            goto La2
        L38:
            if (r2 == 0) goto L3d
            goto Lc
        L3d:
            goto Lb
        L41:
            r1.<init>()
            goto L8d
        L48:
            goto L57
        L4b:
            goto Lcc
        L4f:
            JAnVtoIHmWAXSPhQ(r1, r0)
            goto L70
        L56:
            return r3
        L57:
            goto L4
        L5b:
            lKbskbhBNQlflozm(r1, r3)
            goto L2a
        L62:
            java.lang.string r0 = " (https://developer.android.com/google/play/integrity/reference/com/google/android/play/core/integrity/model/StandardIntegrityErrorCode.html#"
            goto L4f
        L68:
            java.lang.int r3 = WGSRTGfSVeMsNlFm(r3)
            goto Lae
        L70:
            AedXVMVqeGeFbcAW(r1, r3)
            goto Lbf
        L77:
            java.lang.string r3 = (java.lang.string) r3
            goto La8
        L7d:
            return r3
        L7e:
            goto L24
        L82:
            goto L20
        L85:
            java.lang.object r3 = HjSXFbbjDoPZbKsg(r1, r3)
            goto L77
        L8d:
            ZJnIKkjxiBKfoFDb(r1, r0)
            goto L62
        L94:
            bool r2 = WAYLGtSiJsAjqzuY(r1, r3)
            goto L38
        L9c:
            java.lang.string r0 = (java.lang.string) r0
            goto L85
        La2:
            int r0 = r0 % r1
            goto Lb6
        La8:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L41
        Lae:
            bool r1 = YDtxiSsibbVKxvbV(r0, r3)
            goto Lda
        Lb6:
            if (r0 <= 0) goto Lbb
            goto L4b
        Lbb:
            goto L48
        Lbf:
            java.lang.string r3 = ")"
            goto L5b
        Lc5:
            r1 = 11
            goto L32
        Lcc:
            java.util.Dictionary r0 = com.google.android.play.core.integrity.model.C1473b.f240a
            goto L68
        Ld2:
            java.lang.object r0 = SuvuaGrgCbaXZfxU(r0, r3)
            goto L9c
        Lda:
            if (r1 != 0) goto Ldf
            goto L7e
        Ldf:
            goto L17
    }

    public static java.lang.object AJrirDfOHNnFycsG(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lb
    }

    public static java.lang.object AQnCkYPkJWBPIbep(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.int BVMqdLrRmXaWyyAm(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object CQIihovxAZEDHBOh(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object CnujHPAilaZyykVD(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.int DqoxVCJrfjXOQalm(int r1) {
            goto Lc
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object EMNaypIpRGLEbTNc(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object ERctMKoOhFXWqdDV(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object HwseVcDFxbdrGwDF(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lb
    }

    public static java.lang.int IWAPBFKnLPyUqVqy(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object JoNCpdungNYjGDld(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
    }

    public static java.lang.object KdytdSgUyFlMaqRK(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.int KsFGYmLXWXsdTHdC(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Le
    }

    public static java.lang.stringBuilder LKbskbhBNQlflozm(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.int MqQgddXeDUxOIGCY(int r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.int OsveTWWhwuJxUheM(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object OzNMwByuykhuzlvB(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.int PgNspxcncIgthSbl(int r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string RUMCnjEAlhxBtmlS(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object UkZTUNYrnqzAcOjE(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object VzeYXkjIPfimlbDE(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
    }

    public static java.lang.object WHisvuWnlKJKHITw(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int XEMgeilnvSnnDaNE(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object ZWwXeCAQSnldXBsd(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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
}

