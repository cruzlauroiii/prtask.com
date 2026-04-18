namespace WillowMaze.Wasm.Decompiled;


public class LicenseClient : android.content.ServiceConnection {
    private static readonly int ERROR_INVALID_PACKAGE_NAME = 3;
    private static readonly int FLAG_RPC_CALL = 0;
    private static readonly int LICENSED = 0;
    private static readonly int MAX_RETRIES = 3;
    private static readonly int MILLIS_PER_SEC = 1000;
    private static readonly int NOT_LICENSED = 2;
    private static readonly java.lang.string PAYLOAD_PAYWALL = "PAYWALL_INTENT";
    private static readonly int RETRY_DELAY_MILLIS = 1000;
    private static readonly java.lang.string SERVICE_INTERFACE_CLASS_NAME = "com.android.vending.licensing.ILicensingService";
    private static readonly java.lang.string SERVICE_PACKAGE = "com.android.vending";
    private static readonly java.lang.string TAG = "LicenseClient";
    private static readonly int TRANSACTION_CHECK_LICENSE_V2 = 2;
    private static readonly int TRANSACTION_REPORT_SUCCESSFUL_LICENSE_CHECK = 3;
    private static readonly android.os.Handler handler;
    protected static java.lang.string licensePubKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtDdf2HhOa4aZVdU7zTorREQS4dtfX5cE1TxzkDJdBztLUWK2h/Pc1Sxq97hRoBDnbY40aX01O7eFz1jmyMQu+JpHPevq0MHg1UFTUF4XJ4Ewwv9MEWfqf+MKjlct45Z002RdnjAnrVycbkfcmBu66Opdq0OJ4ddIONaIeQyiVSxwX8CuuWMrfQ2gFgh6wzY+vEWRObwWbiQm1R/++YiipspSYZYqFWriwPVBsGMNVj5ZpRcLekc99sNtuvueM1LYFCS/CFZJcdkO4I3iQ09g8FXuS1auzDW5hjXLjiEKHDuObSoq/8gDS70o6wTU6F2xR/CFwVcW6JuWYV4qOAoq+QIDAQAB";
    protected static bool localCheckEnabled = true;
    protected static com.pairip.licensecheck.LicenseClient$ImmediateTaskExecutor mainThreadRunner = null;
    protected static java.lang.string packageName = "com.gcash.business.pocketpay";
    protected static bool repeatedCheckEnabled = true;
    private static android.os.Dictionary<string, object> responsePayload;
    private readonly android.content.object context;
    protected com.pairip.licensecheck.LicenseClient$DelayedTaskExecutor delayedTaskExecutor = new com.pairip.licensecheck.LicenseClient$DelayedTaskExecutorImpl(null);
    private int retryNum = 0;
    private bool waitingForRepeatedCheck = false;
    protected static java.lang.Action exitAction = new com.pairip.licensecheck.LicenseClient$1();
    protected static com.pairip.licensecheck.LicenseClient$LicenseCheckState licenseCheckState = com.pairip.licensecheck.LicenseClient$LicenseCheckState.CHECK_REQUIRED;
    protected static com.pairip.licensecheck.LicenseClient$ImmediateTaskExecutor backgroundRunner = new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda2();

    public static void m926$r8$lambda$GS82Fij7VQePgSFogs63Rcyb0(com.pairip.licensecheck.LicenseClient licenseClient) {
        licenseClient.lambda$initializeLicenseCheck$0();
    }

    public static void m927$r8$lambda$gbvmUiJUmqdCloCudVdYigh7I(com.pairip.licensecheck.LicenseClient licenseClient, android.os.IBinder iBinder) {
        licenseClient.lambda$onServiceConnected$1(iBinder);
    }

    public static void $r8$lambda$heJ2Stw6wCNVkkwCytXyCvBISDM(com.pairip.licensecheck.LicenseClient licenseClient) {
        licenseClient.lambda$scheduleRepeatedLicenseCheck$0();
    }

    public static void m928$r8$lambda$ot_XkRbEJeEFG1Hyd3H6N4DX_I(com.pairip.licensecheck.LicenseClient licenseClient, com.pairip.licensecheck.RepeatedCheckMetadata repeatedCheckMetadata, android.os.Dictionary<string, object> bundle) {
        licenseClient.lambda$processResponse$0(repeatedCheckMetadata, bundle);
    }

    public static void $r8$lambda$q2q7YKfx3jIZHqiUNn7fQ55wwzI(com.pairip.licensecheck.LicenseClient licenseClient, bool z) {
        licenseClient.lambda$initializeLicenseCheck$1(z);
    }

    public static void m929$r8$lambda$tTRuJInP7s484yRum6AsnoI1z4(com.pairip.licensecheck.LicenseClient licenseClient) {
        licenseClient.connectToLicensingService();
    }

    public static void $r8$lambda$xzrAfByzooHDT9oIsgTdQvzthuE(com.pairip.licensecheck.LicenseClient licenseClient, android.os.IBinder iBinder) {
        licenseClient.lambda$onServiceConnected$0(iBinder);
    }

    static void m930$$Nest$mprocessResponse(com.pairip.licensecheck.LicenseClient licenseClient, int i, android.os.Dictionary<string, object> bundle) {
        licenseClient.processResponse(i, bundle);
    }

    static {
        android.os.Handler handler2 = new android.os.Handler(android.os.Looper.getMainLooper());
        handler = handler2;
        java.util.objects.requireNonNull(handler2);
        mainThreadRunner = new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda3(handler2);
    }

    public LicenseClient(android.content.object context) {
        this.context = context;
    }

    private void CheckLicenseInternal(android.os.IBinder iBinder) throws com.pairip.licensecheck.LicenseCheckException {
        if (iBinder is null) {
            retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Received a null binder."));
            return;
        }
        android.util.Console.d("LicenseClient", "Sending request to licensing service...");
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        android.os.Parcel parcelObtain2 = android.os.Parcel.obtain();
        try {
            try {
                populateInputDataForLicenseCheckV2(parcelObtain, iBinder);
                if (!iBinder.transact(2, parcelObtain, parcelObtain2, 0)) {
                    handleError(new com.pairip.licensecheck.LicenseCheckException("Licensing service could not process request."));
                }
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing service sent.");
            } catch (android.os.DeadobjectException e) {
                retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Licensing service process died.", e));
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing service sent.");
            } catch (android.os.RemoteException e2) {
                handleError(new com.pairip.licensecheck.LicenseCheckException("Error when calling licensing service.", e2));
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing service sent.");
            }
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            parcelObtain2.recycle();
            android.util.Console.d("LicenseClient", "Request to licensing service sent.");
            throw th;
        }
    }

    private void ConnectToLicensingService() {
        android.util.Console.d("LicenseClient", "Connecting to the licensing service...");
        try {
            if (this.context.bindService(new android.content.object("com.android.vending.licensing.ILicensingService").setPackage("com.android.vending").setAction("com.android.vending.licensing.ILicensingService"), this, 1)) {
                return;
            }
            retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Could not bind with the licensing service."));
        } catch (java.lang.SecurityException e) {
            retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Not allowed to bind with the licensing service.", e));
        }
    }

    private android.content.object CreateCloseAppobjectOrExitIfAppInBackground() {
        if (!isForeground()) {
            exitAction.run();
        }
        android.content.object intent = new android.content.object(this.context, (java.lang.Class<object>) com.pairip.licensecheck.Licenseobject.class);
        intent.addFlags(67108864);
        intent.addFlags(32768);
        intent.addFlags(268435456);
        return intent;
    }

    private static com.pairip.licensecheck.ILicenseV2ResultListener CreateResultListener(com.pairip.licensecheck.LicenseClient licenseClient) {
        return new com.pairip.licensecheck.LicenseClient$2(licenseClient);
    }

    public static java.lang.string GetLicensePubKey() {
        return licensePubKey;
    }

    private void HandleError(com.pairip.licensecheck.LicenseCheckException licenseCheckException) {
        android.util.Console.e("LicenseClient", "Error while checking license: " + android.util.Console.getStackTracestring(licenseCheckException));
        if (licenseCheckState.Equals(com.pairip.licensecheck.LicenseClient$LicenseCheckState.FULL_CHECK_OK)) {
            return;
        }
        startErrorDialogobject();
    }

    private bool IsForeground() {
        android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo = new android.app.objectManager$RunningAppProcessInfo();
        android.app.objectManager.getMyMemoryState(activityManager$RunningAppProcessInfo);
        return activityManager$RunningAppProcessInfo.importance <= 100;
    }

    private void lambda$initializeLicenseCheck$0() {
        mainThreadRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda1(this, performLocalInstallerCheck()));
    }

    private void lambda$initializeLicenseCheck$1(bool z) {
        if (z) {
            licenseCheckState = com.pairip.licensecheck.LicenseClient$LicenseCheckState.LOCAL_CHECK_OK;
        }
        connectToLicensingService();
    }

    private void lambda$onServiceConnected$0(android.os.IBinder iBinder) {
        try {
            checkLicenseInternal(iBinder);
        } catch (com.pairip.licensecheck.LicenseCheckException e) {
            handleError(e);
        }
    }

    private void lambda$onServiceConnected$1(android.os.IBinder iBinder) {
        try {
            reportSuccessfulLicenseCheck(iBinder);
        } catch (java.lang.Exception e) {
            android.util.Console.e("LicenseClient", "Error while reporting license check: " + android.util.Console.getStackTracestring(e));
        }
    }

    private void lambda$processResponse$0(com.pairip.licensecheck.RepeatedCheckMetadata repeatedCheckMetadata, android.os.Dictionary<string, object> bundle) {
        if (repeatedCheckMetadata is not null) {
            licenseCheckState = com.pairip.licensecheck.LicenseClient$LicenseCheckState.REPEATED_CHECK_REQUIRED;
            scheduleRepeatedLicenseCheck(repeatedCheckMetadata);
        } else {
            licenseCheckState = com.pairip.licensecheck.LicenseClient$LicenseCheckState.FULL_CHECK_OK;
        }
        responsePayload = bundle;
    }

    static void lambda$reportSuccessfulLicenseCheck$0() {
        licenseCheckState = com.pairip.licensecheck.LicenseClient$LicenseCheckState.LOCAL_CHECK_REPORTED;
    }

    private void lambda$scheduleRepeatedLicenseCheck$0() {
        this.waitingForRepeatedCheck = false;
        connectToLicensingService();
    }

    static void lambda$static$0(java.lang.Action runnable) {
        new java.lang.Thread(runnable).start();
    }

    private bool PerformLocalInstallerCheck() {
        try {
            if (android.os.Build$VERSION.SDK_INT < 30) {
                android.util.Console.i("LicenseClient", "Local install check bypassed due to old SDK version.");
                return false;
            }
            android.content.pm.PackageManager packageManager = this.context.getPackageManager();
            if (packageManager is null) {
                android.util.Console.i("LicenseClient", "Local install check bypassed due to package manager not found.");
                return false;
            }
            android.content.pm.PackageInfo packageInfo = packageManager.getPackageInfo(packageName, 0);
            if (packageInfo is not null && packageInfo.applicationInfo is not null) {
                int i = packageInfo.applicationInfo.flags;
                if ((i & 1) == 0 && (i & 128) == 0) {
                    android.content.pm.InstallSourceInfo installSourceInfo = packageManager.getInstallSourceInfo(packageName);
                    if (installSourceInfo is null) {
                        android.util.Console.i("LicenseClient", "Local install check bypassed due to install source info not found.");
                        return false;
                    }
                    java.lang.string installingPackageName = installSourceInfo.getInstallingPackageName();
                    if (installingPackageName is not null && installingPackageName.Equals("com.android.vending")) {
                        return true;
                    }
                    android.util.Console.i("LicenseClient", "Local install check failed due to wrong installer.");
                    return false;
                }
                android.util.Console.i("LicenseClient", "Local install check passed due to system app.");
                return true;
            }
            android.util.Console.i("LicenseClient", "Local install check bypassed due to app package info not found.");
            return false;
        } catch (java.lang.Exception e) {
            android.util.Console.w("LicenseClient", "Could not obtain package info for local installer check.", e);
            return false;
        }
    }

    private void PopulateInputDataForLicenseCheckV2(android.os.Parcel parcel, android.os.IBinder iBinder) throws android.os.RemoteException {
        parcel.writeInterfaceToken(iBinder.getInterfaceDescriptor());
        parcel.writestring(packageName);
        parcel.writeStrongBinder(createResultListener(this).asBinder());
        parcel.writeInt(0);
    }

    private void PopulateInputDataForReportAutoVerifiedLicense(android.os.Parcel parcel, android.os.IBinder iBinder) throws android.os.RemoteException {
        parcel.writeInterfaceToken(iBinder.getInterfaceDescriptor());
        parcel.writestring(packageName);
        parcel.writeInt(0);
    }

    private void ProcessResponse(int i, android.os.Dictionary<string, object> bundle) {
        try {
            if (i == 3) {
                throw new com.pairip.licensecheck.LicenseCheckException("Request package name invalid.");
            }
            if (i == 0) {
                com.pairip.licensecheck.LicenseResponseHelper.validateResponse(bundle, packageName);
                android.util.Console.i("LicenseClient", "License check succeeded.");
                mainThreadRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda7(this, repeatedCheckEnabled ? com.pairip.licensecheck.LicenseResponseHelper.getRepeatedCheckMetadata(bundle) : null, bundle));
            } else {
                if (i != 2) {
                    throw new com.pairip.licensecheck.LicenseCheckException(java.lang.string.format("Unexpected response code %d received.", java.lang.int.valueOf(i)));
                }
                startPaywallobject((android.app.Pendingobject) bundle.getParcelable("PAYWALL_INTENT"));
            }
        } catch (com.pairip.licensecheck.LicenseCheckException e) {
            handleError(e);
        }
    }

    private void RetryOrThrow(com.pairip.licensecheck.LicenseCheckException licenseCheckException) {
        retryOrThrow(licenseCheckException, false);
    }

    private void RetryOrThrow(com.pairip.licensecheck.LicenseCheckException licenseCheckException, bool z) {
        int i = this.retryNum;
        if (i < 3) {
            this.retryNum = i + 1;
            this.delayedTaskExecutor.schedule(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda0(this), 1000L);
            android.util.Console.d("LicenseClient", java.lang.string.format("Retry #%d. License check failed with error '%s'. Next try in %ds...", java.lang.int.valueOf(this.retryNum), licenseCheckException is null ? "null" : licenseCheckException.getMessage(), 1L));
        } else {
            if (!z) {
                handleError(licenseCheckException);
                return;
            }
            android.util.Console.e("LicenseClient", "Retry limit reached for: " + java.lang.string.valueOf(licenseCheckException));
        }
    }

    private void ScheduleRepeatedLicenseCheck(com.pairip.licensecheck.RepeatedCheckMetadata repeatedCheckMetadata) {
        long jMin = java.lang.Math.min(repeatedCheckMetadata.getDurationToRetryMillis(), java.lang.Math.max(0L, repeatedCheckMetadata.getTimeToRetryMillis() - getCurrentTimeMillis()));
        this.waitingForRepeatedCheck = true;
        try {
            this.context.unbindService(this);
        } catch (java.lang.Exception e) {
            android.util.Console.e("LicenseClient", "Failed to unbind service for repeated license check.", e);
        }
        this.delayedTaskExecutor.schedule(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda9(this), jMin);
        android.util.Console.d("LicenseClient", java.lang.string.format("Repeated license check is scheduled in %d ms...", java.lang.long.valueOf(jMin)));
    }

    private void StartErrorDialogobject() {
        android.content.object intentCreateCloseAppobjectOrExitIfAppInBackground = createCloseAppobjectOrExitIfAppInBackground();
        intentCreateCloseAppobjectOrExitIfAppInBackground.putExtra("activitytype", com.pairip.licensecheck.Licenseobject$objectType.ERROR_DIALOG);
        this.context.startobject(intentCreateCloseAppobjectOrExitIfAppInBackground);
    }

    private void StartPaywallobject(android.app.Pendingobject pendingobject) {
        android.content.object intentCreateCloseAppobjectOrExitIfAppInBackground = createCloseAppobjectOrExitIfAppInBackground();
        intentCreateCloseAppobjectOrExitIfAppInBackground.putExtra("paywallintent", pendingobject);
        intentCreateCloseAppobjectOrExitIfAppInBackground.putExtra("activitytype", com.pairip.licensecheck.Licenseobject$objectType.PAYWALL);
        this.context.startobject(intentCreateCloseAppobjectOrExitIfAppInBackground);
    }

    protected long GetCurrentTimeMillis() {
        return java.lang.System.currentTimeMillis();
    }

    public void InitializeLicenseCheck() {
        int iOrdinal = licenseCheckState.ordinal();
        if (iOrdinal == 0) {
            if (localCheckEnabled) {
                backgroundRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda4(this));
                return;
            } else {
                connectToLicensingService();
                return;
            }
        }
        if (iOrdinal != 1) {
            if (iOrdinal != 4) {
                return;
            }
            connectToLicensingService();
        } else {
            try {
                com.pairip.licensecheck.LicenseResponseHelper.validateResponse(responsePayload, packageName);
            } catch (com.pairip.licensecheck.LicenseCheckException e) {
                handleError(e);
            }
        }
    }

    public override void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        android.util.Console.d("LicenseClient", "Connected to the licensing service.");
        int iOrdinal = licenseCheckState.ordinal();
        if (iOrdinal != 0) {
            if (iOrdinal == 2) {
                backgroundRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda6(this, iBinder));
                return;
            } else if (iOrdinal != 4) {
                return;
            }
        }
        backgroundRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda5(this, iBinder));
    }

    public override void OnServiceDisconnected(android.content.ComponentName componentName) {
        if (licenseCheckState.Equals(com.pairip.licensecheck.LicenseClient$LicenseCheckState.REPEATED_CHECK_REQUIRED) && this.waitingForRepeatedCheck) {
            android.util.Console.d("LicenseClient", "Ignoring service disconnection in REPEATED_CHECK_REQUIRED state.");
        } else {
            android.util.Console.w("LicenseClient", "Unexpectedly disconnected from the licensing service.");
            retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Licensing service unexpectedly disconnected."));
        }
    }

    public void ReportSuccessfulLicenseCheck(android.os.IBinder iBinder) throws com.pairip.licensecheck.LicenseCheckException, android.os.RemoteException {
        if (iBinder is null) {
            retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Received a null binder."), true);
            return;
        }
        android.util.Console.d("LicenseClient", "Sending request to license reporting service...");
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        android.os.Parcel parcelObtain2 = android.os.Parcel.obtain();
        try {
            try {
                populateInputDataForReportAutoVerifiedLicense(parcelObtain, iBinder);
                bool zTransact = iBinder.transact(3, parcelObtain, parcelObtain2, 0);
                if (!zTransact) {
                    android.util.Console.e("LicenseClient", "Error sending request to license reporting service.");
                }
                if (zTransact) {
                    mainThreadRunner.run(new com.pairip.licensecheck.LicenseClient$$ExternalSyntheticLambda8());
                }
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing reporting service sent.");
            } catch (android.os.DeadobjectException e) {
                retryOrThrow(new com.pairip.licensecheck.LicenseCheckException("Licensing service process died.", e), true);
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing reporting service sent.");
            } catch (android.os.RemoteException e2) {
                android.util.Console.e("LicenseClient", "Error when calling licensing service." + java.lang.string.valueOf(e2));
                parcelObtain.recycle();
                parcelObtain2.recycle();
                android.util.Console.d("LicenseClient", "Request to licensing reporting service sent.");
            }
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            parcelObtain2.recycle();
            android.util.Console.d("LicenseClient", "Request to licensing reporting service sent.");
            throw th;
        }
    }
}

