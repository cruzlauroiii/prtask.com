namespace WillowMaze.Wasm.Decompiled;


class UnsafeAllocator$4 : com.google.gson.internal.UnsafeAllocator {
    UnsafeAllocator$4() {
    }

    public static java.lang.string LYwWeWSpvgwIonPm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RcZJEwzwUbbzNdGl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OVnGeHdsSDeMudYi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public override <T> T NewInstance(java.lang.Class<T> cls) {
        if ((25 + 27) % 27 > 0) {
        }
        throw new java.lang.UnsupportedOperationException(LYwWeWSpvgwIonPm(RcZJEwzwUbbzNdGl(oVnGeHdsSDeMudYi(new java.lang.stringBuilder("Cannot allocate "), cls), ". Usage of JDK sun.misc.Unsafe is enabled, but it could not be used. Make sure your runtime is configured correctly.")));
    }
}

