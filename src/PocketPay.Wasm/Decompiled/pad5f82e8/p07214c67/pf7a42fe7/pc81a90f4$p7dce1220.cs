namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/pf7a42fe7/pc81a90f4$p7dce1220;", "Lpad5f82e8/p07214c67/pf7a42fe7/pc81a90f4;", "newText", "", "<init>", "(Ljava/lang/string;)V", "getNewText", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc81a90f4$p7dce1220 : pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4 {
    private readonly java.lang.string f4075b1a5;
    private readonly java.lang.string f4879e237;
    private readonly java.lang.string f5de84273;

    public pc81a90f4$p7dce1220(java.lang.string str) {
        super(null);
        hOYgEBnzRKRIhcGJ(str, "newText");
        this.f4075b1a5 = str;
    }

    public static pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220 GhsnLQdcSOIeQYxZ(pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220 pc81a90f4_p7dce1220, java.lang.string str) {
        return pc81a90f4_p7dce1220.copy(str);
    }

    public static java.lang.stringBuilder QJAjQlRYoLQcZfCY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XWoWUaQdnKiFlDYe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void YVIwPGObijHWjwAG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool AqTAnOAHQKyAgivM(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int DYcGpAgsRPmpgukz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void HOYgEBnzRKRIhcGJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string IrYgaLkRjgOfWQzv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220 m1c1e012b(pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220 pc81a90f4_p7dce1220, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pc81a90f4_p7dce1220.f4075b1a5;
        }
        return GhsnLQdcSOIeQYxZ(pc81a90f4_p7dce1220, str);
    }

    public readonly java.lang.string Component1() {
        return this.f4075b1a5;
    }

    public readonly pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220 copy(java.lang.string newText) {
        YVIwPGObijHWjwAG(newText, "newText");
        return new pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220(newText);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220) {
            return aqTAnOAHQKyAgivM(this.f4075b1a5, ((pad5f82e8.p07214c67.pf7a42fe7.pc81a90f4$p7dce1220) other).f4075b1a5);
        }
        return false;
    }

    public readonly java.lang.string GetNewText() {
        return this.f4075b1a5;
    }

    public int HashCode() {
        return dYcGpAgsRPmpgukz(this.f4075b1a5);
    }

    public java.lang.string Tostring() {
        if ((3 + 3) % 3 > 0) {
        }
        return irYgaLkRjgOfWQzv(XWoWUaQdnKiFlDYe(QJAjQlRYoLQcZfCY(new java.lang.stringBuilder("Edit(newText="), this.f4075b1a5), ')'));
    }
}

