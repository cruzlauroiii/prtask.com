namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d : P71d96ecc
{
    private readonly p297c1c27 F06a9ef6b;
    private readonly RoomDatabase F0838d855;
    private readonly SharedSQLiteStatement F0965e16e;
    private readonly SharedSQLiteStatement F0e43e65d;
    private readonly SharedSQLiteStatement F10498f81;
    private readonly EntityDeletionOrUpdateAdapter F18732a7f;
    private readonly EntityInsertionAdapter F1b13ddba;
    private readonly EntityInsertionAdapter F1d13902f;
    private readonly EntityDeletionOrUpdateAdapter F2218c5a2;
    private readonly EntityDeletionOrUpdateAdapter F289000f7;
    private readonly SharedSQLiteStatement F2b8bc11d;
    private readonly EntityDeletionOrUpdateAdapter F2ed36c08;
    private readonly SharedSQLiteStatement F32df433c;
    private readonly EntityDeletionOrUpdateAdapter F3e56dd29;
    private readonly p297c1c27 F46588322;
    private readonly SharedSQLiteStatement F46cccaac;
    private readonly RoomDatabase F46e51b0d;
    private readonly SharedSQLiteStatement F482fff84;
    private readonly EntityDeletionOrUpdateAdapter F4a797351;
    private readonly SharedSQLiteStatement F4f5155ab;
    private readonly EntityInsertionAdapter F5d8fbb1a;
    private readonly EntityInsertionAdapter F6345296f;
    private readonly EntityDeletionOrUpdateAdapter F6528ea93;
    private readonly SharedSQLiteStatement F71d073ea;
    private readonly EntityInsertionAdapter F77d74cbf;
    private readonly SharedSQLiteStatement F79f2c4dc;
    private readonly SharedSQLiteStatement F84b12d30;
    private readonly EntityInsertionAdapter F8563cd84;
    private readonly EntityInsertionAdapter F91c3cb4b;
    private readonly EntityDeletionOrUpdateAdapter F91eba26a;
    private readonly SharedSQLiteStatement F925f3435;
    private readonly p35667ee1 F9982f3cc;
    private readonly EntityInsertionAdapter F9b75de36;
    private readonly EntityInsertionAdapter Fa7a9762c;
    private readonly RoomDatabase Fa8bf39ac;
    private readonly p35667ee1 Fa92cb57a;
    private readonly EntityInsertionAdapter Fb58a503c;
    private readonly SharedSQLiteStatement Fb5f0bbde;
    private readonly p297c1c27 Fb8317a4c;
    private readonly EntityInsertionAdapter Fb87e65fa;
    private readonly EntityDeletionOrUpdateAdapter Fc2aaf784;
    private readonly p35667ee1 Fcc2c22d4;
    private readonly SharedSQLiteStatement Fcd61bd38;
    private readonly SharedSQLiteStatement Fd257e865;
    private readonly SharedSQLiteStatement Fd2d4784d;
    private readonly p297c1c27 Fd7c409df;
    private readonly EntityInsertionAdapter Fdfc4bf89;
    private readonly EntityInsertionAdapter Fe05aee6f;
    private readonly p297c1c27 Fe7b35187;
    private readonly EntityInsertionAdapter Ff0660cce;
    private readonly SharedSQLiteStatement Ff2513c7d;
    private readonly EntityInsertionAdapter Ff75834ee;
    private readonly SharedSQLiteStatement Ffb15ef43;
    private readonly EntityDeletionOrUpdateAdapter Ffe5edf24;

    private void M08f17002(ArrayMap P0)
    {
        // str: "SELECT `code`,`rate`,`type`,`subType`,`engName`,`arabName` FROM `tax` WHERE `code` IN ("
        // str: ")"
        // str: "code"
        // call: RoomSQLiteQuery.bindString
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: RelationUtil.recursiveFetchArrayMap
        // call: ArrayMap.size
        // call: Cursor.moveToNext
        // call: Cursor.getString
        // call: ArrayMap.containsKey
        // call: Cursor.isNull
        // call: pf22d65ed.<init>
        // call: ArrayMap.put
        // call: Cursor.close
        // call: HashSet<object>.iterator
        // call: StringUtil.newStringBuilder
        // call: IEnumerator<object>.hasNext
        // call: p20e4401d$pd41d8cd9$p144e4630.<init>
        // call: HashSet<object>.isEmpty
        // call: RoomSQLiteQuery.acquire
        // call: IEnumerator<object>.next
        // call: DBUtil.query
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$pd41d8cd9$p144e4630
        // type: pf22d65ed
    }

    private static EntityInsertionAdapter M0dc0a6ea(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fa7a9762c
        return default!;
    }

    private static EntityInsertionAdapter M13fe7af4(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.ff75834ee
        return default!;
    }

    private static SharedSQLiteStatement M1740fbc7(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.f4f5155ab
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter M2a096755(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fc2aaf784
        return default!;
    }

    private static string M337ceba5(p20e4401d P0, p22820a6f P1)
    {
        // call: p20e4401d.mad627590
        return string.Empty;
    }

    private p8c261c90 M379cd0f0(string P0)
    {
        // str: "QR_PAY"
        // str: "TAP_ON_PHONE"
        // str: "Can't convert value to enum, unknown value: "
        // str: "COMBO_PAY"
        // str: "CASH"
        // call: string.equals
        // call: string.hashCode
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9cb40e51
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.faf50f824
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static p8c261c90 M406f4166(p20e4401d P0, string P1)
    {
        // call: p20e4401d.m379cd0f0
        return default!;
    }

    private static RoomDatabase M429f062d(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        return default!;
    }

    private static p22820a6f M53786ceb(p20e4401d P0, string P1)
    {
        // call: p20e4401d.mf67b7e72
        return default!;
    }

    private static void M59c413ba(p20e4401d P0, ArrayMap P1)
    {
        // call: p20e4401d.m08f17002
    }

    private static EntityDeletionOrUpdateAdapter M5e49d338(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.f2218c5a2
        return default!;
    }

    private static string M5ec06fdf(p20e4401d P0, p8c261c90 P1)
    {
        // call: p20e4401d.mc45dd9be
        return string.Empty;
    }

    private static SharedSQLiteStatement M649493cb(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fd257e865
        return default!;
    }

    private string M6807eda8(pa1fa2777 P0)
    {
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "SERVICE"
        // str: "NORMAL"
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: pa1fa2777.ordinal
        // call: StringBuilder.toString
        // field: p4670093c.pf0719ea8.p20e4401d$28.$SwitchMap$domain$entities$inventory$Type
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    private static EntityInsertionAdapter M74674bbd(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.f5d8fbb1a
        return default!;
    }

    private static pa1fa2777 M74faefcd(p20e4401d P0, string P1)
    {
        // call: p20e4401d.m914269ef
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter M83fd488e(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.f18732a7f
        return default!;
    }

    private static p297c1c27 M89082e03(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fb8317a4c
        return default!;
    }

    private string M8de5dda9(p5a409c20 P0)
    {
        // str: "PAYBACK"
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "INVENTORY"
        // str: "REVALUATION"
        // str: "SELL"
        // str: "ACCEPT"
        // call: p5a409c20.ordinal
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: p4670093c.pf0719ea8.p20e4401d$28.$SwitchMap$domain$entities$receipt$OperationType
        // type: IllegalArgumentException
        // type: StringBuilder
        return string.Empty;
    }

    private pa1fa2777 M914269ef(string P0)
    {
        // str: "NORMAL"
        // str: "SERVICE"
        // str: "Can't convert value to enum, unknown value: "
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: string.equals
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: string.hashCode
        // field: pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.ff9e81a74
        // field: pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.f1e238528
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private p5a409c20 M96a818e5(string P0)
    {
        return default!;
    }

    private static SharedSQLiteStatement Ma5940f5e(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fd2d4784d
        return default!;
    }

    private string Mad627590(p22820a6f P0)
    {
        // str: "ADVANCE"
        // str: "db0bbf9c1695dc4afac08081e7e4c288c32333354c190711c90184523a1e91b3e712f87dbee534"
        // str: "RECEIPT"
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "WITHOUT_RECEIPT"
        // call: p22820a6f.ordinal
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p4670093c.pf0719ea8.p20e4401d$28.$SwitchMap$domain$entities$receipt$ReceiptType
        // type: IllegalArgumentException
        // type: StringBuilder
        return string.Empty;
    }

    public static List<object> Mb3fda515()
    {
        // call: Collections.emptyList
        return default!;
    }

    private static string Mbbeb9b46(p20e4401d P0, p5a409c20 P1)
    {
        // call: p20e4401d.m8de5dda9
        return string.Empty;
    }

    private string Mc45dd9be(p8c261c90 P0)
    {
        // str: "COMBO_PAY"
        // str: "TAP_ON_PHONE"
        // str: "QR_PAY"
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "CASH"
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: p8c261c90.ordinal
        // call: StringBuilder.<init>
        // field: p4670093c.pf0719ea8.p20e4401d$28.$SwitchMap$domain$entities$receipt$PaymentType
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    private static SharedSQLiteStatement Mc7321d99(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.f2b8bc11d
        return default!;
    }

    private static SharedSQLiteStatement Mcdc7972c(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fcd61bd38
        return default!;
    }

    private static EntityInsertionAdapter Mebdbf394(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fe05aee6f
        return default!;
    }

    private static p35667ee1 Mf23e8626(p20e4401d P0)
    {
        // field: p4670093c.pf0719ea8.p20e4401d.fa92cb57a
        return default!;
    }

    private p22820a6f Mf67b7e72(string P0)
    {
        // str: "WITHOUT_RECEIPT"
        // str: "Can't convert value to enum, unknown value: "
        // str: "ed0b38b985b29b6a48eb6a65de3a9498ea37580ded4afa82594644bfb40af908ddfd53c94d9c90"
        // str: "RECEIPT"
        // str: "ADVANCE"
        // call: string.hashCode
        // call: string.equals
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.fcc52554c
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f480d47bf
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f0267fe7f
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f52c9932e
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    private static string Mf8f67da7(p20e4401d P0, pa1fa2777 P1)
    {
        // call: p20e4401d.m6807eda8
        return string.Empty;
    }

    private static p5a409c20 Mff218fba(p20e4401d P0, string P1)
    {
        // call: p20e4401d.m96a818e5
        return default!;
    }

    public object ClearCurrentPaybackPayments(object P0)
    {
        // call: p20e4401d$24.<init>
        // call: CoroutinesRoom.execute
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$24
        return default!;
    }

    public object ClearCurrentPaybackPositions(object P0)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$20.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$20
        return default!;
    }

    public object ClearCurrentPaybackReceipts(object P0)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$21.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$21
        return default!;
    }

    public object CreateCurrentPaybackReceipt(pe39a6d57 P0, List<object> P1, object P2)
    {
        // call: p20e4401d$pd41d8cd9$p95263d50.<init>
        // call: RoomDatabaseKt.withTransaction
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$pd41d8cd9$p95263d50
        return default!;
    }

    public object CreateSinglePayment(p0fc46d65 P0, object P1)
    {
        // call: RoomDatabaseKt.withTransaction
        // call: p20e4401d$pd41d8cd9$p437e9676.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$pd41d8cd9$p437e9676
        return default!;
    }

    public object DeleteCurrentPaybackPayment(string P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$23.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$23
        return default!;
    }

    public object GetCurrentPaybackPayments(object P0)
    {
        // str: "SELECT * FROM current_payback_payment WHERE receiptUuid = (SELECT receiptUuid FROM current_paybac..."
        // call: DBUtil.createCancellationSignal
        // call: p20e4401d$27.<init>
        // call: RoomSQLiteQuery.acquire
        // call: CoroutinesRoom.execute
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$27
        return default!;
    }

    public object GetCurrentPaybackPositions(object P0)
    {
        // str: "SELECT * FROM current_payback_position WHERE receiptUuid = (SELECT receiptUuid FROM current_payba..."
        // call: CoroutinesRoom.execute
        // call: DBUtil.createCancellationSignal
        // call: p20e4401d$25.<init>
        // call: RoomSQLiteQuery.acquire
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$25
        return default!;
    }

    public object GetCurrentPaybackReceipt(string P0, object P1)
    {
        // str: "SELECT * FROM current_payback_receipt WHERE deviceId = ? and isSelected = 1"
        // call: RoomSQLiteQuery.acquire
        // call: DBUtil.createCancellationSignal
        // call: CoroutinesRoom.execute
        // call: RoomSQLiteQuery.bindString
        // call: p20e4401d$26.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$26
        return default!;
    }

    public object InsertPayment(p0fc46d65 P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$15.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$15
        return default!;
    }

    public object InsertPayments(List<object> P0, object P1)
    {
        // call: p20e4401d$16.<init>
        // call: CoroutinesRoom.execute
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$16
        return default!;
    }

    public object InsertPositions(List<object> P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$13.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$13
        return default!;
    }

    public object InsertReceipt(pe39a6d57 P0, object P1)
    {
        // call: p20e4401d$14.<init>
        // call: CoroutinesRoom.execute
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$14
        return default!;
    }

    private void Lambda$__fetchRelationshiptaxAsdomainEntitiesDbTaxDbEntity$3$payback-dao-CurrentPaybackReceiptDao_Impl(ArrayMap P0)
    {
        // call: p20e4401d.m08f17002
        // field: kotlin.Unit.INSTANCE
    }

    private object Lambda$createCurrentPaybackReceipt$1$payback-dao-CurrentPaybackReceiptDao_Impl(pe39a6d57 P0, List<object> P1, object P2)
    {
        // call: p71d96ecc$pb0da8397.m19e83fc5
        return default!;
    }

    private object Lambda$createSinglePayment$2$payback-dao-CurrentPaybackReceiptDao_Impl(p0fc46d65 P0, object P1)
    {
        // call: p71d96ecc$pb0da8397.mf41603b1
        return default!;
    }

    private object Lambda$updatePositions$0$payback-dao-CurrentPaybackReceiptDao_Impl(List<object> P0, object P1)
    {
        // call: p71d96ecc$pb0da8397.m1c83b96a
        return default!;
    }

    public object RemoveCurrentReceipt(pe39a6d57 P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$17.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$17
        return default!;
    }

    public object UpdateCurrentPaybackReceipt(pe39a6d57 P0, object P1)
    {
        // call: p20e4401d$19.<init>
        // call: CoroutinesRoom.execute
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$19
        return default!;
    }

    public object UpdatePaymentTransaction(string P0, string P1, string P2, string P3, string P4, string P5, string P6, string P7, object P8)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$22.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$22
        return default!;
    }

    public object UpdatePosition(pb1f8808e P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p20e4401d$18.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$18
        return default!;
    }

    public object UpdatePositions(List<object> P0, object P1)
    {
        // call: RoomDatabaseKt.withTransaction
        // call: p20e4401d$pd41d8cd9$pcca4ef0e.<init>
        // field: p4670093c.pf0719ea8.p20e4401d.fa8bf39ac
        // type: p20e4401d$pd41d8cd9$pcca4ef0e
        return default!;
    }

}
