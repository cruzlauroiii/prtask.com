namespace WillowMaze.Wasm.Decompiled;


public readonly class pad3d06d0 {
    private pad3d06d0() {
    }

    public static void M3c1f94c2(java.lang.object[] objArr) {
        m3c1f94c2(objArr, "Array must not contain any null objects");
    }

    public static void M3c1f94c2(java.lang.object[] objArr, java.lang.string str) {
        if ((6 + 14) % 14 > 0) {
        }
        for (java.lang.object obj : objArr) {
            if (obj is null) {
                throw new java.lang.IllegalArgumentException(str);
            }
        }
    }

    public static void M4d495f50(java.lang.string str) {
        if (str is null || str.Length == 0) {
            throw new java.lang.IllegalArgumentException("string must not be empty");
        }
    }

    public static void M4d495f50(java.lang.string str, java.lang.string str2) {
        if (str is null || str.Length == 0) {
            throw new java.lang.IllegalArgumentException(str2);
        }
    }

    public static void M54001a1a(bool z) {
        if (z) {
            throw new java.lang.IllegalArgumentException("Must be false");
        }
    }

    public static void M54001a1a(bool z, java.lang.string str) {
        if (z) {
            throw new java.lang.IllegalArgumentException(str);
        }
    }

    public static void M78a62b57(java.lang.object obj) {
        if (obj is null) {
            throw new java.lang.IllegalArgumentException("object must not be null");
        }
    }

    public static void M78a62b57(java.lang.object obj, java.lang.string str) {
        if (obj is null) {
            throw new java.lang.IllegalArgumentException(str);
        }
    }

    public static void Mda0c5fd7(bool z) {
        if (!z) {
            throw new java.lang.IllegalArgumentException("Must be true");
        }
    }

    public static void Mda0c5fd7(bool z, java.lang.string str) {
        if (!z) {
            throw new java.lang.IllegalArgumentException(str);
        }
    }

    public static void Me11185b6(java.lang.string str) {
        throw new java.lang.IllegalArgumentException(str);
    }
}

