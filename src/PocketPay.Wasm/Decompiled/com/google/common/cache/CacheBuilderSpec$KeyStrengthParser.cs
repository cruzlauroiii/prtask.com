namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$KeyStrengthParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    private readonly com.google.common.cache.LocalCache$Strength strength;

    public CacheBuilderSpec$KeyStrengthParser(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        this.strength = localCache$Strength;
    }

    public static void XMfRwCgcnpzHJOIV(bool z, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj, obj2);
    }

    public static void ZlvqJRNGjpKiEGpV(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, @javax.annotation.CheckForNull java.lang.string str2) {
        if ((13 + 20) % 20 > 0) {
        }
        ZlvqJRNGjpKiEGpV(str2 is null, "key %s does not take values", str);
        XMfRwCgcnpzHJOIV(cacheBuilderSpec.keyStrength is null, "%s was already set to %s", str, cacheBuilderSpec.keyStrength);
        cacheBuilderSpec.keyStrength = this.strength;
    }
}

