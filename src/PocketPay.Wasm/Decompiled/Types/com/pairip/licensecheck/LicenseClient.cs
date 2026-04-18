namespace WillowMaze.Wasm.Decompiled;

public class LicenseClient : ServiceConnection
{
    private static int ERROR_INVALID_PACKAGE_NAME;
    private static int FLAG_RPC_CALL;
    private static int LICENSED;
    private static int MAX_RETRIES;
    private static int MILLIS_PER_SEC;
    private static int NOT_LICENSED;
    private static string PAYLOAD_PAYWALL;
    private static int RETRY_DELAY_MILLIS;
    private static string SERVICE_INTERFACE_CLASS_NAME;
    private static string SERVICE_PACKAGE;
    private static string TAG;
    private static int TRANSACTION_CHECK_LICENSE_V2;
    private static int TRANSACTION_REPORT_SUCCESSFUL_LICENSE_CHECK;
    private static LicenseClient$ImmediateTaskExecutor BackgroundRunner;
    private static Action ExitAction;
    private static object Handler;
    private static LicenseClient$LicenseCheckState LicenseCheckState;
    private static string LicensePubKey;
    private static bool LocalCheckEnabled;
    private static LicenseClient$ImmediateTaskExecutor MainThreadRunner;
    private static string PackageName;
    private static bool RepeatedCheckEnabled;
    private static Dictionary<string, object> ResponsePayload;
    private readonly object Context;
    private LicenseClient$DelayedTaskExecutor DelayedTaskExecutor;
    private int RetryNum;
    private bool WaitingForRepeatedCheck;

    public static void $r8$lambda$GS82Fij7VQePgSFog-s63-Rcyb0(LicenseClient P0)
    {
        // call: LicenseClient.lambda$initializeLicenseCheck$0
    }

    public static void $r8$lambda$gb-vmUiJUmqdCloCudVdY-igh7I(LicenseClient P0, IBinder P1)
    {
        // call: LicenseClient.lambda$onServiceConnected$1
    }

    public static void $r8$lambda$heJ2Stw6wCNVkkwCytXyCvBISDM(LicenseClient P0)
    {
        // call: LicenseClient.lambda$scheduleRepeatedLicenseCheck$0
    }

    public static void $r8$lambda$ot_XkRbEJeEFG1Hy-d3H6N4DX_I(LicenseClient P0, RepeatedCheckMetadata P1, Dictionary<string, object> P2)
    {
        // call: LicenseClient.lambda$processResponse$0
    }

    public static void $r8$lambda$q2q7YKfx3jIZHqiUNn7fQ55wwzI(LicenseClient P0, bool P1)
    {
        // call: LicenseClient.lambda$initializeLicenseCheck$1
    }

    public static void $r8$lambda$tTRuJInP7s484yRu-m6AsnoI1z4(LicenseClient P0)
    {
        // call: LicenseClient.connectToLicensingService
    }

    public static void $r8$lambda$xzrAfByzooHDT9oIsgTdQvzthuE(LicenseClient P0, IBinder P1)
    {
        // call: LicenseClient.lambda$onServiceConnected$0
    }

    private static void -$$Nest$mprocessResponse(LicenseClient P0, int P1, Dictionary<string, object> P2)
    {
        // call: LicenseClient.processResponse
    }

    private void CheckLicenseInternal(IBinder P0)
    {
        // str: "Request to licensing service sent."
        // str: "Received a null binder."
        // str: "Sending request to licensing service..."
        // str: "LicenseClient"
        // str: "Licensing service could not process request."
        // str: "Error when calling licensing service."
        // str: "Licensing service process died."
        // call: LicenseCheckException.<init>
        // call: LicenseClient.retryOrThrow
        // call: Console.d
        // call: Parcel.obtain
        // call: LicenseClient.populateInputDataForLicenseCheckV2
        // call: IBinder.transact
        // call: LicenseClient.handleError
        // call: Parcel.recycle
        // type: LicenseCheckException
    }

    private void ConnectToLicensingService()
    {
        // str: "LicenseClient"
        // str: "Connecting to the licensing service..."
        // str: "com.android.vending.licensing.ILicensingService"
        // str: "com.android.vending"
        // str: "Could not bind with the licensing service."
        // str: "Not allowed to bind with the licensing service."
        // call: Console.d
        // call: object.<init>
        // call: object.setPackage
        // call: object.setAction
        // call: object.bindService
        // call: LicenseCheckException.<init>
        // call: LicenseClient.retryOrThrow
        // field: com.pairip.licensecheck.LicenseClient.context
        // type: object
        // type: LicenseCheckException
    }

    private object CreateCloseAppIntentOrExitIfAppInBackground()
    {
        // call: LicenseClient.isForeground
        // call: Action.run
        // call: object.<init>
        // call: object.addFlags
        // field: com.pairip.licensecheck.LicenseClient.exitAction
        // field: com.pairip.licensecheck.LicenseClient.context
        // type: object
        // type: LicenseActivity
        return default!;
    }

    private static ILicenseV2ResultListener CreateResultListener(LicenseClient P0)
    {
        // call: LicenseClient$2.<init>
        // type: LicenseClient$2
        return default!;
    }

    public static string GetLicensePubKey()
    {
        // field: com.pairip.licensecheck.LicenseClient.licensePubKey
        return string.Empty;
    }

    private void HandleError(LicenseCheckException P0)
    {
        // str: "Error while checking license: "
        // str: "LicenseClient"
        // call: Console.getStackTraceString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Console.e
        // call: LicenseClient$LicenseCheckState.equals
        // call: LicenseClient.startErrorDialogActivity
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.FULL_CHECK_OK
        // type: StringBuilder
    }

    private bool IsForeground()
    {
        // call: ActivityManager$RunningAppProcessInfo.<init>
        // call: ActivityManager.getMyMemoryState
        // field: android.app.ActivityManager$RunningAppProcessInfo.importance
        // type: ActivityManager$RunningAppProcessInfo
        return false;
    }

    private void Lambda$initializeLicenseCheck$0()
    {
        // call: LicenseClient.performLocalInstallerCheck
        // call: LicenseClient$$ExternalSyntheticLambda1.<init>
        // call: LicenseClient$ImmediateTaskExecutor.run
        // field: com.pairip.licensecheck.LicenseClient.mainThreadRunner
        // type: LicenseClient$$ExternalSyntheticLambda1
    }

    private void Lambda$initializeLicenseCheck$1(bool P0)
    {
        // call: LicenseClient.connectToLicensingService
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.LOCAL_CHECK_OK
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
    }

    private void Lambda$onServiceConnected$0(IBinder P0)
    {
        // call: LicenseClient.checkLicenseInternal
        // call: LicenseClient.handleError
    }

    private void Lambda$onServiceConnected$1(IBinder P0)
    {
        // str: "Error while reporting license check: "
        // str: "LicenseClient"
        // call: LicenseClient.reportSuccessfulLicenseCheck
        // call: Console.getStackTraceString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Console.e
        // type: StringBuilder
    }

    private void Lambda$processResponse$0(RepeatedCheckMetadata P0, Dictionary<string, object> P1)
    {
        // call: LicenseClient.scheduleRepeatedLicenseCheck
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.REPEATED_CHECK_REQUIRED
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.FULL_CHECK_OK
        // field: com.pairip.licensecheck.LicenseClient.responsePayload
    }

    private static void Lambda$reportSuccessfulLicenseCheck$0()
    {
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.LOCAL_CHECK_REPORTED
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
    }

    private void Lambda$scheduleRepeatedLicenseCheck$0()
    {
        // call: LicenseClient.connectToLicensingService
        // field: com.pairip.licensecheck.LicenseClient.waitingForRepeatedCheck
    }

    private static void Lambda$static$0(Action P0)
    {
        // call: Thread.<init>
        // call: Thread.start
        // type: Thread
    }

    private bool PerformLocalInstallerCheck()
    {
        // str: "LicenseClient"
        // str: "Local install check bypassed due to old SDK version."
        // str: "Local install check bypassed due to package manager not found."
        // str: "Local install check bypassed due to install source info not found."
        // str: "com.android.vending"
        // str: "Local install check failed due to wrong installer."
        // str: "Local install check passed due to system app."
        // str: "Local install check bypassed due to app package info not found."
        // str: "Could not obtain package info for local installer check."
        // call: Console.i
        // call: object.getPackageManager
        // call: PackageManager.getPackageInfo
        // call: PackageManager.getInstallSourceInfo
        // call: InstallSourceInfo.getInstallingPackageName
        // call: string.equals
        // call: Console.w
        // field: android.os.Build$VERSION.SDK_INT
        // field: com.pairip.licensecheck.LicenseClient.context
        // field: com.pairip.licensecheck.LicenseClient.packageName
        // field: android.content.pm.PackageInfo.applicationInfo
        // field: android.content.pm.ApplicationInfo.flags
        return false;
    }

    private void PopulateInputDataForLicenseCheckV2(Parcel P0, IBinder P1)
    {
        // call: IBinder.getInterfaceDescriptor
        // call: Parcel.writeInterfaceToken
        // call: Parcel.writeString
        // call: LicenseClient.createResultListener
        // call: ILicenseV2ResultListener.asBinder
        // call: Parcel.writeStrongBinder
        // call: Parcel.writeInt
        // field: com.pairip.licensecheck.LicenseClient.packageName
    }

    private void PopulateInputDataForReportAutoVerifiedLicense(Parcel P0, IBinder P1)
    {
        // call: IBinder.getInterfaceDescriptor
        // call: Parcel.writeInterfaceToken
        // call: Parcel.writeString
        // call: Parcel.writeInt
        // field: com.pairip.licensecheck.LicenseClient.packageName
    }

    private void ProcessResponse(int P0, Dictionary<string, object> P1)
    {
        // str: "LicenseClient"
        // str: "License check succeeded."
        // str: "PAYWALL_INTENT"
        // str: "Unexpected response code %d received."
        // str: "Request package name invalid."
        // call: LicenseResponseHelper.validateResponse
        // call: Console.i
        // call: LicenseResponseHelper.getRepeatedCheckMetadata
        // call: LicenseClient$$ExternalSyntheticLambda7.<init>
        // call: LicenseClient$ImmediateTaskExecutor.run
        // call: Dictionary<string, object>.getParcelable
        // call: LicenseClient.startPaywallActivity
        // call: int.valueOf
        // call: string.format
        // call: LicenseCheckException.<init>
        // call: LicenseClient.handleError
        // field: com.pairip.licensecheck.LicenseClient.packageName
        // field: com.pairip.licensecheck.LicenseClient.repeatedCheckEnabled
        // field: com.pairip.licensecheck.LicenseClient.mainThreadRunner
        // type: LicenseClient$$ExternalSyntheticLambda7
        // type: LicenseCheckException
    }

    private void RetryOrThrow(LicenseCheckException P0)
    {
        // call: LicenseClient.retryOrThrow
    }

    private void RetryOrThrow(LicenseCheckException P0, bool P1)
    {
        // str: "LicenseClient"
        // str: "null"
        // str: "Retry #%d. License check failed with error '%s'. Next try in %ds..."
        // str: "Retry limit reached for: "
        // call: LicenseClient$$ExternalSyntheticLambda0.<init>
        // call: LicenseClient$DelayedTaskExecutor.schedule
        // call: int.valueOf
        // call: LicenseCheckException.getMessage
        // call: long.valueOf
        // call: string.format
        // call: Console.d
        // call: string.valueOf
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Console.e
        // call: LicenseClient.handleError
        // field: com.pairip.licensecheck.LicenseClient.retryNum
        // field: com.pairip.licensecheck.LicenseClient.delayedTaskExecutor
        // type: LicenseClient$$ExternalSyntheticLambda0
        // type: StringBuilder
    }

    private void ScheduleRepeatedLicenseCheck(RepeatedCheckMetadata P0)
    {
        // str: "LicenseClient"
        // str: "Failed to unbind service for repeated license check."
        // str: "Repeated license check is scheduled in %d ms..."
        // call: LicenseClient.getCurrentTimeMillis
        // call: RepeatedCheckMetadata.getDurationToRetryMillis
        // call: RepeatedCheckMetadata.getTimeToRetryMillis
        // call: Math.max
        // call: Math.min
        // call: object.unbindService
        // call: Console.e
        // call: LicenseClient$$ExternalSyntheticLambda9.<init>
        // call: LicenseClient$DelayedTaskExecutor.schedule
        // call: long.valueOf
        // call: string.format
        // call: Console.d
        // field: com.pairip.licensecheck.LicenseClient.waitingForRepeatedCheck
        // field: com.pairip.licensecheck.LicenseClient.context
        // field: com.pairip.licensecheck.LicenseClient.delayedTaskExecutor
        // type: LicenseClient$$ExternalSyntheticLambda9
    }

    private void StartErrorDialogActivity()
    {
        // str: "activitytype"
        // call: LicenseClient.createCloseAppIntentOrExitIfAppInBackground
        // call: object.putExtra
        // call: object.startActivity
        // field: com.pairip.licensecheck.LicenseActivity$ActivityType.ERROR_DIALOG
        // field: com.pairip.licensecheck.LicenseClient.context
    }

    private void StartPaywallActivity(PendingIntent P0)
    {
        // str: "paywallintent"
        // str: "activitytype"
        // call: LicenseClient.createCloseAppIntentOrExitIfAppInBackground
        // call: object.putExtra
        // call: object.startActivity
        // field: com.pairip.licensecheck.LicenseActivity$ActivityType.PAYWALL
        // field: com.pairip.licensecheck.LicenseClient.context
    }

    private long GetCurrentTimeMillis()
    {
        // call: System.currentTimeMillis
        return 0;
    }

    public void InitializeLicenseCheck()
    {
        // call: LicenseClient$LicenseCheckState.ordinal
        // call: LicenseClient.connectToLicensingService
        // call: LicenseResponseHelper.validateResponse
        // call: LicenseClient.handleError
        // call: LicenseClient$$ExternalSyntheticLambda4.<init>
        // call: LicenseClient$ImmediateTaskExecutor.run
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
        // field: com.pairip.licensecheck.LicenseClient.responsePayload
        // field: com.pairip.licensecheck.LicenseClient.packageName
        // field: com.pairip.licensecheck.LicenseClient.localCheckEnabled
        // field: com.pairip.licensecheck.LicenseClient.backgroundRunner
        // type: LicenseClient$$ExternalSyntheticLambda4
    }

    public void OnServiceConnected(ComponentName P0, IBinder P1)
    {
        // str: "LicenseClient"
        // str: "Connected to the licensing service."
        // call: Console.d
        // call: LicenseClient$LicenseCheckState.ordinal
        // call: LicenseClient$$ExternalSyntheticLambda6.<init>
        // call: LicenseClient$ImmediateTaskExecutor.run
        // call: LicenseClient$$ExternalSyntheticLambda5.<init>
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
        // field: com.pairip.licensecheck.LicenseClient.backgroundRunner
        // type: LicenseClient$$ExternalSyntheticLambda6
        // type: LicenseClient$$ExternalSyntheticLambda5
    }

    public void OnServiceDisconnected(ComponentName P0)
    {
        // str: "LicenseClient"
        // str: "Ignoring service disconnection in REPEATED_CHECK_REQUIRED state."
        // str: "Unexpectedly disconnected from the licensing service."
        // str: "Licensing service unexpectedly disconnected."
        // call: LicenseClient$LicenseCheckState.equals
        // call: Console.d
        // call: Console.w
        // call: LicenseCheckException.<init>
        // call: LicenseClient.retryOrThrow
        // field: com.pairip.licensecheck.LicenseClient.licenseCheckState
        // field: com.pairip.licensecheck.LicenseClient$LicenseCheckState.REPEATED_CHECK_REQUIRED
        // field: com.pairip.licensecheck.LicenseClient.waitingForRepeatedCheck
        // type: LicenseCheckException
    }

    public void ReportSuccessfulLicenseCheck(IBinder P0)
    {
        // str: "Request to licensing reporting service sent."
        // str: "Error when calling licensing service."
        // str: "Received a null binder."
        // str: "Sending request to license reporting service..."
        // str: "LicenseClient"
        // str: "Error sending request to license reporting service."
        // str: "Licensing service process died."
        // call: LicenseCheckException.<init>
        // call: LicenseClient.retryOrThrow
        // call: Console.d
        // call: Parcel.obtain
        // call: LicenseClient.populateInputDataForReportAutoVerifiedLicense
        // call: IBinder.transact
        // call: Console.e
        // call: LicenseClient$$ExternalSyntheticLambda8.<init>
        // call: LicenseClient$ImmediateTaskExecutor.run
        // call: Parcel.recycle
        // call: string.valueOf
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: com.pairip.licensecheck.LicenseClient.mainThreadRunner
        // type: LicenseCheckException
        // type: LicenseClient$$ExternalSyntheticLambda8
        // type: StringBuilder
    }

}
