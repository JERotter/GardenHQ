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
        :href="getLink(icon)"
      ></v-btn>
    </div>

    <div class="pt-0">
      <p>
        Already have an invitation code?
        <a href="/create">Create Your Account!</a>
      </p>
    </div>

    <v-divider></v-divider>

    <div>{{ new Date().getFullYear() }} — <strong>Garden HQ</strong></div>
  </v-footer>
</template>

<script>
export default {
  data: () => ({
    icons: [
      "mdi-facebook",
      "mdi-twitter",
      "mdi-linkedin",
      "mdi-instagram",
      "mdi-email",
    ],
  }),
  methods: {
    getLink(icon) {
      // Return the appropriate link based on the icon
      if (icon === "mdi-facebook") {
        return "https://www.facebook.com/";
      } else if (icon === "mdi-twitter") {
        return "https://twitter.com/";
      } else if (icon === "mdi-linkedin") {
        return "https://www.linkedin.com/";
      } else if (icon === "mdi-instagram") {
        return "https://www.instagram.com/";
      } else if (icon === "mdi-email") {
        return "/contact";
      }
    },
  },
};
</script>
