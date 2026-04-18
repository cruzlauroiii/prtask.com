resource "cloudflare_queue" "prtask_r2_events" {
  account_id = var.cloudflare_account_id
  name       = "prtask-r2-events"
}

# R2 event notification rule: fires on db/prtask.json writes
# Configured via wrangler CLI since Terraform provider lacks native support:
#   npx wrangler r2 bucket notification create prtask-data \
#     --event-type object-create \
#     --prefix "db/prtask.json" \
#     --queue prtask-r2-events
# Or run: scripts/setup-r2-event-notification.sh
