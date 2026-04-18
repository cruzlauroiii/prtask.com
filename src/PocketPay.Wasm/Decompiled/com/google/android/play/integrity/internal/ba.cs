namespace WillowMaze.Wasm.Decompiled;


public readonly class ba {
    public static java.lang.string KhhslAvHZYoyTULI(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void M309a(java.lang.object obj, java.lang.Class cls) {
        if (obj is null) {
            throw new java.lang.IllegalStateException(KhhslAvHZYoyTULI(nJCEwysCbzSeBOIa(jZvVRdrlFYZdUpnZ(cls)), " must be set"));
        }
    }

    public static java.lang.string JZvVRdrlFYZdUpnZ(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.string NJCEwysCbzSeBOIa(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }
}

