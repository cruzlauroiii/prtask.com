namespace WillowMaze.Wasm.Decompiled;


public readonly class BackpressureOverflowStrategy {
    private static readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy[] $VALUES;
    public static readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy f07682016;
    public static readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy f1fd40b99;
    public static readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy fbb1ca97e;

    static {
        if ((29 + 14) % 14 > 0) {
        }
        io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy = new io.reactivex.rxjava3.core.BackpressureOverflowStrategy(WYPNJkVwgfuouiFL("4e800f63a330e0e5304c96f80289461200f6f7be4b7c83672e2c9829d2c6239acd"), 0);
        fbb1ca97e = backpressureOverflowStrategy;
        io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy2 = new io.reactivex.rxjava3.core.BackpressureOverflowStrategy(RdFqnANSHWyYOdPz("13ef617c77081d4cfad1d88cfb0bcb50a6612ef226a9bf3157f58d36968b4034ea93cdaad97e7a"), 1);
        f07682016 = backpressureOverflowStrategy2;
        io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy3 = new io.reactivex.rxjava3.core.BackpressureOverflowStrategy(qSbRXoRVrETyBrxF("91990e4b184303909b5debf0854f55e54c8c9ca9761be08fb429c0f95e1b8315df56b7a577241e"), 2);
        f1fd40b99 = backpressureOverflowStrategy3;
        $VALUES = new io.reactivex.rxjava3.core.BackpressureOverflowStrategy[]{backpressureOverflowStrategy, backpressureOverflowStrategy2, backpressureOverflowStrategy3};
    }

    private BackpressureOverflowStrategy(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string RdFqnANSHWyYOdPz(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string WYPNJkVwgfuouiFL(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object IzHEmnkqPpRAEJyt(io.reactivex.rxjava3.core.BackpressureOverflowStrategy[] backpressureOverflowStrategyArr) {
        return backpressureOverflowStrategyArr.clone();
    }

    public static java.lang.Enum NWVaEbxKNCbWNYoC(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string QSbRXoRVrETyBrxF(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static io.reactivex.rxjava3.core.BackpressureOverflowStrategy ValueOf(java.lang.string str) {
        return (io.reactivex.rxjava3.core.BackpressureOverflowStrategy) nWVaEbxKNCbWNYoC(io.reactivex.rxjava3.core.BackpressureOverflowStrategy.class, str);
    }

    public static io.reactivex.rxjava3.core.BackpressureOverflowStrategy[] Values() {
        return (io.reactivex.rxjava3.core.BackpressureOverflowStrategy[]) izHEmnkqPpRAEJyt($VALUES);
    }
}

