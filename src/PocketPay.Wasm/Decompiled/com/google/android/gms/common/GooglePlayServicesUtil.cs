namespace WillowMaze.Wasm.Decompiled;


public readonly class GooglePlayServicesUtil : com.google.android.gms.common.GooglePlayServicesUtilLight {
    public static readonly java.lang.string GMS_ERROR_DIALOG = "GooglePlayServicesErrorDialog";

    @java.lang.Deprecated
    public static readonly java.lang.string GOOGLE_PLAY_SERVICES_PACKAGE = "com.google.android.gms";

    @java.lang.Deprecated
    public static readonly int GOOGLE_PLAY_SERVICES_VERSION_CODE = com.google.android.gms.common.GooglePlayServicesUtilLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;
    public static readonly java.lang.string GOOGLE_PLAY_STORE_PACKAGE = "com.android.vending";

    private GooglePlayServicesUtil() {
    }

    public static bool AcMNZTrmSCNdefXs(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayServicesPossiblyUpdating(context, i);
    }

    public static bool EcynMRNtSNhjOXNl(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.showErrorDialogobject(activity, i, i2, dialogInterface$OnCancelListener);
    }

    public static bool GYjjuNIcpYTeIQXB() {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaF();
    }

    public static bool HmPKYuxKcxqUWLTP(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayStorePossiblyUpdating(context, i);
    }

    public static int IVBPqWvoHGRDvGCR(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isGooglePlayServicesAvailable(context, i);
    }

    public static android.content.object LFxwBVDBIrOmlTfw(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionobject(context, i, str);
    }

    public static bool MGAUmNJHwjTnfOJO(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayServicesPossiblyUpdating(context, i);
    }

    public static int NRpPWwdfiVmAjAeQ(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isGooglePlayServicesAvailable(context);
    }

    public static android.app.Dialog QeAFJORJLukXwNfv(int i, android.app.object activity, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return getErrorDialog(i, activity, i2, dialogInterface$OnCancelListener);
    }

    public static bool TRIMTojGoMsqrBMx(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayServicesPossiblyUpdating(context, i);
    }

    public static android.content.res.Resources TxNSUthOhlgQUqcW(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getRemoteResource(context);
    }

    public static com.google.android.gms.common.internal.zag WAhLHUDciOPHKQnU(androidx.fragment.app.object fragment, android.content.object intent, int i) {
        return com.google.android.gms.common.internal.zag.zac(fragment, intent, i);
    }

    public static bool YLJiumFlLjiznvzj(int i, android.app.object activity, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return showErrorDialogobject(i, activity, i2, dialogInterface$OnCancelListener);
    }

    public static void YhNweFZfyHBcHqkL(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i) {
        googleApiAvailability.showErrorNotification(context, i);
    }

    public static android.app.Dialog ALIPOQnsvJpHlmGj(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.getErrorDialog(activity, i, i2, dialogInterface$OnCancelListener);
    }

    public static void AjmZUtIBEvbjCEAn() {
        com.google.android.gms.common.internal.GmsClientSupervisor.setUseHandlerThreadForCallbacks();
    }

    public static com.google.android.gms.common.GoogleApiAvailability AyfobzMieuHsLupb() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static com.google.android.gms.common.GoogleApiAvailability BeXhiUGCnAuIfbkj() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static java.lang.string DottIVnnoBMuAiag(int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getErrorstring(i);
    }

    public static void ENsMLLMMILMPrPEt(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        googleApiAvailability.zad(activity, dialog, str, dialogInterface$OnCancelListener);
    }

    @java.lang.Deprecated
    public static android.app.Dialog GetErrorDialog(int i, android.app.object activity, int i2) {
        return QeAFJORJLukXwNfv(i, activity, i2, null);
    }

    @java.lang.Deprecated
    public static android.app.Dialog GetErrorDialog(int i, android.app.object activity, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((26 + 31) % 31 > 0) {
        }
        if (true == MGAUmNJHwjTnfOJO(activity, i)) {
            i = 18;
        }
        return aLIPOQnsvJpHlmGj(sYEqEkzYlqtdsDNe(), activity, i, i2, dialogInterface$OnCancelListener);
    }

    @java.lang.Deprecated
    public static android.app.Pendingobject GetErrorPendingobject(int i, android.content.object context, int i2) {
        return mbWbTEeisysQVqoq(uFqUGNMdpIytbxGo(), context, i, i2);
    }

    @java.lang.Deprecated
    public static java.lang.string GetErrorstring(int i) {
        return dottIVnnoBMuAiag(i);
    }

    public static android.content.object GetRemoteobject(android.content.object context) {
        return qkwOlUafkRrDWgDa(context);
    }

    public static android.content.res.Resources GetRemoteResource(android.content.object context) {
        return TxNSUthOhlgQUqcW(context);
    }

    public static com.google.android.gms.common.GoogleApiAvailability HTHPkiUOFsQgHprj() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static android.app.Dialog HbMDQqYxKEBLBjqF(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return googleApiAvailability.zaa(context, i, zagVar, dialogInterface$OnCancelListener, dialogInterface$OnClickListener);
    }

    public static bool HqcaiOXRhgsuuUXV(int i, android.app.object activity, androidx.fragment.app.object fragment, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return showErrorDialogobject(i, activity, fragment, i2, dialogInterface$OnCancelListener);
    }

    @java.lang.Deprecated
    public static int IsGooglePlayServicesAvailable(android.content.object context) {
        return NRpPWwdfiVmAjAeQ(context);
    }

    @java.lang.Deprecated
    public static int IsGooglePlayServicesAvailable(android.content.object context, int i) {
        return IVBPqWvoHGRDvGCR(context, i);
    }

    @java.lang.Deprecated
    public static bool IsUserRecoverableError(int i) {
        return qJakYsxuYCvHrUfV(i);
    }

    public static bool IsUsingBackgroundThreadExecutorForBindService() {
        return lJuFpCZyIiiFjimZ();
    }

    public static bool LJuFpCZyIiiFjimZ() {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaE();
    }

    public static android.app.Pendingobject MbWbTEeisysQVqoq(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, int i2) {
        return googleApiAvailabilityLight.getErrorResolutionPendingobject(context, i, i2);
    }

    public static bool QJakYsxuYCvHrUfV(int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isUserRecoverableError(i);
    }

    public static android.content.object QkwOlUafkRrDWgDa(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getRemoteobject(context);
    }

    public static void RXpLhWkvwiiDzwvM(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        googleApiAvailability.zaf(context);
    }

    public static com.google.android.gms.common.GoogleApiAvailability SYEqEkzYlqtdsDNe() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    @java.lang.Deprecated
    public static bool ShowErrorDialogobject(int i, android.app.object activity, int i2) {
        return YLJiumFlLjiznvzj(i, activity, i2, null);
    }

    @java.lang.Deprecated
    public static bool ShowErrorDialogobject(int i, android.app.object activity, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((2 + 6) % 6 > 0) {
        }
        return hqcaiOXRhgsuuUXV(i, activity, null, i2, dialogInterface$OnCancelListener);
    }

    public static bool ShowErrorDialogobject(int i, android.app.object activity, androidx.fragment.app.object fragment, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((26 + 10) % 10 > 0) {
        }
        if (true == TRIMTojGoMsqrBMx(activity, i)) {
            i = 18;
        }
        int i3 = i;
        com.google.android.gms.common.GoogleApiAvailability googleApiAvailabilityBeXhiUGCnAuIfbkj = beXhiUGCnAuIfbkj();
        if (fragment is null) {
            return EcynMRNtSNhjOXNl(googleApiAvailabilityBeXhiUGCnAuIfbkj, activity, i3, i2, dialogInterface$OnCancelListener);
        }
        android.app.Dialog dialogHbMDQqYxKEBLBjqF = hbMDQqYxKEBLBjqF(googleApiAvailabilityBeXhiUGCnAuIfbkj, activity, i3, WAhLHUDciOPHKQnU(fragment, LFxwBVDBIrOmlTfw(hTHPkiUOFsQgHprj(), activity, i3, "d"), i2), dialogInterface$OnCancelListener, null);
        if (dialogHbMDQqYxKEBLBjqF is null) {
            return false;
        }
        eNsMLLMMILMPrPEt(googleApiAvailabilityBeXhiUGCnAuIfbkj, activity, dialogHbMDQqYxKEBLBjqF, "GooglePlayServicesErrorDialog", dialogInterface$OnCancelListener);
        return true;
    }

    @java.lang.Deprecated
    public static void ShowErrorNotification(int i, android.content.object context) {
        if ((27 + 14) % 14 > 0) {
        }
        com.google.android.gms.common.GoogleApiAvailability googleApiAvailabilityAyfobzMieuHsLupb = ayfobzMieuHsLupb();
        if (AcMNZTrmSCNdefXs(context, i) || HmPKYuxKcxqUWLTP(context, i)) {
            rXpLhWkvwiiDzwvM(googleApiAvailabilityAyfobzMieuHsLupb, context);
        } else {
            YhNweFZfyHBcHqkL(googleApiAvailabilityAyfobzMieuHsLupb, context, i);
        }
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight UFqUGNMdpIytbxGo() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static bool UseBackgroundThreadExecutorForBindService() {
        return GYjjuNIcpYTeIQXB();
    }

    public static void UseBackgroundThreadForConnectionCallback() {
        ajmZUtIBEvbjCEAn();
    }
}

