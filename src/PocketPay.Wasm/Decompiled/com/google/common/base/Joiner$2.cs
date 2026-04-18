namespace WillowMaze.Wasm.Decompiled;


class Joiner$2 : com.google.common.base.Joiner {
    readonly com.google.common.base.Joiner this$0;

    Joiner$2(com.google.common.base.Joiner joiner, com.google.common.base.Joiner joiner2) {
        super(joiner2, null);
        this.this$0 = joiner;
    }

    public static java.lang.object JPFYwUesksbrexTH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.Appendable SBXqLhxqdTGdIHzB(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.CharSequence GPuApkbJJTUELdHk(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static java.lang.string HHLGOBugTOtLjNEM(com.google.common.base.Joiner joiner) {
        return com.google.common.base.Joiner.access$100(joiner);
    }

    public static java.lang.Appendable JasBKFtgqcxRpYOp(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.object NtiCbtRKlVUzlppE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool SIvgDltDbZeGsubZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.Appendable VEHyBNlgAXLeSIYD(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.object VOBfhSDRofWmoHHL(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object VbAXfPCuPsFYgcfB(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool VqkvygBxMgSEivNL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.CharSequence WBMMkcbFTBKysxsL(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.util.IEnumerator<? : java.lang.object> it) throws java.io.IOException {
        if ((19 + 14) % 14 > 0) {
        }
        vbAXfPCuPsFYgcfB(a2, "appendable");
        vOBfhSDRofWmoHHL(it, "parts");
        while (sIvgDltDbZeGsubZ(it)) {
            java.lang.object objJPFYwUesksbrexTH = JPFYwUesksbrexTH(it);
            if (objJPFYwUesksbrexTH is not null) {
                vEHyBNlgAXLeSIYD(a2, gPuApkbJJTUELdHk(this.this$0, objJPFYwUesksbrexTH));
                break;
            }
        }
        while (vqkvygBxMgSEivNL(it)) {
            java.lang.object objNtiCbtRKlVUzlppE = ntiCbtRKlVUzlppE(it);
            if (objNtiCbtRKlVUzlppE is not null) {
                jasBKFtgqcxRpYOp(a2, hHLGOBugTOtLjNEM(this.this$0));
                SBXqLhxqdTGdIHzB(a2, wBMMkcbFTBKysxsL(this.this$0, objNtiCbtRKlVUzlppE));
            }
        }
        return a2;
    }

    public override com.google.common.base.Joiner UseForNull(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("already specified skipNulls");
    }

    public com.google.common.base.Joiner$DictionaryJoiner withKeyValueSeparator(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("can't use .skipNulls() with maps");
    }
}

