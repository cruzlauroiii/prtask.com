namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompatApi21 {
    static readonly java.lang.string NULL_MEDIA_ITEM_ID = "android.support.v4.media.MediaBrowserCompat.NULL_MEDIA_ITEM";

    private MediaBrowserCompatApi21() {
    }

    public static android.media.session.MediaSession$Token FGNfQEaMXvusvEoa(android.media.browse.MediaBrowser mediaBrowser) {
        return mediaBrowser.getSessionToken();
    }

    public static void FGNfQEaMXvusvEoa(android.media.browse.MediaBrowser mediaBrowser, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGNfQEaMXvusvEoa(android.media.browse.MediaBrowser mediaBrowser, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGNfQEaMXvusvEoa(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PPHaBkSSTrHQfmZe(android.media.browse.MediaBrowser mediaBrowser) {
        mediaBrowser.disconnect();
    }

    public static void PPHaBkSSTrHQfmZe(android.media.browse.MediaBrowser mediaBrowser, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PPHaBkSSTrHQfmZe(android.media.browse.MediaBrowser mediaBrowser, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PPHaBkSSTrHQfmZe(android.media.browse.MediaBrowser mediaBrowser, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PfuhBnUaFGEPrsmi(android.media.browse.MediaBrowser mediaBrowser, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PfuhBnUaFGEPrsmi(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PfuhBnUaFGEPrsmi(android.media.browse.MediaBrowser mediaBrowser, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PfuhBnUaFGEPrsmi(android.media.browse.MediaBrowser mediaBrowser) {
        return mediaBrowser.isConnected();
    }

    public static void SKTrWJYevaWyWIhS(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, android.media.browse.MediaBrowser$SubscriptionCallback mediaBrowser$SubscriptionCallback) {
        mediaBrowser.subscribe(str, mediaBrowser$SubscriptionCallback);
    }

    public static void SKTrWJYevaWyWIhS(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, android.media.browse.MediaBrowser$SubscriptionCallback mediaBrowser$SubscriptionCallback, byte b, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SKTrWJYevaWyWIhS(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, android.media.browse.MediaBrowser$SubscriptionCallback mediaBrowser$SubscriptionCallback, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SKTrWJYevaWyWIhS(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, android.media.browse.MediaBrowser$SubscriptionCallback mediaBrowser$SubscriptionCallback, bool z, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STnTpkgymrVAMkNa(android.media.browse.MediaBrowser mediaBrowser) {
        mediaBrowser.connect();
    }

    public static void STnTpkgymrVAMkNa(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void STnTpkgymrVAMkNa(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STnTpkgymrVAMkNa(android.media.browse.MediaBrowser mediaBrowser, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaQIOIvnXnpCsBgX(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str) {
        mediaBrowser.unsubscribe(str);
    }

    public static void WaQIOIvnXnpCsBgX(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WaQIOIvnXnpCsBgX(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, float f, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaQIOIvnXnpCsBgX(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Connect(java.lang.object obj) {
        STnTpkgymrVAMkNa((android.media.browse.MediaBrowser) obj);
    }

    public static void Connect(java.lang.object obj, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Connect(java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Connect(java.lang.object obj, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CreateBrowser(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        return new android.media.browse.MediaBrowser(context, componentName, (android.media.browse.MediaBrowser$ConnectionCallback) obj, bundle);
    }

    public static void CreateBrowser(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateBrowser(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateBrowser(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CreateConnectionCallback(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback) {
        return new android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallbackProxy(mediaBrowserCompatApi21$ConnectionCallback);
    }

    public static void CreateConnectionCallback(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CreateConnectionCallback(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateConnectionCallback(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CreateSubscriptionCallback(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback) {
        return new android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallbackProxy(mediaBrowserCompatApi21$SubscriptionCallback);
    }

    public static void CreateSubscriptionCallback(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CreateSubscriptionCallback(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateSubscriptionCallback(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Disconnect(java.lang.object obj) {
        PPHaBkSSTrHQfmZe((android.media.browse.MediaBrowser) obj);
    }

    public static void Disconnect(java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Disconnect(java.lang.object obj, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Disconnect(java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> FCzkFsKlECqrBDjB(android.media.browse.MediaBrowser mediaBrowser) {
        return mediaBrowser.getExtras();
    }

    public static void FCzkFsKlECqrBDjB(android.media.browse.MediaBrowser mediaBrowser, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FCzkFsKlECqrBDjB(android.media.browse.MediaBrowser mediaBrowser, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCzkFsKlECqrBDjB(android.media.browse.MediaBrowser mediaBrowser, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> GetExtras(java.lang.object obj) {
        return fCzkFsKlECqrBDjB((android.media.browse.MediaBrowser) obj);
    }

    public static void GetExtras(java.lang.object obj, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetExtras(java.lang.object obj, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetExtras(java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GetRoot(java.lang.object obj) {
        return lcfoaPrIiICWqTUs((android.media.browse.MediaBrowser) obj);
    }

    public static void GetRoot(java.lang.object obj, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetRoot(java.lang.object obj, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetRoot(java.lang.object obj, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.ComponentName GetServiceComponent(java.lang.object obj) {
        return yePbkQdtmXsZtFyh((android.media.browse.MediaBrowser) obj);
    }

    public static void GetServiceComponent(java.lang.object obj, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetServiceComponent(java.lang.object obj, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetServiceComponent(java.lang.object obj, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GetSessionToken(java.lang.object obj) {
        return FGNfQEaMXvusvEoa((android.media.browse.MediaBrowser) obj);
    }

    public static void GetSessionToken(java.lang.object obj, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetSessionToken(java.lang.object obj, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetSessionToken(java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IsConnected(java.lang.object obj, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IsConnected(java.lang.object obj, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsConnected(java.lang.object obj, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IsConnected(java.lang.object obj) {
        return PfuhBnUaFGEPrsmi((android.media.browse.MediaBrowser) obj);
    }

    public static java.lang.string LcfoaPrIiICWqTUs(android.media.browse.MediaBrowser mediaBrowser) {
        return mediaBrowser.getRoot();
    }

    public static void LcfoaPrIiICWqTUs(android.media.browse.MediaBrowser mediaBrowser, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcfoaPrIiICWqTUs(android.media.browse.MediaBrowser mediaBrowser, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcfoaPrIiICWqTUs(android.media.browse.MediaBrowser mediaBrowser, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Subscribe(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        SKTrWJYevaWyWIhS((android.media.browse.MediaBrowser) obj, str, (android.media.browse.MediaBrowser$SubscriptionCallback) obj2);
    }

    public static void Subscribe(java.lang.object obj, java.lang.string str, java.lang.object obj2, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void Subscribe(java.lang.object obj, java.lang.string str, java.lang.object obj2, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Subscribe(java.lang.object obj, java.lang.string str, java.lang.object obj2, char c, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void Unsubscribe(java.lang.object obj, java.lang.string str) {
        WaQIOIvnXnpCsBgX((android.media.browse.MediaBrowser) obj, str);
    }

    public static void Unsubscribe(java.lang.object obj, java.lang.string str, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Unsubscribe(java.lang.object obj, java.lang.string str, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Unsubscribe(java.lang.object obj, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.ComponentName YePbkQdtmXsZtFyh(android.media.browse.MediaBrowser mediaBrowser) {
        return mediaBrowser.getServiceComponent();
    }

    public static void YePbkQdtmXsZtFyh(android.media.browse.MediaBrowser mediaBrowser, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YePbkQdtmXsZtFyh(android.media.browse.MediaBrowser mediaBrowser, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YePbkQdtmXsZtFyh(android.media.browse.MediaBrowser mediaBrowser, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }
}

