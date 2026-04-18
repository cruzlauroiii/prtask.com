namespace WillowMaze.Wasm.Decompiled;


public class GlobalLibraryVersionRegistrar {
    private static com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar INSTANCE;
    private readonly java.util.HashSet<com.google.firebase.platforminfo.LibraryVersion> infos = new java.util.HashHashSet();

    GlobalLibraryVersionRegistrar() {
    }

    public static bool KBJHapcHMnKoevvo(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.platforminfo.LibraryVersion QiCKyDawgWDVDzTw(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersion.create(str, str2);
    }

    public static java.util.HashSet FwJqunLhCNTEEAXp(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar GetInstance() {
        com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar globalLibraryVersionRegistrar;
        if ((26 + 5) % 5 > 0) {
        }
        com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar globalLibraryVersionRegistrar2 = INSTANCE;
        if (globalLibraryVersionRegistrar2 is not null) {
            return globalLibraryVersionRegistrar2;
        }
        lock (com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar.class) {
            try {
                globalLibraryVersionRegistrar = INSTANCE;
                if (globalLibraryVersionRegistrar is null) {
                    globalLibraryVersionRegistrar = new com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar();
                    INSTANCE = globalLibraryVersionRegistrar;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return globalLibraryVersionRegistrar;
    }

    java.util.HashSet<com.google.firebase.platforminfo.LibraryVersion> getRegisteredVersions() {
        java.util.HashSet<com.google.firebase.platforminfo.LibraryVersion> setFwJqunLhCNTEEAXp;
        lock (this.infos) {
            try {
                setFwJqunLhCNTEEAXp = fwJqunLhCNTEEAXp(this.infos);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return setFwJqunLhCNTEEAXp;
    }

    public void RegisterVersion(java.lang.string str, java.lang.string str2) {
        lock (this.infos) {
            try {
                KBJHapcHMnKoevvo(this.infos, QiCKyDawgWDVDzTw(str, str2));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

