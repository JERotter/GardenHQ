<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <v-card>
  <v-app-bar 
      color="teal-darken-4"
      image="../assets/images/vegetables.jpeg "
    >
      <template v-slot:image>
        <v-img
          gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
        ></v-img>
      </template>

      <v-app-bar-title><a href="/" style="text-decoration: none; color: white">Garden HQ</a></v-app-bar-title>

       <v-spacer></v-spacer>

      <v-btn icon>
            <v-icon>mdi-magnify</v-icon>
          </v-btn> 

       <v-btn icon to="/dashboard" link>
        <v-icon>mdi-view-dashboard</v-icon>s
      </v-btn> 

       <v-btn icon>
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn> 
    </v-app-bar> 
</v-card>

</template>

<script>
export default {

}
</script>

<style>

</style>