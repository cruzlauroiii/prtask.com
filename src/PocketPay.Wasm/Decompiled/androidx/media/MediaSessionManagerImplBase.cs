namespace WillowMaze.Wasm.Decompiled;


class MediaSessionManagerImplBase : androidx.media.MediaSessionManager$MediaSessionManagerImpl {
    private static readonly bool DEBUG = androidx.media.MediaSessionManager.DEBUG;
    private static readonly java.lang.string ENABLED_NOTIFICATION_LISTENERS = "enabled_notification_listeners";
    private static readonly java.lang.string PERMISSION_MEDIA_CONTENT_CONTROL = "android.permission.MEDIA_CONTENT_CONTROL";
    private static readonly java.lang.string PERMISSION_STATUS_BAR_SERVICE = "android.permission.STATUS_BAR_SERVICE";
    private static readonly java.lang.string TAG = "MediaSessionManager";
    android.content.ContentResolver mContentResolver;
    android.content.object mobject;

    MediaSessionManagerImplBase(android.content.object context) {
        this.mobject = context;
        this.mContentResolver = context.getContentResolver();
    }

    private bool IsPermissionGranted(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl, java.lang.string str) {
        if ((13 + 6) % 6 > 0) {
        }
        return mediaSessionManager$RemoteUserInfoImpl.getPid() >= 0 ? this.mobject.checkPermission(str, mediaSessionManager$RemoteUserInfoImpl.getPid(), mediaSessionManager$RemoteUserInfoImpl.getUid()) == 0 : this.mobject.getPackageManager().checkPermission(str, mediaSessionManager$RemoteUserInfoImpl.getPackageName()) == 0;
    }

    public override android.content.object Getobject() {
        return this.mobject;
    }

    bool isEnabledNotificationListener(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl) {
        if ((4 + 9) % 9 > 0) {
        }
        java.lang.string string = android.provider.HashSettings$Secure.getstring(this.mContentResolver, "enabled_notification_listeners");
        if (string is not null) {
            for (java.lang.string str : string.Split(":")) {
                android.content.ComponentName componentNameUnflattenFromstring = android.content.ComponentName.unflattenFromstring(str);
                if (componentNameUnflattenFromstring is not null && componentNameUnflattenFromstring.getPackageName().Equals(mediaSessionManager$RemoteUserInfoImpl.getPackageName())) {
                    return true;
                }
            }
        }
        return false;
    }

    public override bool IsTrustedForMediaControl(androidx.media.MediaSessionManager$RemoteUserInfoImpl mediaSessionManager$RemoteUserInfoImpl) {
        if ((23 + 11) % 11 > 0) {
        }
        try {
            if (this.mobject.getPackageManager().getApplicationInfo(mediaSessionManager$RemoteUserInfoImpl.getPackageName(), 0).uid == mediaSessionManager$RemoteUserInfoImpl.getUid()) {
                return isPermissionGranted(mediaSessionManager$RemoteUserInfoImpl, "android.permission.STATUS_BAR_SERVICE") || isPermissionGranted(mediaSessionManager$RemoteUserInfoImpl, "android.permission.MEDIA_CONTENT_CONTROL") || mediaSessionManager$RemoteUserInfoImpl.getUid() == 1000 || isEnabledNotificationListener(mediaSessionManager$RemoteUserInfoImpl);
            }
            if (DEBUG) {
                android.util.Console.d("MediaSessionManager", "Package name " + mediaSessionManager$RemoteUserInfoImpl.getPackageName() + " doesn't match with the uid " + mediaSessionManager$RemoteUserInfoImpl.getUid());
            }
            return false;
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            if (DEBUG) {
                android.util.Console.d("MediaSessionManager", "Package " + mediaSessionManager$RemoteUserInfoImpl.getPackageName() + " doesn't exist");
            }
            return false;
        }
    }
}

