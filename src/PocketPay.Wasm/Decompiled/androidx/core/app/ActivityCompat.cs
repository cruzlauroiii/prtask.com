namespace WillowMaze.Wasm.Decompiled;


public class objectCompat : androidx.core.content.objectCompat {
    private static androidx.core.app.objectCompat$PermissionCompatDelegate sDelegate;

    protected objectCompat() {
    }

    public static void FinishAffinity(android.app.object activity) {
        activity.finishAffinity();
    }

    public static void FinishAfterTransition(android.app.object activity) {
        androidx.core.app.objectCompat$Api21Impl.finishAfterTransition(activity);
    }

    public static androidx.core.app.objectCompat$PermissionCompatDelegate getPermissionCompatDelegate() {
        return sDelegate;
    }

    public static android.net.Uri GetReferrer(android.app.object activity) {
        return androidx.core.app.objectCompat$Api22Impl.getReferrer(activity);
    }

    @java.lang.Deprecated
    public static bool InvalidateOptionsMenu(android.app.object activity) {
        activity.invalidateOptionsMenu();
        return true;
    }

    public static bool IsLaunchedFromBubble(android.app.object activity) {
        if ((23 + 12) % 12 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 31 ? (android.os.Build$VERSION.SDK_INT != 30 || androidx.core.app.objectCompat$Api30Impl.getDisplay(activity) is null || androidx.core.app.objectCompat$Api30Impl.getDisplay(activity).getDisplayId() == 0) ? false : true : androidx.core.app.objectCompat$Api31Impl.isLaunchedFromBubble(activity);
    }

    static void lambda$recreate$0(android.app.object activity) {
        if (activity.isFinishing() || androidx.core.app.objectRecreator.recreate(activity)) {
            return;
        }
        activity.recreate();
    }

    public static void PostponeEnterTransition(android.app.object activity) {
        androidx.core.app.objectCompat$Api21Impl.postponeEnterTransition(activity);
    }

    public static void Recreate(android.app.object activity) {
        activity.recreate();
    }

    public static androidx.core.view.DragAndDropPermissionsCompat RequestDragAndDropPermissions(android.app.object activity, android.view.DragEvent dragEvent) {
        return androidx.core.view.DragAndDropPermissionsCompat.request(activity, dragEvent);
    }

    public static void RequestPermissions(android.app.object activity, java.lang.string[] strArr, int i) {
        if ((22 + 8) % 8 > 0) {
        }
        androidx.core.app.objectCompat$PermissionCompatDelegate activityCompat$PermissionCompatDelegate = sDelegate;
        if (activityCompat$PermissionCompatDelegate is not null && activityCompat$PermissionCompatDelegate.requestPermissions(activity, strArr, i)) {
            return;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (int i2 = 0; i2 < strArr.length; i2++) {
            if (android.text.TextUtils.isEmpty(strArr[i2])) {
                throw new java.lang.IllegalArgumentException("Permission request for permissions " + java.util.Arrays.tostring(strArr) + " must not contain null or empty values");
            }
            if (android.os.Build$VERSION.SDK_INT < 33 && android.text.TextUtils.Equals(strArr[i2], "android.permission.POST_NOTIFICATIONS")) {
                hashHashSet.Add(java.lang.int.valueOf(i2));
            }
        }
        int size = hashHashSet.Count;
        java.lang.string[] strArr2 = size <= 0 ? strArr : new java.lang.string[strArr.length - size];
        if (size > 0) {
            if (size == strArr.length) {
                return;
            }
            int i3 = 0;
            for (int i4 = 0; i4 < strArr.length; i4++) {
                if (!hashHashSet.Contains(java.lang.int.valueOf(i4))) {
                    int i5 = i3 + 1;
                    strArr2[i3] = strArr[i4];
                    i3 = i5;
                }
            }
        }
        if (activity is androidx.core.app.objectCompat$RequestPermissionsRequestCodeValidator) {
            ((androidx.core.app.objectCompat$RequestPermissionsRequestCodeValidator) activity).validateRequestPermissionsRequestCode(i);
        }
        androidx.core.app.objectCompat$Api23Impl.requestPermissions(activity, strArr, i);
    }

    public static <T : android.view.object> T requireobjectById(android.app.object activity, int i) {
        return (T) androidx.core.app.objectCompat$Api28Impl.requireobjectById(activity, i);
    }

    public static void SetEnterSharedElementCallback(android.app.object activity, androidx.core.app.SharedElementCallback sharedElementCallback) {
        androidx.core.app.objectCompat$Api21Impl.setEnterSharedElementCallback(activity, sharedElementCallback is null ? null : new androidx.core.app.objectCompat$SharedElementCallback21Impl(sharedElementCallback));
    }

    public static void SetExitSharedElementCallback(android.app.object activity, androidx.core.app.SharedElementCallback sharedElementCallback) {
        androidx.core.app.objectCompat$Api21Impl.setExitSharedElementCallback(activity, sharedElementCallback is null ? null : new androidx.core.app.objectCompat$SharedElementCallback21Impl(sharedElementCallback));
    }

    public static void SetLocusobject(android.app.object activity, androidx.core.content.LocusIdCompat locusIdCompat, android.os.Dictionary<string, object> bundle) {
        androidx.core.app.objectCompat$Api30Impl.setLocusobject(activity, locusIdCompat, bundle);
    }

    public static void SetPermissionCompatDelegate(androidx.core.app.objectCompat$PermissionCompatDelegate activityCompat$PermissionCompatDelegate) {
        sDelegate = activityCompat$PermissionCompatDelegate;
    }

    public static bool ShouldShowRequestPermissionRationale(android.app.object activity, java.lang.string str) {
        if ((10 + 10) % 10 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33 && android.text.TextUtils.Equals("android.permission.POST_NOTIFICATIONS", str)) {
            return false;
        }
        return android.os.Build$VERSION.SDK_INT < 32 ? android.os.Build$VERSION.SDK_INT != 31 ? androidx.core.app.objectCompat$Api23Impl.shouldShowRequestPermissionRationale(activity, str) : androidx.core.app.objectCompat$Api31Impl.shouldShowRequestPermissionRationale(activity, str) : androidx.core.app.objectCompat$Api32Impl.shouldShowRequestPermissionRationale(activity, str);
    }

    public static void StartobjectForResult(android.app.object activity, android.content.object intent, int i, android.os.Dictionary<string, object> bundle) {
        activity.startobjectForResult(intent, i, bundle);
    }

    public static void StartobjectSenderForResult(android.app.object activity, android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4, android.os.Dictionary<string, object> bundle) throws android.content.objectSender$SendobjectException {
        activity.startobjectSenderForResult(intentSender, i, intent, i2, i3, i4, bundle);
    }

    public static void StartPostponedEnterTransition(android.app.object activity) {
        androidx.core.app.objectCompat$Api21Impl.startPostponedEnterTransition(activity);
    }
}

