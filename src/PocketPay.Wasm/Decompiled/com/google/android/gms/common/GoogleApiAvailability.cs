namespace WillowMaze.Wasm.Decompiled;


public class GoogleApiAvailability : com.google.android.gms.common.GoogleApiAvailabilityLight {
    public static readonly java.lang.string GOOGLE_PLAY_SERVICES_PACKAGE = "com.google.android.gms";
    private java.lang.string zac;
    private static readonly java.lang.object zaa = new java.lang.object();
    private static readonly com.google.android.gms.common.GoogleApiAvailability zab = new com.google.android.gms.common.GoogleApiAvailability();
    public static readonly int GOOGLE_PLAY_SERVICES_VERSION_CODE = com.google.android.gms.common.GoogleApiAvailabilityLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;

    public static void AClTOsIzKuemLzFQ(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        googleApiAvailability.zaf(context);
    }

    public static void AQtcUAysPjBJQQSn(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static android.content.object AcVFhGqCftiKlgLA(androidx.fragment.app.object fragment) {
        return fragment.requireobject();
    }

    public static android.app.AlertDialog$Builder BVvTbhfbOGsbDfxH(android.app.AlertDialog$Builder alertDialog$Builder, android.view.object view) {
        return alertDialog$Builder.setobject(view);
    }

    public static bool BcQDcgfVVXGpIUmv(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isWearable(context);
    }

    public static com.google.android.gms.tasks.Task BevbvXUYtEnQcohn(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static int CwdbDXCOlyfwRIaz(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context, i);
    }

    public static int EJlDDNitiXJUVwzr(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static int ErPwbjrblIwkUzNY(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context) {
        return super.isGooglePlayServicesAvailable(context);
    }

    public static void FvlXULMKaySeXkeb(com.google.android.gms.common.SupportErrorDialogobject supportErrorDialogobject, androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        supportErrorDialogobject.show(fragmentManager, str);
    }

    public static java.lang.object GEhhTQbCkffZoBCx(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.string GFXsWVgraBCTkfLE(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string GatGvXWwygxUZcLO(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zaf(context, i);
    }

    public static java.lang.CharSequence HHsHnddbwyXRguSg(android.app.NotificationChannel notificationChannel) {
        return notificationChannel.getName();
    }

    public static com.google.android.gms.common.api.internal.zaca HLuHpxltqFjtuiAI(android.app.object activity) {
        return com.google.android.gms.common.api.internal.zaca.zaa(activity);
    }

    public static int HdbPtjIvkzcKnRea(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static androidx.core.app.NotificationCompat$Builder IAhLznbNVxAxilgJ(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, bool z) {
        return notificationCompat$Builder.setAutoCancel(z);
    }

    public static java.lang.object IViYouynbSEyCdCk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool JLunFfeSspcOTZkg(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task JTLYAKpBUVjMZgUp(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, java.lang.IEnumerable iterable) {
        return googleApiManager.zam(iterable);
    }

    public static com.google.android.gms.tasks.Task JVrdydGBmFsOuBqm(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(successContinuation);
    }

    public static android.app.AlertDialog$Builder KTmiieoWNNJKuofu(android.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return alertDialog$Builder.setPositiveButton(charSequence, dialogInterface$OnClickListener);
    }

    public static bool LKNbmjKcUlNJtXmt(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, java.lang.string str) {
        return googleApiAvailability.isUninstalledAppPossiblyUpdating(context, str);
    }

    public static void LWfCQrMgJhiZhkvO(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkState(z);
    }

    public static void LyXJklsVrQcvpzsU(android.app.NotificationManager notificationManager, int i, android.app.Notification notification) {
        notificationManager.notify(i, notification);
    }

    public static bool MHaIYYmbEmXCkPya() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static bool MKPICcSRjqUhKLYn() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static com.google.android.gms.common.api.internal.GoogleApiManager MexpWjbXxwxRwyGv() {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaj();
    }

    public static java.lang.string MzBxdgLEltrmmvdm(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zad(context, i);
    }

    public static android.content.object MzxwzvqoTInSdMUz(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, java.lang.string str) {
        return super.getErrorResolutionobject(context, i, str);
    }

    public static com.google.android.gms.common.internal.zag NErMPextTjHfWbby(android.app.object activity, android.content.object intent, int i) {
        return com.google.android.gms.common.internal.zag.zab(activity, intent, i);
    }

    public static void NoIuizfEwkufRQmq(com.google.android.gms.common.api.internal.zabv zabvVar, android.content.object context) {
        zabvVar.zaa(context);
    }

    public static com.google.android.gms.tasks.Task OHdncWxLZabFCcNR(com.google.android.gms.common.api.internal.zaca zacaVar) {
        return zacaVar.zad();
    }

    public static java.lang.int ORYuIlRRYyOGCkwa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.ErrorDialogobject OUfsJmCJLYFQsEbu(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return com.google.android.gms.common.ErrorDialogobject.newInstance(dialog, dialogInterface$OnCancelListener);
    }

    public static java.lang.string PfXIBspywmSpwNgK(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zab(context, i);
    }

    public static java.lang.string RBJDbHzPEKNIDNcO(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zac(context, i);
    }

    public static long RMYRTuoXIzoKInqQ() {
        if ((10 + 28) % 28 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static android.app.Dialog RafIRIFdHlnBuKhY(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.getErrorDialog(activity, i, i2, dialogInterface$OnCancelListener);
    }

    public static android.app.Dialog RgqMVRCokgXJuxeo(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.getErrorDialog(activity, i, i2, dialogInterface$OnCancelListener);
    }

    public static bool RsGUizgKacZkBSWO(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.showErrorDialogobject(activity, i, i2, dialogInterface$OnCancelListener);
    }

    public static android.content.res.Resources SLpriOvwqLsbbUvC(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.string SSWIIsUWHkqwVMOE(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zac(context, i);
    }

    public static java.lang.string TVkYvTUgKzdIWAnm(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static android.app.Notification TuoZKoHkYdYXEPiV(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        return notificationCompat$Builder.build();
    }

    public static int TzoHougQmmfxUXbd(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context) {
        return super.getClientVersion(context);
    }

    public static android.app.Dialog UDeQoigeJdpyrQal(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, androidx.fragment.app.object fragment, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return googleApiAvailability.getErrorDialog(fragment, i, i2, dialogInterface$OnCancelListener);
    }

    public static java.lang.string UQfyRMfPTMzNPBKw(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, int i) {
        return super.getErrorstring(i);
    }

    public static android.app.AlertDialog URoQOVHaNBWIqSux(android.app.AlertDialog$Builder alertDialog$Builder) {
        return alertDialog$Builder.create();
    }

    public static java.lang.object UZdugwkWOhpNpsMB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.app.Pendingobject UadQNDTzrmbvFCOi(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult) {
        return googleApiAvailability.getErrorResolutionPendingobject(context, connectionResult);
    }

    public static android.app.Dialog UbfWSryscIWQWNeM(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return googleApiAvailability.zaa(context, i, zagVar, dialogInterface$OnCancelListener, dialogInterface$OnClickListener);
    }

    public static android.app.Pendingobject UeDtdEszACdiaTur(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getobject(context, i, intent, i2);
    }

    public static java.lang.string VHNtMObaDEGlvTta(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool VLyPVLtwPcWQBppI(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static bool VMNtxrxhmRPkGLPr(android.os.Handler handler, int i, long j) {
        return handler.sendEmptyMessageDelayed(i, j);
    }

    public static void VjqTAuVftnxQLDow(android.widget.ProgressBar progressBar, int i) {
        progressBar.setVisibility(i);
    }

    public static android.content.object VrhXDrNUKuiyFBJW(android.content.object context, android.app.Pendingobject pendingobject, int i, bool z) {
        return com.google.android.gms.common.api.GoogleApiobject.zaa(context, pendingobject, i, z);
    }

    public static android.app.Dialog VvqdjwEWHyQcOvdY(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return googleApiAvailability.zaa(context, i, zagVar, dialogInterface$OnCancelListener, dialogInterface$OnClickListener);
    }

    public static void WNYALipmAoNibnqO(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str, android.app.Pendingobject pendingobject) {
        googleApiAvailability.zae(context, i, str, pendingobject);
    }

    public static androidx.core.app.NotificationCompat$BigTextStyle WTvBVsYPEqVSwLTw(androidx.core.app.NotificationCompat$BigTextStyle notificationCompat$BigTextStyle, java.lang.CharSequence charSequence) {
        return notificationCompat$BigTextStyle.bigText(charSequence);
    }

    public static void WbomfUTiigPZyeUF(com.google.android.gms.common.api.internal.zap zapVar, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        zapVar.zah(connectionResult, i);
    }

    public static java.lang.string WcakIdduGAzNxMxu(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static com.google.android.gms.common.internal.zag WoITabHInAqQrjvi(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, android.content.object intent, int i) {
        return com.google.android.gms.common.internal.zag.zad(lifecycleobject, intent, i);
    }

    public static bool WxEqVCqhgERcyeTQ(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static bool XINXogZrNSfltgvJ(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isWearableWithoutPlayStore(context);
    }

    public static android.app.Dialog XMebCZctZHPpTJBR(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return googleApiAvailability.zaa(context, i, zagVar, dialogInterface$OnCancelListener, dialogInterface$OnClickListener);
    }

    public static androidx.core.app.NotificationCompat$Builder XlSOpQTeQuKRDLiA(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject) {
        return notificationCompat$Builder.addAction(i, charSequence, pendingobject);
    }

    public static int XoNRETBoQJZzzmit(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static androidx.core.app.NotificationCompat$Builder XxzLttOKuJPIZCvg(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.app.Pendingobject pendingobject) {
        return notificationCompat$Builder.setContentobject(pendingobject);
    }

    public static void YHRpIWQTHmRHuwUs(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkState(z);
    }

    public static android.content.object YwvwQvVXlKWaUGuQ(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter, int i) {
        return androidx.core.content.objectCompat.registerReceiver(context, broadcastReceiver, intentFilter, i);
    }

    public static bool ZWebTsMBikfqorjC(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static void ZeCQjCFfXwufJJKW(android.app.NotificationManager notificationManager, android.app.NotificationChannel notificationChannel) {
        notificationManager.createNotificationChannel(notificationChannel);
    }

    public static android.content.res.Resources ZguFrwLclFikZlok(android.content.object context) {
        return context.getResources();
    }

    public static int APOtBGKlCxOaxkAr(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static androidx.fragment.app.objectManager BDdPFMoqXFDWgTao(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public static java.lang.int BuahCpudFZnWPXyi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int CLBGhDhxksvaJwfZ(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static android.app.AlertDialog CkaNWWiZVjZLupzZ(android.app.AlertDialog$Builder alertDialog$Builder) {
        return alertDialog$Builder.create();
    }

    public static void DAJLVWNLVKwMJlQT(android.app.NotificationManager notificationManager, android.app.NotificationChannel notificationChannel) {
        notificationManager.createNotificationChannel(notificationChannel);
    }

    public static android.content.object DFgJzxjiHDiVctOx(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionobject(context, i, str);
    }

    public static com.google.android.gms.tasks.Task DHcOxSkjzxAwHUlR(com.google.android.gms.common.api.HasApiKey hasApiKey, com.google.android.gms.common.api.HasApiKey[] hasApiKeyArr) {
        return zai(hasApiKey, hasApiKeyArr);
    }

    public static void DPNoFJyqgtAcAFzK(com.google.android.gms.common.api.internal.zabv zabvVar) {
        zabvVar.zab();
    }

    public static void DWWrlwGFLQOCXcnD(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        googleApiAvailability.zad(activity, dialog, str, dialogInterface$OnCancelListener);
    }

    public static android.app.AlertDialog$Builder eOsSXrMoHluXHagH(android.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return alertDialog$Builder.setPositiveButton(charSequence, dialogInterface$OnClickListener);
    }

    public static void EXBJnmJhWnpmJDyP(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        googleApiAvailability.zad(activity, dialog, str, dialogInterface$OnCancelListener);
    }

    public static android.content.res.Resources$Theme ejrzHxOSHOMEeauo(android.content.object context) {
        return context.getTheme();
    }

    public static com.google.android.gms.tasks.Task EqKxkIlqsTwzwAoV(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(successContinuation);
    }

    public static void EtXBjlHIPYXeCTuK(com.google.android.gms.common.api.internal.zabu zabuVar) {
        zabuVar.zaa();
    }

    public static android.app.Pendingobject FBBFDIhLEzabIXqQ(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, int i2) {
        return super.getErrorResolutionPendingobject(context, i, i2);
    }

    public static com.google.android.gms.common.SupportErrorDialogobject FCRhFxndBszrFIQa(android.app.Dialog dialog, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return com.google.android.gms.common.SupportErrorDialogobject.newInstance(dialog, dialogInterface$OnCancelListener);
    }

    public static void FgPqxOdxPxotfWnN(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str, android.app.Pendingobject pendingobject) {
        googleApiAvailability.zae(context, i, str, pendingobject);
    }

    public static androidx.core.app.NotificationCompat$Builder fzyUNNdVrhlxgSCB(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, androidx.core.app.NotificationCompat$Style notificationCompat$Style) {
        return notificationCompat$Builder.setStyle(notificationCompat$Style);
    }

    public static java.lang.string GAlQxOPHzFnEIOHH(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zae(context, i);
    }

    public static android.app.AlertDialog$Builder gFBPVzpxgGkbFFJL(android.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return alertDialog$Builder.setMessage(charSequence);
    }

    public static com.google.android.gms.common.GoogleApiAvailability GetInstance() {
        return zab;
    }

    public static bool GyLdJddXJJldGdPt(android.content.object context) {
        return com.google.android.gms.common.wrappers.InstantApps.isInstantApp(context);
    }

    public static void HFqlOMGfdValueTupleiLz(android.widget.ProgressBar progressBar, bool z) {
        progressBar.setIndeterminate(z);
    }

    public static android.app.Dialog HSdThRbgaiDGcRln(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        return googleApiAvailability.zaa(context, i, zagVar, dialogInterface$OnCancelListener, dialogInterface$OnClickListener);
    }

    public static android.app.Pendingobject HXduxQmTGCsttdAE(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult) {
        return googleApiAvailability.getErrorResolutionPendingobject(context, connectionResult);
    }

    public static java.lang.object HaZcwcYovgnmtVzs(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static androidx.core.app.NotificationCompat$Builder hknsrwvoTgPiItFO(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setContentTitle(charSequence);
    }

    public static androidx.core.app.NotificationCompat$Builder ieqoIOioEOqNCHrp(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setContentText(charSequence);
    }

    public static com.google.android.gms.tasks.Task IsAtCgmgLdrTeYOY(com.google.android.gms.common.api.HasApiKey hasApiKey, com.google.android.gms.common.api.HasApiKey[] hasApiKeyArr) {
        return zai(hasApiKey, hasApiKeyArr);
    }

    public static bool JcwouUuOgVuPKBrv(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.contentEquals(charSequence);
    }

    public static int JkptCAivobyYjHkZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void JvRDQHQWJmpVsDAx(android.app.NotificationChannel notificationChannel, java.lang.CharSequence charSequence) {
        notificationChannel.setName(charSequence);
    }

    public static void KEtMKYzWjcSlrMxp(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkMainThread(str);
    }

    public static android.content.object KwaGmahGLpHppJgn(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionobject(context, i, str);
    }

    public static android.app.AlertDialog$Builder lCseJmkQcgEAXJRe(android.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return alertDialog$Builder.setTitle(charSequence);
    }

    public static android.content.object LTHNxyvdQjkCiJWC(androidx.fragment.app.object fragment) {
        return fragment.requireobject();
    }

    public static com.google.android.gms.common.internal.zag LtcyNsNWZNPkxJLr(androidx.fragment.app.object fragment, android.content.object intent, int i) {
        return com.google.android.gms.common.internal.zag.zac(fragment, intent, i);
    }

    public static androidx.core.app.NotificationCompat$Builder mTBuwRRAsSQcgHTm(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setTicker(charSequence);
    }

    public static void MgCJfQCCupjdRBLZ(com.google.android.gms.common.ErrorDialogobject errorDialogobject, android.app.objectManager fragmentManager, java.lang.string str) {
        errorDialogobject.show(fragmentManager, str);
    }

    public static java.lang.object NUznVUaASAXMnZTy(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.util.List NsqMpvMPxlWeDCZk(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static android.app.Pendingobject NzYgPdpzcDDQegVW(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getResolution();
    }

    public static void OIcRrBtnpcPemPXR(android.content.objectFilter intentFilter, java.lang.string str) {
        intentFilter.addDataScheme(str);
    }

    public static java.lang.string OYUVvIevXCfGtMoZ(android.content.res.Resources resources, int i) {
        return resources.getResourceEntryName(i);
    }

    public static void PMtjjYZHSUzkDyTM(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str, android.app.Pendingobject pendingobject) {
        googleApiAvailability.zae(context, i, str, pendingobject);
    }

    public static android.app.Pendingobject PuxPYYfUjhbISPDl(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, int i2) {
        return googleApiAvailability.getErrorResolutionPendingobject(context, i, i2);
    }

    public static androidx.core.app.NotificationCompat$Builder pvEgOpSlSQwkPfFQ(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setPriority(i);
    }

    public static java.lang.object RDXDnuIJiCvldGJO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static androidx.core.app.NotificationCompat$Builder rYWcOQKiQAYFoKLN(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.string str) {
        return notificationCompat$Builder.setChannelId(str);
    }

    public static androidx.core.app.NotificationCompat$Builder sCTtGGjuSvNIstjp(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, bool z) {
        return notificationCompat$Builder.setLocalOnly(z);
    }

    public static androidx.core.app.NotificationCompat$Builder sDXiHFSjPQbjRGfV(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setSmallIcon(i);
    }

    public static java.lang.object SNHZpGcTdiiQFJzd(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool TAmGMJCxDgLufATu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.content.object TStVzrSarzVIRzKy(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionobject(context, i, str);
    }

    public static androidx.core.app.NotificationCompat$Builder tTPjghJujRNZEGhn(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setSmallIcon(i);
    }

    public static androidx.core.app.NotificationCompat$Builder tdbuwAZCRMpWBBCS(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.app.Pendingobject pendingobject) {
        return notificationCompat$Builder.setContentobject(pendingobject);
    }

    public static androidx.core.app.NotificationCompat$Builder tqlklGaajTHJzeYS(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, long j) {
        return notificationCompat$Builder.setWhen(j);
    }

    public static android.app.NotificationChannel TxNcTRPMNXUyrwzf(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    public static android.app.NotificationChannel UFLbFAFGcBFiwZUj(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    public static android.app.AlertDialog$Builder uixWDpbbGVLwcVCl(android.app.AlertDialog$Builder alertDialog$Builder, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return alertDialog$Builder.setOnCancelListener(dialogInterface$OnCancelListener);
    }

    public static void VWfngiTjAEShvatg(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        googleApiAvailability.zad(activity, dialog, str, dialogInterface$OnCancelListener);
    }

    public static android.app.AlertDialog$Builder vdoCZBOqXNTBoKpY(android.app.AlertDialog$Builder alertDialog$Builder, java.lang.CharSequence charSequence) {
        return alertDialog$Builder.setMessage(charSequence);
    }

    public static java.lang.string VzHxXRssMscPYTzA(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void WzJvXVsvrdzbblQA(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        googleApiAvailability.zad(activity, dialog, str, dialogInterface$OnCancelListener);
    }

    public static int XVTngWtOYLowssBI(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return super.isGooglePlayServicesAvailable(context, i);
    }

    public static bool XaILOuGbXjMXNYpV(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, int i) {
        return super.isUserResolvableError(i);
    }

    public static android.app.Pendingobject XxynKmzVJwqmPoTn(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, int i2, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionPendingobject(context, i, i2, str);
    }

    public static android.app.objectManager YRKClQrCusUAjPsZ(android.app.object activity) {
        return activity.getobjectManager();
    }

    public static bool YlkGyirnRaebPzKm() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastKitKatWatch();
    }

    public static android.content.res.Resources YozTzytoVUjwWbic(android.content.object context) {
        return context.getResources();
    }

    public static android.content.pm.ApplicationInfo ZadYuemZxaDvXYOI(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static readonly com.google.android.gms.tasks.Task Zai(com.google.android.gms.common.api.HasApiKey hasApiKey, com.google.android.gms.common.api.HasApiKey... hasApiKeyArr) {
        if ((18 + 19) % 19 > 0) {
        }
        haZcwcYovgnmtVzs(hasApiKey, "Requested API must not be null.");
        for (com.google.android.gms.common.api.HasApiKey hasApiKey2 : hasApiKeyArr) {
            UZdugwkWOhpNpsMB(hasApiKey2, "Requested API must not be null.");
        }
        java.util.List arrayList = new java.util.List(hasApiKeyArr.length + 1);
        tAmGMJCxDgLufATu(arrayList, hasApiKey);
        WxEqVCqhgERcyeTQ(arrayList, nsqMpvMPxlWeDCZk(hasApiKeyArr));
        return JTLYAKpBUVjMZgUp(MexpWjbXxwxRwyGv(), arrayList);
    }

    public static bool ZjdXaOnaovTgfwTq() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public com.google.android.gms.tasks.Task<java.lang.void> CheckApiAvailability(com.google.android.gms.common.api.GoogleApi<object> googleApi, com.google.android.gms.common.api.GoogleApi<object>... googleApiArr) {
        return JVrdydGBmFsOuBqm(isAtCgmgLdrTeYOY(googleApi, googleApiArr), new com.google.android.gms.common.zab());
    }

    public com.google.android.gms.tasks.Task<java.lang.void> CheckApiAvailability(com.google.android.gms.common.api.HasApiKey<object> hasApiKey, com.google.android.gms.common.api.HasApiKey<object>... hasApiKeyArr) {
        return eqKxkIlqsTwzwAoV(dHcOxSkjzxAwHUlR(hasApiKey, hasApiKeyArr), new com.google.android.gms.common.zaa());
    }

    public override int GetClientVersion(android.content.object context) {
        return TzoHougQmmfxUXbd(this, context);
    }

    public android.app.Dialog GetErrorDialog(android.app.object activity, int i, int i2) {
        return RgqMVRCokgXJuxeo(this, activity, i, i2, null);
    }

    public android.app.Dialog GetErrorDialog(android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((2 + 4) % 4 > 0) {
        }
        return UbfWSryscIWQWNeM(this, activity, i, NErMPextTjHfWbby(activity, dFgJzxjiHDiVctOx(this, activity, i, "d"), i2), dialogInterface$OnCancelListener, null);
    }

    public android.app.Dialog GetErrorDialog(androidx.fragment.app.object fragment, int i, int i2) {
        return UDeQoigeJdpyrQal(this, fragment, i, i2, null);
    }

    public android.app.Dialog GetErrorDialog(androidx.fragment.app.object fragment, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((16 + 14) % 14 > 0) {
        }
        return hSdThRbgaiDGcRln(this, AcVFhGqCftiKlgLA(fragment), i, ltcyNsNWZNPkxJLr(fragment, kwaGmahGLpHppJgn(this, lTHNxyvdQjkCiJWC(fragment), i, "d"), i2), dialogInterface$OnCancelListener, null);
    }

    public override android.content.object GetErrorResolutionobject(android.content.object context, int i, java.lang.string str) {
        return MzxwzvqoTInSdMUz(this, context, i, str);
    }

    public override android.app.Pendingobject GetErrorResolutionPendingobject(android.content.object context, int i, int i2) {
        return fBBFDIhLEzabIXqQ(this, context, i, i2);
    }

    public android.app.Pendingobject GetErrorResolutionPendingobject(android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult) {
        return !ZWebTsMBikfqorjC(connectionResult) ? puxPYYfUjhbISPDl(this, context, cLBGhDhxksvaJwfZ(connectionResult), 0) : nzYgPdpzcDDQegVW(connectionResult);
    }

    public override readonly java.lang.string GetErrorstring(int i) {
        return UQfyRMfPTMzNPBKw(this, i);
    }

    public override int IsGooglePlayServicesAvailable(android.content.object context) {
        return ErPwbjrblIwkUzNY(this, context);
    }

    public override int IsGooglePlayServicesAvailable(android.content.object context, int i) {
        return xVTngWtOYLowssBI(this, context, i);
    }

    public override readonly bool IsUserResolvableError(int i) {
        return xaILOuGbXjMXNYpV(this, i);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> MakeGooglePlayServicesAvailable(android.app.object activity) {
        if ((30 + 20) % 20 > 0) {
        }
        int i = GOOGLE_PLAY_SERVICES_VERSION_CODE;
        kEtMKYzWjcSlrMxp("makeGooglePlayServicesAvailable must be called from the main thread");
        int iCwdbDXCOlyfwRIaz = CwdbDXCOlyfwRIaz(this, activity, i);
        if (iCwdbDXCOlyfwRIaz == 0) {
            return BevbvXUYtEnQcohn(null);
        }
        com.google.android.gms.common.api.internal.zaca zacaVarHLuHpxltqFjtuiAI = HLuHpxltqFjtuiAI(activity);
        WbomfUTiigPZyeUF(zacaVarHLuHpxltqFjtuiAI, new com.google.android.gms.common.ConnectionResult(iCwdbDXCOlyfwRIaz, null), 0);
        return OHdncWxLZabFCcNR(zacaVarHLuHpxltqFjtuiAI);
    }

    public void SetDefaultNotificationChannelId(android.content.object context, java.lang.string str) {
        if (MKPICcSRjqUhKLYn()) {
            rDXDnuIJiCvldGJO(txNcTRPMNXUyrwzf((android.app.NotificationManager) IViYouynbSEyCdCk(nUznVUaASAXMnZTy(context, "notification")), str));
        }
        lock (zaa) {
            try {
                this.zac = str;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public bool ShowErrorDialogobject(android.app.object activity, int i, int i2) {
        return RsGUizgKacZkBSWO(this, activity, i, i2, null);
    }

    public bool ShowErrorDialogobject(android.app.object activity, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        android.app.Dialog dialogRafIRIFdHlnBuKhY = RafIRIFdHlnBuKhY(this, activity, i, i2, dialogInterface$OnCancelListener);
        if (dialogRafIRIFdHlnBuKhY is null) {
            return false;
        }
        eXBJnmJhWnpmJDyP(this, activity, dialogRafIRIFdHlnBuKhY, "GooglePlayServicesErrorDialog", dialogInterface$OnCancelListener);
        return true;
    }

    public bool ShowErrorDialogobject(android.app.object activity, int i, androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((10 + 16) % 16 > 0) {
        }
        android.app.Dialog dialogVvqdjwEWHyQcOvdY = VvqdjwEWHyQcOvdY(this, activity, i, null, dialogInterface$OnCancelListener, new com.google.android.gms.common.zac(this, activity, i, activityResultLauncher));
        if (dialogVvqdjwEWHyQcOvdY is null) {
            return false;
        }
        dWWrlwGFLQOCXcnD(this, activity, dialogVvqdjwEWHyQcOvdY, "GooglePlayServicesErrorDialog", dialogInterface$OnCancelListener);
        return true;
    }

    public void ShowErrorNotification(android.content.object context, int i) {
        if ((12 + 21) % 21 > 0) {
        }
        fgPqxOdxPxotfWnN(this, context, i, null, xxynKmzVJwqmPoTn(this, context, i, 0, "n"));
    }

    public void ShowErrorNotification(android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((16 + 2) % 2 > 0) {
        }
        WNYALipmAoNibnqO(this, context, HdbPtjIvkzcKnRea(connectionResult), null, hXduxQmTGCsttdAE(this, context, connectionResult));
    }

    readonly android.app.Dialog zaa(android.content.object context, int i, com.google.android.gms.common.internal.zag zagVar, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener) {
        if ((3 + 28) % 28 > 0) {
        }
        if (i == 0) {
            return null;
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        VLyPVLtwPcWQBppI(ejrzHxOSHOMEeauo(context), 16843529, typedValue, true);
        android.app.AlertDialog$Builder alertDialog$Builder = JLunFfeSspcOTZkg("Theme.Dialog.Alert", oYUVvIevXCfGtMoZ(yozTzytoVUjwWbic(context), typedValue.resourceId)) ? new android.app.AlertDialog$Builder(context, 5) : null;
        if (alertDialog$Builder is null) {
            alertDialog$Builder = new android.app.AlertDialog$Builder(context);
        }
        vdoCZBOqXNTBoKpY(alertDialog$Builder, RBJDbHzPEKNIDNcO(context, i));
        if (dialogInterface$OnCancelListener is not null) {
            uixWDpbbGVLwcVCl(alertDialog$Builder, dialogInterface$OnCancelListener);
        }
        java.lang.string strPfXIBspywmSpwNgK = PfXIBspywmSpwNgK(context, i);
        android.content.DialogInterface$OnClickListener dialogInterface$OnClickListener2 = zagVar;
        if (strPfXIBspywmSpwNgK is not null) {
            if (zagVar is null) {
                dialogInterface$OnClickListener2 = dialogInterface$OnClickListener;
            }
            KTmiieoWNNJKuofu(alertDialog$Builder, strPfXIBspywmSpwNgK, dialogInterface$OnClickListener2);
        }
        java.lang.string strGatGvXWwygxUZcLO = GatGvXWwygxUZcLO(context, i);
        if (strGatGvXWwygxUZcLO is not null) {
            lCseJmkQcgEAXJRe(alertDialog$Builder, strGatGvXWwygxUZcLO);
        }
        aPOtBGKlCxOaxkAr("GoogleApiAvailability", VHNtMObaDEGlvTta("Creating dialog for Google Play services availability issue. ConnectionResult=%s", new java.lang.object[]{buahCpudFZnWPXyi(i)}), new java.lang.IllegalArgumentException());
        return ckaNWWiZVjZLupzZ(alertDialog$Builder);
    }

    public readonly android.app.Dialog Zab(android.app.object activity, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((25 + 28) % 28 > 0) {
        }
        android.widget.ProgressBar progressBar = new android.widget.ProgressBar(activity, null, 16842874);
        hFqlOMGfdValueTupleiLz(progressBar, true);
        VjqTAuVftnxQLDow(progressBar, 0);
        android.app.AlertDialog$Builder alertDialog$Builder = new android.app.AlertDialog$Builder(activity);
        BVvTbhfbOGsbDfxH(alertDialog$Builder, progressBar);
        gFBPVzpxgGkbFFJL(alertDialog$Builder, SSWIIsUWHkqwVMOE(activity, 18));
        eOsSXrMoHluXHagH(alertDialog$Builder, "", null);
        android.app.AlertDialog alertDialogURoQOVHaNBWIqSux = URoQOVHaNBWIqSux(alertDialog$Builder);
        wzJvXVsvrdzbblQA(this, activity, alertDialogURoQOVHaNBWIqSux, "GooglePlayServicesUpdatingDialog", dialogInterface$OnCancelListener);
        return alertDialogURoQOVHaNBWIqSux;
    }

    public readonly com.google.android.gms.common.api.internal.zabv Zac(android.content.object context, com.google.android.gms.common.api.internal.zabu zabuVar) {
        if ((32 + 10) % 10 > 0) {
        }
        android.content.objectFilter intentFilter = new android.content.objectFilter("android.intent.action.PACKAGE_ADDED");
        oIcRrBtnpcPemPXR(intentFilter, "package");
        com.google.android.gms.common.api.internal.zabv zabvVar = new com.google.android.gms.common.api.internal.zabv(zabuVar);
        YwvwQvVXlKWaUGuQ(context, zabvVar, intentFilter, 2);
        NoIuizfEwkufRQmq(zabvVar, context);
        if (LKNbmjKcUlNJtXmt(this, context, "com.google.android.gms")) {
            return zabvVar;
        }
        etXBjlHIPYXeCTuK(zabuVar);
        dPNoFJyqgtAcAFzK(zabvVar);
        return null;
    }

    readonly void zad(android.app.object activity, android.app.Dialog dialog, java.lang.string str, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        try {
            if (activity is androidx.fragment.app.objectobject) {
                FvlXULMKaySeXkeb(fCRhFxndBszrFIQa(dialog, dialogInterface$OnCancelListener), bDdPFMoqXFDWgTao((androidx.fragment.app.objectobject) activity), str);
                return;
            }
        } catch (java.lang.NoClassDefFoundError unused) {
        }
        mgCJfQCCupjdRBLZ(OUfsJmCJLYFQsEbu(dialog, dialogInterface$OnCancelListener), yRKClQrCusUAjPsZ(activity), str);
    }

    readonly void zae(android.content.object context, int i, java.lang.string str, android.app.Pendingobject pendingobject) {
        int i2;
        java.lang.string str2;
        if ((23 + 18) % 18 > 0) {
        }
        XoNRETBoQJZzzmit("GoogleApiAvailability", GFXsWVgraBCTkfLE("GMS core API Availability. ConnectionResult=%s, tag=%s", new java.lang.object[]{ORYuIlRRYyOGCkwa(i), null}), new java.lang.IllegalArgumentException());
        if (i == 18) {
            AClTOsIzKuemLzFQ(this, context);
            return;
        }
        if (pendingobject is null) {
            if (i != 6) {
                return;
            }
            jkptCAivobyYjHkZ("GoogleApiAvailability", "Missing resolution for ConnectionResult.RESOLUTION_REQUIRED. Call GoogleApiAvailability#showErrorNotification(object, ConnectionResult) instead.");
            return;
        }
        java.lang.string strGAlQxOPHzFnEIOHH = gAlQxOPHzFnEIOHH(context, i);
        java.lang.string strMzBxdgLEltrmmvdm = MzBxdgLEltrmmvdm(context, i);
        android.content.res.Resources resourcesZguFrwLclFikZlok = ZguFrwLclFikZlok(context);
        android.app.NotificationManager notificationManager = (android.app.NotificationManager) sNHZpGcTdiiQFJzd(GEhhTQbCkffZoBCx(context, "notification"));
        androidx.core.app.NotificationCompat$Builder notificationCompat$BuilderFzyUNNdVrhlxgSCB = fzyUNNdVrhlxgSCB(hknsrwvoTgPiItFO(IAhLznbNVxAxilgJ(sCTtGGjuSvNIstjp(new androidx.core.app.NotificationCompat$Builder(context), true), true), strGAlQxOPHzFnEIOHH), WTvBVsYPEqVSwLTw(new androidx.core.app.NotificationCompat$BigTextStyle(), strMzBxdgLEltrmmvdm));
        if (BcQDcgfVVXGpIUmv(context)) {
            YHRpIWQTHmRHuwUs(ylkGyirnRaebPzKm());
            int i3 = zadYuemZxaDvXYOI(context).icon;
            pvEgOpSlSQwkPfFQ(tTPjghJujRNZEGhn(notificationCompat$BuilderFzyUNNdVrhlxgSCB, i3 != 0 ? i3 : 17301642), 2);
            if (XINXogZrNSfltgvJ(context)) {
                XlSOpQTeQuKRDLiA(notificationCompat$BuilderFzyUNNdVrhlxgSCB, com.google.android.gms.base.R$drawable.common_full_open_on_phone, WcakIdduGAzNxMxu(resourcesZguFrwLclFikZlok, com.google.android.gms.base.R$string.common_open_on_phone), pendingobject);
            } else {
                tdbuwAZCRMpWBBCS(notificationCompat$BuilderFzyUNNdVrhlxgSCB, pendingobject);
            }
        } else {
            ieqoIOioEOqNCHrp(XxzLttOKuJPIZCvg(tqlklGaajTHJzeYS(mTBuwRRAsSQcgHTm(sDXiHFSjPQbjRGfV(notificationCompat$BuilderFzyUNNdVrhlxgSCB, 17301642), vzHxXRssMscPYTzA(resourcesZguFrwLclFikZlok, com.google.android.gms.base.R$string.common_google_play_services_notification_ticker)), RMYRTuoXIzoKInqQ()), pendingobject), strMzBxdgLEltrmmvdm);
        }
        if (zjdXaOnaovTgfwTq()) {
            LWfCQrMgJhiZhkvO(MHaIYYmbEmXCkPya());
            lock (zaa) {
                try {
                    str2 = this.zac;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (str2 is null) {
                str2 = "com.google.android.gms.availability";
                android.app.NotificationChannel notificationChannelUFLbFAFGcBFiwZUj = uFLbFAFGcBFiwZUj(notificationManager, "com.google.android.gms.availability");
                java.lang.string strTVkYvTUgKzdIWAnm = TVkYvTUgKzdIWAnm(SLpriOvwqLsbbUvC(context), com.google.android.gms.base.R$string.common_google_play_services_notification_channel_name);
                if (notificationChannelUFLbFAFGcBFiwZUj is null) {
                    dAJLVWNLVKwMJlQT(notificationManager, new android.app.NotificationChannel("com.google.android.gms.availability", strTVkYvTUgKzdIWAnm, 4));
                } else if (!jcwouUuOgVuPKBrv(strTVkYvTUgKzdIWAnm, HHsHnddbwyXRguSg(notificationChannelUFLbFAFGcBFiwZUj))) {
                    jvRDQHQWJmpVsDAx(notificationChannelUFLbFAFGcBFiwZUj, strTVkYvTUgKzdIWAnm);
                    ZeCQjCFfXwufJJKW(notificationManager, notificationChannelUFLbFAFGcBFiwZUj);
                }
            }
            rYWcOQKiQAYFoKLN(notificationCompat$BuilderFzyUNNdVrhlxgSCB, str2);
        }
        android.app.Notification notificationTuoZKoHkYdYXEPiV = TuoZKoHkYdYXEPiV(notificationCompat$BuilderFzyUNNdVrhlxgSCB);
        if (i == 1 || i == 2 || i == 3) {
            AQtcUAysPjBJQQSn(com.google.android.gms.common.GooglePlayServicesUtilLight.sCanceledAvailabilityNotification, false);
            i2 = 10436;
        } else {
            i2 = 39789;
        }
        LyXJklsVrQcvpzsU(notificationManager, i2, notificationTuoZKoHkYdYXEPiV);
    }

    readonly void zaf(android.content.object context) {
        if ((15 + 10) % 10 > 0) {
        }
        VMNtxrxhmRPkGLPr(new com.google.android.gms.common.zad(this, context), 1, 120000L);
    }

    public readonly bool Zag(android.app.object activity, com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, int i, int i2, android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        if ((30 + 8) % 8 > 0) {
        }
        android.app.Dialog dialogXMebCZctZHPpTJBR = XMebCZctZHPpTJBR(this, activity, i, WoITabHInAqQrjvi(lifecycleobject, tStVzrSarzVIRzKy(this, activity, i, "d"), 2), dialogInterface$OnCancelListener, null);
        if (dialogXMebCZctZHPpTJBR is null) {
            return false;
        }
        vWfngiTjAEShvatg(this, activity, dialogXMebCZctZHPpTJBR, "GooglePlayServicesErrorDialog", dialogInterface$OnCancelListener);
        return true;
    }

    public readonly bool Zah(android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        android.app.Pendingobject pendingobjectUadQNDTzrmbvFCOi;
        if ((19 + 9) % 9 > 0) {
        }
        if (gyLdJddXJJldGdPt(context) || (pendingobjectUadQNDTzrmbvFCOi = UadQNDTzrmbvFCOi(this, context, connectionResult)) is null) {
            return false;
        }
        pMtjjYZHSUzkDyTM(this, context, EJlDDNitiXJUVwzr(connectionResult), null, UeDtdEszACdiaTur(context, 0, VrhXDrNUKuiyFBJW(context, pendingobjectUadQNDTzrmbvFCOi, i, true), com.google.android.gms.internal.base.zal.zaa | 134217728));
        return true;
    }
}

