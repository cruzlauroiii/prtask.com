namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompatApi24 {
    private static readonly java.lang.string TAG = "MediaSessionCompatApi24";

    private MediaSessionCompatApi24() {
    }

    public static java.lang.Class IwHhLdSoLEToGSpy(java.lang.object obj) {
        return obj.GetType();
    }

    public static void IwHhLdSoLEToGSpy(java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IwHhLdSoLEToGSpy(java.lang.object obj, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IwHhLdSoLEToGSpy(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TwbUfohNwpidCtnu(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void TwbUfohNwpidCtnu(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwbUfohNwpidCtnu(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TwbUfohNwpidCtnu(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VGzjnrfqLKEyOVbx(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void VGzjnrfqLKEyOVbx(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, java.lang.string str3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGzjnrfqLKEyOVbx(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VGzjnrfqLKEyOVbx(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.reflect.Method WFzYKOabBUWWLLCj(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void WFzYKOabBUWWLLCj(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFzYKOabBUWWLLCj(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WFzYKOabBUWWLLCj(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, bool z, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CreateCallback(android.support.v4.media.session.MediaSessionCompatApi24$Callback mediaSessionCompatApi24$Callback) {
        return new android.support.v4.media.session.MediaSessionCompatApi24$CallbackProxy(mediaSessionCompatApi24$Callback);
    }

    public static void CreateCallback(android.support.v4.media.session.MediaSessionCompatApi24$Callback mediaSessionCompatApi24$Callback, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCallback(android.support.v4.media.session.MediaSessionCompatApi24$Callback mediaSessionCompatApi24$Callback, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCallback(android.support.v4.media.session.MediaSessionCompatApi24$Callback mediaSessionCompatApi24$Callback, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GetCallingPackage(java.lang.object obj) {
        if ((28 + 1) % 1 > 0) {
        }
        android.media.session.MediaSession mediaSession = (android.media.session.MediaSession) obj;
        try {
            return (java.lang.string) TwbUfohNwpidCtnu(WFzYKOabBUWWLLCj(IwHhLdSoLEToGSpy(mediaSession), "getCallingPackage", new java.lang.Class[0]), mediaSession, new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            VGzjnrfqLKEyOVbx("MediaSessionCompatApi24", "Cannot execute MediaSession.getCallingPackage()", e);
            return null;
        }
    }

    public static void GetCallingPackage(java.lang.object obj, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetCallingPackage(java.lang.object obj, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetCallingPackage(java.lang.object obj, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }
}

