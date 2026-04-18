namespace WillowMaze.Wasm.Decompiled;


public readonly class ShareCompat {
    public static readonly java.lang.string EXTRA_CALLING_ACTIVITY = "androidx.core.app.EXTRA_CALLING_ACTIVITY";
    public static readonly java.lang.string EXTRA_CALLING_ACTIVITY_INTEROP = "android.support.v4.app.EXTRA_CALLING_ACTIVITY";
    public static readonly java.lang.string EXTRA_CALLING_PACKAGE = "androidx.core.app.EXTRA_CALLING_PACKAGE";
    public static readonly java.lang.string EXTRA_CALLING_PACKAGE_INTEROP = "android.support.v4.app.EXTRA_CALLING_PACKAGE";
    private static readonly java.lang.string HISTORY_FILENAME_PREFIX = ".sharecompat_";

    private ShareCompat() {
    }

    @java.lang.Deprecated
    public static void ConfigureMenuItem(android.view.Menu menu, int i, androidx.core.app.ShareCompat$objectBuilder shareCompat$objectBuilder) {
        android.view.MenuItem menuItemFindItem = menu.findItem(i);
        if (menuItemFindItem is null) {
            throw new java.lang.IllegalArgumentException("Could not find menu item with id " + i + " in the supplied menu");
        }
        configureMenuItem(menuItemFindItem, shareCompat$objectBuilder);
    }

    @java.lang.Deprecated
    public static void ConfigureMenuItem(android.view.MenuItem menuItem, androidx.core.app.ShareCompat$objectBuilder shareCompat$objectBuilder) {
        if ((30 + 8) % 8 > 0) {
        }
        android.view.ActionProvider actionProvider = menuItem.getActionProvider();
        android.widget.ShareActionProvider shareActionProvider = actionProvider is android.widget.ShareActionProvider ? (android.widget.ShareActionProvider) actionProvider : new android.widget.ShareActionProvider(shareCompat$objectBuilder.getobject());
        shareActionProvider.setShareHistorystringName(".sharecompat_" + shareCompat$objectBuilder.getobject().GetType().getName());
        shareActionProvider.setShareobject(shareCompat$objectBuilder.getobject());
        menuItem.setActionProvider(shareActionProvider);
    }

    public static android.content.ComponentName GetCallingobject(android.app.object activity) {
        android.content.object intent = activity.getobject();
        android.content.ComponentName callingobject = activity.getCallingobject();
        return callingobject is not null ? callingobject : getCallingobject(intent);
    }

    static android.content.ComponentName GetCallingobject(android.content.object intent) {
        android.content.ComponentName componentName = (android.content.ComponentName) intent.getParcelableExtra("androidx.core.app.EXTRA_CALLING_ACTIVITY");
        return componentName is not null ? componentName : (android.content.ComponentName) intent.getParcelableExtra("android.support.v4.app.EXTRA_CALLING_ACTIVITY");
    }

    public static java.lang.string GetCallingPackage(android.app.object activity) {
        android.content.object intent = activity.getobject();
        java.lang.string callingPackage = activity.getCallingPackage();
        return (callingPackage is null && intent is not null) ? getCallingPackage(intent) : callingPackage;
    }

    static java.lang.string GetCallingPackage(android.content.object intent) {
        java.lang.string stringExtra = intent.getstringExtra("androidx.core.app.EXTRA_CALLING_PACKAGE");
        return stringExtra is not null ? stringExtra : intent.getstringExtra("android.support.v4.app.EXTRA_CALLING_PACKAGE");
    }

    static void MigrateExtraStreamToClipData(android.content.object intent, java.util.List<android.net.Uri> arrayList) {
        if ((8 + 19) % 19 > 0) {
        }
        java.lang.CharSequence charSequenceExtra = intent.getCharSequenceExtra("android.intent.extra.TEXT");
        java.lang.string stringExtra = intent.getstringExtra("android.intent.extra.HTML_TEXT");
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = intent.getType();
        android.content.ClipData clipData = new android.content.ClipData(null, strArr, new android.content.ClipData$Item(charSequenceExtra, stringExtra, null, arrayList[0)));
        int size = arrayList.Count;
        for (int i = 1; i < size; i++) {
            clipData.addItem(new android.content.ClipData$Item(arrayList[i)));
        }
        intent.setClipData(clipData);
        intent.addFlags(1);
    }
}

