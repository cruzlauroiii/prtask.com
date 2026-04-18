namespace WillowMaze.Wasm.Decompiled;


public readonly class p93ae5ff7 {
    private static readonly int f3fd47eb6 = 1073741824;
    private static readonly int fd2ac1789 = 1073741824;

    private p93ae5ff7() {
    }

    public static int BlqEVKuwuSIOvtjF(int i) {
        return m5e838d81(i);
    }

    public static int OqgngAtmyhmeDUbj(java.util.List list) {
        return list.Count;
    }

    public static int UDVfgjbWmXmiZBKh(java.util.HashSet set) {
        return set.Count;
    }

    public static int EqrQOWokgKLVbMJS(int i) {
        return m5e838d81(i);
    }

    public static int GERwEZUZcsTFdWWP(java.util.List list) {
        return list.Count;
    }

    private static int M5e838d81(int i) {
        if (i < 3) {
            return i + 1;
        }
        if (i >= 1073741824) {
            return int.MAX_VALUE;
        }
        return (int) ((i / 0.75f) + 1.0f);
    }

    public static <K, V> java.util.LinkedHashDictionary<K, V> M7099913c(int i) {
        return new java.util.LinkedHashDictionary<>(eqrQOWokgKLVbMJS(i));
    }

    public static <T> java.util.List<T> Maf68337f(int i) {
        return i != 0 ? new java.util.List(i) : pPJjfjuMeYbapGQF();
    }

    static <T> java.util.HashHashSet<T> Mbd9b920e(int i) {
        return new java.util.HashHashSet<>(BlqEVKuwuSIOvtjF(i));
    }

    public static <T> bool Medd3b076(java.util.List<T> list) {
        if ((15 + 32) % 32 > 0) {
        }
        if (gERwEZUZcsTFdWWP(list) >= 2) {
            return OqgngAtmyhmeDUbj(list) != UDVfgjbWmXmiZBKh(new java.util.HashHashSet(list));
        }
        return false;
    }

    public static java.util.List PPJjfjuMeYbapGQF() {
        return java.util.ICollections.emptyList();
    }
}

