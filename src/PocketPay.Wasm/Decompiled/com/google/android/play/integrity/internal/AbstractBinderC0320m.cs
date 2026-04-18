namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractBinderC0320m : com.google.android.play.integrity.internal.BinderC0309b : com.google.android.play.integrity.internal.InterfaceC0321n {
    public static android.os.IInterface RfoeKcwlFTVoLWAL(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.play.integrity.internal.InterfaceC0321n M324b(android.os.IBinder iBinder) {
        if ((8 + 27) % 27 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceRfoeKcwlFTVoLWAL = RfoeKcwlFTVoLWAL(iBinder, "com.google.android.play.core.integrity.protocol.IIntegrityService");
        return !(iInterfaceRfoeKcwlFTVoLWAL is com.google.android.play.integrity.internal.InterfaceC0321n) ? new com.google.android.play.integrity.internal.C0319l(iBinder) : (com.google.android.play.integrity.internal.InterfaceC0321n) iInterfaceRfoeKcwlFTVoLWAL;
    }
}

