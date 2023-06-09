<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <v-card app >
      <v-app-bar
        color="teal-darken-4"
        image="../assets/images/vegetables.jpeg "
      >
        <template v-slot:image>
          <v-img
            gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
          ></v-img>
        </template>

        <v-app-bar-title
          ><a href="/" style="text-decoration: none; color: white"
            >Garden HQ</a
          ></v-app-bar-title
        >

        <v-spacer></v-spacer>

        <v-btn icon to="/dashboard" link>
          <v-icon>mdi-login</v-icon>
        </v-btn>
      </v-app-bar>
    </v-card>
</template>

<script>
export default {};
</script>

<style>
  .app {
    position: relative;
  }

  .appbar {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    z-index: 1000;
  }
</style>
