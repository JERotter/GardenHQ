<template>
  <VCard >
        <VCardItem>
          <VCardTitle>Invitation Requests</VCardTitle>

          <!-- <template #append>
            <div class="me-n3">
              <VBtn icon size="x-small" variant="text" color="default">
                <VIcon size="24" icon="mdi-dots-vertical" />
              </VBtn>
            </div>
          </template> -->
        </VCardItem>

        <VCardText>
          <VList class="card-list">
            <VListItem v-for="data in salesByCountries" :key="data.country">
              <template #prepend>
                <VAvatar
                  size="40"
                  variant="tonal"
                  :color="data.color"
                  class="me-3"
                >
                  {{ data.abbr }}
                </VAvatar>
              </template>

              <VListItemTitle class="mb-1">
                <span class="text-sm font-weight-semibold">{{
                  data.amount
                }}</span>
                <VIcon
                  size="22"
                  :color="data.change.charAt(0) === '+' ? 'success' : 'error'"
                  class="mx-1"
                >
                  {{
                    data.change.charAt(0) === "+"
                      ? "mdi-chevron-up"
                      : "mdi-chevron-down"
                  }}
                </VIcon>
                <span
                  :class="`text-xs ${
                    data.change.charAt(0) === '+'
                      ? 'text-success'
                      : 'text-error'
                  }`"
                >
                  {{ data.change.slice(1) }}
                </span>
              </VListItemTitle>

              <VListItemSubtitle class="text-xs">
                {{ data.country }}
              </VListItemSubtitle>

              <template #append>
                <div>
                  <h4 class="font-weight-semibold">
                    {{ data.sales }}
                  </h4>
                  <span class="text-xs text-medium-emphasis">Sales</span>
                </div>
              </template>
            </VListItem>
          </VList>
        </VCardText>
      </VCard>
</template>

<script>
export default {
    data: () => ({
      salesByCountries: [
        {
          abbr: "New",
          amount: "$8,656k",
          country: "United states of america",
          change: "+25.8%",
          sales: "894k",
          color: "success",
        },
        {
          abbr: "Total",
          amount: "$2,415k",
          country: "United kingdom",
          change: "-6.2%",
          sales: "645k",
          color: "error",
        },
        
      ],
    }),
  };
  </script>
  
  <style lang="scss" scoped>
  .card-list {
    --v-card-list-gap: 1.5rem;
  }
  </style>
  