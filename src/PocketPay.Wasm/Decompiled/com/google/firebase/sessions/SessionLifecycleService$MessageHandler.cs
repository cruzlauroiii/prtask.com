namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\r\u001a\u00020\u000eH\u0002J\u0010\u0010\u000f\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u0011H\u0002J\u0010\u0010\u0012\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u0011H\u0002J\u0010\u0010\u0013\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u0011H\u0002J\u0010\u0010\u0014\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0015\u001a\u00020\n2\u0006\u0010\u0016\u001a\u00020\fH\u0002J\u0010\u0010\u0017\u001a\u00020\u000e2\u0006\u0010\u0018\u001a\u00020\u0007H\u0002J\b\u0010\u0019\u001a\u00020\u000eH\u0002J\u0018\u0010\u001a\u001a\u00020\u000e2\u0006\u0010\u0018\u001a\u00020\u00072\u0006\u0010\u001b\u001a\u00020\u001cH\u0002R\u001e\u0010\u0005\u001a\u0012\u0012\u0004\u0012\u00020\u00070\u0006j\b\u0012\u0004\u0012\u00020\u0007`\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lcom/google/firebase/sessions/SessionLifecycleService$MessageHandler;", "Landroid/os/Handler;", "looper", "Landroid/os/Looper;", "(Landroid/os/Looper;)V", "boundClients", "Ljava/util/List;", "Landroid/os/Messenger;", "Lkotlin/collections/List;", "hasForegrounded", "", "lastMsgTimeMs", "", "broadcastSession", "", "handleBackgrounding", "msg", "Landroid/os/Message;", "handleClientBound", "handleForegrounding", "handleMessage", "isSessionRestart", "foregroundTimeMs", "maybeSendSessionToClient", "client", "newSession", "sendSessionToClient", "sessionId", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionLifecycleService$MessageHandler : android.os.Handler {
    private readonly java.util.List<android.os.Messenger> boundClients;
    private bool hasForegrounded;
    private long lastMsgTimeMs;

    public SessionLifecycleService$MessageHandler(android.os.Looper looper) {
        super(looper);
        pQBAXYIcRUTymwgk(looper, "looper");
        this.boundClients = new java.util.List<>();
    }

    public static int ANeZrjOeiLjZagnD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static com.google.firebase.sessions.SessionDatastore CGfrlfkneIDYcekR(com.google.firebase.sessions.SessionDatastore$Companion sessionDatastore$Companion) {
        return sessionDatastore$Companion.getInstance();
    }

    public static int CJpNGtZgXVPemMex(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static long DojchbgfMEwDmrLM(android.os.Message message) {
        if ((30 + 20) % 20 > 0) {
        }
        return message.getWhen();
    }

    public static java.lang.stringBuilder EHYPSpNjZEHatLiH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings FPLRddAbyCOAHvOr(com.google.firebase.sessions.settings.SessionsHashSettings$Companion sessionsHashSettings$Companion) {
        return sessionsHashSettings$Companion.getInstance();
    }

    public static java.lang.stringBuilder FgwXxMkAJjlhEgzN(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void FvwztNwooLfGQFZx(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Message message) {
        sessionLifecycleService$MessageHandler.handleClientBound(message);
    }

    public static java.lang.string GIyCmdWaRJllfbgP(com.google.firebase.sessions.SessionDatastore sessionDatastore) {
        return sessionDatastore.getCurrentSessionId();
    }

    public static void GpAvHvOCLokCvgGE(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.stringBuilder HNmnahexcBLLtXvC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.sessions.SessionDetails HVbwDItyKbHwnlqe(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.getCurrentSession();
    }

    public static java.lang.stringBuilder IHSANHZWbomJnxzx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void IkfGNaQQZSMqpRtw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder IpPAhavAieqfTYxv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool JnitGbBGZVPHbVbG(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static int KZSHfxrarEBSSaCs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool KfPdrPWQvBGRNYYS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder LrAzloDtmrRIyLDT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MPxIIIvYBPpfLbVc(com.google.firebase.sessions.SessionDetails sessionDetails) {
        return sessionDetails.getSessionId();
    }

    public static com.google.firebase.sessions.SessionDetails NZZGGDimVyeHNZus(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.generateNewSession();
    }

    public static void NaFwfmkYQpnhwzwQ(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Messenger messenger, java.lang.string str) {
        sessionLifecycleService$MessageHandler.sendSessionToClient(messenger, str);
    }

    public static int NvxyWoaPoNrFZpKo(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int NwQnMdetyErxwHnS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.stringBuilder OBRQkWyyFUGptYcG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static long OHOzUZSIsYslnldy(android.os.Message message) {
        if ((9 + 7) % 7 > 0) {
        }
        return message.getWhen();
    }

    public static void OZMwJnjYZJtszkqJ(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler) {
        sessionLifecycleService$MessageHandler.newSession();
    }

    public static long OewKSNXdxsCKYedx(android.os.Message message) {
        if ((28 + 26) % 26 > 0) {
        }
        return message.getWhen();
    }

    public static int OpmcyMjaunqtCtvX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder PdHrkQVzLNcYoGhX(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int QbUVbYyGQNjbcLKD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string RTNqRKykNmfXUSBw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SmNGTjuoNIUWbQNX(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler) {
        sessionLifecycleService$MessageHandler.broadcastSession();
    }

    public static void TESiKSIGUDQkePZe(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Messenger messenger) {
        sessionLifecycleService$MessageHandler.maybeSendSessionToClient(messenger);
    }

    public static void TsSfGlclbFUEEvlQ(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Message message) {
        sessionLifecycleService$MessageHandler.handleForegrounding(message);
    }

    public static java.lang.stringBuilder TzBDgSGHdMiyLEbq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.os.Message UWVLNZozqpxTPdgs(android.os.Handler handler, int i, int i2, int i3) {
        return android.os.Message.obtain(handler, i, i2, i3);
    }

    public static void UiwmywVhcsmqbGmP(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Messenger messenger) {
        sessionLifecycleService$MessageHandler.maybeSendSessionToClient(messenger);
    }

    public static java.lang.string VBElmLiXoGTBbKAO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long VfRbUbiAPZNcyAXr(android.os.Message message) {
        if ((13 + 14) % 14 > 0) {
        }
        return message.getWhen();
    }

    public static java.lang.stringBuilder VfipZfPsBroCmGdE(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static com.google.firebase.sessions.SessionGenerator VncOGDlBOfWiEtKY(com.google.firebase.sessions.SessionGenerator$Companion sessionGenerator$Companion) {
        return sessionGenerator$Companion.getInstance();
    }

    public static com.google.firebase.sessions.SessionGenerator WooGyXUyKzCPMctg(com.google.firebase.sessions.SessionGenerator$Companion sessionGenerator$Companion) {
        return sessionGenerator$Companion.getInstance();
    }

    public static com.google.firebase.sessions.SessionGenerator XAYZUnSityaAdRql(com.google.firebase.sessions.SessionGenerator$Companion sessionGenerator$Companion) {
        return sessionGenerator$Companion.getInstance();
    }

    public static java.lang.string XuDGxKTrFihQkfZH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XvglhmTnnUJilHXw(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool YMDvjCRCBiNcwNbR(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, long j) {
        return sessionLifecycleService$MessageHandler.isSessionRestart(j);
    }

    public static int YySyRhqBFGPjKApO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder ZGTMFZctGyVlcFHs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static long ZckkasBYGoYkOXYi(android.os.Message message) {
        if ((9 + 24) % 24 > 0) {
        }
        return message.getWhen();
    }

    public static void BHucOHZFjSOuUHGH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void BbdZKWizetGwEGte(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Message message) {
        sessionLifecycleService$MessageHandler.handleBackgrounding(message);
    }

    public static com.google.firebase.sessions.SessionDetails BlbviddPnAPtLvlL(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.getCurrentSession();
    }

    private readonly void BroadcastSession() {
        if ((21 + 6) % 6 > 0) {
        }
        pzbyrIvlizSFXlei("SessionLifecycleService", "Broadcasting new session");
        lscVSCeDBIdlqVvu(iDPxejjyxmjeMEMi(com.google.firebase.sessions.SessionFirelogPublisher.Companion), HVbwDItyKbHwnlqe(WooGyXUyKzCPMctg(com.google.firebase.sessions.SessionGenerator.Companion)));
        java.util.IEnumerator itTlADYeFMGanaluMR = tlADYeFMGanaluMR(new java.util.List(this.boundClients));
        while (KfPdrPWQvBGRNYYS(itTlADYeFMGanaluMR)) {
            android.os.Messenger messenger = (android.os.Messenger) gmjFWKTTGSmGqjGK(itTlADYeFMGanaluMR);
            gyVHhqbPvxJerCWG(messenger, "it");
            TESiKSIGUDQkePZe(this, messenger);
        }
    }

    public static int CvirgQLPFMPcNwHl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static long CyBravszolyxfkkA(android.os.Message message) {
        if ((22 + 18) % 18 > 0) {
        }
        return message.getWhen();
    }

    public static java.lang.stringBuilder DOQSfznCfULAORaC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string DPWXDMYCkQjBRbxn(com.google.firebase.sessions.SessionDetails sessionDetails) {
        return sessionDetails.getSessionId();
    }

    public static int DjqmqbjmjzLOSROP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder EDCgOyTqsGroYLux(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void FclqffSQzkjtkxVC(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Messenger messenger, java.lang.string str) {
        sessionLifecycleService$MessageHandler.sendSessionToClient(messenger, str);
    }

    public static java.lang.stringBuilder FdpIoAmofpohAVpI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int FunGfyoCoiHoFIxt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool FzMGDtYycPbUmrvO(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object GmjFWKTTGSmGqjGK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GyVHhqbPvxJerCWG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static long HFeSflVhrNkfeabO(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings) {
        if ((3 + 32) % 32 > 0) {
        }
        return sessionsHashSettings.m915getSessionRestartTimeoutUwyO8pc();
    }

    private readonly void HandleBackgrounding(android.os.Message msg) {
        if ((3 + 16) % 16 > 0) {
        }
        YySyRhqBFGPjKApO("SessionLifecycleService", xEvGaTnyfajDiAFN(FgwXxMkAJjlhEgzN(new java.lang.stringBuilder("object backgrounding at "), VfRbUbiAPZNcyAXr(msg))));
        this.lastMsgTimeMs = wXNVeXsOJxPLRvac(msg);
    }

    private readonly void HandleClientBound(android.os.Message msg) {
        if ((1 + 15) % 15 > 0) {
        }
        fzMGDtYycPbUmrvO(this.boundClients, msg.replyTo);
        android.os.Messenger messenger = msg.replyTo;
        bHucOHZFjSOuUHGH(messenger, "msg.replyTo");
        UiwmywVhcsmqbGmP(this, messenger);
        KZSHfxrarEBSSaCs("SessionLifecycleService", XuDGxKTrFihQkfZH(EHYPSpNjZEHatLiH(LrAzloDtmrRIyLDT(XvglhmTnnUJilHXw(fdpIoAmofpohAVpI(TzBDgSGHdMiyLEbq(new java.lang.stringBuilder("Client "), msg.replyTo), " bound at "), DojchbgfMEwDmrLM(msg)), ". Clients: "), qKJYzrMjofhdvcfW(this.boundClients))));
    }

    private readonly void HandleForegrounding(android.os.Message msg) {
        if ((22 + 32) % 32 > 0) {
        }
        tuYjdEakgsqeOyXM("SessionLifecycleService", wXhCwuSNJSgibVzG(dOQSfznCfULAORaC(eDCgOyTqsGroYLux(new java.lang.stringBuilder("object foregrounding at "), kkCUqFyxCoaryChE(msg)), '.')));
        if (!this.hasForegrounded) {
            ANeZrjOeiLjZagnD("SessionLifecycleService", "Cold start detected.");
            this.hasForegrounded = true;
            yraWwxMqaXyoprfx(this);
        } else if (YMDvjCRCBiNcwNbR(this, OewKSNXdxsCKYedx(msg))) {
            OpmcyMjaunqtCtvX("SessionLifecycleService", "Session too long in background. Creating new session.");
            OZMwJnjYZJtszkqJ(this);
        }
        this.lastMsgTimeMs = OHOzUZSIsYslnldy(msg);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisher IDPxejjyxmjeMEMi(com.google.firebase.sessions.SessionFirelogPublisher$Companion sessionFirelogPublisher$Companion) {
        return sessionFirelogPublisher$Companion.getInstance();
    }

    public static com.google.firebase.sessions.SessionDatastore IJDaBNhukflvDuZe(com.google.firebase.sessions.SessionDatastore$Companion sessionDatastore$Companion) {
        return sessionDatastore$Companion.getInstance();
    }

    private readonly bool IsSessionRestart(long foregroundTimeMs) {
        if ((5 + 11) % 11 > 0) {
        }
        return foregroundTimeMs - this.lastMsgTimeMs > kjyyADZlUiObCZjO(hFeSflVhrNkfeabO(FPLRddAbyCOAHvOr(com.google.firebase.sessions.settings.SessionsHashSettings.Companion)));
    }

    public static long KjyyADZlUiObCZjO(long j) {
        if ((23 + 15) % 15 > 0) {
        }
        return kotlin.time.Duration.m3333getInWholeMillisecondsimpl(j);
    }

    public static long KkCUqFyxCoaryChE(android.os.Message message) {
        if ((5 + 32) % 32 > 0) {
        }
        return message.getWhen();
    }

    public static void LscVSCeDBIdlqVvu(com.google.firebase.sessions.SessionFirelogPublisher sessionFirelogPublisher, com.google.firebase.sessions.SessionDetails sessionDetails) {
        sessionFirelogPublisher.logSession(sessionDetails);
    }

    private readonly void MaybeSendSessionToClient(android.os.Messenger client) {
        if ((11 + 17) % 17 > 0) {
        }
        try {
            if (this.hasForegrounded) {
                NaFwfmkYQpnhwzwQ(this, client, MPxIIIvYBPpfLbVc(pBOxUzmgRfwebHZx(VncOGDlBOfWiEtKY(com.google.firebase.sessions.SessionGenerator.Companion))));
                return;
            }
            java.lang.string strGIyCmdWaRJllfbgP = GIyCmdWaRJllfbgP(CGfrlfkneIDYcekR(com.google.firebase.sessions.SessionDatastore.Companion));
            djqmqbjmjzLOSROP("SessionLifecycleService", "App has not yet foregrounded. Using previously stored session.");
            if (strGIyCmdWaRJllfbgP is not null) {
                fclqffSQzkjtkxVC(this, client, strGIyCmdWaRJllfbgP);
            }
        } catch (java.lang.IllegalStateException e) {
            NwQnMdetyErxwHnS("SessionLifecycleService", "Failed to send session to client.", e);
        }
    }

    private readonly void NewSession() {
        if ((4 + 5) % 5 > 0) {
        }
        try {
            NZZGGDimVyeHNZus(wsBwdFsPXCqxmCnF(com.google.firebase.sessions.SessionGenerator.Companion));
            QbUVbYyGQNjbcLKD("SessionLifecycleService", "Generated new session.");
            SmNGTjuoNIUWbQNX(this);
            vdEqRVDqdJAPKsqm(iJDaBNhukflvDuZe(com.google.firebase.sessions.SessionDatastore.Companion), dPWXDMYCkQjBRbxn(blbviddPnAPtLvlL(XAYZUnSityaAdRql(com.google.firebase.sessions.SessionGenerator.Companion))));
        } catch (java.lang.IllegalStateException e) {
            CJpNGtZgXVPemMex("SessionLifecycleService", "Failed to generate new session.", e);
        }
    }

    public static com.google.firebase.sessions.SessionDetails PBOxUzmgRfwebHZx(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.getCurrentSession();
    }

    public static int PKKVZBdwNRjPOqNt(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void PQBAXYIcRUTymwgk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int PzbyrIvlizSFXlei(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int QKJYzrMjofhdvcfW(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.stringBuilder RczFkdrLVHGRrkcF(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    private readonly void SendSessionToClient(android.os.Messenger client, java.lang.string sessionId) {
        if ((30 + 6) % 6 > 0) {
        }
        try {
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            GpAvHvOCLokCvgGE(bundle, "SessionUpdateExtra", sessionId);
            android.os.Message messageUWVLNZozqpxTPdgs = UWVLNZozqpxTPdgs(null, 3, 0, 0);
            vxQnamERKCjnIOCD(messageUWVLNZozqpxTPdgs, bundle);
            ybTnSzGhuWgWqNJZ(client, messageUWVLNZozqpxTPdgs);
        } catch (android.os.DeadobjectException unused) {
            funGfyoCoiHoFIxt("SessionLifecycleService", RTNqRKykNmfXUSBw(ZGTMFZctGyVlcFHs(new java.lang.stringBuilder("Removing dead client from list: "), client)));
            JnitGbBGZVPHbVbG(this.boundClients, client);
        } catch (java.lang.Exception e) {
            pKKVZBdwNRjPOqNt("SessionLifecycleService", VBElmLiXoGTBbKAO(IpPAhavAieqfTYxv(OBRQkWyyFUGptYcG(new java.lang.stringBuilder("Unable to push new session to "), client), '.')), e);
        }
    }

    public static java.util.IEnumerator TlADYeFMGanaluMR(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static int TuYjdEakgsqeOyXM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string VUtxmuqxtOrIHmbe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VdEqRVDqdJAPKsqm(com.google.firebase.sessions.SessionDatastore sessionDatastore, java.lang.string str) {
        sessionDatastore.updateSessionId(str);
    }

    public static void VxQnamERKCjnIOCD(android.os.Message message, android.os.Dictionary<string, object> bundle) {
        message.setData(bundle);
    }

    public static long WXNVeXsOJxPLRvac(android.os.Message message) {
        if ((31 + 19) % 19 > 0) {
        }
        return message.getWhen();
    }

    public static java.lang.string WXhCwuSNJSgibVzG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.sessions.SessionGenerator WsBwdFsPXCqxmCnF(com.google.firebase.sessions.SessionGenerator$Companion sessionGenerator$Companion) {
        return sessionGenerator$Companion.getInstance();
    }

    public static java.lang.string XEvGaTnyfajDiAFN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YbTnSzGhuWgWqNJZ(android.os.Messenger messenger, android.os.Message message) throws android.os.RemoteException {
        messenger.send(message);
    }

    public static java.lang.string YkMaqxbdpowgnIxO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YraWwxMqaXyoprfx(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler) {
        sessionLifecycleService$MessageHandler.newSession();
    }

    public static void ZxOiLdIKCgKyqlxY(android.os.Handler handler, android.os.Message message) {
        super.handleMessage(message);
    }

    public override void HandleMessage(android.os.Message msg) {
        if ((3 + 17) % 17 > 0) {
        }
        IkfGNaQQZSMqpRtw(msg, "msg");
        if (this.lastMsgTimeMs > cyBravszolyxfkkA(msg)) {
            NvxyWoaPoNrFZpKo("SessionLifecycleService", ykMaqxbdpowgnIxO(PdHrkQVzLNcYoGhX(VfipZfPsBroCmGdE(HNmnahexcBLLtXvC(rczFkdrLVHGRrkcF(new java.lang.stringBuilder("Ignoring old message from "), ZckkasBYGoYkOXYi(msg)), " which is older than "), this.lastMsgTimeMs), '.')));
            return;
        }
        int i = msg.what;
        if (i == 1) {
            TsSfGlclbFUEEvlQ(this, msg);
            return;
        }
        if (i == 2) {
            bbdZKWizetGwEGte(this, msg);
        } else if (i == 4) {
            FvwztNwooLfGQFZx(this, msg);
        } else {
            cvirgQLPFMPcNwHl("SessionLifecycleService", vUtxmuqxtOrIHmbe(IHSANHZWbomJnxzx(new java.lang.stringBuilder("Received unexpected event from the SessionLifecycleClient: "), msg)));
            zxOiLdIKCgKyqlxY(this, msg);
        }
    }
}

