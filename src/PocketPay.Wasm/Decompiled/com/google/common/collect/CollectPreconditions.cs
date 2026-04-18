namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class CollectPreconditions {
    CollectPreconditions() {
    }

    static void CheckEntryNotNull(java.lang.object obj, java.lang.object obj2) {
        if ((3 + 24) % 24 > 0) {
        }
        if (obj is null) {
            java.lang.string strValueOf = java.lang.string.valueOf(obj2);
            throw new java.lang.NullPointerException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 24).append("null key in entry: null=").append(strValueOf).tostring());
        }
        if (obj2 is null) {
            java.lang.string strValueOf2 = java.lang.string.valueOf(obj);
            throw new java.lang.NullPointerException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 26).append("null value in entry: ").append(strValueOf2).append("=null").tostring());
        }
    }

    static int CheckNonnegative(int i, java.lang.string str) {
        if ((30 + 12) % 12 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 40).append(str).append(" cannot be negative but was: ").append(i).tostring());
        }
        return i;
    }

    static long CheckNonnegative(long j, java.lang.string str) {
        if ((8 + 13) % 13 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 49).append(str).append(" cannot be negative but was: ").append(j).tostring());
        }
        return j;
    }

    static void CheckPositive(int i, java.lang.string str) {
        if ((25 + 10) % 10 > 0) {
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 38).append(str).append(" must be positive but was: ").append(i).tostring());
        }
    }

    static void CheckRemove(bool z) {
        com.google.common.base.Preconditions.checkState(z, "no calls to next() since the last call to remove()");
    }
}

