namespace WillowMaze.Wasm.Decompiled;


public class pc8308b1e {
    public static bool M2a3f81d2(java.lang.object obj, java.lang.object obj2) {
        if (obj == obj2) {
            return true;
        }
        return (obj is null || obj2 is null || !obj.Equals(obj2)) ? false : true;
    }

    public static int M550d1cc0(java.lang.object obj) {
        if (obj is not null) {
            return obj.GetHashCode();
        }
        return 0;
    }
}

