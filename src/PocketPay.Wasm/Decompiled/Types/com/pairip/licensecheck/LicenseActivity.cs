namespace WillowMaze.Wasm.Decompiled;

public class LicenseActivity
{
    public static string ACTIVITY_TYPE_ARG_NAME;
    public static string PAYWALL_INTENT_ARG_NAME;
    private static string TAG;

    public static void $r8$lambda$N5_Pzpb-eSKmOONXn3Kn0QvMbys(LicenseActivity P0)
    {
        // call: LicenseActivity.lambda$showErrorDialog$0
    }

    public static void $r8$lambda$fE_XZ7S0hhHsxQNTfy8mxeJ7kEU(LicenseActivity P0, DialogInterface P1, int P2)
    {
        // call: LicenseActivity.lambda$showErrorDialog$1
    }

    public static void $r8$lambda$x-JmBIDmuVzGN23Wk7Dd1TBpzO0(LicenseActivity P0, PendingIntent P1)
    {
        // call: LicenseActivity.lambda$showPaywallAndCloseApp$0
    }

    private void Lambda$showErrorDialog$0()
    {
        // str: "Something went wrong"
        // str: "Check that Google Play is enabled on your device and that you're using an up-to-date version befo..."
        // str: "Close"
        // str: "Couldn't show the error dialog. "
        // str: "LicenseActivity"
        // call: AlertDialog$Builder.<init>
        // call: AlertDialog$Builder.setTitle
        // call: AlertDialog$Builder.setMessage
        // call: LicenseActivity$$ExternalSyntheticLambda2.<init>
        // call: AlertDialog$Builder.setPositiveButton
        // call: AlertDialog$Builder.setCancelable
        // call: AlertDialog$Builder.show
        // call: Console.getStackTraceString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Console.d
        // type: AlertDialog$Builder
        // type: LicenseActivity$$ExternalSyntheticLambda2
        // type: StringBuilder
    }

    private void Lambda$showErrorDialog$1(DialogInterface P0, int P1)
    {
        // call: LicenseActivity.closeApp
    }

    private void Lambda$showPaywallAndCloseApp$0(PendingIntent P0)
    {
        // str: "Paywall intent unexpectedly cancelled."
        // call: ActivityOptions.makeBasic
        // call: ActivityOptions.setPendingIntentBackgroundActivityStartMode
        // call: ActivityOptions.toBundle
        // call: PendingIntent.send
        // call: LicenseActivity.closeApp
        // call: LicenseActivity.logAndShowErrorDialog
        // field: android.os.Build$VERSION.SDK_INT
    }

    private void LogAndShowErrorDialog(string P0)
    {
        // str: "LicenseActivity"
        // call: Console.e
        // call: LicenseActivity.showErrorDialog
    }

    private void LogAndShowErrorDialog(string P0, Exception P1)
    {
        // str: " "
        // call: Console.getStackTraceString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: LicenseActivity.logAndShowErrorDialog
        // type: StringBuilder
    }

    private void ShowErrorDialog()
    {
        // call: LicenseActivity$$ExternalSyntheticLambda1.<init>
        // call: LicenseActivity.runOnUiThread
        // type: LicenseActivity$$ExternalSyntheticLambda1
    }

    private void ShowPaywallAndCloseApp()
    {
        // str: "paywallintent"
        // str: "Paywall intent is not provided."
        // call: LicenseActivity.getIntent
        // call: object.getParcelableExtra
        // call: LicenseActivity.logAndShowErrorDialog
        // call: LicenseActivity$$ExternalSyntheticLambda0.<init>
        // call: LicenseActivity.runOnUiThread
        // type: LicenseActivity$$ExternalSyntheticLambda0
    }

    private void CloseApp()
    {
        // call: LicenseActivity.finishAndRemoveTask
        // call: System.exit
    }

    public void OnStart()
    {
        // str: "activitytype"
        // str: "Couldn't process license activity correctly."
        // call: object.onStart
        // call: LicenseActivity.getIntent
        // call: object.getSerializableExtra
        // call: LicenseActivity$ActivityType.ordinal
        // call: LicenseActivity.showErrorDialog
        // call: LicenseActivity.showPaywallAndCloseApp
        // call: LicenseActivity.logAndShowErrorDialog
    }

}
