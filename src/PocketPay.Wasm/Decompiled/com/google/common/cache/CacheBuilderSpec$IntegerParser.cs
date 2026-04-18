namespace WillowMaze.Wasm.Decompiled;


abstract class CacheBuilderSpec$intParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    CacheBuilderSpec$intParser() {
    }

    public static java.lang.string AIHiqiwZeKuYyATT(java.lang.string str, java.lang.object[] objArr) {
        return com.google.common.cache.CacheBuilderSpec.access$000(str, objArr);
    }

    public static int BIqbZPGoSqbFcvKv(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string HWJlDjQQvXjTNeIf(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool VDmQaJMSYtqJEoGJ(java.lang.string str) {
        return com.google.common.base.strings.isNullOrEmpty(str);
    }

    public static java.lang.stringBuilder DjZPRcaOpxqrtjqL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EUdrjdbXSIzCmief(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FXBrBKqkSHIVbjEf(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.stringBuilder IczfGVVNQYfgeZPC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TgwQudeGrdqNWRAL(com.google.common.cache.CacheBuilderSpec$intParser cacheBuilderSpec$intParser, com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, int i) {
        cacheBuilderSpec$intParser.parseint(cacheBuilderSpec, i);
    }

    public static java.lang.stringBuilder VerFYFxBzUeyTpDs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, java.lang.string str2) {
        if (VDmQaJMSYtqJEoGJ(str2)) {
            throw new java.lang.IllegalArgumentException(eUdrjdbXSIzCmief(iczfGVVNQYfgeZPC(verFYFxBzUeyTpDs(djZPRcaOpxqrtjqL(new java.lang.stringBuilder(BIqbZPGoSqbFcvKv(HWJlDjQQvXjTNeIf(str)) + 21), "value of key "), str), " omitted")));
        }
        try {
            tgwQudeGrdqNWRAL(this, cacheBuilderSpec, fXBrBKqkSHIVbjEf(str2));
        } catch (java.lang.NumberFormatException e) {
            throw new java.lang.IllegalArgumentException(AIHiqiwZeKuYyATT("key %s value set to %s, must be integer", new java.lang.object[]{str, str2}), e);
        }
    }

    protected abstract void Parseint(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, int i);
}

