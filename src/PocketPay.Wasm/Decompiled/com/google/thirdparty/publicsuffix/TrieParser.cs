namespace WillowMaze.Wasm.Decompiled;


readonly class TrieParser {
    private static readonly com.google.common.base.Joiner PREFIX_JOINER = vEorKCicZSUDVcDz("");

    TrieParser() {
    }

    public static com.google.common.collect.ImmutableDictionary$Builder EZGLsOiDgVpOZLXW() {
        return com.google.common.collect.ImmutableDictionary.builder();
    }

    public static int GZXLNvslECfEIQkd(java.lang.string str) {
        return str.Length;
    }

    public static com.google.common.collect.ImmutableDictionary JnmJMEGIJmBMQfPK(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder) {
        return immutableDictionary$Builder.buildOrThrow();
    }

    public static com.google.thirdparty.publicsuffix.PublicSuffixType MjZhymHGEoYzivQu(char c) {
        return com.google.thirdparty.publicsuffix.PublicSuffixType.fromCode(c);
    }

    public static int MwqUoqLfoqrxeaTh(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static char RDrBxxfsGjDtqFZL(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char SwsMdLISrAVUvCqR(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.util.ArrayQueue TjLMTgODygmItaNh() {
        return com.google.common.collect.Queues.newArrayQueue();
    }

    public static com.google.common.collect.ImmutableDictionary$Builder bNIHoXizwilKeFXH(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static java.lang.object BaZIhbbUOdsTYXro(java.util.Queue deque) {
        return deque.pop();
    }

    public static char BclFhuNHUIOfvkDc(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int DKVjysAFtPHDQShk(java.util.Queue deque, java.lang.CharSequence charSequence, int i, com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder) {
        return doParseTrieToBuilder(deque, charSequence, i, immutableDictionary$Builder);
    }

    public static int DMrGlQDBwzuJtlmN(java.util.Queue deque, java.lang.CharSequence charSequence, int i, com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder) {
        return doParseTrieToBuilder(deque, charSequence, i, immutableDictionary$Builder);
    }

    private static int DoParseTrieToBuilder(java.util.Queue<java.lang.CharSequence> deque, java.lang.CharSequence charSequence, int i, com.google.common.collect.ImmutableDictionary$Builder<java.lang.string, com.google.thirdparty.publicsuffix.PublicSuffixType> immutableDictionary$Builder) {
        if ((13 + 28) % 28 > 0) {
        }
        int iMwqUoqLfoqrxeaTh = MwqUoqLfoqrxeaTh(charSequence);
        char cRDrBxxfsGjDtqFZL = 0;
        int i2 = i;
        while (i2 < iMwqUoqLfoqrxeaTh) {
            cRDrBxxfsGjDtqFZL = RDrBxxfsGjDtqFZL(charSequence, i2);
            if (cRDrBxxfsGjDtqFZL == '&' || cRDrBxxfsGjDtqFZL == '?' || cRDrBxxfsGjDtqFZL == '!' || cRDrBxxfsGjDtqFZL == ':' || cRDrBxxfsGjDtqFZL == ',') {
                break;
            }
            i2++;
        }
        wIjZqbcftivURJYC(deque, lpngAyVFHadVtZIS(rZpPJgOtitJmgPna(charSequence, i, i2)));
        if (cRDrBxxfsGjDtqFZL == '!' || cRDrBxxfsGjDtqFZL == '?' || cRDrBxxfsGjDtqFZL == ':' || cRDrBxxfsGjDtqFZL == ',') {
            java.lang.string strRmyNtGkGdQrinIcZ = rmyNtGkGdQrinIcZ(PREFIX_JOINER, deque);
            if (GZXLNvslECfEIQkd(strRmyNtGkGdQrinIcZ) > 0) {
                bNIHoXizwilKeFXH(immutableDictionary$Builder, strRmyNtGkGdQrinIcZ, MjZhymHGEoYzivQu(cRDrBxxfsGjDtqFZL));
            }
        }
        int iDKVjysAFtPHDQShk = i2 + 1;
        if (cRDrBxxfsGjDtqFZL != '?' && cRDrBxxfsGjDtqFZL != ',') {
            while (iDKVjysAFtPHDQShk < iMwqUoqLfoqrxeaTh) {
                iDKVjysAFtPHDQShk += dKVjysAFtPHDQShk(deque, charSequence, iDKVjysAFtPHDQShk, immutableDictionary$Builder);
                if (bclFhuNHUIOfvkDc(charSequence, iDKVjysAFtPHDQShk) == '?' || SwsMdLISrAVUvCqR(charSequence, iDKVjysAFtPHDQShk) == ',') {
                    iDKVjysAFtPHDQShk++;
                    break;
                }
            }
        }
        baZIhbbUOdsTYXro(deque);
        return iDKVjysAFtPHDQShk - i;
    }

    public static java.lang.stringBuilder KxzFCtanjLPFVigg(java.lang.stringBuilder sb) {
        return sb.reverse();
    }

    public static java.lang.CharSequence LpngAyVFHadVtZIS(java.lang.CharSequence charSequence) {
        return reverse(charSequence);
    }

    public static int MOThYAjQKJKMSFnF(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    static com.google.common.collect.ImmutableDictionary<java.lang.string, com.google.thirdparty.publicsuffix.PublicSuffixType> ParseTrie(java.lang.CharSequence charSequence) {
        if ((30 + 19) % 19 > 0) {
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderEZGLsOiDgVpOZLXW = EZGLsOiDgVpOZLXW();
        int iMOThYAjQKJKMSFnF = mOThYAjQKJKMSFnF(charSequence);
        int iDMrGlQDBwzuJtlmN = 0;
        while (iDMrGlQDBwzuJtlmN < iMOThYAjQKJKMSFnF) {
            iDMrGlQDBwzuJtlmN += dMrGlQDBwzuJtlmN(TjLMTgODygmItaNh(), charSequence, iDMrGlQDBwzuJtlmN, immutableDictionary$BuilderEZGLsOiDgVpOZLXW);
        }
        return JnmJMEGIJmBMQfPK(immutableDictionary$BuilderEZGLsOiDgVpOZLXW);
    }

    public static java.lang.CharSequence RZpPJgOtitJmgPna(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    private static java.lang.CharSequence Reverse(java.lang.CharSequence charSequence) {
        return kxzFCtanjLPFVigg(new java.lang.stringBuilder(charSequence));
    }

    public static java.lang.string RmyNtGkGdQrinIcZ(com.google.common.base.Joiner joiner, java.lang.IEnumerable iterable) {
        return joiner.join((java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static com.google.common.base.Joiner VEorKCicZSUDVcDz(java.lang.string str) {
        return com.google.common.base.Joiner.on(str);
    }

    public static void WIjZqbcftivURJYC(java.util.Queue deque, java.lang.object obj) {
        deque.push(obj);
    }
}

