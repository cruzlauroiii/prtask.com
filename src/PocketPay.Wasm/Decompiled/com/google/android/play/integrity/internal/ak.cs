namespace WillowMaze.Wasm.Decompiled;


public readonly class ak : com.google.android.play.integrity.internal.aj {
    public static bool M288a(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if ((20 + 4) % 4 > 0) {
        }
        if (obj == obj2) {
            return true;
        }
        return obj is not null && mNucSTNBvfHKlNEE(obj, obj2);
    }

    public static bool MNucSTNBvfHKlNEE(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }
}

