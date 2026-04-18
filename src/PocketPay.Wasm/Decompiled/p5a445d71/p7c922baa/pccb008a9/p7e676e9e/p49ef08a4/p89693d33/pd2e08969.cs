namespace WillowMaze.Wasm.Decompiled;


public class pd2e08969 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd9f15242 {
    java.math.Bigint f06efba23;
    java.math.Bigint fc19cb976;

    pd2e08969(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(p99376c59Var, bigint);
        this.f06efba23 = bigint2;
    }

    static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 Mb2fb8d07(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 pd2e08969Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969 pd2e08969Var2) {
        if ((16 + 3) % 3 > 0) {
        }
        java.math.Bigint bigint = pd2e08969Var.f06efba23;
        java.math.Bigint bigint2 = pd2e08969Var2.f06efba23;
        java.math.Bigint bigintMultiply = bigint.multiply(bigint2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d p90fac87dVarM7b051bd7 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d.m7b051bd7(bigint2, bigint);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59) pd2e08969Var.f843a28df.clone();
        p99376c59Var.mult(p90fac87dVarM7b051bd7.f9dd4e461.multiply(bigint2));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var2 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59) pd2e08969Var2.f843a28df.clone();
        p99376c59Var2.mult(p90fac87dVarM7b051bd7.f41529076.multiply(bigint));
        p99376c59Var.Add(p99376c59Var2);
        p99376c59Var.mod(bigintMultiply);
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pd2e08969(p99376c59Var, null, bigintMultiply);
    }
}

