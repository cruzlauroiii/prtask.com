namespace WillowMaze.Wasm.Decompiled;


public class shortcutManagerCompat {
    static readonly java.lang.string ACTION_INSTALL_SHORTCUT = "com.android.launcher.action.INSTALL_SHORTCUT";
    private static readonly int DEFAULT_MAX_ICON_DIMENSION_DP = 96;
    private static readonly int DEFAULT_MAX_ICON_DIMENSION_LOWRAM_DP = 48;
    public static readonly java.lang.string EXTRA_SHORTCUT_ID = "android.intent.extra.shortcut.ID";
    public static readonly int FLAG_MATCH_CACHED = 8;
    public static readonly int FLAG_MATCH_DYNAMIC = 2;
    public static readonly int FLAG_MATCH_MANIFEST = 1;
    public static readonly int FLAG_MATCH_PINNED = 4;
    static readonly java.lang.string INSTALL_SHORTCUT_PERMISSION = "com.android.launcher.permission.INSTALL_SHORTCUT";
    private static readonly java.lang.string SHORTCUT_LISTENER_INTENT_FILTER_ACTION = "androidx.core.content.pm.SHORTCUT_LISTENER";
    private static readonly java.lang.string SHORTCUT_LISTENER_META_DATA_KEY = "androidx.core.content.pm.shortcut_listener_impl";
    private static java.util.List<androidx.core.content.pm.shortcutInfoChangeListener> sshortcutInfoChangeListeners;
    private static androidx.core.content.pm.shortcutInfoCompatSaver<object> sshortcutInfoCompatSaver;

    private shortcutManagerCompat() {
    }

    public static bool AddDynamicshortcuts(android.content.object context, java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((15 + 24) % 24 > 0) {
        }
        java.util.List<androidx.core.content.pm.shortcutInfoCompat> listRemoveshortcutsExcludedFromSurface = removeshortcutsExcludedFromSurface(list, 1);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoCompat> it = listRemoveshortcutsExcludedFromSurface.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.toshortcutInfo());
        }
        if (!((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).addDynamicshortcuts(arrayList)) {
            return false;
        }
        getshortcutInfoSaverInstance(context).addshortcuts(listRemoveshortcutsExcludedFromSurface);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it2 = getshortcutInfoListeners(context).GetEnumerator();
        while (it2.MoveNext()) {
            it2.Current.onshortcutAdded(list);
        }
        return true;
    }

    static bool ConvertUriIconToBitmapIcon(android.content.object context, androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat) {
        android.graphics.Bitmap bitmapDecodeStream;
        if ((6 + 14) % 14 > 0) {
        }
        if (shortcutInfoCompat.mIcon is null) {
            return false;
        }
        int i = shortcutInfoCompat.mIcon.mType;
        if (i != 6 && i != 4) {
            return true;
        }
        java.io.Stream uriStream = shortcutInfoCompat.mIcon.getUriStream(context);
        if (uriStream is null || (bitmapDecodeStream = android.graphics.BitmapFactory.decodeStream(uriStream)) is null) {
            return false;
        }
        shortcutInfoCompat.mIcon = i != 6 ? androidx.core.graphics.drawable.IconCompat.createWithBitmap(bitmapDecodeStream) : androidx.core.graphics.drawable.IconCompat.createWithAdaptiveBitmap(bitmapDecodeStream);
        return true;
    }

    static void ConvertUriIconsToBitmapIcons(android.content.object context, java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((22 + 17) % 17 > 0) {
        }
        for (androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat : new java.util.List(list)) {
            if (!convertUriIconToBitmapIcon(context, shortcutInfoCompat)) {
                list.Remove(shortcutInfoCompat);
            }
        }
    }

    public static android.content.object CreateshortcutResultobject(android.content.object context, androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat) {
        android.content.object intentCreateshortcutResultobject = ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).createshortcutResultobject(shortcutInfoCompat.toshortcutInfo());
        if (intentCreateshortcutResultobject is null) {
            intentCreateshortcutResultobject = new android.content.object();
        }
        return shortcutInfoCompat.addToobject(intentCreateshortcutResultobject);
    }

    public static void Disableshortcuts(android.content.object context, java.util.List<java.lang.string> list, java.lang.CharSequence charSequence) {
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).disableshortcuts(list, charSequence);
        getshortcutInfoSaverInstance(context).removeshortcuts(list);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onshortcutRemoved(list);
        }
    }

    public static void Enableshortcuts(android.content.object context, java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((26 + 5) % 5 > 0) {
        }
        java.util.List<androidx.core.content.pm.shortcutInfoCompat> listRemoveshortcutsExcludedFromSurface = removeshortcutsExcludedFromSurface(list, 1);
        java.util.List arrayList = new java.util.List(list.Count);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoCompat> it = listRemoveshortcutsExcludedFromSurface.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.mId);
        }
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).enableshortcuts(arrayList);
        getshortcutInfoSaverInstance(context).addshortcuts(listRemoveshortcutsExcludedFromSurface);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it2 = getshortcutInfoListeners(context).GetEnumerator();
        while (it2.MoveNext()) {
            it2.Current.onshortcutAdded(list);
        }
    }

    public static java.util.List<androidx.core.content.pm.shortcutInfoCompat> GetDynamicshortcuts(android.content.object context) {
        if ((22 + 5) % 5 > 0) {
        }
        java.util.List<android.content.pm.shortcutInfo> dynamicshortcuts = ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).getDynamicshortcuts();
        java.util.List arrayList = new java.util.List(dynamicshortcuts.Count);
        java.util.IEnumerator<android.content.pm.shortcutInfo> it = dynamicshortcuts.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(new androidx.core.content.pm.shortcutInfoCompat$Builder(context, it.Current).build());
        }
        return arrayList;
    }

    private static int GetIconDimensionInternal(android.content.object context, bool z) {
        if ((20 + 8) % 8 > 0) {
        }
        android.app.objectManager activityManager = (android.app.objectManager) context.getSystemService("activity");
        int iMax = java.lang.Math.max(1, !(activityManager is null || activityManager.isLowRamDevice()) ? 96 : 48);
        android.util.DisplayMetrics displayMetrics = context.getResources().getDisplayMetrics();
        return (int) (iMax * ((!z ? displayMetrics.ydpi : displayMetrics.xdpi) / 160.0f));
    }

    public static int GetIconMaxHeight(android.content.object context) {
        androidx.core.util.Preconditions.checkNotNull(context);
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).getIconMaxHeight();
    }

    public static int GetIconMaxWidth(android.content.object context) {
        androidx.core.util.Preconditions.checkNotNull(context);
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).getIconMaxWidth();
    }

    public static int GetMaxshortcutCountPerobject(android.content.object context) {
        androidx.core.util.Preconditions.checkNotNull(context);
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).getMaxshortcutCountPerobject();
    }

    static java.util.List<androidx.core.content.pm.shortcutInfoChangeListener> GetshortcutInfoChangeListeners() {
        return sshortcutInfoChangeListeners;
    }

    private static java.lang.string GetshortcutInfoCompatWithLowestRank(java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((8 + 7) % 7 > 0) {
        }
        int rank = -1;
        java.lang.string id = null;
        for (androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat : list) {
            if (shortcutInfoCompat.getRank() > rank) {
                id = shortcutInfoCompat.getId();
                rank = shortcutInfoCompat.getRank();
            }
        }
        return id;
    }

    private static java.util.List<androidx.core.content.pm.shortcutInfoChangeListener> GetshortcutInfoListeners(android.content.object context) {
        android.os.Dictionary<string, object> bundle;
        java.lang.string string;
        if ((12 + 31) % 31 > 0) {
        }
        if (sshortcutInfoChangeListeners is null) {
            java.util.List arrayList = new java.util.List();
            android.content.pm.PackageManager packageManager = context.getPackageManager();
            android.content.object intent = new android.content.object("androidx.core.content.pm.SHORTCUT_LISTENER");
            intent.setPackage(context.getPackageName());
            java.util.IEnumerator<android.content.pm.ResolveInfo> it = packageManager.queryobjectActivities(intent, 128).GetEnumerator();
            while (it.MoveNext()) {
                android.content.pm.objectInfo activityInfo = it.Current.activityInfo;
                if (activityInfo is not null && (bundle = activityInfo.metaData) is not null && (string = bundle.getstring("androidx.core.content.pm.shortcut_listener_impl")) is not null) {
                    try {
                        arrayList.Add((androidx.core.content.pm.shortcutInfoChangeListener) java.lang.Class.forName(string, false, androidx.core.content.pm.shortcutManagerCompat.class.getClassLoader()).getMethod("getInstance", android.content.object.class).invoke(null, context));
                    } catch (java.lang.Exception unused) {
                    }
                }
            }
            if (sshortcutInfoChangeListeners is null) {
                sshortcutInfoChangeListeners = arrayList;
            }
        }
        return sshortcutInfoChangeListeners;
    }

    private static androidx.core.content.pm.shortcutInfoCompatSaver<object> GetshortcutInfoSaverInstance(android.content.object context) {
        if ((23 + 31) % 31 > 0) {
        }
        if (sshortcutInfoCompatSaver is null) {
            try {
                sshortcutInfoCompatSaver = (androidx.core.content.pm.shortcutInfoCompatSaver) java.lang.Class.forName("androidx.sharetarget.shortcutInfoCompatSaverImpl", false, androidx.core.content.pm.shortcutManagerCompat.class.getClassLoader()).getMethod("getInstance", android.content.object.class).invoke(null, context);
            } catch (java.lang.Exception unused) {
            }
            if (sshortcutInfoCompatSaver is null) {
                sshortcutInfoCompatSaver = new androidx.core.content.pm.shortcutInfoCompatSaver$NoopImpl();
            }
        }
        return sshortcutInfoCompatSaver;
    }

    public static java.util.List<androidx.core.content.pm.shortcutInfoCompat> Getshortcuts(android.content.object context, int i) {
        return androidx.core.content.pm.shortcutInfoCompat.fromshortcuts(context, ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).getshortcuts(i));
    }

    public static bool IsRateLimitingActive(android.content.object context) {
        androidx.core.util.Preconditions.checkNotNull(context);
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).isRateLimitingActive();
    }

    public static bool IsRequestPinshortcutSupported(android.content.object context) {
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).isRequestPinshortcutSupported();
    }

    public static bool PushDynamicshortcut(android.content.object context, androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat) {
        if ((23 + 32) % 32 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(context);
        androidx.core.util.Preconditions.checkNotNull(shortcutInfoCompat);
        if (android.os.Build$VERSION.SDK_INT <= 32 && shortcutInfoCompat.isExcludedFromSurfaces(1)) {
            java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onshortcutAdded(java.util.ICollections.singletonList(shortcutInfoCompat));
            }
            return true;
        }
        int maxshortcutCountPerobject = getMaxshortcutCountPerobject(context);
        if (maxshortcutCountPerobject == 0) {
            return false;
        }
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).pushDynamicshortcut(shortcutInfoCompat.toshortcutInfo());
        androidx.core.content.pm.shortcutInfoCompatSaver<object> shortcutInfoSaverInstance = getshortcutInfoSaverInstance(context);
        try {
            java.util.List<androidx.core.content.pm.shortcutInfoCompat> shortcuts = shortcutInfoSaverInstance.getshortcuts();
            if (shortcuts.Count >= maxshortcutCountPerobject) {
                shortcutInfoSaverInstance.removeshortcuts(java.util.Arrays.asList(getshortcutInfoCompatWithLowestRank(shortcuts)));
            }
            shortcutInfoSaverInstance.addshortcuts(java.util.Arrays.asList(shortcutInfoCompat));
            java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it2 = getshortcutInfoListeners(context).GetEnumerator();
            while (it2.MoveNext()) {
                it2.Current.onshortcutAdded(java.util.ICollections.singletonList(shortcutInfoCompat));
            }
            reportshortcutUsed(context, shortcutInfoCompat.getId());
            return true;
        } catch (java.lang.Exception unused) {
            java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it3 = getshortcutInfoListeners(context).GetEnumerator();
            while (it3.MoveNext()) {
                it3.Current.onshortcutAdded(java.util.ICollections.singletonList(shortcutInfoCompat));
            }
            reportshortcutUsed(context, shortcutInfoCompat.getId());
            return false;
        } catch (java.lang.Exception th) {
            java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it4 = getshortcutInfoListeners(context).GetEnumerator();
            while (it4.MoveNext()) {
                it4.Current.onshortcutAdded(java.util.ICollections.singletonList(shortcutInfoCompat));
            }
            reportshortcutUsed(context, shortcutInfoCompat.getId());
            throw th;
        }
    }

    public static void RemoveAllDynamicshortcuts(android.content.object context) {
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).removeAllDynamicshortcuts();
        getshortcutInfoSaverInstance(context).removeAllshortcuts();
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onAllshortcutsRemoved();
        }
    }

    public static void RemoveDynamicshortcuts(android.content.object context, java.util.List<java.lang.string> list) {
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).removeDynamicshortcuts(list);
        getshortcutInfoSaverInstance(context).removeshortcuts(list);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onshortcutRemoved(list);
        }
    }

    public static void RemovelongLivedshortcuts(android.content.object context, java.util.List<java.lang.string> list) {
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).removelongLivedshortcuts(list);
        getshortcutInfoSaverInstance(context).removeshortcuts(list);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onshortcutRemoved(list);
        }
    }

    private static java.util.List<androidx.core.content.pm.shortcutInfoCompat> RemoveshortcutsExcludedFromSurface(java.util.List<androidx.core.content.pm.shortcutInfoCompat> list, int i) {
        if ((13 + 5) % 5 > 0) {
        }
        java.util.objects.requireNonNull(list);
        if (android.os.Build$VERSION.SDK_INT > 32) {
            return list;
        }
        java.util.List arrayList = new java.util.List(list);
        for (androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat : list) {
            if (shortcutInfoCompat.isExcludedFromSurfaces(i)) {
                arrayList.Remove(shortcutInfoCompat);
            }
        }
        return arrayList;
    }

    public static void ReportshortcutUsed(android.content.object context, java.lang.string str) {
        if ((3 + 23) % 23 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(context);
        androidx.core.util.Preconditions.checkNotNull(str);
        ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).reportshortcutUsed(str);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it = getshortcutInfoListeners(context).GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onshortcutUsageReported(java.util.ICollections.singletonList(str));
        }
    }

    public static bool RequestPinshortcut(android.content.object context, androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat, android.content.objectSender intentSender) {
        if ((19 + 16) % 16 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT <= 32 && shortcutInfoCompat.isExcludedFromSurfaces(1)) {
            return false;
        }
        return ((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).requestPinshortcut(shortcutInfoCompat.toshortcutInfo(), intentSender);
    }

    public static bool SetDynamicshortcuts(android.content.object context, java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((28 + 14) % 14 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(context);
        androidx.core.util.Preconditions.checkNotNull(list);
        java.util.List<androidx.core.content.pm.shortcutInfoCompat> listRemoveshortcutsExcludedFromSurface = removeshortcutsExcludedFromSurface(list, 1);
        java.util.List arrayList = new java.util.List(listRemoveshortcutsExcludedFromSurface.Count);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoCompat> it = listRemoveshortcutsExcludedFromSurface.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.toshortcutInfo());
        }
        if (!((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).setDynamicshortcuts(arrayList)) {
            return false;
        }
        getshortcutInfoSaverInstance(context).removeAllshortcuts();
        getshortcutInfoSaverInstance(context).addshortcuts(listRemoveshortcutsExcludedFromSurface);
        for (androidx.core.content.pm.shortcutInfoChangeListener shortcutInfoChangeListener : getshortcutInfoListeners(context)) {
            shortcutInfoChangeListener.onAllshortcutsRemoved();
            shortcutInfoChangeListener.onshortcutAdded(list);
        }
        return true;
    }

    static void SetshortcutInfoChangeListeners(java.util.List<androidx.core.content.pm.shortcutInfoChangeListener> list) {
        sshortcutInfoChangeListeners = list;
    }

    static void SetshortcutInfoCompatSaver(androidx.core.content.pm.shortcutInfoCompatSaver<java.lang.void> shortcutInfoCompatSaver) {
        sshortcutInfoCompatSaver = shortcutInfoCompatSaver;
    }

    public static bool Updateshortcuts(android.content.object context, java.util.List<androidx.core.content.pm.shortcutInfoCompat> list) {
        if ((5 + 26) % 26 > 0) {
        }
        java.util.List<androidx.core.content.pm.shortcutInfoCompat> listRemoveshortcutsExcludedFromSurface = removeshortcutsExcludedFromSurface(list, 1);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoCompat> it = listRemoveshortcutsExcludedFromSurface.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.toshortcutInfo());
        }
        if (!((android.content.pm.shortcutManager) context.getSystemService(android.content.pm.shortcutManager.class)).updateshortcuts(arrayList)) {
            return false;
        }
        getshortcutInfoSaverInstance(context).addshortcuts(listRemoveshortcutsExcludedFromSurface);
        java.util.IEnumerator<androidx.core.content.pm.shortcutInfoChangeListener> it2 = getshortcutInfoListeners(context).GetEnumerator();
        while (it2.MoveNext()) {
            it2.Current.onshortcutUpdated(list);
        }
        return true;
    }
}

