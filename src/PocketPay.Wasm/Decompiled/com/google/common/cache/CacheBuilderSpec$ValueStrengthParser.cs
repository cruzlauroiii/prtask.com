namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$ValueStrengthParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    private readonly com.google.common.cache.LocalCache$Strength strength;

    public CacheBuilderSpec$ValueStrengthParser(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        this.strength = localCache$Strength;
    }

    public static void ZBZOmWKwnNOMlWba(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static void GQRsJHtocNOMoynJ(bool z, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj, obj2);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, @javax.annotation.CheckForNull java.lang.string str2) {
        if ((3 + 8) % 8 > 0) {
        }
        ZBZOmWKwnNOMlWba(str2 is null, "key %s does not take values", str);
        gQRsJHtocNOMoynJ(cacheBuilderSpec.valueStrength is null, "%s was already set to %s", str, cacheBuilderSpec.valueStrength);
        cacheBuilderSpec.valueStrength = this.strength;
    }
}

