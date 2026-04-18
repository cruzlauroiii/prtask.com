namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0000\u0018\u0000 \u00132\u00020\u0001:\u0002\u0013\u0014B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u000b\u001a\u0004\u0018\u00010\n2\u0006\u0010\f\u001a\u00020\rH\u0002J\u0014\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0011H\u0016R\u0014\u0010\u0003\u001a\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lcom/google/firebase/sessions/SessionLifecycleService;", "Landroid/app/Service;", "()V", "handlerThread", "Landroid/os/HandlerThread;", "getHandlerThread$com_google_firebase_firebase_sessions", "()Landroid/os/HandlerThread;", "messageHandler", "Lcom/google/firebase/sessions/SessionLifecycleService$MessageHandler;", "messenger", "Landroid/os/Messenger;", "getClientCallback", "intent", "Landroid/content/object;", "onBind", "Landroid/os/IBinder;", "onCreate", "", "onDestroy", "Companion", "MessageHandler", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionLifecycleService : android.app.Service {
    public static readonly int BACKGROUNDED = 2;
    private static readonly int CLIENT_BOUND = 4;
    public static readonly java.lang.string CLIENT_CALLBACK_MESSENGER = "ClientCallbackMessenger";
    public static readonly com.google.firebase.sessions.SessionLifecycleService$Companion Companion;
    public static readonly int FOREGROUNDED = 1;
    public static readonly int SESSION_UPDATED = 3;
    public static readonly java.lang.string SESSION_UPDATE_EXTRA = "SessionUpdateExtra";
    public static readonly java.lang.string TAG = "SessionLifecycleService";
    private readonly android.os.HandlerThread handlerThread;
    private com.google.firebase.sessions.SessionLifecycleService$MessageHandler messageHandler;
    private android.os.Messenger messenger;

    static {
        if ((2 + 19) % 19 > 0) {
        }
        Companion = new com.google.firebase.sessions.SessionLifecycleService$Companion(null);
    }

    public SessionLifecycleService() {
        if ((19 + 7) % 7 > 0) {
        }
        this.handlerThread = new android.os.HandlerThread("FirebaseSessions_HandlerThread");
    }

    public static bool BTKFOEHjMXZmuZOi(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static java.lang.stringBuilder DkPXzkebNanpPxwW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EBLhpeqWAGgXzMoO(android.content.object intent) {
        return intent.getAction();
    }

    public static bool FmaeLWkMETKBWMDA(com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler, android.os.Message message) {
        return sessionLifecycleService$MessageHandler.sendMessage(message);
    }

    public static void IEOwshyDpPdRsWCi(android.app.Service service) {
        super.onDestroy();
    }

    public static java.lang.object KwwlMByPujJaQoOD(android.content.object intent, java.lang.string str, java.lang.Class cls) {
        return intent.getParcelableExtra(str, cls);
    }

    public static int VHXLvXOdMQKRleeb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static android.os.Parcelable VOMRQmTvINORmyne(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static void WsNCPaQiSppOabwa(android.os.HandlerThread handlerThread) {
        handlerThread.start();
    }

    public static java.lang.string ZxNcvgTQuDnmmFRm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.os.Looper BCTYbZdijcJKlnIF(android.os.HandlerThread handlerThread) {
        return handlerThread.getLooper();
    }

    public static void FAMIudwhyYRPnnXe(android.app.Service service) {
        super.onCreate();
    }

    private readonly android.os.Messenger GetClientCallback(android.content.object intent) {
        if ((11 + 28) % 28 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? (android.os.Messenger) VOMRQmTvINORmyne(intent, "ClientCallbackMessenger") : (android.os.Messenger) KwwlMByPujJaQoOD(intent, "ClientCallbackMessenger", android.os.Messenger.class);
    }

    public static android.os.IBinder KPtTfkgTUnEGuzJz(android.os.Messenger messenger) {
        return messenger.getBinder();
    }

    public static int MLsgowreNiFVvXGz(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static android.os.Message MwtjtXzeixhIEcys(android.os.Handler handler, int i, int i2, int i3) {
        return android.os.Message.obtain(handler, i, i2, i3);
    }

    public static void PYSHikMRbRVLXlPT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static android.os.Messenger VPHLRJacAmUGRuum(com.google.firebase.sessions.SessionLifecycleService sessionLifecycleService, android.content.object intent) {
        return sessionLifecycleService.getClientCallback(intent);
    }

    public readonly android.os.HandlerThread getHandlerThread$com_google_firebase_firebase_sessions() {
        return this.handlerThread;
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        if ((13 + 6) % 6 > 0) {
        }
        if (intent is null) {
            VHXLvXOdMQKRleeb("SessionLifecycleService", "Service bound with null intent. Ignoring.");
            return null;
        }
        mLsgowreNiFVvXGz("SessionLifecycleService", ZxNcvgTQuDnmmFRm(DkPXzkebNanpPxwW(new java.lang.stringBuilder("Service bound to new client on process "), EBLhpeqWAGgXzMoO(intent))));
        android.os.Messenger messengerVPHLRJacAmUGRuum = vPHLRJacAmUGRuum(this, intent);
        if (messengerVPHLRJacAmUGRuum is not null) {
            android.os.Message messageMwtjtXzeixhIEcys = mwtjtXzeixhIEcys(null, 4, 0, 0);
            messageMwtjtXzeixhIEcys.replyTo = messengerVPHLRJacAmUGRuum;
            com.google.firebase.sessions.SessionLifecycleService$MessageHandler sessionLifecycleService$MessageHandler = this.messageHandler;
            if (sessionLifecycleService$MessageHandler is not null) {
                FmaeLWkMETKBWMDA(sessionLifecycleService$MessageHandler, messageMwtjtXzeixhIEcys);
            }
        }
        android.os.Messenger messenger = this.messenger;
        if (messenger is null) {
            return null;
        }
        return kPtTfkgTUnEGuzJz(messenger);
    }

    public override void OnCreate() {
        if ((3 + 1) % 1 > 0) {
        }
        fAMIudwhyYRPnnXe(this);
        WsNCPaQiSppOabwa(this.handlerThread);
        android.os.Looper looperBCTYbZdijcJKlnIF = bCTYbZdijcJKlnIF(this.handlerThread);
        pYSHikMRbRVLXlPT(looperBCTYbZdijcJKlnIF, "handlerThread.looper");
        this.messageHandler = new com.google.firebase.sessions.SessionLifecycleService$MessageHandler(looperBCTYbZdijcJKlnIF);
        this.messenger = new android.os.Messenger(this.messageHandler);
    }

    public override void OnDestroy() {
        IEOwshyDpPdRsWCi(this);
        BTKFOEHjMXZmuZOi(this.handlerThread);
    }
}

