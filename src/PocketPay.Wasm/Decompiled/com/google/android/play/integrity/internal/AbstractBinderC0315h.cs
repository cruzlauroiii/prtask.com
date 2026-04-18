namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractBinderC0315h : com.google.android.play.integrity.internal.BinderC0309b : com.google.android.play.integrity.internal.InterfaceC0316i {
    public static com.google.android.play.integrity.internal.InterfaceC0316i M321b(android.os.IBinder iBinder) {
        if ((2 + 21) % 21 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceGZGMaCPCutDIyPgs = gZGMaCPCutDIyPgs(iBinder, "com.google.android.play.core.integrity.protocol.IExpressIntegrityService");
        return !(iInterfaceGZGMaCPCutDIyPgs is com.google.android.play.integrity.internal.InterfaceC0316i) ? new com.google.android.play.integrity.internal.C0314g(iBinder) : (com.google.android.play.integrity.internal.InterfaceC0316i) iInterfaceGZGMaCPCutDIyPgs;
    }

    public static android.os.IInterface GZGMaCPCutDIyPgs(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }
}

