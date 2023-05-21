<template>
  <v-app>
    <appbar />
    <v-main>
      <v-container>
        <!-- form -->
      </v-container>
    </v-main>
    <v-footer app class="bg-brown-lighten-5 text-center d-flex flex-column">
      <div>
        <v-btn
          v-for="icon in icons"
          :key="icon"
          class="mx-4"
          :icon="icon"
          variant="text"
        ></v-btn>
      </div>

      <v-divider></v-divider>

      <div>{{ new Date().getFullYear() }} — <strong>Vuetify</strong></div>
    </v-footer>
  </v-app>
</template>

<script>
import appbar from "../components/Appbar.vue";

export default {
  components: { appbar },
  data: () => ({
    icons: ["mdi-facebook", "mdi-twitter", "mdi-linkedin", "mdi-instagram"],
  }),
};
</script>

<style></style>
