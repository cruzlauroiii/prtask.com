namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0087\b\u0018\u00002\u00020\u0001B\u0019\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u0010\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0003HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0005HÖ\u0001R\u001e\u0010\u0002\u001a\u00020\u00038\u0006@\u0006X\u0087\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\b\u0010\t\"\u0004\b\n\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0016"}, d2 = {"Lpad5f82e8/p07214c67/pd77d5e50/p25a7e996;", "", "id", "", "receiptUuid", "", "<init>", "(ILjava/lang/string;)V", "getId", "()I", "setId", "(I)V", "getReceiptUuid", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p25a7e996 {
    private int f16c3e057;
    private int f4d0a717f;
    private readonly java.lang.string f875583e3;
    private int fb80bb774;
    private readonly java.lang.string fe00d2245;

    public p25a7e996(int i, java.lang.string str) {
        SmJnHoIPHKXTwvBA(str, "receiptUuid");
        this.fb80bb774 = i;
        this.fe00d2245 = str;
    }

    public p25a7e996(int i, java.lang.string str, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? 0 : i, str);
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p25a7e996 DlmNSEmsGdPdlNeZ(pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var, int i, java.lang.string str) {
        return p25a7e996Var.copy(i, str);
    }

    public static java.lang.stringBuilder IskKYhaCFiaqiudB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MUTyrJHBioxSJnCj(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void SmJnHoIPHKXTwvBA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool TyWXKddpLyDGmqoW(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string CRDoVtROSFMkAEkH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GAgNpiKppAWlDXkY(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KSAbgVkKTUeUXRuU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int LRYGsMECRkkTEzLM(int i) {
        return java.lang.int.hashCode(i);
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p25a7e996 M1c1e012b(pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var, int i, java.lang.string str, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = p25a7e996Var.fb80bb774;
        }
        if ((i2 & 2) != 0) {
            str = p25a7e996Var.fe00d2245;
        }
        return DlmNSEmsGdPdlNeZ(p25a7e996Var, i, str);
    }

    public static java.lang.stringBuilder QpAwBjFNHtQGRxEi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZcFYDijsKlhQQOYo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly int Component1() {
        return this.fb80bb774;
    }

    public readonly java.lang.string Component2() {
        return this.fe00d2245;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.p25a7e996 Copy(int id, java.lang.string receiptUuid) {
        zcFYDijsKlhQQOYo(receiptUuid, "receiptUuid");
        return new pad5f82e8.p07214c67.pd77d5e50.p25a7e996(id, receiptUuid);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.pd77d5e50.p25a7e996)) {
            return false;
        }
        pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var = (pad5f82e8.p07214c67.pd77d5e50.p25a7e996) other;
        return this.fb80bb774 == p25a7e996Var.fb80bb774 && TyWXKddpLyDGmqoW(this.fe00d2245, p25a7e996Var.fe00d2245);
    }

    public readonly int GetId() {
        return this.fb80bb774;
    }

    public readonly java.lang.string GetReceiptUuid() {
        return this.fe00d2245;
    }

    public int HashCode() {
        return (lRYGsMECRkkTEzLM(this.fb80bb774) * 31) + MUTyrJHBioxSJnCj(this.fe00d2245);
    }

    public readonly void SetId(int i) {
        this.fb80bb774 = i;
    }

    public java.lang.string Tostring() {
        if ((12 + 18) % 18 > 0) {
        }
        return cRDoVtROSFMkAEkH(gAgNpiKppAWlDXkY(IskKYhaCFiaqiudB(qpAwBjFNHtQGRxEi(kSAbgVkKTUeUXRuU(new java.lang.stringBuilder("QueueReceiptDbEntity(id="), this.fb80bb774), ", receiptUuid="), this.fe00d2245), ')'));
    }
}

