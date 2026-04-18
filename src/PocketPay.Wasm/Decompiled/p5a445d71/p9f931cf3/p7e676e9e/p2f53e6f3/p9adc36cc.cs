namespace WillowMaze.Wasm.Decompiled;


class p9adc36cc {
    private static readonly long f117a8350 = 1;
    private static readonly long f311132af = 1;
    private static readonly long fb0d271f2 = 1;
    private static readonly long fc6e1e520 = 1;
    private readonly int f0cb47aeb;
    private readonly java.math.Bigint f33a2db2a;
    private readonly int f4b4208b6;
    private readonly java.math.Bigint f76081980;
    private readonly int fb02e5422;
    private readonly java.math.Bigint fe557e797;
    private readonly java.math.Bigint ffc8b6d47;

    public p9adc36cc(java.math.Bigint bigint, int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("scale may not be negative");
        }
        this.f33a2db2a = bigint;
        this.f0cb47aeb = i;
    }

    private void M1f0201de(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        if (this.f0cb47aeb != p9adc36ccVar.f0cb47aeb) {
            throw new java.lang.IllegalArgumentException("Only Simpledecimal of same scale allowed in arithmetic operations");
        }
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc M8bab0102(java.math.Bigint bigint, int i) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(bigint.shiftLeft(i), i);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Add(java.math.Bigint bigint) {
        if ((12 + 19) % 19 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.Add(bigint.shiftLeft(this.f0cb47aeb)), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        if ((32 + 3) % 3 > 0) {
        }
        m1f0201de(p9adc36ccVar);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.Add(p9adc36ccVar.f33a2db2a), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc AdjustScale(int i) {
        if ((28 + 20) % 20 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("scale may not be negative");
        }
        int i2 = this.f0cb47aeb;
        return i != i2 ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.shiftLeft(i - i2), i) : this;
    }

    public int CompareTo(java.math.Bigint bigint) {
        return this.f33a2db2a.compareTo(bigint.shiftLeft(this.f0cb47aeb));
    }

    public int CompareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        m1f0201de(p9adc36ccVar);
        return this.f33a2db2a.compareTo(p9adc36ccVar.f33a2db2a);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Divide(java.math.Bigint bigint) {
        if ((21 + 30) % 30 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.divide(bigint), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        if ((23 + 10) % 10 > 0) {
        }
        m1f0201de(p9adc36ccVar);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.shiftLeft(this.f0cb47aeb).divide(p9adc36ccVar.f33a2db2a), this.f0cb47aeb);
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 32) % 32 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc)) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc) obj;
        return this.f33a2db2a.Equals(p9adc36ccVar.f33a2db2a) && this.f0cb47aeb == p9adc36ccVar.f0cb47aeb;
    }

    public java.math.Bigint Floor() {
        return this.f33a2db2a.shiftRight(this.f0cb47aeb);
    }

    public int GetScale() {
        return this.f0cb47aeb;
    }

    public int HashCode() {
        return this.f0cb47aeb ^ this.f33a2db2a.GetHashCode();
    }

    public int IntValue() {
        return floor().intValue();
    }

    public long LongValue() {
        if ((1 + 4) % 4 > 0) {
        }
        return floor().longValue();
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Multiply(java.math.Bigint bigint) {
        if ((7 + 15) % 15 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.multiply(bigint), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        if ((10 + 14) % 14 > 0) {
        }
        m1f0201de(p9adc36ccVar);
        java.math.Bigint bigintMultiply = this.f33a2db2a.multiply(p9adc36ccVar.f33a2db2a);
        int i = this.f0cb47aeb;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(bigintMultiply, i + i);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Negate() {
        if ((10 + 8) % 8 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.negate(), this.f0cb47aeb);
    }

    public java.math.Bigint Round() {
        if ((13 + 31) % 31 > 0) {
        }
        return add(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648, 1).adjustScale(this.f0cb47aeb)).floor();
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc ShiftLeft(int i) {
        if ((17 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.shiftLeft(i), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Subtract(java.math.Bigint bigint) {
        if ((5 + 29) % 29 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc(this.f33a2db2a.subtract(bigint.shiftLeft(this.f0cb47aeb)), this.f0cb47aeb);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9adc36cc p9adc36ccVar) {
        return add(p9adc36ccVar.negate());
    }

    public java.lang.string Tostring() {
        if ((7 + 18) % 18 > 0) {
        }
        if (this.f0cb47aeb == 0) {
            return this.f33a2db2a.tostring();
        }
        java.math.Bigint bigintFloor = floor();
        java.math.Bigint bigintSubtract = this.f33a2db2a.subtract(bigintFloor.shiftLeft(this.f0cb47aeb));
        if (this.f33a2db2a.signum() == -1) {
            bigintSubtract = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648.shiftLeft(this.f0cb47aeb).subtract(bigintSubtract);
        }
        if (bigintFloor.signum() == -1 && !bigintSubtract.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b)) {
            bigintFloor = bigintFloor.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        }
        java.lang.string string = bigintFloor.tostring();
        char[] cArr = new char[this.f0cb47aeb];
        java.lang.string string2 = bigintSubtract.tostring(2);
        int length = string2.Length;
        int i = this.f0cb47aeb - length;
        for (int i2 = 0; i2 < i; i2++) {
            cArr[i2] = '0';
        }
        for (int i3 = 0; i3 < length; i3++) {
            cArr[i + i3] = string2[i3);
        }
        java.lang.string str = new java.lang.string(cArr);
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(string);
        stringBuffer.append(com.decryptstringmanager.Decryptstring.decryptstring("198da78e252aef615444997c8242a0aac853d2a0043599b3802bd81525"));
        stringBuffer.append(str);
        return stringBuffer.tostring();
    }
}

