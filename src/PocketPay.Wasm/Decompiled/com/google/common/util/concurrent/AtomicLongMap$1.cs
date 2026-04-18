namespace WillowMaze.Wasm.Decompiled;


class AtomiclongDictionary$1 : com.google.common.base.Function<java.util.concurrent.atomic.Atomiclong, java.lang.long> {
    AtomiclongDictionary$1(com.google.common.util.concurrent.AtomiclongDictionary atomiclongDictionary) {
    }

    public java.lang.long Apply2(java.util.concurrent.atomic.Atomiclong atomiclong) {
        return java.lang.long.valueOf(atomiclong[));
    }

    public override java.lang.long Apply(java.util.concurrent.atomic.Atomiclong atomiclong) {
        return apply2(atomiclong);
    }
}

