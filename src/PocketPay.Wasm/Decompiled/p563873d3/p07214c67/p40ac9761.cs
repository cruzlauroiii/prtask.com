namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0016\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B;\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\u0003\u0012\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\t\u0010\nJ\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0014\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u0017\u001a\u0004\u0018\u00010\u0003HÆ\u0003JG\u0010\u0018\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u00032\b\b\u0002\u0010\u0007\u001a\u00020\u00032\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001c\u001a\u00020\u001dHÖ\u0001J\t\u0010\u001e\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\fR\u0016\u0010\u0006\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\fR\u0016\u0010\u0007\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\fR\u0018\u0010\b\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\f¨\u0006\u001f"}, d2 = {"Lp563873d3/p07214c67/p40ac9761;", "", "smsUuid", "", "phone", "email", "role", "region", "password", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getSmsUuid", "()Ljava/lang/string;", "getPhone", "getEmail", "getRole", "getRegion", "getPassword", "component1", "component2", "component3", "component4", "component5", "component6", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-registration-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p40ac9761 {

    @com.google.gson.annotations.SerializedName("email")
    private readonly java.lang.string f0c83f57c;

    @com.google.gson.annotations.SerializedName("role")
    private readonly java.lang.string f29a7e964;

    @com.google.gson.annotations.SerializedName("password")
    private readonly java.lang.string f5f4dcc3b;

    @com.google.gson.annotations.SerializedName("sms_uuid")
    private readonly java.lang.string f6cdfd1a5;

    @com.google.gson.annotations.SerializedName("region")
    private readonly java.lang.string f960db2ed;

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    public p40ac9761(java.lang.string smsUuid, java.lang.string phone, java.lang.string email, java.lang.string role, java.lang.string region, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(smsUuid, "smsUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(email, "email");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(role, "role");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(region, "region");
        this.f6cdfd1a5 = smsUuid;
        this.ff7a42fe7 = phone;
        this.f0c83f57c = email;
        this.f29a7e964 = role;
        this.f960db2ed = region;
        this.f5f4dcc3b = str;
    }

    public p40ac9761(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, str2, str3, str4, str5, (i & 32) != 0 ? null : str6);
        if ((12 + 29) % 29 > 0) {
        }
    }

    public static p563873d3.p07214c67.p40ac9761 M1c1e012b(p563873d3.p07214c67.p40ac9761 p40ac9761Var, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p40ac9761Var.f6cdfd1a5;
        }
        if ((i & 2) != 0) {
            str2 = p40ac9761Var.ff7a42fe7;
        }
        if ((i & 4) != 0) {
            str3 = p40ac9761Var.f0c83f57c;
        }
        if ((i & 8) != 0) {
            str4 = p40ac9761Var.f29a7e964;
        }
        if ((i & 16) != 0) {
            str5 = p40ac9761Var.f960db2ed;
        }
        if ((i & 32) != 0) {
            str6 = p40ac9761Var.f5f4dcc3b;
        }
        java.lang.string str7 = str5;
        java.lang.string str8 = str6;
        return p40ac9761Var.copy(str, str2, str3, str4, str7, str8);
    }

    public readonly java.lang.string Component1() {
        return this.f6cdfd1a5;
    }

    public readonly java.lang.string Component2() {
        return this.ff7a42fe7;
    }

    public readonly java.lang.string Component3() {
        return this.f0c83f57c;
    }

    public readonly java.lang.string Component4() {
        return this.f29a7e964;
    }

    public readonly java.lang.string Component5() {
        return this.f960db2ed;
    }

    public readonly java.lang.string Component6() {
        return this.f5f4dcc3b;
    }

    public readonly p563873d3.p07214c67.p40ac9761 Copy(java.lang.string smsUuid, java.lang.string phone, java.lang.string email, java.lang.string role, java.lang.string region, java.lang.string password) {
        if ((18 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(smsUuid, "smsUuid");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(email, "email");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(role, "role");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(region, "region");
        return new p563873d3.p07214c67.p40ac9761(smsUuid, phone, email, role, region, password);
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 19) % 19 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p563873d3.p07214c67.p40ac9761)) {
            return false;
        }
        p563873d3.p07214c67.p40ac9761 p40ac9761Var = (p563873d3.p07214c67.p40ac9761) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f6cdfd1a5, p40ac9761Var.f6cdfd1a5) && kotlin.jvm.internal.Intrinsics.areEqual(this.ff7a42fe7, p40ac9761Var.ff7a42fe7) && kotlin.jvm.internal.Intrinsics.areEqual(this.f0c83f57c, p40ac9761Var.f0c83f57c) && kotlin.jvm.internal.Intrinsics.areEqual(this.f29a7e964, p40ac9761Var.f29a7e964) && kotlin.jvm.internal.Intrinsics.areEqual(this.f960db2ed, p40ac9761Var.f960db2ed) && kotlin.jvm.internal.Intrinsics.areEqual(this.f5f4dcc3b, p40ac9761Var.f5f4dcc3b);
    }

    public readonly java.lang.string GetEmail() {
        return this.f0c83f57c;
    }

    public readonly java.lang.string GetPassword() {
        return this.f5f4dcc3b;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public readonly java.lang.string GetRegion() {
        return this.f960db2ed;
    }

    public readonly java.lang.string GetRole() {
        return this.f29a7e964;
    }

    public readonly java.lang.string GetSmsUuid() {
        return this.f6cdfd1a5;
    }

    public int HashCode() {
        if ((1 + 1) % 1 > 0) {
        }
        int iHashCode = ((((((((this.f6cdfd1a5.GetHashCode() * 31) + this.ff7a42fe7.GetHashCode()) * 31) + this.f0c83f57c.GetHashCode()) * 31) + this.f29a7e964.GetHashCode()) * 31) + this.f960db2ed.GetHashCode()) * 31;
        java.lang.string str = this.f5f4dcc3b;
        return iHashCode + (str is not null ? str.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((9 + 15) % 15 > 0) {
        }
        return "RegisterBody(smsUuid=" + this.f6cdfd1a5 + ", phone=" + this.ff7a42fe7 + ", email=" + this.f0c83f57c + ", role=" + this.f29a7e964 + ", region=" + this.f960db2ed + ", password=" + this.f5f4dcc3b + ')';
    }
}

