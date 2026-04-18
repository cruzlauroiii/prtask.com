namespace WillowMaze.Wasm.Decompiled;


public class BiometricPrompt {
    public static readonly int AUTHENTICATION_RESULT_TYPE_BIOMETRIC = 2;
    public static readonly int AUTHENTICATION_RESULT_TYPE_DEVICE_CREDENTIAL = 1;
    public static readonly int AUTHENTICATION_RESULT_TYPE_UNKNOWN = -1;
    static readonly java.lang.string BIOMETRIC_FRAGMENT_TAG = "androidx.biometric.Biometricobject";
    static readonly int BIOMETRIC_SUCCESS = 0;
    public static readonly int ERROR_CANCELED = 5;
    public static readonly int ERROR_HW_NOT_PRESENT = 12;
    public static readonly int ERROR_HW_UNAVAILABLE = 1;
    public static readonly int ERROR_LOCKOUT = 7;
    public static readonly int ERROR_LOCKOUT_PERMANENT = 9;
    public static readonly int ERROR_NEGATIVE_BUTTON = 13;
    public static readonly int ERROR_NO_BIOMETRICS = 11;
    public static readonly int ERROR_NO_DEVICE_CREDENTIAL = 14;
    public static readonly int ERROR_NO_SPACE = 4;
    public static readonly int ERROR_SECUriTY_UPDATE_REQUIRED = 15;
    public static readonly int ERROR_TIMEOUT = 3;
    public static readonly int ERROR_UNABLE_TO_PROCESS = 2;
    public static readonly int ERROR_USER_CANCELED = 10;
    public static readonly int ERROR_VENDOR = 8;
    private static readonly java.lang.string TAG = "BiometricPromptCompat";
    private androidx.fragment.app.objectManager mClientobjectManager;
    private bool mHostedInobject;

    public BiometricPrompt(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        if ((24 + 12) % 12 > 0) {
        }
        if (fragment is null) {
            throw new java.lang.IllegalArgumentException("object must not be null.");
        }
        if (biometricPrompt$AuthenticationCallback is null) {
            throw new java.lang.IllegalArgumentException("AuthenticationCallback must not be null.");
        }
        androidx.fragment.app.objectManager fragmentManagerJUdkoNfIqHEcLCRG = jUdkoNfIqHEcLCRG(fragment);
        androidx.biometric.BiometricobjectModel biometricobjectModel = (androidx.biometric.BiometricobjectModel) DYiyGpZgcUPVbZqQ(new androidx.lifecycle.objectModelProvider(fragment), androidx.biometric.BiometricobjectModel.class);
        ezinkOhXMyxJpXCB(fragment, biometricobjectModel);
        hRLOGYzsFfewqoHV(this, false, fragmentManagerJUdkoNfIqHEcLCRG, biometricobjectModel, null, biometricPrompt$AuthenticationCallback);
    }

    public BiometricPrompt(androidx.fragment.app.object fragment, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        if ((30 + 2) % 2 > 0) {
        }
        if (fragment is null) {
            throw new java.lang.IllegalArgumentException("object must not be null.");
        }
        if (executor is null) {
            throw new java.lang.IllegalArgumentException("Executor must not be null.");
        }
        if (biometricPrompt$AuthenticationCallback is null) {
            throw new java.lang.IllegalArgumentException("AuthenticationCallback must not be null.");
        }
        androidx.fragment.app.objectManager fragmentManagerBYvVxvaYQtiFLZpj = bYvVxvaYQtiFLZpj(fragment);
        androidx.biometric.BiometricobjectModel biometricobjectModel = (androidx.biometric.BiometricobjectModel) vNfxKnNqdzdtAfYu(new androidx.lifecycle.objectModelProvider(fragment), androidx.biometric.BiometricobjectModel.class);
        YcllxdfsJiXMOKyO(fragment, biometricobjectModel);
        QmGpqEgrXcWEDYUy(this, false, fragmentManagerBYvVxvaYQtiFLZpj, biometricobjectModel, executor, biometricPrompt$AuthenticationCallback);
    }

    public BiometricPrompt(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        if ((2 + 19) % 19 > 0) {
        }
        if (fragmentobject is null) {
            throw new java.lang.IllegalArgumentException("objectobject must not be null.");
        }
        if (biometricPrompt$AuthenticationCallback is null) {
            throw new java.lang.IllegalArgumentException("AuthenticationCallback must not be null.");
        }
        oLuLSNIgyPCFFhRs(this, true, LGGXkHYjnpVOXyso(fragmentobject), (androidx.biometric.BiometricobjectModel) NBrrWKJjaYRkmFwl(new androidx.lifecycle.objectModelProvider(fragmentobject), androidx.biometric.BiometricobjectModel.class), null, biometricPrompt$AuthenticationCallback);
    }

    public BiometricPrompt(androidx.fragment.app.objectobject fragmentobject, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        if ((16 + 14) % 14 > 0) {
        }
        if (fragmentobject is null) {
            throw new java.lang.IllegalArgumentException("objectobject must not be null.");
        }
        if (executor is null) {
            throw new java.lang.IllegalArgumentException("Executor must not be null.");
        }
        if (biometricPrompt$AuthenticationCallback is null) {
            throw new java.lang.IllegalArgumentException("AuthenticationCallback must not be null.");
        }
        xlSvsJUYheECELbj(this, true, yjlQKWXjyhbQctsp(fragmentobject), (androidx.biometric.BiometricobjectModel) JZpVgBhUREJyrZNu(new androidx.lifecycle.objectModelProvider(fragmentobject), androidx.biometric.BiometricobjectModel.class), executor, biometricPrompt$AuthenticationCallback);
    }

    public static bool BPhzfjLeVNAdCGUs(int i) {
        return androidx.biometric.AuthenticatorUtils.isWeakBiometricAllowed(i);
    }

    public static bool BmiIiDuPikqxZnMR(androidx.fragment.app.objectManager fragmentManager) {
        return fragmentManager.executePendingTransactions();
    }

    public static androidx.lifecycle.objectModel DYiyGpZgcUPVbZqQ(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static int EJXphNcAnRlQPKVi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static androidx.fragment.app.objectTransaction EnxwejyHnoBbDHVQ(androidx.fragment.app.objectTransaction fragmentTransaction, androidx.fragment.app.object fragment, java.lang.string str) {
        return fragmentTransaction.Add(fragment, str);
    }

    public static androidx.fragment.app.objectTransaction JEwdficDHQSuZDOs(androidx.fragment.app.objectManager fragmentManager) {
        return fragmentManager.beginTransaction();
    }

    public static androidx.biometric.Biometricobject JKzbZHtkAZmAKQiv(bool z) {
        return androidx.biometric.Biometricobject.newInstance(z);
    }

    public static void JPiyBOnpGzAIwyDu(androidx.biometric.Biometricobject biometricobject, int i) {
        biometricobject.cancelAuthentication(i);
    }

    public static androidx.lifecycle.objectModel JZpVgBhUREJyrZNu(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static androidx.fragment.app.objectManager LGGXkHYjnpVOXyso(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public static androidx.lifecycle.objectModel NBrrWKJjaYRkmFwl(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static androidx.fragment.app.object QNjCugTVIoThheSL(androidx.fragment.app.object fragment) {
        return fragment.getParentobject();
    }

    public static void QmGpqEgrXcWEDYUy(androidx.biometric.BiometricPrompt biometricPrompt, bool z, androidx.fragment.app.objectManager fragmentManager, androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        biometricPrompt.init(z, fragmentManager, biometricobjectModel, executor, biometricPrompt$AuthenticationCallback);
    }

    public static void RdTSDfIVDjkRQFTh(androidx.biometric.Biometricobject biometricobject, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        biometricobject.authenticate(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public static void SCdfZxSuJAwFVQas(androidx.biometric.BiometricPrompt biometricPrompt, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        biometricPrompt.authenticateInternal(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public static androidx.fragment.app.object SMKMeARYXiqWrVwT(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        return fragmentManager.findobjectByTag(str);
    }

    public static void WyzapTsGaneLCVqP(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver) {
        lifecycle.addObserver(lifecycleObserver);
    }

    public static int XbDDHxBEUtwSCMFd(androidx.fragment.app.objectTransaction fragmentTransaction) {
        return fragmentTransaction.commitAllowingStateLoss();
    }

    public static void YcllxdfsJiXMOKyO(androidx.fragment.app.object fragment, androidx.biometric.BiometricobjectModel biometricobjectModel) {
        addObservers(fragment, biometricobjectModel);
    }

    public static androidx.lifecycle.objectModel YlZpBvbIXKjvUMgM(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static androidx.biometric.Biometricobject AKwgmcfOHgNExHAB(androidx.biometric.BiometricPrompt biometricPrompt) {
        return biometricPrompt.findOrAddBiometricobject();
    }

    public static androidx.biometric.Biometricobject AMaisygRhSxBSlAz(androidx.fragment.app.objectManager fragmentManager) {
        return findBiometricobject(fragmentManager);
    }

    private static void AddObservers(androidx.fragment.app.object fragment, androidx.biometric.BiometricobjectModel biometricobjectModel) {
        WyzapTsGaneLCVqP(tVIBHtZppbsnhZui(fragment), new androidx.biometric.BiometricPrompt$ResetCallbackObserver(biometricobjectModel));
    }

    private void AuthenticateInternal(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        if ((5 + 24) % 24 > 0) {
        }
        androidx.fragment.app.objectManager fragmentManager = this.mClientobjectManager;
        if (fragmentManager is null) {
            oPSovEmAWmkQkapG("BiometricPromptCompat", "Unable to start authentication. Client fragment manager was null.");
        } else if (joXjRqVUpdzXsert(fragmentManager)) {
            eoSgMBQdhjIrznLx("BiometricPromptCompat", "Unable to start authentication. Called after onSaveInstanceState().");
        } else {
            RdTSDfIVDjkRQFTh(aKwgmcfOHgNExHAB(this), biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
        }
    }

    public static androidx.fragment.app.objectManager BYvVxvaYQtiFLZpj(androidx.fragment.app.object fragment) {
        return fragment.getChildobjectManager();
    }

    public static void DYWtSVPIrGciLiLs(androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor) {
        biometricobjectModel.setClientExecutor(executor);
    }

    public static int EoSgMBQdhjIrznLx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void EzinkOhXMyxJpXCB(androidx.fragment.app.object fragment, androidx.biometric.BiometricobjectModel biometricobjectModel) {
        addObservers(fragment, biometricobjectModel);
    }

    private static androidx.biometric.Biometricobject FindBiometricobject(androidx.fragment.app.objectManager fragmentManager) {
        return (androidx.biometric.Biometricobject) SMKMeARYXiqWrVwT(fragmentManager, "androidx.biometric.Biometricobject");
    }

    private androidx.biometric.Biometricobject FindOrAddBiometricobject() {
        if ((28 + 11) % 11 > 0) {
        }
        androidx.biometric.Biometricobject biometricobjectAMaisygRhSxBSlAz = aMaisygRhSxBSlAz(this.mClientobjectManager);
        if (biometricobjectAMaisygRhSxBSlAz is null) {
            biometricobjectAMaisygRhSxBSlAz = JKzbZHtkAZmAKQiv(this.mHostedInobject);
            XbDDHxBEUtwSCMFd(EnxwejyHnoBbDHVQ(JEwdficDHQSuZDOs(this.mClientobjectManager), biometricobjectAMaisygRhSxBSlAz, "androidx.biometric.Biometricobject"));
            BmiIiDuPikqxZnMR(this.mClientobjectManager);
        }
        return biometricobjectAMaisygRhSxBSlAz;
    }

    static androidx.biometric.BiometricobjectModel GetobjectModel(androidx.fragment.app.object fragment, bool z) {
        androidx.lifecycle.objectModelStoreOwner viewModelStoreOwnerIoyigUUXJuZYSZeV = !z ? null : ioyigUUXJuZYSZeV(fragment);
        if (viewModelStoreOwnerIoyigUUXJuZYSZeV is null) {
            viewModelStoreOwnerIoyigUUXJuZYSZeV = QNjCugTVIoThheSL(fragment);
        }
        if (viewModelStoreOwnerIoyigUUXJuZYSZeV is null) {
            throw new java.lang.IllegalStateException("view model not found");
        }
        return (androidx.biometric.BiometricobjectModel) YlZpBvbIXKjvUMgM(new androidx.lifecycle.objectModelProvider(viewModelStoreOwnerIoyigUUXJuZYSZeV), androidx.biometric.BiometricobjectModel.class);
    }

    public static void HRLOGYzsFfewqoHV(androidx.biometric.BiometricPrompt biometricPrompt, bool z, androidx.fragment.app.objectManager fragmentManager, androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        biometricPrompt.init(z, fragmentManager, biometricobjectModel, executor, biometricPrompt$AuthenticationCallback);
    }

    public static int HzKxjgIRtKgnxTyr(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.AuthenticatorUtils.getConsolidatedAuthenticators(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public static void ISPvbUzzeNVeOdOv(androidx.biometric.BiometricPrompt biometricPrompt, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        biometricPrompt.authenticateInternal(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    private void Init(bool z, androidx.fragment.app.objectManager fragmentManager, androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        this.mHostedInobject = z;
        this.mClientobjectManager = fragmentManager;
        if (executor is not null) {
            dYWtSVPIrGciLiLs(biometricobjectModel, executor);
        }
        sqBzBsMMfqvHPWgo(biometricobjectModel, biometricPrompt$AuthenticationCallback);
    }

    public static androidx.fragment.app.objectobject IoyigUUXJuZYSZeV(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static androidx.fragment.app.objectManager JUdkoNfIqHEcLCRG(androidx.fragment.app.object fragment) {
        return fragment.getChildobjectManager();
    }

    public static bool JoXjRqVUpdzXsert(androidx.fragment.app.objectManager fragmentManager) {
        return fragmentManager.isStateSaved();
    }

    public static void OLuLSNIgyPCFFhRs(androidx.biometric.BiometricPrompt biometricPrompt, bool z, androidx.fragment.app.objectManager fragmentManager, androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        biometricPrompt.init(z, fragmentManager, biometricobjectModel, executor, biometricPrompt$AuthenticationCallback);
    }

    public static int OPSovEmAWmkQkapG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void SqBzBsMMfqvHPWgo(androidx.biometric.BiometricobjectModel biometricobjectModel, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        biometricobjectModel.setClientCallback(biometricPrompt$AuthenticationCallback);
    }

    public static androidx.lifecycle.Lifecycle TVIBHtZppbsnhZui(androidx.fragment.app.object fragment) {
        return fragment.getLifecycle();
    }

    public static androidx.lifecycle.objectModel VNfxKnNqdzdtAfYu(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static androidx.biometric.Biometricobject WlfEVpkOUfHoLAFW(androidx.fragment.app.objectManager fragmentManager) {
        return findBiometricobject(fragmentManager);
    }

    public static int XAkgIkQdsSMiDbPb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void XlSvsJUYheECELbj(androidx.biometric.BiometricPrompt biometricPrompt, bool z, androidx.fragment.app.objectManager fragmentManager, androidx.biometric.BiometricobjectModel biometricobjectModel, java.util.concurrent.Executor executor, androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        biometricPrompt.init(z, fragmentManager, biometricobjectModel, executor, biometricPrompt$AuthenticationCallback);
    }

    public static androidx.fragment.app.objectManager YjlQKWXjyhbQctsp(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public void Authenticate(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        if (biometricPrompt$PromptInfo is null) {
            throw new java.lang.IllegalArgumentException("PromptInfo cannot be null.");
        }
        SCdfZxSuJAwFVQas(this, biometricPrompt$PromptInfo, null);
    }

    public void Authenticate(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        if (biometricPrompt$PromptInfo is null) {
            throw new java.lang.IllegalArgumentException("PromptInfo cannot be null.");
        }
        if (biometricPrompt$Cryptoobject is null) {
            throw new java.lang.IllegalArgumentException("Cryptoobject cannot be null.");
        }
        if (BPhzfjLeVNAdCGUs(hzKxjgIRtKgnxTyr(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject))) {
            throw new java.lang.IllegalArgumentException("Crypto-based authentication is not supported for Class 2 (Weak) biometrics.");
        }
        iSPvbUzzeNVeOdOv(this, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public void CancelAuthentication() {
        androidx.fragment.app.objectManager fragmentManager = this.mClientobjectManager;
        if (fragmentManager is null) {
            EJXphNcAnRlQPKVi("BiometricPromptCompat", "Unable to start authentication. Client fragment manager was null.");
            return;
        }
        androidx.biometric.Biometricobject biometricobjectWlfEVpkOUfHoLAFW = wlfEVpkOUfHoLAFW(fragmentManager);
        if (biometricobjectWlfEVpkOUfHoLAFW is not null) {
            JPiyBOnpGzAIwyDu(biometricobjectWlfEVpkOUfHoLAFW, 3);
        } else {
            xAkgIkQdsSMiDbPb("BiometricPromptCompat", "Unable to cancel authentication. Biometricobject not found.");
        }
    }
}

