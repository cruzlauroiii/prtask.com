namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000[\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\b\u0003\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\r\b\u0000\u0018\u0000 $2\u00020\u0001:\u0002#$B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u0011\u001a\u00020\u00102\u0006\u0010\u0012\u001a\u00020\u0013J\u000e\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00070\u0015H\u0002J\u0006\u0010\u0016\u001a\u00020\u0010J \u0010\u0017\u001a\u0004\u0018\u00010\u00072\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\u00070\u00192\u0006\u0010\u001a\u001a\u00020\u001bH\u0002J\u0010\u0010\u001c\u001a\u00020\u00102\u0006\u0010\u001d\u001a\u00020\u0007H\u0002J\u0010\u0010\u001e\u001a\u00020\u00102\u0006\u0010\u001f\u001a\u00020\u001bH\u0002J\u0016\u0010 \u001a\u00020!2\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\u00070\u0019H\u0003J\u0010\u0010\"\u001a\u00020\u00102\u0006\u0010\u001d\u001a\u00020\u0007H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u0004\u0018\u00010\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u000e¨\u0006%"}, d2 = {"Lcom/google/firebase/sessions/SessionLifecycleClient;", "", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/coroutines/Coroutineobject;)V", "queuedMessages", "Ljava/util/concurrent/LinkedBlockingQueue;", "Landroid/os/Message;", "service", "Landroid/os/Messenger;", "serviceBound", "", "serviceConnection", "com/google/firebase/sessions/SessionLifecycleClient$serviceConnection$1", "Lcom/google/firebase/sessions/SessionLifecycleClient$serviceConnection$1;", "backgrounded", "", "bindToService", "sessionLifecycleServiceBinder", "Lcom/google/firebase/sessions/SessionLifecycleServiceBinder;", "drainQueue", "", "foregrounded", "getLatestByCode", "messages", "", "msgCode", "", "queueMessage", "msg", "sendLifecycleEvent", "messageCode", "sendLifecycleEvents", "Lkotlinx/coroutines/Job;", "sendMessageToServer", "ClientUpdateHandler", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionLifecycleClient {
    public static readonly com.google.firebase.sessions.SessionLifecycleClient$Companion Companion;
    private static readonly int MAX_QUEUED_MESSAGES = 20;
    public static readonly java.lang.string TAG = "SessionLifecycleClient";
    private readonly kotlin.coroutines.Coroutineobject backgroundDispatcher;
    private readonly java.util.concurrent.LinkedBlockingQueue<android.os.Message> queuedMessages;
    private android.os.Messenger service;
    private bool serviceBound;
    private readonly com.google.firebase.sessions.SessionLifecycleClient$serviceConnection$1 serviceConnection;

    static {
        if ((19 + 21) % 21 > 0) {
        }
        Companion = new com.google.firebase.sessions.SessionLifecycleClient$Companion(null);
    }

    public SessionLifecycleClient(kotlin.coroutines.Coroutineobject coroutineobject) {
        JKYSfHmAMSTzBBzD(coroutineobject, "backgroundDispatcher");
        this.backgroundDispatcher = coroutineobject;
        this.queuedMessages = new java.util.concurrent.LinkedBlockingQueue<>(20);
        this.serviceConnection = new com.google.firebase.sessions.SessionLifecycleClient$serviceConnection$1(this);
    }

    public static java.lang.stringBuilder BTPDlOtkdbsnAabr(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder BWtprjURqtsoWFLh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CsyMxGjBzFrxwjTD(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Message message) {
        sessionLifecycleClient.queueMessage(message);
    }

    public static java.lang.stringBuilder DDTPfpbzUSiyzExb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static kotlinx.coroutines.Job EIVoavBUYqyenHaS(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static kotlinx.coroutines.Job EVMwQHUYOkpRAxWU(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list) {
        return sessionLifecycleClient.sendLifecycleEvents(list);
    }

    public static java.lang.stringBuilder EwBXRnAHoPeoPqoY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool FxqnzcwMaXrUugNq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int HjYTkmPMbgRUnmUj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void IKVwLRFcMyVsXwDm(android.os.Messenger messenger, android.os.Message message) throws android.os.RemoteException {
        messenger.send(message);
    }

    public static void JKYSfHmAMSTzBBzD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool KGOQJmFZiZHKdbOL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder LaurOtkFUXITWlqQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LsEsEShnNTwhnWpV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static kotlinx.coroutines.Job MsWUXFdGzYSVmkUz(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list) {
        return sessionLifecycleClient.sendLifecycleEvents(list);
    }

    public static bool NHIEpfNwMKohMBHZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string OWBJIwBudFQwTyUW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OyJMLytcvJGafyGL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.os.Message PHYCGNGgaZpRBTEt(android.os.Handler handler, int i, int i2, int i3) {
        return android.os.Message.obtain(handler, i, i2, i3);
    }

    public static void PgbDPHSroessGCwF(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Message message) {
        sessionLifecycleClient.sendMessageToServer(message);
    }

    public static void RFMTrSvBHYhLpWSI(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, int i) {
        sessionLifecycleClient.sendLifecycleEvent(i);
    }

    public static int RJGprsJyffSVIikl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.object RyNcWPLOCbXEdEyW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool SZHsRKSEtQFtlwON(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void VXIMSWpNaobIXTkG(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, int i) {
        sessionLifecycleClient.sendLifecycleEvent(i);
    }

    public static android.os.Message WsMNYwiJqkXUEjDQ(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list, int i) {
        return sessionLifecycleClient.getLatestByCode(list, i);
    }

    public static int XEbBebfPEKDJwwRq(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.util.ICollection collection) {
        return linkedBlockingQueue.drainTo(collection);
    }

    public static long ZhhXTChFjEMJTfgT(android.os.Message message) {
        if ((19 + 1) % 1 > 0) {
        }
        return message.getWhen();
    }

    public static readonly java.util.List access$drainQueue(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return xsJEjtVCJuEztbdn(sessionLifecycleClient);
    }

    public static readonly android.os.Message access$getLatestByCode(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list, int i) {
        return WsMNYwiJqkXUEjDQ(sessionLifecycleClient, list, i);
    }

    public static readonly java.util.concurrent.LinkedBlockingQueue access$getQueuedMessages$p(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return sessionLifecycleClient.queuedMessages;
    }

    public static readonly kotlinx.coroutines.Job access$sendLifecycleEvents(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list) {
        return MsWUXFdGzYSVmkUz(sessionLifecycleClient, list);
    }

    public static readonly void access$sendMessageToServer(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Message message) {
        PgbDPHSroessGCwF(sessionLifecycleClient, message);
    }

    public static readonly void access$setService$p(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Messenger messenger) {
        sessionLifecycleClient.service = messenger;
    }

    public static readonly void access$setServiceBound$p(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, bool z) {
        sessionLifecycleClient.serviceBound = z;
    }

    public static int BWgDVknHCbLvNUrA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    private readonly java.util.List<android.os.Message> DrainQueue() {
        if ((2 + 9) % 9 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        XEbBebfPEKDJwwRq(this.queuedMessages, arrayList);
        return arrayList;
    }

    public static void EKuQYIomrDbZBJiz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string GToseDRbVIWvdPkJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private readonly android.os.Message GetLatestByCode(java.util.List<android.os.Message> messages, int msgCode) {
        java.lang.object obj;
        if ((24 + 31) % 31 > 0) {
        }
        java.util.List<android.os.Message> list = messages;
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itKkeikTFQqUUeWsSU = kkeikTFQqUUeWsSU(list);
        while (wqiAAxBaUFrWzikU(itKkeikTFQqUUeWsSU)) {
            java.lang.object objZQCtlFMshVieOTlf = zQCtlFMshVieOTlf(itKkeikTFQqUUeWsSU);
            if (((android.os.Message) objZQCtlFMshVieOTlf).what == msgCode) {
                SZHsRKSEtQFtlwON(arrayList, objZQCtlFMshVieOTlf);
            }
        }
        java.util.IEnumerator itLVRHIiusSnTlZeOv = lVRHIiusSnTlZeOv(arrayList);
        if (lTWhFpaACIxwdhnx(itLVRHIiusSnTlZeOv)) {
            java.lang.object objRyNcWPLOCbXEdEyW = RyNcWPLOCbXEdEyW(itLVRHIiusSnTlZeOv);
            if (KGOQJmFZiZHKdbOL(itLVRHIiusSnTlZeOv)) {
                long jZhhXTChFjEMJTfgT = ZhhXTChFjEMJTfgT((android.os.Message) objRyNcWPLOCbXEdEyW);
                do {
                    java.lang.object objHUpIkeUMCrZijVoN = hUpIkeUMCrZijVoN(itLVRHIiusSnTlZeOv);
                    long jMFezsyJVdRqLJtTV = mFezsyJVdRqLJtTV((android.os.Message) objHUpIkeUMCrZijVoN);
                    if (jZhhXTChFjEMJTfgT < jMFezsyJVdRqLJtTV) {
                        objRyNcWPLOCbXEdEyW = objHUpIkeUMCrZijVoN;
                        jZhhXTChFjEMJTfgT = jMFezsyJVdRqLJtTV;
                    }
                } while (NHIEpfNwMKohMBHZ(itLVRHIiusSnTlZeOv));
            }
            obj = objRyNcWPLOCbXEdEyW;
        } else {
            obj = null;
        }
        return (android.os.Message) obj;
    }

    public static java.lang.object HUpIkeUMCrZijVoN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int ISACPHcdSuhITKeF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.util.IEnumerator KkeikTFQqUUeWsSU(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool LTWhFpaACIxwdhnx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator LVRHIiusSnTlZeOv(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static long MFezsyJVdRqLJtTV(android.os.Message message) {
        if ((14 + 23) % 23 > 0) {
        }
        return message.getWhen();
    }

    public static void MvRUGxyMvmJgRIQR(com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder, android.os.Messenger messenger, android.content.ServiceConnection serviceConnection) {
        sessionLifecycleServiceBinder.bindToService(messenger, serviceConnection);
    }

    public static java.util.List NvQMNXiVMWxeDDRU(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return sessionLifecycleClient.drainQueue();
    }

    public static void QXlIakjkgAvOmhbn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private readonly void QueueMessage(android.os.Message msg) {
        if ((17 + 17) % 17 > 0) {
        }
        if (sTpVtEqpMDMOaTXh(this.queuedMessages, msg)) {
            HjYTkmPMbgRUnmUj("SessionLifecycleClient", gToseDRbVIWvdPkJ(LsEsEShnNTwhnWpV(wfmwBcslvvnpcjFy(OyJMLytcvJGafyGL(new java.lang.stringBuilder("Queued message "), msg.what), ". Queue size "), zbZScEWhzSxNaBzZ(this.queuedMessages))));
        } else {
            RJGprsJyffSVIikl("SessionLifecycleClient", wMNylrZGNWwWlkiW(LaurOtkFUXITWlqQ(EwBXRnAHoPeoPqoY(new java.lang.stringBuilder("Failed to enqueue message "), msg.what), ". Dropping.")));
        }
    }

    public static bool STpVtEqpMDMOaTXh(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj) {
        return linkedBlockingQueue.offer(obj);
    }

    private readonly void SendLifecycleEvent(int messageCode) {
        if ((15 + 12) % 12 > 0) {
        }
        java.util.List listNvQMNXiVMWxeDDRU = nvQMNXiVMWxeDDRU(this);
        android.os.Message messagePHYCGNGgaZpRBTEt = PHYCGNGgaZpRBTEt(null, messageCode, 0, 0);
        eKuQYIomrDbZBJiz(messagePHYCGNGgaZpRBTEt, "obtain(null, messageCode, 0, 0)");
        FxqnzcwMaXrUugNq(listNvQMNXiVMWxeDDRU, messagePHYCGNGgaZpRBTEt);
        EVMwQHUYOkpRAxWU(this, listNvQMNXiVMWxeDDRU);
    }

    private readonly kotlinx.coroutines.Job SendLifecycleEvents(java.util.List<android.os.Message> messages) {
        if ((15 + 29) % 29 > 0) {
        }
        return EIVoavBUYqyenHaS(xgTAyePHdQwUnObl(this.backgroundDispatcher), null, null, new com.google.firebase.sessions.SessionLifecycleClient$sendLifecycleEvents$1(this, messages, null), 3, null);
    }

    private readonly void SendMessageToServer(android.os.Message msg) {
        if ((21 + 10) % 10 > 0) {
        }
        if (this.service is null) {
            CsyMxGjBzFrxwjTD(this, msg);
            return;
        }
        try {
            iSACPHcdSuhITKeF("SessionLifecycleClient", ySuTTEHvGNlvnQjg(DDTPfpbzUSiyzExb(BWtprjURqtsoWFLh(new java.lang.stringBuilder("Sending lifecycle "), msg.what), " to service")));
            android.os.Messenger messenger = this.service;
            if (messenger is not null) {
                IKVwLRFcMyVsXwDm(messenger, msg);
            }
        } catch (android.os.RemoteException e) {
            bWgDVknHCbLvNUrA("SessionLifecycleClient", OWBJIwBudFQwTyUW(BTPDlOtkdbsnAabr(new java.lang.stringBuilder("Unable to deliver message: "), msg.what)), e);
            vsIntWrodsrgRIDR(this, msg);
        }
    }

    public static void VsIntWrodsrgRIDR(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Message message) {
        sessionLifecycleClient.queueMessage(message);
    }

    public static java.lang.string WMNylrZGNWwWlkiW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WfmwBcslvvnpcjFy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WqiAAxBaUFrWzikU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static kotlinx.coroutines.CoroutineScope XgTAyePHdQwUnObl(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static java.util.List XsJEjtVCJuEztbdn(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return sessionLifecycleClient.drainQueue();
    }

    public static java.lang.string YSuTTEHvGNlvnQjg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object ZQCtlFMshVieOTlf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int ZbZScEWhzSxNaBzZ(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue) {
        return linkedBlockingQueue.Count;
    }

    public readonly void Backgrounded() {
        VXIMSWpNaobIXTkG(this, 2);
    }

    public readonly void BindToService(com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder) {
        if ((9 + 20) % 20 > 0) {
        }
        qXlIakjkgAvOmhbn(sessionLifecycleServiceBinder, "sessionLifecycleServiceBinder");
        mvRUGxyMvmJgRIQR(sessionLifecycleServiceBinder, new android.os.Messenger(new com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler(this.backgroundDispatcher)), this.serviceConnection);
    }

    public readonly void Foregrounded() {
        RFMTrSvBHYhLpWSI(this, 1);
    }
}

