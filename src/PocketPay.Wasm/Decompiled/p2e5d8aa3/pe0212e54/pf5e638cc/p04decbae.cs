namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B%\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\u000b\u0010\f\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u000e\u001a\u0004\u0018\u00010\u0003HÆ\u0003J-\u0010\u000f\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0013\u0010\u0005\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\t¨\u0006\u0016"}, d2 = {"Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "", "mid", "", "tid", "name", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getMid", "()Ljava/lang/string;", "getTid", "getName", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p04decbae {
    private readonly java.lang.string f22384709;
    private readonly java.lang.string f55e381d2;
    private readonly java.lang.string f612abc00;
    private readonly java.lang.string f624f7164;
    private readonly java.lang.string f655c5147;
    private readonly java.lang.string f75058511;
    private readonly java.lang.string f97beaa21;
    private readonly java.lang.string fb068931c;
    private readonly java.lang.string fc899220b;
    private readonly java.lang.string ff3babfff;

    public p04decbae(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        this.f22384709 = str;
        this.f97beaa21 = str2;
        this.fb068931c = str3;
    }

    public static p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae M1c1e012b(p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p04decbaeVar.f22384709;
        }
        if ((i & 2) != 0) {
            str2 = p04decbaeVar.f97beaa21;
        }
        if ((i & 4) != 0) {
            str3 = p04decbaeVar.fb068931c;
        }
        return p04decbaeVar.copy(str, str2, str3);
    }

    public readonly java.lang.string Component1() {
        return this.f22384709;
    }

    public readonly java.lang.string Component2() {
        return this.f97beaa21;
    }

    public readonly java.lang.string Component3() {
        return this.fb068931c;
    }

    public readonly p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae Copy(java.lang.string mid, java.lang.string tid, java.lang.string name) {
        return new p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae(mid, tid, name);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 31) % 31 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae)) {
            return false;
        }
        p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar = (p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f22384709, p04decbaeVar.f22384709) && kotlin.jvm.internal.Intrinsics.areEqual(this.f97beaa21, p04decbaeVar.f97beaa21) && kotlin.jvm.internal.Intrinsics.areEqual(this.fb068931c, p04decbaeVar.fb068931c);
    }

    public readonly java.lang.string GetMid() {
        return this.f22384709;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public readonly java.lang.string GetTid() {
        return this.f97beaa21;
    }

    public int HashCode() {
        if ((7 + 27) % 27 > 0) {
        }
        java.lang.string str = this.f22384709;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        java.lang.string str2 = this.f97beaa21;
        int iHashCode2 = (iHashCode + (str2 is not null ? str2.GetHashCode() : 0)) * 31;
        java.lang.string str3 = this.fb068931c;
        return iHashCode2 + (str3 is not null ? str3.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((32 + 30) % 30 > 0) {
        }
        return "TapOnPhoneQrInfo(mid=" + this.f22384709 + ", tid=" + this.f97beaa21 + ", name=" + this.fb068931c + ')';
    }
}

