<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <v-footer class="bg-brown-lighten-5 text-center d-flex flex-column" app>
    <div>
      <v-btn
        v-for="icon in icons"
        :key="icon"
        class="mx-4"
        :icon="icon"
        variant="text"
      ></v-btn>
    </div>

    <div class="pt-0">Garden HQ</div>

    <v-divider></v-divider>

    <div>{{ new Date().getFullYear() }} — <strong>Vuetify</strong></div>
  </v-footer>
</template>

<script>
export default {
  data: () => ({
    icons: ["mdi-facebook", "mdi-twitter", "mdi-linkedin", "mdi-instagram"],
  }),
};
</script>
