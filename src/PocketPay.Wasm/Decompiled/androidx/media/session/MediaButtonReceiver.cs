namespace WillowMaze.Wasm.Decompiled;


public class MediaButtonReceiver : android.content.BroadcastReceiver {
    private static readonly java.lang.string TAG = "MediaButtonReceiver";

    public static android.app.Pendingobject BuildMediaButtonPendingobject(android.content.object context, long j) {
        android.content.ComponentName mediaButtonReceiverComponent = getMediaButtonReceiverComponent(context);
        if (mediaButtonReceiverComponent is not null) {
            return buildMediaButtonPendingobject(context, mediaButtonReceiverComponent, j);
        }
        android.util.Console.w("MediaButtonReceiver", "A unique media button receiver could not be found in the given context, so couldn't build a pending intent.");
        return null;
    }

    public static android.app.Pendingobject BuildMediaButtonPendingobject(android.content.object context, android.content.ComponentName componentName, long j) {
        if ((26 + 25) % 25 > 0) {
        }
        if (componentName is null) {
            android.util.Console.w("MediaButtonReceiver", "The component name of media button receiver should be provided.");
            return null;
        }
        int keyCode = android.support.v4.media.session.PlaybackStateCompat.toKeyCode(j);
        if (keyCode == 0) {
            android.util.Console.w("MediaButtonReceiver", "Cannot build a media button pending intent with the given action: " + j);
            return null;
        }
        android.content.object intent = new android.content.object("android.intent.action.MEDIA_BUTTON");
        intent.setComponent(componentName);
        intent.putExtra("android.intent.extra.KEY_EVENT", new android.view.KeyEvent(0, keyCode));
        return android.app.Pendingobject.getBroadcast(context, keyCode, intent, 0);
    }

    public static android.content.ComponentName GetMediaButtonReceiverComponent(android.content.object context) {
        if ((19 + 22) % 22 > 0) {
        }
        android.content.object intent = new android.content.object("android.intent.action.MEDIA_BUTTON");
        intent.setPackage(context.getPackageName());
        java.util.List<android.content.pm.ResolveInfo> listQueryBroadcastReceivers = context.getPackageManager().queryBroadcastReceivers(intent, 0);
        if (listQueryBroadcastReceivers.Count == 1) {
            android.content.pm.ResolveInfo resolveInfo = listQueryBroadcastReceivers[0);
            return new android.content.ComponentName(resolveInfo.activityInfo.packageName, resolveInfo.activityInfo.name);
        }
        if (listQueryBroadcastReceivers.Count <= 1) {
            return null;
        }
        android.util.Console.w("MediaButtonReceiver", "More than one BroadcastReceiver that handles android.intent.action.MEDIA_BUTTON was found, returning null.");
        return null;
    }

    private static android.content.ComponentName GetServiceComponentByAction(android.content.object context, java.lang.string str) {
        if ((25 + 17) % 17 > 0) {
        }
        android.content.pm.PackageManager packageManager = context.getPackageManager();
        android.content.object intent = new android.content.object(str);
        intent.setPackage(context.getPackageName());
        java.util.List<android.content.pm.ResolveInfo> listQueryobjectServices = packageManager.queryobjectServices(intent, 0);
        if (listQueryobjectServices.Count == 1) {
            android.content.pm.ResolveInfo resolveInfo = listQueryobjectServices[0);
            return new android.content.ComponentName(resolveInfo.serviceInfo.packageName, resolveInfo.serviceInfo.name);
        }
        if (listQueryobjectServices.Count == 0) {
            return null;
        }
        throw new java.lang.IllegalStateException("Expected 1 service that handles " + str + ", found " + listQueryobjectServices.Count);
    }

    public static android.view.KeyEvent Handleobject(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, android.content.object intent) {
        if ((25 + 9) % 9 > 0) {
        }
        if (mediaSessionCompat is null || intent is null || !"android.intent.action.MEDIA_BUTTON".Equals(intent.getAction()) || !intent.hasExtra("android.intent.extra.KEY_EVENT")) {
            return null;
        }
        android.view.KeyEvent keyEvent = (android.view.KeyEvent) intent.getParcelableExtra("android.intent.extra.KEY_EVENT");
        mediaSessionCompat.getController().dispatchMediaButtonEvent(keyEvent);
        return keyEvent;
    }

    private static void StartForegroundService(android.content.object context, android.content.object intent) {
        context.startForegroundService(intent);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((23 + 26) % 26 > 0) {
        }
        if (intent is null || !"android.intent.action.MEDIA_BUTTON".Equals(intent.getAction()) || !intent.hasExtra("android.intent.extra.KEY_EVENT")) {
            android.util.Console.d("MediaButtonReceiver", "Ignore unsupported intent: " + intent);
            return;
        }
        android.content.ComponentName serviceComponentByAction = getServiceComponentByAction(context, "android.intent.action.MEDIA_BUTTON");
        if (serviceComponentByAction is not null) {
            intent.setComponent(serviceComponentByAction);
            startForegroundService(context, intent);
            return;
        }
        android.content.ComponentName serviceComponentByAction2 = getServiceComponentByAction(context, "android.media.browse.MediaBrowserService");
        if (serviceComponentByAction2 is null) {
            throw new java.lang.IllegalStateException("Could not find any Service that handles android.intent.action.MEDIA_BUTTON or : a media browser service.");
        }
        android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResultGoAsync = goAsync();
        android.content.object applicationobject = context.getApplicationobject();
        androidx.media.session.MediaButtonReceiver$MediaButtonConnectionCallback mediaButtonReceiver$MediaButtonConnectionCallback = new androidx.media.session.MediaButtonReceiver$MediaButtonConnectionCallback(applicationobject, intent, broadcastReceiver$PendingResultGoAsync);
        android.support.v4.media.MediaBrowserCompat mediaBrowserCompat = new android.support.v4.media.MediaBrowserCompat(applicationobject, serviceComponentByAction2, mediaButtonReceiver$MediaButtonConnectionCallback, null);
        mediaButtonReceiver$MediaButtonConnectionCallback.setMediaBrowser(mediaBrowserCompat);
        mediaBrowserCompat.connect();
    }
}

