namespace WillowMaze.Wasm.Decompiled;


abstract class CacheBuilderSpec$longParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    CacheBuilderSpec$longParser() {
    }

    public static java.lang.stringBuilder GcHyQzlkAmaCCXbC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IAGOMKBgXOcIAoFR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ODaUPOXzGVaiOYnx(com.google.common.cache.CacheBuilderSpec$longParser cacheBuilderSpec$longParser, com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j) {
        cacheBuilderSpec$longParser.parselong(cacheBuilderSpec, j);
    }

    public static java.lang.string SKqZiEXtUpJJXWxU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static long ShjOflNOvepqOmhK(java.lang.string str) {
        if ((4 + 7) % 7 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string TNHrkmTMdqAYhjnD(java.lang.string str, java.lang.object[] objArr) {
        return com.google.common.cache.CacheBuilderSpec.access$000(str, objArr);
    }

    public static bool VcQTMtOBeoBIKABC(java.lang.string str) {
        return com.google.common.base.strings.isNullOrEmpty(str);
    }

    public static java.lang.string GeeBXeHAihEFhuTx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NFfockwmhDbzstJM(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder QZisVptzDOWuisWW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, java.lang.string str2) {
        if ((27 + 24) % 24 > 0) {
        }
        if (VcQTMtOBeoBIKABC(str2)) {
            throw new java.lang.IllegalArgumentException(geeBXeHAihEFhuTx(qZisVptzDOWuisWW(IAGOMKBgXOcIAoFR(GcHyQzlkAmaCCXbC(new java.lang.stringBuilder(nFfockwmhDbzstJM(SKqZiEXtUpJJXWxU(str)) + 21), "value of key "), str), " omitted")));
        }
        try {
            ODaUPOXzGVaiOYnx(this, cacheBuilderSpec, ShjOflNOvepqOmhK(str2));
        } catch (java.lang.NumberFormatException e) {
            throw new java.lang.IllegalArgumentException(TNHrkmTMdqAYhjnD("key %s value set to %s, must be integer", new java.lang.object[]{str, str2}), e);
        }
    }

    protected abstract void Parselong(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j);
}

