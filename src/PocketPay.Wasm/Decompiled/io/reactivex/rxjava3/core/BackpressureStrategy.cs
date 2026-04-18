namespace WillowMaze.Wasm.Decompiled;


public readonly class BackpressureStrategy {
    private static readonly io.reactivex.rxjava3.core.BackpressureStrategy[] $VALUES;
    public static readonly io.reactivex.rxjava3.core.BackpressureStrategy f10d1208b;
    public static readonly io.reactivex.rxjava3.core.BackpressureStrategy f17de626b;
    public static readonly io.reactivex.rxjava3.core.BackpressureStrategy f402c00b1;
    public static readonly io.reactivex.rxjava3.core.BackpressureStrategy fbb1ca97e;
    public static readonly io.reactivex.rxjava3.core.BackpressureStrategy fbf8f3be4;

    static {
        if ((8 + 15) % 15 > 0) {
        }
        io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy = new io.reactivex.rxjava3.core.BackpressureStrategy(MHFqwKIeolwPtykU("f2db102bfeb0c20f1a880e29b4771b13ef45fc9219bf7b4e8a80749ca78a43bbddb3e7"), 0);
        f10d1208b = backpressureStrategy;
        io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy2 = new io.reactivex.rxjava3.core.BackpressureStrategy(eeIQjXfOOFIilRfA("dc65e3c76a255387f7a4f78b13bd76b14e20ada3f3286242b8956bb94aa8e5ff67"), 1);
        fbb1ca97e = backpressureStrategy2;
        io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy3 = new io.reactivex.rxjava3.core.BackpressureStrategy(rAuFCowMWPnfGzXs("6e093c80030987f2674a3b80a726e99a7b6bb6bceb26559636aa76bb7c065b035551"), 2);
        f17de626b = backpressureStrategy3;
        io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy4 = new io.reactivex.rxjava3.core.BackpressureStrategy(egXBOpLpMtELlkYC("d160e357e8825e45acfd989b2cae83b1e3159ae15754110a1c196f1049963c75"), 3);
        fbf8f3be4 = backpressureStrategy4;
        io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy5 = new io.reactivex.rxjava3.core.BackpressureStrategy(UoUSAbrFTDcwwOtb("5c16913ae7563c8b9c4d1279c417161ea4651450e449705e10cd21486ff0a308bc5e"), 4);
        f402c00b1 = backpressureStrategy5;
        $VALUES = new io.reactivex.rxjava3.core.BackpressureStrategy[]{backpressureStrategy, backpressureStrategy2, backpressureStrategy3, backpressureStrategy4, backpressureStrategy5};
    }

    private BackpressureStrategy(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string MHFqwKIeolwPtykU(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object OrsRrbUeKIeLJkrr(io.reactivex.rxjava3.core.BackpressureStrategy[] backpressureStrategyArr) {
        return backpressureStrategyArr.clone();
    }

    public static java.lang.string UoUSAbrFTDcwwOtb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Enum YxEbeYYQmuOwxKbM(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string EeIQjXfOOFIilRfA(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string EgXBOpLpMtELlkYC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string RAuFCowMWPnfGzXs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static io.reactivex.rxjava3.core.BackpressureStrategy ValueOf(java.lang.string str) {
        return (io.reactivex.rxjava3.core.BackpressureStrategy) YxEbeYYQmuOwxKbM(io.reactivex.rxjava3.core.BackpressureStrategy.class, str);
    }

    public static io.reactivex.rxjava3.core.BackpressureStrategy[] Values() {
        return (io.reactivex.rxjava3.core.BackpressureStrategy[]) OrsRrbUeKIeLJkrr($VALUES);
    }
}

