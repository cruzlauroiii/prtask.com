namespace WillowMaze.Wasm.Decompiled;


public readonly class Joiner$DictionaryJoiner {
    private readonly com.google.common.base.Joiner joiner;
    private readonly java.lang.string keyValueSeparator;

    private Joiner$DictionaryJoiner(com.google.common.base.Joiner joiner, java.lang.string str) {
        this.joiner = joiner;
        this.keyValueSeparator = (java.lang.string) LdxOJVXVvqtrBMWu(str);
    }

    Joiner$DictionaryJoiner(com.google.common.base.Joiner joiner, java.lang.string str, com.google.common.base.Joiner$1 joiner$1) {
        this(joiner, str);
    }

    public static java.lang.Appendable ALtFgatITHZWYyyI(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static bool AmUfPJiNZVcXrzuL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object ByJpoNnUYZuUYbVE(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.CharSequence CFMOajAhDIcFZCiB(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static java.lang.object DJRFKpoZsuaUfLQi(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.Appendable GsmmHrSzsohIGedK(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.object GzZjyUHHyVMYuWBW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.HashSet KohlCnWsYzGQMyWX(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object LdxOJVXVvqtrBMWu(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string MjWzWQnCEIZyxaCl(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.util.IEnumerator it) {
        return joiner$DictionaryJoiner.join((java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>>) it);
    }

    public static java.lang.CharSequence OHzMdVbbGgJbcfJC(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static bool OSgDvJUKEsdXvJBj(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator OoWGCbHLraArsJuO(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.CharSequence RTmcwgqCGCAYOepF(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static com.google.common.base.Joiner SveAKQnofuaOOaVQ(com.google.common.base.Joiner joiner, java.lang.string str) {
        return joiner.useForNull(str);
    }

    public static java.lang.Appendable VMTYxeRQttbLoIUp(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.util.HashSet VspjkmsUmVDjqnuF(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.stringBuilder XFsmldHMinvXmdTB(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.stringBuilder sb, java.util.IEnumerator it) {
        return joiner$DictionaryJoiner.appendTo(sb, (java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>>) it);
    }

    public static java.lang.string YfuVYNgNOeXeJwCR(com.google.common.base.Joiner joiner) {
        return com.google.common.base.Joiner.access$100(joiner);
    }

    public static java.lang.CharSequence ANJyQpvTKMcVcXdk(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static java.lang.stringBuilder ApGYdiPuMhCIXewy(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.stringBuilder sb, java.util.IEnumerator it) {
        return joiner$DictionaryJoiner.appendTo(sb, (java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>>) it);
    }

    public static java.lang.Appendable EjRzYQPqAJyQmyRc(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.Appendable appendable, java.util.IEnumerator it) {
        return joiner$DictionaryJoiner.appendTo(appendable, (java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>>) it);
    }

    public static java.lang.Appendable FBjvTJganxfxxKlH(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.object GJuOieaFMWTBvATZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.Appendable HSqZsIFLPaPgputj(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.util.IEnumerator IQnSinooCSBAqfnr(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.stringBuilder KOXdLWxnoMGMNmMk(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.stringBuilder sb, java.lang.IEnumerable iterable) {
        return joiner$DictionaryJoiner.appendTo(sb, (java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>>) iterable);
    }

    public static java.lang.object KYaHoCAdWqyjGglB(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string MCSjxFgSHBlzGhzo(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.IEnumerable iterable) {
        return joiner$DictionaryJoiner.join((java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>>) iterable);
    }

    public static java.lang.Appendable MLJNzqEKfxXTknKV(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.Appendable appendable, java.lang.IEnumerable iterable) {
        return joiner$DictionaryJoiner.appendTo(appendable, (java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>>) iterable);
    }

    public static java.lang.object NlFIJImTLUowKMsq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object NmLxpGrKWbxdqbVw(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.Appendable OfXSoFMdFQQizLTv(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.util.IEnumerator OgGwnTtJCySlMnNL(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.string PIHOBZqKrNBnGtLf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet RdhhZUEmloyxgtsC(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.Appendable UqrXEfgOXxrsXkib(com.google.common.base.Joiner$DictionaryJoiner joiner$DictionaryJoiner, java.lang.Appendable appendable, java.util.IEnumerator it) {
        return joiner$DictionaryJoiner.appendTo(appendable, (java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>>) it);
    }

    public static java.lang.Appendable ZDyvcxHagdwNhWGv(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>> iterable) throws java.io.IOException {
        return (A) uqrXEfgOXxrsXkib(this, a2, ogGwnTtJCySlMnNL(iterable));
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>> it) throws java.io.IOException {
        if ((3 + 19) % 19 > 0) {
        }
        DJRFKpoZsuaUfLQi(a2);
        if (OSgDvJUKEsdXvJBj(it)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) GzZjyUHHyVMYuWBW(it);
            hSqZsIFLPaPgputj(a2, OHzMdVbbGgJbcfJC(this.joiner, kYaHoCAdWqyjGglB(map$Entry)));
            GsmmHrSzsohIGedK(a2, this.keyValueSeparator);
            VMTYxeRQttbLoIUp(a2, RTmcwgqCGCAYOepF(this.joiner, nlFIJImTLUowKMsq(map$Entry)));
            while (AmUfPJiNZVcXrzuL(it)) {
                ofXSoFMdFQQizLTv(a2, YfuVYNgNOeXeJwCR(this.joiner));
                java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) gJuOieaFMWTBvATZ(it);
                zDyvcxHagdwNhWGv(a2, CFMOajAhDIcFZCiB(this.joiner, ByJpoNnUYZuUYbVE(map$Entry2)));
                fBjvTJganxfxxKlH(a2, this.keyValueSeparator);
                ALtFgatITHZWYyyI(a2, aNJyQpvTKMcVcXdk(this.joiner, nmLxpGrKWbxdqbVw(map$Entry2)));
            }
        }
        return a2;
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.util.Dictionary<object, object> map) throws java.io.IOException {
        return (A) mLJNzqEKfxXTknKV(this, a2, VspjkmsUmVDjqnuF(map));
    }

    public java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>> iterable) {
        return apGYdiPuMhCIXewy(this, sb, OoWGCbHLraArsJuO(iterable));
    }

    public java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>> it) {
        try {
            ejRzYQPqAJyQmyRc(this, sb, it);
            return sb;
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.util.Dictionary<object, object> map) {
        return kOXdLWxnoMGMNmMk(this, sb, KohlCnWsYzGQMyWX(map));
    }

    public java.lang.string Join(java.lang.IEnumerable<? : java.util.Dictionary$Entry<object, object>> iterable) {
        return MjWzWQnCEIZyxaCl(this, iQnSinooCSBAqfnr(iterable));
    }

    public java.lang.string Join(java.util.IEnumerator<? : java.util.Dictionary$Entry<object, object>> it) {
        return pIHOBZqKrNBnGtLf(XFsmldHMinvXmdTB(this, new java.lang.stringBuilder(), it));
    }

    public java.lang.string Join(java.util.Dictionary<object, object> map) {
        return mCSjxFgSHBlzGhzo(this, rdhhZUEmloyxgtsC(map));
    }

    public com.google.common.base.Joiner$DictionaryJoiner useForNull(java.lang.string str) {
        if ((19 + 29) % 29 > 0) {
        }
        return new com.google.common.base.Joiner$DictionaryJoiner(SveAKQnofuaOOaVQ(this.joiner, str), this.keyValueSeparator);
    }
}

