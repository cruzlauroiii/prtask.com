namespace WillowMaze.Wasm.Decompiled;


public abstract class pa827ecfa$p7979ad97 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa {
    private java.math.Bigint[] f14a047fc;
    private java.math.Bigint[] f3300ca07;
    private java.math.Bigint[] fac5585d9;
    private java.math.Bigint[] fc7c217b0;
    private java.math.Bigint[] fdc902f61;

    protected pa827ecfa$p7979ad97(int i, int i2, int i3, int i4) {
        super(m14402bcc(i, i2, i3, i4));
        this.fac5585d9 = null;
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 M14402bcc(int i, int i2, int i3, int i4) {
        if (i2 == 0) {
            throw new java.lang.IllegalArgumentException("k1 must be > 0");
        }
        if (i3 == 0) {
            if (i4 != 0) {
                throw new java.lang.IllegalArgumentException("k3 must be 0 if k2 == 0");
            }
            return p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p41678799.m606a117f(new int[]{0, i2, i});
        }
        if (i3 <= i2) {
            throw new java.lang.IllegalArgumentException("k2 must be > k1");
        }
        if (i4 <= i3) {
            throw new java.lang.IllegalArgumentException("k3 must be > k2");
        }
        return p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p41678799.m606a117f(new int[]{0, i2, i3, i4, i});
    }

    private static java.math.Bigint M7f54ec10(java.security.SecureRandom secureRandom, int i) {
        java.math.Bigint bigintM861a7ab4;
        if ((8 + 4) % 4 > 0) {
        }
        do {
            bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(i, secureRandom);
        } while (bigintM861a7ab4.signum() <= 0);
        return bigintM861a7ab4;
    }

    public static java.math.Bigint Ma91c78e0(int i, int[] iArr, java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253(bigint).modInverse(i, iArr).toBigint();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreatePoint(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((23 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = fromBigint(bigint);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint2 = fromBigint(bigint2);
        int coordinateSystem = getCoordinateSystem();
        if (coordinateSystem == 5 || coordinateSystem == 6) {
            if (!p5a196a0aVarFromBigint.isZero()) {
                p5a196a0aVarFromBigint2 = p5a196a0aVarFromBigint2.divide(p5a196a0aVarFromBigint).Add(p5a196a0aVarFromBigint);
            } else if (!p5a196a0aVarFromBigint2.square().Equals(getB())) {
                throw new java.lang.IllegalArgumentException();
            }
        }
        return createRawPoint(p5a196a0aVarFromBigint, p5a196a0aVarFromBigint2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f DecompressPoint(int i, java.math.Bigint bigint) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd;
        if ((5 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = fromBigint(bigint);
        if (p5a196a0aVarFromBigint.isZero()) {
            p5a196a0aVarAdd = getB().sqrt();
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSolveQuadraticEquation = solveQuadraticEquation(p5a196a0aVarFromBigint.square().invert().multiply(getB()).Add(getA()).Add(p5a196a0aVarFromBigint));
            if (p5a196a0aVarSolveQuadraticEquation is null) {
                p5a196a0aVarAdd = null;
            } else {
                if (p5a196a0aVarSolveQuadraticEquation.testBitZero() != (i == 1)) {
                    p5a196a0aVarSolveQuadraticEquation = p5a196a0aVarSolveQuadraticEquation.addOne();
                }
                int coordinateSystem = getCoordinateSystem();
                p5a196a0aVarAdd = (coordinateSystem == 5 || coordinateSystem == 6) ? p5a196a0aVarSolveQuadraticEquation.Add(p5a196a0aVarFromBigint) : p5a196a0aVarSolveQuadraticEquation.multiply(p5a196a0aVarFromBigint);
            }
        }
        if (p5a196a0aVarAdd is null) {
            throw new java.lang.IllegalArgumentException("Invalid point compression");
        }
        return createRawPoint(p5a196a0aVarFromBigint, p5a196a0aVarAdd);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized java.math.Bigint[] GetSi() {
        /*
            r1 = this;
            goto L13
        L4:
            goto L16
        L7:
            return r0
        L8:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L8
            goto Le
        Le:
            throw r0
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L1a
        L1a:
            monitor-enter(r1)
            java.math.Bigint[] r0 = r1.fac5585d9     // Catch: java.lang.Exception -> L8
            if (r0 != 0) goto L25
            java.math.Bigint[] r0 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.m8a5de957(r1)     // Catch: java.lang.Exception -> L8
            r1.fac5585d9 = r0     // Catch: java.lang.Exception -> L8
        L25:
            java.math.Bigint[] r0 = r1.fac5585d9     // Catch: java.lang.Exception -> L8
            goto L2b
        L2b:
            monitor-exit(r1)
            goto L7
        */
        throw new UnsupportedOperationException("Method not decompiled: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.getSi():java.math.Bigint[]");
    }

    public bool IsKoblitz() {
        if (this.f70a17ffa is null || this.ff89ed0d1 is null || !this.f92eb5ffe.isOne()) {
            return false;
        }
        return this.f0cc175b9.isZero() || this.f0cc175b9.isOne();
    }

    public override bool IsValidFieldElement(java.math.Bigint bigint) {
        return bigint is not null && bigint.signum() >= 0 && bigint.bitLength() <= getFieldSize();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElement(java.security.SecureRandom secureRandom) {
        return fromBigint(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(getFieldSize(), secureRandom));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElementMult(java.security.SecureRandom secureRandom) {
        if ((8 + 7) % 7 > 0) {
        }
        int fieldSize = getFieldSize();
        return fromBigint(m7f54ec10(secureRandom, fieldSize)).multiply(fromBigint(m7f54ec10(secureRandom, fieldSize)));
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SolveQuadraticEquation(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd;
        if ((16 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97 p5a196a0a_p7979ad97 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97) p5a196a0aVar;
        bool zHasFastTrace = p5a196a0a_p7979ad97.hasFastTrace();
        if (zHasFastTrace && p5a196a0a_p7979ad97.trace() != 0) {
            return null;
        }
        int fieldSize = getFieldSize();
        if ((fieldSize & 1) != 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarHalfTrace = p5a196a0a_p7979ad97.halfTrace();
            if (zHasFastTrace || p5a196a0aVarHalfTrace.square().Add(p5a196a0aVarHalfTrace).Add(p5a196a0aVar).isZero()) {
                return p5a196a0aVarHalfTrace;
            }
            return null;
        }
        if (p5a196a0aVar.isZero()) {
            return p5a196a0aVar;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b);
        java.util.Random random = new java.util.Random();
        do {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint2 = fromBigint(new java.math.Bigint(fieldSize, random));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd2 = p5a196a0aVar;
            p5a196a0aVarAdd = p5a196a0aVarFromBigint;
            for (int i = 1; i < fieldSize; i++) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVarAdd2.square();
                p5a196a0aVarAdd = p5a196a0aVarAdd.square().Add(p5a196a0aVarSquare.multiply(p5a196a0aVarFromBigint2));
                p5a196a0aVarAdd2 = p5a196a0aVarSquare.Add(p5a196a0aVar);
            }
            if (!p5a196a0aVarAdd2.isZero()) {
                return null;
            }
        } while (p5a196a0aVarAdd.square().Add(p5a196a0aVarAdd).isZero());
        return p5a196a0aVarAdd;
    }
}

