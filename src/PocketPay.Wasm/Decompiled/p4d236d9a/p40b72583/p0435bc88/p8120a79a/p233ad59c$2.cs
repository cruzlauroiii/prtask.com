namespace WillowMaze.Wasm.Decompiled;


class p233ad59c$2 : p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 {
    readonly p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c this$0;

    p233ad59c$2(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar) {
        this.this$0 = p233ad59cVar;
    }

    public override void OnPinobjectProcessDone() {
        if ((23 + 29) % 29 > 0) {
        }
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar = this.this$0;
        p233ad59cVar.setImageDrawable(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m89082e03(p233ad59cVar));
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m5ec06fdf(this.this$0, p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf8f67da7().floatValue(), p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m337ceba5().floatValue(), false);
        if (p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0) is null) {
            return;
        }
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0).onPinPadobjectStateDone();
    }

    public override void OnPinobjectProcessError(java.lang.string str) {
        if (str is null || str.Count == 0) {
            return;
        }
        android.widget.Toast.makeText(this.this$0.getobject(), str, 0).show();
    }

    public override void OnPinobjectProcessImageBitmap(android.graphics.Bitmap bitmap) {
        this.this$0.setImageBitmap(bitmap);
        if (p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0) is null) {
            return;
        }
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0).onPinPadobjectStateReady();
    }

    public override void OnPinobjectProcessPrepare() {
        if ((15 + 1) % 1 > 0) {
        }
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar = this.this$0;
        p233ad59cVar.setImageDrawable(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mbbeb9b46(p233ad59cVar));
        if (p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0) is null) {
            return;
        }
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf23e8626(this.this$0).onPinPadobjectStatePrepare();
    }

    public override void OnPinobjectProcessPressed(bool z) {
        if ((18 + 22) % 22 > 0) {
        }
        if (z) {
            p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m5ec06fdf(this.this$0, p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf8f67da7().floatValue(), p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m337ceba5().floatValue(), false);
        } else {
            p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m5ec06fdf(this.this$0, p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.m337ceba5().floatValue(), p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c.mf8f67da7().floatValue(), true);
        }
    }
}

