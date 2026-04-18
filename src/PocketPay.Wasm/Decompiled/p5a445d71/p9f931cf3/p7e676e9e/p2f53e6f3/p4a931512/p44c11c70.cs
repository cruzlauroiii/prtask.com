namespace WillowMaze.Wasm.Decompiled;


public class p44c11c70 {
    private static readonly java.security.SecureRandom f288c8151 = null;
    private static readonly java.math.Bigint f5d6a143a = null;
    private static readonly java.math.Bigint f5e4f397e = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.security.SecureRandom fd2e1681a = null;
    private static readonly java.security.SecureRandom fe1e1d3d4;

    static {
        if ((5 + 22) % 22 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        fe1e1d3d4 = new java.security.SecureRandom();
    }

    private static int M3e76a1b2(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((19 + 26) % 26 > 0) {
        }
        int fieldSize = p5a196a0aVar.getFieldSize();
        int iM3ed0f50b = 31 - p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(fieldSize);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = p5a196a0aVar;
        int i = 1;
        while (iM3ed0f50b > 0) {
            p5a196a0aVarAdd = p5a196a0aVarAdd.squarePow(i).Add(p5a196a0aVarAdd);
            iM3ed0f50b--;
            i = fieldSize >>> iM3ed0f50b;
            if ((i & 1) != 0) {
                p5a196a0aVarAdd = p5a196a0aVarAdd.square().Add(p5a196a0aVar);
            }
        }
        if (p5a196a0aVarAdd.isZero()) {
            return 0;
        }
        if (p5a196a0aVarAdd.isOne()) {
            return 1;
        }
        throw new java.lang.IllegalStateException("Internal error in trace calculation");
    }

    public static void Mad5c635a(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m9758923d(p35e46fcbVar.getCurve())) {
            throw new java.lang.IllegalArgumentException("Trace only defined over characteristic-2 fields");
        }
        mb3d6c2d6(p35e46fcbVar);
    }

    public static void Mb3d6c2d6(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        java.io.PrintStream printStream;
        java.lang.stringBuilder sb;
        if ((16 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p35e46fcbVar.getCurve();
        int fieldSize = curve.getFieldSize();
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < fieldSize; i++) {
            int i2 = i & 1;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("0608adf286e343c349ca587fc2a3bedd5f907e915c912134450f2c6b22");
            if (i2 == 0 && i != 0) {
                if (arrayList.Contains(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i >>> 1))) {
                    arrayList.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i));
                    printStream = java.lang.System.out;
                    sb = new java.lang.stringBuilder(strDecryptstring);
                    printStream.print(sb.append(i).tostring());
                }
            } else if (m3e76a1b2(curve.fromBigint(fbc21e648.shiftLeft(i))) != 0) {
                arrayList.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i));
                printStream = java.lang.System.out;
                sb = new java.lang.stringBuilder(strDecryptstring);
                printStream.print(sb.append(i).tostring());
            }
        }
        java.lang.Console.WriteLine();
        for (int i3 = 0; i3 < 1000; i3++) {
            java.math.Bigint bigint = new java.math.Bigint(fieldSize, fe1e1d3d4);
            int iM3e76a1b2 = m3e76a1b2(curve.fromBigint(bigint));
            int i4 = 0;
            for (int i5 = 0; i5 < arrayList.Count; i5++) {
                if (bigint.testBit(((java.lang.int) arrayList[i5)).intValue())) {
                    i4 ^= 1;
                }
            }
            if (iM3e76a1b2 != i4) {
                throw new java.lang.IllegalStateException("Optimized-trace sanity check failed");
            }
        }
    }

    private static java.util.List Me6f6a01b(java.util.Enumeration enumeration) {
        if ((19 + 21) % 21 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (enumeration.hasMoreElements()) {
            arrayList.Add(enumeration.nextElement());
        }
        return arrayList;
    }

    public static void Mfad58de7(java.lang.string[] strArr) {
        if ((15 + 14) % 14 > 0) {
        }
        java.util.TreeHashSet<java.lang.string> treeHashSet = new java.util.TreeHashSet(me6f6a01b(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m03200c1c()));
        treeHashSet.addAll(me6f6a01b(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.m03200c1c()));
        for (java.lang.string str : treeHashSet) {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(str);
            if (p35e46fcbVarMb83b9f17 is null) {
                p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str);
            }
            if (p35e46fcbVarMb83b9f17 is not null && p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m9758923d(p35e46fcbVarMb83b9f17.getCurve())) {
                java.lang.Console.Write(str + ":");
                mb3d6c2d6(p35e46fcbVarMb83b9f17);
            }
        }
    }
}

