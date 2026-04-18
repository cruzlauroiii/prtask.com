namespace WillowMaze.Wasm.Decompiled;


class p9785642f$14 : androidx.room.SharedSQLiteStatement {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$14(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    public override java.lang.string CreateQuery() {
        return "\n            UPDATE current_sell_payment\n            SET\n                transaction_rrn = ?,\n                transaction_stan = ?,\n                transaction_authCode = ?,\n                transaction_responseCode = ?,\n                transaction_topRefUuid = ?,\n                transaction_terminalId = ?,\n                transaction_merchantId = ?\n            WHERE uuid = ?\n        ";
    }
}

