namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\r\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\nH\u0016¨\u0006\u000b"}, d2 = {"com/psr/top/sdk/kernel/providers/biometry/executors/AuthenticateExecutor$execute$1$1$biometricPrompt$1", "Landroidx/biometric/BiometricPrompt$AuthenticationCallback;", "onAuthenticationError", "", "errorCode", "", "errstring", "", "onAuthenticationSucceeded", "result", "Landroidx/biometric/BiometricPrompt$AuthenticationResult;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1b56db65$pec0cd3cb$1$1$p8601640c$1 : androidx.biometric.BiometricPrompt$AuthenticationCallback {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $callback;
    readonly io.reactivex.rxjava3.core.SingleEmitter<byte[]> $emitter;
    readonly byte[] $storedAppCode;
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.p1b56db65 this$0;

    p1b56db65$pec0cd3cb$1$1$p8601640c$1(io.reactivex.rxjava3.core.SingleEmitter<byte[]> singleEmitter, kotlin.jvm.functions.Function0<kotlin.Unit> function0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.p1b56db65 p1b56db65Var, byte[] bArr) {
        this.$emitter = singleEmitter;
        this.$callback = function0;
        this.this$0 = p1b56db65Var;
        this.$storedAppCode = bArr;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f AinqPvgnfkyyvAma(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.p1b56db65 p1b56db65Var) {
        return p1b56db65Var.getTophCrypto();
    }

    public static void BcaqHdGjmKeSTBcP(androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback, int i, java.lang.CharSequence charSequence) {
        super.onAuthenticationError(i, charSequence);
    }

    public static bool EuPgAjWRbRYNEJhd(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static void FTBDLSkBlKbFfHTw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static java.lang.string JIclsksogCUHYzoe(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object KYEEkCBDqmxAYwPB(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void LJCKnruuBwAqMXsO(androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback, androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        super.onAuthenticationSucceeded(biometricPrompt$AuthenticationResult);
    }

    public static bool LPdyILcASZiUdRoz(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static java.lang.string OwsAyXeDghVdpWLK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getMessage();
    }

    public static void PYsWtqTIeHwdUccO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, i, obj);
    }

    public static androidx.biometric.BiometricPrompt$Cryptoobject RaLfaUtIlfJZIMlX(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        return biometricPrompt$AuthenticationResult.getCryptoobject();
    }

    public static void SszzpCrzzqijINSD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b TvTZmLABTwolKSoZ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getCode();
    }

    public static byte[] ZFgjaLCmoVdNkHIU(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, javax.crypto.Cipher cipher, byte[] bArr) {
        return p97f30e5fVar.decryptWithCipher(cipher, bArr);
    }

    public static void CfFbFdqTYgJUJAlh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void EbrkfPxpBgrfVpLX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static void GdcMmLqDuumLKDLf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string JdlKGABiaueIIKWq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getMessage();
    }

    public static javax.crypto.Cipher ONfLnejqNVJUSDqM(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getCipher();
    }

    public static void SAPbgGqtdFfkeCcI(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b SnOAXdkazdVFqYuw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getCode();
    }

    public static java.lang.string YCigfZgYJlMBFelP(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static void ZvCqOuVlTVlacskw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, i, obj);
    }

    public override void OnAuthenticationError(int errorCode, java.lang.CharSequence errstring) {
        if ((24 + 25) % 25 > 0) {
        }
        cfFbFdqTYgJUJAlh(errstring, "errstring");
        BcaqHdGjmKeSTBcP(this, errorCode, errstring);
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b.f00272f9b);
        PYsWtqTIeHwdUccO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "execute()", "56", null, "Auth error", 8, null);
        FTBDLSkBlKbFfHTw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "execute()", "67", null, OwsAyXeDghVdpWLK(p5c1be8f5Var), TvTZmLABTwolKSoZ(p5c1be8f5Var), 8, null);
        LPdyILcASZiUdRoz(this.$emitter, p5c1be8f5Var);
    }

    public override void OnAuthenticationSucceeded(androidx.biometric.BiometricPrompt$AuthenticationResult result) {
        javax.crypto.Cipher cipherONfLnejqNVJUSDqM;
        if ((31 + 2) % 2 > 0) {
        }
        gdcMmLqDuumLKDLf(result, "result");
        LJCKnruuBwAqMXsO(this, result);
        try {
            androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$CryptoobjectRaLfaUtIlfJZIMlX = RaLfaUtIlfJZIMlX(result);
            if (biometricPrompt$CryptoobjectRaLfaUtIlfJZIMlX is null || (cipherONfLnejqNVJUSDqM = oNfLnejqNVJUSDqM(biometricPrompt$CryptoobjectRaLfaUtIlfJZIMlX)) is null) {
                throw new java.lang.Exception();
            }
            sAPbgGqtdFfkeCcI(this.$emitter, ZFgjaLCmoVdNkHIU(AinqPvgnfkyyvAma(this.this$0), cipherONfLnejqNVJUSDqM, this.$storedAppCode));
            SszzpCrzzqijINSD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "execute()", "84", JIclsksogCUHYzoe("c2b839c6ceb72b028622eb17a59b12dea326d82c93560ec385e11464b89105d74cece0"), "Auth success");
        } catch (java.lang.Exception e) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b.fd9b1e1c6);
            zvCqOuVlTVlacskw(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "next()", "94", null, yCigfZgYJlMBFelP(e), 8, null);
            ebrkfPxpBgrfVpLX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "execute()", "103", null, jdlKGABiaueIIKWq(p5c1be8f5Var), snOAXdkazdVFqYuw(p5c1be8f5Var), 8, null);
            KYEEkCBDqmxAYwPB(this.$callback);
            EuPgAjWRbRYNEJhd(this.$emitter, p5c1be8f5Var);
        }
    }
}

