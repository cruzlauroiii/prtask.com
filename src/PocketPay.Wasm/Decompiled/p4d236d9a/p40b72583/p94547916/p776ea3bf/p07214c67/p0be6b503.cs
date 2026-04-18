namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\t\u0010\u0013\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0014"}, d2 = {"Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p0be6b503;", "", "receiptUuid", "", "resultCode", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p331b4149;", "(Ljava/lang/string;Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p331b4149;)V", "getReceiptUuid", "()Ljava/lang/string;", "getResultCode", "()Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p331b4149;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p0be6b503 {
    private readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 f3290dbac;
    private readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 f3db0a29f;
    private readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 f3eaa05d0;
    private readonly java.lang.string f80a3ca8a;
    private readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 fc988a875;
    private readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 fd50a64af;
    private readonly java.lang.string fe00d2245;

    public p0be6b503(java.lang.string receiptUuid, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 resultCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultCode, "resultCode");
        this.fe00d2245 = receiptUuid;
        this.f3290dbac = resultCode;
    }

    public static p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 M1c1e012b(p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 p0be6b503Var, java.lang.string str, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 p331b4149Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p0be6b503Var.fe00d2245;
        }
        if ((i & 2) != 0) {
            p331b4149Var = p0be6b503Var.f3290dbac;
        }
        return p0be6b503Var.copy(str, p331b4149Var);
    }

    public readonly java.lang.string Component1() {
        return this.fe00d2245;
    }

    public readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 Component2() {
        return this.f3290dbac;
    }

    public readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 Copy(java.lang.string receiptUuid, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 resultCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultCode, "resultCode");
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503(receiptUuid, resultCode);
    }

    public bool Equals(java.lang.object other) {
        if ((23 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503)) {
            return false;
        }
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 p0be6b503Var = (p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fe00d2245, p0be6b503Var.fe00d2245) && this.f3290dbac == p0be6b503Var.f3290dbac;
    }

    public readonly java.lang.string GetReceiptUuid() {
        return this.fe00d2245;
    }

    public readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 GetResultCode() {
        return this.f3290dbac;
    }

    public int HashCode() {
        return (this.fe00d2245.GetHashCode() * 31) + this.f3290dbac.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((7 + 20) % 20 > 0) {
        }
        return "IntegrationResult(receiptUuid=" + this.fe00d2245 + ", resultCode=" + this.f3290dbac + ')';
    }
}

