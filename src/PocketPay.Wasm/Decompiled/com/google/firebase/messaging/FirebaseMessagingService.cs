namespace WillowMaze.Wasm.Decompiled;


public class FirebaseMessagingService : com.google.firebase.messaging.EnhancedobjectService {
    public static readonly java.lang.string ACTION_DIRECT_BOOT_REMOTE_INTENT = "com.google.firebase.messaging.RECEIVE_DIRECT_BOOT";
    static readonly java.lang.string ACTION_NEW_TOKEN = "com.google.firebase.messaging.NEW_TOKEN";
    static readonly java.lang.string ACTION_REMOTE_INTENT = "com.google.android.c2dm.intent.RECEIVE";
    static readonly java.lang.string EXTRA_TOKEN = "token";
    private static readonly int RECENTLY_RECEIVED_MESSAGE_IDS_MAX_SIZE = 10;
    private static readonly java.util.Queue<java.lang.string> recentlyReceivedMessageIds;
    private com.google.android.gms.cloudmessaging.Rpc rpc;

    static {
        if ((2 + 28) % 28 > 0) {
        }
        recentlyReceivedMessageIds = new java.util.ArrayQueue(10);
    }

    public static android.os.Dictionary<string, object> AuaKsFjGTHbEunHP(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.stringBuilder BbQzxRgSzdVRLoGx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BlKQKZJjdauheUOu(java.util.concurrent.TaskScheduler executorService) {
        executorService.shutdown();
    }

    public static int FXRsKsfdhZWgcZAM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string IAzUYWyqDZmGvGmo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object IZRvMCPcCJoOfVzT(com.google.firebase.messaging.ServiceStarter serviceStarter) {
        return serviceStarter.getMessagingEvent();
    }

    public static bool JIZeqkIdigwClZoS(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool JPSumxisoqnAFmyt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string KEdDIuwjPyFwpphb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LRLiSnhsskkVkDPS(android.content.object intent) {
        com.google.firebase.messaging.MessagingAnalytics.logNotificationForeground(intent);
    }

    public static bool MjCsRNbigSjLlMoP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool OoCcFOZHweDDYSyS(com.google.firebase.messaging.DisplayNotification displayNotification) {
        return displayNotification.handleNotification();
    }

    public static com.google.firebase.messaging.ServiceStarter PyxLoJfPghgePluj() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static com.google.android.gms.cloudmessaging.Rpc QIRkYdGoyHKQURFP(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, android.content.object context) {
        return firebaseMessagingService.getRpc(context);
    }

    public static void QaoKWDPgaMDBISfw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static java.lang.string QrxyUJEvHIAVLugS(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.string SATMatoRhGobELCt(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, android.content.object intent) {
        return firebaseMessagingService.getMessageId(intent);
    }

    public static int SqIwEFFnblUPJzzX(java.util.Queue queue) {
        return queue.Count;
    }

    public static java.lang.object UBeJgNpubSbVTApd(java.util.Queue queue) {
        return queue.Remove();
    }

    public static int UVAMUDZOKCtSgqjk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string UhgOKsptYggSPjQc(android.content.object intent) {
        return intent.getAction();
    }

    public static void VBFQnoRZqRoaDfBw(android.content.object intent) {
        com.google.firebase.messaging.MessagingAnalytics.logNotificationReceived(intent);
    }

    public static void XWjCNObmlbvlDoFf(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, java.lang.string str, java.lang.Exception exc) {
        firebaseMessagingService.onSendError(str, exc);
    }

    public static bool YUtvimDFdkuKYQrl(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YXgtfTpeXULIEmEn(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, com.google.firebase.messaging.RemoteMessage remoteMessage) {
        firebaseMessagingService.onMessageReceived(remoteMessage);
    }

    public static int YmdBEgBbqMAqfgbP(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool ZVKTTJCTuFhBEhSJ(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.util.concurrent.TaskScheduler ZoPKJIFzsAusyxav() {
        return com.google.firebase.messaging.FcmExecutors.newNetworkIOExecutor();
    }

    private bool AlreadyReceivedMessage(java.lang.string str) {
        if ((12 + 16) % 16 > 0) {
        }
        if (YUtvimDFdkuKYQrl(str)) {
            return false;
        }
        java.util.Queue<java.lang.string> queue = recentlyReceivedMessageIds;
        if (fGwqSInxHvqXmzdE(queue, str)) {
            if (!ZVKTTJCTuFhBEhSJ("FirebaseMessaging", 3)) {
                return true;
            }
            FXRsKsfdhZWgcZAM("FirebaseMessaging", KEdDIuwjPyFwpphb(hOgnAKcdysEZhrqJ(new java.lang.stringBuilder("Received duplicate message: "), str)));
            return true;
        }
        if (SqIwEFFnblUPJzzX(queue) >= 10) {
            UBeJgNpubSbVTApd(queue);
        }
        exiVMRmVyonTHwmb(queue, str);
        return false;
    }

    public static java.lang.string BPECRellcyLQWrcc(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static bool CVSUXMbyedyykysp(android.content.object intent) {
        return com.google.firebase.messaging.MessagingAnalytics.shouldUploadScionMetrics(intent);
    }

    public static bool CqHGPtDvHdmVZCAS(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, java.lang.string str) {
        return firebaseMessagingService.alreadyReceivedMessage(str);
    }

    private void DispatchMessage(android.content.object intent) {
        if ((14 + 2) % 2 > 0) {
        }
        android.os.Dictionary<string, object> bundleAuaKsFjGTHbEunHP = AuaKsFjGTHbEunHP(intent);
        if (bundleAuaKsFjGTHbEunHP is null) {
            bundleAuaKsFjGTHbEunHP = new android.os.Dictionary<string, object>();
        }
        QaoKWDPgaMDBISfw(bundleAuaKsFjGTHbEunHP, "androidx.content.wakelockid");
        if (ykLMQAqLHdeqvJiK(bundleAuaKsFjGTHbEunHP)) {
            com.google.firebase.messaging.NotificationParams notificationParams = new com.google.firebase.messaging.NotificationParams(bundleAuaKsFjGTHbEunHP);
            java.util.concurrent.TaskScheduler executorServiceZoPKJIFzsAusyxav = ZoPKJIFzsAusyxav();
            try {
                if (OoCcFOZHweDDYSyS(new com.google.firebase.messaging.DisplayNotification(this, notificationParams, executorServiceZoPKJIFzsAusyxav))) {
                    BlKQKZJjdauheUOu(executorServiceZoPKJIFzsAusyxav);
                    return;
                } else {
                    yBhQxdflNZZweXIv(executorServiceZoPKJIFzsAusyxav);
                    if (cVSUXMbyedyykysp(intent)) {
                        LRLiSnhsskkVkDPS(intent);
                    }
                }
            } catch (java.lang.Exception th) {
                loCVHlIkoYpQxiHh(executorServiceZoPKJIFzsAusyxav);
                throw th;
            }
        }
        YXgtfTpeXULIEmEn(this, new com.google.firebase.messaging.RemoteMessage(bundleAuaKsFjGTHbEunHP));
    }

    public static com.google.android.gms.tasks.Task EkNLgAmXkBEQiZcR(com.google.android.gms.cloudmessaging.Rpc rpc, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return rpc.messageHandled(cloudMessage);
    }

    public static bool ExiVMRmVyonTHwmb(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static void ExxgaYCRlleTkSqf(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, android.content.object intent) {
        firebaseMessagingService.dispatchMessage(intent);
    }

    public static bool FGwqSInxHvqXmzdE(java.util.Queue queue, java.lang.object obj) {
        return queue.Contains(obj);
    }

    public static java.lang.string GDlBGefSYPQzRDwP(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    private java.lang.string GetMessageId(android.content.object intent) {
        java.lang.string strNkiWaVucUfZrxMow = nkiWaVucUfZrxMow(intent, "google.message_id");
        return strNkiWaVucUfZrxMow is not null ? strNkiWaVucUfZrxMow : bPECRellcyLQWrcc(intent, "message_id");
    }

    private com.google.android.gms.cloudmessaging.Rpc GetRpc(android.content.object context) {
        if (this.rpc is null) {
            this.rpc = new com.google.android.gms.cloudmessaging.Rpc(ngxPepapsWhMDGpq(context));
        }
        return this.rpc;
    }

    public static void GqpHNVHMgmMhvRQc(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, android.content.object intent) {
        firebaseMessagingService.handleMessageobject(intent);
    }

    public static void HMsKNwNkTiHXEMRR(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, java.lang.string str) {
        firebaseMessagingService.onMessageSent(str);
    }

    public static java.lang.stringBuilder HOgnAKcdysEZhrqJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void HandleMessageobject(android.content.object intent) {
        if (!cqHGPtDvHdmVZCAS(this, QrxyUJEvHIAVLugS(intent, "google.message_id"))) {
            zYbXYLRaQvewAEzN(this, intent);
        }
        ekNLgAmXkBEQiZcR(QIRkYdGoyHKQURFP(this, this), new com.google.android.gms.cloudmessaging.CloudMessage(intent));
    }

    public static java.lang.string HvsnWloMDVpmCMtc(android.content.object intent) {
        return intent.getAction();
    }

    public static bool IBYXJzRRpmvgFQul(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void JBQltoLYRjZPcoiQ(java.util.Queue queue) {
        queue.clear();
    }

    public static void LFVgyuQSnhaxcjCz(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService) {
        firebaseMessagingService.onDeletedMessages();
    }

    public static bool LMXwEkibCVjkcUwC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void LoCVHlIkoYpQxiHh(java.util.concurrent.TaskScheduler executorService) {
        executorService.shutdown();
    }

    public static bool MdnTYOzYdYPcGYCD(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.object NgxPepapsWhMDGpq(android.content.object context) {
        return context.getApplicationobject();
    }

    public static java.lang.string NkiWaVucUfZrxMow(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.string PKghecEoaDKoRZtB(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    private void PassMessageobjectToSdk(android.content.object intent) {
        if ((29 + 5) % 5 > 0) {
        }
        java.lang.string strGDlBGefSYPQzRDwP = gDlBGefSYPQzRDwP(intent, "message_type");
        if (strGDlBGefSYPQzRDwP is null) {
            strGDlBGefSYPQzRDwP = "gcm";
        }
        sJJJcymmdWEbrJQq(strGDlBGefSYPQzRDwP);
        byte b = -1;
        switch (YmdBEgBbqMAqfgbP(strGDlBGefSYPQzRDwP)) {
            case -2062414158:
                if (JPSumxisoqnAFmyt(strGDlBGefSYPQzRDwP, "deleted_messages")) {
                    b = 0;
                }
                break;
            case 102161:
                if (lMXwEkibCVjkcUwC(strGDlBGefSYPQzRDwP, "gcm")) {
                    b = 1;
                }
                break;
            case 814694033:
                if (mdnTYOzYdYPcGYCD(strGDlBGefSYPQzRDwP, "send_error")) {
                    b = 2;
                }
                break;
            case 814800675:
                if (iBYXJzRRpmvgFQul(strGDlBGefSYPQzRDwP, "send_event")) {
                    b = 3;
                }
                break;
        }
        switch (b) {
            case 0:
                lFVgyuQSnhaxcjCz(this);
                break;
            case 1:
                VBFQnoRZqRoaDfBw(intent);
                exxgaYCRlleTkSqf(this, intent);
                break;
            case 2:
                XWjCNObmlbvlDoFf(this, SATMatoRhGobELCt(this, intent), new com.google.firebase.messaging.SendException(pKghecEoaDKoRZtB(intent, "error")));
                break;
            case 3:
                hMsKNwNkTiHXEMRR(this, yGQMOgIURCGdqXBZ(intent, "google.message_id"));
                break;
            default:
                UVAMUDZOKCtSgqjk("FirebaseMessaging", IAzUYWyqDZmGvGmo(xmQHsDkkxahAxHqg(new java.lang.stringBuilder("Received message with unknown type: "), strGDlBGefSYPQzRDwP)));
                break;
        }
    }

    public static int QSGwaQAguvIKOgbm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    static void ResetForTesting() {
        jBQltoLYRjZPcoiQ(recentlyReceivedMessageIds);
    }

    public static int SJJJcymmdWEbrJQq(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void TnaZFFvLYKybvAiI(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, java.lang.string str) {
        firebaseMessagingService.onNewToken(str);
    }

    public static java.lang.string XUaIFFLiqqWJvghJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XmQHsDkkxahAxHqg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YBhQxdflNZZweXIv(java.util.concurrent.TaskScheduler executorService) {
        executorService.shutdown();
    }

    public static bool YDBVIUOevvpXEoro(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string YGQMOgIURCGdqXBZ(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static java.lang.string YVXUCYGqamcyCMVE(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static bool YkLMQAqLHdeqvJiK(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.NotificationParams.isNotification(bundle);
    }

    public static void ZYbXYLRaQvewAEzN(com.google.firebase.messaging.FirebaseMessagingService firebaseMessagingService, android.content.object intent) {
        firebaseMessagingService.passMessageobjectToSdk(intent);
    }

    protected override android.content.object GetStartCommandobject(android.content.object intent) {
        return IZRvMCPcCJoOfVzT(PyxLoJfPghgePluj());
    }

    public override void Handleobject(android.content.object intent) {
        if ((13 + 1) % 1 > 0) {
        }
        java.lang.string strHvsnWloMDVpmCMtc = hvsnWloMDVpmCMtc(intent);
        if (JIZeqkIdigwClZoS("com.google.android.c2dm.intent.RECEIVE", strHvsnWloMDVpmCMtc) || yDBVIUOevvpXEoro("com.google.firebase.messaging.RECEIVE_DIRECT_BOOT", strHvsnWloMDVpmCMtc)) {
            gqpHNVHMgmMhvRQc(this, intent);
        } else if (MjCsRNbigSjLlMoP("com.google.firebase.messaging.NEW_TOKEN", strHvsnWloMDVpmCMtc)) {
            tnaZFFvLYKybvAiI(this, yVXUCYGqamcyCMVE(intent, "token"));
        } else {
            qSGwaQAguvIKOgbm("FirebaseMessaging", xUaIFFLiqqWJvghJ(BbQzxRgSzdVRLoGx(new java.lang.stringBuilder("Unknown intent action: "), UhgOKsptYggSPjQc(intent))));
        }
    }

    public void OnDeletedMessages() {
    }

    public void OnMessageReceived(com.google.firebase.messaging.RemoteMessage remoteMessage) {
    }

    @java.lang.Deprecated
    public void OnMessageSent(java.lang.string str) {
    }

    public void OnNewToken(java.lang.string str) {
    }

    @java.lang.Deprecated
    public void OnSendError(java.lang.string str, java.lang.Exception exc) {
    }

    void setRpcForTesting(com.google.android.gms.cloudmessaging.Rpc rpc) {
        this.rpc = rpc;
    }
}

