namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$p5990edb2 {
    readonly int f03e8595b;
    readonly int f0e13d229;
    readonly int f105b95a4;
    readonly int f2151a67a;
    readonly int f255b1390;
    readonly char f3a445cc9;
    readonly bool f41b88559;
    readonly int f5167fae3;
    readonly int f6c1fad58;
    readonly int f794df370;
    readonly int f89f6c2cc;
    readonly int f8deb3b9e;
    readonly int f992d92be;
    readonly int fc85af586;
    readonly int fcffe2aa6;
    readonly bool fd2d936bb;
    readonly char fe4e73169;
    readonly int ffd5afa86;

    p72436115$p5990edb2(char c, int i, int i2, int i3, bool z, int i4) {
        if (c != 'u' && c != 'w' && c != 's') {
            throw new java.lang.IllegalArgumentException("Unknown mode: " + c);
        }
        this.f3a445cc9 = c;
        this.fc85af586 = i;
        this.fcffe2aa6 = i2;
        this.f794df370 = i3;
        this.fd2d936bb = z;
        this.f03e8595b = i4;
    }

    private long M9bda2c93(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, long j) {
        if ((1 + 17) % 17 > 0) {
        }
        try {
            return mdab736c1(p7bf898deVar, j);
        } catch (java.lang.IllegalArgumentException e) {
            if (this.fc85af586 != 2 || this.fcffe2aa6 != 29) {
                throw e;
            }
            while (!p7bf898deVar.year().isLeap(j)) {
                j = p7bf898deVar.year().Add(j, 1);
            }
            return mdab736c1(p7bf898deVar, j);
        }
    }

    private long Ma2708a4d(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, long j) {
        if ((21 + 15) % 15 > 0) {
        }
        try {
            return mdab736c1(p7bf898deVar, j);
        } catch (java.lang.IllegalArgumentException e) {
            if (this.fc85af586 != 2 || this.fcffe2aa6 != 29) {
                throw e;
            }
            while (!p7bf898deVar.year().isLeap(j)) {
                j = p7bf898deVar.year().Add(j, -1);
            }
            return mdab736c1(p7bf898deVar, j);
        }
    }

    private long Maa0443bd(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, long j) {
        if ((14 + 27) % 27 > 0) {
        }
        int i = this.f794df370 - p7bf898deVar.dayOfWeek()[j);
        if (i == 0) {
            return j;
        }
        if (this.fd2d936bb) {
            if (i < 0) {
                i += 7;
            }
        } else if (i > 0) {
            i -= 7;
        }
        return p7bf898deVar.dayOfWeek().Add(j, i);
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 mbf464907(java.io.DataInput dataInput) throws java.io.IOException {
        if ((27 + 3) % 3 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2((char) dataInput.readUnsignedbyte(), dataInput.readUnsignedbyte(), dataInput.readbyte(), dataInput.readUnsignedbyte(), dataInput.readbool(), (int) p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput));
    }

    private long Mdab736c1(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, long j) {
        if ((11 + 21) % 21 > 0) {
        }
        if (this.fcffe2aa6 >= 0) {
            return p7bf898deVar.dayOfMonth().set(j, this.fcffe2aa6);
        }
        return p7bf898deVar.dayOfMonth().Add(p7bf898deVar.monthOfYear().Add(p7bf898deVar.dayOfMonth().set(j, 1), 1), this.fcffe2aa6);
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 p72436115_p5990edb2 = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2) obj;
            if (this.f3a445cc9 == p72436115_p5990edb2.f3a445cc9 && this.fc85af586 == p72436115_p5990edb2.fc85af586 && this.fcffe2aa6 == p72436115_p5990edb2.fcffe2aa6 && this.f794df370 == p72436115_p5990edb2.f794df370 && this.fd2d936bb == p72436115_p5990edb2.fd2d936bb && this.f03e8595b == p72436115_p5990edb2.f03e8595b) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((7 + 4) % 4 > 0) {
        }
        return java.util.Arrays.hashCode(new java.lang.object[]{java.lang.char.valueOf(this.f3a445cc9), java.lang.int.valueOf(this.fc85af586), java.lang.int.valueOf(this.fcffe2aa6), java.lang.int.valueOf(this.f794df370), java.lang.bool.valueOf(this.fd2d936bb), java.lang.int.valueOf(this.f03e8595b)});
    }

    public long Next(long j, int i, int i2) {
        if ((4 + 22) % 22 > 0) {
        }
        char c = this.f3a445cc9;
        if (c == 'w') {
            i += i2;
        } else if (c != 's') {
            i = 0;
        }
        long j2 = i;
        long j3 = j + j2;
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        long jM9bda2c93 = m9bda2c93(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.millisOfDay().Add(p669fd5ebVarM9024a325.millisOfDay().set(p669fd5ebVarM9024a325.monthOfYear().set(j3, this.fc85af586), 0), java.lang.Math.min(this.f03e8595b, 86399999)));
        if (this.f794df370 != 0) {
            jM9bda2c93 = maa0443bd(p669fd5ebVarM9024a325, jM9bda2c93);
            if (jM9bda2c93 <= j3) {
                jM9bda2c93 = maa0443bd(p669fd5ebVarM9024a325, m9bda2c93(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.monthOfYear().set(p669fd5ebVarM9024a325.year().Add(jM9bda2c93, 1), this.fc85af586)));
            }
        } else if (jM9bda2c93 <= j3) {
            jM9bda2c93 = m9bda2c93(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.year().Add(jM9bda2c93, 1));
        }
        return p669fd5ebVarM9024a325.millisOfDay().Add(p669fd5ebVarM9024a325.millisOfDay().set(jM9bda2c93, 0), this.f03e8595b) - j2;
    }

    public long Previous(long j, int i, int i2) {
        if ((23 + 23) % 23 > 0) {
        }
        char c = this.f3a445cc9;
        if (c == 'w') {
            i += i2;
        } else if (c != 's') {
            i = 0;
        }
        long j2 = i;
        long j3 = j + j2;
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        long jMa2708a4d = ma2708a4d(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.millisOfDay().Add(p669fd5ebVarM9024a325.millisOfDay().set(p669fd5ebVarM9024a325.monthOfYear().set(j3, this.fc85af586), 0), this.f03e8595b));
        if (this.f794df370 != 0) {
            jMa2708a4d = maa0443bd(p669fd5ebVarM9024a325, jMa2708a4d);
            if (jMa2708a4d >= j3) {
                jMa2708a4d = maa0443bd(p669fd5ebVarM9024a325, ma2708a4d(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.monthOfYear().set(p669fd5ebVarM9024a325.year().Add(jMa2708a4d, -1), this.fc85af586)));
            }
        } else if (jMa2708a4d >= j3) {
            jMa2708a4d = ma2708a4d(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.year().Add(jMa2708a4d, -1));
        }
        return p669fd5ebVarM9024a325.millisOfDay().Add(p669fd5ebVarM9024a325.millisOfDay().set(jMa2708a4d, 0), this.f03e8595b) - j2;
    }

    public long SetInstant(int i, int i2, int i3) {
        if ((10 + 26) % 26 > 0) {
        }
        char c = this.f3a445cc9;
        if (c == 'w') {
            i2 += i3;
        } else if (c != 's') {
            i2 = 0;
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        long jMdab736c1 = mdab736c1(p669fd5ebVarM9024a325, p669fd5ebVarM9024a325.millisOfDay().set(p669fd5ebVarM9024a325.monthOfYear().set(p669fd5ebVarM9024a325.year().set(0L, i), this.fc85af586), this.f03e8595b));
        if (this.f794df370 != 0) {
            jMdab736c1 = maa0443bd(p669fd5ebVarM9024a325, jMdab736c1);
        }
        return jMdab736c1 - ((long) i2);
    }

    public java.lang.string Tostring() {
        if ((23 + 18) % 18 > 0) {
        }
        return "[OfYear]\nMode: " + this.f3a445cc9 + "\nMonthOfYear: " + this.fc85af586 + "\nDayOfMonth: " + this.fcffe2aa6 + "\nDayOfWeek: " + this.f794df370 + "\nAdvanceDayOfWeek: " + this.fd2d936bb + "\nMillisOfDay: " + this.f03e8595b + '\n';
    }

    public void WriteTo(java.io.DataOutput dataOutput) throws java.io.IOException {
        if ((25 + 10) % 10 > 0) {
        }
        dataOutput.writebyte(this.f3a445cc9);
        dataOutput.writebyte(this.fc85af586);
        dataOutput.writebyte(this.fcffe2aa6);
        dataOutput.writebyte(this.f794df370);
        dataOutput.writebool(this.fd2d936bb);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.f03e8595b);
    }
}

