namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\r\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\nH\u0016¨\u0006\u000b"}, d2 = {"com/psr/top/sdk/kernel/providers/biometry/executors/SaveAuthenticateExecutor$execute$1$1$biometricPrompt$1", "Landroidx/biometric/BiometricPrompt$AuthenticationCallback;", "onAuthenticationError", "", "errorCode", "", "errstring", "", "onAuthenticationSucceeded", "result", "Landroidx/biometric/BiometricPrompt$AuthenticationResult;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class ped6b769f$pec0cd3cb$1$1$p8601640c$1 : androidx.biometric.BiometricPrompt$AuthenticationCallback {
    readonly byte[] $appCodebytes;
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $callback;
    readonly io.reactivex.rxjava3.core.CompletableEmitter $emitter;
    readonly java.lang.string $extraKey;
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.ped6b769f this$0;

    ped6b769f$pec0cd3cb$1$1$p8601640c$1(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, kotlin.jvm.functions.Function0<kotlin.Unit> function0, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.ped6b769f ped6b769fVar, byte[] bArr, java.lang.string str) {
        this.$emitter = completableEmitter;
        this.$callback = function0;
        this.this$0 = ped6b769fVar;
        this.$appCodebytes = bArr;
        this.$extraKey = str;
    }

    public static void CaKYXnDptNtBbyiE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.biometric.BiometricPrompt$Cryptoobject GVlCYXnakudNbrUr(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        return biometricPrompt$AuthenticationResult.getCryptoobject();
    }

    public static void KpbtOuhuCLaOxyQZ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static void LrcVyyUdyxriBHYn(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, i, obj);
    }

    public static byte[] QVqWAvHVmwhZbjDj(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, javax.crypto.Cipher cipher, byte[] bArr) {
        return p97f30e5fVar.encryptWithCipher(cipher, bArr);
    }

    public static void RHHeTpFtfFJZhvZL(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public static void RavJQRwjUomFNKVA(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pddecebde.pa25971c4 pa25971c4Var, java.lang.string str, java.lang.string str2) {
        pa25971c4Var.setstring(str, str2);
    }

    public static java.lang.string SLLFdeEvgALtYdFT(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static void UjWAjvEMHZvyNgPw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b WMCUYfLEiBZXNlXU(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getCode();
    }

    public static java.lang.string WvljjcCrJLeOhiVd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static javax.crypto.Cipher AaXDeqsPyXyZmgXW(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getCipher();
    }

    public static void DPvJLxCxaAZMDoKe(androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback, androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        super.onAuthenticationSucceeded(biometricPrompt$AuthenticationResult);
    }

    public static void DXOVUPVMuRRAuXOu(androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback, int i, java.lang.CharSequence charSequence) {
        super.onAuthenticationError(i, charSequence);
    }

    public static java.lang.string EZFFiDqZIvdQlTxY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var) {
        return p5c1be8f5Var.getMessage();
    }

    public static void EkHRdctfhLiKtwmH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static java.lang.string HwyZLwrXpXUkcAsh(byte[] bArr) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p1ceded00.m8d6ea934(bArr);
    }

    public static java.lang.object KtvFIfZBphQmRSja(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pddecebde.pa25971c4 PGAtHKiEqUQfYUiU(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.ped6b769f ped6b769fVar) {
        return ped6b769fVar.getTophStorage();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f PemzienQlXASdvYy(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.ped6b769f ped6b769fVar) {
        return ped6b769fVar.getTophCrypto();
    }

    public static bool WPBSJkVzcQvnIndr(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, java.lang.Exception th) {
        return completableEmitter.tryOnError(th);
    }

    public static void YLWeJKJljtqKIewo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, i, obj);
    }

    public override void OnAuthenticationError(int errorCode, java.lang.CharSequence errstring) {
        if ((30 + 10) % 10 > 0) {
        }
        UjWAjvEMHZvyNgPw(errstring, "errstring");
        dXOVUPVMuRRAuXOu(this, errorCode, errstring);
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5 p5c1be8f5Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p5c1be8f5(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b.f00272f9b);
        LrcVyyUdyxriBHYn(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "SaveAuthenticateExecutor", "execute()", "65", null, "auth error", 8, null);
        KpbtOuhuCLaOxyQZ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "SaveAuthenticateExecutor", "execute()", "73", null, eZFFiDqZIvdQlTxY(p5c1be8f5Var), WMCUYfLEiBZXNlXU(p5c1be8f5Var), 8, null);
        wPBSJkVzcQvnIndr(this.$emitter, p5c1be8f5Var);
    }

    public override void OnAuthenticationSucceeded(androidx.biometric.BiometricPrompt$AuthenticationResult result) {
        androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$CryptoobjectGVlCYXnakudNbrUr;
        javax.crypto.Cipher cipherAaXDeqsPyXyZmgXW;
        if ((25 + 4) % 4 > 0) {
        }
        CaKYXnDptNtBbyiE(result, "result");
        dPvJLxCxaAZMDoKe(this, result);
        try {
            biometricPrompt$CryptoobjectGVlCYXnakudNbrUr = GVlCYXnakudNbrUr(result);
        } catch (java.lang.Exception e) {
            yLWeJKJljtqKIewo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "SaveAuthenticateExecutor", "execute()", "91", null, SLLFdeEvgALtYdFT(e), 8, null);
            ktvFIfZBphQmRSja(this.$callback);
        }
        if (biometricPrompt$CryptoobjectGVlCYXnakudNbrUr is null || (cipherAaXDeqsPyXyZmgXW = aaXDeqsPyXyZmgXW(biometricPrompt$CryptoobjectGVlCYXnakudNbrUr)) is null) {
            throw new java.lang.Exception();
        }
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.ped6b769f ped6b769fVar = this.this$0;
        RavJQRwjUomFNKVA(pGAtHKiEqUQfYUiU(ped6b769fVar), this.$extraKey, hwyZLwrXpXUkcAsh(QVqWAvHVmwhZbjDj(pemzienQlXASdvYy(ped6b769fVar), cipherAaXDeqsPyXyZmgXW, this.$appCodebytes)));
        ekHRdctfhLiKtwmH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AuthenticateExecutor", "execute()", "101", WvljjcCrJLeOhiVd("1f06ef4856189e86260357501dede564969eabbcfb7b598f8f5add14054d58312b42ba"), "auth success");
        RHHeTpFtfFJZhvZL(this.$emitter);
    }
}

