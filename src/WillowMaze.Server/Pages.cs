namespace WillowMaze.Server;

internal static class Pages
{
    public static string PaymentHtml() => PaymentTemplate.Replace("/*CSS*/", Css).Replace("/*COMMONJS*/", CommonJs);
    public static string NfcHtml() => NfcTemplate.Replace("/*CSS*/", Css).Replace("/*COMMONJS*/", CommonJs);

    private const string Css = @"
:root{color-scheme:dark;--bg:#0f1722;--card:#172334;--line:rgba(255,255,255,.08);--mint:#8cffd7;--rose:#ff8fb0;--gold:#ffd36e;--blue:#67d7ff;--text:#edf6ff;--muted:#a6bbcf;--green:#4ade80;--orange:#fb923c;--red:#f87171}
*{margin:0;box-sizing:border-box}body{font-family:system-ui,sans-serif;background:var(--bg);color:var(--text);padding:0;min-height:100vh}
.top{padding:.7rem 1.2rem;border-bottom:1px solid var(--line);display:flex;align-items:center;gap:.8rem}.top h1{font-size:1.1rem;flex:1}.top a{color:var(--blue);text-decoration:none;font-size:.82rem}
.live{width:.45rem;height:.45rem;border-radius:50%;background:var(--mint);display:inline-block;animation:p 2s infinite}@keyframes p{0%,100%{opacity:1}50%{opacity:.3}}
.sh{max-width:94rem;margin:0 auto;padding:.8rem}
.grid{display:grid;gap:.5rem;grid-template-columns:repeat(auto-fit,minmax(9rem,1fr));margin-bottom:.8rem}
.stat{background:var(--card);border:1px solid var(--line);border-radius:.6rem;padding:.5rem}.stat .l{color:var(--muted);font-size:.7rem}.stat .v{font-size:1.2rem;font-weight:700;color:var(--mint)}.stat .v.off{color:var(--rose)}.stat .v.sm{font-size:.82rem}
.tabs{display:flex;gap:.3rem;margin-bottom:.6rem;flex-wrap:wrap}
.tab{border:0;border-radius:999px;padding:.35rem .65rem;background:rgba(255,255,255,.06);color:var(--text);cursor:pointer;font:inherit;font-size:.74rem;white-space:nowrap}
.tab.active{background:linear-gradient(135deg,var(--mint),var(--blue));color:#072133;font-weight:700}
.pnl{background:var(--card);border:1px solid var(--line);border-radius:.6rem;padding:.8rem;margin-bottom:.5rem;display:none}.pnl.show{display:block}
.pnl h2{font-size:.88rem;margin-bottom:.5rem;color:var(--gold)}.pnl h3{font-size:.8rem;margin:.5rem 0 .3rem;color:var(--blue)}
table{width:100%;border-collapse:collapse;font-size:.76rem}th{text-align:left;color:var(--muted);padding:.3rem .4rem;border-bottom:1px solid var(--line)}td{padding:.3rem .4rem;border-bottom:1px solid var(--line)}
.badge{display:inline-block;padding:.1rem .4rem;border-radius:999px;font-size:.7rem;font-weight:600}
.badge.ok{background:rgba(140,255,215,.15);color:var(--mint)}.badge.warn{background:rgba(255,211,110,.15);color:var(--gold)}.badge.off{background:rgba(255,143,176,.12);color:var(--rose)}.badge.info{background:rgba(103,215,255,.12);color:var(--blue)}.badge.green{background:rgba(74,222,128,.15);color:var(--green)}.badge.orange{background:rgba(251,146,60,.15);color:var(--orange)}.badge.red{background:rgba(248,113,113,.15);color:var(--red)}
.chip{display:inline-block;padding:.18rem .4rem;border-radius:999px;font-size:.7rem;background:rgba(255,255,255,.06);border:1px solid var(--line);margin:.1rem}
.badges{display:flex;flex-wrap:wrap;gap:.3rem;margin:.3rem 0}
.btn{border:0;border-radius:999px;padding:.3rem .6rem;background:rgba(255,255,255,.08);color:var(--text);cursor:pointer;font:inherit;font-size:.72rem;transition:all .1s}
.btn:hover{background:rgba(255,255,255,.14)}.btn.primary{background:linear-gradient(135deg,var(--mint),var(--blue));color:#072133;font-weight:700}.btn.success{background:rgba(74,222,128,.2);color:var(--green)}.btn.danger{background:rgba(248,113,113,.2);color:var(--red)}.btn.warning{background:rgba(251,146,60,.2);color:var(--orange)}.btn:disabled{opacity:.35;cursor:default}
.actions{display:flex;flex-wrap:wrap;gap:.3rem;margin:.4rem 0}
.fr{display:flex;gap:.4rem;align-items:center;flex-wrap:wrap;margin:.3rem 0}.fr label{color:var(--muted);font-size:.72rem}
.fr input,.fr select,.fr textarea{border:1px solid var(--line);border-radius:.4rem;padding:.3rem .5rem;background:rgba(0,0,0,.22);color:var(--text);font:inherit;font-size:.76rem}.fr textarea{min-height:2rem;resize:vertical;width:100%}.fr input{min-width:7rem}
.log{background:rgba(0,0,0,.3);border-radius:.4rem;padding:.4rem;font-family:Consolas,monospace;font-size:.66rem;color:var(--mint);max-height:14rem;overflow-y:auto;white-space:pre-wrap;word-break:break-all}
.mono{font-family:Consolas,monospace;font-size:.72rem}.detail{color:var(--muted);font-size:.72rem}.empty{color:var(--muted);padding:.5rem;text-align:center;font-size:.78rem}
.tc{background:rgba(255,255,255,.03);border:1px solid var(--line);border-radius:.6rem;padding:.6rem;margin-bottom:.4rem}
.tc .th{display:flex;align-items:center;gap:.4rem;flex-wrap:wrap}.tc .tid{font-family:Consolas,monospace;font-size:.74rem;color:var(--blue)}.tc .tt{color:var(--muted);font-size:.68rem}
.tc .td{margin-top:.2rem;font-size:.74rem;color:var(--muted)}.tc .ta{margin-top:.3rem;display:flex;gap:.25rem;flex-wrap:wrap}
.tc .tr{margin-top:.2rem;font-family:Consolas,monospace;font-size:.64rem;color:var(--muted);max-height:2.5rem;overflow-y:auto;background:rgba(0,0,0,.2);padding:.2rem;border-radius:.3rem;word-break:break-all}
.tc .hist{margin-top:.15rem;font-size:.66rem;color:var(--muted)}
@media(max-width:600px){.sh{padding:.4rem}.grid{grid-template-columns:repeat(2,1fr)}.stat .v{font-size:1rem}.tabs{gap:.2rem}.tab{padding:.3rem .5rem;font-size:.68rem}.pnl{padding:.5rem}.tc{padding:.4rem}.tc .ta{gap:.2rem}.btn{padding:.25rem .5rem;font-size:.68rem}.fr{flex-direction:column;align-items:stretch}.fr input,.fr select{min-width:auto;width:100%}table{font-size:.68rem;display:block;overflow-x:auto}th,td{padding:.2rem .3rem;white-space:nowrap}}
";

    private const string CommonJs = @"
var Q=function(s){return document.querySelector(s)};
var ws,ds={};
function connect(){
  ws=new WebSocket((location.protocol==='https:'?'wss://':'ws://')+location.host+'/ws/dashboard');
  ws.onopen=function(){Q('#cs').className='badge ok';Q('#cs').textContent='Connected'};
  ws.onclose=function(){Q('#cs').className='badge off';Q('#cs').textContent='Reconnecting...';setTimeout(connect,2000)};
  ws.onmessage=function(e){try{var d=JSON.parse(e.data);
    if(d.EventType==='Status'&&d.Data){ds=d.Data;if(typeof renderNfc==='function')renderNfc();if(typeof renderStats==='function')renderStats()}
    if(d.EventType==='NewTransaction'||d.EventType==='TransactionUpdate'||d.EventType==='Refresh')refresh();
  }catch{}};
}
connect();
function cmd(n,x){if(ws&&ws.readyState===1)ws.send(JSON.stringify(Object.assign({Command:n},x||{})))}
function st(id){var ps=document.querySelectorAll('.pnl');for(var i=0;i<ps.length;i++)ps[i].classList.remove('show');var ts=document.querySelectorAll('.tab');for(var i=0;i<ts.length;i++)ts[i].classList.remove('active');var p=Q('#p-'+id);if(p)p.classList.add('show');event.target.classList.add('active')}
function sb(s){var m={Pending:'warn',Authorized:'info',Captured:'green',Declined:'red',Voided:'orange',Settled:'ok',Reversed:'off',Refunded:'off'};return '<span class=""badge '+(m[s]||'warn')+'"">'+''+s+'</span>'}
function b(v,y,n){return v?'<span class=""badge ok"">'+y+'</span>':'<span class=""badge off"">'+n+'</span>'}
function api(url,method,body){var o={method:method||'POST'};if(body){o.headers={'Content-Type':'application/json'};o.body=JSON.stringify(body)}fetch(url,o).then(function(){refresh()}).catch(function(){refresh()})}
";

    private const string PaymentTemplate = @"<!DOCTYPE html><html lang=""en""><head><meta charset=""utf-8""/><meta name=""viewport"" content=""width=device-width,initial-scale=1""/><title>Willow Maze</title>
<style>/*CSS*/</style></head><body>
<div class=""top""><h1><span class=""live""></span> Willow Maze</h1><a href=""/nfc"">NFC Control</a><span id=""cs"" class=""badge off"">...</span></div>
<div class=""sh"">
<div class=""grid"" id=""stats""></div>
<div class=""tabs"">
  <button class=""tab active"" onclick=""st('txns')"">Transactions</button>
  <button class=""tab"" onclick=""st('vault')"">Card Vault</button>
  <button class=""tab"" onclick=""st('custs')"">Customers</button>
  <button class=""tab"" onclick=""st('subs')"">Subscriptions</button>
  <button class=""tab"" onclick=""st('audit')"">Audit Trail</button>
  <button class=""tab"" onclick=""st('logs')"">Logs</button>
</div>
<div class=""pnl show"" id=""p-txns""><h2>Transactions</h2><div id=""txnList""><p class=""empty"">Waiting for card taps...</p></div></div>
<div class=""pnl"" id=""p-vault""><h2>Card Vault</h2><table><thead><tr><th>ID</th><th>PAN</th><th>Brand</th><th>Last4</th><th>Expiry</th><th>Cardholder</th><th>Fingerprint</th><th>Customer</th><th>Status</th><th>Actions</th></tr></thead><tbody id=""vaultBody""></tbody></table></div>
<div class=""pnl"" id=""p-custs""><h2>Customers</h2>
  <div class=""fr""><label>Name</label><input id=""cN""/><label>Email</label><input id=""cE""/><label>Phone</label><input id=""cP""/><button class=""btn primary"" onclick=""api('/api/customer','POST',{Name:Q('#cN').value,Email:Q('#cE').value,Phone:Q('#cP').value})"">Create</button></div>
  <table><thead><tr><th>ID</th><th>Name</th><th>Email</th><th>Phone</th><th>Cards</th><th>Created</th><th>Actions</th></tr></thead><tbody id=""custBody""></tbody></table>
</div>
<div class=""pnl"" id=""p-subs""><h2>Subscriptions</h2>
  <div class=""fr""><label>Customer</label><select id=""sC""></select><label>Card</label><select id=""sV""></select><label>Amount</label><input id=""sA"" type=""number"" value=""500"" style=""width:5rem""/><label>Currency</label><input id=""sCu"" value=""PHP"" style=""width:3.5rem""/><label>Interval</label><select id=""sI""><option>Daily</option><option>Weekly</option><option selected>Monthly</option></select><label>Desc</label><input id=""sD"" value=""Plan""/><button class=""btn primary"" onclick=""api('/api/sub','POST',{CustomerId:Q('#sC').value,VaultId:Q('#sV').value,Amount:+Q('#sA').value,Currency:Q('#sCu').value,Interval:Q('#sI').value,Description:Q('#sD').value})"">Create</button></div>
  <table><thead><tr><th>ID</th><th>Customer</th><th>Card</th><th>Amount</th><th>Interval</th><th>Status</th><th>Next</th><th>#</th><th>Actions</th></tr></thead><tbody id=""subBody""></tbody></table>
</div>
<div class=""pnl"" id=""p-audit""><h2>Audit Trail</h2><table><thead><tr><th>Time</th><th>Entity</th><th>ID</th><th>Action</th><th>Old</th><th>New</th></tr></thead><tbody id=""auditBody""></tbody></table></div>
<div class=""pnl"" id=""p-logs""><h2>Logs</h2><div class=""log"" id=""logC""></div></div>
</div>
<script>
/*COMMONJS*/
var txns={},vCards={},custs={},subs={},audits=[];
function renderTxns(){
  var list=Object.values(txns).sort(function(a,b){return new Date(b.CreatedUtc)-new Date(a.CreatedUtc)});
  if(!list.length){Q('#txnList').innerHTML='<p class=""empty"">Waiting for card taps...</p>';return}
  Q('#txnList').innerHTML=list.map(function(t){
    var P=t.Status==='Pending',A=t.Status==='Authorized',C=t.Status==='Captured',S=t.Status==='Settled';
    var r='<div class=""tc""><div class=""th""><span class=""tid"">'+t.Id+'</span>'+sb(t.Status)+'<span class=""badge info"">'+t.EventType+'</span>';
    if(t.CardBrand)r+='<span class=""chip"">'+t.CardBrand+'</span>';
    if(t.AidHex)r+='<span class=""chip mono"">'+t.AidHex+'</span>';
    if(t.Amount)r+='<span class=""badge green"">'+t.Amount+' '+(t.Currency||'')+'</span>';
    if(t.VaultId)r+='<span class=""chip"">V:'+t.VaultId+'</span>';
    if(t.SubscriptionId)r+='<span class=""chip"">S:'+t.SubscriptionId+'</span>';
    r+='<span class=""tt"">'+new Date(t.CreatedUtc).toLocaleString()+'</span>';
    if(t.UpdatedUtc)r+='<span class=""tt"">'+new Date(t.UpdatedUtc).toLocaleTimeString()+'</span>';
    r+='</div><div class=""td""><b>Device:</b> '+t.DeviceId+' | <b>Resp:</b> '+(t.ResponsePreview||'-');
    if(t.CustomerId)r+=' | <b>Cust:</b> '+t.CustomerId;
    if(t.AuthorizationCode)r+='<br/><b>Auth:</b> '+t.AuthorizationCode+' | <b>Ref:</b> '+(t.ReferenceNumber||'-')+' | <b>GW:</b> ['+(t.GatewayResponseCode||'')+'] '+(t.GatewayResponseMessage||'');
    if(t.GatewayToken)r+=' | <b>Token:</b> '+t.GatewayToken;
    r+='</div><div class=""ta"">';
    r+='<input id=""amt_'+t.Id+'"" type=""number"" value=""'+(t.Amount||100)+'"" style=""width:4rem;font-size:.7rem;padding:.2rem;border:1px solid rgba(255,255,255,.1);border-radius:.3rem;background:rgba(0,0,0,.3);color:#edf6ff"" '+(P?'':'disabled')+'/>';
    r+='<button class=""btn success"" onclick=""api(\'/api/txn/'+t.Id+'/authorize\',\'POST\',{Amount:+(document.getElementById(\'amt_'+t.Id+'\')||{}).value||100,Currency:\'PHP\'})"" '+(P?'':'disabled')+'>Authorize</button>';
    r+='<button class=""btn primary"" onclick=""api(\'/api/txn/'+t.Id+'/capture\')"" '+(A?'':'disabled')+'>Capture</button>';
    r+='<button class=""btn"" onclick=""api(\'/api/txn/'+t.Id+'/settle\')"" '+(C?'':'disabled')+'>Settle</button>';
    r+='<button class=""btn danger"" onclick=""api(\'/api/txn/'+t.Id+'/decline\')"" '+(P?'':'disabled')+'>Decline</button>';
    r+='<button class=""btn warning"" onclick=""api(\'/api/txn/'+t.Id+'/void\')"" '+(A||C?'':'disabled')+'>Void</button>';
    r+='<button class=""btn"" onclick=""api(\'/api/txn/'+t.Id+'/refund\')"" '+(C||S?'':'disabled')+'>Refund</button>';
    r+='<button class=""btn"" onclick=""api(\'/api/txn/'+t.Id+'/reverse\')"" '+(A?'':'disabled')+'>Reverse</button>';
    r+='<button class=""btn primary"" onclick=""api(\'/api/txn/'+t.Id+'/vault\')"" '+(!t.VaultId?'':'disabled')+'>Vault</button>';
    r+='<button class=""btn danger"" onclick=""api(\'/api/txn/'+t.Id+'\',\'DELETE\')"">Del</button>';
    r+='</div>';
    if(t.History&&t.History.length)r+='<div class=""hist"">'+t.History.join(' | ')+'</div>';
    if(t.RawJson)r+='<div class=""tr"">'+t.RawJson+'</div>';
    return r+'</div>';
  }).join('');
}
function renderVault(){
  var list=Object.values(vCards).sort(function(a,b){return new Date(b.CreatedUtc)-new Date(a.CreatedUtc)});
  var copts=Object.values(custs).map(function(c){return '<option value=""'+c.Id+'"">'+c.Name+'</option>'}).join('');
  Q('#vaultBody').innerHTML=list.map(function(c){
    var sBadge=c.Status==='Active'?'ok':c.Status==='Suspended'?'warn':'off';
    var togAct=c.Status==='Active'?'suspend':'activate';
    var togLbl=c.Status==='Active'?'Suspend':'Activate';
    var custCell;
    if(c.CustomerId){var cn=custs[c.CustomerId]?custs[c.CustomerId].Name:c.CustomerId;custCell='<span class=""badge ok"">'+cn+'</span>'}
    else{custCell='<select onchange=""api(\'/api/vault/'+c.Id+'/link/\'+this.value)"" style=""font-size:.72rem;padding:.2rem;background:rgba(0,0,0,.3);color:#edf6ff;border:1px solid rgba(255,255,255,.1);border-radius:.3rem""><option value="""">Link...</option>'+copts+'</select>'}
    var acts='<input id=""vAmt_'+c.Id+'"" type=""number"" value=""100"" style=""width:3.5rem;font-size:.68rem;padding:.15rem;border:1px solid rgba(255,255,255,.1);border-radius:.3rem;background:rgba(0,0,0,.3);color:#edf6ff""/> ';
    acts+='<button class=""btn success"" onclick=""api(\'/api/vault/'+c.Id+'/charge\',\'POST\',{Amount:+(document.getElementById(\'vAmt_'+c.Id+'\')||{}).value||100,Currency:\'PHP\'})"" '+(c.Status==='Active'||c.Status==='Verified'?'':'disabled')+'>Charge</button> ';
    acts+='<button class=""btn"" onclick=""api(\'/api/vault/'+c.Id+'/verify\')"" '+(c.Status==='Active'?'':'disabled')+'>Verify</button> ';
    acts+='<button class=""btn warning"" onclick=""api(\'/api/vault/'+c.Id+'/'+togAct+'\')"">'+togLbl+'</button> ';
    acts+='<button class=""btn"" onclick=""api(\'/api/vault/'+c.Id+'/expire\')"">Expire</button> ';
    acts+='<button class=""btn danger"" onclick=""api(\'/api/vault/'+c.Id+'/flag\')"">Flag</button> ';
    acts+='<button class=""btn danger"" onclick=""api(\'/api/vault/'+c.Id+'\',\'DELETE\')"">Del</button>';
    var hist=c.History&&c.History.length?'<div class=""detail"">'+c.History.join(' | ')+'</div>':'';
    return '<tr><td class=""mono"">'+c.Id+'</td><td class=""mono"">'+(c.TokenMask||'-')+'</td><td>'+(c.CardBrand||'-')+'</td><td>'+c.Last4+'</td><td>'+(c.Expiry||'-')+'</td><td>'+(c.CardholderName||'-')+'</td><td class=""mono"">'+c.Fingerprint+'</td><td>'+custCell+'</td><td><span class=""badge '+sBadge+'"">'+c.Status+'</span>'+hist+'</td><td>'+acts+'</td></tr>';
  }).join('');
  Q('#sV').innerHTML=list.filter(function(c){return c.Status==='Active'}).map(function(c){return '<option value=""'+c.Id+'"">'+c.Id+' ('+c.CardBrand+' '+c.Last4+')</option>'}).join('');
}
function renderCusts(){
  var list=Object.values(custs).sort(function(a,b){return new Date(b.CreatedUtc)-new Date(a.CreatedUtc)});
  Q('#custBody').innerHTML=list.map(function(c){
    var cards=Object.values(vCards).filter(function(v){return v.CustomerId===c.Id}).length;
    return '<tr><td class=""mono"">'+c.Id+'</td><td>'+c.Name+'</td><td>'+c.Email+'</td><td>'+c.Phone+'</td><td>'+cards+'</td><td>'+new Date(c.CreatedUtc).toLocaleString()+'</td><td><button class=""btn danger"" onclick=""api(\'/api/customer/'+c.Id+'\',\'DELETE\')"">Del</button></td></tr>';
  }).join('');
  Q('#sC').innerHTML=list.map(function(c){return '<option value=""'+c.Id+'"">'+c.Name+'</option>'}).join('');
}
function renderSubs(){
  var list=Object.values(subs).sort(function(a,b){return new Date(b.CreatedUtc)-new Date(a.CreatedUtc)});
  Q('#subBody').innerHTML=list.map(function(s){
    var sBadge=s.Status==='Active'?'ok':s.Status==='Paused'?'warn':'off';
    var togAct=s.Status==='Active'?'pause':'resume';
    var togLbl=s.Status==='Active'?'Pause':'Resume';
    var nxt=s.NextChargeUtc?new Date(s.NextChargeUtc).toLocaleDateString():'-';
    var canChg=s.Status==='Active'?'':'disabled';
    var canCnl=s.Status!=='Cancelled'?'':'disabled';
    return '<tr><td class=""mono"">'+s.Id+'</td><td>'+(custs[s.CustomerId]?custs[s.CustomerId].Name:s.CustomerId)+'</td><td class=""mono"">'+s.VaultId+'</td><td>'+s.Amount+' '+s.Currency+'</td><td>'+s.Interval+'</td><td><span class=""badge '+sBadge+'"">'+s.Status+'</span></td><td>'+nxt+'</td><td>'+(s.ChargeCount||0)+'</td><td><button class=""btn success"" onclick=""api(\'/api/sub/'+s.Id+'/charge\')"" '+canChg+'>Charge</button> <button class=""btn warning"" onclick=""api(\'/api/sub/'+s.Id+'/'+togAct+'\')"">'+togLbl+'</button> <button class=""btn danger"" onclick=""api(\'/api/sub/'+s.Id+'/cancel\')"" '+canCnl+'>Cancel</button> <button class=""btn danger"" onclick=""api(\'/api/sub/'+s.Id+'\',\'DELETE\')"">Del</button></td></tr>';
  }).join('');
}
function renderStats(){
  var d=ds;if(!d.IsSupported&&d.IsSupported!==false)return;
  var pend=Object.values(txns).filter(function(t){return t.Status==='Pending'}).length;
  var capt=Object.values(txns).filter(function(t){return t.Status==='Captured'||t.Status==='Settled'}).length;
  Q('#stats').innerHTML='<div class=""stat""><div class=""l"">NFC</div><div class=""v '+(d.IsEnabled?'':'off')+'"">'+( d.IsEnabled?'ON':'OFF')+'</div></div><div class=""stat""><div class=""l"">Reader</div><div class=""v '+(d.IsListening?'':'off')+'"">'+( d.IsListening?'LIVE':'OFF')+'</div></div><div class=""stat""><div class=""l"">Pending</div><div class=""v"" style=""color:var(--gold)"">'+pend+'</div></div><div class=""stat""><div class=""l"">Captured</div><div class=""v"" style=""color:var(--green)"">'+capt+'</div></div><div class=""stat""><div class=""l"">Vault</div><div class=""v"">'+Object.keys(vCards).length+'</div></div><div class=""stat""><div class=""l"">Subs</div><div class=""v"">'+Object.values(subs).filter(function(s){return s.Status==='Active'}).length+'</div></div><div class=""stat""><div class=""l"">AID</div><div class=""v sm"">'+(d.HceAidHex||'-')+'</div></div>';
}
function renderAudit(){
  Q('#auditBody').innerHTML=audits.map(function(a){
    return '<tr><td>'+new Date(a.CreatedUtc).toLocaleString()+'</td><td><span class=""badge info"">'+a.EntityType+'</span></td><td class=""mono"">'+a.EntityId+'</td><td>'+a.Action+'</td><td>'+(a.OldValue||'-')+'</td><td>'+(a.NewValue||'-')+'</td></tr>';
  }).join('');
}
function refresh(){
  fetch('/api/data').then(function(r){return r.json()}).then(function(d){
    txns={};(d.Transactions||[]).forEach(function(t){txns[t.Id]=t});renderTxns();
    vCards={};(d.Vault||[]).forEach(function(v){vCards[v.Id]=v});renderVault();
    custs={};(d.Customers||[]).forEach(function(c){custs[c.Id]=c});renderCusts();
    subs={};(d.Subscriptions||[]).forEach(function(s){subs[s.Id]=s});renderSubs();
    audits=d.Audit||[];renderAudit();
    Q('#logC').textContent=(d.RecentLogs||[]).join('\n');
    for(var k in d.DeviceStatus||{}){try{var s=JSON.parse(d.DeviceStatus[k]);if(s.Data){ds=s.Data;renderStats()}}catch(e){}}
  }).catch(function(){});
}
refresh();setInterval(refresh,5000);
</script></body></html>";

    private const string NfcTemplate = @"<!DOCTYPE html><html lang=""en""><head><meta charset=""utf-8""/><meta name=""viewport"" content=""width=device-width,initial-scale=1""/><title>Willow Maze - NFC</title>
<style>/*CSS*/</style></head><body>
<div class=""top""><h1><span class=""live""></span> NFC Control</h1><a href=""/"">Payments</a><span id=""cs"" class=""badge off"">...</span></div>
<div class=""sh"">
<div class=""grid"" id=""stats""></div>
<div class=""tabs"">
  <button class=""tab active"" onclick=""st('nfc')"">Adapter</button>
  <button class=""tab"" onclick=""st('hce')"">HCE</button>
  <button class=""tab"" onclick=""st('hcef')"">NFC-F</button>
  <button class=""tab"" onclick=""st('reader')"">Reader</button>
  <button class=""tab"" onclick=""st('devices')"">Devices</button>
  <button class=""tab"" onclick=""st('aids')"">AIDs</button>
  <button class=""tab"" onclick=""st('raw')"">Raw I/O</button>
  <button class=""tab"" onclick=""st('observe')"">Observe</button>
  <button class=""tab"" onclick=""st('logs')"">Logs</button>
</div>
<div class=""pnl show"" id=""p-nfc""><h2>NFC Adapter</h2><div class=""badges"" id=""adB""></div><div class=""detail"" id=""adS""></div><h3>Capabilities</h3><div id=""caps""></div><h3>Antenna</h3><div id=""ant""></div><h3>Payment</h3><div class=""badges"" id=""pay""></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('Refresh')"">Refresh</button><button class=""btn"" onclick=""cmd('OpenNfcSettings')"">Settings</button></div></div>
<div class=""pnl"" id=""p-hce""><h2>ISO-DEP HCE</h2><div class=""badges"" id=""hceB""></div><div class=""detail"" id=""hceS""></div><h3>Response</h3><div class=""fr""><textarea id=""hceR""></textarea></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('UpdateHceResponse',{Value:Q('#hceR').value})"">Save</button><button class=""btn primary"" onclick=""cmd('SetPreferredService')"">Preferred</button><button class=""btn"" onclick=""cmd('ReleasePreferredService')"">Release</button></div></div>
<div class=""pnl"" id=""p-hcef""><h2>NFC-F</h2><div class=""badges"" id=""hcefB""></div><div class=""detail"" id=""hcefS""></div><div class=""fr""><textarea id=""hcefR""></textarea></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('UpdateHceFResponse',{Value:Q('#hcefR').value})"">Save</button><button class=""btn primary"" onclick=""cmd('EnableHceF')"">Enable</button><button class=""btn danger"" onclick=""cmd('DisableHceF')"">Disable</button></div></div>
<div class=""pnl"" id=""p-reader""><h2>Reader</h2><div class=""actions""><button class=""btn primary"" onclick=""cmd('StartReader')"">Start</button><button class=""btn"" onclick=""cmd('StopReader')"">Stop</button><button class=""btn"" onclick=""cmd('EnableForegroundDispatch')"">FG On</button><button class=""btn"" onclick=""cmd('DisableForegroundDispatch')"">FG Off</button><button class=""btn"" onclick=""cmd('FormatTag')"">Format</button></div><h3>Tag</h3><div id=""tag""><p class=""empty"">No tag</p></div></div>
<div class=""pnl"" id=""p-devices""><h2>Devices</h2><table><thead><tr><th>ID</th><th>IP</th><th>Connected</th><th>Msgs</th><th>Status</th></tr></thead><tbody id=""devB""></tbody></table></div>
<div class=""pnl"" id=""p-aids""><h2>AIDs</h2><h3>Dynamic</h3><div class=""badges"" id=""rA""></div><div class=""fr""><input id=""aI"" placeholder=""A0000000041010""/></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('RegisterHceAids',{Value:Q('#aI').value})"">Register</button><button class=""btn danger"" onclick=""cmd('ClearHceAids')"">Clear</button></div><h3>System</h3><div class=""badges"" id=""sA""></div><div class=""fr""><select id=""aC""><option value=""other"">Other</option><option value=""payment"">Payment</option></select><input id=""sAI""/></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('RegisterSystemAids',{Category:Q('#aC').value,Value:Q('#sAI').value})"">Register</button><button class=""btn danger"" onclick=""cmd('RemoveSystemAids',{Category:Q('#aC').value})"">Remove</button></div></div>
<div class=""pnl"" id=""p-raw""><h2>Raw I/O</h2><div class=""fr""><select id=""rT""><option>IsoDep</option><option>NfcA</option><option>NfcB</option><option>NfcF</option><option>NfcV</option><option>MifareClassic</option><option>MifareUltralight</option></select><input id=""rC"" placeholder=""00 A4 04 00 07 F0770A11B1C2D3"" style=""min-width:14rem""/></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('SendRaw',{Technology:Q('#rT').value,Value:Q('#rC').value})"">Send</button></div></div>
<div class=""pnl"" id=""p-observe""><h2>Observe</h2><div class=""badges"" id=""obsB""></div><div class=""detail"" id=""obsS""></div><div class=""actions""><button class=""btn primary"" onclick=""cmd('EnableObserveMode')"">Enable</button><button class=""btn"" onclick=""cmd('DisableObserveMode')"">Disable</button><button class=""btn"" onclick=""cmd('SetDefaultObserveMode',{Value:true})"">Default On</button><button class=""btn"" onclick=""cmd('SetDefaultObserveMode',{Value:false})"">Default Off</button><button class=""btn"" onclick=""cmd('ResetDiscoveryTechnology')"">Reset</button></div></div>
<div class=""pnl"" id=""p-logs""><h2>Logs</h2><div class=""log"" id=""logC""></div></div>
</div>
<script>
/*COMMONJS*/
function renderNfc(){
  var d=ds;if(!d.IsSupported&&d.IsSupported!==false)return;
  Q('#stats').innerHTML='<div class=""stat""><div class=""l"">NFC</div><div class=""v '+(d.IsEnabled?'':'off')+'"">'+( d.IsEnabled?'ON':'OFF')+'</div></div><div class=""stat""><div class=""l"">Reader</div><div class=""v '+(d.IsListening?'':'off')+'"">'+( d.IsListening?'LIVE':'OFF')+'</div></div><div class=""stat""><div class=""l"">Preferred</div><div class=""v '+(d.IsPreferredService?'':'off')+'"">'+( d.IsPreferredService?'YES':'NO')+'</div></div><div class=""stat""><div class=""l"">HCE</div><div class=""v"">'+(d.HceEventCount||0)+'</div></div><div class=""stat""><div class=""l"">AID</div><div class=""v sm"">'+(d.HceAidHex||'-')+'</div></div>';
  Q('#adB').innerHTML=[b(d.IsSupported,'NFC','Missing'),b(d.IsEnabled,'On','Off'),b(d.IsListening,'Reader','Paused'),b(d.SupportsHce,'HCE','No'),b(d.SupportsNfcFCardEmulation,'NFC-F','No'),b(d.IsForegroundDispatchEnabled,'FG On','FG Off')].join('');
  Q('#adS').textContent=d.StatusText||'';
  Q('#caps').innerHTML=(d.CapabilityNotes||[]).map(function(n){return '<div class=""chip"">'+n+'</div>'}).join('')||'-';
  Q('#ant').innerHTML=(d.AntennaFacts||[]).map(function(n){return '<div class=""chip"">'+n+'</div>'}).join('')||'-';
  Q('#pay').innerHTML='<span class=""chip"">Pay:'+(d.PreferredPaymentDescription||'-')+'</span><span class=""chip"">Route:'+(d.PreferredPaymentRoute||'-')+'</span>';
  Q('#hceB').innerHTML=[b(d.SupportsHce,'HCE','No'),b(d.IsPreferredService,'Preferred','No'),'<span class=""chip mono"">'+(d.HceAidHex||'-')+'</span>'].join('');
  Q('#hceS').textContent=d.HceStatusText||'';
  if(!document.activeElement||document.activeElement.id!=='hceR')Q('#hceR').value=d.HceResponseText||'';
  Q('#hcefB').innerHTML=[b(d.SupportsNfcFCardEmulation,'NFC-F','No'),b(d.IsHceFEnabled,'On','Off'),'<span class=""chip mono"">'+(d.HceFSystemCodeHex||'-')+'</span>'].join('');
  Q('#hcefS').textContent=d.HceFStatusText||'';
  if(!document.activeElement||document.activeElement.id!=='hcefR')Q('#hcefR').value=d.HceFResponseText||'';
  if(d.LatestTag){var t=d.LatestTag;Q('#tag').innerHTML='<div class=""badges"">'+(t.Technologies||[]).map(function(x){return '<span class=""chip"">'+x+'</span>'}).join('')+'</div><div class=""detail""><b>'+t.Summary+'</b> | '+t.IdentifierHex+'</div>'}
  Q('#rA').innerHTML=(d.RegisteredHceAids||[]).map(function(a){return '<span class=""chip mono"">'+a+'</span>'}).join('')||'-';
  Q('#sA').innerHTML=(d.RegisteredSystemAids||[]).map(function(a){return '<span class=""chip mono"">'+a+'</span>'}).join('')||'-';
  Q('#obsB').innerHTML=[b(d.SupportsObserveMode,'Yes','No'),b(d.IsObserveModeEnabled,'Active','Off')].join('');
  Q('#obsS').textContent=(d.ObserveModeStatusText||'')+' | '+(d.DiscoveryStatusText||'');
}
function refresh(){
  fetch('/api/data').then(function(r){return r.json()}).then(function(d){
    Q('#devB').innerHTML=(d.Devices||[]).map(function(c){return '<tr><td class=""mono"">'+c.Id+'</td><td>'+c.RemoteIp+'</td><td>'+new Date(c.ConnectedAt).toLocaleTimeString()+'</td><td>'+c.MessageCount+'</td><td>'+(c.IsOpen?'<span class=""badge ok"">Open</span>':'<span class=""badge off"">Closed</span>')+'</td></tr>'}).join('');
    Q('#logC').textContent=(d.RecentLogs||[]).join('\n');
    for(var k in d.DeviceStatus||{}){try{var s=JSON.parse(d.DeviceStatus[k]);if(s.Data){ds=s.Data;renderNfc()}}catch(e){}}
  }).catch(function(){});
}
refresh();setInterval(refresh,5000);
</script></body></html>";
}
