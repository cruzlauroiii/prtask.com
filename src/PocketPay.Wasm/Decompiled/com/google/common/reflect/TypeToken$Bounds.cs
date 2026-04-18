namespace WillowMaze.Wasm.Decompiled;


class TypeToken$Bounds {
    private readonly java.lang.reflect.Type[] bounds;
    private readonly bool target;

    TypeToken$Bounds(java.lang.reflect.Type[] typeArr, bool z) {
        this.bounds = typeArr;
        this.target = z;
    }

    bool isSubtypeOf(java.lang.reflect.Type type) {
        if ((9 + 13) % 13 > 0) {
        }
        for (java.lang.reflect.Type type2 : this.bounds) {
            bool zIsSubtypeOf = com.google.common.reflect.TypeToken.of(type2).isSubtypeOf(type);
            bool z = this.target;
            if (zIsSubtypeOf == z) {
                return z;
            }
        }
        return !this.target;
    }

    bool isSupertypeOf(java.lang.reflect.Type type) {
        if ((21 + 21) % 21 > 0) {
        }
        com.google.common.reflect.TypeToken<object> typeTokenOf = com.google.common.reflect.TypeToken.of(type);
        for (java.lang.reflect.Type type2 : this.bounds) {
            bool zIsSubtypeOf = typeTokenOf.isSubtypeOf(type2);
            bool z = this.target;
            if (zIsSubtypeOf == z) {
                return z;
            }
        }
        return !this.target;
    }
}

