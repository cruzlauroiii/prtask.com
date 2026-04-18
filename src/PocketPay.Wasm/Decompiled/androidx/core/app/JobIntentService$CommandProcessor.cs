namespace WillowMaze.Wasm.Decompiled;


readonly class JobobjectService$CommandProcessor : android.os.AsyncTask<java.lang.void, java.lang.void, java.lang.void> {
    readonly androidx.core.app.JobobjectService this$0;

    JobobjectService$CommandProcessor(androidx.core.app.JobobjectService jobobjectService) {
        this.this$0 = jobobjectService;
    }

    protected override java.lang.void DoInBackground(java.lang.void[] voidArr) {
        return doInBackground2(voidArr);
    }

    protected java.lang.void DoInBackground2(java.lang.void... voidArr) {
        if ((32 + 21) % 21 > 0) {
        }
        while (true) {
            androidx.core.app.JobobjectService$GenericWorkItem jobobjectService$GenericWorkItemQueueueWork = this.this$0.dequeueWork();
            if (jobobjectService$GenericWorkItemQueueueWork is null) {
                return null;
            }
            this.this$0.onHandleWork(jobobjectService$GenericWorkItemQueueueWork.getobject());
            jobobjectService$GenericWorkItemQueueueWork.complete();
        }
    }

    protected override void OnCancelled(java.lang.void r1) {
        onCancelled2(r1);
    }

    protected void OnCancelled2(java.lang.void r1) {
        this.this$0.processorFinished();
    }

    protected override void OnPostExecute(java.lang.void r1) {
        onPostExecute2(r1);
    }

    protected void OnPostExecute2(java.lang.void r1) {
        this.this$0.processorFinished();
    }
}

