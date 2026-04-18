namespace WillowMaze.Wasm.Decompiled;


public class pba67773a : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97 {
    protected long[] f37c7d7f8;
    protected long[] f9bf20536;
    protected long[] f9dd4e461;
    protected long[] fb72417c0;
    protected long[] fbeec6e95;

    public pba67773a() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
    }

    public pba67773a(java.math.Bigint bigint) {
        if ((7 + 26) % 26 > 0) {
        }
        if (bigint is null || bigint.signum() < 0 || bigint.bitLength() > 113) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecT113FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m1712f3b8(bigint);
    }

    protected pba67773a(long[] jArr) {
        this.f9dd4e461 = jArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar).f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.mfbf72fda(this.f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return multiply(p5a196a0aVar.invert());
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mc238ce55(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecT113Field";
    }

    public override int GetFieldSize() {
        return 113;
    }

    public int GetK1() {
        return 9;
    }

    public int GetK2() {
        return 0;
    }

    public int GetK3() {
        return 0;
    }

    public int GetM() {
        return 113;
    }

    public int GetRepresentation() {
        return 2;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a HalfTrace() {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m8ae6f599(this.f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override bool HasFastTrace() {
        return true;
    }

    public int HashCode() {
        if ((27 + 14) % 14 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 2) ^ 113009;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m20e57f32(this.f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m7e86d991(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m69c6e24b(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar).f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return multiplyPlusProduct(p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        long[] jArr = this.f9dd4e461;
        long[] jArr2 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar).f9dd4e461;
        long[] jArr3 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar2).f9dd4e461;
        long[] jArr4 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar3).f9dd4e461;
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.mde883c68(jArr, jArr2, jArrMf03001e5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.mde883c68(jArr3, jArr4, jArrMf03001e5);
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.ma6d0c789(jArrMf03001e5, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        return this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.mdd1de98e(this.f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m2fc01ec7(this.f9dd4e461, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return squarePlusProduct(p5a196a0aVar, p5a196a0aVar2);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        long[] jArr = this.f9dd4e461;
        long[] jArr2 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar).f9dd4e461;
        long[] jArr3 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a) p5a196a0aVar2).f9dd4e461;
        long[] jArrMf03001e5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mf03001e5();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.maf110662(jArr, jArrMf03001e5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.mde883c68(jArr2, jArr3, jArrMf03001e5);
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.ma6d0c789(jArrMf03001e5, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePow(int i) {
        if (i < 1) {
            return this;
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m4c1a88a3();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m96dc2752(this.f9dd4e461, i, jArrM4c1a88a3);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba67773a(jArrM4c1a88a3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return add(p5a196a0aVar);
    }

    public override bool TestBitZero() {
        if ((30 + 11) % 11 > 0) {
        }
        return (this.f9dd4e461[0] & 1) != 0;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.ma345cd5e(this.f9dd4e461);
    }

    public override int Trace() {
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pad8eaf3d.m04a75036(this.f9dd4e461);
    }
}

