namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$10 : androidx.room.SharedSQLiteStatement {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$10(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    public override java.lang.string CreateQuery() {
        return "\n            UPDATE current_payback_payment\n            SET\n                transaction_rrn = ?,\n                transaction_stan = ?,\n                transaction_authCode = ?,\n                transaction_responseCode = ?,\n                transaction_topRefUuid = ?,\n                transaction_terminalId = ?,\n                transaction_merchantId = ?\n            WHERE uuid = ?\n        ";
    }
}

