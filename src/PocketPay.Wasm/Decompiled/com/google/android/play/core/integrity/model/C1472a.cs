namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.model.a */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1472a {

    /* JADX INFO: renamed from: a */
    private static readonly java.util.Dictionary f238a = null;

    /* JADX INFO: renamed from: b */
    private static readonly java.util.Dictionary f239b = null;

    static {
            goto L180
        L4:
            com.google.android.play.core.integrity.model.C1472a.f238a = r0
            goto L368
        La:
            r5 = -4
            goto L1dc
        Lf:
            OTAxyakNSEQsEsQR(r1, r14, r0)
            goto L32f
        L16:
            java.lang.string r15 = "Nonce is not encoded as a base64 web-safe no-wrap string.\nRetry with correct nonce format.\n"
            goto L322
        L1c:
            java.lang.int r15 = UPNowhcyOxECyowN(r15)
            goto L2c7
        L24:
            r13 = -12
            goto L2aa
        L2a:
            wesqejGhpsbWHZjP(r1, r2, r0)
            goto L2fb
        L31:
            r14 = -13
            goto L23d
        L37:
            lkVNjqsfeDyRdUkz(r0, r13, r14)
            goto L31
        L3e:
            r0 = 1
            goto L223
        L45:
            java.lang.string r4 = "The Play Store app is either not installed or not the official version.\nAsk the user to install an official and recent version of Play Store.\n"
            goto L354
        L4b:
            java.lang.string r0 = "GOOGLE_SERVER_UNAVAILABLE"
            goto L283
        L51:
            rdhAOrxhoQobuidS(r0, r2, r3)
            goto L298
        L58:
            java.lang.string r0 = "CANNOT_BIND_TO_SERVICE"
            goto L2ec
        L5e:
            r11 = -10
            goto L26c
        L64:
            java.lang.int r14 = pmyUOCgMNOHyRGQX(r14)
            goto L204
        L6c:
            java.lang.string r13 = "The Play Store needs to be updated.\nAsk the user to update the Google Play Store.\n"
            goto L274
        L72:
            java.lang.int r12 = KIoBlIepuAzJbiGN(r12)
            goto L14b
        L7a:
            qikkYWjxZaIIqhNo(r0, r14, r12)
            goto L174
        L81:
            r2 = -1
            goto L2bf
        L86:
            r6 = -5
            goto Lff
        L8b:
            AqvdYAoPzBmxHyIj(r1, r11, r0)
            goto L348
        L92:
            java.lang.string r5 = "Network error: unable to obtain integrity details.\nAsk the user to check for a connection.\n"
            goto L259
        L98:
            EDgsZvMvvEtyRfJG(r1, r2, r0)
            goto L4b
        L9f:
            java.lang.string r13 = "Nonce length is too long. The nonce must be less than 500 bytes before base64 encoding.\nRetry with a shorter nonce.\n"
            goto L334
        La5:
            r18 = r12
            goto Lf9
        Lab:
            java.lang.string r11 = "Binding to the service in the Play Store has failed. This can be due to having an old Play Store version installed on the device.\nAsk the user to update Play Store.\n"
            goto Le5
        Lb1:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto Lc5
        Lb7:
            r14 = -16
            goto L18f
        Lbd:
            java.lang.int r3 = NoQhBnslPQmjfBHO(r3)
            goto L45
        Lc5:
            r0.<init>()
            goto L4
        Lcc:
            java.lang.string r8 = "Google Play Services is not available or version is too old.\nAsk the user to Install or Update Play Services.\n"
            goto L307
        Ld2:
            r2 = r18
            goto L2a
        Ld8:
            aGxgAdJNZoRBEACQ(r0, r5, r6)
            goto L86
        Ldf:
            r15 = -14
            goto L1c
        Le5:
            xUYqxbGPVXDsIJwS(r0, r10, r11)
            goto L5e
        Lec:
            goto L2a6
        Lef:
            goto L157
        Lf3:
            java.lang.string r0 = "NETWORK_ERROR"
            goto L1b0
        Lf9:
            java.lang.string r12 = "The provided cloud project number is invalid.\nUse the cloud project number which can be found in Project info in your Google Cloud Console for the cloud project where Play Integrity API is enabled.\n"
            goto L216
        Lff:
            java.lang.int r6 = IqpnIOhvoviKEjTZ(r6)
            goto L1fe
        L107:
            qzAEMrHMDXxlPCHm(r0, r6, r7)
            goto L146
        L10e:
            java.lang.string r9 = "The calling app UID (user id) does not match the one from Package Manager.\nSomething is wrong (possibly an attack). Non-actionable.\n"
            goto L2b8
        L114:
            if (r0 <= 0) goto L119
            goto L2a6
        L119:
            goto L2a3
        L11d:
            java.lang.string r12 = "Nonce length is too short. The nonce must be a minimum of 16 bytes (before base64 encoding) to allow for a better security.\nRetry with a longer nonce.\n"
            goto L19d
        L123:
            RgSJxfNSBXkituXC(r0, r13, r14)
            goto Lb7
        L12a:
            java.lang.string r3 = "Integrity API is not available.\nIntegrity API is not enabled, or the Play Store version might be old.\nRecommended actions:\n1) Make sure that Integrity API is enabled in Google Play Console.\n2) Ask the user to update Play Store.\n"
            goto L51
        L130:
            YIzPGVvXDoTPDxLt(r1, r13, r0)
            goto L1cb
        L137:
            java.lang.int r7 = tCgALXbNGpyDiHnr(r7)
            goto Lcc
        L13f:
            wygOczTzfPNKYgyY(r1, r7, r0)
            goto L1be
        L146:
            r7 = -6
            goto L137
        L14b:
            r19 = r14
            goto L1a4
        L151:
            r12 = -11
            goto L27b
        L157:
            goto L183
        L15a:
            r13 = -15
            goto L2d9
        L160:
            java.lang.string r0 = "APP_NOT_INSTALLED"
            goto L341
        L166:
            CzVxMbrIuYsyyJQQ(r1, r2, r0)
            goto L33b
        L16d:
            VFyzAsGdMtOOpqUi(r1, r5, r0)
            goto L2cd
        L174:
            java.lang.string r0 = "API_NOT_AVAILABLE"
            goto L236
        L17a:
            java.lang.string r14 = "Play Services needs to be updated.\nAsk the user to update Google Play Services.\n"
            goto L123
        L180:
            goto Lef
        L183:
            goto L3e
        L187:
            java.lang.int r4 = mQcPAlQezadtxSai(r4)
            goto L92
        L18f:
            java.lang.int r14 = QxRZMgMVnwjtSXHh(r14)
            goto La5
        L197:
            com.google.android.play.core.integrity.model.C1472a.f239b = r1
            goto L81
        L19d:
            AxKxGPINxLguvyfX(r0, r11, r12)
            goto L151
        L1a4:
            java.lang.string r14 = "Unknown error processing integrity request.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n"
            goto L24b
        L1aa:
            int r0 = r0 % r1
            goto L114
        L1b0:
            KjxzrYXKrUBGGZwA(r1, r4, r0)
            goto L260
        L1b7:
            r1.<init>()
            goto L197
        L1be:
            java.lang.string r0 = "PLAY_SERVICES_VERSION_OUTDATED"
            goto L130
        L1c4:
            MDHfYCKqYPEcdldq(r0, r9, r10)
            goto L20a
        L1cb:
            java.lang.string r0 = "APP_UID_MISMATCH"
            goto L252
        L1d1:
            java.lang.string r0 = "INTERNAL_ERROR"
            goto L301
        L1d7:
            r8 = -7
            goto L2f3
        L1dc:
            java.lang.int r5 = QttnqCUuvzMYMiZh(r5)
            goto L2e6
        L1e4:
            r9 = -8
            goto L1e9
        L1e9:
            java.lang.int r9 = LtVbDndlspbzKHPA(r9)
            goto L245
        L1f1:
            SVdDrEMjEELSVink(r1, r2, r0)
            goto L22a
        L1f8:
            r2 = r17
            goto L166
        L1fe:
            java.lang.string r7 = "PackageManager could not find this app.\nSomething is wrong (possibly an attack). Non-actionable.\n"
            goto L107
        L204:
            r20 = r12
            goto L266
        L20a:
            r10 = -9
            goto L290
        L210:
            java.lang.string r0 = "PLAY_SERVICES_NOT_FOUND"
            goto L13f
        L216:
            GROJcXawPqLVMgoD(r0, r14, r12)
            goto L34e
        L21d:
            java.lang.string r0 = "NONCE_TOO_SHORT"
            goto L8b
        L223:
            r1 = 13
            goto L230
        L22a:
            java.lang.string r0 = "CLIENT_TRANSIENT_ERROR"
            goto Lf
        L230:
            int r0 = r0 + r1
            goto L1aa
        L236:
            OqzjSzLAGjqMbwEF(r1, r2, r0)
            goto Lf3
        L23d:
            java.lang.int r14 = YxSPTawiQjWSpBeb(r14)
            goto L16
        L245:
            java.lang.string r10 = "The calling app is making too many requests to the API and hence is throttled.\nRetry with an exponential backoff.\n"
            goto L1c4
        L24b:
            cHpBHMvVRaiPHUWb(r0, r12, r14)
            goto L329
        L252:
            ESTHUiTTQLTMYvmy(r1, r8, r0)
            goto L2b2
        L259:
            PWmkbdczNqYurXIp(r0, r4, r5)
            goto La
        L260:
            java.lang.string r0 = "PLAY_STORE_NOT_FOUND"
            goto L30e
        L266:
            java.lang.string r12 = "There is a error on the calling device.\nRetry with an exponential backoff.\n"
            goto L7a
        L26c:
            java.lang.int r11 = KttGeMeOvWzOcUNs(r11)
            goto L11d
        L274:
            oxWiSKEmevTQapOI(r0, r15, r13)
            goto L15a
        L27b:
            java.lang.int r12 = IDhfVZOvbMLMfavM(r12)
            goto L9f
        L283:
            r2 = r16
            goto L289
        L289:
            bXxcisYUyRzByIrY(r1, r2, r0)
            goto L1d1
        L290:
            java.lang.int r10 = zKqSwgXTUuxTuaiB(r10)
            goto Lab
        L298:
            r3 = -2
            goto Lbd
        L29d:
            r17 = r14
            goto L17a
        L2a3:
            goto L330
        L2a6:
            goto Lb1
        L2aa:
            java.lang.int r13 = jyezjRJIxwGJHXBu(r13)
            goto L2d3
        L2b2:
            java.lang.string r0 = "TOO_MANY_REQUESTS"
            goto L315
        L2b8:
            YwFPjBVxCSvOTyZv(r0, r8, r9)
            goto L1e4
        L2bf:
            java.lang.int r2 = gquSGdiUADiKsVvB(r2)
            goto L12a
        L2c7:
            r16 = r13
            goto L6c
        L2cd:
            java.lang.string r0 = "PLAY_STORE_VERSION_OUTDATED"
            goto L361
        L2d3:
            java.lang.string r14 = "Unknown internal Google server error.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n"
            goto L37
        L2d9:
            java.lang.int r13 = upxUXbRtshLvinFe(r13)
            goto L29d
        L2e1:
            r4 = -3
            goto L187
        L2e6:
            java.lang.string r6 = "No active account found in the Play Store app. Note that the Play Integrity API now supports unauthenticated requests. This error code is used only for older Play Store versions that lack support.\nAsk the user to authenticate in Play Store.\n"
            goto Ld8
        L2ec:
            BKijQfbXJpotBQpl(r1, r10, r0)
            goto L21d
        L2f3:
            java.lang.int r8 = YHlPkgLsLLNnxhbL(r8)
            goto L10e
        L2fb:
            java.lang.string r0 = "NONCE_IS_NOT_BASE64"
            goto L1f8
        L301:
            r2 = r20
            goto L1f1
        L307:
            KIEpEiRdxkdrEgOu(r0, r7, r8)
            goto L1d7
        L30e:
            SuLBoZyKKrZwrZdw(r1, r3, r0)
            goto L31c
        L315:
            lQzJDRBYZhlkXXOR(r1, r9, r0)
            goto L58
        L31c:
            java.lang.string r0 = "PLAY_STORE_ACCOUNT_NOT_FOUND"
            goto L16d
        L322:
            jlJnhTziglwaUppa(r0, r14, r15)
            goto Ldf
        L329:
            r14 = -17
            goto L64
        L32f:
            return
        L330:
            goto Lec
        L334:
            SuQVWoYqqVvEeIYI(r0, r12, r13)
            goto L24
        L33b:
            java.lang.string r0 = "CLOUD_PROJECT_NUMBER_IS_INVALID"
            goto L35b
        L341:
            CVvIYpMJoOSdPIvR(r1, r6, r0)
            goto L210
        L348:
            java.lang.string r0 = "NONCE_TOO_LONG"
            goto Ld2
        L34e:
            r12 = -100
            goto L72
        L354:
            QtZRBSubEZvuOqiN(r0, r3, r4)
            goto L2e1
        L35b:
            r2 = r19
            goto L98
        L361:
            AzwdlzTeHvafpDNT(r1, r15, r0)
            goto L160
        L368:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L1b7
    }

    public static java.lang.object AqvdYAoPzBmxHyIj(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object AxKxGPINxLguvyfX(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object AzwdlzTeHvafpDNT(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object BKijQfbXJpotBQpl(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object CVvIYpMJoOSdPIvR(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static java.lang.object CzVxMbrIuYsyyJQQ(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object EDgsZvMvvEtyRfJG(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object ESTHUiTTQLTMYvmy(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object FWposHNtujXHeFCk(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1[r2)
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

    public static java.lang.object GROJcXawPqLVMgoD(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int IDhfVZOvbMLMfavM(int r1) {
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

    public static java.lang.int IqpnIOhvoviKEjTZ(int r1) {
            goto Lf
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static java.lang.object KIEpEiRdxkdrEgOu(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int KIoBlIepuAzJbiGN(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static java.lang.object KjxzrYXKrUBGGZwA(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int KttGeMeOvWzOcUNs(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static java.lang.int LtVbDndlspbzKHPA(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object MDHfYCKqYPEcdldq(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static bool NNDVjkXWdTpsigrL(java.util.Dictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.ContainsKey(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.int NoQhBnslPQmjfBHO(int r1) {
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

    public static java.lang.object OTAxyakNSEQsEsQR(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object OqzjSzLAGjqMbwEF(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object PWmkbdczNqYurXIp(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object QtZRBSubEZvuOqiN(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.int QttnqCUuvzMYMiZh(int r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.int QxRZMgMVnwjtSXHh(int r1) {
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

    public static java.lang.object RgSJxfNSBXkituXC(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object SVdDrEMjEELSVink(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static java.lang.object SuLBoZyKKrZwrZdw(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object SuQVWoYqqVvEeIYI(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static java.lang.object UFSyBNVlwJZPoFjE(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            java.lang.object r0 = r1[r2)
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

    public static java.lang.int UPNowhcyOxECyowN(int r1) {
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

    public static java.lang.object VFyzAsGdMtOOpqUi(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.stringBuilder VRjHPWwIFfVKVZCT(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.int YHlPkgLsLLNnxhbL(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object YIzPGVvXDoTPDxLt(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object YwFPjBVxCSvOTyZv(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int YxSPTawiQjWSpBeb(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L7
    }

    /* JADX INFO: renamed from: a */
    public static java.lang.string M248a(int r3) {
            goto Le
        L4:
            goto L11
        L7:
            r1 = 27
            goto Lb5
        Le:
            goto L95
        L11:
            goto L3a
        L15:
            if (r0 <= 0) goto L1a
            goto L21
        L1a:
            goto L1e
        L1e:
            goto L70
        L21:
            goto Lc3
        L25:
            r1.<init>()
            goto Lc9
        L2c:
            java.lang.int r3 = hweDILZGaESccRox(r3)
            goto L51
        L34:
            java.lang.string r3 = (java.lang.string) r3
            goto La4
        L3a:
            r0 = 30
            goto L7
        L41:
            cKouDUwhiYhmMArg(r1, r3)
            goto L84
        L48:
            if (r1 != 0) goto L4d
            goto Lab
        L4d:
            goto L99
        L51:
            bool r1 = NNDVjkXWdTpsigrL(r0, r3)
            goto L48
        L59:
            java.lang.object r3 = UFSyBNVlwJZPoFjE(r1, r3)
            goto L34
        L61:
            java.lang.string r3 = ""
            goto L6f
        L67:
            bool r2 = igCeHebzWMFVgjgm(r1, r3)
            goto L7b
        L6f:
            return r3
        L70:
            goto L92
        L74:
            oUyXMWwygRlXCmsQ(r1, r3)
            goto Ld0
        L7b:
            if (r2 == 0) goto L80
            goto La0
        L80:
            goto L9f
        L84:
            java.lang.string r3 = sLExVpwwXMFVrmZJ(r1)
            goto Laa
        L8c:
            int r0 = r0 % r1
            goto L15
        L92:
            goto L21
        L95:
            goto L4
        L99:
            java.util.Dictionary r1 = com.google.android.play.core.integrity.model.C1472a.f239b
            goto L67
        L9f:
            goto Lab
        La0:
            goto Lbb
        La4:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L25
        Laa:
            return r3
        Lab:
            goto L61
        Laf:
            java.lang.string r0 = (java.lang.string) r0
            goto L59
        Lb5:
            int r0 = r0 + r1
            goto L8c
        Lbb:
            java.lang.object r0 = FWposHNtujXHeFCk(r0, r3)
            goto Laf
        Lc3:
            java.util.Dictionary r0 = com.google.android.play.core.integrity.model.C1472a.f238a
            goto L2c
        Lc9:
            qVleUmdTfFeFDHIT(r1, r0)
            goto Ld6
        Ld0:
            java.lang.string r3 = ")"
            goto L41
        Ld6:
            java.lang.string r0 = " (https://developer.android.com/google/play/integrity/reference/com/google/android/play/core/integrity/model/IntegrityErrorCode.html#"
            goto Ldc
        Ldc:
            VRjHPWwIFfVKVZCT(r1, r0)
            goto L74
    }

    public static java.lang.object AGxgAdJNZoRBEACQ(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object BXxcisYUyRzByIrY(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object CHpBHMvVRaiPHUWb(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.stringBuilder CKouDUwhiYhmMArg(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.int GquSGdiUADiKsVvB(int r1) {
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

    public static java.lang.int HweDILZGaESccRox(int r1) {
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

    public static bool IgCeHebzWMFVgjgm(java.util.Dictionary r1, java.lang.object r2) {
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

    public static java.lang.object JlJnhTziglwaUppa(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static java.lang.int JyezjRJIxwGJHXBu(int r1) {
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

    public static java.lang.object LQzJDRBYZhlkXXOR(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object LkVNjqsfeDyRdUkz(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int MQcPAlQezadtxSai(int r1) {
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

    public static java.lang.stringBuilder OUyXMWwygRlXCmsQ(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.object OxWiSKEmevTQapOI(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int PmyUOCgMNOHyRGQX(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static java.lang.stringBuilder QVleUmdTfFeFDHIT(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.object QikkYWjxZaIIqhNo(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object QzAEMrHMDXxlPCHm(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object RdhAOrxhoQobuidS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.string SLExVpwwXMFVrmZJ(java.lang.stringBuilder r1) {
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

    public static java.lang.int TCgALXbNGpyDiHnr(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Lb
    }

    public static java.lang.int UpxUXbRtshLvinFe(int r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object WesqejGhpsbWHZjP(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object WygOczTzfPNKYgyY(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object XUYqxbGPVXDsIJwS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.int ZKqSwgXTUuxTuaiB(int r1) {
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
}

