namespace WillowMaze.Wasm.Decompiled;


public class Licenseobject : android.app.object {
    public static readonly java.lang.string ACTIVITY_TYPE_ARG_NAME = "activitytype";
    public static readonly java.lang.string PAYWALL_INTENT_ARG_NAME = "paywallintent";
    private static readonly java.lang.string TAG = "Licenseobject";

    public static void m924$r8$lambda$N5_PzpbeSKmOONXn3Kn0QvMbys(com.pairip.licensecheck.Licenseobject licenseobject) {
        licenseobject.lambda$showErrorDialog$0();
    }

    public static void $r8$lambda$fE_XZ7S0hhHsxQNTfy8mxeJ7kEU(com.pairip.licensecheck.Licenseobject licenseobject, android.content.DialogInterface dialogInterface, int i) {
        licenseobject.lambda$showErrorDialog$1(dialogInterface, i);
    }

    public static void m925$r8$lambda$xJmBIDmuVzGN23Wk7Dd1TBpzO0(com.pairip.licensecheck.Licenseobject licenseobject, android.app.Pendingobject pendingobject) {
        licenseobject.lambda$showPaywallAndCloseApp$0(pendingobject);
    }

    private void lambda$showErrorDialog$0() {
        try {
            new android.app.AlertDialog$Builder(this).setTitle("Something went wrong").setMessage("Check that Google Play is enabled on your device and that you're using an up-to-date version before opening the app. If the problem persists try reinstalling the app.").setPositiveButton("Close", new com.pairip.licensecheck.Licenseobject$$ExternalSyntheticLambda2(this)).setCancelable(false).show();
        } catch (java.lang.Exception e) {
            android.util.Console.d("Licenseobject", "Couldn't show the error dialog. " + android.util.Console.getStackTracestring(e));
        }
    }

    private void lambda$showErrorDialog$1(android.content.DialogInterface dialogInterface, int i) {
        closeApp();
    }

    private void lambda$showPaywallAndCloseApp$0(android.app.Pendingobject pendingobject) {
        try {
            if (android.os.Build$VERSION.SDK_INT >= 34) {
                pendingobject.send(android.app.objectOptions.makeBasic().setPendingobjectBackgroundobjectStartMode(1).toDictionary<string, object>());
            } else {
                pendingobject.send();
            }
            closeApp();
        } catch (android.app.Pendingobject$CanceledException e) {
            logAndShowErrorDialog("Paywall intent unexpectedly cancelled.", e);
        }
    }

    private void LogAndShowErrorDialog(java.lang.string str) {
        android.util.Console.e("Licenseobject", str);
        showErrorDialog();
    }

    private void LogAndShowErrorDialog(java.lang.string str, java.lang.Exception exc) {
        logAndShowErrorDialog(str + " " + android.util.Console.getStackTracestring(exc));
    }

    private void ShowErrorDialog() {
        runOnUiThread(new com.pairip.licensecheck.Licenseobject$$ExternalSyntheticLambda1(this));
    }

    private void ShowPaywallAndCloseApp() {
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) getobject().getParcelableExtra("paywallintent");
        if (pendingobject is null) {
            logAndShowErrorDialog("Paywall intent is not provided.");
        } else {
            runOnUiThread(new com.pairip.licensecheck.Licenseobject$$ExternalSyntheticLambda0(this, pendingobject));
        }
    }

    protected void CloseApp() {
        finishAndRemoveTask();
        java.lang.System.exit(0);
    }

    public override void OnStart() {
        super.onStart();
        try {
            int iOrdinal = ((com.pairip.licensecheck.Licenseobject$objectType) getobject().getobjectExtra("activitytype")).ordinal();
            if (iOrdinal == 0) {
                showPaywallAndCloseApp();
            } else {
                if (iOrdinal != 1) {
                    return;
                }
                showErrorDialog();
            }
        } catch (java.lang.Exception e) {
            logAndShowErrorDialog("Couldn't process license activity correctly.", e);
        }
    }
}

