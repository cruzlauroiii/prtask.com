namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : java.lang.ClassLoader {
    public static bool UyiWKLxppOamyxkB(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int EQZxWygBGsLRYcEm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool HpZPheHsrOqkVDoo(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.Class LZotuWVVkSyhEGOg(java.lang.ClassLoader classLoader, java.lang.string str, bool z) {
        return super.loadClass(str, z);
    }

    protected override readonly java.lang.Class LoadClass(java.lang.string str, bool z) throws java.lang.ClassNotFoundException {
        if (!hpZPheHsrOqkVDoo(str, "com.google.android.gms.iid.MessengerCompat")) {
            return lZotuWVVkSyhEGOg(this, str, z);
        }
        if (!UyiWKLxppOamyxkB("CloudMessengerCompat", 3)) {
            return com.google.android.gms.cloudmessaging.zzd.class;
        }
        eQZxWygBGsLRYcEm("CloudMessengerCompat", "Using renamed FirebaseIidMessengerCompat class");
        return com.google.android.gms.cloudmessaging.zzd.class;
    }
}

