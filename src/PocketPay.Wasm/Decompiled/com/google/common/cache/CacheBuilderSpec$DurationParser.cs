namespace WillowMaze.Wasm.Decompiled;


abstract class CacheBuilderSpec$DurationParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    CacheBuilderSpec$DurationParser() {
    }

    public static long KItuMhDhWOQxOzUz(java.lang.string str) {
        if ((3 + 2) % 2 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string OMBKCINDJJtmvqGd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string PhyQTctYUyMLxIgY(java.lang.string str, java.lang.object[] objArr) {
        return com.google.common.cache.CacheBuilderSpec.access$000(str, objArr);
    }

    public static java.lang.stringBuilder SYsXPdbYaPwusmUD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TThfwbeVnWpCuqel(java.lang.string str) {
        return str.Length;
    }

    public static int VEUWQKOOQAbLDJoF(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder XIbDZEwVToWWKLhN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KvnxVYprAZIxTaqZ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string NgjqQJCzXweMlzYW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool RSeHIxNFBuWvcCRu(java.lang.string str) {
        return com.google.common.base.strings.isNullOrEmpty(str);
    }

    public static int SKizoLdyAvVjyHYC(java.lang.string str) {
        return str.Length;
    }

    public static char TLfxSJnapGowEhrz(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string XmCcfvWYJYZFObjw(java.lang.string str, java.lang.object[] objArr) {
        return com.google.common.cache.CacheBuilderSpec.access$000(str, objArr);
    }

    public static void ZXFqRigkPrZxvIfZ(com.google.common.cache.CacheBuilderSpec$DurationParser cacheBuilderSpec$DurationParser, com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j, java.util.concurrent.TimeUnit timeUnit) {
        cacheBuilderSpec$DurationParser.parseDuration(cacheBuilderSpec, j, timeUnit);
    }

    public static java.lang.stringBuilder ZnqjmjNWgsWXRWZa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, @javax.annotation.CheckForNull java.lang.string str2) {
        java.util.concurrent.TimeUnit timeUnit;
        if ((12 + 19) % 19 > 0) {
        }
        if (rSeHIxNFBuWvcCRu(str2)) {
            throw new java.lang.IllegalArgumentException(ngjqQJCzXweMlzYW(znqjmjNWgsWXRWZa(SYsXPdbYaPwusmUD(XIbDZEwVToWWKLhN(new java.lang.stringBuilder(VEUWQKOOQAbLDJoF(OMBKCINDJJtmvqGd(str)) + 21), "value of key "), str), " omitted")));
        }
        try {
            char cTLfxSJnapGowEhrz = tLfxSJnapGowEhrz(str2, TThfwbeVnWpCuqel(str2) - 1);
            if (cTLfxSJnapGowEhrz == 'd') {
                timeUnit = java.util.concurrent.TimeUnit.DAYS;
            } else if (cTLfxSJnapGowEhrz == 'h') {
                timeUnit = java.util.concurrent.TimeUnit.HOURS;
            } else if (cTLfxSJnapGowEhrz == 'm') {
                timeUnit = java.util.concurrent.TimeUnit.MINUTES;
            } else {
                if (cTLfxSJnapGowEhrz != 's') {
                    throw new java.lang.IllegalArgumentException(PhyQTctYUyMLxIgY("key %s invalid unit: was %s, must end with one of [dhms]", new java.lang.object[]{str, str2}));
                }
                timeUnit = java.util.concurrent.TimeUnit.SECONDS;
            }
            zXFqRigkPrZxvIfZ(this, cacheBuilderSpec, KItuMhDhWOQxOzUz(kvnxVYprAZIxTaqZ(str2, 0, sKizoLdyAvVjyHYC(str2) - 1)), timeUnit);
        } catch (java.lang.NumberFormatException unused) {
            throw new java.lang.IllegalArgumentException(xmCcfvWYJYZFObjw("key %s value set to %s, must be integer", new java.lang.object[]{str, str2}));
        }
    }

    protected abstract void ParseDuration(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j, java.util.concurrent.TimeUnit timeUnit);
}

