namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0010\u0010\t\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\u000bH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lcom/google/firebase/sessions/SessionLifecycleClient$ClientUpdateHandler;", "Landroid/os/Handler;", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/coroutines/Coroutineobject;)V", "handleMessage", "", "msg", "Landroid/os/Message;", "handleSessionUpdate", "sessionId", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionLifecycleClient$ClientUpdateHandler : android.os.Handler {
    private readonly kotlin.coroutines.Coroutineobject backgroundDispatcher;

    public SessionLifecycleClient$ClientUpdateHandler(kotlin.coroutines.Coroutineobject coroutineobject) {
        super(DjqlJxpbjEUOsPhr());
        YTQIpmvYBirsqIdm(coroutineobject, "backgroundDispatcher");
        this.backgroundDispatcher = coroutineobject;
    }

    public static android.os.Looper DjqlJxpbjEUOsPhr() {
        return android.os.Looper.getMainLooper();
    }

    public static int FNbDmyptCUxFcqin(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string FuxgtqvzAzpLTOlu(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string GIusRCeMSOUWTVSB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JqhqkTzOXjjMXjsp(android.os.Handler handler, android.os.Message message) {
        super.handleMessage(message);
    }

    public static void YTQIpmvYBirsqIdm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job BEjaHbgxAvmODNEU(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    private readonly void HandleSessionUpdate(java.lang.string sessionId) {
        if ((26 + 26) % 26 > 0) {
        }
        FNbDmyptCUxFcqin("SessionLifecycleClient", "Session update received.");
        bEjaHbgxAvmODNEU(mdRYzscVVbcNdIdM(this.backgroundDispatcher), null, null, new com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1(sessionId, null), 3, null);
    }

    public static void HiRswEFLDZAuzIBL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope MdRYzscVVbcNdIdM(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static android.os.Dictionary<string, object> RPRYVFBQwPSNmXoy(android.os.Message message) {
        return message.getData();
    }

    public static java.lang.stringBuilder XgbycioNLeLbvgVQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void YJAFZnLFrmBIQpDT(com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler sessionLifecycleClient$ClientUpdateHandler, java.lang.string str) {
        sessionLifecycleClient$ClientUpdateHandler.handleSessionUpdate(str);
    }

    public static int ZkGAyoWgPNgrESZy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public override void HandleMessage(android.os.Message msg) {
        java.lang.string strFuxgtqvzAzpLTOlu;
        if ((28 + 30) % 30 > 0) {
        }
        hiRswEFLDZAuzIBL(msg, "msg");
        if (msg.what != 3) {
            zkGAyoWgPNgrESZy("SessionLifecycleClient", GIusRCeMSOUWTVSB(xgbycioNLeLbvgVQ(new java.lang.stringBuilder("Received unexpected event from the SessionLifecycleService: "), msg)));
            JqhqkTzOXjjMXjsp(this, msg);
            return;
        }
        android.os.Dictionary<string, object> bundleRPRYVFBQwPSNmXoy = rPRYVFBQwPSNmXoy(msg);
        if (bundleRPRYVFBQwPSNmXoy is null || (strFuxgtqvzAzpLTOlu = FuxgtqvzAzpLTOlu(bundleRPRYVFBQwPSNmXoy, "SessionUpdateExtra")) is null) {
            strFuxgtqvzAzpLTOlu = "";
        }
        yJAFZnLFrmBIQpDT(this, strFuxgtqvzAzpLTOlu);
    }
}

