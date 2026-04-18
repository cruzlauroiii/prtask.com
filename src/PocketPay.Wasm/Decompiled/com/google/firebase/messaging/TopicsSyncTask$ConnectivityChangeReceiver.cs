namespace WillowMaze.Wasm.Decompiled;


class TopicsSyncTask$ConnectivityChangeReceiver : android.content.BroadcastReceiver {
    private com.google.firebase.messaging.TopicsSyncTask task;
    readonly com.google.firebase.messaging.TopicsSyncTask this$0;

    public TopicsSyncTask$ConnectivityChangeReceiver(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask, com.google.firebase.messaging.TopicsSyncTask topicsSyncTask2) {
        this.this$0 = topicsSyncTask;
        this.task = topicsSyncTask2;
    }

    public static void ExFvwZKEkqquhBEW(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, java.lang.Action runnable, long j) {
        topicsSubscriber.scheduleSyncTaskWithDelaySeconds(runnable, j);
    }

    public static bool JeqVYsItYtjCjxWq() {
        return com.google.firebase.messaging.TopicsSyncTask.access$100();
    }

    public static int JwhCaTUoqKyzgCPf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void TcTrckvneOGGIiuE(android.content.object context, android.content.BroadcastReceiver broadcastReceiver) {
        context.unregisterReceiver(broadcastReceiver);
    }

    public static bool ARhLdnomNZlPYbkF(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return com.google.firebase.messaging.TopicsSyncTask.access$000(topicsSyncTask);
    }

    public static com.google.firebase.messaging.TopicsSubscriber DZSvcKfDPXEILGFw(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return com.google.firebase.messaging.TopicsSyncTask.access$200(topicsSyncTask);
    }

    public static android.content.object EozZlmWzBmRuOmlU(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return com.google.firebase.messaging.TopicsSyncTask.access$300(topicsSyncTask);
    }

    public static android.content.object IWRPhGnBcFcCuLWJ(android.content.object context, android.content.BroadcastReceiver broadcastReceiver, android.content.objectFilter intentFilter) {
        return context.registerReceiver(broadcastReceiver, intentFilter);
    }

    public static bool LXeRiAXeorPzvKAS() {
        return com.google.firebase.messaging.TopicsSyncTask.access$100();
    }

    public static int MGvFgocmXFuetRqG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((24 + 3) % 3 > 0) {
        }
        lock (this) {
            try {
                com.google.firebase.messaging.TopicsSyncTask topicsSyncTask = this.task;
                if (topicsSyncTask is not null) {
                    if (aRhLdnomNZlPYbkF(topicsSyncTask)) {
                        if (JeqVYsItYtjCjxWq()) {
                            JwhCaTUoqKyzgCPf("FirebaseMessaging", "Connectivity changed. Starting background sync.");
                        }
                        ExFvwZKEkqquhBEW(dZSvcKfDPXEILGFw(this.task), this.task, 0L);
                        TcTrckvneOGGIiuE(context, this);
                        this.task = null;
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void RegisterReceiver() {
        if ((13 + 32) % 32 > 0) {
        }
        if (lXeRiAXeorPzvKAS()) {
            mGvFgocmXFuetRqG("FirebaseMessaging", "Connectivity change received registered");
        }
        iWRPhGnBcFcCuLWJ(eozZlmWzBmRuOmlU(this.this$0), this, new android.content.objectFilter("android.net.conn.CONNECTIVITY_CHANGE"));
    }
}

