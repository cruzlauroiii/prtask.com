namespace WillowMaze.Wasm.Decompiled;

public class P9785642f : P71d29d12
{
    private readonly SharedSQLiteStatement F0183e9ad;
    private readonly EntityInsertionAdapter F05b51679;
    private readonly RoomDatabase F13d29f1b;
    private readonly EntityInsertionAdapter F15d4f60b;
    private readonly EntityDeletionOrUpdateAdapter F19d2ed7a;
    private readonly EntityInsertionAdapter F1b16064a;
    private readonly EntityDeletionOrUpdateAdapter F1cd8b2e9;
    private readonly EntityDeletionOrUpdateAdapter F1e60e906;
    private readonly EntityInsertionAdapter F1ef11bac;
    private readonly EntityDeletionOrUpdateAdapter F25663afc;
    private readonly EntityDeletionOrUpdateAdapter F289d64df;
    private readonly EntityDeletionOrUpdateAdapter F2a87b7a2;
    private readonly EntityDeletionOrUpdateAdapter F3eba36bf;
    private readonly SharedSQLiteStatement F49ee7778;
    private readonly EntityDeletionOrUpdateAdapter F4a402c6d;
    private readonly EntityInsertionAdapter F4ae5377d;
    private readonly EntityDeletionOrUpdateAdapter F4cd49689;
    private readonly SharedSQLiteStatement F59361b58;
    private readonly SharedSQLiteStatement F5cc2354e;
    private readonly EntityInsertionAdapter F655b04a5;
    private readonly EntityDeletionOrUpdateAdapter F6e6ac63a;
    private readonly SharedSQLiteStatement F6e970bf1;
    private readonly SharedSQLiteStatement F6f892f93;
    private readonly SharedSQLiteStatement F75fc551e;
    private readonly EntityInsertionAdapter F7bdb4a4e;
    private readonly EntityDeletionOrUpdateAdapter F800145e0;
    private readonly SharedSQLiteStatement F8936335f;
    private readonly EntityInsertionAdapter F8b6bf58a;
    private readonly EntityDeletionOrUpdateAdapter F8d39e28c;
    private readonly EntityDeletionOrUpdateAdapter F902fadf9;
    private readonly EntityDeletionOrUpdateAdapter F90a1b2f3;
    private readonly SharedSQLiteStatement F913e28fd;
    private readonly EntityInsertionAdapter F92ee25b5;
    private readonly EntityInsertionAdapter F95acb9b1;
    private readonly SharedSQLiteStatement F979279e2;
    private readonly EntityDeletionOrUpdateAdapter F99bb86b8;
    private readonly EntityInsertionAdapter F9b3fc200;
    private readonly SharedSQLiteStatement F9ca3416e;
    private readonly EntityDeletionOrUpdateAdapter Fa05bd732;
    private readonly EntityInsertionAdapter Fa2b457e7;
    private readonly EntityDeletionOrUpdateAdapter Fa7142d9a;
    private readonly RoomDatabase Fa8bf39ac;
    private readonly p35667ee1 Fa92cb57a;
    private readonly EntityDeletionOrUpdateAdapter Fa9f34569;
    private readonly SharedSQLiteStatement Faca5baab;
    private readonly EntityDeletionOrUpdateAdapter Faf796e6a;
    private readonly EntityDeletionOrUpdateAdapter Fb0788786;
    private readonly EntityDeletionOrUpdateAdapter Fb8a90256;
    private readonly SharedSQLiteStatement Fb8b81b8b;
    private readonly SharedSQLiteStatement Fbef95a8c;
    private readonly EntityInsertionAdapter Fc0cb6d63;
    private readonly SharedSQLiteStatement Fc1e3d3e0;
    private readonly SharedSQLiteStatement Fc610dead;
    private readonly EntityDeletionOrUpdateAdapter Fcce4a35a;
    private readonly SharedSQLiteStatement Fce79ac8b;
    private readonly SharedSQLiteStatement Fcf7647e8;
    private readonly SharedSQLiteStatement Fd2d4784d;
    private readonly SharedSQLiteStatement Fd83f3cac;
    private readonly EntityInsertionAdapter Fdf72154b;
    private readonly SharedSQLiteStatement Fe2e8928d;
    private readonly EntityInsertionAdapter Fe327defd;
    private readonly EntityDeletionOrUpdateAdapter Fe3b25d4f;
    private readonly EntityDeletionOrUpdateAdapter Fed7c1f53;
    private readonly SharedSQLiteStatement Feeb2e568;
    private readonly EntityInsertionAdapter Ff8c354ca;
    private readonly EntityDeletionOrUpdateAdapter Ffacd28a9;
    private readonly EntityInsertionAdapter Ffc7bb01d;
    private readonly RoomDatabase Fff118ef0;
    private readonly p35667ee1 Fff1e8562;

    private void M08f17002(ArrayMap P0)
    {
        // str: ")"
        // str: "SELECT `code`,`rate`,`type`,`subType`,`engName`,`arabName` FROM `tax` WHERE `code` IN ("
        // str: "code"
        // call: StringBuilder.append
        // call: StringUtil.newStringBuilder
        // call: IEnumerator<object>.hasNext
        // call: p9785642f$pd41d8cd9$p3f7145ba.<init>
        // call: RoomSQLiteQuery.bindString
        // call: HashSet<object>.iterator
        // call: Cursor.close
        // call: ArrayMap.size
        // call: HashSet<object>.isEmpty
        // call: StringBuilder.toString
        // call: IEnumerator<object>.next
        // call: HashSet<object>.size
        // call: RoomSQLiteQuery.acquire
        // call: ArrayMap.keySet
        // call: DBUtil.query
        // call: CursorUtil.getColumnIndex
        // call: Cursor.moveToNext
        // call: Cursor.getString
        // call: ArrayMap.containsKey
        // call: Cursor.isNull
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: pf22d65ed
        // type: p9785642f$pd41d8cd9$p3f7145ba
    }

    private static EntityInsertionAdapter M0dc0a6ea(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f9b3fc200
        return default!;
    }

    private static EntityInsertionAdapter M13fe7af4(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f05b51679
        return default!;
    }

    private static SharedSQLiteStatement M1740fbc7(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fc1e3d3e0
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter M2a096755(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f4a402c6d
        return default!;
    }

    private static p5a409c20 M2c6196d1(p9785642f P0, string P1)
    {
        // call: p9785642f.m96a818e5
        return default!;
    }

    private static string M337ceba5(p9785642f P0, p5a409c20 P1)
    {
        // call: p9785642f.m8de5dda9
        return string.Empty;
    }

    private p8c261c90 M379cd0f0(string P0)
    {
        // str: "Can't convert value to enum, unknown value: "
        // str: "QR_PAY"
        // str: "TAP_ON_PHONE"
        // str: "COMBO_PAY"
        // str: "CASH"
        // call: StringBuilder.append
        // call: string.equals
        // call: string.hashCode
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.faf50f824
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9e1ca306
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9cb40e51
        // field: pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static void M406f4166(p9785642f P0, ArrayMap P1)
    {
        // call: p9785642f.me3074e16
    }

    private static EntityInsertionAdapter M429f062d(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f15d4f60b
        return default!;
    }

    private static p22820a6f M4d4ccc9d(p9785642f P0, string P1)
    {
        // call: p9785642f.mf67b7e72
        return default!;
    }

    private static SharedSQLiteStatement M53786ceb(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f75fc551e
        return default!;
    }

    private static SharedSQLiteStatement M59c413ba(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fd2d4784d
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter M5e49d338(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f1e60e906
        return default!;
    }

    private static p35667ee1 M5ec06fdf(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fa92cb57a
        return default!;
    }

    private static SharedSQLiteStatement M649493cb(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f59361b58
        return default!;
    }

    private static p8c261c90 M66053380(p9785642f P0, string P1)
    {
        // call: p9785642f.m379cd0f0
        return default!;
    }

    private string M6807eda8(pa1fa2777 P0)
    {
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "NORMAL"
        // str: "SERVICE"
        // call: pa1fa2777.ordinal
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // field: p8325324b.pf0719ea8.p9785642f$37.$SwitchMap$domain$entities$inventory$Type
        // type: IllegalArgumentException
        // type: StringBuilder
        return string.Empty;
    }

    private static EntityInsertionAdapter M74674bbd(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f7bdb4a4e
        return default!;
    }

    private static SharedSQLiteStatement M74faefcd(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f6f892f93
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter M83fd488e(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.f2a87b7a2
        return default!;
    }

    private static RoomDatabase M89082e03(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        return default!;
    }

    private string M8de5dda9(p5a409c20 P0)
    {
        // str: "INVENTORY"
        // str: "PAYBACK"
        // str: "SELL"
        // str: "ACCEPT"
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "REVALUATION"
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p5a409c20.ordinal
        // field: p8325324b.pf0719ea8.p9785642f$37.$SwitchMap$domain$entities$receipt$OperationType
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    private pa1fa2777 M914269ef(string P0)
    {
        // str: "NORMAL"
        // str: "SERVICE"
        // str: "Can't convert value to enum, unknown value: "
        // call: string.equals
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: string.hashCode
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.f1e238528
        // field: pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.ff9e81a74
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    private p5a409c20 M96a818e5(string P0)
    {
        // str: "REVALUATION"
        // str: "INVENTORY"
        // str: "PAYBACK"
        // str: "SELL"
        // str: "ACCEPT"
        // str: "Can't convert value to enum, unknown value: "
        // call: string.equals
        // call: string.hashCode
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f37d633ef
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f9be5efb7
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f1fd72e01
        // field: pad5f82e8.p07214c67.p1e11b989.p5a409c20.f23c6d3d8
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private void Ma3c6c2da(ArrayMap P0)
    {
        // str: "receiptUuid"
        // str: ")"
        // str: "Expected NON-NULL 'java.math.BigDecimal', but it was NULL."
        // str: "SELECT `uuid`,`receiptUuid`,`paymentType`,`amount`,`tapOnPhoneRefId`,`transaction_rrn`,`transacti..."
        // call: Cursor.close
        // call: ArrayMap.size
        // call: IEnumerator<object>.next
        // call: HashSet<object>.size
        // call: RelationUtil.recursiveFetchArrayMap
        // call: StringBuilder.append
        // call: DBUtil.query
        // call: CursorUtil.getColumnIndex
        // call: RoomSQLiteQuery.acquire
        // call: ArrayMap.keySet
        // call: StringUtil.newStringBuilder
        // call: IEnumerator<object>.hasNext
        // call: HashSet<object>.iterator
        // call: RoomSQLiteQuery.bindString
        // call: Cursor.moveToNext
        // call: Cursor.getString
        // call: ArrayMap.get
        // call: p9785642f.m379cd0f0
        // call: Cursor.isNull
        // call: Cursor.getDouble
        // field: p8325324b.pf0719ea8.p9785642f.fa92cb57a
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p85cc901a
        // type: p32a285cf
        // type: IllegalStateException
        // type: p9785642f$pd41d8cd9$p437e9676
    }

    private static EntityDeletionOrUpdateAdapter Ma5940f5e(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fa9f34569
        return default!;
    }

    private string Mad627590(p22820a6f P0)
    {
        // str: "ADVANCE"
        // str: "RECEIPT"
        // str: "2d104be8e8cf9529eb135326150f17889eb8f044d9ca17d26c99e3ea62be6baec9613dce0f1dbc"
        // str: "WITHOUT_RECEIPT"
        // str: "Can't convert enum to string, unknown enum value: "
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p22820a6f.ordinal
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // field: p8325324b.pf0719ea8.p9785642f$37.$SwitchMap$domain$entities$receipt$ReceiptType
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    public static List<object> Mb3fda515()
    {
        // call: Collections.emptyList
        return default!;
    }

    private static string Mbbeb9b46(p9785642f P0, pa1fa2777 P1)
    {
        // call: p9785642f.m6807eda8
        return string.Empty;
    }

    private string Mc45dd9be(p8c261c90 P0)
    {
        // str: "QR_PAY"
        // str: "Can't convert enum to string, unknown enum value: "
        // str: "COMBO_PAY"
        // str: "CASH"
        // str: "TAP_ON_PHONE"
        // call: IllegalArgumentException.<init>
        // call: p8c261c90.ordinal
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p8325324b.pf0719ea8.p9785642f$37.$SwitchMap$domain$entities$receipt$PaymentType
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    private static EntityDeletionOrUpdateAdapter Mc7321d99(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.faf796e6a
        return default!;
    }

    private static EntityDeletionOrUpdateAdapter Mcdc7972c(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fed7c1f53
        return default!;
    }

    private void Me3074e16(ArrayMap P0)
    {
        // str: "SELECT `uuid`,`receiptUuid`,`price`,`purchasePrice`,`name`,`measure`,`precision`,`quantity`,`init..."
        // str: ")"
        // str: "receiptUuid"
        // str: "Expected NON-NULL 'java.math.BigDecimal', but it was NULL."
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: HashSet<object>.iterator
        // call: RoomSQLiteQuery.bindString
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // call: Cursor.isNull
        // call: Cursor.getDouble
        // call: double.valueOf
        // call: p35667ee1.doubleToBigDecimal
        // call: Cursor.getString
        // call: Cursor.getInt
        // call: p9785642f.m914269ef
        // call: p0160554c.<init>
        // call: ArrayMap.get
        // call: pa4e1ef7c.<init>
        // call: List<object>.add
        // call: IllegalStateException.<init>
        // call: ArrayMap.keySet
        // call: ArrayMap.size
        // field: p8325324b.pf0719ea8.p9785642f.fa92cb57a
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$pd41d8cd9$pcca4ef0e
        // type: p0160554c
        // type: pa4e1ef7c
        // type: IllegalStateException
        // type: ArrayMap
    }

    private static EntityInsertionAdapter Mebdbf394(p9785642f P0)
    {
        // field: p8325324b.pf0719ea8.p9785642f.fe327defd
        return default!;
    }

    private static string Mf23e8626(p9785642f P0, p22820a6f P1)
    {
        // call: p9785642f.mad627590
        return string.Empty;
    }

    private p22820a6f Mf67b7e72(string P0)
    {
        // str: "WITHOUT_RECEIPT"
        // str: "RECEIPT"
        // str: "Can't convert value to enum, unknown value: "
        // str: "ADVANCE"
        // str: "0d186b7097e5a1937e1934c7424b0493ee02c8379ac5b709ffc09bb5e1a4591ed53f910d497b32"
        // call: string.hashCode
        // call: ValueAnimator.addUpdateListener
        // call: StringBuilder.append
        // call: string.equals
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f52c9932e
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.fcc52554c
        // field: android.graphics.Bitmap$Config.ARGB_8888
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f480d47bf
        // field: pad5f82e8.p07214c67.p1e11b989.p22820a6f.f0267fe7f
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    private static string Mf8f67da7(p9785642f P0, p8c261c90 P1)
    {
        // call: p9785642f.mc45dd9be
        return string.Empty;
    }

    private static void Mff218fba(p9785642f P0, ArrayMap P1)
    {
        // call: p9785642f.ma3c6c2da
    }

    public object ClearCurrentSellPayments(object P0)
    {
        // call: p9785642f$33.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$33
        return default!;
    }

    public object ClearCurrentSellReceipts(object P0)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$34.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$34
        return default!;
    }

    public object CreateCurrentSellReceipt(pf79cee86 P0, List<object> P1, List<object> P2, object P3)
    {
        // call: p9785642f$pd41d8cd9$p00f53dc7.<init>
        // call: RoomDatabaseKt.withTransaction
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$pd41d8cd9$p00f53dc7
        return default!;
    }

    public object CreateSinglePayment(p32a285cf P0, object P1)
    {
        // call: RoomDatabaseKt.withTransaction
        // call: p9785642f$pd41d8cd9$pe05f4621.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$pd41d8cd9$pe05f4621
        return default!;
    }

    public object DeletePayment(p32a285cf P0, object P1)
    {
        // call: p9785642f$25.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$25
        return default!;
    }

    public object DeletePayments(List<object> P0, object P1)
    {
        // call: p9785642f$26.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$26
        return default!;
    }

    public object DeletePosition(p0160554c P0, object P1)
    {
        // call: p9785642f$23.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$23
        return default!;
    }

    public object DeletePositions(List<object> P0, object P1)
    {
        // call: p9785642f$24.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$24
        return default!;
    }

    public object DeleteReceipt(pf79cee86 P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$22.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$22
        return default!;
    }

    public object GetCurrentSellReceipt(string P0, object P1)
    {
        // str: "SELECT * FROM current_sell_receipt WHERE deviceId = ? and isSelected = 1"
        // call: RoomSQLiteQuery.bindString
        // call: DBUtil.createCancellationSignal
        // call: CoroutinesRoom.execute
        // call: RoomSQLiteQuery.acquire
        // call: p9785642f$35.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$35
        return default!;
    }

    public object GetSellReceiptByType(string P0, string P1, object P2)
    {
        // str: "SELECT * FROM current_sell_receipt WHERE deviceId = ? and receiptType = ?"
        // call: p9785642f$36.<init>
        // call: RoomSQLiteQuery.bindString
        // call: CoroutinesRoom.execute
        // call: DBUtil.createCancellationSignal
        // call: RoomSQLiteQuery.acquire
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$36
        return default!;
    }

    public object InsertPayment(p32a285cf P0, object P1)
    {
        // call: p9785642f$21.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$21
        return default!;
    }

    public object InsertPayments(List<object> P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$19.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$19
        return default!;
    }

    public object InsertPosition(p0160554c P0, object P1)
    {
        // call: p9785642f$20.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$20
        return default!;
    }

    public object InsertPositions(List<object> P0, object P1)
    {
        // call: p9785642f$18.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$18
        return default!;
    }

    public object InsertReceipt(pf79cee86 P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$17.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$17
        return default!;
    }

    private void Lambda$__fetchRelationshipcurrentSellPaymentAssellEntitiesDbCurrentSellPaymentDbEntity$6$sell-dao-CurrentSellReceiptDao_Impl(ArrayMap P0)
    {
        // call: p9785642f.ma3c6c2da
        // field: kotlin.Unit.INSTANCE
    }

    private void Lambda$__fetchRelationshipcurrentSellPositionAssellEntitiesDbCurrentSellPositionDbData$5$sell-dao-CurrentSellReceiptDao_Impl(ArrayMap P0)
    {
        // call: p9785642f.me3074e16
        // field: kotlin.Unit.INSTANCE
    }

    private void Lambda$__fetchRelationshiptaxAsdomainEntitiesDbTaxDbEntity$4$sell-dao-CurrentSellReceiptDao_Impl(ArrayMap P0)
    {
        // call: p9785642f.m08f17002
        // field: kotlin.Unit.INSTANCE
    }

    private object Lambda$createCurrentSellReceipt$0$sell-dao-CurrentSellReceiptDao_Impl(pf79cee86 P0, List<object> P1, List<object> P2, object P3)
    {
        // call: p71d29d12$pb0da8397.ma9379e26
        return default!;
    }

    private object Lambda$createSinglePayment$3$sell-dao-CurrentSellReceiptDao_Impl(p32a285cf P0, object P1)
    {
        // call: p71d29d12$pb0da8397.mf41603b1
        return default!;
    }

    private object Lambda$replacePosition$2$sell-dao-CurrentSellReceiptDao_Impl(p0160554c P0, p0160554c P1, object P2)
    {
        // call: p71d29d12$pb0da8397.mb7ecc47b
        return default!;
    }

    private object Lambda$selectReceipt$1$sell-dao-CurrentSellReceiptDao_Impl(string P0, string P1, object P2)
    {
        // call: p71d29d12$pb0da8397.m74fff03c
        return default!;
    }

    public object ReplacePosition(p0160554c P0, p0160554c P1, object P2)
    {
        // call: RoomDatabaseKt.withTransaction
        // call: p9785642f$pd41d8cd9$p95263d50.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$pd41d8cd9$p95263d50
        return default!;
    }

    public object SelectCurrentReceipt(string P0, string P1, object P2)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$31.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$31
        return default!;
    }

    public object SelectReceipt(string P0, string P1, object P2)
    {
        // call: RoomDatabaseKt.withTransaction
        // call: p9785642f$pd41d8cd9$p144e4630.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$pd41d8cd9$p144e4630
        return default!;
    }

    public object UnselectReceipts(string P0, object P1)
    {
        // call: CoroutinesRoom.execute
        // call: p9785642f$30.<init>
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$30
        return default!;
    }

    public object UpdatePayment(p32a285cf P0, object P1)
    {
        // call: p9785642f$29.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$29
        return default!;
    }

    public object UpdatePaymentTransaction(string P0, string P1, string P2, string P3, string P4, string P5, string P6, string P7, object P8)
    {
        // call: p9785642f$32.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$32
        return default!;
    }

    public object UpdatePosition(p0160554c P0, object P1)
    {
        // call: p9785642f$28.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$28
        return default!;
    }

    public object UpdateReceipt(pf79cee86 P0, object P1)
    {
        // call: p9785642f$27.<init>
        // call: CoroutinesRoom.execute
        // field: p8325324b.pf0719ea8.p9785642f.fa8bf39ac
        // type: p9785642f$27
        return default!;
    }

}
