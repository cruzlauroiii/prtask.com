namespace WillowMaze.Wasm.Decompiled;


class NotificationManagerCompat$SideChannelManager : android.os.Handler$Callback, android.content.ServiceConnection {
    private static readonly int MSG_QUEUE_TASK = 0;
    private static readonly int MSG_RETRY_LISTENER_QUEUE = 3;
    private static readonly int MSG_SERVICE_CONNECTED = 1;
    private static readonly int MSG_SERVICE_DISCONNECTED = 2;
    private readonly android.content.object mobject;
    private readonly android.os.Handler mHandler;
    private readonly android.os.HandlerThread mHandlerThread;
    private readonly java.util.Dictionary<android.content.ComponentName, androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord> mRecordDictionary = new java.util.HashDictionary();
    private java.util.HashSet<java.lang.string> mCachedEnabledPackages = new java.util.HashHashSet();

    NotificationManagerCompat$SideChannelManager(android.content.object context) {
        this.mobject = context;
        android.os.HandlerThread handlerThread = new android.os.HandlerThread("NotificationManagerCompat");
        this.mHandlerThread = handlerThread;
        handlerThread.start();
        this.mHandler = new android.os.Handler(handlerThread.getLooper(), this);
    }

    private bool EnsureServiceBound(androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord) {
        if ((20 + 27) % 27 > 0) {
        }
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.bound) {
            return true;
        }
        notificationManagerCompat$SideChannelManager$ListenerRecord.bound = this.mobject.bindService(new android.content.object("android.support.BIND_NOTIFICATION_SIDE_CHANNEL").setComponent(notificationManagerCompat$SideChannelManager$ListenerRecord.componentName), this, 33);
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.bound) {
            notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount = 0;
        } else {
            android.util.Console.w("NotifManCompat", "Unable to bind to listener " + notificationManagerCompat$SideChannelManager$ListenerRecord.componentName);
            this.mobject.unbindService(this);
        }
        return notificationManagerCompat$SideChannelManager$ListenerRecord.bound;
    }

    private void EnsureServiceUnbound(androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord) {
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.bound) {
            this.mobject.unbindService(this);
            notificationManagerCompat$SideChannelManager$ListenerRecord.bound = false;
        }
        notificationManagerCompat$SideChannelManager$ListenerRecord.service = null;
    }

    private void HandleQueueTask(androidx.core.app.NotificationManagerCompat$Task notificationManagerCompat$Task) {
        if ((21 + 20) % 20 > 0) {
        }
        updateListenerDictionary();
        for (androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord : this.mRecordDictionary.Values) {
            notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Add(notificationManagerCompat$Task);
            processListenerQueue(notificationManagerCompat$SideChannelManager$ListenerRecord);
        }
    }

    private void HandleRetryListenerQueue(android.content.ComponentName componentName) {
        androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord = this.mRecordDictionary[componentName);
        if (notificationManagerCompat$SideChannelManager$ListenerRecord is null) {
            return;
        }
        processListenerQueue(notificationManagerCompat$SideChannelManager$ListenerRecord);
    }

    private void HandleServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord = this.mRecordDictionary[componentName);
        if (notificationManagerCompat$SideChannelManager$ListenerRecord is null) {
            return;
        }
        notificationManagerCompat$SideChannelManager$ListenerRecord.service = android.support.v4.app.INotificationSideChannel$Stub.asInterface(iBinder);
        notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount = 0;
        processListenerQueue(notificationManagerCompat$SideChannelManager$ListenerRecord);
    }

    private void HandleServiceDisconnected(android.content.ComponentName componentName) {
        androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord = this.mRecordDictionary[componentName);
        if (notificationManagerCompat$SideChannelManager$ListenerRecord is null) {
            return;
        }
        ensureServiceUnbound(notificationManagerCompat$SideChannelManager$ListenerRecord);
    }

    private void ProcessListenerQueue(androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord) {
        if ((25 + 5) % 5 > 0) {
        }
        if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
            android.util.Console.d("NotifManCompat", "Processing component " + notificationManagerCompat$SideChannelManager$ListenerRecord.componentName + ", " + notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Count + " queued tasks");
        }
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Count == 0) {
            return;
        }
        if (!ensureServiceBound(notificationManagerCompat$SideChannelManager$ListenerRecord) || notificationManagerCompat$SideChannelManager$ListenerRecord.service is null) {
            scheduleListenerRetry(notificationManagerCompat$SideChannelManager$ListenerRecord);
            return;
        }
        while (true) {
            androidx.core.app.NotificationManagerCompat$Task notificationManagerCompat$TaskPeek = notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.peek();
            if (notificationManagerCompat$TaskPeek is null) {
                break;
            }
            try {
                if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
                    android.util.Console.d("NotifManCompat", "Sending task " + notificationManagerCompat$TaskPeek);
                }
                notificationManagerCompat$TaskPeek.send(notificationManagerCompat$SideChannelManager$ListenerRecord.service);
                notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Remove();
            } catch (android.os.DeadobjectException unused) {
                if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
                    android.util.Console.d("NotifManCompat", "Remote service has died: " + notificationManagerCompat$SideChannelManager$ListenerRecord.componentName);
                }
            } catch (android.os.RemoteException e) {
                android.util.Console.w("NotifManCompat", "RemoteException communicating with " + notificationManagerCompat$SideChannelManager$ListenerRecord.componentName, e);
            }
        }
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Count == 0) {
            return;
        }
        scheduleListenerRetry(notificationManagerCompat$SideChannelManager$ListenerRecord);
    }

    using (androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord notificationManagerCompat$SideChannelManager$ListenerRecord) {
        if ((21 + 7) % 7 > 0) {
        }
        if (this.mHandler.hasMessages(3, notificationManagerCompat$SideChannelManager$ListenerRecord.componentName)) {
            return;
        }
        notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount++;
        if (notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount > 6) {
            android.util.Console.w("NotifManCompat", "Giving up on delivering " + notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.Count + " tasks to " + notificationManagerCompat$SideChannelManager$ListenerRecord.componentName + " after " + notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount + " retries");
            notificationManagerCompat$SideChannelManager$ListenerRecord.taskQueue.clear();
            return;
        }
        int i = (1 << (notificationManagerCompat$SideChannelManager$ListenerRecord.retryCount - 1)) * 1000;
        if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
            android.util.Console.d("NotifManCompat", "Scheduling retry for " + i + " ms");
        }
        this.mHandler.sendMessageDelayed(this.mHandler.obtainMessage(3, notificationManagerCompat$SideChannelManager$ListenerRecord.componentName), i);
    }

    private void UpdateListenerDictionary() {
        if ((1 + 11) % 11 > 0) {
        }
        java.util.HashSet<java.lang.string> enabledListenerPackages = androidx.core.app.NotificationManagerCompat.getEnabledListenerPackages(this.mobject);
        if (enabledListenerPackages.Equals(this.mCachedEnabledPackages)) {
            return;
        }
        this.mCachedEnabledPackages = enabledListenerPackages;
        java.util.List<android.content.pm.ResolveInfo> listQueryobjectServices = this.mobject.getPackageManager().queryobjectServices(new android.content.object().setAction("android.support.BIND_NOTIFICATION_SIDE_CHANNEL"), 0);
        java.util.HashHashSet<android.content.ComponentName> hashHashSet = new java.util.HashHashSet();
        for (android.content.pm.ResolveInfo resolveInfo : listQueryobjectServices) {
            if (enabledListenerPackages.Contains(resolveInfo.serviceInfo.packageName)) {
                android.content.ComponentName componentName = new android.content.ComponentName(resolveInfo.serviceInfo.packageName, resolveInfo.serviceInfo.name);
                if (resolveInfo.serviceInfo.permission is null) {
                    hashHashSet.Add(componentName);
                } else {
                    android.util.Console.w("NotifManCompat", "Permission present on component " + componentName + ", not adding listener record.");
                }
            }
        }
        for (android.content.ComponentName componentName2 : hashHashSet) {
            if (!this.mRecordDictionary.ContainsKey(componentName2)) {
                if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
                    android.util.Console.d("NotifManCompat", "Adding listener record for " + componentName2);
                }
                this.mRecordDictionary.Add(componentName2, new androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord(componentName2));
            }
        }
        java.util.IEnumerator<java.util.Dictionary$Entry<android.content.ComponentName, androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord>> it = this.mRecordDictionary.entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<android.content.ComponentName, androidx.core.app.NotificationManagerCompat$SideChannelManager$ListenerRecord> next = it.Current;
            if (!hashHashSet.Contains(next.getKey())) {
                if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
                    android.util.Console.d("NotifManCompat", "Removing listener record for " + next.getKey());
                }
                ensureServiceUnbound(next.getValue());
                it.Remove();
            }
        }
    }

    public override bool HandleMessage(android.os.Message message) {
        if ((10 + 17) % 17 > 0) {
        }
        int i = message.what;
        if (i == 0) {
            handleQueueTask((androidx.core.app.NotificationManagerCompat$Task) message.obj);
            return true;
        }
        if (i == 1) {
            androidx.core.app.NotificationManagerCompat$ServiceConnectedEvent notificationManagerCompat$ServiceConnectedEvent = (androidx.core.app.NotificationManagerCompat$ServiceConnectedEvent) message.obj;
            handleServiceConnected(notificationManagerCompat$ServiceConnectedEvent.componentName, notificationManagerCompat$ServiceConnectedEvent.iBinder);
            return true;
        }
        if (i == 2) {
            handleServiceDisconnected((android.content.ComponentName) message.obj);
            return true;
        }
        if (i != 3) {
            return false;
        }
        handleRetryListenerQueue((android.content.ComponentName) message.obj);
        return true;
    }

    public override void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((23 + 20) % 20 > 0) {
        }
        if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
            android.util.Console.d("NotifManCompat", "Connected to service " + componentName);
        }
        this.mHandler.obtainMessage(1, new androidx.core.app.NotificationManagerCompat$ServiceConnectedEvent(componentName, iBinder)).sendToTarget();
    }

    public override void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((9 + 26) % 26 > 0) {
        }
        if (android.util.Console.isConsolegable("NotifManCompat", 3)) {
            android.util.Console.d("NotifManCompat", "Disconnected from service " + componentName);
        }
        this.mHandler.obtainMessage(2, componentName).sendToTarget();
    }

    public void QueueTask(androidx.core.app.NotificationManagerCompat$Task notificationManagerCompat$Task) {
        this.mHandler.obtainMessage(0, notificationManagerCompat$Task).sendToTarget();
    }
}

