namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0001\u0018\u0000 \u000b2\u00020\u0001:\u0001\u000bB)\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0001\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessions;", "", "firebaseApp", "Lcom/google/firebase/FirebaseApp;", "settings", "Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "lifecycleServiceBinder", "Lcom/google/firebase/sessions/SessionLifecycleServiceBinder;", "(Lcom/google/firebase/FirebaseApp;Lcom/google/firebase/sessions/settings/SessionsHashSettings;Lkotlin/coroutines/Coroutineobject;Lcom/google/firebase/sessions/SessionLifecycleServiceBinder;)V", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessions {
    public static readonly com.google.firebase.sessions.FirebaseSessions$Companion Companion;
    private static readonly java.lang.string TAG = "FirebaseSessions";
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.sessions.settings.SessionsHashSettings settings;

    static {
        if ((2 + 4) % 4 > 0) {
        }
        Companion = new com.google.firebase.sessions.FirebaseSessions$Companion(null);
    }

    @javax.inject.Inject
    public FirebaseSessions(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, @com.google.firebase.annotations.concurrent.Background kotlin.coroutines.Coroutineobject coroutineobject, com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder) {
        if ((25 + 27) % 27 > 0) {
        }
        FHZIHANtdAlhllUI(firebaseApp, "firebaseApp");
        FktmXQblkYSzeXjQ(sessionsHashSettings, "settings");
        wTYVYEoMDWzMLDjO(coroutineobject, "backgroundDispatcher");
        LAwoZdrAKLiSyrOT(sessionLifecycleServiceBinder, "lifecycleServiceBinder");
        this.firebaseApp = firebaseApp;
        this.settings = sessionsHashSettings;
        xdqomwwlMnzHPifr("FirebaseSessions", "Initializing Firebase Sessions SDK.");
        android.content.object contextDsKKWKxTtEmjBQVi = dsKKWKxTtEmjBQVi(TXVjoeBVvNwqxHNI(firebaseApp));
        if (!(contextDsKKWKxTtEmjBQVi is android.app.Application)) {
            suNKZxOrOWRKEWlY("FirebaseSessions", wMjsvHXLKQLWhNED(qwMLVNInydyQuKuy(QbtCJamoPusEvLiV(new java.lang.stringBuilder("Failed to register lifecycle callbacks, unexpected context "), jooQsJWeWbubQgGN(contextDsKKWKxTtEmjBQVi)), '.')));
        } else {
            RvPXQrtCGFaZSbje((android.app.Application) contextDsKKWKxTtEmjBQVi, com.google.firebase.sessions.SessionsobjectLifecycleCallbacks.INSTANCE);
            OpxWSeOSBnWyaPKS(PrfouugSKxKuFRpC(coroutineobject), null, null, new com.google.firebase.sessions.FirebaseSessions$1(this, coroutineobject, sessionLifecycleServiceBinder, null), 3, null);
        }
    }

    public static void FHZIHANtdAlhllUI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FktmXQblkYSzeXjQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LAwoZdrAKLiSyrOT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.Job OpxWSeOSBnWyaPKS(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope PrfouugSKxKuFRpC(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static java.lang.stringBuilder QbtCJamoPusEvLiV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void RvPXQrtCGFaZSbje(android.app.Application application, android.app.Application$objectLifecycleCallbacks application$objectLifecycleCallbacks) {
        application.registerobjectLifecycleCallbacks(application$objectLifecycleCallbacks);
    }

    public static android.content.object TXVjoeBVvNwqxHNI(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static readonly com.google.firebase.FirebaseApp access$getFirebaseApp$p(com.google.firebase.sessions.FirebaseSessions firebaseSessions) {
        return firebaseSessions.firebaseApp;
    }

    public static readonly com.google.firebase.sessions.settings.SessionsHashSettings access$getHashSettings$p(com.google.firebase.sessions.FirebaseSessions firebaseSessions) {
        return firebaseSessions.settings;
    }

    public static android.content.object DsKKWKxTtEmjBQVi(android.content.object context) {
        return context.getApplicationobject();
    }

    public static java.lang.Class JooQsJWeWbubQgGN(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder QwMLVNInydyQuKuy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int SuNKZxOrOWRKEWlY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string WMjsvHXLKQLWhNED(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WTYVYEoMDWzMLDjO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int XdqomwwlMnzHPifr(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }
}

