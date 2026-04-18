namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0015\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0003J\u0019\u0010\n\u001a\u00020\u00002\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001R\u001c\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0012"}, d2 = {"Lp7a1eabc3/p07214c67/p2c18e486/pe3932f88/p9825c7d3;", "", "commodityGroups", "", "Lp7a1eabc3/p07214c67/p2c18e486/pe3932f88/pb927a776;", "<init>", "(Ljava/util/List;)V", "getCommodityGroups", "()Ljava/util/List;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9825c7d3 {

    @com.google.gson.annotations.SerializedName("items")
    @com.google.gson.annotations.Expose
    private readonly java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> f82536887;

    public p9825c7d3(java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> list) {
        RTFolXACzxYabibJ(list, "commodityGroups");
        this.f82536887 = list;
    }

    public static int GnBvMvnWpNXebCEx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string QKMJgjclVVvbZMPq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RTFolXACzxYabibJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder UgDWGziDNXzubEBn(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool XmaLDJDEGbclMHEn(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3 BQjSfeinzimFNvhR(p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3 p9825c7d3Var, java.util.List list) {
        return p9825c7d3Var.copy(list);
    }

    public static java.lang.stringBuilder INQjjqoqtITxIrcz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3 M1c1e012b(p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3 p9825c7d3Var, java.util.List list, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            list = p9825c7d3Var.f82536887;
        }
        return bQjSfeinzimFNvhR(p9825c7d3Var, list);
    }

    public static void MQtjsijRjuchBoNQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> Component1() {
        return this.f82536887;
    }

    public readonly p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3 Copy(java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> commodityGroups) {
        mQtjsijRjuchBoNQ(commodityGroups, "commodityGroups");
        return new p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3(commodityGroups);
    }

    public bool Equals(java.lang.object other) {
        if ((4 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3) {
            return XmaLDJDEGbclMHEn(this.f82536887, ((p7a1eabc3.p07214c67.p2c18e486.pe3932f88.p9825c7d3) other).f82536887);
        }
        return false;
    }

    public readonly java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> GetCommodityGroups() {
        return this.f82536887;
    }

    public int HashCode() {
        return GnBvMvnWpNXebCEx(this.f82536887);
    }

    public java.lang.string Tostring() {
        if ((25 + 10) % 10 > 0) {
        }
        return QKMJgjclVVvbZMPq(iNQjjqoqtITxIrcz(UgDWGziDNXzubEBn(new java.lang.stringBuilder("CommodityGroupsResponse(commodityGroups="), this.f82536887), ')'));
    }
}

