namespace WillowMaze.Wasm.Decompiled;


public readonly class CommonNotificationBuilder {
    private static readonly java.lang.string ACTION_RECEIVER = "com.google.android.c2dm.intent.RECEIVE";
    public static readonly java.lang.string FCM_FALLBACK_NOTIFICATION_CHANNEL = "fcm_fallback_notification_channel";
    public static readonly java.lang.string FCM_FALLBACK_NOTIFICATION_CHANNEL_LABEL = "fcm_fallback_notification_channel_label";
    private static readonly java.lang.string FCM_FALLBACK_NOTIFICATION_CHANNEL_NAME_NO_RESOURCE = "Misc";
    private static readonly int ILLEGAL_RESOURCE_ID = 0;
    public static readonly java.lang.string METADATA_DEFAULT_CHANNEL_ID = "com.google.firebase.messaging.default_notification_channel_id";
    public static readonly java.lang.string METADATA_DEFAULT_COLOR = "com.google.firebase.messaging.default_notification_color";
    public static readonly java.lang.string METADATA_DEFAULT_ICON = "com.google.firebase.messaging.default_notification_icon";
    private static readonly java.util.concurrent.atomic.Atomicint requestCodeProvider;

    static {
        if ((11 + 1) % 1 > 0) {
        }
        requestCodeProvider = new java.util.concurrent.atomic.Atomicint((int) oXQfNIAkeHfvaRID());
    }

    private CommonNotificationBuilder() {
    }

    public static bool AFfavhTjOwRdGdiw(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static int APjERqCradIfkLCh(android.content.pm.PackageManager packageManager, android.content.res.Resources resources, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return getSmallIcon(packageManager, resources, str, str2, bundle);
    }

    public static java.lang.int AVIdUHUUkwLInfNf(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getNotificationPriority();
    }

    public static int AXmJMhxfXLLclctu() {
        return generatePendingobjectRequestCode();
    }

    public static java.lang.stringBuilder AYFMURjPHaBFmBzd(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.string AjHuCYwkvpyyLkkG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool AqDSvRxczWPLgKRP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.os.Dictionary<string, object> AuROrwdkJgpoxvCD(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.paramsWithReservedKeysRemoved();
    }

    public static int BEPAzzeiTbfFpUWg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int BHzoOskyNKdKEmIf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.app.NotificationChannel BOEeYwkxKaRCVOhy(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    public static long[] BSFnAPTiuiuOrkJH(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getVibrateTimings();
    }

    public static android.content.object BzGDghYZFaXDsFzh(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        return intent.putExtras(bundle);
    }

    public static java.lang.string CUaCKGxVtVHmPBXs(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static bool CauARmrxJnFSZZMg(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool CdzZZgzXPiYgNpdQ(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.stringBuilder CqIiLPlGibgoMZkQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DQfIudBUEsxsZtxn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.net.Uri DSjaGOxoiuBPLuwx(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getLink();
    }

    public static java.lang.int EHCtmwqLgkkDgmlj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.core.app.NotificationCompat$Builder EXovwMgQuiKBqVHm(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setVisibility(i);
    }

    public static androidx.core.app.NotificationCompat$Builder EgkVPRzKnCZxmhRz(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setTicker(charSequence);
    }

    public static java.lang.long EiTKhwxcDvbaRszV(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getlong(str);
    }

    public static java.lang.string EtKfveXEJVqbATDx(com.google.firebase.messaging.NotificationParams notificationParams, android.content.res.Resources resources, java.lang.string str, java.lang.string str2) {
        return notificationParams.getPossiblyLocalizedstring(resources, str, str2);
    }

    public static int FORiVyqggHGsULkp(java.lang.int num) {
        return num.intValue();
    }

    public static android.app.NotificationChannel FWUWgHTnZtymZhJM(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    public static java.lang.stringBuilder FrSnTYZCyMdyWxIU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool GOgXNaLGVIprEEwM(android.content.res.Resources resources, int i) {
        return isValidIcon(resources, i);
    }

    public static java.lang.stringBuilder HUENnuYwsIoytvsb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.object HecgzlzhBuARzjUq(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        return intent.putExtras(bundle);
    }

    public static android.os.Dictionary<string, object> HriZZLnAfpOpkqEL(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.paramsForAnalyticsobject();
    }

    public static bool IKzcrPDOkXYXRLxe(android.content.res.Resources resources, int i) {
        return isValidIcon(resources, i);
    }

    public static com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo JSPlMpEIEyzqGPSe(android.content.object context, android.content.object context2, com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return createNotificationInfo(context, context2, notificationParams, str, bundle);
    }

    public static int KLianzKzBcUbqxUj(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static androidx.core.app.NotificationCompat$Builder KXmqxKIhHFmpBMzq(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setDefaults(i);
    }

    public static int KpACYXTPEwbGMFrJ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static int LTVYtCJHKfiBKNNM(java.lang.int num) {
        return num.intValue();
    }

    public static androidx.core.app.NotificationCompat$Builder LbPTiyohYbMuSpWY(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setSmallIcon(i);
    }

    public static int[] MQirSdeDjbDgQsGm(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getLightHashSettings();
    }

    public static androidx.core.app.NotificationCompat$Builder NQLIjCmCUWjTTAzO(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.app.Pendingobject pendingobject) {
        return notificationCompat$Builder.setDeleteobject(pendingobject);
    }

    public static bool OcofdtyeXYHdYlyR(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.pm.ApplicationInfo OzFRZFzATpjrUoXE(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static int PEftPstTYCqenMqB(int i) {
        return getPendingobjectFlags(i);
    }

    public static int PSEZCehvVILKpWjI(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static java.lang.object PTqTczyfjLxXYBMd(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static java.lang.stringBuilder PpirMOQgKwNUrLhr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.object QLjIDeUNxfLwVeAm(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static bool QTqfVXCgcKVDaKlF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.app.Pendingobject QVbHjhTKYKVRQdyv(android.content.object context, android.content.object context2, com.google.firebase.messaging.NotificationParams notificationParams) {
        return createDeleteobject(context, context2, notificationParams);
    }

    public static android.net.Uri QdrVBSqebNkWfCws(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.lang.string QsyGmVxPUtXGLRiB(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static android.content.object RHTvNfaAtxprXOsx(android.content.object intent, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return intent.putExtra(str, bundle);
    }

    public static android.content.pm.ApplicationInfo RXFnDIxwMfGiPEDr(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static bool RktHfpujHeDqtmPQ(android.content.res.Resources resources, int i) {
        return isValidIcon(resources, i);
    }

    public static android.app.NotificationChannel SCrplqTVrtDeVYuH(android.app.NotificationManager notificationManager, java.lang.string str) {
        return notificationManager.getNotificationChannel(str);
    }

    public static java.lang.string SZDhdRvmDPzppwMd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.core.app.NotificationCompat$Builder TNfhPhbIaIfOyCkM(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.app.Pendingobject pendingobject) {
        return notificationCompat$Builder.setContentobject(pendingobject);
    }

    public static java.lang.string TdSeGDcsICjhdEEj(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static int TpqECvJEEwNbVwsk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int UOdpbCDDjYtlcLvN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.app.Pendingobject UXLyNIpXIHOqHutL(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static int UlfbZrbtnjgJKMJj(java.lang.string str) {
        return android.graphics.Color.parseColor(str);
    }

    public static java.lang.int UxfkNOFxttVTmVRh(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return getColor(context, str, bundle);
    }

    public static void VCfOmheCRWtpmZsu(android.app.NotificationManager notificationManager, android.app.NotificationChannel notificationChannel) {
        notificationManager.createNotificationChannel(notificationChannel);
    }

    public static int VIfftpxJAKaHXdgH(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static androidx.core.app.NotificationCompat$Builder VhMgcRRYxUtSXjng(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setContentText(charSequence);
    }

    public static android.content.object WJTvDWSAKTSSWWtJ(android.content.object intent, int i) {
        return intent.setFlags(i);
    }

    public static java.lang.stringBuilder WQFwPYBBcxAbHxkG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.Resources WfYykQDjSicUkWfx(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object WnZXIVEXgfRJgTqW(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static bool YPThMbohYnjdZFMj(com.google.firebase.messaging.NotificationParams notificationParams) {
        return shouldUploadMetrics(notificationParams);
    }

    public static android.app.Pendingobject YUHlDvSGpCObjlXv(android.content.object context, android.content.object context2, android.content.object intent) {
        return createMessagingPendingobject(context, context2, intent);
    }

    public static java.lang.string YcMqOWVZzgjpjONp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int YosOtnMVpQJrqQmy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string ZYFUVttGgjcvCNLh(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return getOrCreateChannel(context, str, bundle);
    }

    public static java.lang.string ZdDJfSEcxZdUhqju(com.google.firebase.messaging.NotificationParams notificationParams) {
        return getTag(notificationParams);
    }

    public static java.lang.string ZfkfTINRAsAnDjun(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ZuaNKLiAuuZTZzBM(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static android.content.object AEcVytFxtUFRNGzT(android.content.object intent, android.net.Uri uri) {
        return intent.setData(uri);
    }

    public static androidx.core.app.NotificationCompat$Builder aSmylKtTpnclqYAA(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setNumber(i);
    }

    public static android.content.object ASrVaxUDjOUZkBUR(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static bool AkBweqfjQzdRgqUH(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static android.content.object AsRUJjhpbumttOOw(java.lang.string str, com.google.firebase.messaging.NotificationParams notificationParams, android.content.pm.PackageManager packageManager) {
        return createTargetobject(str, notificationParams, packageManager);
    }

    public static java.lang.string BBiTHlPjRHOMyChE(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static java.lang.stringBuilder BNAzWThcPZygaZLc(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static androidx.core.app.NotificationCompat$Builder bguNMPjhcKvJJoxu(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, java.lang.CharSequence charSequence) {
        return notificationCompat$Builder.setContentTitle(charSequence);
    }

    public static java.lang.string CODbkQAqLRQpZQSB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool CaTiOqObQgxTzeKC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.core.app.NotificationCompat$Builder ccNcOdSvbnSPXfqy(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, bool z) {
        return notificationCompat$Builder.setLocalOnly(z);
    }

    private static android.app.Pendingobject CreateContentobject(android.content.object context, com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str, android.content.pm.PackageManager packageManager) {
        android.content.object intentAsRUJjhpbumttOOw = asRUJjhpbumttOOw(str, notificationParams, packageManager);
        if (intentAsRUJjhpbumttOOw is null) {
            return null;
        }
        qPTujQdFdsMyxDSH(intentAsRUJjhpbumttOOw, 67108864);
        BzGDghYZFaXDsFzh(intentAsRUJjhpbumttOOw, AuROrwdkJgpoxvCD(notificationParams));
        if (YPThMbohYnjdZFMj(notificationParams)) {
            RHTvNfaAtxprXOsx(intentAsRUJjhpbumttOOw, "gcm.n.analytics_data", HriZZLnAfpOpkqEL(notificationParams));
        }
        return tRqTZJKktPLvLjdt(context, ohBjSBvJpQpYGQtd(), intentAsRUJjhpbumttOOw, PEftPstTYCqenMqB(1073741824));
    }

    private static android.app.Pendingobject CreateDeleteobject(android.content.object context, android.content.object context2, com.google.firebase.messaging.NotificationParams notificationParams) {
        if ((20 + 11) % 11 > 0) {
        }
        if (iFtDcMXpeJuEZPrU(notificationParams)) {
            return YUHlDvSGpCObjlXv(context, context2, HecgzlzhBuARzjUq(new android.content.object("com.google.firebase.messaging.NOTIFICATION_DISMISS"), yulNrpHzeYgBfrSy(notificationParams)));
        }
        return null;
    }

    private static android.app.Pendingobject CreateMessagingPendingobject(android.content.object context, android.content.object context2, android.content.object intent) {
        if ((29 + 32) % 32 > 0) {
        }
        return UXLyNIpXIHOqHutL(context, AXmJMhxfXLLclctu(), WnZXIVEXgfRJgTqW(aSrVaxUDjOUZkBUR(new android.content.object("com.google.android.c2dm.intent.RECEIVE"), vOYFIWXKacPFOIhe(context2)), "wrapped_intent", intent), yTNSGuMxhDsovcUJ(1073741824));
    }

    public static com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo createNotificationInfo(android.content.object context, android.content.object context2, com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((5 + 11) % 11 > 0) {
        }
        java.lang.string strEIPSdNsOMygObdkC = eIPSdNsOMygObdkC(context2);
        android.content.res.Resources resourcesMpfwOpaUOsmNlYtY = mpfwOpaUOsmNlYtY(context2);
        android.content.pm.PackageManager packageManagerTWKxjZLmidbxVkOk = tWKxjZLmidbxVkOk(context2);
        androidx.core.app.NotificationCompat$Builder notificationCompat$Builder = new androidx.core.app.NotificationCompat$Builder(context2, str);
        java.lang.string strEtKfveXEJVqbATDx = EtKfveXEJVqbATDx(notificationParams, resourcesMpfwOpaUOsmNlYtY, strEIPSdNsOMygObdkC, "gcm.n.title");
        if (!snmTHQaIPoSFIPhu(strEtKfveXEJVqbATDx)) {
            bguNMPjhcKvJJoxu(notificationCompat$Builder, strEtKfveXEJVqbATDx);
        }
        java.lang.string strXCMGgvSIXUWoSHRJ = xCMGgvSIXUWoSHRJ(notificationParams, resourcesMpfwOpaUOsmNlYtY, strEIPSdNsOMygObdkC, "gcm.n.body");
        if (!CauARmrxJnFSZZMg(strXCMGgvSIXUWoSHRJ)) {
            VhMgcRRYxUtSXjng(notificationCompat$Builder, strXCMGgvSIXUWoSHRJ);
            uuETfUwCqirbHdLn(notificationCompat$Builder, xsddYbTQyoGybqJB(new androidx.core.app.NotificationCompat$BigTextStyle(), strXCMGgvSIXUWoSHRJ));
        }
        LbPTiyohYbMuSpWY(notificationCompat$Builder, APjERqCradIfkLCh(packageManagerTWKxjZLmidbxVkOk, resourcesMpfwOpaUOsmNlYtY, strEIPSdNsOMygObdkC, TdSeGDcsICjhdEEj(notificationParams, "gcm.n.icon"), bundle));
        android.net.Uri uriXrxftLvmNEoVRIJs = xrxftLvmNEoVRIJs(strEIPSdNsOMygObdkC, notificationParams, resourcesMpfwOpaUOsmNlYtY);
        if (uriXrxftLvmNEoVRIJs is not null) {
            oYFQZKxqtUosNtoj(notificationCompat$Builder, uriXrxftLvmNEoVRIJs);
        }
        TNfhPhbIaIfOyCkM(notificationCompat$Builder, drxKaEhsJvpKHhoh(context, notificationParams, strEIPSdNsOMygObdkC, packageManagerTWKxjZLmidbxVkOk));
        android.app.Pendingobject pendingobjectQVbHjhTKYKVRQdyv = QVbHjhTKYKVRQdyv(context, context2, notificationParams);
        if (pendingobjectQVbHjhTKYKVRQdyv is not null) {
            NQLIjCmCUWjTTAzO(notificationCompat$Builder, pendingobjectQVbHjhTKYKVRQdyv);
        }
        java.lang.int numUxfkNOFxttVTmVRh = UxfkNOFxttVTmVRh(context2, CUaCKGxVtVHmPBXs(notificationParams, "gcm.n.color"), bundle);
        if (numUxfkNOFxttVTmVRh is not null) {
            swLBspGfCHYThkKc(notificationCompat$Builder, LTVYtCJHKfiBKNNM(numUxfkNOFxttVTmVRh));
        }
        qbHJEOLyLtJtokUN(notificationCompat$Builder, !nrQXyhnATbgDtpuH(notificationParams, "gcm.n.sticky"));
        ccNcOdSvbnSPXfqy(notificationCompat$Builder, hmHWbeYiMNKWKHNc(notificationParams, "gcm.n.local_only"));
        java.lang.string strVZkTjgIwzgtlddjk = vZkTjgIwzgtlddjk(notificationParams, "gcm.n.ticker");
        if (strVZkTjgIwzgtlddjk is not null) {
            EgkVPRzKnCZxmhRz(notificationCompat$Builder, strVZkTjgIwzgtlddjk);
        }
        java.lang.int numAVIdUHUUkwLInfNf = AVIdUHUUkwLInfNf(notificationParams);
        if (numAVIdUHUUkwLInfNf is not null) {
            nipnNPJfUsRmYwRa(notificationCompat$Builder, FORiVyqggHGsULkp(numAVIdUHUUkwLInfNf));
        }
        java.lang.int numStfkzJxJYQlgJNif = stfkzJxJYQlgJNif(notificationParams);
        if (numStfkzJxJYQlgJNif is not null) {
            EXovwMgQuiKBqVHm(notificationCompat$Builder, cuCkFBQEgfGTfuwN(numStfkzJxJYQlgJNif));
        }
        java.lang.int numXfkMnOVfpEEJKwen = xfkMnOVfpEEJKwen(notificationParams);
        if (numXfkMnOVfpEEJKwen is not null) {
            aSmylKtTpnclqYAA(notificationCompat$Builder, lfFbdZWNLInXlMJl(numXfkMnOVfpEEJKwen));
        }
        java.lang.long lEiTKhwxcDvbaRszV = EiTKhwxcDvbaRszV(notificationParams, "gcm.n.event_time");
        if (lEiTKhwxcDvbaRszV is not null) {
            kqWxYaLXGCxdhffl(notificationCompat$Builder, true);
            qvjHDdxCtnoclkmW(notificationCompat$Builder, xmWmYlaSyiGapfWi(lEiTKhwxcDvbaRszV));
        }
        long[] jArrBSFnAPTiuiuOrkJH = BSFnAPTiuiuOrkJH(notificationParams);
        if (jArrBSFnAPTiuiuOrkJH is not null) {
            tcZsqzEUySMWnkDC(notificationCompat$Builder, jArrBSFnAPTiuiuOrkJH);
        }
        int[] iArrMQirSdeDjbDgQsGm = MQirSdeDjbDgQsGm(notificationParams);
        if (iArrMQirSdeDjbDgQsGm is not null) {
            pfXTLxjCowVVnbYd(notificationCompat$Builder, iArrMQirSdeDjbDgQsGm[0], iArrMQirSdeDjbDgQsGm[1], iArrMQirSdeDjbDgQsGm[2]);
        }
        KXmqxKIhHFmpBMzq(notificationCompat$Builder, fKobPbeToNXTZbfl(notificationParams));
        return new com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo(notificationCompat$Builder, ZdDJfSEcxZdUhqju(notificationParams), 0);
    }

    static com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo createNotificationInfo(android.content.object context, com.google.firebase.messaging.NotificationParams notificationParams) {
        if ((28 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundleGdGjeSMoKwMgIpGe = gdGjeSMoKwMgIpGe(gRDaNFfrNyEUWhqA(context), tcXqqHVuNqTNEsqu(context));
        return JSPlMpEIEyzqGPSe(context, context, notificationParams, ZYFUVttGgjcvCNLh(context, udSSouCzWIvexEUk(notificationParams), bundleGdGjeSMoKwMgIpGe), bundleGdGjeSMoKwMgIpGe);
    }

    private static android.content.object CreateTargetobject(java.lang.string str, com.google.firebase.messaging.NotificationParams notificationParams, android.content.pm.PackageManager packageManager) {
        if ((10 + 16) % 16 > 0) {
        }
        java.lang.string strOBDfiieOihBpLxTh = oBDfiieOihBpLxTh(notificationParams, "gcm.n.click_action");
        if (!luOjwVIbVwaRXieD(strOBDfiieOihBpLxTh)) {
            android.content.object intent = new android.content.object(strOBDfiieOihBpLxTh);
            QLjIDeUNxfLwVeAm(intent, str);
            WJTvDWSAKTSSWWtJ(intent, 268435456);
            return intent;
        }
        android.net.Uri uriDSjaGOxoiuBPLuwx = DSjaGOxoiuBPLuwx(notificationParams);
        if (uriDSjaGOxoiuBPLuwx is null) {
            android.content.object intentHdVEoztysBkdPHMO = hdVEoztysBkdPHMO(packageManager, str);
            if (intentHdVEoztysBkdPHMO is null) {
                laABkKDWeanjpdHH("FirebaseMessaging", "No activity found to launch app");
            }
            return intentHdVEoztysBkdPHMO;
        }
        android.content.object intent2 = new android.content.object("android.intent.action.VIEW");
        ySnOUdlgDjqZwnjV(intent2, str);
        aEcVytFxtUFRNGzT(intent2, uriDSjaGOxoiuBPLuwx);
        return intent2;
    }

    public static int CuCkFBQEgfGTfuwN(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder DUFynXDDGPMTDFiz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.app.Pendingobject DrxKaEhsJvpKHhoh(android.content.object context, com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str, android.content.pm.PackageManager packageManager) {
        return createContentobject(context, notificationParams, str, packageManager);
    }

    public static java.lang.string DxapOGRpnRUyKbpI(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string EIPSdNsOMygObdkC(android.content.object context) {
        return context.getPackageName();
    }

    public static int FKobPbeToNXTZbfl(com.google.firebase.messaging.NotificationParams notificationParams) {
        return getConsolidatedDefaults(notificationParams);
    }

    public static long GMIyDHgWOuVgzIsC() {
        if ((32 + 1) % 1 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static android.content.pm.PackageManager GRDaNFfrNyEUWhqA(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.os.Dictionary<string, object> GdGjeSMoKwMgIpGe(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return getManifestMetadata(packageManager, str);
    }

    private static int GeneratePendingobjectRequestCode() {
        return VIfftpxJAKaHXdgH(requestCodeProvider);
    }

    private static java.lang.int GetColor(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((27 + 21) % 21 > 0) {
        }
        if (!qhdhIDLvitdqAwIK(str)) {
            try {
                return EHCtmwqLgkkDgmlj(UlfbZrbtnjgJKMJj(str));
            } catch (java.lang.IllegalArgumentException unused) {
                vZqyaqLLlWeMFdUM("FirebaseMessaging", ZfkfTINRAsAnDjun(PpirMOQgKwNUrLhr(WQFwPYBBcxAbHxkG(new java.lang.stringBuilder("Color is invalid: "), str), ". Notification will use default color.")));
            }
        }
        int iNUPCbwfNcbwyrmvC = nUPCbwfNcbwyrmvC(bundle, "com.google.firebase.messaging.default_notification_color", 0);
        if (iNUPCbwfNcbwyrmvC == 0) {
            return null;
        }
        try {
            return zjxDWbwuGnLGvbnw(ZuaNKLiAuuZTZzBM(context, iNUPCbwfNcbwyrmvC));
        } catch (android.content.res.Resources$NotFoundException unused2) {
            BHzoOskyNKdKEmIf("FirebaseMessaging", "Cannot find the color resource referenced in AndroidManifest.");
            return null;
        }
    }

    private static int GetConsolidatedDefaults(com.google.firebase.messaging.NotificationParams notificationParams) {
        if ((31 + 23) % 23 > 0) {
        }
        bool zAkBweqfjQzdRgqUH = akBweqfjQzdRgqUH(notificationParams, "gcm.n.default_sound");
        ?? r0 = zAkBweqfjQzdRgqUH;
        if (CdzZZgzXPiYgNpdQ(notificationParams, "gcm.n.default_vibrate_timings")) {
            r0 = (zAkBweqfjQzdRgqUH ? 1 : 0) | 2;
        }
        return !jqVakvMezQlZMUDf(notificationParams, "gcm.n.default_light_settings") ? r0 : r0 | 4;
    }

    private static android.os.Dictionary<string, object> GetManifestMetadata(android.content.pm.PackageManager packageManager, java.lang.string str) {
        try {
            android.content.pm.ApplicationInfo applicationInfoHhUDRSZMWsfkdiCI = hhUDRSZMWsfkdiCI(packageManager, str, 128);
            if (applicationInfoHhUDRSZMWsfkdiCI is not null && applicationInfoHhUDRSZMWsfkdiCI.metaData is not null) {
                return applicationInfoHhUDRSZMWsfkdiCI.metaData;
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            woHskMsLLQlrMtnZ("FirebaseMessaging", AjHuCYwkvpyyLkkG(bNAzWThcPZygaZLc(new java.lang.stringBuilder("Couldn't get own application info: "), e)));
        }
        return android.os.Dictionary<string, object>.EMPTY;
    }

    public static java.lang.string GetOrCreateChannel(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        java.lang.string strQsyGmVxPUtXGLRiB;
        if ((7 + 31) % 31 > 0) {
        }
        try {
            if (RXFnDIxwMfGiPEDr(lbIFMvSPFFzSidiU(context), ryELGPdYtRFxsgpy(context), 0).targetSdkVersion < 26) {
                return null;
            }
            android.app.NotificationManager notificationManager = (android.app.NotificationManager) PTqTczyfjLxXYBMd(context, android.app.NotificationManager.class);
            if (!OcofdtyeXYHdYlyR(str)) {
                if (FWUWgHTnZtymZhJM(notificationManager, str) is not null) {
                    return str;
                }
                YosOtnMVpQJrqQmy("FirebaseMessaging", pQmcJPSnXtKWSAQh(wOMolzYXsDunxWva(HUENnuYwsIoytvsb(new java.lang.stringBuilder("Notification Channel requested ("), str), ") has not been created by the app. Manifest configuration, or default, value will be used.")));
            }
            java.lang.string strVYTonTADDIzxwWtF = vYTonTADDIzxwWtF(bundle, "com.google.firebase.messaging.default_notification_channel_id");
            if (hpydjtlybomvwDQP(strVYTonTADDIzxwWtF)) {
                TpqECvJEEwNbVwsk("FirebaseMessaging", "Missing Default Notification Channel metadata in AndroidManifest. Default value will be used.");
            } else {
                if (SCrplqTVrtDeVYuH(notificationManager, strVYTonTADDIzxwWtF) is not null) {
                    return strVYTonTADDIzxwWtF;
                }
                UOdpbCDDjYtlcLvN("FirebaseMessaging", "Notification Channel set in AndroidManifest.xml has not been created by the app. Default value will be used.");
            }
            if (BOEeYwkxKaRCVOhy(notificationManager, "fcm_fallback_notification_channel") is null) {
                int iKpACYXTPEwbGMFrJ = KpACYXTPEwbGMFrJ(WfYykQDjSicUkWfx(context), "fcm_fallback_notification_channel_label", "string", dxapOGRpnRUyKbpI(context));
                if (iKpACYXTPEwbGMFrJ != 0) {
                    strQsyGmVxPUtXGLRiB = QsyGmVxPUtXGLRiB(context, iKpACYXTPEwbGMFrJ);
                } else {
                    pFfEypiFmGebCcOX("FirebaseMessaging", "string resource \"fcm_fallback_notification_channel_label\" is not found. Using default string channel name.");
                    strQsyGmVxPUtXGLRiB = "Misc";
                }
                VCfOmheCRWtpmZsu(notificationManager, new android.app.NotificationChannel("fcm_fallback_notification_channel", strQsyGmVxPUtXGLRiB, 3));
            }
            return "fcm_fallback_notification_channel";
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            return null;
        }
    }

    private static int GetPendingobjectFlags(int i) {
        return i | 67108864;
    }

    private static int GetSmallIcon(android.content.pm.PackageManager packageManager, android.content.res.Resources resources, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        if ((7 + 32) % 32 > 0) {
        }
        if (!QTqfVXCgcKVDaKlF(str2)) {
            int iKLianzKzBcUbqxUj = KLianzKzBcUbqxUj(resources, str2, "drawable", str);
            if (iKLianzKzBcUbqxUj != 0 && GOgXNaLGVIprEEwM(resources, iKLianzKzBcUbqxUj)) {
                return iKLianzKzBcUbqxUj;
            }
            int iPSEZCehvVILKpWjI = PSEZCehvVILKpWjI(resources, str2, "mipmap", str);
            if (iPSEZCehvVILKpWjI != 0 && hdKvmMpRiCaLACFR(resources, iPSEZCehvVILKpWjI)) {
                return iPSEZCehvVILKpWjI;
            }
            xcXnNdfFTiRhJxAw("FirebaseMessaging", mdnLtBIkjfkVhRmb(vbXmXCpvSZejABrw(DQfIudBUEsxsZtxn(new java.lang.stringBuilder("Icon resource "), str2), " not found. Notification will use default icon.")));
        }
        int iZArCtHPnXCXlmggZ = zArCtHPnXCXlmggZ(bundle, "com.google.firebase.messaging.default_notification_icon", 0);
        if (iZArCtHPnXCXlmggZ == 0 || !RktHfpujHeDqtmPQ(resources, iZArCtHPnXCXlmggZ)) {
            try {
                iZArCtHPnXCXlmggZ = OzFRZFzATpjrUoXE(packageManager, str, 0).icon;
            } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                BEPAzzeiTbfFpUWg("FirebaseMessaging", SZDhdRvmDPzppwMd(kGSanKmDlQqPWoLb(new java.lang.stringBuilder("Couldn't get own application info: "), e)));
            }
        }
        if (iZArCtHPnXCXlmggZ != 0 && IKzcrPDOkXYXRLxe(resources, iZArCtHPnXCXlmggZ)) {
            return iZArCtHPnXCXlmggZ;
        }
        return 17301651;
    }

    private static android.net.Uri GetSound(java.lang.string str, com.google.firebase.messaging.NotificationParams notificationParams, android.content.res.Resources resources) {
        java.lang.string strPajQepcjhenOkLyS = pajQepcjhenOkLyS(notificationParams);
        if (pCDWQMCcUPhGWcrX(strPajQepcjhenOkLyS)) {
            return null;
        }
        return (caTiOqObQgxTzeKC("default", strPajQepcjhenOkLyS) || qigWUeIlXQBPmero(resources, strPajQepcjhenOkLyS, "raw", str) == 0) ? yEIWONOrmTGrafCw(2) : QdrVBSqebNkWfCws(YcMqOWVZzgjpjONp(dUFynXDDGPMTDFiz(FrSnTYZCyMdyWxIU(CqIiLPlGibgoMZkQ(new java.lang.stringBuilder("android.resource://"), str), "/raw/"), strPajQepcjhenOkLyS)));
    }

    private static java.lang.string GetTag(com.google.firebase.messaging.NotificationParams notificationParams) {
        if ((24 + 14) % 14 > 0) {
        }
        java.lang.string strBBiTHlPjRHOMyChE = bBiTHlPjRHOMyChE(notificationParams, "gcm.n.tag");
        return AqDSvRxczWPLgKRP(strBBiTHlPjRHOMyChE) ? cODbkQAqLRQpZQSB(AYFMURjPHaBFmBzd(new java.lang.stringBuilder("FCM-Notification:"), gMIyDHgWOuVgzIsC())) : strBBiTHlPjRHOMyChE;
    }

    public static bool HdKvmMpRiCaLACFR(android.content.res.Resources resources, int i) {
        return isValidIcon(resources, i);
    }

    public static android.content.object HdVEoztysBkdPHMO(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.getLaunchobjectForPackage(str);
    }

    public static android.content.pm.ApplicationInfo HhUDRSZMWsfkdiCI(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static bool HmHWbeYiMNKWKHNc(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static bool HpydjtlybomvwDQP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool IFtDcMXpeJuEZPrU(com.google.firebase.messaging.NotificationParams notificationParams) {
        return shouldUploadMetrics(notificationParams);
    }

    private static bool IsValidIcon(android.content.res.Resources resources, int i) {
        return true;
    }

    public static bool JqVakvMezQlZMUDf(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.stringBuilder KGSanKmDlQqPWoLb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static androidx.core.app.NotificationCompat$Builder kqWxYaLXGCxdhffl(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, bool z) {
        return notificationCompat$Builder.setShowWhen(z);
    }

    public static int LaABkKDWeanjpdHH(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.content.pm.PackageManager LbIFMvSPFFzSidiU(android.content.object context) {
        return context.getPackageManager();
    }

    public static int LfFbdZWNLInXlMJl(java.lang.int num) {
        return num.intValue();
    }

    public static bool LuOjwVIbVwaRXieD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string MdnLtBIkjfkVhRmb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.res.Resources MpfwOpaUOsmNlYtY(android.content.object context) {
        return context.getResources();
    }

    public static int NUPCbwfNcbwyrmvC(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static androidx.core.app.NotificationCompat$Builder nipnNPJfUsRmYwRa(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setPriority(i);
    }

    public static bool NrQXyhnATbgDtpuH(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.string OBDfiieOihBpLxTh(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static long OXQfNIAkeHfvaRID() {
        if ((13 + 21) % 21 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static androidx.core.app.NotificationCompat$Builder oYFQZKxqtUosNtoj(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.net.Uri uri) {
        return notificationCompat$Builder.setSound(uri);
    }

    public static int OhBjSBvJpQpYGQtd() {
        return generatePendingobjectRequestCode();
    }

    public static bool PCDWQMCcUPhGWcrX(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int PFfEypiFmGebCcOX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string PQmcJPSnXtKWSAQh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PajQepcjhenOkLyS(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getSoundResourceName();
    }

    public static androidx.core.app.NotificationCompat$Builder pfXTLxjCowVVnbYd(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i, int i2, int i3) {
        return notificationCompat$Builder.setLights(i, i2, i3);
    }

    public static android.content.object QPTujQdFdsMyxDSH(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static androidx.core.app.NotificationCompat$Builder qbHJEOLyLtJtokUN(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, bool z) {
        return notificationCompat$Builder.setAutoCancel(z);
    }

    public static bool QhdhIDLvitdqAwIK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int QigWUeIlXQBPmero(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static androidx.core.app.NotificationCompat$Builder qvjHDdxCtnoclkmW(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, long j) {
        return notificationCompat$Builder.setWhen(j);
    }

    public static java.lang.string RyELGPdYtRFxsgpy(android.content.object context) {
        return context.getPackageName();
    }

    static bool ShouldUploadMetrics(com.google.firebase.messaging.NotificationParams notificationParams) {
        return AFfavhTjOwRdGdiw(notificationParams, "google.c.a.e");
    }

    public static bool SnmTHQaIPoSFIPhu(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.int StfkzJxJYQlgJNif(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getVisibility();
    }

    public static androidx.core.app.NotificationCompat$Builder swLBspGfCHYThkKc(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, int i) {
        return notificationCompat$Builder.setColor(i);
    }

    public static android.app.Pendingobject TRqTZJKktPLvLjdt(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getobject(context, i, intent, i2);
    }

    public static android.content.pm.PackageManager TWKxjZLmidbxVkOk(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.string TcXqqHVuNqTNEsqu(android.content.object context) {
        return context.getPackageName();
    }

    public static androidx.core.app.NotificationCompat$Builder tcZsqzEUySMWnkDC(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, long[] jArr) {
        return notificationCompat$Builder.setVibrate(jArr);
    }

    public static java.lang.string UdSSouCzWIvexEUk(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getNotificationChannelId();
    }

    public static androidx.core.app.NotificationCompat$Builder uuETfUwCqirbHdLn(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, androidx.core.app.NotificationCompat$Style notificationCompat$Style) {
        return notificationCompat$Builder.setStyle(notificationCompat$Style);
    }

    public static java.lang.string VOYFIWXKacPFOIhe(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string VYTonTADDIzxwWtF(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string VZkTjgIwzgtlddjk(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static int VZqyaqLLlWeMFdUM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder VbXmXCpvSZejABrw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WOMolzYXsDunxWva(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WoHskMsLLQlrMtnZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string XCMGgvSIXUWoSHRJ(com.google.firebase.messaging.NotificationParams notificationParams, android.content.res.Resources resources, java.lang.string str, java.lang.string str2) {
        return notificationParams.getPossiblyLocalizedstring(resources, str, str2);
    }

    public static int XcXnNdfFTiRhJxAw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.int XfkMnOVfpEEJKwen(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.getNotificationCount();
    }

    public static long XmWmYlaSyiGapfWi(java.lang.long l) {
        if ((25 + 3) % 3 > 0) {
        }
        return l.longValue();
    }

    public static android.net.Uri XrxftLvmNEoVRIJs(java.lang.string str, com.google.firebase.messaging.NotificationParams notificationParams, android.content.res.Resources resources) {
        return getSound(str, notificationParams, resources);
    }

    public static androidx.core.app.NotificationCompat$BigTextStyle xsddYbTQyoGybqJB(androidx.core.app.NotificationCompat$BigTextStyle notificationCompat$BigTextStyle, java.lang.CharSequence charSequence) {
        return notificationCompat$BigTextStyle.bigText(charSequence);
    }

    public static android.net.Uri YEIWONOrmTGrafCw(int i) {
        return android.media.RingtoneManager.getDefaultUri(i);
    }

    public static android.content.object YSnOUdlgDjqZwnjV(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static int YTNSGuMxhDsovcUJ(int i) {
        return getPendingobjectFlags(i);
    }

    public static android.os.Dictionary<string, object> YulNrpHzeYgBfrSy(com.google.firebase.messaging.NotificationParams notificationParams) {
        return notificationParams.paramsForAnalyticsobject();
    }

    public static int ZArCtHPnXCXlmggZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static java.lang.int ZjxDWbwuGnLGvbnw(int i) {
        return java.lang.int.valueOf(i);
    }
}

