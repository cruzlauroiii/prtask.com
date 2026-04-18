import { GitHubRead, GitHubWrite, GitHubDelete, GitHubList } from "./collections";
import type { UserClaims, WsMessage, Env, ClientConnection } from "./types";

const Clients = new Map<WebSocket, ClientConnection>();

export function registerClient(Ws: WebSocket, User: UserClaims | null): void {
  Clients.set(Ws, { Ws, User, Channels: new Set() });
}

export function unregisterClient(Ws: WebSocket): void {
  Clients.delete(Ws);
}

function BroadcastToChannel(Channel: string, Payload: string, ExcludeWs?: WebSocket): void {
  for (const [Ws, Client] of Clients) {
    if (Ws === ExcludeWs) continue;
    if (Client.Channels.has(Channel)) {
      try { Ws.send(Payload); } catch { Clients.delete(Ws); }
    }
  }
}

function Reply(Ws: WebSocket, Msg: WsMessage, Data: unknown): void {
  Ws.send(JSON.stringify({ Type: "Data", Id: Msg.Id, Data }));
}

function ReplyOk(Ws: WebSocket, Msg: WsMessage): void {
  Ws.send(JSON.stringify({ Type: "Ack", Id: Msg.Id, Success: true }));
}

function ReplyError(Ws: WebSocket, Msg: WsMessage, Message: string): void {
  Ws.send(JSON.stringify({ Type: "Error", Id: Msg.Id, Message }));
}

function RequireAuth(Ws: WebSocket, Msg: WsMessage, Client: ClientConnection): boolean {
  if (!Client.User) {
    ReplyError(Ws, Msg, "Authentication required");
    return false;
  }
  return true;
}

export async function handleWsMessage(
  Ws: WebSocket, Raw: string, Env: Env,
): Promise<void> {
  let Msg: WsMessage;
  try { Msg = JSON.parse(Raw); }
  catch { Ws.send(JSON.stringify({ Type: "Error", Message: "Invalid JSON" })); return; }

  const Client = Clients.get(Ws);
  if (!Client) { Ws.send(JSON.stringify({ Type: "Error", Message: "Not registered" })); return; }

  switch (Msg.Type) {
    case "Subscribe":
      if (Msg.Channel) {
        Client.Channels.add(Msg.Channel);
        Ws.send(JSON.stringify({ Type: "Ack", Id: Msg.Id, Channel: Msg.Channel }));
      }
      break;

    case "UserInfo":
      if (!Client.User) { ReplyError(Ws, Msg, "Not authenticated"); break; }
      Reply(Ws, Msg, Client.User);
      break;

    // AchievementEndpoints
    case "ListAchievementUserById": {
      const R0 = await GitHubRead(Env, "data/achievement/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R0) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R0.Content));
      break;
    }
    // AuditEndpoints
    case "ListAuditRoot": {
      const L1 = await GitHubList(Env, "data/audit");
      Reply(Ws, Msg, L1);
      break;
    }
    case "ListAuditAuditLogById": {
      const R2 = await GitHubRead(Env, "data/audit/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R2) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R2.Content));
      break;
    }
    case "ListAuditByEntity": {
      const R3 = await GitHubRead(Env, "data/audit/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R3) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R3.Content));
      break;
    }
    case "ListAuditByUser": {
      const R4 = await GitHubRead(Env, "data/audit/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R4) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R4.Content));
      break;
    }
    // AuthEndpoints
    case "CreateAuthApiAuthLogout": {
      const I5 = Msg.Data?.Id ?? crypto.randomUUID();
      const N5 = { ...Msg.Data, Id: I5 };
      await GitHubWrite(Env, "data/auth/" + I5 + ".json", JSON.stringify(N5, null, 2), "Create data/auth");
      Reply(Ws, Msg, N5);
      BroadcastToChannel("data/auth", JSON.stringify({ Type: "Mutation", Channel: "data/auth", Data: N5 }), Ws);
      break;
    }
    case "ListAuthApiAuthMe": {
      const L6 = await GitHubList(Env, "data/auth");
      Reply(Ws, Msg, L6);
      break;
    }
    case "ListAuthApiAuthGitHub": {
      const L7 = await GitHubList(Env, "data/auth");
      Reply(Ws, Msg, L7);
      break;
    }
    case "ListAuthApiAuthCallback": {
      const L8 = await GitHubList(Env, "data/auth");
      Reply(Ws, Msg, L8);
      break;
    }
    case "ListAuthAuthRoute": {
      const L9 = await GitHubList(Env, "data/auth");
      Reply(Ws, Msg, L9);
      break;
    }
    case "ListAuthCallbackRoute": {
      const L10 = await GitHubList(Env, "data/auth");
      Reply(Ws, Msg, L10);
      break;
    }
    // BillsPaymentEndpoints
    case "ListBillsPaymentBillers": {
      const L11 = await GitHubList(Env, "data/bills-payment");
      Reply(Ws, Msg, L11);
      break;
    }
    case "ListBillsPaymentBillerBySlug": {
      const L12 = await GitHubList(Env, "data/bills-payment");
      Reply(Ws, Msg, L12);
      break;
    }
    case "CreateBillsPaymentRoot": {
      const I13 = Msg.Data?.Id ?? crypto.randomUUID();
      const N13 = { ...Msg.Data, Id: I13 };
      await GitHubWrite(Env, "data/bills-payment/" + I13 + ".json", JSON.stringify(N13, null, 2), "Create data/bills-payment");
      Reply(Ws, Msg, N13);
      BroadcastToChannel("data/bills-payment", JSON.stringify({ Type: "Mutation", Channel: "data/bills-payment", Data: N13 }), Ws);
      break;
    }
    case "BillsPaymentBillPaymentExecute": {
      const E14 = await GitHubRead(Env, "data/bills-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E14) { ReplyError(Ws, Msg, "Not found"); break; }
      const U14 = { ...JSON.parse(E14.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/bills-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U14, null, 2), "BillsPaymentBillPaymentExecute", E14.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/bills-payment", JSON.stringify({ Type: "Mutation", Channel: "data/bills-payment", Data: U14 }), Ws);
      break;
    }
    case "ListBillsPaymentBillPaymentStatus": {
      const R15 = await GitHubRead(Env, "data/bills-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R15) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R15.Content));
      break;
    }
    // BoardEndpoints
    case "ListBoardByOwner": {
      const R16 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R16) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R16.Content));
      break;
    }
    case "ListBoardBoardById": {
      const R17 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R17) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R17.Content));
      break;
    }
    case "CreateBoardRoot": {
      const I18 = Msg.Data?.Id ?? crypto.randomUUID();
      const N18 = { ...Msg.Data, Id: I18 };
      await GitHubWrite(Env, "data/board/" + I18 + ".json", JSON.stringify(N18, null, 2), "Create data/board");
      Reply(Ws, Msg, N18);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Mutation", Channel: "data/board", Data: N18 }), Ws);
      break;
    }
    case "UpdateBoardBoardById": {
      const C19 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C19) { ReplyError(Ws, Msg, "Not found"); break; }
      const M19 = { ...JSON.parse(C19.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/board/" + Msg.Data?.Id + ".json", JSON.stringify(M19, null, 2), "Update data/board", C19.Sha);
      Reply(Ws, Msg, M19);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Mutation", Channel: "data/board", Data: M19 }), Ws);
      break;
    }
    case "DeleteBoardBoardById": {
      const D20 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D20) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/board/" + Msg.Data?.Id + ".json", D20.Sha, "Delete data/board");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Deletion", Channel: "data/board", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListBoardColumns": {
      const R21 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R21) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R21.Content));
      break;
    }
    case "CreateBoardColumns": {
      const I22 = Msg.Data?.Id ?? crypto.randomUUID();
      const N22 = { ...Msg.Data, Id: I22 };
      await GitHubWrite(Env, "data/board/" + I22 + ".json", JSON.stringify(N22, null, 2), "Create data/board");
      Reply(Ws, Msg, N22);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Mutation", Channel: "data/board", Data: N22 }), Ws);
      break;
    }
    case "UpdateBoardColumnById": {
      const C23 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C23) { ReplyError(Ws, Msg, "Not found"); break; }
      const M23 = { ...JSON.parse(C23.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/board/" + Msg.Data?.Id + ".json", JSON.stringify(M23, null, 2), "Update data/board", C23.Sha);
      Reply(Ws, Msg, M23);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Mutation", Channel: "data/board", Data: M23 }), Ws);
      break;
    }
    case "DeleteBoardColumnById": {
      const D24 = await GitHubRead(Env, "data/board/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D24) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/board/" + Msg.Data?.Id + ".json", D24.Sha, "Delete data/board");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/board", JSON.stringify({ Type: "Deletion", Channel: "data/board", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // CloudflareD1Endpoints
    case "ListCloudflareD1Status": {
      const L25 = await GitHubList(Env, "data/cloudflare-d1");
      Reply(Ws, Msg, L25);
      break;
    }
    case "CreateCloudflareD1Query": {
      const I26 = Msg.Data?.Id ?? crypto.randomUUID();
      const N26 = { ...Msg.Data, Id: I26 };
      await GitHubWrite(Env, "data/cloudflare-d1/" + I26 + ".json", JSON.stringify(N26, null, 2), "Create data/cloudflare-d1");
      Reply(Ws, Msg, N26);
      BroadcastToChannel("data/cloudflare-d1", JSON.stringify({ Type: "Mutation", Channel: "data/cloudflare-d1", Data: N26 }), Ws);
      break;
    }
    // CustomerEndpoints
    case "CreateCustomerRoot": {
      const I27 = Msg.Data?.Id ?? crypto.randomUUID();
      const N27 = { ...Msg.Data, Id: I27 };
      await GitHubWrite(Env, "data/customer/" + I27 + ".json", JSON.stringify(N27, null, 2), "Create data/customer");
      Reply(Ws, Msg, N27);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Mutation", Channel: "data/customer", Data: N27 }), Ws);
      break;
    }
    case "ListCustomerCustomerById": {
      const R28 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R28) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R28.Content));
      break;
    }
    case "UpdateCustomerCustomerById": {
      const C29 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C29) { ReplyError(Ws, Msg, "Not found"); break; }
      const M29 = { ...JSON.parse(C29.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/customer/" + Msg.Data?.Id + ".json", JSON.stringify(M29, null, 2), "Update data/customer", C29.Sha);
      Reply(Ws, Msg, M29);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Mutation", Channel: "data/customer", Data: M29 }), Ws);
      break;
    }
    case "DeleteCustomerCustomerById": {
      const D30 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D30) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/customer/" + Msg.Data?.Id + ".json", D30.Sha, "Delete data/customer");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Deletion", Channel: "data/customer", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListCustomerCustomerCards": {
      const R31 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R31) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R31.Content));
      break;
    }
    case "ListCustomerCustomerCard": {
      const R32 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R32) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R32.Content));
      break;
    }
    case "CreateCustomerCustomerCards": {
      const I33 = Msg.Data?.Id ?? crypto.randomUUID();
      const N33 = { ...Msg.Data, Id: I33 };
      await GitHubWrite(Env, "data/customer/" + I33 + ".json", JSON.stringify(N33, null, 2), "Create data/customer");
      Reply(Ws, Msg, N33);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Mutation", Channel: "data/customer", Data: N33 }), Ws);
      break;
    }
    case "UpdateCustomerCustomerCard": {
      const C34 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C34) { ReplyError(Ws, Msg, "Not found"); break; }
      const M34 = { ...JSON.parse(C34.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/customer/" + Msg.Data?.Id + ".json", JSON.stringify(M34, null, 2), "Update data/customer", C34.Sha);
      Reply(Ws, Msg, M34);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Mutation", Channel: "data/customer", Data: M34 }), Ws);
      break;
    }
    case "DeleteCustomerCustomerCard": {
      const D35 = await GitHubRead(Env, "data/customer/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D35) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/customer/" + Msg.Data?.Id + ".json", D35.Sha, "Delete data/customer");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Deletion", Channel: "data/customer", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "CreateCustomerCustomerCardPay": {
      const I36 = Msg.Data?.Id ?? crypto.randomUUID();
      const N36 = { ...Msg.Data, Id: I36 };
      await GitHubWrite(Env, "data/customer/" + I36 + ".json", JSON.stringify(N36, null, 2), "Create data/customer");
      Reply(Ws, Msg, N36);
      BroadcastToChannel("data/customer", JSON.stringify({ Type: "Mutation", Channel: "data/customer", Data: N36 }), Ws);
      break;
    }
    // DiffEndpoints
    case "CreateDiffDiffCompute": {
      const I37 = Msg.Data?.Id ?? crypto.randomUUID();
      const N37 = { ...Msg.Data, Id: I37 };
      await GitHubWrite(Env, "data/diff/" + I37 + ".json", JSON.stringify(N37, null, 2), "Create data/diff");
      Reply(Ws, Msg, N37);
      BroadcastToChannel("data/diff", JSON.stringify({ Type: "Mutation", Channel: "data/diff", Data: N37 }), Ws);
      break;
    }
    case "ListDiffDiffLanguage": {
      const L38 = await GitHubList(Env, "data/diff");
      Reply(Ws, Msg, L38);
      break;
    }
    // DisbursementEndpoints
    case "CreateDisbursementRoot": {
      const I39 = Msg.Data?.Id ?? crypto.randomUUID();
      const N39 = { ...Msg.Data, Id: I39 };
      await GitHubWrite(Env, "data/disbursement/" + I39 + ".json", JSON.stringify(N39, null, 2), "Create data/disbursement");
      Reply(Ws, Msg, N39);
      BroadcastToChannel("data/disbursement", JSON.stringify({ Type: "Mutation", Channel: "data/disbursement", Data: N39 }), Ws);
      break;
    }
    case "DeleteDisbursementRoot": {
      const D40 = await GitHubRead(Env, "data/disbursement/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D40) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/disbursement/" + Msg.Data?.Id + ".json", D40.Sha, "Delete data/disbursement");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/disbursement", JSON.stringify({ Type: "Deletion", Channel: "data/disbursement", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListDisbursementRoot": {
      const L41 = await GitHubList(Env, "data/disbursement");
      Reply(Ws, Msg, L41);
      break;
    }
    case "CreateDisbursementByCustomer": {
      const I42 = Msg.Data?.Id ?? crypto.randomUUID();
      const N42 = { ...Msg.Data, Id: I42 };
      await GitHubWrite(Env, "data/disbursement/" + I42 + ".json", JSON.stringify(N42, null, 2), "Create data/disbursement");
      Reply(Ws, Msg, N42);
      BroadcastToChannel("data/disbursement", JSON.stringify({ Type: "Mutation", Channel: "data/disbursement", Data: N42 }), Ws);
      break;
    }
    case "CreateDisbursementDisbursementById": {
      const I43 = Msg.Data?.Id ?? crypto.randomUUID();
      const N43 = { ...Msg.Data, Id: I43 };
      await GitHubWrite(Env, "data/disbursement/" + I43 + ".json", JSON.stringify(N43, null, 2), "Create data/disbursement");
      Reply(Ws, Msg, N43);
      BroadcastToChannel("data/disbursement", JSON.stringify({ Type: "Mutation", Channel: "data/disbursement", Data: N43 }), Ws);
      break;
    }
    case "DisbursementDisbursementProcess": {
      const E44 = await GitHubRead(Env, "data/disbursement/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E44) { ReplyError(Ws, Msg, "Not found"); break; }
      const U44 = { ...JSON.parse(E44.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/disbursement/" + Msg.Data?.Id + ".json", JSON.stringify(U44, null, 2), "DisbursementDisbursementProcess", E44.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/disbursement", JSON.stringify({ Type: "Mutation", Channel: "data/disbursement", Data: U44 }), Ws);
      break;
    }
    case "ListDisbursementDisbursementById": {
      const R45 = await GitHubRead(Env, "data/disbursement/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R45) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R45.Content));
      break;
    }
    // InferenceEndpoints
    case "CreateInferenceCompletion": {
      const I46 = Msg.Data?.Id ?? crypto.randomUUID();
      const N46 = { ...Msg.Data, Id: I46 };
      await GitHubWrite(Env, "data/inference/" + I46 + ".json", JSON.stringify(N46, null, 2), "Create data/inference");
      Reply(Ws, Msg, N46);
      BroadcastToChannel("data/inference", JSON.stringify({ Type: "Mutation", Channel: "data/inference", Data: N46 }), Ws);
      break;
    }
    case "CreateInferenceEmbedding": {
      const I47 = Msg.Data?.Id ?? crypto.randomUUID();
      const N47 = { ...Msg.Data, Id: I47 };
      await GitHubWrite(Env, "data/inference/" + I47 + ".json", JSON.stringify(N47, null, 2), "Create data/inference");
      Reply(Ws, Msg, N47);
      BroadcastToChannel("data/inference", JSON.stringify({ Type: "Mutation", Channel: "data/inference", Data: N47 }), Ws);
      break;
    }
    case "ListInferenceStatus": {
      const L48 = await GitHubList(Env, "data/inference");
      Reply(Ws, Msg, L48);
      break;
    }
    // InvoiceEndpoints
    case "CreateInvoiceRoot": {
      const I49 = Msg.Data?.Id ?? crypto.randomUUID();
      const N49 = { ...Msg.Data, Id: I49 };
      await GitHubWrite(Env, "data/invoice/" + I49 + ".json", JSON.stringify(N49, null, 2), "Create data/invoice");
      Reply(Ws, Msg, N49);
      BroadcastToChannel("data/invoice", JSON.stringify({ Type: "Mutation", Channel: "data/invoice", Data: N49 }), Ws);
      break;
    }
    case "ListInvoiceRoot": {
      const R50 = await GitHubRead(Env, "data/invoice/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R50) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R50.Content));
      break;
    }
    case "ListInvoiceInvoiceById": {
      const R51 = await GitHubRead(Env, "data/invoice/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R51) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R51.Content));
      break;
    }
    case "DeleteInvoiceInvoiceById": {
      const D52 = await GitHubRead(Env, "data/invoice/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D52) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/invoice/" + Msg.Data?.Id + ".json", D52.Sha, "Delete data/invoice");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/invoice", JSON.stringify({ Type: "Deletion", Channel: "data/invoice", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // KycEndpoints
    case "CreateKycKycCreate": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I53 = Msg.Data?.Id ?? crypto.randomUUID();
      const N53 = { ...Msg.Data, Id: I53 };
      await GitHubWrite(Env, "data/kyc/" + I53 + ".json", JSON.stringify(N53, null, 2), "Create data/kyc");
      Reply(Ws, Msg, N53);
      BroadcastToChannel("data/kyc", JSON.stringify({ Type: "Mutation", Channel: "data/kyc", Data: N53 }), Ws);
      break;
    }
    case "ListKycKycStatus": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R54 = await GitHubRead(Env, "data/kyc/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R54) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R54.Content));
      break;
    }
    case "UpdateKycKycUpdate": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const C55 = await GitHubRead(Env, "data/kyc/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C55) { ReplyError(Ws, Msg, "Not found"); break; }
      const M55 = { ...JSON.parse(C55.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/kyc/" + Msg.Data?.Id + ".json", JSON.stringify(M55, null, 2), "Update data/kyc", C55.Sha);
      Reply(Ws, Msg, M55);
      BroadcastToChannel("data/kyc", JSON.stringify({ Type: "Mutation", Channel: "data/kyc", Data: M55 }), Ws);
      break;
    }
    case "ListKycKycList": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L56 = await GitHubList(Env, "data/kyc");
      Reply(Ws, Msg, L56);
      break;
    }
    case "DeleteKycKycDelete": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D57 = await GitHubRead(Env, "data/kyc/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D57) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/kyc/" + Msg.Data?.Id + ".json", D57.Sha, "Delete data/kyc");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/kyc", JSON.stringify({ Type: "Deletion", Channel: "data/kyc", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // LeaderboardEndpoints
    case "ListLeaderboardApiLeaderboard": {
      const L58 = await GitHubList(Env, "data/leaderboard");
      Reply(Ws, Msg, L58);
      break;
    }
    case "GetLeaderboard": {
      const R59 = await GitHubRead(Env, "data/leaderboard/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R59) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R59.Content));
      break;
    }
    // MayaConnectEndpoints
    case "ListMayaConnectAuthorize": {
      const L60 = await GitHubList(Env, "data/maya-connect");
      Reply(Ws, Msg, L60);
      break;
    }
    case "CreateMayaConnectToken": {
      const I61 = Msg.Data?.Id ?? crypto.randomUUID();
      const N61 = { ...Msg.Data, Id: I61 };
      await GitHubWrite(Env, "data/maya-connect/" + I61 + ".json", JSON.stringify(N61, null, 2), "Create data/maya-connect");
      Reply(Ws, Msg, N61);
      BroadcastToChannel("data/maya-connect", JSON.stringify({ Type: "Mutation", Channel: "data/maya-connect", Data: N61 }), Ws);
      break;
    }
    case "CreateMayaConnectRefresh": {
      const I62 = Msg.Data?.Id ?? crypto.randomUUID();
      const N62 = { ...Msg.Data, Id: I62 };
      await GitHubWrite(Env, "data/maya-connect/" + I62 + ".json", JSON.stringify(N62, null, 2), "Create data/maya-connect");
      Reply(Ws, Msg, N62);
      BroadcastToChannel("data/maya-connect", JSON.stringify({ Type: "Mutation", Channel: "data/maya-connect", Data: N62 }), Ws);
      break;
    }
    case "ListMayaConnectUserInfo": {
      const L63 = await GitHubList(Env, "data/maya-connect");
      Reply(Ws, Msg, L63);
      break;
    }
    case "ListMayaConnectJwk": {
      const L64 = await GitHubList(Env, "data/maya-connect");
      Reply(Ws, Msg, L64);
      break;
    }
    // P3PaymentEndpoints
    case "CreateP3PaymentP3Pay": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I65 = Msg.Data?.Id ?? crypto.randomUUID();
      const N65 = { ...Msg.Data, Id: I65 };
      await GitHubWrite(Env, "data/p3-payment/" + I65 + ".json", JSON.stringify(N65, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N65);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N65 }), Ws);
      break;
    }
    case "CreateP3PaymentP3Authorize": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I66 = Msg.Data?.Id ?? crypto.randomUUID();
      const N66 = { ...Msg.Data, Id: I66 };
      await GitHubWrite(Env, "data/p3-payment/" + I66 + ".json", JSON.stringify(N66, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N66);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N66 }), Ws);
      break;
    }
    case "P3PaymentP3Capture": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E67 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E67) { ReplyError(Ws, Msg, "Not found"); break; }
      const U67 = { ...JSON.parse(E67.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/p3-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U67, null, 2), "P3PaymentP3Capture", E67.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: U67 }), Ws);
      break;
    }
    case "P3PaymentP3FinalCapture": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E68 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E68) { ReplyError(Ws, Msg, "Not found"); break; }
      const U68 = { ...JSON.parse(E68.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/p3-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U68, null, 2), "P3PaymentP3FinalCapture", E68.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: U68 }), Ws);
      break;
    }
    case "P3PaymentP3Void": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E69 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E69) { ReplyError(Ws, Msg, "Not found"); break; }
      const U69 = { ...JSON.parse(E69.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/p3-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U69, null, 2), "P3PaymentP3Void", E69.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: U69 }), Ws);
      break;
    }
    case "P3PaymentP3Refund": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E70 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E70) { ReplyError(Ws, Msg, "Not found"); break; }
      const U70 = { ...JSON.parse(E70.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/p3-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U70, null, 2), "P3PaymentP3Refund", E70.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: U70 }), Ws);
      break;
    }
    case "ListP3PaymentP3TransactionById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L71 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L71);
      break;
    }
    case "ListP3PaymentP3Transactions": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R72 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R72) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R72.Content));
      break;
    }
    case "CreateP3PaymentP3Balance": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I73 = Msg.Data?.Id ?? crypto.randomUUID();
      const N73 = { ...Msg.Data, Id: I73 };
      await GitHubWrite(Env, "data/p3-payment/" + I73 + ".json", JSON.stringify(N73, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N73);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N73 }), Ws);
      break;
    }
    case "ListP3PaymentP3Ping": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L74 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L74);
      break;
    }
    // P3PaymentEndpoints.Bin
    case "ListP3PaymentBinP3BinByValue": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L75 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L75);
      break;
    }
    case "CreateP3PaymentBinP3BinsQuery": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I76 = Msg.Data?.Id ?? crypto.randomUUID();
      const N76 = { ...Msg.Data, Id: I76 };
      await GitHubWrite(Env, "data/p3-payment/" + I76 + ".json", JSON.stringify(N76, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N76);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N76 }), Ws);
      break;
    }
    case "ListP3PaymentBinP3BinPatterns": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L77 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L77);
      break;
    }
    case "ListP3PaymentBinP3BinDelta": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L78 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L78);
      break;
    }
    case "CreateP3PaymentBinP3ApiKeys": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I79 = Msg.Data?.Id ?? crypto.randomUUID();
      const N79 = { ...Msg.Data, Id: I79 };
      await GitHubWrite(Env, "data/p3-payment/" + I79 + ".json", JSON.stringify(N79, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N79);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N79 }), Ws);
      break;
    }
    case "ListP3PaymentBinP3ApiKeyById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R80 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R80) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R80.Content));
      break;
    }
    case "ListP3PaymentBinP3ApiKeys": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L81 = await GitHubList(Env, "data/p3-payment");
      Reply(Ws, Msg, L81);
      break;
    }
    case "DeleteP3PaymentBinP3ApiKeyById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D82 = await GitHubRead(Env, "data/p3-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D82) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/p3-payment/" + Msg.Data?.Id + ".json", D82.Sha, "Delete data/p3-payment");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Deletion", Channel: "data/p3-payment", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // P3PaymentEndpoints.Recurring
    case "CreateP3PaymentRecurringP3Recurring": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I83 = Msg.Data?.Id ?? crypto.randomUUID();
      const N83 = { ...Msg.Data, Id: I83 };
      await GitHubWrite(Env, "data/p3-payment/" + I83 + ".json", JSON.stringify(N83, null, 2), "Create data/p3-payment");
      Reply(Ws, Msg, N83);
      BroadcastToChannel("data/p3-payment", JSON.stringify({ Type: "Mutation", Channel: "data/p3-payment", Data: N83 }), Ws);
      break;
    }
    // PaymentEndpoints
    case "CreatePaymentApiPaymentsCheckout": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I84 = Msg.Data?.Id ?? crypto.randomUUID();
      const N84 = { ...Msg.Data, Id: I84 };
      await GitHubWrite(Env, "data/payment/" + I84 + ".json", JSON.stringify(N84, null, 2), "Create data/payment");
      Reply(Ws, Msg, N84);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N84 }), Ws);
      break;
    }
    case "CreatePaymentApiPaymentsWebhook": {
      const I85 = Msg.Data?.Id ?? crypto.randomUUID();
      const N85 = { ...Msg.Data, Id: I85 };
      await GitHubWrite(Env, "data/payment/" + I85 + ".json", JSON.stringify(N85, null, 2), "Create data/payment");
      Reply(Ws, Msg, N85);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N85 }), Ws);
      break;
    }
    case "GetPayment": {
      const R86 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R86) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R86.Content));
      break;
    }
    // PaymentEndpoints.Operations
    case "ListPaymentOperationsPaymentVoids": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R87 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R87) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R87.Content));
      break;
    }
    case "ListPaymentOperationsPaymentVoidById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R88 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R88) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R88.Content));
      break;
    }
    case "ListPaymentOperationsPaymentRefunds": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R89 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R89) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R89.Content));
      break;
    }
    case "ListPaymentOperationsPaymentRefundById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R90 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R90) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R90.Content));
      break;
    }
    case "PaymentOperationsPaymentCapture": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E91 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E91) { ReplyError(Ws, Msg, "Not found"); break; }
      const U91 = { ...JSON.parse(E91.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/payment/" + Msg.Data?.Id + ".json", JSON.stringify(U91, null, 2), "PaymentOperationsPaymentCapture", E91.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: U91 }), Ws);
      break;
    }
    case "PaymentOperationsPaymentCancel": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E92 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E92) { ReplyError(Ws, Msg, "Not found"); break; }
      const U92 = { ...JSON.parse(E92.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/payment/" + Msg.Data?.Id + ".json", JSON.stringify(U92, null, 2), "PaymentOperationsPaymentCancel", E92.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: U92 }), Ws);
      break;
    }
    case "CreatePaymentOperationsFees": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I93 = Msg.Data?.Id ?? crypto.randomUUID();
      const N93 = { ...Msg.Data, Id: I93 };
      await GitHubWrite(Env, "data/payment/" + I93 + ".json", JSON.stringify(N93, null, 2), "Create data/payment");
      Reply(Ws, Msg, N93);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N93 }), Ws);
      break;
    }
    // PaymentEndpoints.Vault
    case "CreatePaymentVaultCustomerCardsList": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I94 = Msg.Data?.Id ?? crypto.randomUUID();
      const N94 = { ...Msg.Data, Id: I94 };
      await GitHubWrite(Env, "data/payment/" + I94 + ".json", JSON.stringify(N94, null, 2), "Create data/payment");
      Reply(Ws, Msg, N94);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N94 }), Ws);
      break;
    }
    case "ListPaymentVaultCustomerCardsList": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R95 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R95) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R95.Content));
      break;
    }
    case "ListPaymentVaultCustomerCardByToken": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R96 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R96) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R96.Content));
      break;
    }
    case "DeletePaymentVaultCustomerCardByToken": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D97 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D97) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/payment/" + Msg.Data?.Id + ".json", D97.Sha, "Delete data/payment");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Deletion", Channel: "data/payment", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "CreatePaymentVaultVaultPay": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I98 = Msg.Data?.Id ?? crypto.randomUUID();
      const N98 = { ...Msg.Data, Id: I98 };
      await GitHubWrite(Env, "data/payment/" + I98 + ".json", JSON.stringify(N98, null, 2), "Create data/payment");
      Reply(Ws, Msg, N98);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N98 }), Ws);
      break;
    }
    case "CreatePaymentVaultWebhooks": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I99 = Msg.Data?.Id ?? crypto.randomUUID();
      const N99 = { ...Msg.Data, Id: I99 };
      await GitHubWrite(Env, "data/payment/" + I99 + ".json", JSON.stringify(N99, null, 2), "Create data/payment");
      Reply(Ws, Msg, N99);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N99 }), Ws);
      break;
    }
    case "ListPaymentVaultWebhooks": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L100 = await GitHubList(Env, "data/payment");
      Reply(Ws, Msg, L100);
      break;
    }
    case "UpdatePaymentVaultWebhooksById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const C101 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C101) { ReplyError(Ws, Msg, "Not found"); break; }
      const M101 = { ...JSON.parse(C101.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/payment/" + Msg.Data?.Id + ".json", JSON.stringify(M101, null, 2), "Update data/payment", C101.Sha);
      Reply(Ws, Msg, M101);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: M101 }), Ws);
      break;
    }
    case "DeletePaymentVaultWebhooksById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D102 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D102) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/payment/" + Msg.Data?.Id + ".json", D102.Sha, "Delete data/payment");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Deletion", Channel: "data/payment", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // PaymentRecordEndpoints
    case "ListPaymentRecordPaymentById": {
      const R103 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R103) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R103.Content));
      break;
    }
    case "ListPaymentRecordByPayer": {
      const R104 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R104) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R104.Content));
      break;
    }
    case "ListPaymentRecordByTask": {
      const R105 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R105) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R105.Content));
      break;
    }
    case "ListPaymentRecordByMayaPaymentId": {
      const R106 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R106) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R106.Content));
      break;
    }
    case "CreatePaymentRecordRoot": {
      const I107 = Msg.Data?.Id ?? crypto.randomUUID();
      const N107 = { ...Msg.Data, Id: I107 };
      await GitHubWrite(Env, "data/payment-record/" + I107 + ".json", JSON.stringify(N107, null, 2), "Create data/payment-record");
      Reply(Ws, Msg, N107);
      BroadcastToChannel("data/payment-record", JSON.stringify({ Type: "Mutation", Channel: "data/payment-record", Data: N107 }), Ws);
      break;
    }
    case "UpdatePaymentRecordPaymentById": {
      const C108 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C108) { ReplyError(Ws, Msg, "Not found"); break; }
      const M108 = { ...JSON.parse(C108.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/payment-record/" + Msg.Data?.Id + ".json", JSON.stringify(M108, null, 2), "Update data/payment-record", C108.Sha);
      Reply(Ws, Msg, M108);
      BroadcastToChannel("data/payment-record", JSON.stringify({ Type: "Mutation", Channel: "data/payment-record", Data: M108 }), Ws);
      break;
    }
    case "DeletePaymentRecordPaymentById": {
      const D109 = await GitHubRead(Env, "data/payment-record/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D109) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/payment-record/" + Msg.Data?.Id + ".json", D109.Sha, "Delete data/payment-record");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/payment-record", JSON.stringify({ Type: "Deletion", Channel: "data/payment-record", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // PaymentV2Endpoints
    case "CreatePaymentV2Root": {
      const I110 = Msg.Data?.Id ?? crypto.randomUUID();
      const N110 = { ...Msg.Data, Id: I110 };
      await GitHubWrite(Env, "data/payment/" + I110 + ".json", JSON.stringify(N110, null, 2), "Create data/payment");
      Reply(Ws, Msg, N110);
      BroadcastToChannel("data/payment", JSON.stringify({ Type: "Mutation", Channel: "data/payment", Data: N110 }), Ws);
      break;
    }
    case "ListPaymentV2PaymentV2ById": {
      const R111 = await GitHubRead(Env, "data/payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R111) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R111.Content));
      break;
    }
    // PlainTextDbEndpoints
    case "ListPlainTextDbCollection": {
      const L112 = await GitHubList(Env, "data/plain-text-db");
      Reply(Ws, Msg, L112);
      break;
    }
    case "ListPlainTextDbCollectionItem": {
      const R113 = await GitHubRead(Env, "data/plain-text-db/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R113) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R113.Content));
      break;
    }
    case "UpdatePlainTextDbCollectionItem": {
      const C114 = await GitHubRead(Env, "data/plain-text-db/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C114) { ReplyError(Ws, Msg, "Not found"); break; }
      const M114 = { ...JSON.parse(C114.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/plain-text-db/" + Msg.Data?.Id + ".json", JSON.stringify(M114, null, 2), "Update data/plain-text-db", C114.Sha);
      Reply(Ws, Msg, M114);
      BroadcastToChannel("data/plain-text-db", JSON.stringify({ Type: "Mutation", Channel: "data/plain-text-db", Data: M114 }), Ws);
      break;
    }
    case "DeletePlainTextDbCollectionItem": {
      const D115 = await GitHubRead(Env, "data/plain-text-db/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D115) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/plain-text-db/" + Msg.Data?.Id + ".json", D115.Sha, "Delete data/plain-text-db");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/plain-text-db", JSON.stringify({ Type: "Deletion", Channel: "data/plain-text-db", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListPlainTextDbCollectionExport": {
      const L116 = await GitHubList(Env, "data/plain-text-db");
      Reply(Ws, Msg, L116);
      break;
    }
    case "CreatePlainTextDbCollectionImport": {
      const I117 = Msg.Data?.Id ?? crypto.randomUUID();
      const N117 = { ...Msg.Data, Id: I117 };
      await GitHubWrite(Env, "data/plain-text-db/" + I117 + ".json", JSON.stringify(N117, null, 2), "Create data/plain-text-db");
      Reply(Ws, Msg, N117);
      BroadcastToChannel("data/plain-text-db", JSON.stringify({ Type: "Mutation", Channel: "data/plain-text-db", Data: N117 }), Ws);
      break;
    }
    // PullRequestEndpoints
    case "GetPullRequest": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R118 = await GitHubRead(Env, "data/pull-request/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R118) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R118.Content));
      break;
    }
    case "GetPullRequestDeveloper": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R119 = await GitHubRead(Env, "data/pull-request/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R119) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R119.Content));
      break;
    }
    case "CreatePullRequest": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I120 = Msg.Data?.Id ?? crypto.randomUUID();
      const N120 = { ...Msg.Data, Id: I120 };
      await GitHubWrite(Env, "data/pull-request/" + I120 + ".json", JSON.stringify(N120, null, 2), "Create data/pull-request");
      Reply(Ws, Msg, N120);
      BroadcastToChannel("data/pull-request", JSON.stringify({ Type: "Mutation", Channel: "data/pull-request", Data: N120 }), Ws);
      break;
    }
    case "PullRequestApprove": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E121 = await GitHubRead(Env, "data/pull-request/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E121) { ReplyError(Ws, Msg, "Not found"); break; }
      const U121 = { ...JSON.parse(E121.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/pull-request/" + Msg.Data?.Id + ".json", JSON.stringify(U121, null, 2), "PullRequestApprove", E121.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/pull-request", JSON.stringify({ Type: "Mutation", Channel: "data/pull-request", Data: U121 }), Ws);
      break;
    }
    case "PullRequestReject": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E122 = await GitHubRead(Env, "data/pull-request/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E122) { ReplyError(Ws, Msg, "Not found"); break; }
      const U122 = { ...JSON.parse(E122.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/pull-request/" + Msg.Data?.Id + ".json", JSON.stringify(U122, null, 2), "PullRequestReject", E122.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/pull-request", JSON.stringify({ Type: "Mutation", Channel: "data/pull-request", Data: U122 }), Ws);
      break;
    }
    // QrPaymentEndpoints
    case "CreateQrPaymentQrDynamic": {
      const I123 = Msg.Data?.Id ?? crypto.randomUUID();
      const N123 = { ...Msg.Data, Id: I123 };
      await GitHubWrite(Env, "data/qr-payment/" + I123 + ".json", JSON.stringify(N123, null, 2), "Create data/qr-payment");
      Reply(Ws, Msg, N123);
      BroadcastToChannel("data/qr-payment", JSON.stringify({ Type: "Mutation", Channel: "data/qr-payment", Data: N123 }), Ws);
      break;
    }
    case "CreateQrPaymentQrStatic": {
      const I124 = Msg.Data?.Id ?? crypto.randomUUID();
      const N124 = { ...Msg.Data, Id: I124 };
      await GitHubWrite(Env, "data/qr-payment/" + I124 + ".json", JSON.stringify(N124, null, 2), "Create data/qr-payment");
      Reply(Ws, Msg, N124);
      BroadcastToChannel("data/qr-payment", JSON.stringify({ Type: "Mutation", Channel: "data/qr-payment", Data: N124 }), Ws);
      break;
    }
    case "QrPaymentQrExecute": {
      const E125 = await GitHubRead(Env, "data/qr-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E125) { ReplyError(Ws, Msg, "Not found"); break; }
      const U125 = { ...JSON.parse(E125.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/qr-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U125, null, 2), "QrPaymentQrExecute", E125.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/qr-payment", JSON.stringify({ Type: "Mutation", Channel: "data/qr-payment", Data: U125 }), Ws);
      break;
    }
    case "ListQrPaymentQrStatus": {
      const R126 = await GitHubRead(Env, "data/qr-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R126) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R126.Content));
      break;
    }
    // RefundEndpoints
    case "ListRefundRefundById": {
      const R127 = await GitHubRead(Env, "data/refund/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R127) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R127.Content));
      break;
    }
    case "ListRefundRefundsByPayment": {
      const R128 = await GitHubRead(Env, "data/refund/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R128) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R128.Content));
      break;
    }
    case "CreateRefundRoot": {
      const I129 = Msg.Data?.Id ?? crypto.randomUUID();
      const N129 = { ...Msg.Data, Id: I129 };
      await GitHubWrite(Env, "data/refund/" + I129 + ".json", JSON.stringify(N129, null, 2), "Create data/refund");
      Reply(Ws, Msg, N129);
      BroadcastToChannel("data/refund", JSON.stringify({ Type: "Mutation", Channel: "data/refund", Data: N129 }), Ws);
      break;
    }
    case "DeleteRefundRefundById": {
      const D130 = await GitHubRead(Env, "data/refund/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D130) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/refund/" + Msg.Data?.Id + ".json", D130.Sha, "Delete data/refund");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/refund", JSON.stringify({ Type: "Deletion", Channel: "data/refund", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // RemittanceEndpoints
    case "CreateRemittanceRoot": {
      const I131 = Msg.Data?.Id ?? crypto.randomUUID();
      const N131 = { ...Msg.Data, Id: I131 };
      await GitHubWrite(Env, "data/remittance/" + I131 + ".json", JSON.stringify(N131, null, 2), "Create data/remittance");
      Reply(Ws, Msg, N131);
      BroadcastToChannel("data/remittance", JSON.stringify({ Type: "Mutation", Channel: "data/remittance", Data: N131 }), Ws);
      break;
    }
    case "RemittanceRemittanceExecute": {
      const E132 = await GitHubRead(Env, "data/remittance/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E132) { ReplyError(Ws, Msg, "Not found"); break; }
      const U132 = { ...JSON.parse(E132.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/remittance/" + Msg.Data?.Id + ".json", JSON.stringify(U132, null, 2), "RemittanceRemittanceExecute", E132.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/remittance", JSON.stringify({ Type: "Mutation", Channel: "data/remittance", Data: U132 }), Ws);
      break;
    }
    case "ListRemittanceRemittanceStatus": {
      const L133 = await GitHubList(Env, "data/remittance");
      Reply(Ws, Msg, L133);
      break;
    }
    // RepositoryEndpoints
    case "ListRepositoryByOwner": {
      const R134 = await GitHubRead(Env, "data/repository/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R134) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R134.Content));
      break;
    }
    case "ListRepositoryRepositoryById": {
      const R135 = await GitHubRead(Env, "data/repository/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R135) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R135.Content));
      break;
    }
    case "CreateRepositoryRoot": {
      const I136 = Msg.Data?.Id ?? crypto.randomUUID();
      const N136 = { ...Msg.Data, Id: I136 };
      await GitHubWrite(Env, "data/repository/" + I136 + ".json", JSON.stringify(N136, null, 2), "Create data/repository");
      Reply(Ws, Msg, N136);
      BroadcastToChannel("data/repository", JSON.stringify({ Type: "Mutation", Channel: "data/repository", Data: N136 }), Ws);
      break;
    }
    case "UpdateRepositoryRepositoryById": {
      const C137 = await GitHubRead(Env, "data/repository/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C137) { ReplyError(Ws, Msg, "Not found"); break; }
      const M137 = { ...JSON.parse(C137.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/repository/" + Msg.Data?.Id + ".json", JSON.stringify(M137, null, 2), "Update data/repository", C137.Sha);
      Reply(Ws, Msg, M137);
      BroadcastToChannel("data/repository", JSON.stringify({ Type: "Mutation", Channel: "data/repository", Data: M137 }), Ws);
      break;
    }
    case "DeleteRepositoryRepositoryById": {
      const D138 = await GitHubRead(Env, "data/repository/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D138) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/repository/" + Msg.Data?.Id + ".json", D138.Sha, "Delete data/repository");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/repository", JSON.stringify({ Type: "Deletion", Channel: "data/repository", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // ReviewCommentEndpoints
    case "ListReviewCommentReviewCommentsByPr": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R139 = await GitHubRead(Env, "data/review-comment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R139) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R139.Content));
      break;
    }
    case "CreateReviewCommentRoot": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I140 = Msg.Data?.Id ?? crypto.randomUUID();
      const N140 = { ...Msg.Data, Id: I140 };
      await GitHubWrite(Env, "data/review-comment/" + I140 + ".json", JSON.stringify(N140, null, 2), "Create data/review-comment");
      Reply(Ws, Msg, N140);
      BroadcastToChannel("data/review-comment", JSON.stringify({ Type: "Mutation", Channel: "data/review-comment", Data: N140 }), Ws);
      break;
    }
    case "ReviewCommentReviewCommentResolve": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E141 = await GitHubRead(Env, "data/review-comment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E141) { ReplyError(Ws, Msg, "Not found"); break; }
      const U141 = { ...JSON.parse(E141.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/review-comment/" + Msg.Data?.Id + ".json", JSON.stringify(U141, null, 2), "ReviewCommentReviewCommentResolve", E141.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/review-comment", JSON.stringify({ Type: "Mutation", Channel: "data/review-comment", Data: U141 }), Ws);
      break;
    }
    case "DeleteReviewCommentReviewCommentById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D142 = await GitHubRead(Env, "data/review-comment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D142) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/review-comment/" + Msg.Data?.Id + ".json", D142.Sha, "Delete data/review-comment");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/review-comment", JSON.stringify({ Type: "Deletion", Channel: "data/review-comment", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // SourceCodeEndpoints
    case "CreateSourceCodeSourceUpload": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I143 = Msg.Data?.Id ?? crypto.randomUUID();
      const N143 = { ...Msg.Data, Id: I143 };
      await GitHubWrite(Env, "data/source-code/" + I143 + ".json", JSON.stringify(N143, null, 2), "Create data/source-code");
      Reply(Ws, Msg, N143);
      BroadcastToChannel("data/source-code", JSON.stringify({ Type: "Mutation", Channel: "data/source-code", Data: N143 }), Ws);
      break;
    }
    case "ListSourceCodeSourceFiles": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R144 = await GitHubRead(Env, "data/source-code/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R144) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R144.Content));
      break;
    }
    case "CreateSourceCodeSourceModify": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I145 = Msg.Data?.Id ?? crypto.randomUUID();
      const N145 = { ...Msg.Data, Id: I145 };
      await GitHubWrite(Env, "data/source-code/" + I145 + ".json", JSON.stringify(N145, null, 2), "Create data/source-code");
      Reply(Ws, Msg, N145);
      BroadcastToChannel("data/source-code", JSON.stringify({ Type: "Mutation", Channel: "data/source-code", Data: N145 }), Ws);
      break;
    }
    case "ListSourceCodeSourceModifiedFiles": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R146 = await GitHubRead(Env, "data/source-code/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R146) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R146.Content));
      break;
    }
    case "ListSourceCodeSourceDiff": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R147 = await GitHubRead(Env, "data/source-code/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R147) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R147.Content));
      break;
    }
    case "DeleteSourceCodeSourceDelete": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D148 = await GitHubRead(Env, "data/source-code/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D148) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/source-code/" + Msg.Data?.Id + ".json", D148.Sha, "Delete data/source-code");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/source-code", JSON.stringify({ Type: "Deletion", Channel: "data/source-code", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // SprintEndpoints
    case "ListSprintRoot": {
      const L149 = await GitHubList(Env, "data/sprint");
      Reply(Ws, Msg, L149);
      break;
    }
    case "ListSprintSprintById": {
      const R150 = await GitHubRead(Env, "data/sprint/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R150) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R150.Content));
      break;
    }
    case "ListSprintByOwner": {
      const R151 = await GitHubRead(Env, "data/sprint/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R151) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R151.Content));
      break;
    }
    case "CreateSprintRoot": {
      const I152 = Msg.Data?.Id ?? crypto.randomUUID();
      const N152 = { ...Msg.Data, Id: I152 };
      await GitHubWrite(Env, "data/sprint/" + I152 + ".json", JSON.stringify(N152, null, 2), "Create data/sprint");
      Reply(Ws, Msg, N152);
      BroadcastToChannel("data/sprint", JSON.stringify({ Type: "Mutation", Channel: "data/sprint", Data: N152 }), Ws);
      break;
    }
    case "UpdateSprintSprintById": {
      const C153 = await GitHubRead(Env, "data/sprint/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C153) { ReplyError(Ws, Msg, "Not found"); break; }
      const M153 = { ...JSON.parse(C153.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/sprint/" + Msg.Data?.Id + ".json", JSON.stringify(M153, null, 2), "Update data/sprint", C153.Sha);
      Reply(Ws, Msg, M153);
      BroadcastToChannel("data/sprint", JSON.stringify({ Type: "Mutation", Channel: "data/sprint", Data: M153 }), Ws);
      break;
    }
    case "DeleteSprintSprintById": {
      const D154 = await GitHubRead(Env, "data/sprint/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D154) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/sprint/" + Msg.Data?.Id + ".json", D154.Sha, "Delete data/sprint");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/sprint", JSON.stringify({ Type: "Deletion", Channel: "data/sprint", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // SubscriptionEndpoints
    case "CreateSubscriptionRoot": {
      const I155 = Msg.Data?.Id ?? crypto.randomUUID();
      const N155 = { ...Msg.Data, Id: I155 };
      await GitHubWrite(Env, "data/subscription/" + I155 + ".json", JSON.stringify(N155, null, 2), "Create data/subscription");
      Reply(Ws, Msg, N155);
      BroadcastToChannel("data/subscription", JSON.stringify({ Type: "Mutation", Channel: "data/subscription", Data: N155 }), Ws);
      break;
    }
    case "ListSubscriptionRoot": {
      const R156 = await GitHubRead(Env, "data/subscription/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R156) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R156.Content));
      break;
    }
    case "ListSubscriptionSubscriptionById": {
      const R157 = await GitHubRead(Env, "data/subscription/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R157) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R157.Content));
      break;
    }
    case "DeleteSubscriptionSubscriptionById": {
      const D158 = await GitHubRead(Env, "data/subscription/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D158) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/subscription/" + Msg.Data?.Id + ".json", D158.Sha, "Delete data/subscription");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/subscription", JSON.stringify({ Type: "Deletion", Channel: "data/subscription", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListSubscriptionSubscriptionPayments": {
      const R159 = await GitHubRead(Env, "data/subscription/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R159) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R159.Content));
      break;
    }
    // SyncEndpoints
    case "SyncSyncExecute": {
      const E160 = await GitHubRead(Env, "data/sync/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E160) { ReplyError(Ws, Msg, "Not found"); break; }
      const U160 = { ...JSON.parse(E160.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/sync/" + Msg.Data?.Id + ".json", JSON.stringify(U160, null, 2), "SyncSyncExecute", E160.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/sync", JSON.stringify({ Type: "Mutation", Channel: "data/sync", Data: U160 }), Ws);
      break;
    }
    case "ListSyncStatus": {
      const L161 = await GitHubList(Env, "data/sync");
      Reply(Ws, Msg, L161);
      break;
    }
    case "CreateSyncSyncRegister": {
      const I162 = Msg.Data?.Id ?? crypto.randomUUID();
      const N162 = { ...Msg.Data, Id: I162 };
      await GitHubWrite(Env, "data/sync/" + I162 + ".json", JSON.stringify(N162, null, 2), "Create data/sync");
      Reply(Ws, Msg, N162);
      BroadcastToChannel("data/sync", JSON.stringify({ Type: "Mutation", Channel: "data/sync", Data: N162 }), Ws);
      break;
    }
    // TaskEndpoints
    case "ListTask": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L163 = await GitHubList(Env, "data/task");
      Reply(Ws, Msg, L163);
      break;
    }
    case "GetTask": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R164 = await GitHubRead(Env, "data/task/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R164) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R164.Content));
      break;
    }
    case "CreateTask": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I165 = Msg.Data?.Id ?? crypto.randomUUID();
      const N165 = { ...Msg.Data, Id: I165 };
      await GitHubWrite(Env, "data/task/" + I165 + ".json", JSON.stringify(N165, null, 2), "Create data/task");
      Reply(Ws, Msg, N165);
      BroadcastToChannel("data/task", JSON.stringify({ Type: "Mutation", Channel: "data/task", Data: N165 }), Ws);
      break;
    }
    case "TaskClaim": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const E166 = await GitHubRead(Env, "data/task/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E166) { ReplyError(Ws, Msg, "Not found"); break; }
      const U166 = { ...JSON.parse(E166.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/task/" + Msg.Data?.Id + ".json", JSON.stringify(U166, null, 2), "TaskClaim", E166.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/task", JSON.stringify({ Type: "Mutation", Channel: "data/task", Data: U166 }), Ws);
      break;
    }
    // TranscriptionEndpoints
    case "CreateTranscriptionTranscribe": {
      const I167 = Msg.Data?.Id ?? crypto.randomUUID();
      const N167 = { ...Msg.Data, Id: I167 };
      await GitHubWrite(Env, "data/transcription/" + I167 + ".json", JSON.stringify(N167, null, 2), "Create data/transcription");
      Reply(Ws, Msg, N167);
      BroadcastToChannel("data/transcription", JSON.stringify({ Type: "Mutation", Channel: "data/transcription", Data: N167 }), Ws);
      break;
    }
    case "ListTranscriptionStatus": {
      const L168 = await GitHubList(Env, "data/transcription");
      Reply(Ws, Msg, L168);
      break;
    }
    // UserEndpoints
    case "ListUserRoot": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const L169 = await GitHubList(Env, "data/user");
      Reply(Ws, Msg, L169);
      break;
    }
    case "ListUserUserById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const R170 = await GitHubRead(Env, "data/user/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R170) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R170.Content));
      break;
    }
    case "UpdateUserUserById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const C171 = await GitHubRead(Env, "data/user/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C171) { ReplyError(Ws, Msg, "Not found"); break; }
      const M171 = { ...JSON.parse(C171.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/user/" + Msg.Data?.Id + ".json", JSON.stringify(M171, null, 2), "Update data/user", C171.Sha);
      Reply(Ws, Msg, M171);
      BroadcastToChannel("data/user", JSON.stringify({ Type: "Mutation", Channel: "data/user", Data: M171 }), Ws);
      break;
    }
    case "CreateUserKyc": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const I172 = Msg.Data?.Id ?? crypto.randomUUID();
      const N172 = { ...Msg.Data, Id: I172 };
      await GitHubWrite(Env, "data/user/" + I172 + ".json", JSON.stringify(N172, null, 2), "Create data/user");
      Reply(Ws, Msg, N172);
      BroadcastToChannel("data/user", JSON.stringify({ Type: "Mutation", Channel: "data/user", Data: N172 }), Ws);
      break;
    }
    case "DeleteUserUserById": {
      if (!RequireAuth(Ws, Msg, Client)) break;
      const D173 = await GitHubRead(Env, "data/user/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D173) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/user/" + Msg.Data?.Id + ".json", D173.Sha, "Delete data/user");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/user", JSON.stringify({ Type: "Deletion", Channel: "data/user", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // VectorSearchEndpoints
    case "CreateVectorSearchIndex": {
      const I174 = Msg.Data?.Id ?? crypto.randomUUID();
      const N174 = { ...Msg.Data, Id: I174 };
      await GitHubWrite(Env, "data/vector-search/" + I174 + ".json", JSON.stringify(N174, null, 2), "Create data/vector-search");
      Reply(Ws, Msg, N174);
      BroadcastToChannel("data/vector-search", JSON.stringify({ Type: "Mutation", Channel: "data/vector-search", Data: N174 }), Ws);
      break;
    }
    case "CreateVectorSearchQuery": {
      const I175 = Msg.Data?.Id ?? crypto.randomUUID();
      const N175 = { ...Msg.Data, Id: I175 };
      await GitHubWrite(Env, "data/vector-search/" + I175 + ".json", JSON.stringify(N175, null, 2), "Create data/vector-search");
      Reply(Ws, Msg, N175);
      BroadcastToChannel("data/vector-search", JSON.stringify({ Type: "Mutation", Channel: "data/vector-search", Data: N175 }), Ws);
      break;
    }
    case "DeleteVectorSearchVectorById": {
      const D176 = await GitHubRead(Env, "data/vector-search/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D176) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/vector-search/" + Msg.Data?.Id + ".json", D176.Sha, "Delete data/vector-search");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/vector-search", JSON.stringify({ Type: "Deletion", Channel: "data/vector-search", Id: Msg.Data?.Id }), Ws);
      break;
    }
    case "ListVectorSearchCount": {
      const L177 = await GitHubList(Env, "data/vector-search");
      Reply(Ws, Msg, L177);
      break;
    }
    // VoidEndpoints
    case "ListVoidVoidsByPayment": {
      const R178 = await GitHubRead(Env, "data/void/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R178) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R178.Content));
      break;
    }
    case "ListVoidVoidById": {
      const R179 = await GitHubRead(Env, "data/void/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R179) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R179.Content));
      break;
    }
    case "CreateVoidRoot": {
      const I180 = Msg.Data?.Id ?? crypto.randomUUID();
      const N180 = { ...Msg.Data, Id: I180 };
      await GitHubWrite(Env, "data/void/" + I180 + ".json", JSON.stringify(N180, null, 2), "Create data/void");
      Reply(Ws, Msg, N180);
      BroadcastToChannel("data/void", JSON.stringify({ Type: "Mutation", Channel: "data/void", Data: N180 }), Ws);
      break;
    }
    case "UpdateVoidVoidById": {
      const C181 = await GitHubRead(Env, "data/void/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C181) { ReplyError(Ws, Msg, "Not found"); break; }
      const M181 = { ...JSON.parse(C181.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/void/" + Msg.Data?.Id + ".json", JSON.stringify(M181, null, 2), "Update data/void", C181.Sha);
      Reply(Ws, Msg, M181);
      BroadcastToChannel("data/void", JSON.stringify({ Type: "Mutation", Channel: "data/void", Data: M181 }), Ws);
      break;
    }
    case "DeleteVoidVoidById": {
      const D182 = await GitHubRead(Env, "data/void/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D182) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/void/" + Msg.Data?.Id + ".json", D182.Sha, "Delete data/void");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/void", JSON.stringify({ Type: "Deletion", Channel: "data/void", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // WalletPaymentEndpoints
    case "CreateWalletPaymentRoot": {
      const I183 = Msg.Data?.Id ?? crypto.randomUUID();
      const N183 = { ...Msg.Data, Id: I183 };
      await GitHubWrite(Env, "data/wallet-payment/" + I183 + ".json", JSON.stringify(N183, null, 2), "Create data/wallet-payment");
      Reply(Ws, Msg, N183);
      BroadcastToChannel("data/wallet-payment", JSON.stringify({ Type: "Mutation", Channel: "data/wallet-payment", Data: N183 }), Ws);
      break;
    }
    case "CreateWalletPaymentWalletLink": {
      const I184 = Msg.Data?.Id ?? crypto.randomUUID();
      const N184 = { ...Msg.Data, Id: I184 };
      await GitHubWrite(Env, "data/wallet-payment/" + I184 + ".json", JSON.stringify(N184, null, 2), "Create data/wallet-payment");
      Reply(Ws, Msg, N184);
      BroadcastToChannel("data/wallet-payment", JSON.stringify({ Type: "Mutation", Channel: "data/wallet-payment", Data: N184 }), Ws);
      break;
    }
    case "WalletPaymentWalletLinkExecute": {
      const E185 = await GitHubRead(Env, "data/wallet-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!E185) { ReplyError(Ws, Msg, "Not found"); break; }
      const U185 = { ...JSON.parse(E185.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/wallet-payment/" + Msg.Data?.Id + ".json", JSON.stringify(U185, null, 2), "WalletPaymentWalletLinkExecute", E185.Sha);
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/wallet-payment", JSON.stringify({ Type: "Mutation", Channel: "data/wallet-payment", Data: U185 }), Ws);
      break;
    }
    case "ListWalletPaymentWalletLinkById": {
      const R186 = await GitHubRead(Env, "data/wallet-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!R186) { ReplyError(Ws, Msg, "Not found"); break; }
      Reply(Ws, Msg, JSON.parse(R186.Content));
      break;
    }
    case "DeleteWalletPaymentWalletLinkById": {
      const D187 = await GitHubRead(Env, "data/wallet-payment/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D187) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/wallet-payment/" + Msg.Data?.Id + ".json", D187.Sha, "Delete data/wallet-payment");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/wallet-payment", JSON.stringify({ Type: "Deletion", Channel: "data/wallet-payment", Id: Msg.Data?.Id }), Ws);
      break;
    }
    // WebhookEndpoints
    case "CreateWebhookRoot": {
      const I188 = Msg.Data?.Id ?? crypto.randomUUID();
      const N188 = { ...Msg.Data, Id: I188 };
      await GitHubWrite(Env, "data/webhook/" + I188 + ".json", JSON.stringify(N188, null, 2), "Create data/webhook");
      Reply(Ws, Msg, N188);
      BroadcastToChannel("data/webhook", JSON.stringify({ Type: "Mutation", Channel: "data/webhook", Data: N188 }), Ws);
      break;
    }
    case "ListWebhookRoot": {
      const L189 = await GitHubList(Env, "data/webhook");
      Reply(Ws, Msg, L189);
      break;
    }
    case "UpdateWebhookWebhookById": {
      const C190 = await GitHubRead(Env, "data/webhook/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!C190) { ReplyError(Ws, Msg, "Not found"); break; }
      const M190 = { ...JSON.parse(C190.Content), ...Msg.Data };
      await GitHubWrite(Env, "data/webhook/" + Msg.Data?.Id + ".json", JSON.stringify(M190, null, 2), "Update data/webhook", C190.Sha);
      Reply(Ws, Msg, M190);
      BroadcastToChannel("data/webhook", JSON.stringify({ Type: "Mutation", Channel: "data/webhook", Data: M190 }), Ws);
      break;
    }
    case "DeleteWebhookWebhookById": {
      const D191 = await GitHubRead(Env, "data/webhook/" + (Msg.Data?.Id ?? EmptyStr) + ".json");
      if (!D191) { ReplyError(Ws, Msg, "Not found"); break; }
      await GitHubDelete(Env, "data/webhook/" + Msg.Data?.Id + ".json", D191.Sha, "Delete data/webhook");
      ReplyOk(Ws, Msg);
      BroadcastToChannel("data/webhook", JSON.stringify({ Type: "Deletion", Channel: "data/webhook", Id: Msg.Data?.Id }), Ws);
      break;
    }

    default:
      ReplyError(Ws, Msg, `Unknown message type: ${Msg.Type}`);
  }
}

const EmptyStr = "";
