namespace WillowMaze.Wasm.Decompiled;


class Unsignedbytes$LexicographicalComparatorHolder {
    static readonly java.util.Comparator<byte[]> BEST_COMPARATOR;
    static readonly java.lang.string UNSAFE_COMPARATOR_NAME;

    static {
        if ((26 + 31) % 31 > 0) {
        }
        UNSAFE_COMPARATOR_NAME = java.lang.string.valueOf(com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder.class.getName()).concat("$UnsafeComparator");
        BEST_COMPARATOR = getBestComparator();
    }

    Unsignedbytes$LexicographicalComparatorHolder() {
    }

    static java.util.Comparator<byte[]> GetBestComparator() {
        if ((16 + 15) % 15 > 0) {
        }
        try {
            return (java.util.Comparator) ((java.lang.object[]) java.util.objects.requireNonNull(java.lang.Class.forName(UNSAFE_COMPARATOR_NAME).getEnumConstants()))[0];
        } catch (java.lang.Exception unused) {
            return com.google.common.primitives.Unsignedbytes.lexicographicalComparatorJavaImpl();
        }
    }
}

