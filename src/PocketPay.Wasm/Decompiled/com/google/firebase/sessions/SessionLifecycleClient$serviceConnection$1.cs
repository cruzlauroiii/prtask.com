namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u001c\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0016J\u0012\u0010\b\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016¨\u0006\t"}, d2 = {"com/google/firebase/sessions/SessionLifecycleClient$serviceConnection$1", "Landroid/content/ServiceConnection;", "onServiceConnected", "", "className", "Landroid/content/ComponentName;", "serviceBinder", "Landroid/os/IBinder;", "onServiceDisconnected", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionLifecycleClient$serviceConnection$1 : android.content.ServiceConnection {
    readonly com.google.firebase.sessions.SessionLifecycleClient this$0;

    SessionLifecycleClient$serviceConnection$1(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        this.this$0 = sessionLifecycleClient;
    }

    public static void JiKfXuoEBgaxrAVS(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, bool z) {
        com.google.firebase.sessions.SessionLifecycleClient.access$setServiceBound$p(sessionLifecycleClient, z);
    }

    public static java.util.concurrent.LinkedBlockingQueue PfqyZtagCxRZKlSw(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return com.google.firebase.sessions.SessionLifecycleClient.access$getQueuedMessages$p(sessionLifecycleClient);
    }

    public static void QFkAnoHeCEMUoEKG(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, bool z) {
        com.google.firebase.sessions.SessionLifecycleClient.access$setServiceBound$p(sessionLifecycleClient, z);
    }

    public static kotlinx.coroutines.Job SLoJhFezZfTAuosd(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, java.util.List list) {
        return com.google.firebase.sessions.SessionLifecycleClient.access$sendLifecycleEvents(sessionLifecycleClient, list);
    }

    public static int XFVwauRNIyVCgLuS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int XbYJdjKaFQcREwUz(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void HxAJCIQAOpYdRkDl(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Messenger messenger) {
        com.google.firebase.sessions.SessionLifecycleClient.access$setService$p(sessionLifecycleClient, messenger);
    }

    public static int IPvpiKiiHqZSoSGz(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue) {
        return linkedBlockingQueue.Count;
    }

    public static java.util.List SHDiHECxIYkThEKc(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        return com.google.firebase.sessions.SessionLifecycleClient.access$drainQueue(sessionLifecycleClient);
    }

    public static void XStHqjSjQDnzcELO(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, android.os.Messenger messenger) {
        com.google.firebase.sessions.SessionLifecycleClient.access$setService$p(sessionLifecycleClient, messenger);
    }

    public static java.lang.string YUazjELYSXQswMeq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YavgRIHLIpNAjheN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public override void OnServiceConnected(android.content.ComponentName className, android.os.IBinder serviceBinder) {
        XFVwauRNIyVCgLuS("SessionLifecycleClient", yUazjELYSXQswMeq(yavgRIHLIpNAjheN(new java.lang.stringBuilder("Connected to SessionLifecycleService. Queue size "), iPvpiKiiHqZSoSGz(PfqyZtagCxRZKlSw(this.this$0)))));
        hxAJCIQAOpYdRkDl(this.this$0, new android.os.Messenger(serviceBinder));
        JiKfXuoEBgaxrAVS(this.this$0, true);
        com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient = this.this$0;
        SLoJhFezZfTAuosd(sessionLifecycleClient, sHDiHECxIYkThEKc(sessionLifecycleClient));
    }

    public override void OnServiceDisconnected(android.content.ComponentName className) {
        XbYJdjKaFQcREwUz("SessionLifecycleClient", "Disconnected from SessionLifecycleService");
        xStHqjSjQDnzcELO(this.this$0, null);
        QFkAnoHeCEMUoEKG(this.this$0, false);
    }
}

