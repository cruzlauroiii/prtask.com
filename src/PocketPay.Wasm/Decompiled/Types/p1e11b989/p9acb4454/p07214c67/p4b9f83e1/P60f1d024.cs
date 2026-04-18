namespace WillowMaze.Wasm.Decompiled;

public class P60f1d024
{
    private static pb433d3f3 M05e702d9(pe8f32165 P0, string P1, decimal P2, List<object> P3, List<object> P4)
    {
        // str: ""
        // call: pa2839366.<init>
        // call: pe8f32165.getReceiptUtcTimestamp
        // call: p60f1d024.me0bf79dc
        // call: pe8f32165.getPaymentTypes
        // call: pb433d3f3.<init>
        // call: p728cd16b.m9e5b1846
        // call: pe8f32165.getUuid
        // call: pe8f32165.getEmployeeId
        // call: long.longValue
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f9be5efb7
        // field: pad5f82e8.p07214c67.p1e11b989.pd751e33c.fd0749aab
        // type: pb433d3f3
        // type: pa2839366
        return default!;
    }

    private static pe8fa6fcd M2c436586(p23dc4959 P0, string P1)
    {
        // str: "Payment uuid must not be null"
        // call: Intrinsics.checkNotNull
        // call: p60f1d024.mbed876fa
        // call: p23dc4959.getPaymentType
        // call: pe8fa6fcd.<init>
        // call: p23dc4959.getTransaction
        // call: p23dc4959.getAmount
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p23dc4959.getUuid
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148
        // field: java.math.BigDecimal.ZERO
        // type: pe8fa6fcd
        // type: IllegalStateException
        return default!;
    }

    private static decimal M47b5ed4a(decimal P0)
    {
        // call: decimal.signum
        return 0;
    }

    private static pb433d3f3 M7f967382(pe8f32165 P0, string P1, decimal P2, List<object> P3, List<object> P4)
    {
        // str: ""
        // call: p36ac2c8d.<init>
        // call: pe8f32165.getEmployeeId
        // call: pe8f32165.getReceiptUtcTimestamp
        // call: pe8f32165.getUuid
        // call: p728cd16b.m9e5b1846
        // call: long.longValue
        // call: pe8f32165.getPaymentTypes
        // call: p60f1d024.me0bf79dc
        // call: pb433d3f3.<init>
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6
        // field: pad5f82e8.p07214c67.p1e11b989.pd751e33c.fd0749aab
        // type: pb433d3f3
        // type: p36ac2c8d
        return default!;
    }

    private static p8e34383c Mb28e01df(pd74471b0 P0, string P1)
    {
        // str: "subtract(...)"
        // str: "cd254376ddc57b198ecda424a95c4bcf637af7236fa43a9e99498885371d"
        // str: "ZERO"
        // str: "toString(...)"
        // str: ""
        // call: p60f1d024.m47b5ed4a
        // call: p8e34383c.<init>
        // call: pd74471b0.getDiscountAmount
        // call: pd74471b0.getPrice
        // call: DecryptString.decryptString
        // call: pd74471b0.getQuantity
        // call: Guid.toString
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pd74471b0.getMeasure
        // call: Guid.randomUUID
        // call: pd74471b0.getName
        // call: decimal.subtract
        // call: pd031d465$p910eef8c.getDefaultPrecision
        // field: java.math.BigDecimal.ZERO
        // field: pad5f82e8.p07214c67.p1e11b989.pd031d465.f910eef8c
        // type: p8e34383c
        return default!;
    }

    public static p85cc901a Mbed876fa(p79faa3e4 P0)
    {
        // str: ""
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p79faa3e4.getStan
        // call: p79faa3e4.getResponseCode
        // call: p79faa3e4.getTopRefUuid
        // call: p79faa3e4.getAuthCode
        // call: p85cc901a.<init>
        // call: p79faa3e4.getTerminalId
        // call: p79faa3e4.getMerchantId
        // call: p79faa3e4.getRrn
        // type: p85cc901a
        return default!;
    }

    private static p8c261c90 Me0bf79dc(List<object> P0)
    {
        // call: Enum.name
        // call: CollectionsKt.firstOrNull
        // call: Intrinsics.areEqual
        // call: p8c261c90.values
        // call: List<object>.size
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9cb40e51
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148
        return default!;
    }

    public static pb433d3f3 Me26e46c2(pe8f32165 P0, string P1)
    {
        // str: "<this>"
        // str: "deviceId"
        // str: "subtract(...)"
        // str: "Receipt uuid must not be null"
        // call: Intrinsics.areEqual
        // call: IEnumerator<object>.next
        // call: ICollection<object>.add
        // call: pe8f32165.getPositions
        // call: List<object>.<init>
        // call: pd74471b0.getDiscountAmount
        // call: p60f1d024.m05e702d9
        // call: object.toString
        // call: pe8f32165.getPayments
        // call: p5a409c20.values
        // call: Enum.name
        // call: pe8f32165.getUuid
        // call: pe8f32165.getReceiptDiscount
        // call: IEnumerator<object>.hasNext
        // call: p60f1d024.m47b5ed4a
        // call: Intrinsics.checkNotNullParameter
        // call: CollectionsKt.collectionSizeOrDefault
        // call: p60f1d024.m7f967382
        // call: CollectionsKt.emptyList
        // call: p60f1d024.m2c436586
        // field: kotlin.jvm.internal.Ref$ObjectRef.element
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6
        // field: p1e11b989.p9acb4454.p07214c67.p4b9f83e1.p60f1d024$p12c674ac.$EnumSwitchMapping$0
        // type: List<object>
        // type: IllegalStateException
        // type: IllegalArgumentException
        // type: Ref$ObjectRef
        return default!;
    }

}
