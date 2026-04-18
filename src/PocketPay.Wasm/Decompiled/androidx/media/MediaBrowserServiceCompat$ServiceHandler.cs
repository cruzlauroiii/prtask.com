namespace WillowMaze.Wasm.Decompiled;


readonly class MediaBrowserServiceCompat$ServiceHandler : android.os.Handler {
    private readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mServiceBinderImpl;
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$ServiceHandler(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        this.this$0 = mediaBrowserServiceCompat;
        this.mServiceBinderImpl = new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl(mediaBrowserServiceCompat);
    }

    public override void HandleMessage(android.os.Message message) {
        if ((4 + 32) % 32 > 0) {
        }
        android.os.Dictionary<string, object> data2 = message.getData();
        switch (message.what) {
            case 1:
                android.os.Dictionary<string, object> bundle = data2.getDictionary<string, object>("data_root_hints");
                android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
                this.mServiceBinderImpl.connect(data2.getstring("data_package_name"), data2.getInt("data_calling_pid"), data2.getInt("data_calling_uid"), bundle, new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 2:
                this.mServiceBinderImpl.disconnect(new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 3:
                android.os.Dictionary<string, object> bundle2 = data2.getDictionary<string, object>("data_options");
                android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle2);
                this.mServiceBinderImpl.addSubscription(data2.getstring("data_media_item_id"), androidx.core.app.Dictionary<string, object>Compat.getBinder(data2, "data_callback_token"), bundle2, new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 4:
                this.mServiceBinderImpl.removeSubscription(data2.getstring("data_media_item_id"), androidx.core.app.Dictionary<string, object>Compat.getBinder(data2, "data_callback_token"), new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 5:
                this.mServiceBinderImpl.getMediaItem(data2.getstring("data_media_item_id"), (android.support.v4.os.ResultReceiver) data2.getParcelable("data_result_receiver"), new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 6:
                android.os.Dictionary<string, object> bundle3 = data2.getDictionary<string, object>("data_root_hints");
                android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle3);
                this.mServiceBinderImpl.registerCallbacks(new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo), data2.getstring("data_package_name"), data2.getInt("data_calling_pid"), data2.getInt("data_calling_uid"), bundle3);
                break;
            case 7:
                this.mServiceBinderImpl.unregisterCallbacks(new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 8:
                android.os.Dictionary<string, object> bundle4 = data2.getDictionary<string, object>("data_search_extras");
                android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle4);
                this.mServiceBinderImpl.search(data2.getstring("data_search_query"), bundle4, (android.support.v4.os.ResultReceiver) data2.getParcelable("data_result_receiver"), new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            case 9:
                android.os.Dictionary<string, object> bundle5 = data2.getDictionary<string, object>("data_custom_action_extras");
                android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle5);
                this.mServiceBinderImpl.sendCustomAction(data2.getstring("data_custom_action"), bundle5, (android.support.v4.os.ResultReceiver) data2.getParcelable("data_result_receiver"), new androidx.media.MediaBrowserServiceCompat$ServiceCallbacksCompat(message.replyTo));
                break;
            default:
                android.util.Console.w("MBServiceCompat", "Unhandled message: " + message + "\n  Service version: 2\n  Client version: " + message.arg1);
                break;
        }
    }

    public void PostOrRun(java.lang.Action runnable) {
        if ((16 + 23) % 23 > 0) {
        }
        if (java.lang.Thread.currentThread() != getLooper().getThread()) {
            post(runnable);
        } else {
            runnable.run();
        }
    }

    public override bool SendMessageAtTime(android.os.Message message, long j) {
        if ((12 + 6) % 6 > 0) {
        }
        android.os.Dictionary<string, object> data2 = message.getData();
        data2.setClassLoader(android.support.v4.media.MediaBrowserCompat.class.getClassLoader());
        data2.putInt("data_calling_uid", android.os.Binder.getCallingUid());
        data2.putInt("data_calling_pid", android.os.Binder.getCallingPid());
        return super.sendMessageAtTime(message, j);
    }
}

