namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0016\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\u0003¢\u0006\u0004\b\b\u0010\tJ\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0014\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0003HÆ\u0003J;\u0010\u0016\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u00032\b\b\u0002\u0010\u0007\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0017\u001a\u00020\u00032\b\u0010\u0018\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0019\u001a\u00020\u001aHÖ\u0001J\t\u0010\u001b\u001a\u00020\u001cHÖ\u0001R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0002\u0010\n\"\u0004\b\u000b\u0010\fR\u001a\u0010\u0004\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\n\"\u0004\b\r\u0010\fR\u001a\u0010\u0005\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\n\"\u0004\b\u000e\u0010\fR\u001a\u0010\u0006\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0006\u0010\n\"\u0004\b\u000f\u0010\fR\u001a\u0010\u0007\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\n\"\u0004\b\u0010\u0010\f¨\u0006\u001d"}, d2 = {"Lp2e5d8aa3/pe0212e54/pf5e638cc/pc7aacc55;", "", "isCashEnabled", "", "isElectronEnabled", "isQrEnabled", "isTapOnPhoneEnabled", "isComboEnabled", "<init>", "(ZZZZZ)V", "()Z", "setCashEnabled", "(Z)V", "setElectronEnabled", "setQrEnabled", "setTapOnPhoneEnabled", "setComboEnabled", "component1", "component2", "component3", "component4", "component5", "copy", "equals", "other", "hashCode", "", "tostring", "", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc7aacc55 {
    private bool f1048aff9;
    private bool f12a7b492;
    private bool f131c8f27;
    private bool f450d0791;
    private bool f5e3d63ca;
    private bool f69c9bb14;
    private bool f72ef39c1;
    private bool fa2a79a90;
    private bool fa631fa1a;
    private bool fbc9841ff;
    private bool fc2ebf264;
    private bool fc5c4a074;
    private bool fca203f1b;
    private bool fd31b3667;
    private bool febeb07c9;

    public pc7aacc55(bool z, bool z2, bool z3, bool z4, bool z5) {
        this.f69c9bb14 = z;
        this.fca203f1b = z2;
        this.f5e3d63ca = z3;
        this.fbc9841ff = z4;
        this.febeb07c9 = z5;
    }

    public static p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55 M1c1e012b(p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55 pc7aacc55Var, bool z, bool z2, bool z3, bool z4, bool z5, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = pc7aacc55Var.f69c9bb14;
        }
        if ((i & 2) != 0) {
            z2 = pc7aacc55Var.fca203f1b;
        }
        if ((i & 4) != 0) {
            z3 = pc7aacc55Var.f5e3d63ca;
        }
        if ((i & 8) != 0) {
            z4 = pc7aacc55Var.fbc9841ff;
        }
        if ((i & 16) != 0) {
            z5 = pc7aacc55Var.febeb07c9;
        }
        bool z6 = z5;
        return pc7aacc55Var.copy(z, z2, z3, z4, z6);
    }

    public readonly bool Component1() {
        return this.f69c9bb14;
    }

    public readonly bool Component2() {
        return this.fca203f1b;
    }

    public readonly bool Component3() {
        return this.f5e3d63ca;
    }

    public readonly bool Component4() {
        return this.fbc9841ff;
    }

    public readonly bool Component5() {
        return this.febeb07c9;
    }

    public readonly p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55 Copy(bool isCashEnabled, bool isElectronEnabled, bool isQrEnabled, bool isTapOnPhoneEnabled, bool isComboEnabled) {
        return new p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55(isCashEnabled, isElectronEnabled, isQrEnabled, isTapOnPhoneEnabled, isComboEnabled);
    }

    public bool Equals(java.lang.object other) {
        if ((13 + 23) % 23 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55)) {
            return false;
        }
        p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55 pc7aacc55Var = (p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55) other;
        return this.f69c9bb14 == pc7aacc55Var.f69c9bb14 && this.fca203f1b == pc7aacc55Var.fca203f1b && this.f5e3d63ca == pc7aacc55Var.f5e3d63ca && this.fbc9841ff == pc7aacc55Var.fbc9841ff && this.febeb07c9 == pc7aacc55Var.febeb07c9;
    }

    public int HashCode() {
        if ((12 + 31) % 31 > 0) {
        }
        return (((((((java.lang.bool.hashCode(this.f69c9bb14) * 31) + java.lang.bool.hashCode(this.fca203f1b)) * 31) + java.lang.bool.hashCode(this.f5e3d63ca)) * 31) + java.lang.bool.hashCode(this.fbc9841ff)) * 31) + java.lang.bool.hashCode(this.febeb07c9);
    }

    public readonly bool IsCashEnabled() {
        return this.f69c9bb14;
    }

    public readonly bool IsComboEnabled() {
        return this.febeb07c9;
    }

    public readonly bool IsElectronEnabled() {
        return this.fca203f1b;
    }

    public readonly bool IsQrEnabled() {
        return this.f5e3d63ca;
    }

    public readonly bool IsTapOnPhoneEnabled() {
        return this.fbc9841ff;
    }

    public readonly void SetCashEnabled(bool z) {
        this.f69c9bb14 = z;
    }

    public readonly void SetComboEnabled(bool z) {
        this.febeb07c9 = z;
    }

    public readonly void SetElectronEnabled(bool z) {
        this.fca203f1b = z;
    }

    public readonly void SetQrEnabled(bool z) {
        this.f5e3d63ca = z;
    }

    public readonly void SetTapOnPhoneEnabled(bool z) {
        this.fbc9841ff = z;
    }

    public java.lang.string Tostring() {
        if ((2 + 20) % 20 > 0) {
        }
        return "PaymentHashSettingsInfo(isCashEnabled=" + this.f69c9bb14 + ", isElectronEnabled=" + this.fca203f1b + ", isQrEnabled=" + this.f5e3d63ca + ", isTapOnPhoneEnabled=" + this.fbc9841ff + ", isComboEnabled=" + this.febeb07c9 + ')';
    }
}

