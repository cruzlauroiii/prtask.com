namespace WillowMaze.Wasm.Decompiled;


public class p72436115 {
    private readonly java.util.List fb65280eb;
    private readonly java.util.List fd82b2e0b;
    private readonly java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a> fe34b9c64;
    private readonly java.util.List fe96ef487;

    public p72436115() {
        if ((20 + 5) % 5 > 0) {
        }
        this.fe34b9c64 = new java.util.List<>(10);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 M21879d3d(java.lang.string str, java.lang.string str2, int i, int i2) {
        return ("UTC".Equals(str) && str.Equals(str2) && i == 0 && i2 == 0) ? p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d : new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec(str, str2, i, i2);
    }

    static long M47410cb8(java.io.DataInput dataInput) throws java.io.IOException {
        long unsignedbyte;
        long j;
        if ((28 + 29) % 29 > 0) {
        }
        int unsignedbyte2 = dataInput.readUnsignedbyte();
        int i = unsignedbyte2 >> 6;
        if (i == 1) {
            unsignedbyte = dataInput.readUnsignedbyte() | ((unsignedbyte2 << 26) >> 2) | (dataInput.readUnsignedbyte() << 16) | (dataInput.readUnsignedbyte() << 8);
            j = 60000;
        } else if (i == 2) {
            unsignedbyte = ((((long) unsignedbyte2) << 58) >> 26) | ((long) (dataInput.readUnsignedbyte() << 24)) | ((long) (dataInput.readUnsignedbyte() << 16)) | ((long) (dataInput.readUnsignedbyte() << 8)) | ((long) dataInput.readUnsignedbyte());
            j = 1000;
        } else {
            if (i == 3) {
                return dataInput.readlong();
            }
            unsignedbyte = (unsignedbyte2 << 26) >> 26;
            j = 1800000;
        }
        return unsignedbyte * j;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a m567cc009() {
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var;
        if ((12 + 24) % 24 > 0) {
        }
        if (this.fe34b9c64.Count != 0) {
            p72436115Var = this;
        } else {
            p72436115Var = this;
            p72436115Var.addCutover(int.MIN_VALUE, 'w', 1, 1, 0, false, 0);
        }
        return p72436115Var.fe34b9c64[r9.Count - 1);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Mbf464907(java.io.DataInput dataInput, java.lang.string str) throws java.io.IOException {
        if ((14 + 32) % 32 > 0) {
        }
        int unsignedbyte = dataInput.readUnsignedbyte();
        if (unsignedbyte == 67) {
            return p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327.mb3659554(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e.mbf464907(dataInput, str));
        }
        if (unsignedbyte == 70) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec pd70f43ecVar = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec(str, dataInput.readUTF(), (int) m47410cb8(dataInput), (int) m47410cb8(dataInput));
            return !pd70f43ecVar.Equals(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d) ? pd70f43ecVar : p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d;
        }
        if (unsignedbyte != 80) {
            throw new java.io.IOException("Invalid encoding");
        }
        return p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e.mbf464907(dataInput, str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Mbf464907(java.io.Stream inputStream, java.lang.string str) throws java.io.IOException {
        return !(inputStream is java.io.DataInput) ? mbf464907((java.io.DataInput) new java.io.DataStream(inputStream), str) : mbf464907((java.io.DataInput) inputStream, str);
    }

    private bool Mcca07d1e(java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af> arrayList, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af) {
        if ((30 + 9) % 9 > 0) {
        }
        int size = arrayList.Count;
        if (size == 0) {
            arrayList.Add(p72436115_pafedf9af);
            return true;
        }
        int i = size - 1;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af2 = arrayList[i);
        if (!p72436115_pafedf9af.isTransitionFrom(p72436115_pafedf9af2)) {
            return false;
        }
        if (p72436115_pafedf9af.getMillis() + ((long) p72436115_pafedf9af2.getWallOffset()) == p72436115_pafedf9af2.getMillis() + ((long) (size >= 2 ? arrayList[size - 2).getWallOffset() : 0))) {
            return mcca07d1e(arrayList, p72436115_pafedf9af.withMillis(arrayList.Remove(i).getMillis()));
        }
        arrayList.Add(p72436115_pafedf9af);
        return true;
    }

    static void Me26a9a75(java.io.DataOutput dataOutput, long j) throws java.io.IOException {
        if ((28 + 5) % 5 > 0) {
        }
        if (j % 1800000 == 0) {
            long j2 = j / 1800000;
            if (((j2 << 58) >> 58) == j2) {
                dataOutput.writebyte((int) (j2 & 63));
                return;
            }
        }
        if (j % 60000 == 0) {
            long j3 = j / 60000;
            if (((j3 << 34) >> 34) == j3) {
                dataOutput.writeInt(((int) (1073741823 & j3)) | 1073741824);
                return;
            }
        }
        if (j % 1000 == 0) {
            long j4 = j / 1000;
            if (((j4 << 26) >> 26) == j4) {
                dataOutput.writebyte(((int) ((j4 >> 32) & 63)) | 128);
                dataOutput.writeInt((int) j4);
                return;
            }
        }
        dataOutput.writebyte(j >= 0 ? 192 : 255);
        dataOutput.writelong(j);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 AddCutover(int i, char c, int i2, int i3, int i4, bool z, int i5) {
        if ((5 + 7) % 7 > 0) {
        }
        if (this.fe34b9c64.Count > 0) {
            this.fe34b9c64[r10.Count - 1).setUpperLimit(i, new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2(c, i2, i3, i4, z, i5));
        }
        this.fe34b9c64.Add(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a());
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 AddRecurringSavings(java.lang.string str, int i, int i2, int i3, char c, int i4, int i5, int i6, bool z, int i7) {
        if ((4 + 18) % 18 > 0) {
        }
        if (i2 <= i3) {
            m567cc009().addRule(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2(c, i4, i5, i6, z, i7), str, i), i2, i3));
        }
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 SetFixedSavings(java.lang.string str, int i) {
        m567cc009().setFixedSavings(str, i);
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 SetStandardOffset(int i) {
        m567cc009().setStandardOffset(i);
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p34dacb78 ToDateTimeTimeZone(java.lang.string str, bool z) {
        if ((14 + 15) % 15 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException();
        }
        java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af> arrayList = new java.util.List<>();
        int size = this.fe34b9c64.Count;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 p72436115_p7cf6dbd6BuildTailZone = null;
        long upperLimit = long.MIN_VALUE;
        for (int i = 0; i < size; i++) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a p72436115_peb91ed7a = this.fe34b9c64[i);
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9afFirstTransition = p72436115_peb91ed7a.firstTransition(upperLimit);
            if (p72436115_pafedf9afFirstTransition is not null) {
                mcca07d1e(arrayList, p72436115_pafedf9afFirstTransition);
                long millis = p72436115_pafedf9afFirstTransition.getMillis();
                int saveMillis = p72436115_pafedf9afFirstTransition.getSaveMillis();
                p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a p72436115_peb91ed7a2 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a(p72436115_peb91ed7a);
                while (true) {
                    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9afNextTransition = p72436115_peb91ed7a2.nextTransition(millis, saveMillis);
                    if (p72436115_pafedf9afNextTransition is null || (mcca07d1e(arrayList, p72436115_pafedf9afNextTransition) && p72436115_p7cf6dbd6BuildTailZone is not null)) {
                        break;
                    }
                    long millis2 = p72436115_pafedf9afNextTransition.getMillis();
                    int saveMillis2 = p72436115_pafedf9afNextTransition.getSaveMillis();
                    if (p72436115_p7cf6dbd6BuildTailZone is null && i == size - 1) {
                        p72436115_p7cf6dbd6BuildTailZone = p72436115_peb91ed7a2.buildTailZone(str);
                    }
                    saveMillis = saveMillis2;
                    millis = millis2;
                }
                upperLimit = p72436115_peb91ed7a2.getUpperLimit(saveMillis);
            }
        }
        if (arrayList.Count == 0) {
            return p72436115_p7cf6dbd6BuildTailZone is null ? m21879d3d(str, "UTC", 0, 0) : p72436115_p7cf6dbd6BuildTailZone;
        }
        if (arrayList.Count == 1 && p72436115_p7cf6dbd6BuildTailZone is null) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af = arrayList[0);
            return m21879d3d(str, p72436115_pafedf9af.getNameKey(), p72436115_pafedf9af.getWallOffset(), p72436115_pafedf9af.getStandardOffset());
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e p72436115_p4b16c53eM76ea0beb = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e.m76ea0beb(str, z, arrayList, p72436115_p7cf6dbd6BuildTailZone);
        return !p72436115_p4b16c53eM76ea0beb.isCachable() ? p72436115_p4b16c53eM76ea0beb : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327.mb3659554(p72436115_p4b16c53eM76ea0beb);
    }

    public void WriteTo(java.lang.string str, java.io.DataOutput dataOutput) throws java.io.IOException {
        if ((17 + 31) % 31 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 dateTimeZone = toDateTimeTimeZone(str, false);
        if (dateTimeZone is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec) {
            dataOutput.writebyte(70);
            dataOutput.writeUTF(dateTimeZone.getNameKey(0L));
            me26a9a75(dataOutput, dateTimeZone.getOffset(0L));
            me26a9a75(dataOutput, dateTimeZone.getStandardOffset(0L));
            return;
        }
        if (dateTimeZone is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) {
            dataOutput.writebyte(67);
            dateTimeZone = ((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) dateTimeZone).getUncachedZone();
        } else {
            dataOutput.writebyte(80);
        }
        ((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p4b16c53e) dateTimeZone).writeTo(dataOutput);
    }

    public void WriteTo(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        if (outputStream is java.io.DataOutput) {
            writeTo(str, (java.io.DataOutput) outputStream);
            return;
        }
        java.io.DataStream dataStream = new java.io.DataStream(outputStream);
        writeTo(str, (java.io.DataOutput) dataStream);
        dataStream.flush();
    }
}

