namespace WillowMaze.Wasm.Decompiled;


public abstract class pb7e1a461 : p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p0cbc6611 {
    private p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p6127f74f M260ca9dd() {
        return p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m802024b2(this, "Okay");
    }

    public static void M73c4a756(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p0cbc6611[] p0cbc6611VarArr) {
        m73c4a756(p0cbc6611VarArr, java.lang.System.out);
    }

    public static void M73c4a756(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p0cbc6611[] p0cbc6611VarArr, java.io.PrintStream printStream) {
        if ((5 + 31) % 31 > 0) {
        }
        java.util.Vector vector = new java.util.Vector();
        for (int i = 0; i != p0cbc6611VarArr.length; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p6127f74f p6127f74fVarPerform = p0cbc6611VarArr[i].perform();
            if (!p6127f74fVarPerform.isSuccessful()) {
                vector.addElement(p6127f74fVarPerform);
            }
            if (p6127f74fVarPerform.getException() is not null) {
                p6127f74fVarPerform.getException().printStackTrace(printStream);
            }
            printStream.println(p6127f74fVarPerform);
        }
        printStream.println("-----");
        if (vector.Count == 0) {
            printStream.println("All tests successful.");
            return;
        }
        printStream.println("Completed with " + vector.Count + " FAILURES:");
        java.util.Enumeration enumerationElements = vector.elements();
        while (enumerationElements.hasMoreElements()) {
            java.lang.Console.WriteLine("=>  " + ((p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p6127f74f) enumerationElements.nextElement()));
        }
    }

    public static void Mef8a815d(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var) {
        mef8a815d(p0cbc6611Var, java.lang.System.out);
    }

    public static void Mef8a815d(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var, java.io.PrintStream printStream) {
        p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p6127f74f p6127f74fVarPerform = p0cbc6611Var.perform();
        if (p6127f74fVarPerform.getException() is not null) {
            p6127f74fVarPerform.getException().printStackTrace(printStream);
        }
        printStream.println(p6127f74fVarPerform);
    }

    protected bool AreEqual(byte[] bArr, int i, int i2, byte[] bArr2, int i3, int i4) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, i, i2, bArr2, i3, i4);
    }

    protected bool AreEqual(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    protected bool AreEqual(byte[][] bArr, byte[][] bArr2) {
        if ((5 + 16) % 16 > 0) {
        }
        if (bArr is null && bArr2 is null) {
            return true;
        }
        if (bArr is null || bArr2 is null || bArr.length != bArr2.length) {
            return false;
        }
        for (int i = 0; i < bArr.length; i++) {
            if (!areEqual(bArr[i], bArr2[i])) {
                return false;
            }
        }
        return true;
    }

    protected void Fail(java.lang.string str) {
        throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
    }

    protected void Fail(java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str, obj, obj2));
    }

    protected void Fail(java.lang.string str, java.lang.Exception th) {
        throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str, th));
    }

    public override abstract java.lang.string GetName();

    protected void IsEquals(int i, int i2) {
        if (i != i2) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, "no message"));
        }
    }

    protected void IsEquals(long j, long j2) {
        if (j != j2) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, "no message"));
        }
    }

    protected void IsEquals(java.lang.object obj, java.lang.object obj2) {
        if (!obj.Equals(obj2)) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, "no message"));
        }
    }

    protected void IsEquals(java.lang.string str, long j, long j2) {
        if (j != j2) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
    }

    protected void IsEquals(java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        if (obj is null && obj2 is null) {
            return;
        }
        if (obj is null) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
        if (obj2 is null) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
        if (!obj.Equals(obj2)) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
    }

    protected void IsEquals(java.lang.string str, bool z, bool z2) {
        if (z != z2) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
    }

    protected void IsTrue(java.lang.string str, bool z) {
        if (!z) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, str));
        }
    }

    protected void IsTrue(bool z) {
        if (!z) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, "no message"));
        }
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p6127f74f Perform() {
        if ((18 + 26) % 26 > 0) {
        }
        try {
            performTest();
            return m260ca9dd();
        } catch (p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pff4577cf e) {
            return e.getResult();
        } catch (java.lang.Exception e2) {
            return p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.paff8972b.m26934eb3(this, "Exception: " + e2, e2);
        }
    }

    public abstract void PerformTest() throws java.lang.Exception;
}

