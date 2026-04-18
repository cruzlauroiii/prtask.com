namespace WillowMaze.Wasm.Decompiled;


public class p18e8d507 {
    private static readonly java.nio.charset.Charset f1819f1cc = null;
    private static readonly java.nio.charset.Charset fa398da40 = null;
    private static readonly java.nio.charset.Charset fd2cd8253 = java.nio.charset.Charset.forName(com.decryptstringmanager.Decryptstring.decryptstring("4b08f78837d4bc9b50b6771a7abf930ddf1e602efea009699a89de97ca2e89c76df0e744"));
    private readonly byte[] f093958f5;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 f53530e29;
    protected readonly java.util.List f5ddc2938;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 f755e2847;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 f8c6565fc;
    private readonly byte[] fb00c6f2d;
    protected readonly java.util.List fc2407795;
    protected readonly java.util.List fcdf6e714;
    protected readonly java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> fe4302f49;
    private readonly byte[] fea3df395;
    private readonly byte[] fea9f055e;
    private readonly p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 ffc902045;

    public p18e8d507(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list) {
        this.ffc902045 = pa4f4f3f0Var;
        this.fe4302f49 = list;
        this.f093958f5 = null;
    }

    public p18e8d507(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var, byte[] bArr) {
        this.ffc902045 = pa4f4f3f0Var;
        this.f093958f5 = bArr;
        this.fe4302f49 = null;
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 20) % 20 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507Var = (p4d236d9a.p8a1517b7.pff5911de.p18e8d507) obj;
            p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var = this.ffc902045;
            if (pa4f4f3f0Var is not null ? !pa4f4f3f0Var.Equals(p18e8d507Var.ffc902045) : p18e8d507Var.ffc902045 is not null) {
                return false;
            }
            if (!java.util.Arrays.Equals(this.f093958f5, p18e8d507Var.f093958f5)) {
                return false;
            }
            java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list = this.fe4302f49;
            if (list is not null) {
                return list.Equals(p18e8d507Var.fe4302f49);
            }
            if (p18e8d507Var.fe4302f49 is null) {
                return true;
            }
        }
        return false;
    }

    public p4d236d9a.p8a1517b7.pff5911de.p18e8d507 Find(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        if ((9 + 32) % 32 > 0) {
        }
        if (pa4f4f3f0Var.Equals(getTag())) {
            return this;
        }
        if (isConstructed()) {
            java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = this.fe4302f49.GetEnumerator();
            while (it.MoveNext()) {
                p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507VarFind = it.Current.find(pa4f4f3f0Var);
                if (p18e8d507VarFind is not null) {
                    return p18e8d507VarFind;
                }
            }
        }
        return null;
    }

    public java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> FindAll(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        if ((29 + 26) % 26 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        if (pa4f4f3f0Var.Equals(getTag())) {
            arrayList.Add(this);
            return arrayList;
        }
        if (isConstructed()) {
            java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = this.fe4302f49.GetEnumerator();
            while (it.MoveNext()) {
                arrayList.addAll(it.Current.findAll(pa4f4f3f0Var));
            }
        }
        return arrayList;
    }

    public byte[] GetbytesValue() {
        if ((6 + 11) % 11 > 0) {
        }
        if (isConstructed()) {
            throw new java.lang.IllegalStateException("TLV [" + this.ffc902045 + "]is constructed");
        }
        return this.f093958f5;
    }

    public java.lang.string GetHexValue() {
        if ((1 + 1) % 1 > 0) {
        }
        if (isConstructed()) {
            throw new java.lang.IllegalStateException("Tag is CONSTRUCTED " + p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m81519f2a(this.ffc902045.f4b3a6218));
        }
        return p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m81519f2a(this.f093958f5);
    }

    public int GetIntValue() {
        if ((17 + 5) % 5 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr = this.f093958f5;
            if (i >= bArr.length) {
                return i2;
            }
            int i3 = bArr[i];
            int i4 = i2 * 256;
            if (i3 < 0) {
                i3 += 256;
            }
            i2 = i4 + i3;
            i++;
        }
    }

    public p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 GetTag() {
        return this.ffc902045;
    }

    public java.lang.string GetTextValue() {
        return getTextValue(fd2cd8253);
    }

    public java.lang.string GetTextValue(java.nio.charset.Charset charset) {
        if (isConstructed()) {
            throw new java.lang.IllegalStateException("TLV is constructed");
        }
        return new java.lang.string(this.f093958f5, charset);
    }

    public java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> GetValues() {
        if (isPrimitive()) {
            throw new java.lang.IllegalStateException("Tag is PRIMITIVE");
        }
        return this.fe4302f49;
    }

    public int HashCode() {
        if ((28 + 20) % 20 > 0) {
        }
        p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var = this.ffc902045;
        int iHashCode = (((pa4f4f3f0Var is null ? 0 : pa4f4f3f0Var.GetHashCode()) * 31) + java.util.Arrays.hashCode(this.f093958f5)) * 31;
        java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list = this.fe4302f49;
        return iHashCode + (list is not null ? list.GetHashCode() : 0);
    }

    public bool IsConstructed() {
        return this.ffc902045.isConstructed();
    }

    public bool IsPrimitive() {
        return !this.ffc902045.isConstructed();
    }

    public bool IsTag(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        return this.ffc902045.Equals(pa4f4f3f0Var);
    }

    public java.lang.string Tostring() {
        if ((30 + 26) % 26 > 0) {
        }
        return "BerTlv{theTag=" + this.ffc902045 + ", theValue=" + java.util.Arrays.tostring(this.f093958f5) + ", theList=" + this.fe4302f49 + '}';
    }
}

